# Generated consumer tests

This focused public-API suite is generated from the authoritative `dripsharp/dripsharp` target contract. Do not apply durable manual fixes in a generated product repository.

From a clean pdfcarton product-repository checkout:

```sh
dotnet restore tests/DripSharp.PdfCarton.Tests/DripSharp.PdfCarton.Tests.csproj
dotnet build tests/DripSharp.PdfCarton.Tests/DripSharp.PdfCarton.Tests.csproj --configuration Release --no-restore
dotnet test tests/DripSharp.PdfCarton.Tests/DripSharp.PdfCarton.Tests.csproj --configuration Release --no-restore --no-build
```

The project references only paths within this checkout. Its test host permits major-version roll-forward so a later .NET runtime can exercise an earlier-targeted product family. `SHA256SUMS` inventories every generated test file except the inventory itself.
