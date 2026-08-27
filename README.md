# PdfCarton

[![DripSharp.PdfCarton on NuGet](https://img.shields.io/nuget/vpre/DripSharp.PdfCarton?logo=nuget&label=DripSharp.PdfCarton)](https://www.nuget.org/packages/DripSharp.PdfCarton)

Apache PDFBox document, parsing, rendering, and manipulation APIs for .NET, mechanically translated by DripSharp. This package is an independent translation and is not affiliated with, endorsed by, or sponsored by the Apache Software Foundation.

This is a generated publication repository. Durable source, translation, runtime, and test changes belong in [`dripsharp/dripsharp`](https://github.com/dripsharp/dripsharp) and must be regenerated; do not apply durable manual fixes to generated C# or generated tests here.

## Projects

- [`DripSharp.PdfCarton`](src/DripSharp.PdfCarton/DripSharp.PdfCarton.csproj) — PdfCarton (`netstandard2.0`, version `3.0.8-alpha.2`)
- [`DripSharp.PdfCarton.Fonts`](src/DripSharp.PdfCarton.Fonts/DripSharp.PdfCarton.Fonts.csproj) — PdfCarton Fonts (`netstandard2.0`, version `3.0.8-alpha.2`)
- [`DripSharp.PdfCarton.IO`](src/DripSharp.PdfCarton.IO/DripSharp.PdfCarton.IO.csproj) — PdfCarton I/O (`netstandard2.0`, version `3.0.8-alpha.2`)
- [`DripSharp.PdfCarton.Preflight`](src/DripSharp.PdfCarton.Preflight/DripSharp.PdfCarton.Preflight.csproj) — PdfCarton Preflight (`netstandard2.0`, version `3.0.8-alpha.2`)
- [`DripSharp.PdfCarton.Xmp`](src/DripSharp.PdfCarton.Xmp/DripSharp.PdfCarton.Xmp.csproj) — PdfCarton XMP (`netstandard2.0`, version `3.0.8-alpha.2`)

## Framework compatibility

Every production library has one target framework: `netstandard2.0`. Repository test projects, runners, probes, differential hosts, and package consumers execute on `net10.0` while referencing or consuming those production assemblies.

.NET Framework 4.8 compatibility is inferred from the `netstandard2.0` contract and compatible dependency assets. This repository does not build or run a .NET Framework 4.8 host and does not empirically certify net48 runtime behavior.


## Install

The first public release is a prerelease. Install from nuget.org:

```sh
dotnet add package DripSharp.PdfCarton --version 3.0.8-alpha.2
```


## Build and test

From a clean checkout:

### `DripSharp.PdfCarton.ReleaseSmoke`

```sh
dotnet restore tests/DripSharp.PdfCarton.ReleaseSmoke/DripSharp.PdfCarton.ReleaseSmoke.csproj
dotnet build tests/DripSharp.PdfCarton.ReleaseSmoke/DripSharp.PdfCarton.ReleaseSmoke.csproj --configuration Release --no-restore --no-incremental -warnaserror
dotnet test tests/DripSharp.PdfCarton.ReleaseSmoke/DripSharp.PdfCarton.ReleaseSmoke.csproj --configuration Release --no-restore --no-build
```

### `DripSharp.PdfCarton.Tests`

```sh
dotnet restore tests/DripSharp.PdfCarton.Tests/DripSharp.PdfCarton.Tests.csproj
dotnet build tests/DripSharp.PdfCarton.Tests/DripSharp.PdfCarton.Tests.csproj --configuration Release --no-restore --no-incremental -warnaserror
dotnet test tests/DripSharp.PdfCarton.Tests/DripSharp.PdfCarton.Tests.csproj --configuration Release --no-restore --no-build
```

The shipped suites reference only this checkout. See [`tests/README.md`](tests/README.md) for its generated inventory and execution contract.

## Upstream

This generated family translates Apache PDFBox 3.0.8 at commit [`9286e47d89d6877005c9d2d0f2fd38793a62519a`](https://github.com/apache/pdfbox/tree/9286e47d89d6877005c9d2d0f2fd38793a62519a). Upstream identity and attribution are preserved; this independent .NET translation is not developed, endorsed, or supported by the upstream project.

## License and notices

See [`LICENSE`](LICENSE) for the license and [`NOTICE`](NOTICE) for upstream attribution and the DripSharp translation notice.
