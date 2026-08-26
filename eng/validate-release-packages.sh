#!/usr/bin/env bash

set -euo pipefail

if [[ "$#" != 1 ]]; then
  echo "Usage: eng/validate-release-packages.sh <release-artifact-directory>" >&2
  exit 2
fi

script_directory="$(cd -- "$(dirname -- "${BASH_SOURCE[0]}")" && pwd)"
repository_root="$(cd -- "$script_directory/.." && pwd)"
artifact_directory="$1"
if [[ ! -d "$artifact_directory" ]]; then
  echo "Release artifact directory does not exist: $artifact_directory" >&2
  exit 2
fi
artifact_directory="$(cd -- "$artifact_directory" && pwd)"

temporary_directory="$(mktemp -d "${TMPDIR:-/tmp}/pdfcarton-release-consumer.XXXXXX")"
trap 'rm -rf "$temporary_directory"' EXIT
temporary_directory="$(cd -- "$temporary_directory" && pwd -P)"

case "$temporary_directory/" in
  "$repository_root/"*)
    echo "The release consumer must be created outside the PdfCarton source tree." >&2
    exit 1
    ;;
esac

feed="$temporary_directory/feed"
consumer="$temporary_directory/consumer"
packages="$temporary_directory/packages"
dotnet_home="$temporary_directory/dotnet-home"
mkdir -p "$feed" "$consumer" "$packages" "$dotnet_home"

published_projects=(
  "$repository_root/src/DripSharp.PdfCarton.IO/DripSharp.PdfCarton.IO.csproj"
  "$repository_root/src/DripSharp.PdfCarton.Fonts/DripSharp.PdfCarton.Fonts.csproj"
  "$repository_root/src/DripSharp.PdfCarton.Xmp/DripSharp.PdfCarton.Xmp.csproj"
  "$repository_root/src/DripSharp.PdfCarton/DripSharp.PdfCarton.csproj"
  "$repository_root/src/DripSharp.PdfCarton.Preflight/DripSharp.PdfCarton.Preflight.csproj"
)
version_file="$temporary_directory/version.txt"
project_arguments=()
for project in "${published_projects[@]}"; do
  project_arguments+=(--project "$project")
done

python3 "$script_directory/validate-release-packages.py" \
  --artifacts "$artifact_directory" \
  --feed "$feed" \
  --version-file "$version_file" \
  "${project_arguments[@]}"
version="$(<"$version_file")"

cat > "$consumer/PdfCarton.ReleaseConsumer.csproj" <<EOF
<Project Sdk="Microsoft.NET.Sdk">
  <PropertyGroup>
    <OutputType>Exe</OutputType>
    <TargetFramework>net10.0</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
    <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
    <RollForward>Major</RollForward>
  </PropertyGroup>
  <ItemGroup>
    <PackageReference Include="DripSharp.PdfCarton.IO" Version="$version" />
    <PackageReference Include="DripSharp.PdfCarton.Fonts" Version="$version" />
    <PackageReference Include="DripSharp.PdfCarton.Xmp" Version="$version" />
    <PackageReference Include="DripSharp.PdfCarton" Version="$version" />
    <PackageReference Include="DripSharp.PdfCarton.Preflight" Version="$version" />
  </ItemGroup>
</Project>
EOF

cat > "$consumer/Program.cs" <<'EOF'
using System.Text;
using DripSharp.PdfCarton;
using DripSharp.PdfCarton.Fonts.Util;
using DripSharp.PdfCarton.IO;
using DripSharp.PdfCarton.Pdmodel;
using DripSharp.PdfCarton.Pdmodel.Common;
using DripSharp.PdfCarton.Preflight;
using DripSharp.PdfCarton.Preflight.Parser;
using DripSharp.PdfCarton.Xmp.Xml;

static void Require(bool condition, string message)
{
    if (!condition)
    {
        throw new InvalidOperationException(message);
    }
}

Require(
    typeof(RandomAccessReadBuffer).Assembly.GetName().Name == "DripSharp.PdfCarton.IO",
    "IO package assembly did not load.");
Require(
    typeof(BoundingBox).Assembly.GetName().Name == "DripSharp.PdfCarton.Fonts",
    "Fonts package assembly did not load.");
Require(
    typeof(DomXmpParser).Assembly.GetName().Name == "DripSharp.PdfCarton.Xmp",
    "Xmp package assembly did not load.");
Require(
    typeof(PDDocument).Assembly.GetName().Name == "DripSharp.PdfCarton",
    "PdfCarton package assembly did not load.");
Require(
    typeof(PreflightParser).Assembly.GetName().Name == "DripSharp.PdfCarton.Preflight",
    "Preflight package assembly did not load.");

using (var input = new RandomAccessReadBuffer(new sbyte[] { 1, -2, 3, 4 }))
{
    Require(input.Read() == 1, "IO initial read behavior failed.");
    Require(input.Read() == 254, "IO unsigned read behavior failed.");
    input.Seek(2);
    using RandomAccessRead view = input.CreateView(2, 2);
    Require(view.Read() == 3 && view.Read() == 4, "IO view behavior failed.");
}

var bounds = new BoundingBox(1, 2, 6, 10);
Require(bounds.GetWidth() == 5 && bounds.GetHeight() == 8, "Fonts geometry failed.");
Require(bounds.Contains(3, 4) && !bounds.Contains(7, 4), "Fonts containment failed.");

const string xmp = """
<?xpacket begin="" id="pdfcarton-release-consumer"?>
<x:xmpmeta xmlns:x="adobe:ns:meta/">
  <rdf:RDF xmlns:rdf="http://www.w3.org/1999/02/22-rdf-syntax-ns#">
    <rdf:Description rdf:about="" xmlns:dc="http://purl.org/dc/elements/1.1/">
      <dc:title><rdf:Alt><rdf:li xml:lang="x-default">PdfCarton package consumer</rdf:li></rdf:Alt></dc:title>
    </rdf:Description>
  </rdf:RDF>
</x:xmpmeta>
<?xpacket end="w"?>
""";
var metadata = new DomXmpParser().Parse(
    new MemoryStream(Encoding.UTF8.GetBytes(xmp)));
Require(
    metadata.GetDublinCoreSchema()!.GetTitle("x-default") == "PdfCarton package consumer",
    "Xmp parse behavior failed.");

string file = Path.Combine(
    Path.GetTempPath(), $"pdfcarton-release-consumer-{Guid.NewGuid():N}.pdf");
try
{
    using (var document = new PDDocument())
    {
        document.GetDocumentInformation().SetTitle("PdfCarton package consumer");
        document.AddPage(new PDPage(PDRectangle.A4));
        document.Save(file);
    }

    using (var reopened = Loader.LoadPDF(new FileInfo(file)))
    {
        Require(reopened.GetNumberOfPages() == 1, "PdfCarton page behavior failed.");
        Require(
            reopened.GetDocumentInformation().GetTitle() == "PdfCarton package consumer",
            "PdfCarton metadata behavior failed.");
    }

    var preflightInput = new RandomAccessReadBufferedFile(new FileInfo(file));
    using (var document = (PreflightDocument)new PreflightParser(preflightInput).Parse())
    {
        ValidationResult result = document.Validate();
        Require(!result.IsValid(), "Preflight accepted an ordinary PDF as PDF/A.");
        Require(result.GetErrorsList().Count > 0, "Preflight returned no validation errors.");
    }
    Require(preflightInput.IsClosed(), "Preflight did not close its input.");
}
finally
{
    File.Delete(file);
}

Console.WriteLine("External PdfCarton release package consumer passed.");
EOF

cat > "$consumer/NuGet.Config" <<EOF
<?xml version="1.0" encoding="utf-8"?>
<configuration>
  <packageSources>
    <clear />
    <add key="pdfcarton-release" value="$feed" />
  </packageSources>
</configuration>
EOF

export DOTNET_CLI_HOME="$dotnet_home"
export DOTNET_NOLOGO=1
export DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
export NUGET_PACKAGES="$packages"

dotnet restore "$consumer/PdfCarton.ReleaseConsumer.csproj" \
  --configfile "$consumer/NuGet.Config" \
  --packages "$packages" \
  --no-cache \
  --force
dotnet build "$consumer/PdfCarton.ReleaseConsumer.csproj" \
  --configuration Release \
  --no-restore \
  -warnaserror
dotnet run \
  --project "$consumer/PdfCarton.ReleaseConsumer.csproj" \
  --configuration Release \
  --no-restore \
  --no-build
