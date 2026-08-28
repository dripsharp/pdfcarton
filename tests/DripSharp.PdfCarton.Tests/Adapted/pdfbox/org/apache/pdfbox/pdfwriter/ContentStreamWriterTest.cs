// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdfwriter;

public class ContentStreamWriterTest {
  private static readonly global::System.IO.FileInfo TESTDIRIN
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/test-output/contentstream/in"));

  private static readonly global::System.IO.FileInfo TESTDIROUT
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/test-output/contentstream/out"));

  internal static void setUp() {
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriterTest.TESTDIRIN);
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriterTest.TESTDIROUT);
    global::DripSharp.Runtime.JavaColorSpace csRGB
      = global::DripSharp.Runtime.PdfCartonFontCompat.GetColorSpace(global::DripSharp.Runtime.JavaColorSpace.CS_sRGB);
    csRGB.ToRgb(new float[] { 0, 0, 0 });
    global::DripSharp.Runtime.JavaColorSpace csXYZ
      = global::DripSharp.Runtime.PdfCartonFontCompat.GetColorSpace(global::DripSharp.Runtime.JavaColorSpace.CS_CIEXYZ);
    csXYZ.ToRgb(new float[] { 0, 0, 0 });
  }

  internal virtual void testPDFBox4750() {
    string filename = "PDFBOX-4750.pdf";
    global::System.IO.FileInfo file
      = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/pdfs"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(file)) {
      global::DripSharp.PdfCarton.Rendering.PDFRenderer r
        = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(doc);
      for (int i = 0; (i < doc.GetNumberOfPages()); ++i) {
        global::SkiaSharp.SKBitmap bim1 = r.RenderImageWithDPI(i, (float)(96));
        global::DripSharp.PdfCarton.Tests.Support.WriteImage(bim1,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"),
          new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriterTest.TESTDIRIN).FullName,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(filename,
          "-"), (i + 1)), ".png")))));
        global::DripSharp.PdfCarton.Pdmodel.PDPage page = doc.GetPage(i);
        global::DripSharp.PdfCarton.Pdmodel.Common.PDStream newContent
          = new global::DripSharp.PdfCarton.Pdmodel.Common.PDStream(doc);
        using (global::System.IO.Stream os
          = newContent.CreateOutputStream(global::DripSharp.PdfCarton.Cos.COSName.FlateDecode)) {
          global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser parser
            = new global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser(page);
          global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriter tokenWriter
            = new global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriter(os);
          tokenWriter.WriteTokens(global::DripSharp.Runtime.JavaCompat.CastObjects(parser.Parse()));
        }
        page.SetContents(newContent);
      }
      doc.Save(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriterTest.TESTDIRIN).FullName,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename))));
    }
    if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.DoTestFile(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriterTest.TESTDIRIN).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename))),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriterTest.TESTDIRIN.FullName),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriterTest.TESTDIROUT.FullName)))) {
      global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724580233_1070300929464e2e() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBox4750();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

  private static bool __RunUpstreamBeforeAll() {
    setUp();
    return true;
  }
}
