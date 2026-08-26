#!/usr/bin/env bash

set -euo pipefail

if [[ "$#" != 1 ]]; then
  echo "Usage: eng/pack-release.sh <empty-release-artifact-directory>" >&2
  exit 2
fi

script_directory="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
repository_root="$(cd -- "$script_directory/.." && pwd)"
artifact_directory="$1"

if [[ -e "$artifact_directory" && ! -d "$artifact_directory" ]]; then
  echo "Release artifact path is not a directory: $artifact_directory" >&2
  exit 2
fi
mkdir -p "$artifact_directory"
if [[ -n "$(find "$artifact_directory" -mindepth 1 -maxdepth 1 -print -quit)" ]]; then
  echo "Release artifact directory must be empty: $artifact_directory" >&2
  exit 2
fi
artifact_directory="$(cd -- "$artifact_directory" && pwd)"

cd "$repository_root"
published_projects=(
  "src/DripSharp.PdfCarton.IO/DripSharp.PdfCarton.IO.csproj"
  "src/DripSharp.PdfCarton.Fonts/DripSharp.PdfCarton.Fonts.csproj"
  "src/DripSharp.PdfCarton.Xmp/DripSharp.PdfCarton.Xmp.csproj"
  "src/DripSharp.PdfCarton/DripSharp.PdfCarton.csproj"
  "src/DripSharp.PdfCarton.Preflight/DripSharp.PdfCarton.Preflight.csproj"
)
for project in "${published_projects[@]}"; do
  dotnet pack "$project" \
    --configuration Release \
    --no-build \
    --no-restore \
    --output "$artifact_directory"
done

"$script_directory/validate-release-packages.sh" "$artifact_directory"
