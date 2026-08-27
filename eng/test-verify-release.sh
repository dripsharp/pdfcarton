#!/usr/bin/env bash

set -euo pipefail

script_directory="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
temporary_directory="$(mktemp -d)"
trap 'rm -rf "$temporary_directory"' EXIT

fake_bin="$temporary_directory/bin"
command_log="$temporary_directory/dotnet.log"
mkdir -p "$fake_bin"

cat > "$fake_bin/dotnet" <<'EOF'
#!/usr/bin/env bash
set -euo pipefail
printf '%s\n' "$*" >> "$PDFCARTON_TEST_COMMAND_LOG"
if [[ "${PDFCARTON_TEST_FAIL_SMOKE:-0}" == 1 &&
      "$1" == test &&
      "$2" == tests/DripSharp.PdfCarton.ReleaseSmoke/DripSharp.PdfCarton.ReleaseSmoke.csproj ]]; then
  exit 23
fi
EOF
chmod +x "$fake_bin/dotnet"

fail() {
  echo "$1" >&2
  exit 1
}

require_command() {
  local expected="$1"
  grep -Fqx -- "$expected" "$command_log" ||
    fail "Missing command: $expected"
}

reject_command() {
  local unexpected="$1"
  if grep -Fqx -- "$unexpected" "$command_log"; then
    fail "Unexpected command: $unexpected"
  fi
}

reject_command_fragment() {
  local fragment="$1"
  if grep -Fq -- "$fragment" "$command_log"; then
    fail "Unexpected command containing: $fragment"
  fi
}

production_projects=(
  "src/DripSharp.PdfCarton.IO/DripSharp.PdfCarton.IO.csproj"
  "src/DripSharp.PdfCarton.Fonts/DripSharp.PdfCarton.Fonts.csproj"
  "src/DripSharp.PdfCarton.Xmp/DripSharp.PdfCarton.Xmp.csproj"
  "src/DripSharp.PdfCarton/DripSharp.PdfCarton.csproj"
  "src/DripSharp.PdfCarton.Preflight/DripSharp.PdfCarton.Preflight.csproj"
)
release_smoke_project="tests/DripSharp.PdfCarton.ReleaseSmoke/DripSharp.PdfCarton.ReleaseSmoke.csproj"
complete_test_project="tests/DripSharp.PdfCarton.Tests/DripSharp.PdfCarton.Tests.csproj"
focused_consumer_filter="FullyQualifiedName~DripSharp.PdfCarton.Tests.IoConsumerTests|FullyQualifiedName~DripSharp.PdfCarton.Tests.FontsConsumerTests|FullyQualifiedName~DripSharp.PdfCarton.Tests.XmpConsumerTests|FullyQualifiedName~DripSharp.PdfCarton.Tests.PdfConsumerTests|FullyQualifiedName~DripSharp.PdfCarton.Tests.PreflightConsumerTests"
common_build_arguments="--configuration Release --no-restore --no-incremental --no-dependencies -warnaserror"
common_test_arguments="--configuration Release --no-restore --no-build"

: > "$command_log"
env \
  PATH="$fake_bin:$PATH" \
  PDFCARTON_TEST_COMMAND_LOG="$command_log" \
  PDFCARTON_RELEASE_REDUCED_TESTS=1 \
  "$script_directory/verify-release.sh" >/dev/null

for project in "${production_projects[@]}"; do
  require_command "restore $project --no-dependencies"
  require_command "build $project $common_build_arguments"
done
require_command "restore $release_smoke_project --no-dependencies"
require_command "build $release_smoke_project $common_build_arguments"
require_command "test $release_smoke_project $common_test_arguments"
require_command "restore $complete_test_project --no-dependencies"
require_command "build $complete_test_project $common_build_arguments"
require_command "test $complete_test_project $common_test_arguments --filter $focused_consumer_filter"
reject_command "test $complete_test_project $common_test_arguments"

: > "$command_log"
if env \
  PATH="$fake_bin:$PATH" \
  PDFCARTON_TEST_COMMAND_LOG="$command_log" \
  PDFCARTON_TEST_FAIL_SMOKE=1 \
  PDFCARTON_RELEASE_REDUCED_TESTS=1 \
  "$script_directory/verify-release.sh" >/dev/null 2>&1; then
  fail "Reduced verification accepted a failing mandatory release smoke suite."
fi

require_command "test $release_smoke_project $common_test_arguments"
reject_command_fragment "DripSharp.PdfCarton.Tests"

: > "$command_log"
if env \
  PATH="$fake_bin:$PATH" \
  PDFCARTON_TEST_COMMAND_LOG="$command_log" \
  PDFCARTON_RELEASE_REDUCED_TESTS=all \
  "$script_directory/verify-release.sh" >/dev/null 2>&1; then
  fail "Reduced verification accepted a malformed mode selection."
fi
[[ ! -s "$command_log" ]] || fail "Malformed mode selection ran dotnet."

: > "$command_log"
env \
  PATH="$fake_bin:$PATH" \
  PDFCARTON_TEST_COMMAND_LOG="$command_log" \
  PDFCARTON_RELEASE_REDUCED_TESTS=0 \
  "$script_directory/verify-release.sh" >/dev/null
require_command "test $complete_test_project $common_test_arguments"

echo "PdfCarton release-verification controls passed."
