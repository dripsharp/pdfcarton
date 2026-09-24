// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdfwriter;

public class ContentStreamWriterTest {
  private static readonly global::DripSharp.Runtime.JavaFile TESTDIRIN;

  private static readonly global::DripSharp.Runtime.JavaFile TESTDIROUT;

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
    global::DripSharp.Runtime.JavaFile file
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/pdfs"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)file });
      global::System.Exception __dripsharpPrimary_74_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Rendering.PDFRenderer r
          = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(doc);
        for (int i = 0; (i < doc.GetNumberOfPages()); ++i) {
          global::SkiaSharp.SKBitmap bim1 = r.RenderImageWithDPI(i, (float)(96));
          global::DripSharp.PdfCarton.Tests.Support.WriteImage(bim1,
            global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"),
            global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriterTest.TESTDIRIN,
            global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(filename,
            "-"), unchecked((i + 1))), ".png"))));
          global::DripSharp.PdfCarton.Pdmodel.PDPage page = doc.GetPage(i);
          global::DripSharp.PdfCarton.Pdmodel.Common.PDStream newContent
            = new global::DripSharp.PdfCarton.Pdmodel.Common.PDStream(doc); {
            global::System.IO.Stream os
              = newContent.CreateOutputStream(global::DripSharp.PdfCarton.Cos.COSName.FlateDecode);
            global::System.Exception __dripsharpPrimary_83_35_0 = null!;
            try {
              global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser parser
                = new global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser(page);
              global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriter tokenWriter
                = new global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriter(os);
              tokenWriter.WriteTokens(global::DripSharp.Runtime.JavaCompat.CastObjects(parser.Parse()));
            } catch (global::System.Exception __dripsharpCaught_83_35_0) {
              __dripsharpPrimary_83_35_0 = __dripsharpCaught_83_35_0;
              throw;
            } finally {
              global::DripSharp.Runtime.JavaCompat.CloseResource(os, __dripsharpPrimary_83_35_0);
            }
          }
          page.SetContents(newContent);
        }
        global::DripSharp.Runtime.JavaFileBridge.Call(doc, "Save",
          new global::System.Type[] { typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriterTest.TESTDIRIN,
            global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)) });
      } catch (global::System.Exception __dripsharpCaught_74_25_0) {
        __dripsharpPrimary_74_25_0 = __dripsharpCaught_74_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_74_25_0);
      }
    }
    if (!(global::DripSharp.Runtime.JavaFileBridge.Call<bool>(typeof(global::DripSharp.PdfCarton.Rendering.TestPDFToImage),
      "DoTestFile", new global::System.Type[] { typeof(global::System.IO.FileInfo), typeof(string),
        typeof(string) },
      new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriterTest.TESTDIRIN,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)),
        (string)global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriterTest.TESTDIRIN)),
        (string)global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(global::DripSharp.PdfCarton.Pdfwriter.ContentStreamWriterTest.TESTDIROUT)) }))) {
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

  private static readonly bool __UpstreamBeforeAll;

  private static bool __RunUpstreamBeforeAll() {
    setUp();
    return true;
  }

  static ContentStreamWriterTest() {
    TESTDIRIN
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/test-output/contentstream/in"));
    TESTDIROUT
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/test-output/contentstream/out"));
    __UpstreamBeforeAll = __RunUpstreamBeforeAll();
  }
}
