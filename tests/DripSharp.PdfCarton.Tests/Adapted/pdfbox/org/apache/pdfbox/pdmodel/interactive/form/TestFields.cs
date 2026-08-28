// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class TestFields {
  private const string PATH_OF_PDF
    = "src/test/resources/org/apache/pdfbox/pdmodel/interactive/form/AcroFormsBasicFields.pdf";

  internal virtual void testFlags() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm form
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(doc);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField textBox
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(form);
      global::DripSharp.Testing.JavaAssertions.False(textBox.IsComb(), null);
      textBox.SetComb(true);
      global::DripSharp.Testing.JavaAssertions.True(textBox.IsComb(), null);
      textBox.SetComb(false);
      global::DripSharp.Testing.JavaAssertions.False(textBox.IsComb(), null);
      textBox.SetComb(true);
      textBox.SetDoNotScroll(true);
      global::DripSharp.Testing.JavaAssertions.True(textBox.IsComb(), null);
      global::DripSharp.Testing.JavaAssertions.True(textBox.DoNotScroll(), null);
      textBox.SetComb(false);
      textBox.SetDoNotScroll(false);
      global::DripSharp.Testing.JavaAssertions.False(textBox.IsComb(), null);
      global::DripSharp.Testing.JavaAssertions.False(textBox.DoNotScroll(), null);
      textBox.SetComb(false);
      global::DripSharp.Testing.JavaAssertions.False(textBox.IsComb(), null);
      textBox.SetComb(false);
      global::DripSharp.Testing.JavaAssertions.False(textBox.IsComb(), null);
      textBox.SetComb(true);
      global::DripSharp.Testing.JavaAssertions.True(textBox.IsComb(), null);
      textBox.SetComb(true);
      global::DripSharp.Testing.JavaAssertions.True(textBox.IsComb(), null);
    }
  }

  internal virtual void testAcroFormsBasicFields() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.TestFields.PATH_OF_PDF)))) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm form
        = doc.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.Testing.JavaAssertions.NotNull(form, null);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField textField
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(form.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "TextField"))!);
      global::DripSharp.Testing.JavaAssertions.Null(textField.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.V),
        null);
      textField.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "field value"));
      global::DripSharp.Testing.JavaAssertions.NotNull(textField.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.V),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal("field value", textField.GetValue(), null);
      global::DripSharp.Testing.JavaAssertions.NotNull(textField.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.V),
        null);
      textField.SetValue((string)default!);
      global::DripSharp.Testing.JavaAssertions.Null(textField.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.V),
        null);
      textField
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(form.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "TextField-DefaultValue"))!);
      global::DripSharp.Testing.JavaAssertions.NotNull(textField, null);
      global::DripSharp.Testing.JavaAssertions.Equal("DefaultValue", textField.GetDefaultValue(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(textField.GetDefaultValue(),
        ((global::DripSharp.PdfCarton.Cos.COSString)(textField.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Dv)!)).GetString(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal("/Helv 12 Tf 0 g",
        textField.GetDefaultAppearance(), null);
      textField
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(form.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "RichTextField-DefaultValue"))!);
      global::DripSharp.Testing.JavaAssertions.NotNull(textField, null);
      global::DripSharp.Testing.JavaAssertions.Equal("DefaultValue", textField.GetDefaultValue(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(textField.GetDefaultValue(),
        ((global::DripSharp.PdfCarton.Cos.COSString)(textField.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Dv)!)).GetString(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal("DefaultValue", textField.GetValue(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("/Helv 12 Tf 0 g",
        textField.GetDefaultAppearance(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("font: Helvetica,sans-serif 12.0pt; text-align:left; color:#000000 ",
        textField.GetDefaultStyleString(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(338, textField.GetRichTextValue().Length,
        null);
      textField
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(form.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "LongRichTextField"))!);
      global::DripSharp.Testing.JavaAssertions.NotNull(textField, null);
      global::DripSharp.Testing.JavaAssertions.Equal("org.apache.pdfbox.cos.COSStream",
        global::DripSharp.Runtime.JavaCompat.ClassName(((object)(textField.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.V))).GetType(),
        "DripSharp.PdfCarton", "org.apache.pdfbox"), null);
      global::DripSharp.Testing.JavaAssertions.Equal(145396, textField.GetValue().Length, null);
    }
  }

  internal virtual void testWidgetMissingRect() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.TestFields.PATH_OF_PDF)))) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm form
        = doc.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField textField
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(form.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "TextField-DefaultValue"))!);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget
        = global::DripSharp.Runtime.JavaCompat.ListGet(textField.GetWidgets(), 0);
      global::DripSharp.Testing.JavaAssertions.NotNull(widget.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Ap),
        null);
      widget.GetCOSObject().RemoveItem(global::DripSharp.PdfCarton.Cos.COSName.Rect);
      textField.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "field value"));
      global::DripSharp.Testing.JavaAssertions.Null(widget.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Ap),
        null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_1274583177_6da02cb439b855f7() {
    try {
      this.testAcroFormsBasicFields();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0944030997_4316b1edd312dc0f() {
    try {
      this.testFlags();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1078040852_9ab18f502d3073be() {
    try {
      this.testWidgetMissingRect();
    } finally {
    }
  }
}
