// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class TestRadioButtons {
  internal static readonly global::System.IO.FileInfo TESTFILE3656
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "src/test/resources/org/apache/pdfbox/pdmodel/interactive/form/PDFBOX-3656-SF1199AEG (Complete).pdf"));

  internal virtual void testRadioButtonPDModel() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm form
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(doc);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton radioButton
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton(form);
      global::DripSharp.Testing.JavaAssertions.NotNull(radioButton.GetDefaultValue(), null);
      global::DripSharp.Testing.JavaAssertions.NotNull(radioButton.GetSelectedExportValues(), null);
      global::DripSharp.Testing.JavaAssertions.NotNull(radioButton.GetExportValues(), null);
      global::DripSharp.Testing.JavaAssertions.NotNull(radioButton.GetValue(), null);
      global::System.Collections.Generic.IList<string> options
        = new global::System.Collections.Generic.List<string>();
      global::DripSharp.Runtime.JavaCompat.Add(options, "Value01");
      global::DripSharp.Runtime.JavaCompat.Add(options, "Value02");
      radioButton.SetExportValues(options);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget> widgets
        = new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget>();
      for (int i = 0; (i < global::DripSharp.Runtime.JavaCompat.CollectionCount(options)); i++) {
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget
          = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget();
        global::DripSharp.PdfCarton.Cos.COSDictionary apNDict
          = new global::DripSharp.PdfCarton.Cos.COSDictionary();
        apNDict.SetItem(global::DripSharp.PdfCarton.Cos.COSName.Off,
          new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAppearanceStream(doc));
        apNDict.SetItem(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.ListGet(options, i)),
          new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAppearanceStream(doc));
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAppearanceDictionary appearance
          = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAppearanceDictionary();
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAppearanceEntry appearanceNEntry
          = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAppearanceEntry(apNDict);
        appearance.SetNormalAppearance(appearanceNEntry);
        widget.SetAppearance(appearance);
        widget.SetAppearanceState(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "Off"));
        global::DripSharp.Runtime.JavaCompat.Add(widgets, widget);
      }
      radioButton.SetWidgets(widgets);
      radioButton.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Value01"));
      global::DripSharp.Testing.JavaAssertions.Equal("Value01", radioButton.GetValue(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(radioButton.GetSelectedExportValues()),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal("Value01",
        global::DripSharp.Runtime.JavaCompat.ListGet(radioButton.GetSelectedExportValues(), 0),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal("Value01",
        global::DripSharp.Runtime.JavaCompat.ListGet(widgets, 0).GetAppearanceState().GetName(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal("Off",
        global::DripSharp.Runtime.JavaCompat.ListGet(widgets, 1).GetAppearanceState().GetName(),
        null);
      radioButton.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Value02"));
      global::DripSharp.Testing.JavaAssertions.Equal("Value02", radioButton.GetValue(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(radioButton.GetSelectedExportValues()),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal("Value02",
        global::DripSharp.Runtime.JavaCompat.ListGet(radioButton.GetSelectedExportValues(), 0),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal("Off",
        global::DripSharp.Runtime.JavaCompat.ListGet(widgets, 0).GetAppearanceState().GetName(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal("Value02",
        global::DripSharp.Runtime.JavaCompat.ListGet(widgets, 1).GetAppearanceState().GetName(),
        null);
      radioButton.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Off"));
      global::DripSharp.Testing.JavaAssertions.Equal("Off", radioButton.GetValue(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(radioButton.GetSelectedExportValues()),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal("Off",
        global::DripSharp.Runtime.JavaCompat.ListGet(widgets, 0).GetAppearanceState().GetName(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal("Off",
        global::DripSharp.Runtime.JavaCompat.ListGet(widgets, 1).GetAppearanceState().GetName(),
        null);
      global::DripSharp.PdfCarton.Cos.COSArray optItem
        = (global::DripSharp.PdfCarton.Cos.COSArray)(radioButton.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Opt)!);
      global::DripSharp.Testing.JavaAssertions.NotNull(radioButton.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Opt),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(2, optItem.Size(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ListGet(options,
        0), optItem.GetString(0), null);
      global::System.Collections.Generic.IList<string> retrievedOptions
        = radioButton.GetExportValues();
      global::DripSharp.Testing.JavaAssertions.Equal(2,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(retrievedOptions), null);
      global::DripSharp.Testing.JavaAssertions.Equal(retrievedOptions, options, null);
      radioButton.SetExportValues((global::System.Collections.Generic.IList<string>)default!);
      global::DripSharp.Testing.JavaAssertions.Null(radioButton.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Opt),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(radioButton.GetExportValues(),
        new global::System.Collections.Generic.List<object>(), null);
    }
  }

  internal virtual void testPDFBox3656NotInUnison() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.TestRadioButtons.TESTFILE3656)) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = testPdf.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton field
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Checking/Savings"))!);
      global::DripSharp.Testing.JavaAssertions.False(field.IsRadiosInUnison(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "the radio buttons can be selected individually although having the same ON value"));
    }
  }

  internal virtual void testPDFBox3656ByValidExportValue() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.TestRadioButtons.TESTFILE3656)) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = testPdf.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton field
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Checking/Savings"))!);
      global::DripSharp.Testing.JavaAssertions.False(field.IsRadiosInUnison(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "the radio buttons can be selected individually although having the same ON value"));
      global::DripSharp.Testing.JavaAssertions.Equal("Off", field.GetValue(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "initially no option shall be selected"));
      field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Checking"));
      global::DripSharp.Testing.JavaAssertions.Equal("Checking", field.GetValue(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "setting by the export value should also return that"));
    }
  }

  internal virtual void testPDFBox3656ByInvalidExportValue() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.TestRadioButtons.TESTFILE3656)) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = testPdf.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton field
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Checking/Savings"))!);
      global::DripSharp.Testing.JavaAssertions.False(field.IsRadiosInUnison(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "the radio buttons can be selected individually although having the same ON value"));
      global::DripSharp.Testing.JavaAssertions.Equal("Off", field.GetValue(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "initially no option shall be selected"));
      global::System.Exception exception
        = global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => {
          field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Invalid"));
        }, null);
      string expectedMessage
        = "value 'Invalid' is not a valid option for the field Checking/Savings, valid values are: [Checking, Savings] and Off";
      string actualMessage = global::DripSharp.Runtime.JavaCompat.ExceptionMessage(exception);
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(actualMessage,
        expectedMessage), null);
      global::DripSharp.Testing.JavaAssertions.Equal("Off", field.GetValue(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "no option shall be selected"));
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(field.GetSelectedExportValues()),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "no export values are selected"));
    }
  }

  internal virtual void testPDFBox3656ByValidIndex() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.TestRadioButtons.TESTFILE3656)) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = testPdf.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton field
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Checking/Savings"))!);
      global::DripSharp.Testing.JavaAssertions.False(field.IsRadiosInUnison(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "the radio buttons can be selected individually although having the same ON value"));
      global::DripSharp.Testing.JavaAssertions.Equal("Off", field.GetValue(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "initially no option shall be selected"));
      field.SetValue(4);
      global::DripSharp.Testing.JavaAssertions.Equal("Checking", field.GetValue(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "setting by the index value should return the corresponding export"));
    }
  }

  internal virtual void testPDFBox3656ByInvalidIndex() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.TestRadioButtons.TESTFILE3656)) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = testPdf.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton field
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Checking/Savings"))!);
      global::DripSharp.Testing.JavaAssertions.False(field.IsRadiosInUnison(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "the radio buttons can be selected individually although having the same ON value"));
      global::DripSharp.Testing.JavaAssertions.Equal("Off", field.GetValue(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "initially no option shall be selected"));
      global::System.Exception exception
        = global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => {
          field.SetValue(6);
        }, null);
      string expectedMessage
        = "index '6' is not a valid index for the field Checking/Savings, valid indices are from 0 to 5";
      string actualMessage = global::DripSharp.Runtime.JavaCompat.ExceptionMessage(exception);
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(actualMessage,
        expectedMessage), null);
      global::DripSharp.Testing.JavaAssertions.Equal("Off", field.GetValue(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "no option shall be selected"));
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(field.GetSelectedExportValues()),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "no export values are selected"));
    }
  }

  internal virtual void testPDFBox4617IndexNoneSelected() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.TestRadioButtons.TESTFILE3656)) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = testPdf.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton field
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Checking/Savings"))!);
      global::DripSharp.Testing.JavaAssertions.Equal(-1, field.GetSelectedIndex(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "if there is no value set the index shall be -1"));
    }
  }

  internal virtual void testPDFBox4617IndexForSetByOption() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.TestRadioButtons.TESTFILE3656)) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = testPdf.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton field
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Checking/Savings"))!);
      field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Checking"));
      global::DripSharp.Testing.JavaAssertions.Equal(0, field.GetSelectedIndex(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "the index shall be equal with the first entry of Checking which is 0"));
    }
  }

  internal virtual void testPDFBox4617IndexForSetByIndex() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.TestRadioButtons.TESTFILE3656)) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = testPdf.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton field
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Checking/Savings"))!);
      field.SetValue(4);
      global::DripSharp.Testing.JavaAssertions.Equal("Checking", field.GetValue(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "setting by the index value should return the corresponding export"));
      global::DripSharp.Testing.JavaAssertions.Equal(4, field.GetSelectedIndex(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "the index shall be equals with the set value of 4"));
    }
  }

  internal virtual void testPDFBox5831NumericValueForOpt() {
    string sourceUrl
      = "https://issues.apache.org/jira/secure/attachment/13069137/AU_Erklaerung_final.pdf";
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      sourceUrl)))))) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = testPdf.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton field
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Formular1[0].Seite1[0].TF_P[0].Optionsfeldliste[0]"))!);
      field.SetValue(0);
      global::DripSharp.Testing.JavaAssertions.Equal("1", field.GetValue(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "0")), field.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.V),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(0, field.GetSelectedIndex(), null);
      field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "1"));
      global::DripSharp.Testing.JavaAssertions.Equal("1", field.GetValue(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "0")), field.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.V),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(0, field.GetSelectedIndex(), null);
      field.SetValue(1);
      global::DripSharp.Testing.JavaAssertions.Equal("2", field.GetValue(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "1")), field.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.V),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(1, field.GetSelectedIndex(), null);
      field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "2"));
      global::DripSharp.Testing.JavaAssertions.Equal("2", field.GetValue(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "1")), field.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.V),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(1, field.GetSelectedIndex(), null);
    }
  }

  internal virtual void testPDFBox6178NonAsciiRadioButtonValue() {
    global::System.IO.FileInfo pdfFile
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/pdfs/PDFBOX-6178.pdf"));
    if (!global::System.IO.File.Exists(pdfFile.FullName)) {
      return;
    }
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__390_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfFile)) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm__392_24
        = document__390_25.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field__393_21
        = acroForm__392_24.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Geschlecht"));
      field__393_21.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "m\u00E4nnlich"));
      global::DripSharp.PdfCarton.Cos.COSName vEntry__398_21
        = (global::DripSharp.PdfCarton.Cos.COSName)(field__393_21.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.V)!);
      global::DripSharp.Testing.JavaAssertions.NotNull(vEntry__398_21,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "V entry should not be null after setValue"));
      sbyte[] vBytes__402_20 = vEntry__398_21.GetBytes();
      global::DripSharp.Testing.JavaAssertions.False(this.containsSequence(vBytes__402_20,
        new sbyte[] { unchecked((sbyte)(195)), unchecked((sbyte)(164)) }),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "V entry should not contain UTF-8 encoded \u00E4 (0xC3 0xA4)"));
      global::DripSharp.Testing.JavaAssertions.True(this.containsSequence(vBytes__402_20,
        new sbyte[] { unchecked((sbyte)(228)) }),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "V entry should contain ISO-8859-1 encoded \u00E4 (0xE4)"));
      global::DripSharp.PdfCarton.Cos.COSName asEntry__410_21
        = (global::DripSharp.PdfCarton.Cos.COSName)(global::DripSharp.Runtime.JavaCompat.ListGet(field__393_21.GetWidgets(),
        0).GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.As)!);
      global::DripSharp.Testing.JavaAssertions.NotNull(asEntry__410_21,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "AS entry should not be null after setValue"));
      sbyte[] asBytes__415_20 = asEntry__410_21.GetBytes();
      global::DripSharp.Testing.JavaAssertions.False(this.containsSequence(asBytes__415_20,
        new sbyte[] { unchecked((sbyte)(195)), unchecked((sbyte)(164)) }),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "AS entry should not contain UTF-8 encoded \u00E4 (0xC3 0xA4)"));
      global::DripSharp.Testing.JavaAssertions.True(this.containsSequence(asBytes__415_20,
        new sbyte[] { unchecked((sbyte)(228)) }),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "AS entry should contain ISO-8859-1 encoded \u00E4 (0xE4)"));
      document__390_25.Save(baos);
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__426_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos))) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm__428_24
        = document__426_25.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field__429_21
        = acroForm__428_24.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Geschlecht"));
      global::DripSharp.PdfCarton.Cos.COSName vEntry__432_21
        = (global::DripSharp.PdfCarton.Cos.COSName)(field__429_21.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.V)!);
      global::DripSharp.Testing.JavaAssertions.NotNull(vEntry__432_21,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "V entry should not be null after reload"));
      sbyte[] vBytes__435_20 = vEntry__432_21.GetBytes();
      global::DripSharp.Testing.JavaAssertions.False(this.containsSequence(vBytes__435_20,
        new sbyte[] { unchecked((sbyte)(195)), unchecked((sbyte)(164)) }),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "V entry should still not contain UTF-8 \u00E4 after reload"));
      global::DripSharp.Testing.JavaAssertions.True(this.containsSequence(vBytes__435_20,
        new sbyte[] { unchecked((sbyte)(228)) }),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "V entry should still contain ISO-8859-1 \u00E4 after reload"));
      global::DripSharp.PdfCarton.Cos.COSName asEntry__442_21
        = (global::DripSharp.PdfCarton.Cos.COSName)(global::DripSharp.Runtime.JavaCompat.ListGet(field__429_21.GetWidgets(),
        0).GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.As)!);
      global::DripSharp.Testing.JavaAssertions.NotNull(asEntry__442_21,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "AS entry should not be null after reload"));
      sbyte[] asBytes__446_20 = asEntry__442_21.GetBytes();
      global::DripSharp.Testing.JavaAssertions.False(this.containsSequence(asBytes__446_20,
        new sbyte[] { unchecked((sbyte)(195)), unchecked((sbyte)(164)) }),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "AS entry should still not contain UTF-8 \u00E4 after reload"));
      global::DripSharp.Testing.JavaAssertions.True(this.containsSequence(asBytes__446_20,
        new sbyte[] { unchecked((sbyte)(228)) }),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "AS entry should still contain ISO-8859-1 \u00E4 after reload"));
    }
  }

  private bool containsSequence(sbyte[] haystack, sbyte[] needle) {
    if ((needle.Length == 0)) {
      return true;
    }
    if ((needle.Length > haystack.Length)) {
      return false;
    }
    for (int i = 0; (i <= (haystack.Length - needle.Length)); i++) {
      bool match = true;
      for (int j = 0; (j < needle.Length); j++) {
        if (((int)(haystack[(i + j)]) != (int)(needle[j]))) {
          match = false;
          break;
        }
      }
      if (match) {
        return true;
      }
    }
    return false;
  }

  [Xunit.Fact]
  public void __Upstream_0493884524_ff5bd98cb58440ad() {
    try {
      this.testPDFBox3656ByInvalidExportValue();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1046816353_a898c4854f2a4da0() {
    try {
      this.testPDFBox3656ByInvalidIndex();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0155085511_1c9c1985e24833b7() {
    try {
      this.testPDFBox3656ByValidExportValue();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3755875580_a4c6b239851da2d8() {
    try {
      this.testPDFBox3656ByValidIndex();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0678697771_31bb2a0be5c0cdac() {
    try {
      this.testPDFBox3656NotInUnison();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1456745635_5812cd1d82dbfd9d() {
    try {
      this.testPDFBox4617IndexForSetByIndex();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2383544004_11d481556295ee60() {
    try {
      this.testPDFBox4617IndexForSetByOption();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1202868946_82e0027eca3232c7() {
    try {
      this.testPDFBox4617IndexNoneSelected();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1361097530_e81376033bb53d2f() {
    try {
      this.testPDFBox5831NumericValueForOpt();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4270431791_6b384de466bb11f0() {
    try {
      this.testPDFBox6178NonAsciiRadioButtonValue();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0835666458_f8f5b910bfda3331() {
    try {
      this.testRadioButtonPDModel();
    } finally {
    }
  }
}
