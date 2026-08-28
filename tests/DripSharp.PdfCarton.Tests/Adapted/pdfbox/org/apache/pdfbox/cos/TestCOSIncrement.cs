// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Cos;

public class TestCOSIncrement {
  internal static void init() {
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/test-output")));
  }

  internal virtual void testIncrementallyCreateDocument() {
    sbyte[] documentData = new sbyte[0];
    using (global::DripSharp.Runtime.JavaByteArrayOutputStream documentOutput__77_35
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream()) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__78_24
      = global::DripSharp.Testing.JavaAssertions.DoesNotThrow(()
      => new global::DripSharp.PdfCarton.Pdmodel.PDDocument(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Creating the document failed."))) {
      document__78_24.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage(new global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle((float)(100),
        (float)(100))));
      document__78_24.Save(documentOutput__77_35);
      documentData = global::DripSharp.Runtime.JavaCompat.ToSignedBytes(documentOutput__77_35);
    }
    using (global::DripSharp.Runtime.JavaByteArrayOutputStream documentOutput__89_35
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream()) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__90_24
      = this.loadDocument(documentData)) {
      global::DripSharp.Testing.JavaAssertions.Equal(1, document__90_24.GetNumberOfPages(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Document should have contained 1 page."));
      document__90_24.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage(new global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle((float)(200),
        (float)(200))));
      document__90_24.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage(new global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle((float)(100),
        (float)(100))));
      document__90_24.SaveIncremental(documentOutput__89_35);
      documentData = global::DripSharp.Runtime.JavaCompat.ToSignedBytes(documentOutput__89_35);
    }
    using (global::DripSharp.Runtime.JavaByteArrayOutputStream documentOutput__102_35
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream()) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__103_24
      = this.loadDocument(documentData)) {
      global::DripSharp.Testing.JavaAssertions.Equal(3, document__103_24.GetNumberOfPages(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Document should have contained 3 pages."));
      document__103_24.RemovePage(document__103_24.GetPage(1));
      document__103_24.SaveIncremental(documentOutput__102_35);
      documentData = global::DripSharp.Runtime.JavaCompat.ToSignedBytes(documentOutput__102_35);
    }
    using (global::DripSharp.Runtime.JavaByteArrayOutputStream documentOutput__114_35
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream()) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__115_24
      = this.loadDocument(documentData)) {
      global::DripSharp.Testing.JavaAssertions.NotEqual((float)(200),
        document__115_24.GetPage(1).GetMediaBox().GetWidth(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Page 2 removal failed."));
      global::DripSharp.Testing.JavaAssertions.Equal(2, document__115_24.GetNumberOfPages(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Document should have contained 2 pages."));
      global::DripSharp.Testing.JavaAssertions.False(document__115_24.GetPage(0).HasContents(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 1 should not have had contents."));
      global::DripSharp.Testing.JavaAssertions.Null(document__115_24.GetPage(0).GetResources(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 1 should not have contained resources"));
      global::DripSharp.Testing.JavaAssertions.False(document__115_24.GetPage(1).HasContents(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 2 should not have had contents."));
      global::DripSharp.Testing.JavaAssertions.Null(document__115_24.GetPage(1).GetResources(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 2 should not have contained resources"));
      using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream__124_38
        = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__115_24,
        document__115_24.GetPage(0))) {
        global::System.Uri imageResource
          = global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Cos.TestCOSIncrement),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "simple.png"));
        global::DripSharp.Testing.JavaAssertions.NotNull(imageResource,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "Image resource not found."));
        global::System.IO.FileInfo image = global::DripSharp.Testing.JavaAssertions.DoesNotThrow(()
          => global::DripSharp.Runtime.JavaCompat.NewFileInfo(imageResource),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "Image file could not be loaded"));
        contentStream__124_38.DrawImage(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromFileByExtension(image,
          document__115_24), (float)(15), (float)(20));
      }
      document__115_24.SaveIncremental(documentOutput__114_35);
      documentData = global::DripSharp.Runtime.JavaCompat.ToSignedBytes(documentOutput__114_35);
    }
    using (global::DripSharp.Runtime.JavaByteArrayOutputStream documentOutput__138_35
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream()) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__139_24
      = this.loadDocument(documentData)) {
      global::DripSharp.Testing.JavaAssertions.True(document__139_24.GetPage(0).HasContents(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 1 should have had contents."));
      global::DripSharp.Testing.JavaAssertions.NotNull(document__139_24.GetPage(0).GetResources(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 1 should have contained resources"));
      global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.Iterator(document__139_24.GetPage(0).GetResources().GetFontNames()).HasNext(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 1 should not have contained a font"));
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.Iterator(document__139_24.GetPage(0).GetResources().GetXObjectNames()).HasNext(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 1 should have contained an XObject"));
      global::DripSharp.Testing.JavaAssertions.False(document__139_24.GetPage(1).HasContents(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 2 should not have had contents."));
      global::DripSharp.Testing.JavaAssertions.Null(document__139_24.GetPage(1).GetResources(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 2 should not have contained resources"));
      using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream__150_38
        = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__139_24,
        document__139_24.GetPage(1))) {
        contentStream__150_38.BeginText();
        contentStream__150_38.SetFont(new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica),
          (float)(20));
        contentStream__150_38.NewLineAtOffset((float)(20), (float)(50));
        contentStream__150_38.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "Page 2"));
        contentStream__150_38.EndText();
      }
      document__139_24.SaveIncremental(documentOutput__138_35);
      documentData = global::DripSharp.Runtime.JavaCompat.ToSignedBytes(documentOutput__138_35);
    }
    using (global::DripSharp.Runtime.JavaByteArrayOutputStream documentOutput__164_35
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream()) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__165_24
      = this.loadDocument(documentData)) {
      global::DripSharp.Testing.JavaAssertions.True(document__165_24.GetPage(0).HasContents(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 1 should have had contents."));
      global::DripSharp.Testing.JavaAssertions.NotNull(document__165_24.GetPage(0).GetResources(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 1 should have contained resources"));
      global::DripSharp.Testing.JavaAssertions.NotNull(document__165_24.GetPage(1).GetResources(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 2 should have contained resources"));
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(document__165_24.GetPage(1).GetAnnotations()),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 2 should not have contained an annotation."));
      global::DripSharp.Testing.JavaAssertions.True(document__165_24.GetPage(1).HasContents(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 2 should have had contents."));
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.Iterator(document__165_24.GetPage(1).GetResources().GetFontNames()).HasNext(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 2 should have contained a font"));
      global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.Iterator(document__165_24.GetPage(1).GetResources().GetXObjectNames()).HasNext(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 1 should not have contained an XObject"));
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationText textAnnotation
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationText();
      textAnnotation.SetName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "text annotation"));
      textAnnotation.SetContents(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "text annotation"));
      textAnnotation.SetOpen(true);
      textAnnotation.SetColor(new global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDColor(new float[] { 1,
          0, 0 }, global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance));
      textAnnotation.SetRectangle(new global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle((float)(4),
        (float)(5), (float)(10), (float)(10)));
      textAnnotation.ConstructAppearances(document__165_24);
      global::DripSharp.Runtime.JavaCompat.Add(document__165_24.GetPage(1).GetAnnotations(),
        textAnnotation);
      document__165_24.SaveIncremental(documentOutput__164_35);
      documentData = global::DripSharp.Runtime.JavaCompat.ToSignedBytes(documentOutput__164_35);
    }
    using (global::DripSharp.Runtime.JavaByteArrayOutputStream documentOutput__192_35
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream()) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__193_24
      = this.loadDocument(documentData)) {
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(document__193_24.GetPage(1).GetAnnotations()),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 2 should have contained an annotation."));
      document__193_24.SaveIncremental(documentOutput__192_35);
      documentData = global::DripSharp.Runtime.JavaCompat.ToSignedBytes(documentOutput__192_35);
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__204_24
      = this.loadDocument(documentData)) {
      global::DripSharp.Testing.JavaAssertions.Equal(2, document__204_24.GetNumberOfPages(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Document should have contained 2 pages."));
      global::DripSharp.Testing.JavaAssertions.NotNull(document__204_24.GetPage(0).GetResources(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 1 should have contained resources"));
      global::DripSharp.Testing.JavaAssertions.NotNull(document__204_24.GetPage(1).GetResources(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 2 should have contained resources"));
      global::DripSharp.Testing.JavaAssertions.True(document__204_24.GetPage(0).HasContents(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 1 should have had contents."));
      global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.Iterator(document__204_24.GetPage(0).GetResources().GetFontNames()).HasNext(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 1 should not have contained a font"));
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.Iterator(document__204_24.GetPage(0).GetResources().GetXObjectNames()).HasNext(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 1 should have contained an XObject"));
      global::DripSharp.Testing.JavaAssertions.True(document__204_24.GetPage(1).HasContents(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 2 should have had contents."));
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(document__204_24.GetPage(1).GetAnnotations()),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 2 should have contained an annotation."));
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.Iterator(document__204_24.GetPage(1).GetResources().GetFontNames()).HasNext(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page 2 should have contained a font"));
    }
  }

  internal virtual void testConcurrentModification() {
    global::System.Uri pdfLocation
      = global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "https://issues.apache.org/jira/secure/attachment/12891316/YTW2VWJQTDAE67PGJT6GS7QSKW3GNUQR.pdf"));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(pdfLocation)))) {
      document.SetAllSecurityToBeRemoved(true);
      global::DripSharp.Testing.JavaAssertions.DoesNotThrow(()
        => document.Save(new global::DripSharp.Runtime.JavaByteArrayOutputStream()), null);
    }
  }

  private global::DripSharp.PdfCarton.Pdmodel.PDDocument loadDocument(sbyte[] documentData) {
    return global::DripSharp.Testing.JavaAssertions.DoesNotThrow(()
      => global::DripSharp.PdfCarton.Loader.LoadPDF(documentData),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Loading the document failed."));
  }

  internal virtual void testSubsetting() {
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__267_25
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.PDPage page__269_20
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
      document__267_25.AddPage(page__269_20);
      document__267_25.Save(baos);
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__274_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos))) using (global::System.IO.Stream os
      = global::DripSharp.Runtime.JavaCompat.OpenFileOutput(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/test-output/PDFBOX-5627.pdf"))) {
      global::DripSharp.PdfCarton.Pdmodel.PDPage page__277_20 = document__274_25.GetPage(0);
      global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font__279_20
        = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(document__274_25,
        global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Cos.TestCOSIncrement),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "/org/apache/pdfbox/resources/ttf/LiberationSans-Regular.ttf")));
      using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream
        = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__274_25,
        page__277_20)) {
        contentStream.BeginText();
        contentStream.SetFont(font__279_20, (float)(12));
        contentStream.NewLineAtOffset((float)(75), (float)(750));
        contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "Apache PDFBox"));
        contentStream.EndText();
      }
      global::DripSharp.PdfCarton.Cos.COSDictionary catalog
        = document__274_25.GetDocumentCatalog().GetCOSObject();
      ((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(catalog)).SetNeedToBeUpdated(true);
      global::DripSharp.PdfCarton.Cos.COSDictionary pages
        = catalog.GetCOSDictionary(global::DripSharp.PdfCarton.Cos.COSName.Pages);
      ((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(pages)).SetNeedToBeUpdated(true);
      ((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(page__277_20.GetCOSObject())).SetNeedToBeUpdated(true);
      document__274_25.SaveIncremental(os);
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__300_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/test-output/PDFBOX-5627.pdf")))) {
      global::DripSharp.PdfCarton.Pdmodel.PDPage page__302_20 = document__300_25.GetPage(0);
      global::DripSharp.PdfCarton.Cos.COSName fontName
        = global::DripSharp.Runtime.JavaCompat.Iterator(page__302_20.GetResources().GetFontNames()).Next()!;
      global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font__304_20
        = page__302_20.GetResources().GetFont(fontName);
      global::DripSharp.Testing.JavaAssertions.True(font__304_20.IsEmbedded(), null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_3069478949_b686fcdff344e4e4() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testConcurrentModification();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4152202508_e23d325484dbe2ae() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testIncrementallyCreateDocument();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0273144386_a624a6b4f6ff1bfd() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testSubsetting();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

  private static bool __RunUpstreamBeforeAll() {
    init();
    return true;
  }
}
