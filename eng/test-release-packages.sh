#!/usr/bin/env bash

set -euo pipefail

if [[ "$#" != 0 ]]; then
  echo "Usage: eng/test-release-packages.sh" >&2
  exit 2
fi

script_directory="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
repository_root="$(cd -- "$script_directory/.." && pwd)"
temporary_directory="$(mktemp -d "${TMPDIR:-/tmp}/pdfcarton-release-package-tests.XXXXXX")"
trap 'rm -rf "$temporary_directory"' EXIT

fake_bin="$temporary_directory/bin"
command_log="$temporary_directory/dotnet.log"
capture_directory="$temporary_directory/capture"
component_factory="$temporary_directory/create-component-package.py"
mkdir -p "$fake_bin" "$capture_directory"

cat > "$component_factory" <<'PY'
import sys
import xml.etree.ElementTree as ET
import zipfile
from pathlib import Path

project = Path(sys.argv[1])
output = Path(sys.argv[2])
properties = {}
for group in ET.parse(project).getroot().findall("PropertyGroup"):
    for child in group:
        if child.text and child.text.strip():
            properties[child.tag] = child.text.strip()

package_id = properties["PackageId"]
version = properties["Version"]
dependencies = {
    "DripSharp.PdfCarton.IO": {
        "Microsoft.CSharp": "4.7.0",
        "Microsoft.Extensions.Logging.Abstractions": "10.0.0",
        "System.Memory": "4.6.3",
        "System.Text.Encoding.CodePages": "10.0.0",
    },
    "DripSharp.PdfCarton.Fonts": {
        "DripSharp.PdfCarton.IO": version,
        "Microsoft.CSharp": "4.7.0",
        "Microsoft.Extensions.Logging.Abstractions": "10.0.0",
        "SkiaSharp": "4.150.1",
        "SkiaSharp.NativeAssets.Linux": "4.150.1",
        "System.Formats.Asn1": "10.0.0",
        "System.Memory": "4.6.3",
        "System.Text.Encoding.CodePages": "10.0.0",
    },
    "DripSharp.PdfCarton.Xmp": {
        "Microsoft.CSharp": "4.7.0",
        "Microsoft.Extensions.Logging.Abstractions": "10.0.0",
        "System.Memory": "4.6.3",
        "System.Text.Encoding.CodePages": "10.0.0",
    },
    "DripSharp.PdfCarton": {
        "DripSharp.PdfCarton.Fonts": version,
        "DripSharp.PdfCarton.IO": version,
        "Microsoft.CSharp": "4.7.0",
        "Microsoft.Extensions.Logging.Abstractions": "10.0.0",
        "SkiaSharp": "4.150.1",
        "System.Memory": "4.6.3",
        "System.Security.Cryptography.Pkcs": "10.0.0",
        "System.Text.Encoding.CodePages": "10.0.0",
    },
    "DripSharp.PdfCarton.Preflight": {
        "DripSharp.PdfCarton": version,
        "DripSharp.PdfCarton.Xmp": version,
        "Microsoft.CSharp": "4.7.0",
        "Microsoft.Extensions.Logging.Abstractions": "10.0.0",
        "SkiaSharp": "4.150.1",
        "System.Memory": "4.6.3",
        "System.Text.Encoding.CodePages": "10.0.0",
    },
}[package_id]

dependency_xml = "".join(
    f'<dependency id="{dependency_id}" version="{dependency_version}" exclude="Build,Analyzers" />'
    for dependency_id, dependency_version in dependencies.items()
)
nuspec = (
    '<?xml version="1.0" encoding="utf-8"?>'
    '<package xmlns="http://schemas.microsoft.com/packaging/2013/05/nuspec.xsd">'
    f'<metadata><id>{package_id}</id><version>{version}</version>'
    '<dependencies><group targetFramework=".NETStandard2.0">'
    f'{dependency_xml}</group></dependencies></metadata></package>'
).encode()

output.mkdir(parents=True, exist_ok=True)
with zipfile.ZipFile(output / f"{package_id}.{version}.nupkg", "w") as archive:
    archive.writestr(f"{package_id}.nuspec", nuspec)
    archive.writestr(f"lib/netstandard2.0/{package_id}.dll", f"assembly:{package_id}")
with zipfile.ZipFile(output / f"{package_id}.{version}.snupkg", "w") as archive:
    archive.writestr(f"{package_id}.nuspec", nuspec)
    archive.writestr(f"lib/netstandard2.0/{package_id}.pdb", f"symbols:{package_id}")
PY

cat > "$fake_bin/dotnet" <<'EOF'
#!/usr/bin/env bash
set -euo pipefail

printf '%s\n' "$*" >> "$PDFCARTON_TEST_COMMAND_LOG"
command="$1"

if [[ "$command" == pack ]]; then
  project="$2"
  output=""
  previous=""
  for argument in "$@"; do
    if [[ "$previous" == --output ]]; then
      output="$argument"
    fi
    previous="$argument"
  done
  python3 "$PDFCARTON_TEST_COMPONENT_FACTORY" "$project" "$output"
fi

if [[ "$command" == restore ]]; then
  project="$2"
  cp "$project" "$PDFCARTON_TEST_CAPTURE_DIRECTORY/PdfCarton.ReleaseConsumer.csproj"
  cp "$(dirname -- "$project")/Program.cs" "$PDFCARTON_TEST_CAPTURE_DIRECTORY/Program.cs"
  printf '%s\n' "$project" > "$PDFCARTON_TEST_CAPTURE_DIRECTORY/project-path.txt"
  previous=""
  for argument in "$@"; do
    if [[ "$previous" == --configfile ]]; then
      cp "$argument" "$PDFCARTON_TEST_CAPTURE_DIRECTORY/NuGet.Config"
    fi
    previous="$argument"
  done
fi

if [[ "${PDFCARTON_TEST_FAIL_COMMAND:-}" == "$command" ]]; then
  exit 23
fi
EOF
chmod +x "$fake_bin/dotnet"

fail() {
  echo "$1" >&2
  exit 1
}

run_with_fake_dotnet() {
  env \
    PATH="$fake_bin:$PATH" \
    PDFCARTON_TEST_CAPTURE_DIRECTORY="$capture_directory" \
    PDFCARTON_TEST_COMMAND_LOG="$command_log" \
    PDFCARTON_TEST_COMPONENT_FACTORY="$component_factory" \
    "$@"
}

: > "$command_log"
packed_directory="$temporary_directory/packed"
run_with_fake_dotnet "$script_directory/pack-release.sh" "$packed_directory" >/dev/null

component_projects=(
  "src/DripSharp.PdfCarton.IO/DripSharp.PdfCarton.IO.csproj"
  "src/DripSharp.PdfCarton.Fonts/DripSharp.PdfCarton.Fonts.csproj"
  "src/DripSharp.PdfCarton.Xmp/DripSharp.PdfCarton.Xmp.csproj"
  "src/DripSharp.PdfCarton/DripSharp.PdfCarton.csproj"
  "src/DripSharp.PdfCarton.Preflight/DripSharp.PdfCarton.Preflight.csproj"
)
for project in "${component_projects[@]}"; do
  [[ "$(grep -Fc "pack $project " "$command_log")" == 1 ]] ||
    fail "$project was not packed exactly once as an internal bundle component."
done
grep -Fq -- '--configuration Release --no-build --no-restore --output' "$command_log" ||
  fail "Release packing did not reuse the verified build."

expected_package="$packed_directory/DripSharp.PdfCarton.3.0.8-alpha.2.nupkg"
expected_symbols="$packed_directory/DripSharp.PdfCarton.3.0.8-alpha.2.snupkg"
[[ -f "$expected_package" && -f "$expected_symbols" ]] ||
  fail "The public PdfCarton package and symbol package were not produced."
[[ "$(find "$packed_directory" -mindepth 1 -maxdepth 1 -type f | wc -l | tr -d ' ')" == 2 ]] ||
  fail "The public artifact directory does not contain exactly one package pair."
if find "$packed_directory" -mindepth 1 -maxdepth 1 -name 'DripSharp.PdfCarton.IO.*' -print -quit |
  grep -q .; then
  fail "An internal PdfCarton component escaped into the public artifact inventory."
fi

consumer_project="$capture_directory/PdfCarton.ReleaseConsumer.csproj"
[[ "$(grep -Fc '<PackageReference Include="DripSharp.PdfCarton"' "$consumer_project")" == 1 ]] ||
  fail "The external consumer does not reference the public PdfCarton bundle exactly once."
[[ "$(grep -Fc '<PackageReference Include="DripSharp.PdfCarton' "$consumer_project")" == 1 ]] ||
  fail "The external consumer references an internal PdfCarton component package."
if grep -Fq '<ProjectReference' "$consumer_project"; then
  fail "The external consumer contains a project reference."
fi
for usage in \
  'using DripSharp.PdfCarton;' \
  'using DripSharp.PdfCarton.Fonts.Util;' \
  'using DripSharp.PdfCarton.IO;' \
  'using DripSharp.PdfCarton.Preflight;' \
  'using DripSharp.PdfCarton.Xmp.Xml;'; do
  grep -Fq "$usage" "$capture_directory/Program.cs" ||
    fail "The external consumer is missing $usage"
done
for assembly in \
  DripSharp.PdfCarton.IO \
  DripSharp.PdfCarton.Fonts \
  DripSharp.PdfCarton.Xmp \
  DripSharp.PdfCarton \
  DripSharp.PdfCarton.Preflight; do
  grep -Fq "Assembly.GetName().Name == \"$assembly\"" "$capture_directory/Program.cs" ||
    fail "The external consumer does not prove the $assembly assembly load."
done
grep -Fq '<clear />' "$capture_directory/NuGet.Config" ||
  fail "The external consumer did not clear inherited package sources."
if grep -Fq 'nuget.org' "$capture_directory/NuGet.Config"; then
  fail "The external consumer retained a network package source."
fi
consumer_path="$(<"$capture_directory/project-path.txt")"
case "$consumer_path" in
  "$repository_root/"*)
    fail "The external consumer was created inside the repository."
    ;;
esac

for failing_command in restore build run; do
  : > "$command_log"
  if env \
    PATH="$fake_bin:$PATH" \
    PDFCARTON_TEST_CAPTURE_DIRECTORY="$capture_directory" \
    PDFCARTON_TEST_COMMAND_LOG="$command_log" \
    PDFCARTON_TEST_COMPONENT_FACTORY="$component_factory" \
    PDFCARTON_TEST_FAIL_COMMAND="$failing_command" \
    "$script_directory/validate-release-packages.sh" "$packed_directory" >/dev/null 2>&1; then
    fail "Package validation accepted a failing $failing_command command."
  fi
  grep -Fq "$failing_command " "$command_log" ||
    fail "The $failing_command failure was not exercised."
done

invalid_inventory="$temporary_directory/invalid-inventory"
mkdir -p "$invalid_inventory"
cp "$packed_directory"/* "$invalid_inventory/"
: > "$invalid_inventory/DripSharp.PdfCarton.IO.3.0.8-alpha.2.nupkg"
: > "$command_log"
if run_with_fake_dotnet \
  "$script_directory/validate-release-packages.sh" "$invalid_inventory" >/dev/null 2>&1; then
  fail "Package validation accepted an internal component release artifact."
fi
[[ ! -s "$command_log" ]] || fail "Invalid public inventory reached the consumer."

invalid_symbols="$temporary_directory/invalid-symbols"
mkdir -p "$invalid_symbols"
cp "$packed_directory"/* "$invalid_symbols/"
python3 - "$invalid_symbols/DripSharp.PdfCarton.3.0.8-alpha.2.snupkg" <<'PY'
import sys
import zipfile

with zipfile.ZipFile(sys.argv[1], "a") as archive:
    archive.writestr("lib/netstandard2.0/Unexpected.PdfCarton.pdb", b"unexpected")
PY
: > "$command_log"
if run_with_fake_dotnet \
  "$script_directory/validate-release-packages.sh" "$invalid_symbols" >/dev/null 2>&1; then
  fail "Package validation accepted an unexpected public symbol payload."
fi
[[ ! -s "$command_log" ]] || fail "Invalid symbol inventory reached the consumer."

invalid_metadata="$temporary_directory/invalid-metadata"
mkdir -p "$invalid_metadata"
cp "$packed_directory"/* "$invalid_metadata/"
python3 - "$invalid_metadata/DripSharp.PdfCarton.3.0.8-alpha.2.nupkg" <<'PY'
import sys
import zipfile
from pathlib import Path

archive = Path(sys.argv[1])
replacement = archive.with_suffix(".invalid")
with zipfile.ZipFile(archive) as source, zipfile.ZipFile(replacement, "w") as target:
    for entry in source.infolist():
        contents = source.read(entry.filename)
        if entry.filename.endswith(".nuspec"):
            contents = contents.replace(
                b"<id>DripSharp.PdfCarton</id>",
                b"<id>Unexpected.PdfCarton</id>",
            )
        target.writestr(entry, contents)
replacement.replace(archive)
PY

: > "$command_log"
if run_with_fake_dotnet \
  "$script_directory/validate-release-packages.sh" "$invalid_metadata" >/dev/null 2>&1; then
  fail "Package validation accepted incorrect public NuGet metadata."
fi
[[ ! -s "$command_log" ]] || fail "Invalid package metadata reached the consumer."

echo "PdfCarton one-bundle inventory and external-consumer controls passed."
