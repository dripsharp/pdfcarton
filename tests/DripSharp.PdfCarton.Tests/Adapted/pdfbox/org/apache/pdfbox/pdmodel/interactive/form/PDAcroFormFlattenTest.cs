// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class PDAcroFormFlattenTest {
private static readonly global::System.IO.FileInfo IN_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output/flatten/in"));

private static readonly global::System.IO.FileInfo OUT_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output/flatten/out"));

internal static void setUp() {
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.IN_DIR);
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.OUT_DIR);
}

internal virtual void testFlatten(string sourceUrl, string targetFileName) {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.flattenAndCompare(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", sourceUrl), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", targetFileName));
}

internal virtual void flattenSingleField() {
string filename = "src/test/resources/org/apache/pdfbox/pdmodel/interactive/form/MultilineFields.pdf";
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = document.GetDocumentCatalog().GetAcroForm();
int numFieldsBefore = global::DripSharp.Runtime.JavaCompat.CollectionCount(acroForm.GetFields());
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField> toBeFlattened = new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField>();
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField field = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "AlignLeft-Filled"))!);
global::DripSharp.Runtime.JavaCompat.Add(toBeFlattened, field);
acroForm.Flatten(toBeFlattened, false);
global::DripSharp.Testing.JavaAssertions.Equal(numFieldsBefore, (global::DripSharp.Runtime.JavaCompat.CollectionCount(acroForm.GetFields()) + 1), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "the number of form fields shall be reduced by one"));
global::DripSharp.Testing.JavaAssertions.Null(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "AlignLeft-Filled")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "the flattened field shall no longer exist"));
}

internal virtual void flattenTestPDFBOX5254() {
string sourceUrl = "https://issues.apache.org/jira/secure/attachment/13005793/f1040sb%20test.pdf";
string targetFileName = "PDFBOX-4889-5254.pdf";
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.generateSamples(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", sourceUrl), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", targetFileName));
global::System.IO.FileInfo inputFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", targetFileName)));
global::System.IO.FileInfo outputFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", targetFileName)));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf = global::DripSharp.PdfCarton.Loader.LoadPDF(inputFile)) {
testPdf.GetDocumentCatalog().GetAcroForm().Flatten();
testPdf.SetAllSecurityToBeRemoved(true);
testPdf.Save(outputFile);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(testPdf.GetDocumentCatalog().GetAcroForm((global::DripSharp.PdfCarton.Pdmodel.Fixup.PDDocumentFixup)default!).GetFields()), null);
global::DripSharp.Testing.JavaAssertions.Equal(72, global::DripSharp.Runtime.JavaCompat.CollectionCount(testPdf.GetPage(0).GetAnnotations()), null);
}
if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.DoTestFile(outputFile, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.IN_DIR.FullName), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.OUT_DIR.FullName)))) {
global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
} else {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.removeAllRenditions(inputFile);
global::DripSharp.Runtime.JavaCompat.FileDelete(inputFile);
global::DripSharp.Runtime.JavaCompat.FileDelete(outputFile);
}
}

internal virtual void flattenTestPDFBOX5225() {
string sourceUrl = "https://issues.apache.org/jira/secure/attachment/13027311/SourceFailure.pdf";
string targetFileName = "PDFBOX-5225.pdf";
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.generateSamples(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", sourceUrl), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", targetFileName));
global::System.IO.FileInfo inputFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", targetFileName)));
global::System.IO.FileInfo outputFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", targetFileName)));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf = global::DripSharp.PdfCarton.Loader.LoadPDF(inputFile)) {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = testPdf.GetDocumentCatalog().GetAcroForm();
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField> list = new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField>();
global::DripSharp.Runtime.JavaCompat.Add(list, acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "VN_NAME")));
acroForm.Flatten(list, false);
testPdf.SetAllSecurityToBeRemoved(true);
testPdf.Save(outputFile);
int count = 0;
global::DripSharp.Runtime.JavaIterator<global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField> iterator = acroForm.GetFieldTree().Iterator();
while (iterator.HasNext()) {
iterator.Next();
++count;
}
global::DripSharp.Testing.JavaAssertions.Equal(76, count, null);
global::DripSharp.Testing.JavaAssertions.Equal(59, global::DripSharp.Runtime.JavaCompat.CollectionCount(testPdf.GetPage(0).GetAnnotations()), null);
}
if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.DoTestFile(outputFile, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.IN_DIR.FullName), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.OUT_DIR.FullName)))) {
global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Rendering of ", outputFile), " failed or is not identical to expected rendering in "), global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.IN_DIR), " directory")));
} else {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.removeAllRenditions(inputFile);
global::DripSharp.Runtime.JavaCompat.FileDelete(inputFile);
global::DripSharp.Runtime.JavaCompat.FileDelete(outputFile);
}
}

private static void flattenAndCompare(string sourceUrl, string targetFileName) {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.generateSamples(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", sourceUrl), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", targetFileName));
global::System.IO.FileInfo inputFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", targetFileName)));
global::System.IO.FileInfo outputFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", targetFileName)));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf = global::DripSharp.PdfCarton.Loader.LoadPDF(inputFile)) {
testPdf.GetDocumentCatalog().GetAcroForm().Flatten();
testPdf.SetAllSecurityToBeRemoved(true);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(testPdf.GetDocumentCatalog().GetAcroForm().GetFields()), null);
testPdf.Save(outputFile);
}
if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.DoTestFile(outputFile, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.IN_DIR.FullName), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.OUT_DIR.FullName)))) {
global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
} else {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.removeAllRenditions(inputFile);
global::DripSharp.Runtime.JavaCompat.FileDelete(inputFile);
global::DripSharp.Runtime.JavaCompat.FileDelete(outputFile);
}
}

private static void generateSamples(string sourceUrl, string targetFile) {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.getFromUrl(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", sourceUrl), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", targetFile));
global::System.IO.FileInfo file = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", targetFile)));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = global::DripSharp.PdfCarton.Loader.LoadPDF(file, (string)default!)) {
string outputPrefix = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.IN_DIR.FullName, '/'), file.Name), "-");
int numPages = document.GetNumberOfPages();
global::DripSharp.PdfCarton.Rendering.PDFRenderer renderer = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(document);
for (int i = 0; (i < numPages); i++) {
string fileName = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(outputPrefix, (i + 1)), ".png");
global::SkiaSharp.SKBitmap image = renderer.RenderImageWithDPI(i, (float)(96));
global::DripSharp.PdfCarton.Tests.Support.WriteImage(image, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PNG"), global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", fileName)));
}
}
}

private static void getFromUrl(string sourceUrl, string targetFile) {
using (global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", sourceUrl)))) {
global::DripSharp.Runtime.JavaCompat.Copy(@is, new global::DripSharp.Runtime.JavaPath(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFlattenTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", targetFile))).FullName), new object());
}
}

private static void removeAllRenditions(global::System.IO.FileInfo inputFile) {
global::System.IO.FileInfo[] testFiles = global::DripSharp.PdfCarton.Tests.Support.ListFiles(global::DripSharp.PdfCarton.Tests.Support.ParentFile(inputFile), (dir, name) => (global::DripSharp.Runtime.JavaCompat.StringStartsWith(name, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", inputFile.Name)) && global::DripSharp.Runtime.JavaCompat.StringEndsWith(name.ToLowerInvariant(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ".png"))));
global::DripSharp.Runtime.JavaCompat.ForEach(global::DripSharp.Runtime.JavaCompat.StreamOf(testFiles), (value0) => { value0.Delete(); });
}

[Xunit.Fact]
public void __Upstream_3301782766_2340da1c5ab40918()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.flattenSingleField();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3613570543_873443f1a49c2a3a()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.flattenTestPDFBOX5225();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3613570635_5f75f6f9ab2c5dae()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.flattenTestPDFBOX5254();
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.InlineData("https://issues.apache.org/jira/secure/attachment/12682897/FormI-9-English.pdf", "FormI-9-English.pdf")]
[Xunit.InlineData("https://issues.apache.org/jira/secure/attachment/12689788/test.pdf", "test-2586.pdf")]
[Xunit.InlineData("https://issues.apache.org/jira/secure/attachment/12792007/hidden_fields.pdf", "hidden_fields.pdf")]
[Xunit.InlineData("https://issues.apache.org/jira/secure/attachment/12816014/Signed-Document-1.pdf", "Signed-Document-1.pdf")]
[Xunit.InlineData("https://issues.apache.org/jira/secure/attachment/12816016/Signed-Document-2.pdf", "Signed-Document-2.pdf")]
[Xunit.InlineData("https://issues.apache.org/jira/secure/attachment/12821307/Signed-Document-3.pdf", "Signed-Document-3.pdf")]
[Xunit.InlineData("https://issues.apache.org/jira/secure/attachment/12821308/Signed-Document-4.pdf", "Signed-Document-4.pdf")]
[Xunit.InlineData("https://issues.apache.org/jira/secure/attachment/12986337/stenotypeTest-3_rotate_no_flatten.pdf", "PDFBOX-4693-filled.pdf")]
[Xunit.InlineData("https://issues.apache.org/jira/secure/attachment/12994791/flatten.pdf", "PDFBOX-4788.pdf")]
[Xunit.InlineData("https://issues.apache.org/jira/secure/attachment/13011410/PDFBOX-4955.pdf", "PDFBOX-4955.pdf")]
public void __Upstream_0976080146_e549fbc04dc67b2c(string sourceUrl, string targetFileName)
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testFlatten(sourceUrl, targetFileName);
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
