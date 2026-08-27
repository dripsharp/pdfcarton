#!/usr/bin/env python3

import argparse
import sys
import xml.etree.ElementTree as ET
import zipfile
from pathlib import Path, PurePosixPath


class BundleError(RuntimeError):
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


def require(condition, message):
    if not condition:
        raise BundleError(message)


def project_properties(path):
    root = ET.parse(path).getroot()
    properties = {}
    for group in root.findall("PropertyGroup"):
        for child in group:
            if child.text and child.text.strip():
                properties[child.tag] = child.text.strip()
    return properties


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


def archive_entries(path):
    require(path.is_file(), f"Missing component archive: {path}")
    with zipfile.ZipFile(path) as archive:
        infos = [entry for entry in archive.infolist() if not entry.is_dir()]
        names = [entry.filename for entry in infos]
        safe_archive_names(names, path)
        return {entry.filename: archive.read(entry) for entry in infos}


def metadata(entries, package_id, archive_kind):
    nuspecs = [name for name in entries if name.casefold().endswith(".nuspec")]
    require(len(nuspecs) == 1, f"{package_id} {archive_kind} must contain one nuspec")
    root = ET.fromstring(entries[nuspecs[0]])
    result = root.find("{*}metadata")
    require(result is not None, f"{package_id} {archive_kind} nuspec has no metadata")
    return nuspecs[0], root, result


def element_text(parent, name, package_id):
    element = parent.find(f"{{*}}{name}")
    require(element is not None and element.text, f"{package_id} is missing {name}")
    return element.text.strip()


def dependencies(parent, package_id):
    container = parent.find("{*}dependencies")
    require(container is not None, f"{package_id} has no dependency metadata")
    groups = container.findall("{*}group")
    require(len(groups) == 1, f"{package_id} must have one dependency group")
    require(
        groups[0].get("targetFramework") == DEPENDENCY_FRAMEWORK,
        f"{package_id} must target {DEPENDENCY_FRAMEWORK} in its nuspec",
    )
    result = {}
    for dependency in groups[0].findall("{*}dependency"):
        dependency_id = dependency.get("id")
        version = dependency.get("version")
        require(dependency_id and version, f"{package_id} has incomplete dependency metadata")
        require(dependency_id not in result, f"{package_id} repeats {dependency_id}")
        result[dependency_id] = version
    return result


def rewrite_dependencies(entries, package_id, external_dependencies, archive_kind):
    nuspec_name, root, parent = metadata(entries, package_id, archive_kind)
    container = parent.find("{*}dependencies")
    require(container is not None, f"{package_id} {archive_kind} has no dependencies")
    for child in list(container):
        container.remove(child)
    namespace = root.tag.partition("}")[0].lstrip("{") if root.tag.startswith("{") else ""
    if namespace:
        ET.register_namespace("", namespace)
        group_tag = f"{{{namespace}}}group"
        dependency_tag = f"{{{namespace}}}dependency"
    else:
        group_tag = "group"
        dependency_tag = "dependency"
    group = ET.SubElement(container, group_tag, {"targetFramework": DEPENDENCY_FRAMEWORK})
    for dependency_id, version in sorted(external_dependencies.items(), key=lambda item: item[0].casefold()):
        ET.SubElement(
            group,
            dependency_tag,
            {
                "id": dependency_id,
                "version": version,
                "exclude": "Build,Analyzers",
            },
        )
    entries[nuspec_name] = ET.tostring(root, encoding="utf-8", xml_declaration=True)


def add_entry(entries, name, contents, source):
    existing = entries.get(name)
    require(
        existing is None or existing == contents,
        f"Bundle entry {name} differs between the base package and {source}",
    )
    entries[name] = contents


def write_archive(path, entries):
    safe_archive_names(entries, path)
    with zipfile.ZipFile(path, "w", compression=zipfile.ZIP_DEFLATED, allowZip64=True) as archive:
        for name in sorted(entries, key=str.casefold):
            info = zipfile.ZipInfo(name, date_time=(1980, 1, 1, 0, 0, 0))
            info.compress_type = zipfile.ZIP_DEFLATED
            info.external_attr = 0o600 << 16
            archive.writestr(info, entries[name])


def component_archives(component_directory, version):
    expected = {
        f"{package_id}.{version}.{extension}"
        for package_id in COMPONENT_PACKAGE_IDS
        for extension in ("nupkg", "snupkg")
    }
    actual = {path.name for path in component_directory.iterdir() if path.is_file()}
    require(
        actual == expected,
        f"Component artifact inventory differs: expected {sorted(expected)}, found {sorted(actual)}",
    )
    return {
        package_id: {
            "package": component_directory / f"{package_id}.{version}.nupkg",
            "symbols": component_directory / f"{package_id}.{version}.snupkg",
        }
        for package_id in COMPONENT_PACKAGE_IDS
    }


def main():
    parser = argparse.ArgumentParser(
        description="Bundle the five proved PdfCarton components into one public package."
    )
    parser.add_argument("--components", required=True, type=Path)
    parser.add_argument("--artifacts", required=True, type=Path)
    parser.add_argument("--project", action="append", required=True, type=Path)
    args = parser.parse_args()

    require(args.components.is_dir(), f"Component directory does not exist: {args.components}")
    require(args.artifacts.is_dir(), f"Artifact directory does not exist: {args.artifacts}")
    require(not any(args.artifacts.iterdir()), f"Artifact directory must be empty: {args.artifacts}")
    require(
        len(args.project) == len(COMPONENT_PACKAGE_IDS),
        f"Expected {len(COMPONENT_PACKAGE_IDS)} component projects, found {len(args.project)}",
    )

    projects = {}
    versions = set()
    for project in args.project:
        properties = project_properties(project)
        package_id = properties.get("PackageId")
        require(package_id in COMPONENT_PACKAGE_IDS, f"Unexpected PackageId in {project}")
        require(package_id not in projects, f"Repeated component project: {package_id}")
        require(properties.get("AssemblyName") == package_id, f"AssemblyName differs in {project}")
        require(
            properties.get("TargetFramework") == TARGET_FRAMEWORK,
            f"TargetFramework differs in {project}",
        )
        require(properties.get("Version"), f"Version is missing from {project}")
        projects[package_id] = project
        versions.add(properties["Version"])
    require(set(projects) == set(COMPONENT_PACKAGE_IDS), "Component project inventory differs")
    require(len(versions) == 1, f"Component versions differ: {sorted(versions)}")
    version = versions.pop()
    archives = component_archives(args.components, version)

    package_entries = archive_entries(archives[PUBLIC_PACKAGE_ID]["package"])
    symbol_entries = archive_entries(archives[PUBLIC_PACKAGE_ID]["symbols"])
    external_dependencies = {}
    component_ids = set(COMPONENT_PACKAGE_IDS)
    for package_id in COMPONENT_PACKAGE_IDS:
        component_package = archive_entries(archives[package_id]["package"])
        component_symbols = archive_entries(archives[package_id]["symbols"])
        for entries, archive_kind in (
            (component_package, "package"),
            (component_symbols, "symbol package"),
        ):
            _, _, parent = metadata(entries, package_id, archive_kind)
            require(element_text(parent, "id", package_id) == package_id, f"Unexpected ID for {package_id}")
            require(element_text(parent, "version", package_id) == version, f"Unexpected version for {package_id}")

        for dependency_id, dependency_version in dependencies(
            metadata(component_package, package_id, "package")[2], package_id
        ).items():
            if dependency_id in component_ids:
                require(
                    dependency_version == version,
                    f"{package_id} has non-exact internal dependency {dependency_id} {dependency_version}",
                )
                continue
            existing = external_dependencies.get(dependency_id)
            require(
                existing is None or existing == dependency_version,
                f"External dependency {dependency_id} has conflicting versions",
            )
            external_dependencies[dependency_id] = dependency_version

        assembly_entry = f"lib/{TARGET_FRAMEWORK}/{package_id}.dll"
        pdb_entry = f"lib/{TARGET_FRAMEWORK}/{package_id}.pdb"
        require(assembly_entry in component_package, f"{package_id} package has no {assembly_entry}")
        require(pdb_entry in component_symbols, f"{package_id} symbol package has no {pdb_entry}")
        if package_id != PUBLIC_PACKAGE_ID:
            add_entry(package_entries, assembly_entry, component_package[assembly_entry], package_id)
            add_entry(symbol_entries, pdb_entry, component_symbols[pdb_entry], package_id)

    rewrite_dependencies(
        package_entries, PUBLIC_PACKAGE_ID, external_dependencies, "package"
    )
    rewrite_dependencies(
        symbol_entries, PUBLIC_PACKAGE_ID, external_dependencies, "symbol package"
    )
    package_path = args.artifacts / f"{PUBLIC_PACKAGE_ID}.{version}.nupkg"
    symbol_path = args.artifacts / f"{PUBLIC_PACKAGE_ID}.{version}.snupkg"
    write_archive(package_path, package_entries)
    write_archive(symbol_path, symbol_entries)
    print(
        f"Bundled {', '.join(COMPONENT_PACKAGE_IDS)} into "
        f"{package_path.name} and {symbol_path.name}"
    )


if __name__ == "__main__":
    try:
        main()
    except (BundleError, ET.ParseError, OSError, ValueError, zipfile.BadZipFile) as error:
        print(f"PdfCarton release package bundling failed: {error}", file=sys.stderr)
        sys.exit(1)
