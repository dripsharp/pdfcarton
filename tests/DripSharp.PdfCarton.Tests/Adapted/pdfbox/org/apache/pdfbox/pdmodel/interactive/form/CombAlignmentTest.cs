// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class CombAlignmentTest {
private static readonly global::System.IO.FileInfo OUT_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output"));

private static readonly global::System.IO.FileInfo IN_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "src/test/resources/org/apache/pdfbox/pdmodel/interactive/form"));

private const string NAME_OF_PDF = "CombTest.pdf";

private const string TEST_VALUE = "1234567";

internal virtual void setUp() {
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.OUT_DIR);
}

internal virtual void testCombFields() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.NAME_OF_PDF))))) {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = document.GetDocumentCatalog().GetAcroForm();
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field = acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBoxCombLeft"));
field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ""));
field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.TEST_VALUE));
field = acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBoxCombMiddle"));
field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ""));
field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.TEST_VALUE));
field = acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBoxCombRight"));
field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ""));
field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.TEST_VALUE));
global::System.IO.FileInfo file = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.NAME_OF_PDF)));
document.Save(file);
if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.DoTestFile(file, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.IN_DIR.FullName), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.OUT_DIR.FullName)))) {
global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Rendering of ", file), " failed or is not identical to expected rendering in "), global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.IN_DIR), " directory")));
}
}
}

internal virtual void testPDFBOX5784() {
string NAME_OF_PDF = "PDFBOX-5784.pdf";
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", NAME_OF_PDF))))) {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = document.GetDocumentCatalog().GetAcroForm();
foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field in acroForm.GetFieldTree()) {
if (!(global::DripSharp.Runtime.JavaCompat.StringContains(field.GetPartialName(), "acrobat"))) {
field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "WIaqg"));
}
}
global::System.IO.FileInfo file = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", NAME_OF_PDF)));
document.Save(file);
if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.DoTestFile(file, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.IN_DIR.FullName), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.OUT_DIR.FullName)))) {
global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Rendering of ", file), " failed or is not identical to expected rendering in "), global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.IN_DIR), " directory")));
}
}
}

[Xunit.Fact]
public void __Upstream_0267462476_dc347637ac2d4c68()
{
        this.setUp();
        try
        {
            this.testCombFields();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0778924617_ba5ae70f268a70c9()
{
        this.setUp();
        try
        {
            this.testPDFBOX5784();
        }
        finally
        {
        }
}
}
