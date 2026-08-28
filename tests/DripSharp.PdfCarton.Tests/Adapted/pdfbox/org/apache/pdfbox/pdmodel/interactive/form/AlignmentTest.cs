// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class AlignmentTest {
  private static readonly global::System.IO.FileInfo OUT_DIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/test-output"));

  private static readonly global::System.IO.FileInfo IN_DIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "src/test/resources/org/apache/pdfbox/pdmodel/interactive/form"));

  private const string NAME_OF_PDF = "AlignmentTests.pdf";

  private const string TEST_VALUE = "sdfASDF1234\u00E4\u00F6\u00FC";

  private global::DripSharp.PdfCarton.Pdmodel.PDDocument document = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = null!;

  internal virtual void setUp() {
    this.document
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.IN_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.NAME_OF_PDF))));
    this.acroForm = this.document.GetDocumentCatalog().GetAcroForm();
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.OUT_DIR);
  }

  internal virtual void fillFields() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field
      = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignLeft"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignLeft-Border_Small"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignLeft-Border_Medium"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignLeft-Border_Wide"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignLeft-Border_Wide_Clipped"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignLeft-Border_Small_Outside"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignMiddle"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignMiddle-Border_Small"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignMiddle-Border_Medium"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignMiddle-Border_Wide"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignMiddle-Border_Wide_Clipped"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignMiddle-Border_Medium_Outside"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignRight"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignRight-Border_Small"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignRight-Border_Medium"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignRight-Border_Wide"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignRight-Border_Wide_Clipped"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignRight-Border_Wide_Outside"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.TEST_VALUE));
    global::System.IO.FileInfo file
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.OUT_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.NAME_OF_PDF)));
    this.document.Save(file);
    if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.DoTestFile(file,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.IN_DIR.FullName),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.OUT_DIR.FullName)))) {
      global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Rendering of ",
        file), " failed or is not identical to expected rendering in "),
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.IN_DIR), " directory")));
    }
  }

  internal virtual void tearDown() {
    this.document.Dispose();
  }

  [Xunit.Fact]
  public void __Upstream_1189016092_caee2ab732c82e30() {
    this.setUp();
    try {
      this.fillFields();
    } finally {
      this.tearDown();
    }
  }
}
