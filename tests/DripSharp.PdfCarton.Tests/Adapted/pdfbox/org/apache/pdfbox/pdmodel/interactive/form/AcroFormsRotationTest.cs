// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class AcroFormsRotationTest {
  private static readonly global::System.IO.FileInfo OUT_DIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/test-output"));

  private static readonly global::System.IO.FileInfo IN_DIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "src/test/resources/org/apache/pdfbox/pdmodel/interactive/form"));

  private const string NAME_OF_PDF = "AcroFormsRotation.pdf";

  private const string TEST_VALUE
    = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua.";

  private global::DripSharp.PdfCarton.Pdmodel.PDDocument document = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = null!;

  internal virtual void setUp() {
    this.document
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.IN_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.NAME_OF_PDF))));
    this.acroForm = this.document.GetDocumentCatalog().GetAcroForm();
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.OUT_DIR);
  }

  internal virtual void fillFields() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field
      = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.portrait.single.rotation0"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      field.GetFullyQualifiedName()));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.portrait.single.rotation90"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      field.GetFullyQualifiedName()));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.portrait.single.rotation180"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      field.GetFullyQualifiedName()));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.portrait.single.rotation270"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      field.GetFullyQualifiedName()));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.portrait.multi.rotation0"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(field.GetFullyQualifiedName(),
      "\n"),
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.TEST_VALUE)));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.portrait.multi.rotation90"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(field.GetFullyQualifiedName(),
      "\n"),
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.TEST_VALUE)));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.portrait.multi.rotation180"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(field.GetFullyQualifiedName(),
      "\n"),
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.TEST_VALUE)));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.portrait.multi.rotation270"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(field.GetFullyQualifiedName(),
      "\n"),
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.TEST_VALUE)));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.page90.single.rotation0"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.page90.single.rotation0"));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.page90.single.rotation90"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.page90.single.rotation90"));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.page90.single.rotation180"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.page90.single.rotation180"));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.page90.single.rotation270"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.page90.single.rotation270"));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.page90.multi.rotation0"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(field.GetFullyQualifiedName(),
      "\n"),
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.TEST_VALUE)));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.page90.multi.rotation90"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(field.GetFullyQualifiedName(),
      "\n"),
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.TEST_VALUE)));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.page90.multi.rotation180"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(field.GetFullyQualifiedName(),
      "\n"),
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.TEST_VALUE)));
    field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "pdfbox.page90.multi.rotation270"));
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(field.GetFullyQualifiedName(),
      "\n"),
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.TEST_VALUE)));
    global::System.IO.FileInfo file
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.OUT_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.NAME_OF_PDF)));
    this.document.Save(file);
    if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.DoTestFile(file,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.IN_DIR.FullName),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.OUT_DIR.FullName)))) {
      global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Rendering of ",
        file), " failed or is not identical to expected rendering in "),
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.AcroFormsRotationTest.IN_DIR),
        " directory")));
    }
  }

  internal virtual void tearDown() {
    this.document.Dispose();
  }

  [Xunit.Fact]
  public void __Upstream_1189016092_43fdb1fa6e36f495() {
    this.setUp();
    try {
      this.fillFields();
    } finally {
      this.tearDown();
    }
  }
}
