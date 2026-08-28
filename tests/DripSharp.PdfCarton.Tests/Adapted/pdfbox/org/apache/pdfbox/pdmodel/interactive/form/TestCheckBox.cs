// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class TestCheckBox {
  internal virtual void testCheckboxPDModel() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm form
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(doc);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox checkBox
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox(form);
      global::DripSharp.Testing.JavaAssertions.NotNull(checkBox.GetExportValues(), null);
      global::DripSharp.Testing.JavaAssertions.NotNull(checkBox.GetValue(), null);
      global::System.Collections.Generic.IList<string> options
        = new global::System.Collections.Generic.List<string>();
      global::DripSharp.Runtime.JavaCompat.Add(options, "Value01");
      global::DripSharp.Runtime.JavaCompat.Add(options, "Value02");
      checkBox.SetExportValues(options);
      global::DripSharp.PdfCarton.Cos.COSArray optItem
        = (global::DripSharp.PdfCarton.Cos.COSArray)(checkBox.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Opt)!);
      global::DripSharp.Testing.JavaAssertions.NotNull(checkBox.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Opt),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(2, optItem.Size(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ListGet(options,
        0), optItem.GetString(0), null);
      global::System.Collections.Generic.IList<string> retrievedOptions
        = checkBox.GetExportValues();
      global::DripSharp.Testing.JavaAssertions.Equal(2,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(retrievedOptions), null);
      global::DripSharp.Testing.JavaAssertions.Equal(retrievedOptions, options, null);
      checkBox.SetExportValues((global::System.Collections.Generic.IList<string>)default!);
      global::DripSharp.Testing.JavaAssertions.Null(checkBox.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Opt),
        null);
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(checkBox.GetExportValues()),
        null);
    }
  }

  internal virtual void testCheckBoxNoAppearance() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.PDPage page
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
      doc.AddPage(page);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(doc);
      acroForm.SetNeedAppearances(true);
      doc.GetDocumentCatalog().SetAcroForm(acroForm);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField> fields
        = new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField>();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox checkBox
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox(acroForm);
      checkBox.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "checkbox"));
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget
        = global::DripSharp.Runtime.JavaCompat.ListGet(checkBox.GetWidgets(), 0);
      widget.SetRectangle(new global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle((float)(50),
        (float)(600), (float)(100), (float)(100)));
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDBorderStyleDictionary bs
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDBorderStyleDictionary();
      bs.SetStyle(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDBorderStyleDictionary.StyleSolid));
      bs.SetWidth((float)(1));
      global::DripSharp.PdfCarton.Cos.COSDictionary acd
        = new global::DripSharp.PdfCarton.Cos.COSDictionary();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAppearanceCharacteristicsDictionary ac
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAppearanceCharacteristicsDictionary(acd);
      ac.SetBackground(new global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDColor(new float[] { 1,
          1, 0 }, global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance));
      ac.SetBorderColour(new global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDColor(new float[] { 1,
          0, 0 }, global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance));
      ac.SetNormalCaption(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "4"));
      widget.SetAppearanceCharacteristics(ac);
      widget.SetBorderStyle(bs);
      checkBox.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Off"));
      global::DripSharp.Runtime.JavaCompat.Add(fields, checkBox);
      global::DripSharp.Runtime.JavaCompat.Add(page.GetAnnotations(), widget);
      acroForm.SetFields(fields);
      global::DripSharp.Testing.JavaAssertions.Equal("Off", checkBox.GetValue(), null);
    }
  }

  internal virtual void testPDFBox6207() {
    global::System.IO.FileInfo pdfFile
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/pdfs/PDFBOX-6207.pdf"));
    if (!global::System.IO.File.Exists(pdfFile.FullName)) {
      return;
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfFile)) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = testPdf.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox field
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Check_Info_Post_andere"))!);
      global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => {
          field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Yes"));
        }, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Setting a valid value of a checkbox with an invalid /Opt entry should not throw an exception"));
    }
  }

  [Xunit.Fact]
  public void __Upstream_4258021370_6f1ea82aa9357073() {
    try {
      this.testCheckBoxNoAppearance();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3329182080_90a5ca4c24a5fb2c() {
    try {
      this.testCheckboxPDModel();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724634862_3f1577c1309cd020() {
    try {
      this.testPDFBox6207();
    } finally {
    }
  }
}
