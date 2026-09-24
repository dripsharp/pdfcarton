// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdfwriter;

public class COSWriterTest {
  internal virtual void testPDFBox4321() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_63_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
        doc.AddPage(page);
        global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => {
            doc.Save(new global::System.IO.BufferedStream(new Anonymous_69_51(1024)));
          }, null);
      } catch (global::System.Exception __dripsharpCaught_63_25_0) {
        __dripsharpPrimary_63_25_0 = __dripsharpCaught_63_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_63_25_0);
      }
    }
  }

  private sealed class Anonymous_69_51 : global::DripSharp.Runtime.JavaByteArrayOutputStream {
    public Anonymous_69_51(int baseArgument0) : base(baseArgument0) {}

    public override void Dispose() {
      throw new global::System.IO.IOException(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Stream was closed"));
    }
  }

  internal virtual void testPDFBox5485() {
    global::DripSharp.Runtime.JavaFile pdfFile
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.PathOf(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "src"), "test", "resources", "input", "PDFBOX-3110-poems-beads.pdf"))); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument pdfDocument
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)pdfFile });
      global::System.Exception __dripsharpPrimary_86_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Multipdf.PageExtractor pageExtractor
          = new global::DripSharp.PdfCarton.Multipdf.PageExtractor(pdfDocument, 2, 2); {
          global::DripSharp.PdfCarton.Pdmodel.PDDocument pdfPages = pageExtractor.Extract();
          global::System.Exception __dripsharpPrimary_89_29_0 = null!;
          try {
            global::DripSharp.Testing.JavaAssertions.DoesNotThrow(()
              => pdfPages.Save(new global::DripSharp.Runtime.JavaByteArrayOutputStream()), null);
          } catch (global::System.Exception __dripsharpCaught_89_29_0) {
            __dripsharpPrimary_89_29_0 = __dripsharpCaught_89_29_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(pdfPages,
              __dripsharpPrimary_89_29_0);
          }
        }
      } catch (global::System.Exception __dripsharpCaught_86_25_0) {
        __dripsharpPrimary_86_25_0 = __dripsharpCaught_86_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(pdfDocument, __dripsharpPrimary_86_25_0);
      }
    }
  }

  internal virtual void testPDFBox5945() {
    sbyte[] input = global::DripSharp.PdfCarton.Pdfwriter.COSWriterTest.create();
    global::DripSharp.PdfCarton.Pdfwriter.COSWriterTest.checkTrailerSize(input);
    sbyte[] output = global::DripSharp.PdfCarton.Pdfwriter.COSWriterTest.edit(input);
    global::DripSharp.PdfCarton.Pdfwriter.COSWriterTest.checkTrailerSize(output);
  }

  private static void checkTrailerSize(sbyte[] docData) { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument pdDocument
        = global::DripSharp.PdfCarton.Loader.LoadPDF(docData);
      global::System.Exception __dripsharpPrimary_108_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Cos.COSDocument cosDocument = pdDocument.GetDocument();
        long maxObjNumber
          = global::DripSharp.PdfCarton.Tests.Support.MaxLong(global::DripSharp.Runtime.JavaCompat.MapToLong(global::DripSharp.Runtime.JavaCompat.Stream(global::DripSharp.Runtime.JavaCompat.MapKeySet(cosDocument.GetXrefTable())),
          (value0) => value0.GetNumber())).Value;
        long sizeFromTrailer
          = cosDocument.GetTrailer().GetLong(global::DripSharp.PdfCarton.Cos.COSName.Size);
        global::DripSharp.Testing.JavaAssertions.Equal(unchecked((maxObjNumber + 1)),
          sizeFromTrailer, null);
      } catch (global::System.Exception __dripsharpCaught_108_25_0) {
        __dripsharpPrimary_108_25_0 = __dripsharpCaught_108_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(pdDocument, __dripsharpPrimary_108_25_0);
      }
    }
  }

  private static sbyte[] create() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument pdDocument
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_120_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
          = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(pdDocument);
        pdDocument.GetDocumentCatalog().SetAcroForm(acroForm);
        global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font1
          = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica);
        global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font2
          = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.ZapfDingbats);
        global::DripSharp.PdfCarton.Pdmodel.PDResources resources
          = new global::DripSharp.PdfCarton.Pdmodel.PDResources();
        resources.Put(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "Helv")), font1);
        resources.Put(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "ZaDb")), font2);
        acroForm.SetDefaultResources(resources);
        global::DripSharp.PdfCarton.Pdmodel.PDPage page
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
        pdDocument.AddPage(page);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField textField
          = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(acroForm);
        textField.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "textFieldName"));
        global::DripSharp.Runtime.JavaCompat.Add(acroForm.GetFields(), textField);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget
          = global::DripSharp.Runtime.JavaCompat.ListGet(textField.GetWidgets(), 0);
        widget.SetPage(page);
        global::DripSharp.Runtime.JavaCompat.Add(page.GetAnnotations(), widget);
        global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle rectangle
          = new global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle((float)(10), (float)(200),
          (float)(200), (float)(15));
        widget.SetRectangle(rectangle);
        global::DripSharp.Runtime.JavaByteArrayOutputStream @out
          = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
        pdDocument.Save(@out,
          global::DripSharp.PdfCarton.Pdfwriter.Compress.CompressParameters.NoCompression);
        return global::DripSharp.Runtime.JavaCompat.ToSignedBytes(@out);
      } catch (global::System.Exception __dripsharpCaught_120_25_0) {
        __dripsharpPrimary_120_25_0 = __dripsharpCaught_120_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(pdDocument, __dripsharpPrimary_120_25_0);
      }
    }
  }

  private static sbyte[] edit(sbyte[] input) { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument pdDocument
        = global::DripSharp.PdfCarton.Loader.LoadPDF(input);
      global::System.Exception __dripsharpPrimary_148_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField textField
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(pdDocument.GetDocumentCatalog().GetAcroForm().GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "textFieldName"))!);
        global::DripSharp.Testing.JavaAssertions.NotNull(textField, null);
        textField.SetMultiline(true);
        global::DripSharp.Runtime.JavaByteArrayOutputStream @out
          = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
        pdDocument.SaveIncremental(@out);
        return global::DripSharp.Runtime.JavaCompat.ToSignedBytes(@out);
      } catch (global::System.Exception __dripsharpCaught_148_25_0) {
        __dripsharpPrimary_148_25_0 = __dripsharpCaught_148_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(pdDocument, __dripsharpPrimary_148_25_0);
      }
    }
  }

  internal virtual void testPDFBox6036() {
    global::System.Uri emptyURL
      = global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "https://issues.apache.org/jira/secure/attachment/13066015/empty.pdf"));
    global::System.Uri roboURL
      = global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "https://issues.apache.org/jira/secure/attachment/13066016/roboto-14.pdf"));
    sbyte[] emptyPDF = default!;
    sbyte[] roboPDF = default!; {
      global::System.IO.Stream isEmpty
        = global::DripSharp.Runtime.JavaCompat.OpenUrlStream(emptyURL);
      global::System.Exception __dripsharpPrimary_175_26_0 = null!;
      try {
        global::System.IO.Stream isRobo
          = global::DripSharp.Runtime.JavaCompat.OpenUrlStream(roboURL);
        global::System.Exception __dripsharpPrimary_175_71_0 = null!;
        try {
          emptyPDF = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(isEmpty);
          roboPDF = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(isRobo);
        } catch (global::System.Exception __dripsharpCaught_175_71_0) {
          __dripsharpPrimary_175_71_0 = __dripsharpCaught_175_71_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(isRobo, __dripsharpPrimary_175_71_0);
        }
      } catch (global::System.Exception __dripsharpCaught_175_26_0) {
        __dripsharpPrimary_175_26_0 = __dripsharpCaught_175_26_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(isEmpty, __dripsharpPrimary_175_26_0);
      }
    }
    global::DripSharp.Runtime.JavaByteArrayOutputStream baosCompressed
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream(); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument targetDoc__182_25
        = global::DripSharp.PdfCarton.Loader.LoadPDF(emptyPDF!);
      global::System.Exception __dripsharpPrimary_182_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDDocument doc2__183_28
          = global::DripSharp.PdfCarton.Loader.LoadPDF(roboPDF!);
        global::System.Exception __dripsharpPrimary_183_28_0 = null!;
        try {
          global::DripSharp.PdfCarton.Pdmodel.PDPage sourcePage__185_20 = doc2__183_28.GetPage(0);
          targetDoc__182_25.ImportPage(sourcePage__185_20);
          targetDoc__182_25.Save(baosCompressed);
        } catch (global::System.Exception __dripsharpCaught_183_28_0) {
          __dripsharpPrimary_183_28_0 = __dripsharpCaught_183_28_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(doc2__183_28,
            __dripsharpPrimary_183_28_0);
        }
      } catch (global::System.Exception __dripsharpCaught_182_25_0) {
        __dripsharpPrimary_182_25_0 = __dripsharpCaught_182_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(targetDoc__182_25,
          __dripsharpPrimary_182_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument targetDoc__189_25
        = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baosCompressed));
      global::System.Exception __dripsharpPrimary_189_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.NotNull(targetDoc__189_25.GetDocumentCatalog().GetStructureTreeRoot(),
          null);
        global::DripSharp.PdfCarton.Pdmodel.PDResources res__192_25
          = targetDoc__189_25.GetPage(1).GetResources();
        global::DripSharp.Testing.JavaAssertions.Equal("BCDEEE+Roboto-Regular",
          res__192_25.GetFont(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "F1"))).GetName(), null);
        global::DripSharp.Testing.JavaAssertions.Equal("BCDFEE+Roboto-Regular",
          res__192_25.GetFont(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "F2"))).GetName(), null);
      } catch (global::System.Exception __dripsharpCaught_189_25_0) {
        __dripsharpPrimary_189_25_0 = __dripsharpCaught_189_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(targetDoc__189_25,
          __dripsharpPrimary_189_25_0);
      }
    }
    global::DripSharp.Runtime.JavaByteArrayOutputStream baosUncompressed
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream(); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument targetDoc__199_25
        = global::DripSharp.PdfCarton.Loader.LoadPDF(emptyPDF!);
      global::System.Exception __dripsharpPrimary_199_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDDocument doc2__200_28
          = global::DripSharp.PdfCarton.Loader.LoadPDF(roboPDF!);
        global::System.Exception __dripsharpPrimary_200_28_0 = null!;
        try {
          global::DripSharp.PdfCarton.Pdmodel.PDPage sourcePage__202_20 = doc2__200_28.GetPage(0);
          targetDoc__199_25.ImportPage(sourcePage__202_20);
          targetDoc__199_25.Save(baosUncompressed,
            global::DripSharp.PdfCarton.Pdfwriter.Compress.CompressParameters.NoCompression);
        } catch (global::System.Exception __dripsharpCaught_200_28_0) {
          __dripsharpPrimary_200_28_0 = __dripsharpCaught_200_28_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(doc2__200_28,
            __dripsharpPrimary_200_28_0);
        }
      } catch (global::System.Exception __dripsharpCaught_199_25_0) {
        __dripsharpPrimary_199_25_0 = __dripsharpCaught_199_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(targetDoc__199_25,
          __dripsharpPrimary_199_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument targetDoc__206_25
        = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baosUncompressed));
      global::System.Exception __dripsharpPrimary_206_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.NotNull(targetDoc__206_25.GetDocumentCatalog().GetStructureTreeRoot(),
          null);
        global::DripSharp.PdfCarton.Pdmodel.PDResources res__209_25
          = targetDoc__206_25.GetPage(1).GetResources();
        global::DripSharp.Testing.JavaAssertions.Equal("BCDEEE+Roboto-Regular",
          res__209_25.GetFont(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "F1"))).GetName(), null);
        global::DripSharp.Testing.JavaAssertions.Equal("BCDFEE+Roboto-Regular",
          res__209_25.GetFont(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "F2"))).GetName(), null);
      } catch (global::System.Exception __dripsharpCaught_206_25_0) {
        __dripsharpPrimary_206_25_0 = __dripsharpCaught_206_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(targetDoc__206_25,
          __dripsharpPrimary_206_25_0);
      }
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724576297_1c1656de78521df4() {
    try {
      this.testPDFBox4321();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724607239_7c2cd3532ade2d86() {
    try {
      this.testPDFBox5485();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724611920_80b19cb515c64c39() {
    try {
      this.testPDFBox5945();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724633032_6eb5068150657b3a() {
    try {
      this.testPDFBox6036();
    } finally {
    }
  }
}
