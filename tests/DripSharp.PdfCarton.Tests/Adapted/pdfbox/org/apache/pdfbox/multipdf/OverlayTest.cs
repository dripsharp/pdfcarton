// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Multipdf;

public class OverlayTest {
  private static readonly global::DripSharp.Runtime.JavaFile IN_DIR;

  private static readonly global::DripSharp.Runtime.JavaFile OUT_DIR;

  internal static void setUp() {
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR);
  }

  internal virtual void testRotatedOverlays() {
    this.testRotatedOverlay(0);
    this.testRotatedOverlay(90);
    this.testRotatedOverlay(180);
    this.testRotatedOverlay(270);
  }

  internal virtual void testRotatedOverlaysMap() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument baseDocument__73_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "OverlayTestBaseRot0.pdf")) });
      global::System.Exception __dripsharpPrimary_73_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
          = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
        global::System.Exception __dripsharpPrimary_74_25_0 = null!;
        try {
          for (int p = 0; (p < 4); ++p) {
            doc.ImportPage(baseDocument__73_25.GetPage(0));
          }
          global::DripSharp.Runtime.JavaFileBridge.Call(doc, "Save",
            new global::System.Type[] { typeof(global::System.IO.FileInfo) },
            new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
              global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "OverlayTestBaseRot0_4Pages.pdf")) });
        } catch (global::System.Exception __dripsharpCaught_74_25_0) {
          __dripsharpPrimary_74_25_0 = __dripsharpCaught_74_25_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_74_25_0);
        }
      } catch (global::System.Exception __dripsharpCaught_73_25_0) {
        __dripsharpPrimary_73_25_0 = __dripsharpCaught_73_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(baseDocument__73_25,
          __dripsharpPrimary_73_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument baseDocument__84_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "OverlayTestBaseRot0_4Pages.pdf")) });
      global::System.Exception __dripsharpPrimary_84_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Multipdf.Overlay overlay
          = new global::DripSharp.PdfCarton.Multipdf.Overlay();
        global::System.Exception __dripsharpPrimary_85_22_0 = null!;
        try {
          global::System.Collections.Generic.IDictionary<int, string> specificPageOverlayMap
            = global::DripSharp.Runtime.JavaCompat.NewJavaDictionary<int, string>();
          global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(()
            => overlay.overlay(specificPageOverlayMap), null);
          global::DripSharp.Runtime.JavaCompat.MapPut(specificPageOverlayMap, 1,
            global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR,
            global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "rot0.pdf"))));
          global::DripSharp.Runtime.JavaCompat.MapPut(specificPageOverlayMap, 2,
            global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR,
            global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "rot90.pdf"))));
          global::DripSharp.Runtime.JavaCompat.MapPut(specificPageOverlayMap, 3,
            global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR,
            global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "rot180.pdf"))));
          global::DripSharp.Runtime.JavaCompat.MapPut(specificPageOverlayMap, 4,
            global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR,
            global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "rot270.pdf"))));
          overlay.SetInputPDF(baseDocument__84_25); {
            global::DripSharp.PdfCarton.Pdmodel.PDDocument overlayedResultPDF
              = overlay.overlay(specificPageOverlayMap);
            global::System.Exception __dripsharpPrimary_94_29_0 = null!;
            try {
              global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.PDDocument> documentList
                = new global::DripSharp.PdfCarton.Multipdf.Splitter().Split(overlayedResultPDF);
              global::DripSharp.Runtime.JavaFileBridge.Call(global::DripSharp.Runtime.JavaCompat.ListGet(documentList,
                0), "Save", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
                new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
                  global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                  "Overlayed-with-rot0.pdf")) });
              global::DripSharp.Runtime.JavaFileBridge.Call(global::DripSharp.Runtime.JavaCompat.ListGet(documentList,
                1), "Save", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
                new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
                  global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                  "Overlayed-with-rot90.pdf")) });
              global::DripSharp.Runtime.JavaFileBridge.Call(global::DripSharp.Runtime.JavaCompat.ListGet(documentList,
                2), "Save", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
                new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
                  global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                  "Overlayed-with-rot180.pdf")) });
              global::DripSharp.Runtime.JavaFileBridge.Call(global::DripSharp.Runtime.JavaCompat.ListGet(documentList,
                3), "Save", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
                new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
                  global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                  "Overlayed-with-rot270.pdf")) });
              this.checkIdenticalRendering(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR,
                global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                "Overlayed-with-rot0.pdf")),
                global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
                global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                "Overlayed-with-rot0.pdf")));
              this.checkIdenticalRendering(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR,
                global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                "Overlayed-with-rot90.pdf")),
                global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
                global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                "Overlayed-with-rot90.pdf")));
              this.checkIdenticalRendering(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR,
                global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                "Overlayed-with-rot180.pdf")),
                global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
                global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                "Overlayed-with-rot180.pdf")));
              this.checkIdenticalRendering(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR,
                global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                "Overlayed-with-rot270.pdf")),
                global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
                global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                "Overlayed-with-rot270.pdf")));
            } catch (global::System.Exception __dripsharpCaught_94_29_0) {
              __dripsharpPrimary_94_29_0 = __dripsharpCaught_94_29_0;
              throw;
            } finally {
              global::DripSharp.Runtime.JavaCompat.CloseResource(overlayedResultPDF,
                __dripsharpPrimary_94_29_0);
            }
          }
        } catch (global::System.Exception __dripsharpCaught_85_22_0) {
          __dripsharpPrimary_85_22_0 = __dripsharpCaught_85_22_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(overlay, __dripsharpPrimary_85_22_0);
        }
      } catch (global::System.Exception __dripsharpCaught_84_25_0) {
        __dripsharpPrimary_84_25_0 = __dripsharpCaught_84_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(baseDocument__84_25,
          __dripsharpPrimary_84_25_0);
      }
    }
    global::DripSharp.Runtime.JavaCompat.FileDelete(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "OverlayTestBaseRot0_4Pages.pdf")));
  }

  internal virtual void testOverlayOnRotatedSourcePages() { {
      global::DripSharp.PdfCarton.Multipdf.Overlay overlay
        = new global::DripSharp.PdfCarton.Multipdf.Overlay();
      global::System.Exception __dripsharpPrimary_118_22_0 = null!;
      try {
        overlay.SetInputFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR,
          "/PDFBOX-6049-Source.pdf")));
        overlay.SetDefaultOverlayFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR,
          "/PDFBOX-6049-Overlay.pdf")));
        overlay.SetOverlayPosition(global::DripSharp.PdfCarton.Multipdf.Overlay.Position.Foreground);
        overlay.SetAdjustRotation(true); {
          global::DripSharp.PdfCarton.Pdmodel.PDDocument resultDoc
            = overlay.overlay(global::DripSharp.Runtime.JavaCompat.EmptyMap<int, string>());
          global::System.Exception __dripsharpPrimary_124_29_0 = null!;
          try {
            resultDoc.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
              "/PDFBOX-6049-Result.pdf")));
          } catch (global::System.Exception __dripsharpCaught_124_29_0) {
            __dripsharpPrimary_124_29_0 = __dripsharpCaught_124_29_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(resultDoc,
              __dripsharpPrimary_124_29_0);
          }
        }
        this.checkIdenticalRendering(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR,
          "/PDFBOX-6049-ExpectedResult.pdf"))),
          global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-6049-Result.pdf")));
        global::DripSharp.Runtime.JavaCompat.FileDelete(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-6049-Result.pdf")));
      } catch (global::System.Exception __dripsharpCaught_118_22_0) {
        __dripsharpPrimary_118_22_0 = __dripsharpCaught_118_22_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(overlay, __dripsharpPrimary_118_22_0);
      }
    }
  }

  private void testRotatedOverlay(int rotation) { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument baseDocument
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "OverlayTestBaseRot0.pdf")) });
      global::System.Exception __dripsharpPrimary_136_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Multipdf.Overlay overlay
          = new global::DripSharp.PdfCarton.Multipdf.Overlay();
        global::System.Exception __dripsharpPrimary_137_22_0 = null!;
        try {
          overlay.SetInputPDF(baseDocument); {
            global::DripSharp.PdfCarton.Pdmodel.PDDocument overlayDocument
              = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
              "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
              new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR,
                global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("rot",
                rotation), ".pdf"))) });
            global::System.Exception __dripsharpPrimary_140_29_0 = null!;
            try {
              overlay.SetDefaultOverlayPDF(overlayDocument); {
                global::DripSharp.PdfCarton.Pdmodel.PDDocument overlayedResultPDF
                  = overlay.overlay(global::DripSharp.Runtime.JavaCompat.NewJavaDictionary<int,
                  string>());
                global::System.Exception __dripsharpPrimary_143_33_0 = null!;
                try {
                  global::DripSharp.Runtime.JavaFileBridge.Call(overlayedResultPDF, "Save",
                    new global::System.Type[] { typeof(global::System.IO.FileInfo) },
                    new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
                      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Overlayed-with-rot",
                      rotation), ".pdf"))) });
                } catch (global::System.Exception __dripsharpCaught_143_33_0) {
                  __dripsharpPrimary_143_33_0 = __dripsharpCaught_143_33_0;
                  throw;
                } finally {
                  global::DripSharp.Runtime.JavaCompat.CloseResource(overlayedResultPDF,
                    __dripsharpPrimary_143_33_0);
                }
              }
            } catch (global::System.Exception __dripsharpCaught_140_29_0) {
              __dripsharpPrimary_140_29_0 = __dripsharpCaught_140_29_0;
              throw;
            } finally {
              global::DripSharp.Runtime.JavaCompat.CloseResource(overlayDocument,
                __dripsharpPrimary_140_29_0);
            }
          }
        } catch (global::System.Exception __dripsharpCaught_137_22_0) {
          __dripsharpPrimary_137_22_0 = __dripsharpCaught_137_22_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(overlay, __dripsharpPrimary_137_22_0);
        }
      } catch (global::System.Exception __dripsharpCaught_136_25_0) {
        __dripsharpPrimary_136_25_0 = __dripsharpCaught_136_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(baseDocument,
          __dripsharpPrimary_136_25_0);
      }
    }
    global::DripSharp.Runtime.JavaFile modelFile
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Overlayed-with-rot",
      rotation), ".pdf")));
    global::DripSharp.Runtime.JavaFile resultFile
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Overlayed-with-rot",
      rotation), ".pdf")));
    this.checkIdenticalRendering(modelFile, resultFile);
  }

  private void checkIdenticalRendering(global::DripSharp.Runtime.JavaFile modelFile,
    global::DripSharp.Runtime.JavaFile resultFile) { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument modelDocument
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)modelFile });
      global::System.Exception __dripsharpPrimary_159_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDDocument resultDocument
          = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
          "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.Runtime.JavaFile)resultFile });
        global::System.Exception __dripsharpPrimary_160_25_0 = null!;
        try {
          global::DripSharp.Testing.JavaAssertions.Equal(modelDocument.GetNumberOfPages(),
            resultDocument.GetNumberOfPages(), null);
          for (int page = 0; (page < modelDocument.GetNumberOfPages()); ++page) {
            global::SkiaSharp.SKBitmap modelImage
              = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(modelDocument).RenderImage(page);
            global::SkiaSharp.SKBitmap resultImage
              = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(resultDocument).RenderImage(page);
            global::DripSharp.Testing.JavaAssertions.Equal(modelImage.Width, resultImage.Width,
              null);
            global::DripSharp.Testing.JavaAssertions.Equal(modelImage.Height, resultImage.Height,
              null);
            global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.PdfCartonFontCompat.GetImageType(modelImage),
              global::DripSharp.Runtime.PdfCartonFontCompat.GetImageType(resultImage), null);
            global::DripSharp.Runtime.JavaDataBufferInt modelDataBuffer
              = (global::DripSharp.Runtime.JavaDataBufferInt)(global::DripSharp.Runtime.PdfCartonFontCompat.GetRaster(modelImage).GetDataBuffer()!);
            global::DripSharp.Runtime.JavaDataBufferInt resultDataBuffer
              = (global::DripSharp.Runtime.JavaDataBufferInt)(global::DripSharp.Runtime.PdfCartonFontCompat.GetRaster(resultImage).GetDataBuffer()!);
            global::DripSharp.Testing.JavaAssertions.Equal(modelDataBuffer.GetData(),
              resultDataBuffer.GetData(), null);
          }
        } catch (global::System.Exception __dripsharpCaught_160_25_0) {
          __dripsharpPrimary_160_25_0 = __dripsharpCaught_160_25_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(resultDocument,
            __dripsharpPrimary_160_25_0);
        }
      } catch (global::System.Exception __dripsharpCaught_159_25_0) {
        __dripsharpPrimary_159_25_0 = __dripsharpCaught_159_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(modelDocument,
          __dripsharpPrimary_159_25_0);
      }
    }
    global::DripSharp.Runtime.JavaCompat.FileDelete(resultFile);
  }

  private void createBaseFile() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_185_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage(); {
          global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream cs
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page);
          global::System.Exception __dripsharpPrimary_188_38_0 = null!;
          try {
            float fontHeight = 12;
            float y = (page.GetMediaBox().GetHeight() - (fontHeight * 2));
            global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font
              = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica);
            cs.SetFont(font, fontHeight);
            cs.BeginText();
            cs.SetLeading(((fontHeight * 2) + 1));
            cs.NewLineAtOffset((fontHeight * 2), y);
            while ((y > (fontHeight * 2))) {
              cs.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                global::DripSharp.Runtime.JavaCompat.Concat("A quick movement of the enemy will jeopardize six gunboats. ",
                "Heavy boxes perform quick waltzes and jigs.")));
              cs.NewLine();
              y -= (fontHeight * 2);
            }
            cs.EndText();
          } catch (global::System.Exception __dripsharpCaught_188_38_0) {
            __dripsharpPrimary_188_38_0 = __dripsharpCaught_188_38_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(cs, __dripsharpPrimary_188_38_0);
          }
        }
        doc.AddPage(page);
        doc.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "OverlayTestBaseRot0.pdf"));
      } catch (global::System.Exception __dripsharpCaught_185_25_0) {
        __dripsharpPrimary_185_25_0 = __dripsharpCaught_185_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_185_25_0);
      }
    }
  }

  [Xunit.Fact]
  public void __Upstream_3974534909_9afbf520614df326() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testOverlayOnRotatedSourcePages();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1292860602_8388bf2d8995a27a() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testRotatedOverlays();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2638528066_15647e7a67df7937() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testRotatedOverlaysMap();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll;

  private static bool __RunUpstreamBeforeAll() {
    setUp();
    return true;
  }

  static OverlayTest() {
    IN_DIR
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "src/test/resources/org/apache/pdfbox/multipdf"));
    OUT_DIR
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/test-output/overlay"));
    __UpstreamBeforeAll = __RunUpstreamBeforeAll();
  }
}
