// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class PDAcroFormFromAnnotsTest {
  internal virtual void testFromAnnots4985DefaultMode() {
    string sourceUrl = "https://issues.apache.org/jira/secure/attachment/13013354/POPPLER-806.pdf";
    string acrobatSourceUrl
      = "https://issues.apache.org/jira/secure/attachment/13013384/POPPLER-806-acrobat.pdf";
    int numFormFieldsByAcrobat;
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf__69_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      acrobatSourceUrl)))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog__72_31
        = testPdf__69_25.GetDocumentCatalog();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm__73_24
        = catalog__72_31.GetAcroForm((global::DripSharp.PdfCarton.Pdmodel.Fixup.PDDocumentFixup)default!);
      numFormFieldsByAcrobat
        = global::DripSharp.Runtime.JavaCompat.CollectionCount(acroForm__73_24.GetFields());
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf__77_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      sourceUrl)))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog__79_31
        = testPdf__77_25.GetDocumentCatalog();
      global::DripSharp.PdfCarton.Cos.COSDictionary cosAcroForm
        = (global::DripSharp.PdfCarton.Cos.COSDictionary)(catalog__79_31.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.AcroForm)!);
      global::DripSharp.PdfCarton.Cos.COSArray cosFields
        = (global::DripSharp.PdfCarton.Cos.COSArray)(cosAcroForm.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Fields)!);
      global::DripSharp.Testing.JavaAssertions.Equal(0, cosFields.Size(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Initially there shall be 0 fields"));
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm__84_24
        = catalog__79_31.GetAcroForm();
      global::DripSharp.Testing.JavaAssertions.Equal(numFormFieldsByAcrobat,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(acroForm__84_24.GetFields()),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("After rebuild there shall be ",
        numFormFieldsByAcrobat), " fields")));
    }
  }

  internal virtual void testFromAnnots4985CorrectionMode() {
    string sourceUrl = "https://issues.apache.org/jira/secure/attachment/13013354/POPPLER-806.pdf";
    string acrobatSourceUrl
      = "https://issues.apache.org/jira/secure/attachment/13013384/POPPLER-806-acrobat.pdf";
    int numFormFieldsByAcrobat;
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf__106_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      acrobatSourceUrl)))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog__109_31
        = testPdf__106_25.GetDocumentCatalog();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm__110_24
        = catalog__109_31.GetAcroForm((global::DripSharp.PdfCarton.Pdmodel.Fixup.PDDocumentFixup)default!);
      numFormFieldsByAcrobat
        = global::DripSharp.Runtime.JavaCompat.CollectionCount(acroForm__110_24.GetFields());
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf__114_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      sourceUrl)))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog__117_31
        = testPdf__114_25.GetDocumentCatalog();
      global::DripSharp.PdfCarton.Cos.COSDictionary cosAcroForm
        = (global::DripSharp.PdfCarton.Cos.COSDictionary)(catalog__117_31.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.AcroForm)!);
      global::DripSharp.PdfCarton.Cos.COSArray cosFields
        = (global::DripSharp.PdfCarton.Cos.COSArray)(cosAcroForm.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Fields)!);
      global::DripSharp.Testing.JavaAssertions.Equal(0, cosFields.Size(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Initially there shall be 0 fields"));
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm__122_24
        = catalog__117_31.GetAcroForm(new global::DripSharp.PdfCarton.Pdmodel.Fixup.AcroFormDefaultFixup(testPdf__114_25));
      global::DripSharp.Testing.JavaAssertions.Equal(numFormFieldsByAcrobat,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(acroForm__122_24.GetFields()),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("After rebuild there shall be ",
        numFormFieldsByAcrobat), " fields")));
    }
  }

  internal virtual void testFromAnnots4985WithoutCorrectionMode() {
    string sourceUrl = "https://issues.apache.org/jira/secure/attachment/13013354/POPPLER-806.pdf";
    int numCosFormFields;
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      sourceUrl)))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog = testPdf.GetDocumentCatalog();
      global::DripSharp.PdfCarton.Cos.COSDictionary cosAcroForm
        = (global::DripSharp.PdfCarton.Cos.COSDictionary)(catalog.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.AcroForm)!);
      global::DripSharp.PdfCarton.Cos.COSArray cosFields
        = (global::DripSharp.PdfCarton.Cos.COSArray)(cosAcroForm.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Fields)!);
      numCosFormFields = cosFields.Size();
      global::DripSharp.Testing.JavaAssertions.Equal(0, cosFields.Size(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Initially there shall be 0 fields"));
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = catalog.GetAcroForm((global::DripSharp.PdfCarton.Pdmodel.Fixup.PDDocumentFixup)default!);
      global::DripSharp.Testing.JavaAssertions.Equal(numCosFormFields,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(acroForm.GetFields()),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("After call without correction there shall be ",
        numCosFormFields), " fields")));
    }
  }

  internal virtual void testFromAnnots3891DontCreateFields() {
    string sourceUrl = "https://issues.apache.org/jira/secure/attachment/12881055/merge-test.pdf";
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      sourceUrl)))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog = testPdf.GetDocumentCatalog();
      global::DripSharp.PdfCarton.Cos.COSDictionary cosAcroForm
        = (global::DripSharp.PdfCarton.Cos.COSDictionary)(catalog.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.AcroForm)!);
      global::DripSharp.PdfCarton.Cos.COSArray cosFields
        = (global::DripSharp.PdfCarton.Cos.COSArray)(cosAcroForm.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Fields)!);
      global::DripSharp.Testing.JavaAssertions.Equal(0, cosFields.Size(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Initially there shall be 0 fields"));
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = catalog.GetAcroForm();
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(acroForm.GetFields()),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "After call with default correction there shall be 0 fields"));
    }
  }

  internal virtual void testFromAnnots3891CreateFields() {
    string sourceUrl = "https://issues.apache.org/jira/secure/attachment/12881055/merge-test.pdf";
    string acrobatSourceUrl
      = "https://issues.apache.org/jira/secure/attachment/13014447/merge-test-na-acrobat.pdf";
    int numFormFieldsByAcrobat;
    global::System.Collections.Generic.IDictionary<string,
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField> fieldsByName
      = global::DripSharp.Runtime.JavaCompat.NewJavaDictionary<string,
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField>();
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf__204_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      acrobatSourceUrl)))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog__207_31
        = testPdf__204_25.GetDocumentCatalog();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm__208_24
        = catalog__207_31.GetAcroForm((global::DripSharp.PdfCarton.Pdmodel.Fixup.PDDocumentFixup)default!);
      numFormFieldsByAcrobat
        = global::DripSharp.Runtime.JavaCompat.CollectionCount(acroForm__208_24.GetFields());
      foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field__210_26 in acroForm__208_24.GetFieldTree()) {
        global::DripSharp.Runtime.JavaCompat.MapPut(fieldsByName,
          field__210_26.GetFullyQualifiedName(), field__210_26);
      }
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf__216_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      sourceUrl)))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog__219_31
        = testPdf__216_25.GetDocumentCatalog();
      global::DripSharp.PdfCarton.Cos.COSDictionary cosAcroForm
        = (global::DripSharp.PdfCarton.Cos.COSDictionary)(catalog__219_31.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.AcroForm)!);
      global::DripSharp.PdfCarton.Cos.COSArray cosFields
        = (global::DripSharp.PdfCarton.Cos.COSArray)(cosAcroForm.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Fields)!);
      global::DripSharp.Testing.JavaAssertions.Equal(0, cosFields.Size(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Initially there shall be 0 fields"));
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm__224_24
        = catalog__219_31.GetAcroForm(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFromAnnotsTest.CreateFieldsFixup(testPdf__216_25,
        this));
      global::DripSharp.Testing.JavaAssertions.Equal(numFormFieldsByAcrobat,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(acroForm__224_24.GetFields()),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("After rebuild there shall be ",
        numFormFieldsByAcrobat), " fields")));
      foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field__228_26 in acroForm__224_24.GetFieldTree()) {
        global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.Runtime.JavaCompat.MapGet(fieldsByName,
          field__228_26.GetFullyQualifiedName()), null);
      }
      global::DripSharp.Runtime.JavaCompat.ForEach(global::DripSharp.Runtime.JavaCompat.MapKeySet(fieldsByName),
        (fieldName)
        => global::DripSharp.Testing.JavaAssertions.NotNull(acroForm__224_24.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        fieldName)), null));
    }
  }

  internal virtual void testFromAnnots3891ValidateFont() {
    string sourceUrl = "https://issues.apache.org/jira/secure/attachment/12881055/merge-test.pdf";
    string acrobatSourceUrl
      = "https://issues.apache.org/jira/secure/attachment/13014447/merge-test-na-acrobat.pdf";
    global::System.Collections.Generic.IDictionary<string, string> fontNames
      = global::DripSharp.Runtime.JavaCompat.NewJavaDictionary<string, string>();
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf__257_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      acrobatSourceUrl)))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog__260_31
        = testPdf__257_25.GetDocumentCatalog();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm__261_24
        = catalog__260_31.GetAcroForm((global::DripSharp.PdfCarton.Pdmodel.Fixup.PDDocumentFixup)default!);
      global::DripSharp.PdfCarton.Pdmodel.PDResources acroFormResources__262_25
        = acroForm__261_24.GetDefaultResources();
      if ((acroFormResources__262_25 != default!)) {
        global::DripSharp.Runtime.JavaCompat.ForEach(acroFormResources__262_25.GetFontNames(),
          (fontName) => {
            try {
              global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font
              = acroFormResources__262_25.GetFont(fontName);
              string pdfBoxFontName = font.GetFontDescriptor().GetFontName();
              global::DripSharp.Runtime.JavaCompat.MapPut(fontNames, fontName.GetName(),
              pdfBoxFontName);
            } catch (global::System.IO.IOException) {}
          });
      }
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf__280_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      sourceUrl)))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog__283_31
        = testPdf__280_25.GetDocumentCatalog();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm__284_24
        = catalog__283_31.GetAcroForm(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFromAnnotsTest.CreateFieldsFixup(testPdf__280_25,
        this));
      global::DripSharp.PdfCarton.Pdmodel.PDResources acroFormResources__285_25
        = acroForm__284_24.GetDefaultResources();
      if ((acroFormResources__285_25 != default!)) {
        global::DripSharp.Runtime.JavaCompat.ForEach(acroFormResources__285_25.GetFontNames(),
          (fontName) => {
            try {
              global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font
              = acroFormResources__285_25.GetFont(fontName);
              string pdfBoxFontName = font.GetFontDescriptor().GetFontName();
              global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.MapGet(fontNames,
              fontName.GetName()), pdfBoxFontName,
              global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "font resource added by Acrobat shall match font resource added by PDFBox"));
            } catch (global::System.IO.IOException) {}
          });
      }
    }
  }

  internal virtual void testFromAnnots3891NullField() {
    string sourceUrl
      = "https://issues.apache.org/jira/secure/attachment/13016993/poppler-14433-0.pdf";
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      sourceUrl)))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog = testPdf.GetDocumentCatalog();
      global::DripSharp.Testing.JavaAssertions.DoesNotThrow(()
        => catalog.GetAcroForm(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFromAnnotsTest.CreateFieldsFixup(testPdf,
        this)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Getting the AcroForm shall not throw an exception"));
    }
  }

  internal class CreateFieldsFixup : global::DripSharp.PdfCarton.Pdmodel.Fixup.AbstractFixup {
    internal CreateFieldsFixup(global::DripSharp.PdfCarton.Pdmodel.PDDocument document,
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFromAnnotsTest __outer)
    : base(document) {
      this.__outer = __outer;
    }

    public override void Apply() {
      new global::DripSharp.PdfCarton.Pdmodel.Fixup.Processor.AcroFormOrphanWidgetsProcessor(base.Document).Process();
    }

    private readonly global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFromAnnotsTest __outer;
  }

  [Xunit.Fact]
  public void __Upstream_3903513051_91654bef70c8a2fd() {
    try {
      this.testFromAnnots3891CreateFields();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3835335948_084003787f72d6c6() {
    try {
      this.testFromAnnots3891DontCreateFields();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0832639597_d6adbeae9ee818cd() {
    try {
      this.testFromAnnots3891NullField();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3831275915_8bf269f44902bfc7() {
    try {
      this.testFromAnnots3891ValidateFont();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3271512812_75874f0909751387() {
    try {
      this.testFromAnnots4985CorrectionMode();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1878934169_929f06d2f3273580() {
    try {
      this.testFromAnnots4985DefaultMode();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2630249950_c196d5e11a159199() {
    try {
      this.testFromAnnots4985WithoutCorrectionMode();
    } finally {
    }
  }
}
