#!/usr/bin/env python3

import argparse
import json
import shutil
import sys
import xml.etree.ElementTree as ET
import zipfile
from pathlib import Path, PurePosixPath


class ValidationError(RuntimeError):
    pass


PUBLIC_PACKAGE_ID = "DripSharp.PdfCarton"
TARGET_FRAMEWORK = "netstandard2.0"
DEPENDENCY_FRAMEWORK = ".NETStandard2.0"
COMPONENT_PACKAGE_IDS = (
    "DripSharp.PdfCarton.IO",
    "DripSharp.PdfCarton.Fonts",
    "DripSharp.PdfCarton.Xmp",
    "DripSharp.PdfCarton",
    "DripSharp.PdfCarton.Preflight",
)
PUBLIC_DEPENDENCIES = {
    "Microsoft.CSharp": "4.7.0",
    "Microsoft.Extensions.Logging.Abstractions": "10.0.0",
    "SkiaSharp": "4.150.1",
    "SkiaSharp.NativeAssets.Linux": "4.150.1",
    "System.Formats.Asn1": "10.0.0",
    "System.Memory": "4.6.3",
    "System.Security.Cryptography.Pkcs": "10.0.0",
    "System.Text.Encoding.CodePages": "10.0.0",
}


def require(condition, message):
    if not condition:
        raise ValidationError(message)


def project_properties(path):
    root = ET.parse(path).getroot()
    properties = {}
    for group in root.findall("PropertyGroup"):
        for child in group:
            if child.text and child.text.strip():
                properties[child.tag] = child.text.strip()
    return properties


def element_text(parent, name):
    element = parent.find(f"{{*}}{name}")
    require(element is not None and element.text, f"NuGet metadata is missing {name}")
    return element.text.strip()


def safe_archive_names(names, archive):
    lowered = set()
    for name in names:
        path = PurePosixPath(name)
        require(name and "\\" not in name, f"Unsafe archive path in {archive}: {name!r}")
        require(
            not path.is_absolute() and all(part not in ("", ".", "..") for part in path.parts),
            f"Unsafe archive path in {archive}: {name!r}",
        )
        folded = name.casefold()
        require(folded not in lowered, f"Repeated or case-colliding path in {archive}: {name}")
        lowered.add(folded)


def inspect_archive(path, version, expected_payloads, payload_suffix, archive_kind):
    require(path.is_file(), f"Missing {archive_kind}: {path.name}")
    with zipfile.ZipFile(path) as archive:
        entries = [entry for entry in archive.infolist() if not entry.is_dir()]
        names = [entry.filename for entry in entries]
        safe_archive_names(names, path)
        nuspecs = [name for name in names if name.casefold().endswith(".nuspec")]
        require(len(nuspecs) == 1, f"{archive_kind} must contain one nuspec")
        metadata = ET.fromstring(archive.read(nuspecs[0])).find("{*}metadata")
        require(metadata is not None, f"{archive_kind} nuspec has no metadata")
        require(
            element_text(metadata, "id") == PUBLIC_PACKAGE_ID,
            f"Expected package ID {PUBLIC_PACKAGE_ID}",
        )
        require(
            element_text(metadata, "version") == version,
            f"Expected {PUBLIC_PACKAGE_ID} version {version}",
        )

        dependencies = metadata.find("{*}dependencies")
        require(dependencies is not None, f"{archive_kind} has no dependency metadata")
        groups = dependencies.findall("{*}group")
        require(len(groups) == 1, f"{archive_kind} must have one dependency group")
        group = groups[0]
        require(
            group.get("targetFramework") == DEPENDENCY_FRAMEWORK,
            f"{archive_kind} must target {DEPENDENCY_FRAMEWORK} in its nuspec",
        )
        actual_dependencies = {}
        for dependency in group.findall("{*}dependency"):
            dependency_id = dependency.get("id")
            dependency_version = dependency.get("version")
            require(
                dependency_id and dependency_version,
                f"{archive_kind} has incomplete dependency metadata",
            )
            require(
                dependency_id not in actual_dependencies,
                f"{archive_kind} repeats dependency {dependency_id}",
            )
            actual_dependencies[dependency_id] = dependency_version
        require(
            actual_dependencies == PUBLIC_DEPENDENCIES,
            f"{archive_kind} dependencies differ: expected {PUBLIC_DEPENDENCIES}, "
            f"found {actual_dependencies}",
        )

        actual_payloads = {
            name
            for name in names
            if name.startswith(f"lib/{TARGET_FRAMEWORK}/")
            and name.casefold().endswith(payload_suffix)
        }
        require(
            actual_payloads == expected_payloads,
            f"{archive_kind} production payload differs: expected "
            f"{sorted(expected_payloads)}, found {sorted(actual_payloads)}",
        )


def stage_dependency_packages(project, feed, release_ids):
    assets_path = project.parent / "obj" / "project.assets.json"
    require(assets_path.is_file(), f"Restore assets are missing for {project}")
    with assets_path.open(encoding="utf-8-sig") as stream:
        assets = json.load(stream)

    package_folders = [Path(path) for path in assets.get("packageFolders", {})]
    require(package_folders, f"Restore assets have no package folders for {project}")

    for identity, library in assets.get("libraries", {}).items():
        if library.get("type") != "package":
            continue
        package_id, _, dependency_version = identity.partition("/")
        require(
            package_id and dependency_version,
            f"Malformed restored package identity: {identity}",
        )
        if package_id in release_ids:
            continue
        relative_directory = Path(library.get("path", identity.lower()))
        candidates = []
        for package_folder in package_folders:
            directory = package_folder / relative_directory
            if directory.is_dir():
                candidates.extend(
                    path
                    for path in directory.iterdir()
                    if path.is_file()
                    and path.name.casefold().endswith(".nupkg")
                    and not path.name.casefold().endswith(".symbols.nupkg")
                )
        require(
            len(candidates) == 1,
            f"Expected one restored archive for {package_id} {dependency_version}, found "
            f"{[str(path) for path in candidates]}",
        )
        destination = feed / candidates[0].name
        if not destination.exists():
            shutil.copy2(candidates[0], destination)


def main():
    parser = argparse.ArgumentParser(
        description="Inspect the single public PdfCarton bundle and stage a local feed."
    )
    parser.add_argument("--artifacts", required=True, type=Path)
    parser.add_argument("--feed", required=True, type=Path)
    parser.add_argument("--version-file", required=True, type=Path)
    parser.add_argument("--project", action="append", required=True, type=Path)
    args = parser.parse_args()

    require(args.artifacts.is_dir(), f"Artifact directory does not exist: {args.artifacts}")
    require(args.feed.is_dir(), f"Local feed does not exist: {args.feed}")
    require(
        len(args.project) == len(COMPONENT_PACKAGE_IDS),
        f"Expected {len(COMPONENT_PACKAGE_IDS)} PdfCarton projects, found {len(args.project)}",
    )

    projects = {}
    versions = set()
    for project in args.project:
        properties = project_properties(project)
        package_id = properties.get("PackageId")
        require(package_id in COMPONENT_PACKAGE_IDS, f"Unexpected PackageId in {project}")
        require(package_id not in projects, f"Repeated PdfCarton project: {package_id}")
        require(properties.get("AssemblyName") == package_id, f"Unexpected AssemblyName in {project}")
        require(
            properties.get("TargetFramework") == TARGET_FRAMEWORK,
            f"Unexpected TargetFramework in {project}",
        )
        version = properties.get("Version")
        require(version, f"Version is missing from {project}")
        versions.add(version)
        projects[package_id] = project

    require(
        set(projects) == set(COMPONENT_PACKAGE_IDS),
        f"PdfCarton projects differ: expected {sorted(COMPONENT_PACKAGE_IDS)}, "
        f"found {sorted(projects)}",
    )
    require(len(versions) == 1, f"PdfCarton project versions differ: {sorted(versions)}")
    version = versions.pop()
    package_path = args.artifacts / f"{PUBLIC_PACKAGE_ID}.{version}.nupkg"
    symbol_path = args.artifacts / f"{PUBLIC_PACKAGE_ID}.{version}.snupkg"
    expected_inventory = {package_path.name, symbol_path.name}
    actual_inventory = {path.name for path in args.artifacts.iterdir()}
    require(
        actual_inventory == expected_inventory,
        f"Public PdfCarton artifact inventory differs: expected {sorted(expected_inventory)}, "
        f"found {sorted(actual_inventory)}",
    )

    expected_assemblies = {
        f"lib/{TARGET_FRAMEWORK}/{package_id}.dll" for package_id in COMPONENT_PACKAGE_IDS
    }
    expected_pdbs = {
        f"lib/{TARGET_FRAMEWORK}/{package_id}.pdb" for package_id in COMPONENT_PACKAGE_IDS
    }
    inspect_archive(package_path, version, expected_assemblies, ".dll", "package")
    inspect_archive(symbol_path, version, expected_pdbs, ".pdb", "symbol package")

    shutil.copy2(package_path, args.feed / package_path.name)
    release_ids = set(COMPONENT_PACKAGE_IDS)
    for project in projects.values():
        stage_dependency_packages(project, args.feed, release_ids)

    args.version_file.write_text(version + "\n", encoding="utf-8")
    print(
        f"Public PdfCarton bundle passed: {PUBLIC_PACKAGE_ID} {version}; "
        f"assemblies {', '.join(COMPONENT_PACKAGE_IDS)}"
    )


if __name__ == "__main__":
    try:
        main()
    except (ValidationError, ET.ParseError, OSError, ValueError, zipfile.BadZipFile) as error:
        print(f"PdfCarton release package validation failed: {error}", file=sys.stderr)
        sys.exit(1)
