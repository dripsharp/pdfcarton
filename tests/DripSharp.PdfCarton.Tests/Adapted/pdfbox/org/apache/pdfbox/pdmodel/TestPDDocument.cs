// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel;

public class TestPDDocument {
  private static readonly global::DripSharp.Runtime.JavaFile TESTRESULTSDIR;

  internal static void setUp() {
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.TestPDDocument.TESTRESULTSDIR);
  }

  internal virtual void testSaveLoadStream() {
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos; {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_63_25_0 = null!;
      try {
        document.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
        baos = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
        document.Save(baos,
          global::DripSharp.PdfCarton.Pdfwriter.Compress.CompressParameters.NoCompression);
      } catch (global::System.Exception __dripsharpCaught_63_25_0) {
        __dripsharpPrimary_63_25_0 = __dripsharpCaught_63_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document, __dripsharpPrimary_63_25_0);
      }
    }
    sbyte[] pdf = global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos);
    global::DripSharp.Testing.JavaAssertions.True((pdf.Length > 200), null);
    global::DripSharp.Testing.JavaAssertions.Equal("%PDF-1.4",
      global::DripSharp.Runtime.JavaCompat.NewString(global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(pdf,
      0, 8), global::DripSharp.Runtime.JavaStandardCharsets.UTF8), null);
    global::DripSharp.Testing.JavaAssertions.Equal("%%EOF\n",
      global::DripSharp.Runtime.JavaCompat.NewString(global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(pdf,
      unchecked((pdf.Length - 6)), pdf.Length),
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8), null); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument loadDoc
        = global::DripSharp.PdfCarton.Loader.LoadPDF(pdf);
      global::System.Exception __dripsharpPrimary_78_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(1, loadDoc.GetNumberOfPages(), null);
      } catch (global::System.Exception __dripsharpCaught_78_25_0) {
        __dripsharpPrimary_78_25_0 = __dripsharpCaught_78_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(loadDoc, __dripsharpPrimary_78_25_0);
      }
    }
  }

  internal virtual void testSaveLoadFile() {
    global::DripSharp.Runtime.JavaFile targetFile
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.TestPDDocument.TESTRESULTSDIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "pddocument-saveloadfile.pdf"));
    {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_94_25_0 = null!;
      try {
        document.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
        global::DripSharp.Runtime.JavaFileBridge.Call(document, "Save",
          new global::System.Type[] { typeof(global::System.IO.FileInfo),
            typeof(global::DripSharp.PdfCarton.Pdfwriter.Compress.CompressParameters) },
          new object[] { (global::DripSharp.Runtime.JavaFile)targetFile,
            (global::DripSharp.PdfCarton.Pdfwriter.Compress.CompressParameters)(global::DripSharp.PdfCarton.Pdfwriter.Compress.CompressParameters.NoCompression) });
      } catch (global::System.Exception __dripsharpCaught_94_25_0) {
        __dripsharpPrimary_94_25_0 = __dripsharpCaught_94_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document, __dripsharpPrimary_94_25_0);
      }
    }
    global::DripSharp.Testing.JavaAssertions.True((targetFile.Length > 200), null);
    sbyte[] pdf
      = global::DripSharp.Runtime.JavaCompat.ReadAllBytes(global::DripSharp.Runtime.JavaCompat.FileToPath(targetFile));
    global::DripSharp.Testing.JavaAssertions.True((pdf.Length > 200), null);
    global::DripSharp.Testing.JavaAssertions.Equal("%PDF-1.4",
      global::DripSharp.Runtime.JavaCompat.NewString(global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(pdf,
      0, 8), global::DripSharp.Runtime.JavaStandardCharsets.UTF8), null);
    global::DripSharp.Testing.JavaAssertions.Equal("%%EOF\n",
      global::DripSharp.Runtime.JavaCompat.NewString(global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(pdf,
      unchecked((pdf.Length - 6)), pdf.Length),
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8), null); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument loadDoc
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)targetFile });
      global::System.Exception __dripsharpPrimary_110_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(1, loadDoc.GetNumberOfPages(), null);
      } catch (global::System.Exception __dripsharpCaught_110_25_0) {
        __dripsharpPrimary_110_25_0 = __dripsharpCaught_110_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(loadDoc, __dripsharpPrimary_110_25_0);
      }
    }
  }

  internal virtual void testVersions() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document__124_25
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_124_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(1.4F, document__124_25.GetVersion(), null,
          (float)(0));
        global::DripSharp.Testing.JavaAssertions.Equal(1.4F,
          document__124_25.GetDocument().GetVersion(), null, (float)(0));
        global::DripSharp.Testing.JavaAssertions.Equal("1.4",
          document__124_25.GetDocumentCatalog().GetVersion(), null);
        document__124_25.GetDocument().SetVersion(1.3F);
        document__124_25.GetDocumentCatalog().SetVersion((string)default!);
        global::DripSharp.Testing.JavaAssertions.Equal(1.3F, document__124_25.GetVersion(), null,
          (float)(0));
        global::DripSharp.Testing.JavaAssertions.Equal(1.3F,
          document__124_25.GetDocument().GetVersion(), null, (float)(0));
        global::DripSharp.Testing.JavaAssertions.Null(document__124_25.GetDocumentCatalog().GetVersion(),
          null);
      } catch (global::System.Exception __dripsharpCaught_124_25_0) {
        __dripsharpPrimary_124_25_0 = __dripsharpCaught_124_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document__124_25,
          __dripsharpPrimary_124_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document__140_25
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_140_25_0 = null!;
      try {
        document__140_25.SetVersion(1.3F);
        global::DripSharp.Testing.JavaAssertions.Equal(1.4F, document__140_25.GetVersion(), null,
          (float)(0));
        global::DripSharp.Testing.JavaAssertions.Equal(1.4F,
          document__140_25.GetDocument().GetVersion(), null, (float)(0));
        global::DripSharp.Testing.JavaAssertions.Equal("1.4",
          document__140_25.GetDocumentCatalog().GetVersion(), null);
        document__140_25.SetVersion(1.5F);
        global::DripSharp.Testing.JavaAssertions.Equal(1.5F, document__140_25.GetVersion(), null,
          (float)(0));
        global::DripSharp.Testing.JavaAssertions.Equal(1.4F,
          document__140_25.GetDocument().GetVersion(), null, (float)(0));
        global::DripSharp.Testing.JavaAssertions.Equal("1.5",
          document__140_25.GetDocumentCatalog().GetVersion(), null);
      } catch (global::System.Exception __dripsharpCaught_140_25_0) {
        __dripsharpPrimary_140_25_0 = __dripsharpCaught_140_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document__140_25,
          __dripsharpPrimary_140_25_0);
      }
    }
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream(); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document__160_25
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_160_25_0 = null!;
      try {
        document__160_25.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
        document__160_25.Save(baos);
      } catch (global::System.Exception __dripsharpCaught_160_25_0) {
        __dripsharpPrimary_160_25_0 = __dripsharpCaught_160_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document__160_25,
          __dripsharpPrimary_160_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document__165_25
        = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
      global::System.Exception __dripsharpPrimary_165_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal("1.6",
          document__165_25.GetDocumentCatalog().GetVersion(), null);
        global::DripSharp.Testing.JavaAssertions.Equal(1.6F,
          document__165_25.GetDocument().GetVersion(), null);
        global::DripSharp.Testing.JavaAssertions.Equal(1.6F, document__165_25.GetVersion(), null);
      } catch (global::System.Exception __dripsharpCaught_165_25_0) {
        __dripsharpPrimary_165_25_0 = __dripsharpCaught_165_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document__165_25,
          __dripsharpPrimary_165_25_0);
      }
    }
    global::DripSharp.Testing.JavaAssertions.Equal("%PDF-1.6",
      global::DripSharp.Runtime.JavaCompat.NewString(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos),
      0, 8, global::System.Text.Encoding.UTF8), null);
  }

  internal virtual void testDeleteBadFile() {
    global::DripSharp.Runtime.JavaFile f
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.TestPDDocument.TESTRESULTSDIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "testDeleteBadFile.pdf")); {
      global::System.IO.TextWriter pw
        = new global::System.IO.StreamWriter(global::DripSharp.Runtime.JavaCompat.OpenFileOutput(f),
        global::System.Text.Encoding.UTF8, 1024, false);
      global::System.Exception __dripsharpPrimary_183_26_0 = null!;
      try {
        pw.Write(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "<script language='JavaScript'>"));
      } catch (global::System.Exception __dripsharpCaught_183_26_0) {
        __dripsharpPrimary_183_26_0 = __dripsharpCaught_183_26_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(pw, __dripsharpPrimary_183_26_0);
      }
    }
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
      "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
      new object[] { (global::DripSharp.Runtime.JavaFile)f }),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "parsing should fail"));
    global::DripSharp.Testing.JavaAssertions.DoesNotThrow(()
      => global::DripSharp.Runtime.JavaCompat.DeleteIfExists(global::DripSharp.Runtime.JavaCompat.FileToPath(f)),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "delete bad file failed after failed load"));
  }

  internal virtual void testDeleteGoodFile() {
    global::DripSharp.Runtime.JavaFile f
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.TestPDDocument.TESTRESULTSDIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "testDeleteGoodFile.pdf")); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_200_25_0 = null!;
      try {
        doc.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
        global::DripSharp.Runtime.JavaFileBridge.Call(doc, "Save",
          new global::System.Type[] { typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.Runtime.JavaFile)f });
      } catch (global::System.Exception __dripsharpCaught_200_25_0) {
        __dripsharpPrimary_200_25_0 = __dripsharpCaught_200_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_200_25_0);
      }
    }
    global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
      "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
      new object[] { (global::DripSharp.Runtime.JavaFile)f }).Dispose();
    global::DripSharp.Testing.JavaAssertions.DoesNotThrow(()
      => global::DripSharp.Runtime.JavaCompat.DeleteIfExists(global::DripSharp.Runtime.JavaCompat.FileToPath(f)),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "delete good file failed after successful load() and close()"));
  }

  internal virtual void testSaveArabicLocale() {
    global::System.Globalization.CultureInfo defaultLocale
      = global::System.Globalization.CultureInfo.CurrentCulture;
    global::System.Globalization.CultureInfo arabicLocale
      = new global::DripSharp.PdfCarton.Tests.JavaLocaleBuilder().SetLanguageTag(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "ar-EG-u-nu-arab")).Build();
    global::DripSharp.PdfCarton.Tests.Support.SetDefaultCulture(arabicLocale);
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream(); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_227_25_0 = null!;
      try {
        doc.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
        doc.Save(baos);
      } catch (global::System.Exception __dripsharpCaught_227_25_0) {
        __dripsharpPrimary_227_25_0 = __dripsharpCaught_227_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_227_25_0);
      }
    }
    global::DripSharp.Testing.JavaAssertions.DoesNotThrow(()
      => global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos)).Dispose(),
      null);
    global::DripSharp.PdfCarton.Tests.Support.SetDefaultCulture(defaultLocale);
  }

  [Xunit.Fact]
  public void __Upstream_3494588292_c47ff2ab59da841c() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testDeleteBadFile();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0963902422_31cd1b834aa84dfe() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testDeleteGoodFile();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0079810805_7c23a1bad3acb867() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testSaveArabicLocale();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0664400337_fe9fc057a0266964() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testSaveLoadFile();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3216083605_36b256aa0700f096() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testSaveLoadStream();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0876770637_ae4d1f967beeff32() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testVersions();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll;

  private static bool __RunUpstreamBeforeAll() {
    setUp();
    return true;
  }

  static TestPDDocument() {
    TESTRESULTSDIR
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/test-output"));
    __UpstreamBeforeAll = __RunUpstreamBeforeAll();
  }
}
