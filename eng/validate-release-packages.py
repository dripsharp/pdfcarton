#!/usr/bin/env python3

import argparse
import json
import shutil
import sys
import xml.etree.ElementTree as ET
import zipfile
from pathlib import Path


class ValidationError(RuntimeError):
    pass


PACKAGE_CONTRACTS = {
    "DripSharp.PdfCarton.IO": {
        "assembly": "DripSharp.PdfCarton.IO.dll",
        "dependencies": {
            "Microsoft.CSharp": "4.7.0",
            "Microsoft.Extensions.Logging.Abstractions": "10.0.0",
            "System.Memory": "4.6.3",
            "System.Text.Encoding.CodePages": "10.0.0",
        },
    },
    "DripSharp.PdfCarton.Fonts": {
        "assembly": "DripSharp.PdfCarton.Fonts.dll",
        "dependencies": {
            "DripSharp.PdfCarton.IO": None,
            "Microsoft.CSharp": "4.7.0",
            "Microsoft.Extensions.Logging.Abstractions": "10.0.0",
            "SkiaSharp": "4.150.1",
            "SkiaSharp.NativeAssets.Linux": "4.150.1",
            "System.Formats.Asn1": "10.0.0",
            "System.Memory": "4.6.3",
            "System.Text.Encoding.CodePages": "10.0.0",
        },
    },
    "DripSharp.PdfCarton.Xmp": {
        "assembly": "DripSharp.PdfCarton.Xmp.dll",
        "dependencies": {
            "Microsoft.CSharp": "4.7.0",
            "Microsoft.Extensions.Logging.Abstractions": "10.0.0",
            "System.Memory": "4.6.3",
            "System.Text.Encoding.CodePages": "10.0.0",
        },
    },
    "DripSharp.PdfCarton": {
        "assembly": "DripSharp.PdfCarton.dll",
        "dependencies": {
            "DripSharp.PdfCarton.Fonts": None,
            "DripSharp.PdfCarton.IO": None,
            "Microsoft.CSharp": "4.7.0",
            "Microsoft.Extensions.Logging.Abstractions": "10.0.0",
            "SkiaSharp": "4.150.1",
            "System.Memory": "4.6.3",
            "System.Security.Cryptography.Pkcs": "10.0.0",
            "System.Text.Encoding.CodePages": "10.0.0",
        },
    },
    "DripSharp.PdfCarton.Preflight": {
        "assembly": "DripSharp.PdfCarton.Preflight.dll",
        "dependencies": {
            "DripSharp.PdfCarton.Xmp": None,
            "DripSharp.PdfCarton": None,
            "Microsoft.CSharp": "4.7.0",
            "Microsoft.Extensions.Logging.Abstractions": "10.0.0",
            "SkiaSharp": "4.150.1",
            "System.Memory": "4.6.3",
            "System.Text.Encoding.CodePages": "10.0.0",
        },
    },
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


def inspect_package(artifacts, package_id, version, contract):
    archive_path = artifacts / f"{package_id}.{version}.nupkg"
    require(archive_path.is_file(), f"Missing release package: {archive_path.name}")

    with zipfile.ZipFile(archive_path) as archive:
        names = archive.namelist()
        nuspecs = [name for name in names if name.lower().endswith(".nuspec")]
        require(len(nuspecs) == 1, f"{package_id} must contain one nuspec")
        metadata = ET.fromstring(archive.read(nuspecs[0])).find("{*}metadata")
        require(metadata is not None, f"{package_id} nuspec has no metadata")

        actual_id = element_text(metadata, "id")
        actual_version = element_text(metadata, "version")
        require(actual_id == package_id, f"Expected package ID {package_id}, found {actual_id}")
        require(
            actual_version == version,
            f"Expected {package_id} version {version}, found {actual_version}",
        )

        dependencies = metadata.find("{*}dependencies")
        require(dependencies is not None, f"{package_id} has no dependency metadata")
        groups = dependencies.findall("{*}group")
        require(len(groups) == 1, f"{package_id} must have one dependency group")
        group = groups[0]
        require(
            group.get("targetFramework") == ".NETStandard2.0",
            f"{package_id} must target .NETStandard2.0 in its nuspec",
        )
        actual_dependencies = {}
        for dependency in group.findall("{*}dependency"):
            dependency_id = dependency.get("id")
            dependency_version = dependency.get("version")
            require(
                dependency_id and dependency_version,
                f"{package_id} has incomplete dependency metadata",
            )
            require(
                dependency_id not in actual_dependencies,
                f"{package_id} repeats dependency {dependency_id}",
            )
            actual_dependencies[dependency_id] = dependency_version

        expected_dependencies = {
            dependency_id: version if dependency_version is None else dependency_version
            for dependency_id, dependency_version in contract["dependencies"].items()
        }
        require(
            actual_dependencies == expected_dependencies,
            f"{package_id} dependencies differ: expected {expected_dependencies}, "
            f"found {actual_dependencies}",
        )

        production_assemblies = {
            name
            for name in names
            if name.startswith("lib/netstandard2.0/") and name.lower().endswith(".dll")
        }
        expected_assemblies = {f"lib/netstandard2.0/{contract['assembly']}"}
        require(
            production_assemblies == expected_assemblies,
            f"{package_id} production assemblies differ: expected "
            f"{sorted(expected_assemblies)}, found {sorted(production_assemblies)}",
        )

    return archive_path


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
                    and path.name.lower().endswith(".nupkg")
                    and not path.name.lower().endswith(".symbols.nupkg")
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
        description="Inspect bounded PdfCarton release package facts and stage a local feed."
    )
    parser.add_argument("--artifacts", required=True, type=Path)
    parser.add_argument("--feed", required=True, type=Path)
    parser.add_argument("--version-file", required=True, type=Path)
    parser.add_argument("--project", action="append", required=True, type=Path)
    args = parser.parse_args()

    require(args.artifacts.is_dir(), f"Artifact directory does not exist: {args.artifacts}")
    require(args.feed.is_dir(), f"Local feed does not exist: {args.feed}")
    require(
        len(args.project) == len(PACKAGE_CONTRACTS),
        f"Expected {len(PACKAGE_CONTRACTS)} PdfCarton projects, found {len(args.project)}",
    )

    projects = {}
    versions = set()
    for project in args.project:
        properties = project_properties(project)
        package_id = properties.get("PackageId")
        require(package_id in PACKAGE_CONTRACTS, f"Unexpected PackageId in {project}")
        require(package_id not in projects, f"Repeated PdfCarton project: {package_id}")
        require(
            properties.get("AssemblyName") == package_id,
            f"Unexpected AssemblyName in {project}",
        )
        require(
            properties.get("TargetFramework") == "netstandard2.0",
            f"Unexpected TargetFramework in {project}",
        )
        version = properties.get("Version")
        require(version, f"Version is missing from {project}")
        versions.add(version)
        projects[package_id] = project

    require(
        set(projects) == set(PACKAGE_CONTRACTS),
        f"PdfCarton projects differ: expected {sorted(PACKAGE_CONTRACTS)}, "
        f"found {sorted(projects)}",
    )
    require(len(versions) == 1, f"PdfCarton package versions differ: {sorted(versions)}")
    version = versions.pop()
    release_archives = []
    for package_id, contract in PACKAGE_CONTRACTS.items():
        release_archives.append(
            inspect_package(args.artifacts, package_id, version, contract)
        )

    for archive in release_archives:
        shutil.copy2(archive, args.feed / archive.name)
    release_ids = set(PACKAGE_CONTRACTS)
    for project in projects.values():
        stage_dependency_packages(project, args.feed, release_ids)

    args.version_file.write_text(version + "\n", encoding="utf-8")
    print(
        "Essential PdfCarton package metadata and production assemblies passed: "
        f"{', '.join(PACKAGE_CONTRACTS)} {version}"
    )


if __name__ == "__main__":
    try:
        main()
    except (ValidationError, ET.ParseError, OSError, ValueError, zipfile.BadZipFile) as error:
        print(f"PdfCarton release package validation failed: {error}", file=sys.stderr)
        sys.exit(1)
