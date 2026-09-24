// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class MultilineFieldsTest {
  private static readonly global::DripSharp.Runtime.JavaFile OUT_DIR;

  private static readonly global::DripSharp.Runtime.JavaFile IN_DIR;

  private const string NAME_OF_PDF = "MultilineFields.pdf";

  private const string TEST_VALUE
    = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam";

  private global::DripSharp.PdfCarton.Pdmodel.PDDocument document = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = null!;

  internal virtual void setUp() {
    this.document
      = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
      "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
      new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.IN_DIR,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.NAME_OF_PDF)) });
    this.acroForm = this.document.GetDocumentCatalog().GetAcroForm();
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.OUT_DIR);
  }

  internal virtual void fillFields() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField field
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignLeft"))!);
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.TEST_VALUE));
    field
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignMiddle"))!);
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.TEST_VALUE));
    field
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignRight"))!);
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.TEST_VALUE));
    field
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignLeft-Border_Small"))!);
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.TEST_VALUE));
    field
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignMiddle-Border_Small"))!);
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.TEST_VALUE));
    field
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignRight-Border_Small"))!);
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.TEST_VALUE));
    field
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignLeft-Border_Medium"))!);
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.TEST_VALUE));
    field
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignMiddle-Border_Medium"))!);
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.TEST_VALUE));
    field
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignRight-Border_Medium"))!);
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.TEST_VALUE));
    field
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignLeft-Border_Wide"))!);
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.TEST_VALUE));
    field
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignMiddle-Border_Wide"))!);
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.TEST_VALUE));
    field
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignRight-Border_Wide"))!);
    field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.TEST_VALUE));
    global::DripSharp.Runtime.JavaFile file
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.OUT_DIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.NAME_OF_PDF));
    global::DripSharp.Runtime.JavaFileBridge.Call(this.document, "Save",
      new global::System.Type[] { typeof(global::System.IO.FileInfo) },
      new object[] { (global::DripSharp.Runtime.JavaFile)file });
    if (!(global::DripSharp.Runtime.JavaFileBridge.Call<bool>(typeof(global::DripSharp.PdfCarton.Rendering.TestPDFToImage),
      "DoTestFile", new global::System.Type[] { typeof(global::System.IO.FileInfo), typeof(string),
        typeof(string) }, new object[] { (global::DripSharp.Runtime.JavaFile)file,
        (string)global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.IN_DIR)),
        (string)global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.OUT_DIR)) }))) {
      global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Rendering of ",
        file), " failed or is not identical to expected rendering in "),
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.IN_DIR),
        " directory")));
    }
  }

  internal virtual void testMultilineAuto() {
    global::DripSharp.PdfCarton.Pdmodel.PDDocument document
      = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
      "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
      new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.IN_DIR,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "PDFBOX3812-acrobat-multiline-auto.pdf")) });
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
      = document.GetDocumentCatalog().GetAcroForm();
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField fieldMultiline
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Multiline"))!);
    float fontSizeMultiline = this.getFontSizeFromAppearanceStream(fieldMultiline);
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField fieldSingleline
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Singleline"))!);
    float fontSizeSingleline = this.getFontSizeFromAppearanceStream(fieldSingleline);
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField fieldMultilineAutoscale
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "MultilineAutoscale"))!);
    float fontSizeMultilineAutoscale
      = this.getFontSizeFromAppearanceStream(fieldMultilineAutoscale);
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField fieldSinglelineAutoscale
      = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "SinglelineAutoscale"))!);
    float fontSizeSinglelineAutoscale
      = this.getFontSizeFromAppearanceStream(fieldSinglelineAutoscale);
    fieldMultiline.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Multiline - Fixed"));
    fieldSingleline.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Singleline - Fixed"));
    fieldMultilineAutoscale.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Multiline - auto"));
    fieldSinglelineAutoscale.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Singleline - auto"));
    global::DripSharp.Testing.JavaAssertions.Equal(fontSizeMultiline,
      this.getFontSizeFromAppearanceStream(fieldMultiline), null, 0.001F);
    global::DripSharp.Testing.JavaAssertions.Equal(fontSizeSingleline,
      this.getFontSizeFromAppearanceStream(fieldSingleline), null, 0.001F);
    global::DripSharp.Testing.JavaAssertions.Equal(fontSizeMultilineAutoscale,
      this.getFontSizeFromAppearanceStream(fieldMultilineAutoscale), null, 0.001F);
    global::DripSharp.Testing.JavaAssertions.Equal(fontSizeSinglelineAutoscale,
      this.getFontSizeFromAppearanceStream(fieldSinglelineAutoscale), null, 0.025F);
  }

  internal virtual void testMultilineBreak() {
    string TEST_PDF = "PDFBOX-3835-input-acrobat-wrap.pdf"; {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.MultilineFieldsTest.IN_DIR,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", TEST_PDF)) });
      global::System.Exception __dripsharpPrimary_144_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm localAcroForm
          = document.GetDocumentCatalog().GetAcroForm();
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField fieldInput
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(localAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "filled"))!);
        string fieldValue = fieldInput.GetValue();
        global::System.Collections.Generic.IList<string> acrobatLines
          = this.getTextLinesFromAppearanceStream(fieldInput);
        fieldInput.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          fieldValue));
        global::System.Collections.Generic.IList<string> pdfboxLines
          = this.getTextLinesFromAppearanceStream(fieldInput);
        global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.CollectionCount(acrobatLines),
          global::DripSharp.Runtime.JavaCompat.CollectionCount(pdfboxLines),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "Number of lines generated by PDFBox shall match Acrobat"));
        for (int i = 0; (i < global::DripSharp.Runtime.JavaCompat.CollectionCount(acrobatLines));
          i++) {
          global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ListGet(acrobatLines,
            i).Length, global::DripSharp.Runtime.JavaCompat.ListGet(pdfboxLines, i).Length,
            global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            "Number of characters per lines generated by PDFBox shall match Acrobat"));
        }
      } catch (global::System.Exception __dripsharpCaught_144_25_0) {
        __dripsharpPrimary_144_25_0 = __dripsharpCaught_144_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document, __dripsharpPrimary_144_25_0);
      }
    }
  }

  private float getFontSizeFromAppearanceStream(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field) {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget
      = global::DripSharp.Runtime.JavaCompat.ListGet(field.GetWidgets(), 0);
    global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser parser
      = new global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser(widget.GetNormalAppearanceStream());
    object token = parser.ParseNextToken();
    while ((token != default!)) {
      if (((token is global::DripSharp.PdfCarton.Cos.COSName)
        && global::DripSharp.Runtime.JavaCompat.Equals(((global::DripSharp.PdfCarton.Cos.COSName)(token!)).GetName(),
        "Helv"))) {
        token = parser.ParseNextToken();
        if (((token != default!) && (token is global::DripSharp.PdfCarton.Cos.COSNumber))) {
          return ((global::DripSharp.PdfCarton.Cos.COSNumber)(token!)).FloatValue();
        }
      }
      token = parser.ParseNextToken();
    }
    return 0;
  }

  private global::System.Collections.Generic.IList<string> getTextLinesFromAppearanceStream(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field) {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget
      = global::DripSharp.Runtime.JavaCompat.ListGet(field.GetWidgets(), 0);
    global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser parser
      = new global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser(widget.GetNormalAppearanceStream());
    object token = parser.ParseNextToken();
    global::System.Collections.Generic.IList<string> lines
      = new global::System.Collections.Generic.List<string>();
    while ((token != default!)) {
      if ((token is global::DripSharp.PdfCarton.Cos.COSString)) {
        global::DripSharp.Runtime.JavaCompat.Add(lines,
          ((global::DripSharp.PdfCarton.Cos.COSString)(token!)).GetString());
      }
      token = parser.ParseNextToken();
    }
    return lines;
  }

  internal virtual void tearDown() {
    this.document.Dispose();
  }

  [Xunit.Fact]
  public void __Upstream_1189016092_c226c0b6e22b355c() {
    this.setUp();
    try {
      this.fillFields();
    } finally {
      this.tearDown();
    }
  }

  [Xunit.Fact]
  public void __Upstream_2614353034_50a82652b6bca0de() {
    this.setUp();
    try {
      this.testMultilineAuto();
    } finally {
      this.tearDown();
    }
  }

  [Xunit.Fact]
  public void __Upstream_3736352132_ff250e543819341b() {
    this.setUp();
    try {
      this.testMultilineBreak();
    } finally {
      this.tearDown();
    }
  }

  static MultilineFieldsTest() {
    OUT_DIR
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/test-output"));
    IN_DIR
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "src/test/resources/org/apache/pdfbox/pdmodel/interactive/form"));
  }
}
