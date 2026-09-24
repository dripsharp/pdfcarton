// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Multipdf;

public class PDFCloneUtilityTest {
  internal virtual void testClonePDFWithCosArrayStream() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument srcDoc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_57_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDDocument dstDoc
          = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
        global::System.Exception __dripsharpPrimary_58_25_0 = null!;
        try {
          global::DripSharp.PdfCarton.Pdmodel.PDPage pdPage
            = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
          srcDoc.AddPage(pdPage);
          new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(srcDoc, pdPage,
            global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append,
            true).Dispose();
          new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(srcDoc, pdPage,
            global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append,
            true).Dispose();
          global::DripSharp.PdfCarton.Multipdf.PDFCloneUtility cloner
            = new global::DripSharp.PdfCarton.Multipdf.PDFCloneUtility(dstDoc);
          global::DripSharp.Testing.JavaAssertions.Equal(dstDoc, cloner.getDestination(), null);
          global::DripSharp.PdfCarton.Cos.COSDictionary clonedPageDictionary
            = cloner.CloneForNewDocument<global::DripSharp.PdfCarton.Cos.COSDictionary>(pdPage.GetCOSObject());
          global::DripSharp.PdfCarton.Pdmodel.PDPage clonedPage
            = new global::DripSharp.PdfCarton.Pdmodel.PDPage(clonedPageDictionary);
          global::DripSharp.Runtime.JavaIterator<global::DripSharp.PdfCarton.Pdmodel.Common.PDStream> contentStreams
            = clonedPage.GetContentStreams();
          global::DripSharp.Testing.JavaAssertions.NotNull(contentStreams.Next()!, null);
          global::DripSharp.Testing.JavaAssertions.NotNull(contentStreams.Next()!, null);
          global::DripSharp.Testing.JavaAssertions.False(contentStreams.HasNext(), null);
        } catch (global::System.Exception __dripsharpCaught_58_25_0) {
          __dripsharpPrimary_58_25_0 = __dripsharpCaught_58_25_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(dstDoc, __dripsharpPrimary_58_25_0);
        }
      } catch (global::System.Exception __dripsharpCaught_57_25_0) {
        __dripsharpPrimary_57_25_0 = __dripsharpCaught_57_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(srcDoc, __dripsharpPrimary_57_25_0);
      }
    }
  }

  internal virtual void testClonePDFWithCosArrayStream2() {
    string TESTDIR = "target/test-output/clone/";
    string CLONESRC = "clone-src.pdf";
    string CLONEDST = "clone-dst.pdf";
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      TESTDIR))); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument srcDoc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_89_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage pdPage
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
        srcDoc.AddPage(pdPage); {
          global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream pdPageContentStream1
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(srcDoc, pdPage,
            global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false);
          global::System.Exception __dripsharpPrimary_93_38_0 = null!;
          try {
            pdPageContentStream1.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Black);
            pdPageContentStream1.AddRect((float)(100), (float)(600), (float)(300), (float)(100));
            pdPageContentStream1.Fill();
          } catch (global::System.Exception __dripsharpCaught_93_38_0) {
            __dripsharpPrimary_93_38_0 = __dripsharpCaught_93_38_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(pdPageContentStream1,
              __dripsharpPrimary_93_38_0);
          }
        } {
          global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream pdPageContentStream2
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(srcDoc, pdPage,
            global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false);
          global::System.Exception __dripsharpPrimary_99_38_0 = null!;
          try {
            pdPageContentStream2.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Red);
            pdPageContentStream2.AddRect((float)(100), (float)(500), (float)(300), (float)(100));
            pdPageContentStream2.Fill();
          } catch (global::System.Exception __dripsharpCaught_99_38_0) {
            __dripsharpPrimary_99_38_0 = __dripsharpCaught_99_38_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(pdPageContentStream2,
              __dripsharpPrimary_99_38_0);
          }
        } {
          global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream pdPageContentStream3
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(srcDoc, pdPage,
            global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false);
          global::System.Exception __dripsharpPrimary_105_38_0 = null!;
          try {
            pdPageContentStream3.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Yellow);
            pdPageContentStream3.AddRect((float)(100), (float)(400), (float)(300), (float)(100));
            pdPageContentStream3.Fill();
          } catch (global::System.Exception __dripsharpCaught_105_38_0) {
            __dripsharpPrimary_105_38_0 = __dripsharpCaught_105_38_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(pdPageContentStream3,
              __dripsharpPrimary_105_38_0);
          }
        }
        srcDoc.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(TESTDIR, CLONESRC)));
        global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility merger
          = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility(); {
          global::DripSharp.PdfCarton.Pdmodel.PDDocument dstDoc
            = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
          global::System.Exception __dripsharpPrimary_113_29_0 = null!;
          try {
            merger.AppendDocument(dstDoc, srcDoc);
            dstDoc.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              global::DripSharp.Runtime.JavaCompat.Concat(TESTDIR, CLONEDST)));
          } catch (global::System.Exception __dripsharpCaught_113_29_0) {
            __dripsharpPrimary_113_29_0 = __dripsharpCaught_113_29_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(dstDoc, __dripsharpPrimary_113_29_0);
          }
        }
      } catch (global::System.Exception __dripsharpCaught_89_25_0) {
        __dripsharpPrimary_89_25_0 = __dripsharpCaught_89_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(srcDoc, __dripsharpPrimary_89_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__123_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(TESTDIR, CLONESRC))) });
      global::System.Exception __dripsharpPrimary_123_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(1, doc__123_25.GetNumberOfPages(), null);
      } catch (global::System.Exception __dripsharpCaught_123_25_0) {
        __dripsharpPrimary_123_25_0 = __dripsharpCaught_123_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__123_25,
          __dripsharpPrimary_123_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__127_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo), typeof(string) },
        new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(TESTDIR, CLONESRC))),
          (string)((string)default!) });
      global::System.Exception __dripsharpPrimary_127_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(1, doc__127_25.GetNumberOfPages(), null);
      } catch (global::System.Exception __dripsharpCaught_127_25_0) {
        __dripsharpPrimary_127_25_0 = __dripsharpCaught_127_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__127_25,
          __dripsharpPrimary_127_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__131_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(TESTDIR, CLONEDST))) });
      global::System.Exception __dripsharpPrimary_131_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(1, doc__131_25.GetNumberOfPages(), null);
      } catch (global::System.Exception __dripsharpCaught_131_25_0) {
        __dripsharpPrimary_131_25_0 = __dripsharpCaught_131_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__131_25,
          __dripsharpPrimary_131_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__135_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo), typeof(string) },
        new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(TESTDIR, CLONEDST))),
          (string)((string)default!) });
      global::System.Exception __dripsharpPrimary_135_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(1, doc__135_25.GetNumberOfPages(), null);
      } catch (global::System.Exception __dripsharpCaught_135_25_0) {
        __dripsharpPrimary_135_25_0 = __dripsharpCaught_135_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__135_25,
          __dripsharpPrimary_135_25_0);
      }
    }
  }

  internal virtual void testDirectIndirect() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc1
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_150_25_0 = null!;
      try {
        doc1.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
        doc1.GetDocumentCatalog().SetOCProperties(new global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentProperties());
        global::DripSharp.Runtime.JavaByteArrayOutputStream baos
          = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
        doc1.Save(baos); {
          global::DripSharp.PdfCarton.Pdmodel.PDDocument doc2
            = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
          global::System.Exception __dripsharpPrimary_156_29_0 = null!;
          try {
            global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility merger
              = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
            global::DripSharp.Testing.JavaAssertions.InstanceOf<global::DripSharp.PdfCarton.Cos.COSDictionary>(doc1.GetDocumentCatalog().GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Ocproperties),
              null);
            global::DripSharp.Testing.JavaAssertions.InstanceOf<global::DripSharp.PdfCarton.Cos.COSObject>(doc2.GetDocumentCatalog().GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Ocproperties),
              null);
            merger.AppendDocument(doc2, doc1);
            global::DripSharp.Testing.JavaAssertions.Equal(2, doc2.GetNumberOfPages(), null);
          } catch (global::System.Exception __dripsharpCaught_156_29_0) {
            __dripsharpPrimary_156_29_0 = __dripsharpCaught_156_29_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(doc2, __dripsharpPrimary_156_29_0);
          }
        }
      } catch (global::System.Exception __dripsharpCaught_150_25_0) {
        __dripsharpPrimary_150_25_0 = __dripsharpCaught_150_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc1, __dripsharpPrimary_150_25_0);
      }
    }
  }

  [Xunit.Fact]
  public void __Upstream_2475150079_4c619884d9c6175a() {
    try {
      this.testClonePDFWithCosArrayStream();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3715208467_568a90fefd3031e2() {
    try {
      this.testClonePDFWithCosArrayStream2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0557656457_0d8f7c102aa8232e() {
    try {
      this.testDirectIndirect();
    } finally {
    }
  }
}
