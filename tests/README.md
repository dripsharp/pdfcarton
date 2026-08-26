# Generated test suites

These test suites are generated from the authoritative `dripsharp/dripsharp` target contract. Do not apply durable manual fixes in a generated product repository.

From a clean pdfcarton product-repository checkout:

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

The project references only paths within this checkout. Its test host permits major-version roll-forward so a later .NET runtime can exercise an earlier-targeted product family. `SHA256SUMS` inventories every generated test file except the inventory itself.
Each declared strategy records whether its output is shipped or validation-only; validation-only project paths are excluded from publication by the target contract.
