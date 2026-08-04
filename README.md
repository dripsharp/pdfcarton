# PdfCarton

Apache PDFBox document, parsing, rendering, and manipulation APIs for .NET, mechanically translated by DripSharp. This package is an independent translation and is not affiliated with, endorsed by, or sponsored by the Apache Software Foundation.

This is a generated publication repository. Durable source, translation, runtime, and test changes belong in [`dripsharp/dripsharp`](https://github.com/dripsharp/dripsharp) and must be regenerated; do not apply durable manual fixes to generated C# or generated tests here.

## Projects

- [`DripSharp.PdfCarton`](src/DripSharp.PdfCarton/DripSharp.PdfCarton.csproj) — PdfCarton (`net10.0`)
- [`DripSharp.PdfCarton.Fonts`](src/DripSharp.PdfCarton.Fonts/DripSharp.PdfCarton.Fonts.csproj) — PdfCarton Fonts (`net10.0`)
- [`DripSharp.PdfCarton.IO`](src/DripSharp.PdfCarton.IO/DripSharp.PdfCarton.IO.csproj) — PdfCarton I/O (`net10.0`)
- [`DripSharp.PdfCarton.Preflight`](src/DripSharp.PdfCarton.Preflight/DripSharp.PdfCarton.Preflight.csproj) — PdfCarton Preflight (`net10.0`)
- [`DripSharp.PdfCarton.Xmp`](src/DripSharp.PdfCarton.Xmp/DripSharp.PdfCarton.Xmp.csproj) — PdfCarton XMP (`net10.0`)

## Build and test

From a clean checkout:

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
