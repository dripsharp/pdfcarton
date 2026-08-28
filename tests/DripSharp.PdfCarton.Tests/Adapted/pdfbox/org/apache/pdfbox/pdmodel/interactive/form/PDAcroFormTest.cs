// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class PDAcroFormTest {
  private global::DripSharp.PdfCarton.Pdmodel.PDDocument document = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = null!;

  private static readonly global::System.IO.FileInfo OUT_DIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/test-output"));

  private static readonly global::System.IO.FileInfo IN_DIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "src/test/resources/org/apache/pdfbox/pdmodel/interactive/form"));

  internal virtual void setUp() {
    this.document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
    this.acroForm
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(this.document);
    this.document.GetDocumentCatalog().SetAcroForm(this.acroForm);
  }

  internal virtual void testFieldsEntry() {
    global::DripSharp.Testing.JavaAssertions.NotNull(this.acroForm.GetFields(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(0,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(this.acroForm.GetFields()), null);
    global::DripSharp.Testing.JavaAssertions.Null(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "foo")), null);
    this.acroForm.GetCOSObject().RemoveItem(global::DripSharp.PdfCarton.Cos.COSName.Fields);
    global::DripSharp.Testing.JavaAssertions.NotNull(this.acroForm.GetFields(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(0,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(this.acroForm.GetFields()), null);
    global::DripSharp.Testing.JavaAssertions.Null(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "foo")), null);
  }

  internal virtual void testAcroFormProperties() {
    global::DripSharp.Testing.JavaAssertions.True((this.acroForm.GetDefaultAppearance().Length
      == 0), null);
    this.acroForm.SetDefaultAppearance(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "/Helv 0 Tf 0 g"));
    global::DripSharp.Testing.JavaAssertions.Equal("/Helv 0 Tf 0 g",
      this.acroForm.GetDefaultAppearance(), null);
  }

  internal virtual void testFlatten() {
    global::System.IO.FileInfo file
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormTest.OUT_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignmentTests-flattened.pdf")));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormTest.IN_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "AlignmentTests.pdf"))))) {
      testPdf.GetDocumentCatalog().GetAcroForm().Flatten();
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(testPdf.GetDocumentCatalog().GetAcroForm().GetFields()),
        null);
      testPdf.Save(file);
    }
    if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.DoTestFile(file,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormTest.IN_DIR.FullName),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormTest.OUT_DIR.FullName)))) {
      global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Rendering of ",
        file), " failed or is not identical to expected rendering in "),
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormTest.IN_DIR),
        " directory")));
    }
  }

  internal virtual void testFlattenWidgetNoRef() {
    global::System.IO.FileInfo file
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormTest.OUT_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignmentTests-flattened-noRef.pdf")));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormTest.IN_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "AlignmentTests.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroFormToTest
        = testPdf.GetDocumentCatalog().GetAcroForm();
      foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field in acroFormToTest.GetFieldTree()) {
        global::DripSharp.Runtime.JavaCompat.ForEach(field.GetWidgets(), (widget)
          => widget.GetCOSObject().RemoveItem(global::DripSharp.PdfCarton.Cos.COSName.P));
      }
      acroFormToTest.Flatten();
      global::DripSharp.Testing.JavaAssertions.Equal(36,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(testPdf.GetPage(0).GetAnnotations()),
        null);
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(acroFormToTest.GetFields()),
        null);
      testPdf.Save(file);
    }
    if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.DoTestFile(file,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormTest.IN_DIR.FullName),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormTest.OUT_DIR.FullName)))) {
      global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Rendering of ",
        file), " failed or is not identical to expected rendering in "),
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormTest.IN_DIR),
        " directory")));
    }
  }

  internal virtual void testFlattenSpecificFieldsOnly() {
    global::System.IO.FileInfo file
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormTest.OUT_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AlignmentTests-flattened-specificFields.pdf")));
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField> fieldsToFlatten
      = new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField>();
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormTest.IN_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "AlignmentTests.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroFormToFlatten
        = testPdf.GetDocumentCatalog().GetAcroForm();
      int numFieldsBeforeFlatten
        = global::DripSharp.Runtime.JavaCompat.CollectionCount(acroFormToFlatten.GetFields());
      int numWidgetsBeforeFlatten = this.countWidgets(testPdf);
      global::DripSharp.Runtime.JavaCompat.Add(fieldsToFlatten,
        acroFormToFlatten.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "AlignLeft-Border_Small-Filled")));
      global::DripSharp.Runtime.JavaCompat.Add(fieldsToFlatten,
        acroFormToFlatten.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "AlignLeft-Border_Medium-Filled")));
      global::DripSharp.Runtime.JavaCompat.Add(fieldsToFlatten,
        acroFormToFlatten.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "AlignLeft-Border_Wide-Filled")));
      global::DripSharp.Runtime.JavaCompat.Add(fieldsToFlatten,
        acroFormToFlatten.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "AlignLeft-Border_Wide_Clipped-Filled")));
      acroFormToFlatten.Flatten(fieldsToFlatten, true);
      int numFieldsAfterFlatten
        = global::DripSharp.Runtime.JavaCompat.CollectionCount(acroFormToFlatten.GetFields());
      int numWidgetsAfterFlatten = this.countWidgets(testPdf);
      global::DripSharp.Testing.JavaAssertions.Equal(numFieldsBeforeFlatten, (numFieldsAfterFlatten
        + global::DripSharp.Runtime.JavaCompat.CollectionCount(fieldsToFlatten)), null);
      global::DripSharp.Testing.JavaAssertions.Equal(numWidgetsBeforeFlatten,
        (numWidgetsAfterFlatten
        + global::DripSharp.Runtime.JavaCompat.CollectionCount(fieldsToFlatten)), null);
      testPdf.Save(file);
    }
  }

  internal virtual void testDontAddMissingInformationOnDocumentLoad() {
    try {
      sbyte[] pdfBytes = this.createAcroFormWithMissingResourceInformation();
      using (global::DripSharp.PdfCarton.Pdmodel.PDDocument pdfDocument
        = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfBytes)) {
        global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog documentCatalog
          = pdfDocument.GetDocumentCatalog();
        global::DripSharp.PdfCarton.Cos.COSDictionary catalogDictionary
          = documentCatalog.GetCOSObject();
        global::DripSharp.PdfCarton.Cos.COSDictionary acroFormDictionary
          = (global::DripSharp.PdfCarton.Cos.COSDictionary)(catalogDictionary.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.AcroForm)!);
        global::DripSharp.Testing.JavaAssertions.Null(acroFormDictionary.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Da),
          null);
        global::DripSharp.Testing.JavaAssertions.Null(acroFormDictionary.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Resources),
          null);
      }
    } catch (global::System.IO.IOException) {
      global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Couldn't create test document, test skipped"));
    }
  }

  internal virtual void testAddMissingInformationOnAcroFormAccess() {
    try {
      sbyte[] pdfBytes = this.createAcroFormWithMissingResourceInformation();
      using (global::DripSharp.PdfCarton.Pdmodel.PDDocument pdfDocument
        = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfBytes)) {
        global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog documentCatalog
          = pdfDocument.GetDocumentCatalog();
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm theAcroForm
          = documentCatalog.GetAcroForm();
        global::DripSharp.Testing.JavaAssertions.Equal("/Helv 0 Tf 0 g ",
          theAcroForm.GetDefaultAppearance(), null);
        global::DripSharp.Testing.JavaAssertions.NotNull(theAcroForm.GetDefaultResources(), null);
        global::DripSharp.PdfCarton.Pdmodel.PDResources acroFormResources
          = theAcroForm.GetDefaultResources();
        global::DripSharp.Testing.JavaAssertions.NotNull(acroFormResources.GetFont(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "Helv"))), null);
        global::DripSharp.Testing.JavaAssertions.Equal("Helvetica",
          acroFormResources.GetFont(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "Helv"))).GetName(), null);
        global::DripSharp.Testing.JavaAssertions.NotNull(acroFormResources.GetFont(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "ZaDb"))), null);
        global::DripSharp.Testing.JavaAssertions.Equal("ZapfDingbats",
          acroFormResources.GetFont(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "ZaDb"))).GetName(), null);
      }
    } catch (global::System.IO.IOException) {
      global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Couldn't create test document, test skipped"));
    }
  }

  internal virtual void testBadDA() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.PDPage page
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
      doc.AddPage(page);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm theAcroForm
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(this.document);
      doc.GetDocumentCatalog().SetAcroForm(theAcroForm);
      theAcroForm.SetDefaultResources(new global::DripSharp.PdfCarton.Pdmodel.PDResources());
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField textBox
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(theAcroForm);
      textBox.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "SampleField"));
      textBox.SetDefaultAppearance(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "/Helv 0 tf 0 g"));
      global::DripSharp.Runtime.JavaCompat.Add(theAcroForm.GetFields(), textBox);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget
        = global::DripSharp.Runtime.JavaCompat.ListGet(textBox.GetWidgets(), 0);
      global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle rect
        = new global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle((float)(50), (float)(750),
        (float)(200), (float)(20));
      widget.SetRectangle(rect);
      widget.SetPage(page);
      global::DripSharp.Runtime.JavaCompat.Add(page.GetAnnotations(), widget);
      global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(()
        => textBox.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "huhu")),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "IllegalArgumentException should have been thrown"));
    }
  }

  internal virtual void testAcroFormDefaultFonts() {
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__306_25
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.PDPage page
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
      doc__306_25.AddPage(page);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm2__310_24
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(doc__306_25);
      doc__306_25.GetDocumentCatalog().SetAcroForm(acroForm2__310_24);
      global::DripSharp.PdfCarton.Pdmodel.PDResources defaultResources__312_25
        = acroForm2__310_24.GetDefaultResources();
      global::DripSharp.Testing.JavaAssertions.Null(defaultResources__312_25, null);
      defaultResources__312_25 = new global::DripSharp.PdfCarton.Pdmodel.PDResources();
      acroForm2__310_24.SetDefaultResources(defaultResources__312_25);
      global::DripSharp.Testing.JavaAssertions.Null(defaultResources__312_25.GetFont(global::DripSharp.PdfCarton.Cos.COSName.Helv),
        null);
      global::DripSharp.Testing.JavaAssertions.Null(defaultResources__312_25.GetFont(global::DripSharp.PdfCarton.Cos.COSName.ZaDb),
        null);
      acroForm2__310_24 = doc__306_25.GetDocumentCatalog().GetAcroForm();
      defaultResources__312_25 = acroForm2__310_24.GetDefaultResources();
      global::DripSharp.Testing.JavaAssertions.NotNull(defaultResources__312_25.GetFont(global::DripSharp.PdfCarton.Cos.COSName.Helv),
        null);
      global::DripSharp.Testing.JavaAssertions.NotNull(defaultResources__312_25.GetFont(global::DripSharp.PdfCarton.Cos.COSName.ZaDb),
        null);
      doc__306_25.GetDocumentCatalog().SetAcroForm(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(doc__306_25));
      acroForm2__310_24 = doc__306_25.GetDocumentCatalog().GetAcroForm();
      defaultResources__312_25 = acroForm2__310_24.GetDefaultResources();
      global::DripSharp.PdfCarton.Pdmodel.Font.PDFont helv__330_20
        = defaultResources__312_25.GetFont(global::DripSharp.PdfCarton.Cos.COSName.Helv);
      global::DripSharp.PdfCarton.Pdmodel.Font.PDFont zadb__331_20
        = defaultResources__312_25.GetFont(global::DripSharp.PdfCarton.Cos.COSName.ZaDb);
      global::DripSharp.Testing.JavaAssertions.NotNull(helv__330_20, null);
      global::DripSharp.Testing.JavaAssertions.NotNull(zadb__331_20, null);
      doc__306_25.Save(baos);
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__336_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos))) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm2__338_24
        = doc__336_25.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.PDResources defaultResources__339_25
        = acroForm2__338_24.GetDefaultResources();
      global::DripSharp.PdfCarton.Pdmodel.Font.PDFont helv__340_20
        = defaultResources__339_25.GetFont(global::DripSharp.PdfCarton.Cos.COSName.Helv);
      global::DripSharp.PdfCarton.Pdmodel.Font.PDFont zadb__341_20
        = defaultResources__339_25.GetFont(global::DripSharp.PdfCarton.Cos.COSName.ZaDb);
      global::DripSharp.Testing.JavaAssertions.NotNull(helv__340_20, null);
      global::DripSharp.Testing.JavaAssertions.NotNull(zadb__341_20, null);
      global::DripSharp.Testing.JavaAssertions.InstanceOf<global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font>(helv__340_20,
        null);
      global::DripSharp.Testing.JavaAssertions.InstanceOf<global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font>(zadb__341_20,
        null);
      global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font helvType1
        = (global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font)(helv__340_20!);
      global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font zadbType1
        = (global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font)(zadb__341_20!);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica.GetName(),
        helv__340_20.GetName(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.ZapfDingbats.GetName(),
        zadb__341_20.GetName(), null);
      global::DripSharp.Testing.JavaAssertions.Null(helvType1.GetType1Font(), null);
      global::DripSharp.Testing.JavaAssertions.Null(zadbType1.GetType1Font(), null);
    }
  }

  internal virtual void testIllegalFieldsDefinition() {
    string sourceUrl = "https://issues.apache.org/jira/secure/attachment/12866226/D1790B.PDF";
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      sourceUrl)))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog = testPdf.GetDocumentCatalog();
      global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => catalog.GetAcroForm(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Getting the AcroForm shall not throw an exception"));
    }
  }

  internal virtual void testPDFBox3347() {
    string sourceUrl
      = "https://issues.apache.org/jira/secure/attachment/12968302/KYF%20211%20Best%C3%A4llning%202014.pdf";
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      sourceUrl)))))) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field
        = doc.GetDocumentCatalog().GetAcroForm().GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Krematorier"));
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget> widgets
        = field.GetWidgets();
      global::System.Collections.Generic.ISet<string> set
        = global::DripSharp.Runtime.JavaCompat.NewSortedSet<string>();
      foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget annot in widgets) {
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAppearanceDictionary ap
          = annot.GetAppearance();
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAppearanceEntry normalAppearance
          = ap.GetNormalAppearance();
        global::System.Collections.Generic.ISet<global::DripSharp.PdfCarton.Cos.COSName> nameSet
          = global::DripSharp.Runtime.JavaCompat.MapKeySet(normalAppearance.GetSubDictionary());
        global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(nameSet,
          global::DripSharp.PdfCarton.Cos.COSName.Off), null);
        foreach (global::DripSharp.PdfCarton.Cos.COSName name in nameSet) {
          if (!(name.Equals(global::DripSharp.PdfCarton.Cos.COSName.Off))) {
            set.Add(name.GetName());
          }
        }
      }
      global::DripSharp.Testing.JavaAssertions.Equal("[Nyn\u00E4shamn, R\u00E5cksta, Silverdal, Skogskrem, St Botvid, Stork\u00E4llan]",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(set), null);
    }
  }

  internal virtual void testPDFBox5797() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "src/test/resources/org/apache/pdfbox/pdmodel/interactive/annotation/PDFBOX-5797-SO79271803.pdf")))) {
      global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font load
        = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(doc,
        global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroFormFromAnnotsTest),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "/org/apache/pdfbox/resources/ttf/LiberationSans-Regular.ttf")), false);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm theAcroForm
        = doc.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.PDResources resources = theAcroForm.GetDefaultResources();
      string fontName = resources.Add(load).GetName();
      string defaultAppearanceString
        = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("/",
        fontName), " 12 Tf 0 g");
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField myField
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(theAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Name"))!);
      myField.SetDefaultAppearance(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        defaultAppearanceString));
      global::DripSharp.Runtime.JavaCompat.ListGet(myField.GetWidgets(),
        0).SetAppearance((global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAppearanceDictionary)default!);
      myField.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "\u015E\u015E"));
      global::DripSharp.Testing.JavaAssertions.Equal("\u015E\u015E", myField.GetValue(), null);
    }
  }

  internal virtual void tearDown() {
    this.document.Dispose();
  }

  private sbyte[] createAcroFormWithMissingResourceInformation() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument tmpDocument
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream()) {
      global::DripSharp.PdfCarton.Pdmodel.PDPage page
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
      tmpDocument.AddPage(page);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm newAcroForm
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(this.document);
      tmpDocument.GetDocumentCatalog().SetAcroForm(newAcroForm);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField textBox
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(newAcroForm);
      textBox.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "SampleField"));
      global::DripSharp.Runtime.JavaCompat.Add(newAcroForm.GetFields(), textBox);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget
        = global::DripSharp.Runtime.JavaCompat.ListGet(textBox.GetWidgets(), 0);
      global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle rect
        = new global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle((float)(50), (float)(750),
        (float)(200), (float)(20));
      widget.SetRectangle(rect);
      widget.SetPage(page);
      global::DripSharp.Runtime.JavaCompat.Add(page.GetAnnotations(), widget);
      tmpDocument.Save(baos);
      return global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos);
    }
  }

  private int countWidgets(global::DripSharp.PdfCarton.Pdmodel.PDDocument documentToTest) {
    int count = 0;
    foreach (global::DripSharp.PdfCarton.Pdmodel.PDPage page in documentToTest.GetPages()) {
      try {
        foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation annotation in page.GetAnnotations()) {
          if ((annotation is global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget)) {
            count++;
          }
        }
      } catch (global::System.IO.IOException) {}
    }
    return count;
  }

  [Xunit.Fact]
  public void __Upstream_2642120408_a1c7d05cafb47d84() {
    this.setUp();
    try {
      this.testAcroFormDefaultFonts();
    } finally {
      this.tearDown();
    }
  }

  [Xunit.Fact]
  public void __Upstream_1866220808_104c4d6cb4fe6b89() {
    this.setUp();
    try {
      this.testAcroFormProperties();
    } finally {
      this.tearDown();
    }
  }

  [Xunit.Fact]
  public void __Upstream_2294800731_5313730badd3c885() {
    this.setUp();
    try {
      this.testAddMissingInformationOnAcroFormAccess();
    } finally {
      this.tearDown();
    }
  }

  [Xunit.Fact]
  public void __Upstream_0940010960_262a5840a096fd69() {
    this.setUp();
    try {
      this.testBadDA();
    } finally {
      this.tearDown();
    }
  }

  [Xunit.Fact]
  public void __Upstream_3571568676_4db49048fd5fafc5() {
    this.setUp();
    try {
      this.testDontAddMissingInformationOnDocumentLoad();
    } finally {
      this.tearDown();
    }
  }

  [Xunit.Fact]
  public void __Upstream_2719684935_373809b1fcf1742c() {
    this.setUp();
    try {
      this.testFieldsEntry();
    } finally {
      this.tearDown();
    }
  }

  [Xunit.Fact]
  public void __Upstream_0976080146_77b34c716d884d85() {
    this.setUp();
    try {
      this.testFlatten();
    } finally {
      this.tearDown();
    }
  }

  [Xunit.Fact]
  public void __Upstream_2515182985_a91e1844a4be5b75() {
    this.setUp();
    try {
      this.testFlattenSpecificFieldsOnly();
    } finally {
      this.tearDown();
    }
  }

  [Xunit.Fact]
  public void __Upstream_2400234172_2eca8f3053d0da5e() {
    this.setUp();
    try {
      this.testFlattenWidgetNoRef();
    } finally {
      this.tearDown();
    }
  }

  [Xunit.Fact]
  public void __Upstream_0125007760_0dd12c2ed92c5189() {
    this.setUp();
    try {
      this.testIllegalFieldsDefinition();
    } finally {
      this.tearDown();
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724546574_dc059680ccba31bb() {
    this.setUp();
    try {
      this.testPDFBox3347();
    } finally {
      this.tearDown();
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724610155_e5910a96478bc1c2() {
    this.setUp();
    try {
      this.testPDFBox5797();
    } finally {
      this.tearDown();
    }
  }
}
