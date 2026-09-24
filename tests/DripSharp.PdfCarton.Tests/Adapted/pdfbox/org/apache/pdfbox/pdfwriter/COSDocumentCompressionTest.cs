// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdfwriter;

public class COSDocumentCompressionTest {
  private static readonly global::DripSharp.Runtime.JavaFile INDIR;

  private static readonly global::DripSharp.Runtime.JavaFile OUTDIR;

  internal static void init() {
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.OUTDIR);
  }

  internal virtual void testCompressAcroformDoc() {
    global::DripSharp.Runtime.JavaFile source
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.INDIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "acroform.pdf"));
    global::DripSharp.Runtime.JavaFile target
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.OUTDIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "acroform.pdf")); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document__75_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)source });
      global::System.Exception __dripsharpPrimary_75_25_0 = null!;
      try {
        global::DripSharp.Runtime.JavaFileBridge.Call(document__75_25, "Save",
          new global::System.Type[] { typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.Runtime.JavaFile)target });
      } catch (global::System.Exception __dripsharpCaught_75_25_0) {
        __dripsharpPrimary_75_25_0 = __dripsharpCaught_75_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document__75_25,
          __dripsharpPrimary_75_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document__80_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)target });
      global::System.Exception __dripsharpPrimary_80_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(1, document__80_25.GetNumberOfPages(),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The number of pages should not have changed, during compression."));
        global::DripSharp.PdfCarton.Pdmodel.PDPage page = document__80_25.GetPage(0);
        global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotations
          = page.GetAnnotations();
        global::DripSharp.Testing.JavaAssertions.Equal(13,
          global::DripSharp.Runtime.JavaCompat.CollectionCount(annotations),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The number of annotations should not have changed"));
        global::DripSharp.Testing.JavaAssertions.Equal("TextField",
          global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          0).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The 1. annotation should have been a text field."));
        global::DripSharp.Testing.JavaAssertions.Equal("Button",
          global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          1).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The 2. annotation should have been a button."));
        global::DripSharp.Testing.JavaAssertions.Equal("CheckBox1",
          global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          2).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The 3. annotation should have been a checkbox."));
        global::DripSharp.Testing.JavaAssertions.Equal("CheckBox2",
          global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          3).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The 4. annotation should have been a checkbox."));
        global::DripSharp.Testing.JavaAssertions.Equal("TextFieldMultiLine",
          global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          4).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The 5. annotation should have been a multiline textfield."));
        global::DripSharp.Testing.JavaAssertions.Equal("TextFieldMultiLineRT",
          global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          5).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The 6. annotation should have been a multiline textfield."));
        global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          6).GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Parent),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The 7. annotation should have had a parent entry."));
        global::DripSharp.Testing.JavaAssertions.Equal("GroupOption",
          global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          6).GetCOSObject().GetCOSDictionary(global::DripSharp.PdfCarton.Cos.COSName.Parent).GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The 7. annotation's parent should have been a GroupOption."));
        global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          7).GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Parent),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The 8. annotation should have had a parent entry."));
        global::DripSharp.Testing.JavaAssertions.Equal("GroupOption",
          global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          7).GetCOSObject().GetCOSDictionary(global::DripSharp.PdfCarton.Cos.COSName.Parent).GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The 8. annotation's parent should have been a GroupOption."));
        global::DripSharp.Testing.JavaAssertions.Equal("ListBox",
          global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          8).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The 9. annotation should have been a ListBox."));
        global::DripSharp.Testing.JavaAssertions.Equal("ListBoxMultiSelect",
          global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          9).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The 10. annotation should have been a ListBox Multiselect."));
        global::DripSharp.Testing.JavaAssertions.Equal("ComboBox",
          global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          10).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The 11. annotation should have been a ComboBox."));
        global::DripSharp.Testing.JavaAssertions.Equal("ComboBoxEditable",
          global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          11).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The 12. annotation should have been a EditableComboBox."));
        global::DripSharp.Testing.JavaAssertions.Equal("Signature",
          global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          12).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The 13. annotation should have been a Signature."));
      } catch (global::System.Exception __dripsharpCaught_80_25_0) {
        __dripsharpPrimary_80_25_0 = __dripsharpCaught_80_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document__80_25,
          __dripsharpPrimary_80_25_0);
      }
    }
  }

  internal virtual void testCompressAttachmentsDoc() {
    global::DripSharp.Runtime.JavaFile source
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.INDIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "attachment.pdf"));
    global::DripSharp.Runtime.JavaFile target
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.OUTDIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "attachment.pdf")); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document__140_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)source });
      global::System.Exception __dripsharpPrimary_140_25_0 = null!;
      try {
        global::DripSharp.Runtime.JavaFileBridge.Call(document__140_25, "Save",
          new global::System.Type[] { typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.Runtime.JavaFile)target });
      } catch (global::System.Exception __dripsharpCaught_140_25_0) {
        __dripsharpPrimary_140_25_0 = __dripsharpCaught_140_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document__140_25,
          __dripsharpPrimary_140_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document__145_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)target });
      global::System.Exception __dripsharpPrimary_145_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(2, document__145_25.GetNumberOfPages(),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The number of pages should not have changed, during compression."));
        global::System.Collections.Generic.IDictionary<string,
          global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDComplexFileSpecification> embeddedFiles
          = document__145_25.GetDocumentCatalog().GetNames().GetEmbeddedFiles().GetNames();
        global::DripSharp.Testing.JavaAssertions.Equal(1,
          global::DripSharp.Runtime.JavaCompat.MapCount(embeddedFiles),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The document should have contained an attachment"));
        global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDComplexFileSpecification attachment;
        global::DripSharp.Testing.JavaAssertions.NotNull((attachment
          = global::DripSharp.Runtime.JavaCompat.MapGet(embeddedFiles, "A4Unicode.pdf")),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The document should have contained 'A4Unicode.pdf'."));
        global::DripSharp.Testing.JavaAssertions.Equal(14997,
          attachment.GetEmbeddedFile().GetLength(),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The attachments length is not as expected."));
      } catch (global::System.Exception __dripsharpCaught_145_25_0) {
        __dripsharpPrimary_145_25_0 = __dripsharpCaught_145_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document__145_25,
          __dripsharpPrimary_145_25_0);
      }
    }
  }

  internal virtual void testCompressEncryptedDoc() {
    global::DripSharp.Runtime.JavaFile source
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.INDIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "unencrypted.pdf"));
    global::DripSharp.Runtime.JavaFile target
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.OUTDIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "encrypted.pdf")); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document__172_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo), typeof(string) },
        new object[] { (global::DripSharp.Runtime.JavaFile)source,
          (string)global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "user") });
      global::System.Exception __dripsharpPrimary_172_25_0 = null!;
      try {
        document__172_25.Protect(new global::DripSharp.PdfCarton.Pdmodel.Encryption.StandardProtectionPolicy(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "owner"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "user"),
          new global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission(0)));
        global::DripSharp.Runtime.JavaFileBridge.Call(document__172_25, "Save",
          new global::System.Type[] { typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.Runtime.JavaFile)target });
      } catch (global::System.Exception __dripsharpCaught_172_25_0) {
        __dripsharpPrimary_172_25_0 = __dripsharpCaught_172_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document__172_25,
          __dripsharpPrimary_172_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document__179_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo), typeof(string) },
        new object[] { (global::DripSharp.Runtime.JavaFile)target,
          (string)global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "user") });
      global::System.Exception __dripsharpPrimary_179_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(2, document__179_25.GetNumberOfPages(),
          null);
      } catch (global::System.Exception __dripsharpCaught_179_25_0) {
        __dripsharpPrimary_179_25_0 = __dripsharpCaught_179_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document__179_25,
          __dripsharpPrimary_179_25_0);
      }
    }
  }

  internal virtual void testAlteredDoc() {
    global::DripSharp.Runtime.JavaFile source
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.INDIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "unencrypted.pdf"));
    global::DripSharp.Runtime.JavaFile target
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.OUTDIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "altered.pdf")); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document__197_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)source });
      global::System.Exception __dripsharpPrimary_197_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page__199_20
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage(new global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle((float)(100),
          (float)(100)));
        document__197_25.AddPage(page__199_20); {
          global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__197_25,
            page__199_20);
          global::System.Exception __dripsharpPrimary_202_38_0 = null!;
          try {
            contentStream.BeginText();
            contentStream.NewLineAtOffset((float)(20), (float)(80));
            contentStream.SetFont(new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica),
              (float)(12));
            contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "Test"));
            contentStream.EndText();
          } catch (global::System.Exception __dripsharpCaught_202_38_0) {
            __dripsharpPrimary_202_38_0 = __dripsharpCaught_202_38_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(contentStream,
              __dripsharpPrimary_202_38_0);
          }
        }
        global::DripSharp.Runtime.JavaFileBridge.Call(document__197_25, "Save",
          new global::System.Type[] { typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.Runtime.JavaFile)target });
      } catch (global::System.Exception __dripsharpCaught_197_25_0) {
        __dripsharpPrimary_197_25_0 = __dripsharpCaught_197_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document__197_25,
          __dripsharpPrimary_197_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document__214_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)target });
      global::System.Exception __dripsharpPrimary_214_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(3, document__214_25.GetNumberOfPages(),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The number of pages should not have changed, during compression."));
        global::DripSharp.PdfCarton.Pdmodel.PDPage page__218_20 = document__214_25.GetPage(2);
        global::DripSharp.Testing.JavaAssertions.Equal(43,
          (page__218_20.GetContentStreams()).Next()!.GetLength(),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The stream length of the new page is not as expected."));
      } catch (global::System.Exception __dripsharpCaught_214_25_0) {
        __dripsharpPrimary_214_25_0 = __dripsharpCaught_214_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document__214_25,
          __dripsharpPrimary_214_25_0);
      }
    }
  }

  internal virtual void testPDFBox5927() {
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream(); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__234_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "target/pdfs"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "PDFBOX-5927.pdf")) });
      global::System.Exception __dripsharpPrimary_234_25_0 = null!;
      try {
        doc__234_25.Save(baos);
      } catch (global::System.Exception __dripsharpCaught_234_25_0) {
        __dripsharpPrimary_234_25_0 = __dripsharpCaught_234_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__234_25,
          __dripsharpPrimary_234_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__238_25
        = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
      global::System.Exception __dripsharpPrimary_238_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
          = doc__238_25.GetDocumentCatalog().GetAcroForm();
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox cb
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "chkPrivacy1"))!);
        global::DripSharp.Testing.JavaAssertions.True(cb.IsChecked(), null);
      } catch (global::System.Exception __dripsharpCaught_238_25_0) {
        __dripsharpPrimary_238_25_0 = __dripsharpCaught_238_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__238_25,
          __dripsharpPrimary_238_25_0);
      }
    }
  }

  [Xunit.Fact]
  public void __Upstream_0726120437_ed8b8771c1b74948() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testAlteredDoc();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3478546529_c51987dfa3675c89() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testCompressAcroformDoc();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2291719836_18e4187e1b8afa4a() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testCompressAttachmentsDoc();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4197713160_ff63bba101d9b94d() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testCompressEncryptedDoc();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724611860_d67e073d100289a6() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBox5927();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll;

  private static bool __RunUpstreamBeforeAll() {
    init();
    return true;
  }

  static COSDocumentCompressionTest() {
    INDIR
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "src/test/resources/input/compression/"));
    OUTDIR
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/test-output/compression/"));
    __UpstreamBeforeAll = __RunUpstreamBeforeAll();
  }
}
