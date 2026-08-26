#!/usr/bin/env bash

set -euo pipefail

if [[ "$#" != 1 ]]; then
  echo "Usage: eng/test-release-packages.sh <validated-release-artifact-directory>" >&2
  exit 2
fi

script_directory="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
repository_root="$(cd -- "$script_directory/.." && pwd)"
fixture_directory="$(cd -- "$1" && pwd)"
temporary_directory="$(mktemp -d "${TMPDIR:-/tmp}/pdfcarton-release-package-tests.XXXXXX")"
trap 'rm -rf "$temporary_directory"' EXIT

fake_bin="$temporary_directory/bin"
command_log="$temporary_directory/dotnet.log"
capture_directory="$temporary_directory/capture"
mkdir -p "$fake_bin" "$capture_directory"

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
  case "$project" in
    *DripSharp.PdfCarton.IO.csproj)
      package_id="DripSharp.PdfCarton.IO"
      ;;
    *DripSharp.PdfCarton.Fonts.csproj)
      package_id="DripSharp.PdfCarton.Fonts"
      ;;
    *DripSharp.PdfCarton.Xmp.csproj)
      package_id="DripSharp.PdfCarton.Xmp"
      ;;
    *DripSharp.PdfCarton.Preflight.csproj)
      package_id="DripSharp.PdfCarton.Preflight"
      ;;
    *DripSharp.PdfCarton.csproj)
      package_id="DripSharp.PdfCarton"
      ;;
    *)
      exit 24
      ;;
  esac
  for archive in \
    "$PDFCARTON_TEST_FIXTURE_DIRECTORY/$package_id."*.nupkg \
    "$PDFCARTON_TEST_FIXTURE_DIRECTORY/$package_id."*.snupkg; do
    [[ -f "$archive" ]] || continue
    cp "$archive" "$output/"
  done
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
    PDFCARTON_TEST_FIXTURE_DIRECTORY="$fixture_directory" \
    "$@"
}

: > "$command_log"
packed_directory="$temporary_directory/packed"
run_with_fake_dotnet "$script_directory/pack-release.sh" "$packed_directory" >/dev/null

published_projects=(
  "src/DripSharp.PdfCarton.IO/DripSharp.PdfCarton.IO.csproj"
  "src/DripSharp.PdfCarton.Fonts/DripSharp.PdfCarton.Fonts.csproj"
  "src/DripSharp.PdfCarton.Xmp/DripSharp.PdfCarton.Xmp.csproj"
  "src/DripSharp.PdfCarton/DripSharp.PdfCarton.csproj"
  "src/DripSharp.PdfCarton.Preflight/DripSharp.PdfCarton.Preflight.csproj"
)
for project in "${published_projects[@]}"; do
  [[ "$(grep -Fc "pack $project " "$command_log")" == 1 ]] ||
    fail "$project was not packed exactly once."
done
grep -Fq -- '--configuration Release --no-build --no-restore --output' "$command_log" ||
  fail "Release packing did not reuse the verified build."

consumer_project="$capture_directory/PdfCarton.ReleaseConsumer.csproj"
[[ "$(grep -Fc '<PackageReference Include="DripSharp.PdfCarton' "$consumer_project")" == 5 ]] ||
  fail "The external consumer does not reference all five PdfCarton packages."
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

symbol_package="$(find "$packed_directory" -maxdepth 1 -name 'DripSharp.PdfCarton*.snupkg' -print -quit)"
printf 'symbol package contents are intentionally outside this validator\n' > "$symbol_package"
: > "$command_log"
run_with_fake_dotnet \
  "$script_directory/validate-release-packages.sh" "$packed_directory" >/dev/null

for failing_command in restore build run; do
  : > "$command_log"
  if env \
    PATH="$fake_bin:$PATH" \
    PDFCARTON_TEST_CAPTURE_DIRECTORY="$capture_directory" \
    PDFCARTON_TEST_COMMAND_LOG="$command_log" \
    PDFCARTON_TEST_FIXTURE_DIRECTORY="$fixture_directory" \
    PDFCARTON_TEST_FAIL_COMMAND="$failing_command" \
    "$script_directory/validate-release-packages.sh" "$packed_directory" >/dev/null 2>&1; then
    fail "Package validation accepted a failing $failing_command command."
  fi
  grep -Fq "$failing_command " "$command_log" ||
    fail "The $failing_command failure was not exercised."
done

invalid_directory="$temporary_directory/invalid"
mkdir -p "$invalid_directory"
cp "$fixture_directory"/*.nupkg "$invalid_directory/"
python3 - "$invalid_directory" <<'PY'
import sys
import zipfile
from pathlib import Path

directory = Path(sys.argv[1])
archive = next(directory.glob("DripSharp.PdfCarton.Preflight.*.nupkg"))
replacement = archive.with_suffix(".invalid")
with zipfile.ZipFile(archive) as source, zipfile.ZipFile(replacement, "w") as target:
    for entry in source.infolist():
        contents = source.read(entry.filename)
        if entry.filename.endswith(".nuspec"):
            contents = contents.replace(
                b"<id>DripSharp.PdfCarton.Preflight</id>",
                b"<id>Unexpected.PdfCarton.Preflight</id>",
            )
        target.writestr(entry, contents)
replacement.replace(archive)
PY

: > "$command_log"
if run_with_fake_dotnet \
  "$script_directory/validate-release-packages.sh" "$invalid_directory" >/dev/null 2>&1; then
  fail "Package validation accepted incorrect essential NuGet metadata."
fi
[[ ! -s "$command_log" ]] || fail "Invalid package metadata reached the consumer."

echo "PdfCarton single-pack and external-consumer controls passed."
