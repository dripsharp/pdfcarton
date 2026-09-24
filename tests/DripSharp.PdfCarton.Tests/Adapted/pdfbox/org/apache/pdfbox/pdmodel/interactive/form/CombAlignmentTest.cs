// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class CombAlignmentTest {
  private static readonly global::DripSharp.Runtime.JavaFile OUT_DIR;

  private static readonly global::DripSharp.Runtime.JavaFile IN_DIR;

  private const string NAME_OF_PDF = "CombTest.pdf";

  private const string TEST_VALUE = "1234567";

  internal virtual void setUp() {
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.OUT_DIR);
  }

  internal virtual void testCombFields() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.IN_DIR,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.NAME_OF_PDF)) });
      global::System.Exception __dripsharpPrimary_49_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
          = document.GetDocumentCatalog().GetAcroForm();
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field
          = acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "PDFBoxCombLeft"));
        field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ""));
        field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.TEST_VALUE));
        field = acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "PDFBoxCombMiddle"));
        field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ""));
        field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.TEST_VALUE));
        field = acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "PDFBoxCombRight"));
        field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ""));
        field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.TEST_VALUE));
        global::DripSharp.Runtime.JavaFile file
          = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.OUT_DIR,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.NAME_OF_PDF));
        global::DripSharp.Runtime.JavaFileBridge.Call(document, "Save",
          new global::System.Type[] { typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.Runtime.JavaFile)file });
        if (!(global::DripSharp.Runtime.JavaFileBridge.Call<bool>(typeof(global::DripSharp.PdfCarton.Rendering.TestPDFToImage),
          "DoTestFile", new global::System.Type[] { typeof(global::System.IO.FileInfo),
            typeof(string), typeof(string) }, new object[] { (global::DripSharp.Runtime.JavaFile)file,
            (string)global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.IN_DIR)),
            (string)global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.OUT_DIR)) }))) {
          global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Rendering of ",
            file), " failed or is not identical to expected rendering in "),
            global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.IN_DIR),
            " directory")));
        }
      } catch (global::System.Exception __dripsharpCaught_49_25_0) {
        __dripsharpPrimary_49_25_0 = __dripsharpCaught_49_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document, __dripsharpPrimary_49_25_0);
      }
    }
  }

  internal virtual void testPDFBOX5784() {
    string NAME_OF_PDF = "PDFBOX-5784.pdf"; {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.IN_DIR,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", NAME_OF_PDF)) });
      global::System.Exception __dripsharpPrimary_80_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
          = document.GetDocumentCatalog().GetAcroForm();
        foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field in acroForm.GetFieldTree()) {
          if (!global::DripSharp.Runtime.JavaCompat.StringContains(field.GetPartialName(),
            "acrobat")) {
            field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "WIaqg"));
          }
        }
        global::DripSharp.Runtime.JavaFile file
          = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.OUT_DIR,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", NAME_OF_PDF));
        global::DripSharp.Runtime.JavaFileBridge.Call(document, "Save",
          new global::System.Type[] { typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.Runtime.JavaFile)file });
        if (!(global::DripSharp.Runtime.JavaFileBridge.Call<bool>(typeof(global::DripSharp.PdfCarton.Rendering.TestPDFToImage),
          "DoTestFile", new global::System.Type[] { typeof(global::System.IO.FileInfo),
            typeof(string), typeof(string) }, new object[] { (global::DripSharp.Runtime.JavaFile)file,
            (string)global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.IN_DIR)),
            (string)global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.OUT_DIR)) }))) {
          global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Rendering of ",
            file), " failed or is not identical to expected rendering in "),
            global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.CombAlignmentTest.IN_DIR),
            " directory")));
        }
      } catch (global::System.Exception __dripsharpCaught_80_25_0) {
        __dripsharpPrimary_80_25_0 = __dripsharpCaught_80_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document, __dripsharpPrimary_80_25_0);
      }
    }
  }

  [Xunit.Fact]
  public void __Upstream_0267462476_dc347637ac2d4c68() {
    this.setUp();
    try {
      this.testCombFields();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0778924617_ba5ae70f268a70c9() {
    this.setUp();
    try {
      this.testPDFBOX5784();
    } finally {
    }
  }

  static CombAlignmentTest() {
    OUT_DIR
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/test-output"));
    IN_DIR
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "src/test/resources/org/apache/pdfbox/pdmodel/interactive/form"));
  }
}
