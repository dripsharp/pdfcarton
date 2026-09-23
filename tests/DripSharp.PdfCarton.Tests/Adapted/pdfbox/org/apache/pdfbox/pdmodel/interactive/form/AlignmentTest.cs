// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class AlignmentTest {
  private static readonly global::DripSharp.Runtime.JavaFile OUT_DIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/test-output"));

  private static readonly global::DripSharp.Runtime.JavaFile IN_DIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "src/test/resources/org/apache/pdfbox/pdmodel/interactive/form"));

  private const string NAME_OF_PDF = "AlignmentTests.pdf";

  private const string TEST_VALUE = "sdfASDF1234\u00E4\u00F6\u00FC";

  private global::DripSharp.PdfCarton.Pdmodel.PDDocument document = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = null!;

  internal virtual void setUp() {
    this.document
      = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
      "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
      new object[] { global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.IN_DIR,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.NAME_OF_PDF)) });
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
    global::DripSharp.Runtime.JavaFile file
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.OUT_DIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.NAME_OF_PDF));
    global::DripSharp.Runtime.JavaFileBridge.Call(this.document, "Save",
      new global::System.Type[] { typeof(global::System.IO.FileInfo) }, new object[] { file });
    if (!(global::DripSharp.Runtime.JavaFileBridge.Call<bool>(typeof(global::DripSharp.PdfCarton.Rendering.TestPDFToImage),
      "DoTestFile", new global::System.Type[] { typeof(global::System.IO.FileInfo), typeof(string),
        typeof(string) }, new object[] { file,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.IN_DIR)),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AlignmentTest.OUT_DIR)) }))) {
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
