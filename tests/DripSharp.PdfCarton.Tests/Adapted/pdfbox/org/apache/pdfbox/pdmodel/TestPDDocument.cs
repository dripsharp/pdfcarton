// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel;

public class TestPDDocument {
private static readonly global::System.IO.FileInfo TESTRESULTSDIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output"));

internal static void setUp() {
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.TestPDDocument.TESTRESULTSDIR);
}

internal virtual void testSaveLoadStream() {
global::DripSharp.Runtime.JavaByteArrayOutputStream baos;
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
document.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
baos = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
document.Save(baos, global::DripSharp.PdfCarton.Pdfwriter.Compress.CompressParameters.NoCompression);
}
sbyte[] pdf = global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos);
global::DripSharp.Testing.JavaAssertions.True((pdf.Length > 200), null);
global::DripSharp.Testing.JavaAssertions.Equal("%PDF-1.4", global::DripSharp.Runtime.JavaCompat.NewString(global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(pdf, 0, 8), global::DripSharp.Runtime.JavaStandardCharsets.UTF8), null);
global::DripSharp.Testing.JavaAssertions.Equal("%%EOF\n", global::DripSharp.Runtime.JavaCompat.NewString(global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(pdf, (pdf.Length - 6), pdf.Length), global::DripSharp.Runtime.JavaStandardCharsets.UTF8), null);
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument loadDoc = global::DripSharp.PdfCarton.Loader.LoadPDF(pdf)) {
global::DripSharp.Testing.JavaAssertions.Equal(1, loadDoc.GetNumberOfPages(), null);
}
}

internal virtual void testSaveLoadFile() {
global::System.IO.FileInfo targetFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.TestPDDocument.TESTRESULTSDIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "pddocument-saveloadfile.pdf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
document.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
document.Save(targetFile, global::DripSharp.PdfCarton.Pdfwriter.Compress.CompressParameters.NoCompression);
}
global::DripSharp.Testing.JavaAssertions.True((targetFile.Length > 200), null);
sbyte[] pdf = global::DripSharp.Runtime.JavaCompat.ReadAllBytes(new global::DripSharp.Runtime.JavaPath(targetFile.FullName));
global::DripSharp.Testing.JavaAssertions.True((pdf.Length > 200), null);
global::DripSharp.Testing.JavaAssertions.Equal("%PDF-1.4", global::DripSharp.Runtime.JavaCompat.NewString(global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(pdf, 0, 8), global::DripSharp.Runtime.JavaStandardCharsets.UTF8), null);
global::DripSharp.Testing.JavaAssertions.Equal("%%EOF\n", global::DripSharp.Runtime.JavaCompat.NewString(global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(pdf, (pdf.Length - 6), pdf.Length), global::DripSharp.Runtime.JavaStandardCharsets.UTF8), null);
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument loadDoc = global::DripSharp.PdfCarton.Loader.LoadPDF(targetFile)) {
global::DripSharp.Testing.JavaAssertions.Equal(1, loadDoc.GetNumberOfPages(), null);
}
}

internal virtual void testVersions() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__124_25 = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.Testing.JavaAssertions.Equal(1.4F, document__124_25.GetVersion(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal(1.4F, document__124_25.GetDocument().GetVersion(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal("1.4", document__124_25.GetDocumentCatalog().GetVersion(), null);
document__124_25.GetDocument().SetVersion(1.3F);
document__124_25.GetDocumentCatalog().SetVersion((string)default!);
global::DripSharp.Testing.JavaAssertions.Equal(1.3F, document__124_25.GetVersion(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal(1.3F, document__124_25.GetDocument().GetVersion(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Null(document__124_25.GetDocumentCatalog().GetVersion(), null);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__140_25 = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
document__140_25.SetVersion(1.3F);
global::DripSharp.Testing.JavaAssertions.Equal(1.4F, document__140_25.GetVersion(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal(1.4F, document__140_25.GetDocument().GetVersion(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal("1.4", document__140_25.GetDocumentCatalog().GetVersion(), null);
document__140_25.SetVersion(1.5F);
global::DripSharp.Testing.JavaAssertions.Equal(1.5F, document__140_25.GetVersion(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal(1.4F, document__140_25.GetDocument().GetVersion(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal("1.5", document__140_25.GetDocumentCatalog().GetVersion(), null);
}
global::DripSharp.Runtime.JavaByteArrayOutputStream baos = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__160_25 = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
document__160_25.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
document__160_25.Save(baos);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__165_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos))) {
global::DripSharp.Testing.JavaAssertions.Equal("1.6", document__165_25.GetDocumentCatalog().GetVersion(), null);
global::DripSharp.Testing.JavaAssertions.Equal(1.6F, document__165_25.GetDocument().GetVersion(), null);
global::DripSharp.Testing.JavaAssertions.Equal(1.6F, document__165_25.GetVersion(), null);
}
global::DripSharp.Testing.JavaAssertions.Equal("%PDF-1.6", global::DripSharp.Runtime.JavaCompat.NewString(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos), 0, 8, global::System.Text.Encoding.UTF8), null);
}

internal virtual void testDeleteBadFile() {
global::System.IO.FileInfo f = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.TestPDDocument.TESTRESULTSDIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "testDeleteBadFile.pdf")));
using (global::System.IO.TextWriter pw = new global::System.IO.StreamWriter(global::DripSharp.Runtime.JavaCompat.OpenFileOutput(f), global::System.Text.Encoding.UTF8, 1024, false)) {
pw.Write(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "<script language='JavaScript'>"));
}
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => global::DripSharp.PdfCarton.Loader.LoadPDF(f), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "parsing should fail"));
global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => global::DripSharp.Runtime.JavaCompat.DeleteIfExists(new global::DripSharp.Runtime.JavaPath(f.FullName)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "delete bad file failed after failed load"));
}

internal virtual void testDeleteGoodFile() {
global::System.IO.FileInfo f = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.TestPDDocument.TESTRESULTSDIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "testDeleteGoodFile.pdf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
doc.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
doc.Save(f);
}
global::DripSharp.PdfCarton.Loader.LoadPDF(f).Dispose();
global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => global::DripSharp.Runtime.JavaCompat.DeleteIfExists(new global::DripSharp.Runtime.JavaPath(f.FullName)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "delete good file failed after successful load() and close()"));
}

internal virtual void testSaveArabicLocale() {
global::System.Globalization.CultureInfo defaultLocale = global::System.Globalization.CultureInfo.CurrentCulture;
global::System.Globalization.CultureInfo arabicLocale = new global::DripSharp.PdfCarton.Tests.JavaLocaleBuilder().SetLanguageTag(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ar-EG-u-nu-arab")).Build();
global::DripSharp.PdfCarton.Tests.Support.SetDefaultCulture(arabicLocale);
global::DripSharp.Runtime.JavaByteArrayOutputStream baos = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
doc.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
doc.Save(baos);
}
global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos)).Dispose(), null);
global::DripSharp.PdfCarton.Tests.Support.SetDefaultCulture(defaultLocale);
}

[Xunit.Fact]
public void __Upstream_3494588292_c47ff2ab59da841c()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testDeleteBadFile();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0963902422_31cd1b834aa84dfe()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testDeleteGoodFile();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0079810805_7c23a1bad3acb867()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testSaveArabicLocale();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0664400337_fe9fc057a0266964()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testSaveLoadFile();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3216083605_36b256aa0700f096()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testSaveLoadStream();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0876770637_ae4d1f967beeff32()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testVersions();
        }
        finally
        {
        }
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    setUp();
    return true;
}
}
