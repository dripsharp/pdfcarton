// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Multipdf;

public class TestLayerUtility {
  private static readonly global::System.IO.FileInfo TESTRESULTSDIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/test-output"));

  internal static void setUp() {
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Multipdf.TestLayerUtility.TESTRESULTSDIR);
  }

  internal virtual void testLayerImport() {
    global::System.IO.FileInfo mainPDF = this.createMainPDF();
    global::System.IO.FileInfo overlay1 = this.createOverlay1();
    global::System.IO.FileInfo targetFile
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.TestLayerUtility.TESTRESULTSDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "text-with-form-overlay.pdf")));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument targetDoc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(mainPDF)) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument overlay1Doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(overlay1)) {
      global::DripSharp.Testing.JavaAssertions.Equal(1.4F, targetDoc.GetVersion(), null);
      global::DripSharp.PdfCarton.Multipdf.LayerUtility layerUtil
        = new global::DripSharp.PdfCarton.Multipdf.LayerUtility(targetDoc);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Form.PDFormXObject form
        = layerUtil.ImportPageAsForm(overlay1Doc, 0);
      global::DripSharp.PdfCarton.Pdmodel.PDPage targetPage = targetDoc.GetPage(0);
      layerUtil.WrapInSaveRestore(targetPage);
      global::SkiaSharp.SKMatrix at = global::DripSharp.Runtime.PdfCartonFontCompat.Identity();
      layerUtil.AppendFormAsLayer(targetPage, form, at,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "overlay"));
      global::DripSharp.Testing.JavaAssertions.Equal(1.5F, targetDoc.GetVersion(), null);
      targetDoc.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        targetFile.FullName),
        global::DripSharp.PdfCarton.Pdfwriter.Compress.CompressParameters.NoCompression);
      global::DripSharp.Testing.JavaAssertions.Equal(1.5F, targetDoc.GetVersion(), null);
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(targetFile)) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog = doc.GetDocumentCatalog();
      global::DripSharp.Testing.JavaAssertions.Equal(1.5F, doc.GetVersion(), null);
      global::DripSharp.PdfCarton.Pdmodel.PDPage page = doc.GetPage(0);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup ocg
        = (global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup)(page.GetResources().GetProperties(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "oc1")))!);
      global::DripSharp.Testing.JavaAssertions.NotNull(ocg, null);
      global::DripSharp.Testing.JavaAssertions.Equal("overlay", ocg.GetName(), null);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentProperties ocgs
        = catalog.GetOCProperties();
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup overlay
        = ocgs.GetGroup(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "overlay"));
      global::DripSharp.Testing.JavaAssertions.Equal(ocg.GetName(), overlay.GetName(), null);
      new global::DripSharp.PdfCarton.Multipdf.LayerUtility(doc).ImportPageAsForm(doc, 0);
    }
  }

  private global::System.IO.FileInfo createMainPDF() {
    global::System.IO.FileInfo targetFile
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.TestLayerUtility.TESTRESULTSDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "text-doc.pdf")));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.PDPage page
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
      doc.AddPage(page);
      global::DripSharp.PdfCarton.Pdmodel.PDResources resources = page.GetResources();
      if ((resources == default!)) {
        resources = new global::DripSharp.PdfCarton.Pdmodel.PDResources();
        page.SetResources(resources);
      }
      string[] text
        = new string[] { "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer fermentum lacus in eros",
        "condimentum eget tristique risus viverra. Sed ac sem et lectus ultrices placerat. Nam",
        "fringilla tincidunt nulla id euismod. Vivamus eget mauris dui. Mauris luctus ullamcorper",
        "leo, et laoreet diam suscipit et. Nulla viverra commodo sagittis. Integer vitae rhoncus velit.",
        "Mauris porttitor ipsum in est sagittis non luctus purus molestie. Sed placerat aliquet",
      "vulputate." };
      using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream
        = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page,
        global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Overwrite, false)) {
        global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font
          = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.HelveticaBold);
        contentStream.BeginText();
        contentStream.NewLineAtOffset((float)(50), (float)(720));
        contentStream.SetFont(font, (float)(14));
        contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "Simple test document with text."));
        contentStream.EndText();
        font
          = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica);
        contentStream.BeginText();
        int fontSize = 12;
        contentStream.SetFont(font, (float)(fontSize));
        contentStream.NewLineAtOffset((float)(50), (float)(700));
        foreach (string line in text) {
          contentStream.NewLineAtOffset((float)(0), (-fontSize * 1.2F));
          contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            line));
        }
        contentStream.EndText();
      }
      doc.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", targetFile.FullName),
        global::DripSharp.PdfCarton.Pdfwriter.Compress.CompressParameters.NoCompression);
    }
    return targetFile;
  }

  private global::System.IO.FileInfo createOverlay1() {
    global::System.IO.FileInfo targetFile
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.TestLayerUtility.TESTRESULTSDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "overlay1.pdf")));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.PDPage page
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
      doc.AddPage(page);
      global::DripSharp.PdfCarton.Pdmodel.PDResources resources = page.GetResources();
      if ((resources == default!)) {
        resources = new global::DripSharp.PdfCarton.Pdmodel.PDResources();
        page.SetResources(resources);
      }
      using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream
        = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page,
        global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Overwrite, false)) {
        global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font
          = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.HelveticaBold);
        contentStream.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.LightGray);
        contentStream.BeginText();
        float fontSize = 96;
        contentStream.SetFont(font, fontSize);
        string text = "OVERLAY";
        global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle crop = page.GetCropBox();
        float cx = ((float)(crop.GetWidth()) / (float)2.0F);
        float cy = ((float)(crop.GetHeight()) / (float)2.0F);
        global::DripSharp.PdfCarton.Util.Matrix transform
          = new global::DripSharp.PdfCarton.Util.Matrix();
        transform.Translate(cx, cy);
        transform.Rotate(global::DripSharp.Runtime.JavaCompat.ToRadians((double)(45)));
        transform.Translate((float)(-190), (float)(0));
        contentStream.SetTextMatrix(transform);
        contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", text));
        contentStream.EndText();
      }
      doc.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", targetFile.FullName));
    }
    return targetFile;
  }

  [Xunit.Fact]
  public void __Upstream_3665586276_399ccdae18e81742() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testLayerImport();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

  private static bool __RunUpstreamBeforeAll() {
    setUp();
    return true;
  }
}
