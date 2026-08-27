#!/usr/bin/env bash

set -euo pipefail

script_directory="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
repository_root="$(cd -- "$script_directory/.." && pwd)"
cd "$repository_root"

case "${PDFCARTON_RELEASE_REDUCED_TESTS:-0}" in
  ""|0)
    reduced_tests=0
    ;;
  1)
    reduced_tests=1
    ;;
  *)
    echo "PDFCARTON_RELEASE_REDUCED_TESTS must be 0, 1, or unset." >&2
    exit 2
    ;;
esac

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

for project in "${production_projects[@]}"; do
  dotnet restore "$project" --no-dependencies
  dotnet build "$project" \
    --configuration Release \
    --no-restore \
    --no-incremental \
    --no-dependencies \
    -warnaserror
done

dotnet restore "$release_smoke_project" --no-dependencies
dotnet build "$release_smoke_project" \
  --configuration Release \
  --no-restore \
  --no-incremental \
  --no-dependencies \
  -warnaserror
dotnet test "$release_smoke_project" \
  --configuration Release \
  --no-restore \
  --no-build

dotnet restore "$complete_test_project" --no-dependencies
dotnet build "$complete_test_project" \
  --configuration Release \
  --no-restore \
  --no-incremental \
  --no-dependencies \
  -warnaserror

if [[ "$reduced_tests" == 1 ]]; then
  dotnet test "$complete_test_project" \
    --configuration Release \
    --no-restore \
    --no-build \
    --filter "$focused_consumer_filter"
  echo "Reduced PdfCarton release verification passed."
  echo "Omitted only the exhaustive adapted-upstream and fixture-integrity suites, together with the parent high-memory differential and corpus proof."
  exit 0
fi

dotnet test "$complete_test_project" \
  --configuration Release \
  --no-restore \
  --no-build
