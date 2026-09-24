// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Encryption;

public class TestSymmetricKeyEncryption {
  private static readonly global::Microsoft.Extensions.Logging.ILogger LOG;

  private static readonly global::DripSharp.Runtime.JavaFile TESTRESULTSDIR;

  private static global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission permission = null!;

  internal const string USERPASSWORD = "1234567890abcdefghijk1234567890abcdefghijk";

  internal const string OWNERPASSWORD = "abcdefghijk1234567890abcdefghijk1234567890";

  internal static void setUp() {
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.TESTRESULTSDIR);
    global::DripSharp.Testing.JavaAssertions.Equal(int.MaxValue,
      global::DripSharp.Runtime.JavaCipher.GetMaxAllowedKeyLength(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "AES")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "JCE unlimited strength jurisdiction policy files are not installed"));
    global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission
      = new global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission();
    global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission.SetCanAssembleDocument(false);
    global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission.SetCanExtractContent(false);
    global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission.SetCanExtractForAccessibility(true);
    global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission.SetCanFillInForm(false);
    global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission.SetCanModify(false);
    global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission.SetCanModifyAnnotations(false);
    global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission.SetCanPrint(true);
    global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission.SetCanPrintFaithful(false);
    global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission.SetReadOnly();
  }

  internal virtual void testPermissions() {
    global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission fullAP
      = new global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission();
    global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission restrAP
      = new global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission();
    restrAP.SetCanPrint(false);
    restrAP.SetCanExtractContent(false);
    restrAP.SetCanModify(false);
    this.checkSeveralPerms(this.getFileResourceAsByteArray(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PasswordSample-40bit.pdf")), fullAP, restrAP);
    restrAP.SetCanAssembleDocument(false);
    restrAP.SetCanExtractForAccessibility(false);
    restrAP.SetCanPrintFaithful(false);
    this.checkSeveralPerms(this.getFileResourceAsByteArray(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PasswordSample-128bit.pdf")), fullAP, restrAP);
    this.checkSeveralPerms(this.getFileResourceAsByteArray(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PasswordSample-256bit.pdf")), fullAP, restrAP);
  }

  private void checkSeveralPerms(sbyte[] inputFileAsByteArray1,
    global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission fullAP,
    global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission restrAP) {
    global::DripSharp.PdfCarton.Pdmodel.Encryption.InvalidPasswordException ex;
    this.checkPerms(inputFileAsByteArray1,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "owner"), fullAP);
    this.checkPerms(inputFileAsByteArray1,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "user"), restrAP);
    ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Pdmodel.Encryption.InvalidPasswordException>(()
      => this.checkPerms(inputFileAsByteArray1,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ""),
      (global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission)default!),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "wrong password not detected"));
    global::DripSharp.Testing.JavaAssertions.Equal("Cannot decrypt PDF, the password is incorrect",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  private void checkPerms(sbyte[] inputFileAsByteArray, string password,
    global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission expectedPermissions) { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = global::DripSharp.PdfCarton.Loader.LoadPDF(inputFileAsByteArray,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", password));
      global::System.Exception __dripsharpPrimary_159_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission currentAccessPermission
          = doc.GetCurrentAccessPermission();
        global::DripSharp.Testing.JavaAssertions.Equal(expectedPermissions.IsOwnerPermission(),
          currentAccessPermission.IsOwnerPermission(), null);
        if (!(expectedPermissions.IsOwnerPermission())) {
          global::DripSharp.Testing.JavaAssertions.Equal(true, currentAccessPermission.IsReadOnly(),
            null);
        }
        global::DripSharp.Testing.JavaAssertions.Equal(expectedPermissions.CanAssembleDocument(),
          currentAccessPermission.CanAssembleDocument(), null);
        global::DripSharp.Testing.JavaAssertions.Equal(expectedPermissions.CanExtractContent(),
          currentAccessPermission.CanExtractContent(), null);
        global::DripSharp.Testing.JavaAssertions.Equal(expectedPermissions.CanExtractForAccessibility(),
          currentAccessPermission.CanExtractForAccessibility(), null);
        global::DripSharp.Testing.JavaAssertions.Equal(expectedPermissions.CanFillInForm(),
          currentAccessPermission.CanFillInForm(), null);
        global::DripSharp.Testing.JavaAssertions.Equal(expectedPermissions.CanModify(),
          currentAccessPermission.CanModify(), null);
        global::DripSharp.Testing.JavaAssertions.Equal(expectedPermissions.CanModifyAnnotations(),
          currentAccessPermission.CanModifyAnnotations(), null);
        global::DripSharp.Testing.JavaAssertions.Equal(expectedPermissions.CanPrint(),
          currentAccessPermission.CanPrint(), null);
        global::DripSharp.Testing.JavaAssertions.Equal(expectedPermissions.CanPrintFaithful(),
          currentAccessPermission.CanPrintFaithful(), null);
        new global::DripSharp.PdfCarton.Rendering.PDFRenderer(doc).RenderImage(0);
      } catch (global::System.Exception __dripsharpCaught_159_25_0) {
        __dripsharpPrimary_159_25_0 = __dripsharpCaught_159_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_159_25_0);
      }
    }
  }

  internal virtual void testProtection() {
    string filename = "Acroform-PDFBOX-2333.pdf";
    sbyte[] inputFileAsByteArray
      = this.getFileResourceAsByteArray(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      filename));
    int sizePriorToEncryption = inputFileAsByteArray.Length;
    this.testSymmEncrForKeySize(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      filename), 40, false, sizePriorToEncryption, inputFileAsByteArray,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.USERPASSWORD),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.OWNERPASSWORD),
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission);
    this.testSymmEncrForKeySize(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      filename), 128, false, sizePriorToEncryption, inputFileAsByteArray,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.USERPASSWORD),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.OWNERPASSWORD),
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission);
    this.testSymmEncrForKeySize(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      filename), 128, true, sizePriorToEncryption, inputFileAsByteArray,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.USERPASSWORD),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.OWNERPASSWORD),
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission);
    this.testSymmEncrForKeySize(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      filename), 256, true, sizePriorToEncryption, inputFileAsByteArray,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.USERPASSWORD),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.OWNERPASSWORD),
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission);
  }

  internal virtual void testPDFBox4308() {
    string filename = "PDFBOX-4308.pdf";
    sbyte[] inputFileAsByteArray
      = global::DripSharp.Runtime.JavaCompat.ReadAllBytes(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.PathOf(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat("target/pdfs/", filename)))));
    int sizePriorToEncryption = inputFileAsByteArray.Length;
    this.testSymmEncrForKeySize(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      filename), 40, false, sizePriorToEncryption, inputFileAsByteArray,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.USERPASSWORD),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.OWNERPASSWORD),
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission);
  }

  internal virtual void testPDFBox5955() {
    global::DripSharp.Runtime.JavaFile file40bit
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/pdfs"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-5955-40bit.pdf"));
    global::DripSharp.Runtime.JavaFile file48bit
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/pdfs"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-5955-48bit.pdf")); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__239_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)file40bit });
      global::System.Exception __dripsharpPrimary_239_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Text.PDFTextStripper stripper__241_29
          = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
        string text__242_20 = stripper__241_29.GetText(doc__239_25);
        global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(text__242_20,
          "0x0446615747"), null);
      } catch (global::System.Exception __dripsharpCaught_239_25_0) {
        __dripsharpPrimary_239_25_0 = __dripsharpCaught_239_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__239_25,
          __dripsharpPrimary_239_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__245_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo), typeof(string) },
        new object[] { (global::DripSharp.Runtime.JavaFile)file40bit,
          (string)global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ownerpass") });
      global::System.Exception __dripsharpPrimary_245_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Text.PDFTextStripper stripper__247_29
          = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
        string text__248_20 = stripper__247_29.GetText(doc__245_25);
        global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(text__248_20,
          "0x0446615747"), null);
      } catch (global::System.Exception __dripsharpCaught_245_25_0) {
        __dripsharpPrimary_245_25_0 = __dripsharpCaught_245_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__245_25,
          __dripsharpPrimary_245_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__251_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)file48bit });
      global::System.Exception __dripsharpPrimary_251_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Text.PDFTextStripper stripper__253_29
          = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
        string text__254_20 = stripper__253_29.GetText(doc__251_25);
        global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(text__254_20,
          "0x02988E82AFF8"), null);
      } catch (global::System.Exception __dripsharpCaught_251_25_0) {
        __dripsharpPrimary_251_25_0 = __dripsharpCaught_251_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__251_25,
          __dripsharpPrimary_251_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__257_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo), typeof(string) },
        new object[] { (global::DripSharp.Runtime.JavaFile)file48bit,
          (string)global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ownerpass") });
      global::System.Exception __dripsharpPrimary_257_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Text.PDFTextStripper stripper__259_29
          = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
        string text__260_20 = stripper__259_29.GetText(doc__257_25);
        global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(text__260_20,
          "0x02988E82AFF8"), null);
      } catch (global::System.Exception __dripsharpCaught_257_25_0) {
        __dripsharpPrimary_257_25_0 = __dripsharpCaught_257_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__257_25,
          __dripsharpPrimary_257_25_0);
      }
    }
  }

  internal virtual void testProtectionInnerAttachment() {
    string testFileName = "preEnc_20141025_105451.pdf";
    sbyte[] inputFileWithEmbeddedFileAsByteArray
      = this.getFileResourceAsByteArray(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      testFileName));
    int sizeOfFileWithEmbeddedFile = inputFileWithEmbeddedFileAsByteArray.Length;
    global::DripSharp.Runtime.JavaFile extractedEmbeddedFile
      = this.extractEmbeddedFile(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputFileWithEmbeddedFileAsByteArray),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "innerFile.pdf"));
    this.testSymmEncrForKeySizeInner(40, false, sizeOfFileWithEmbeddedFile,
      inputFileWithEmbeddedFileAsByteArray, extractedEmbeddedFile,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.USERPASSWORD),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.OWNERPASSWORD));
    this.testSymmEncrForKeySizeInner(128, false, sizeOfFileWithEmbeddedFile,
      inputFileWithEmbeddedFileAsByteArray, extractedEmbeddedFile,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.USERPASSWORD),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.OWNERPASSWORD));
    this.testSymmEncrForKeySizeInner(128, true, sizeOfFileWithEmbeddedFile,
      inputFileWithEmbeddedFileAsByteArray, extractedEmbeddedFile,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.USERPASSWORD),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.OWNERPASSWORD));
    this.testSymmEncrForKeySizeInner(256, true, sizeOfFileWithEmbeddedFile,
      inputFileWithEmbeddedFileAsByteArray, extractedEmbeddedFile,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.USERPASSWORD),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.OWNERPASSWORD));
  }

  internal virtual void testPDFBox4453() {
    int TESTCOUNT = 1000;
    global::DripSharp.Runtime.JavaFile file
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.TESTRESULTSDIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4453.pdf")); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__307_25
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_307_25_0 = null!;
      try {
        doc__307_25.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
        for (int i__310_22 = 0; (i__310_22 < TESTCOUNT); ++i__310_22) {
          global::DripSharp.PdfCarton.Cos.COSDictionary dict__314_31
            = new global::DripSharp.PdfCarton.Cos.COSDictionary();
          doc__307_25.GetPage(0).GetCOSObject().SetItem(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            global::DripSharp.Runtime.JavaCompat.Concat("_Test-", i__310_22))), dict__314_31);
          dict__314_31.SetString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            "key1"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "3"));
          dict__314_31.SetString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            "key2"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "0"));
        }
        global::DripSharp.PdfCarton.Pdmodel.Encryption.StandardProtectionPolicy spp
          = new global::DripSharp.PdfCarton.Pdmodel.Encryption.StandardProtectionPolicy(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ""),
          new global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission());
        spp.SetEncryptionKeyLength(40);
        spp.SetPreferAES(false);
        doc__307_25.Protect(spp);
        global::DripSharp.Runtime.JavaFileBridge.Call(doc__307_25, "Save",
          new global::System.Type[] { typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.Runtime.JavaFile)file });
      } catch (global::System.Exception __dripsharpCaught_307_25_0) {
        __dripsharpPrimary_307_25_0 = __dripsharpCaught_307_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__307_25,
          __dripsharpPrimary_307_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__331_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)file });
      global::System.Exception __dripsharpPrimary_331_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.True(doc__331_25.IsEncrypted(), null);
        for (int i__334_22 = 0; (i__334_22 < TESTCOUNT); ++i__334_22) {
          global::DripSharp.PdfCarton.Cos.COSDictionary dict__336_31
            = doc__331_25.GetPage(0).GetCOSObject().GetCOSDictionary(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            global::DripSharp.Runtime.JavaCompat.Concat("_Test-", i__334_22))));
          global::DripSharp.Testing.JavaAssertions.Equal("3",
            dict__336_31.GetString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            "key1")), null);
          global::DripSharp.Testing.JavaAssertions.Equal("0",
            dict__336_31.GetString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            "key2")), null);
        }
      } catch (global::System.Exception __dripsharpCaught_331_25_0) {
        __dripsharpPrimary_331_25_0 = __dripsharpCaught_331_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__331_25,
          __dripsharpPrimary_331_25_0);
      }
    }
  }

  internal virtual void testPDFBox5639() {
    global::DripSharp.Runtime.JavaFile file
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/pdfs"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-5639.pdf")); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo), typeof(string) },
        new object[] { (global::DripSharp.Runtime.JavaFile)file,
          (string)global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "JUL2023rfi") });
      global::System.Exception __dripsharpPrimary_353_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(2, document.GetNumberOfPages(), null);
      } catch (global::System.Exception __dripsharpCaught_353_25_0) {
        __dripsharpPrimary_353_25_0 = __dripsharpCaught_353_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document, __dripsharpPrimary_353_25_0);
      }
    }
  }

  private void testSymmEncrForKeySize(string filename, int keyLength, bool preferAES,
    int sizePriorToEncr, sbyte[] inputFileAsByteArray, string userpassword, string ownerpassword,
    global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission permission) {
    global::DripSharp.PdfCarton.Pdmodel.PDDocument document
      = global::DripSharp.PdfCarton.Loader.LoadPDF(inputFileAsByteArray);
    string prefix = global::DripSharp.Runtime.JavaCompat.Concat(filename, "-Simple-");
    int numSrcPages = document.GetNumberOfPages();
    global::DripSharp.PdfCarton.Rendering.PDFRenderer pdfRenderer
      = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(document);
    global::System.Collections.Generic.IList<global::SkiaSharp.SKBitmap> srcImgTab
      = new global::System.Collections.Generic.List<global::SkiaSharp.SKBitmap>();
    global::System.Collections.Generic.IList<sbyte[]> srcContentStreamTab
      = new global::System.Collections.Generic.List<sbyte[]>();
    for (int i__370_18 = 0; (i__370_18 < numSrcPages); ++i__370_18) {
      global::DripSharp.Runtime.JavaCompat.Add(srcImgTab, pdfRenderer.RenderImage(i__370_18)); {
        global::System.IO.Stream unfilteredStream__373_30
          = document.GetPage(i__370_18).GetContents();
        global::System.Exception __dripsharpPrimary_373_30_0 = null!;
        try {
          global::DripSharp.Runtime.JavaCompat.Add(srcContentStreamTab,
            global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(unfilteredStream__373_30));
        } catch (global::System.Exception __dripsharpCaught_373_30_0) {
          __dripsharpPrimary_373_30_0 = __dripsharpCaught_373_30_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(unfilteredStream__373_30,
            __dripsharpPrimary_373_30_0);
        }
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument encryptedDoc = this.encrypt(keyLength,
        preferAES, sizePriorToEncr, document,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", prefix), permission,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", userpassword),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ownerpassword));
      global::System.Exception __dripsharpPrimary_379_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(numSrcPages, encryptedDoc.GetNumberOfPages(),
          null);
        pdfRenderer = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(encryptedDoc);
        for (int i__384_22 = 0; (i__384_22 < encryptedDoc.GetNumberOfPages()); ++i__384_22) {
          global::SkiaSharp.SKBitmap bim = pdfRenderer.RenderImage(i__384_22);
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(bim,
            global::DripSharp.Runtime.JavaCompat.ListGet(srcImgTab, i__384_22)); {
            global::System.IO.Stream unfilteredStream__391_34
              = encryptedDoc.GetPage(i__384_22).GetContents();
            global::System.Exception __dripsharpPrimary_391_34_0 = null!;
            try {
              sbyte[] bytes
                = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(unfilteredStream__391_34);
              global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ListGet(srcContentStreamTab,
                i__384_22), bytes, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("content stream of page ",
                i__384_22), " not identical")));
            } catch (global::System.Exception __dripsharpCaught_391_34_0) {
              __dripsharpPrimary_391_34_0 = __dripsharpCaught_391_34_0;
              throw;
            } finally {
              global::DripSharp.Runtime.JavaCompat.CloseResource(unfilteredStream__391_34,
                __dripsharpPrimary_391_34_0);
            }
          }
        }
        global::DripSharp.Runtime.JavaFile pdfFile
          = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.TESTRESULTSDIR,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(prefix,
          keyLength), "-bit-"), (preferAES ? "AES" : "RC4")), "-decrypted.pdf")));
        encryptedDoc.SetAllSecurityToBeRemoved(true);
        global::DripSharp.Runtime.JavaFileBridge.Call(encryptedDoc, "Save",
          new global::System.Type[] { typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.Runtime.JavaFile)pdfFile });
      } catch (global::System.Exception __dripsharpCaught_379_25_0) {
        __dripsharpPrimary_379_25_0 = __dripsharpCaught_379_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(encryptedDoc,
          __dripsharpPrimary_379_25_0);
      }
    }
  }

  private global::DripSharp.PdfCarton.Pdmodel.PDDocument encrypt(int keyLength, bool preferAES,
    int sizePriorToEncr, global::DripSharp.PdfCarton.Pdmodel.PDDocument doc, string prefix,
    global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission permission, string userpassword,
    string ownerpassword) {
    global::DripSharp.PdfCarton.Pdmodel.Encryption.StandardProtectionPolicy spp
      = new global::DripSharp.PdfCarton.Pdmodel.Encryption.StandardProtectionPolicy(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      ownerpassword), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", userpassword),
      permission);
    spp.SetEncryptionKeyLength(keyLength);
    spp.SetPreferAES(preferAES);
    doc.SetAllSecurityToBeRemoved(true);
    doc.Protect(spp);
    global::DripSharp.Runtime.JavaFile pdfFile
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.TESTRESULTSDIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(prefix,
      keyLength), "-bit-"), (preferAES ? "AES" : "RC4")), "-encrypted.pdf")));
    global::DripSharp.Runtime.JavaFileBridge.Call(doc, "Save",
      new global::System.Type[] { typeof(global::System.IO.FileInfo) },
      new object[] { (global::DripSharp.Runtime.JavaFile)pdfFile });
    doc.Dispose();
    long sizeEncrypted = pdfFile.Length;
    global::DripSharp.Testing.JavaAssertions.NotEqual(sizeEncrypted, (long)(sizePriorToEncr),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(keyLength,
      "-bit "), (preferAES ? "AES" : "RC4")),
      " encrypted pdf should not have same size as plain one"))); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument encryptedDoc__429_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo), typeof(string) },
        new object[] { (global::DripSharp.Runtime.JavaFile)pdfFile,
          (string)global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ownerpassword) });
      global::System.Exception __dripsharpPrimary_429_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.True(encryptedDoc__429_25.IsEncrypted(), null);
        global::DripSharp.Testing.JavaAssertions.True(encryptedDoc__429_25.GetCurrentAccessPermission().IsOwnerPermission(),
          null);
        global::DripSharp.PdfCarton.Pdmodel.Encryption.PDEncryption encryption
          = encryptedDoc__429_25.GetEncryption();
        int revision = encryption.GetRevision();
        if ((revision < 5)) {
          global::DripSharp.PdfCarton.Pdmodel.Encryption.StandardSecurityHandler standardSecurityHandler
            = new global::DripSharp.PdfCarton.Pdmodel.Encryption.StandardSecurityHandler();
          int keyLengthInBytes = ((encryption.GetVersion() == 1) ? 5
            : global::DripSharp.Runtime.JavaCompat.IntegralDivide(encryption.GetLength(), 8));
          sbyte[] computedUserPassword
            = standardSecurityHandler.GetUserPassword(global::DripSharp.Runtime.JavaCompat.StringGetBytes(ownerpassword,
            global::DripSharp.Runtime.JavaStandardCharsets.ISO88591), encryption.GetOwnerKey(),
            revision, keyLengthInBytes);
          global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.StringSubstring(userpassword,
            0, 32), global::DripSharp.Runtime.JavaCompat.NewString(computedUserPassword,
            global::DripSharp.Runtime.JavaStandardCharsets.ISO88591), null);
        }
      } catch (global::System.Exception __dripsharpCaught_429_25_0) {
        __dripsharpPrimary_429_25_0 = __dripsharpCaught_429_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(encryptedDoc__429_25,
          __dripsharpPrimary_429_25_0);
      }
    }
    global::DripSharp.PdfCarton.Pdmodel.PDDocument encryptedDoc__451_20
      = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
      "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo), typeof(string) },
      new object[] { (global::DripSharp.Runtime.JavaFile)pdfFile,
        (string)global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", userpassword) });
    global::DripSharp.Testing.JavaAssertions.True(encryptedDoc__451_20.IsEncrypted(), null);
    global::DripSharp.Testing.JavaAssertions.False(encryptedDoc__451_20.GetCurrentAccessPermission().IsOwnerPermission(),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(permission.GetPermissionBytes(),
      encryptedDoc__451_20.GetCurrentAccessPermission().GetPermissionBytes(), null);
    return encryptedDoc__451_20;
  }

  private global::DripSharp.Runtime.JavaFile extractEmbeddedFile(global::DripSharp.PdfCarton.IO.RandomAccessRead pdfSource,
    string name) {
    global::DripSharp.PdfCarton.Pdmodel.PDDocument docWithEmbeddedFile
      = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfSource);
    global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog
      = docWithEmbeddedFile.GetDocumentCatalog();
    global::DripSharp.PdfCarton.Pdmodel.PDDocumentNameDictionary names = catalog.GetNames();
    global::DripSharp.PdfCarton.Pdmodel.PDEmbeddedFilesNameTreeNode embeddedFiles
      = names.GetEmbeddedFiles();
    global::System.Collections.Generic.IDictionary<string,
      global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDComplexFileSpecification> embeddedFileNames
      = embeddedFiles.GetNames();
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      global::DripSharp.Runtime.JavaCompat.MapCount(embeddedFileNames), null);
    global::DripSharp.Runtime.JavaMapEntry<string,
      global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDComplexFileSpecification> entry
      = global::DripSharp.Runtime.JavaCompat.Iterator(global::DripSharp.Runtime.JavaCompat.MapEntrySet(embeddedFileNames)).Next()!;
    global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.LOG,
      global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Processing embedded file ",
      entry.Key), ":")));
    global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDComplexFileSpecification complexFileSpec
      = entry.Value;
    global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDEmbeddedFile embeddedFile
      = complexFileSpec.GetEmbeddedFile();
    global::DripSharp.Runtime.JavaFile resultFile
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.TESTRESULTSDIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", name)); {
      global::System.IO.Stream fos
        = global::DripSharp.Runtime.JavaCompat.OpenFileOutput(resultFile);
      global::System.Exception __dripsharpPrimary_475_31_0 = null!;
      try {
        global::System.IO.Stream @is = embeddedFile.CreateInputStream();
        global::System.Exception __dripsharpPrimary_476_26_0 = null!;
        try {
          global::DripSharp.PdfCarton.IO.IOUtils.Copy(@is, fos);
        } catch (global::System.Exception __dripsharpCaught_476_26_0) {
          __dripsharpPrimary_476_26_0 = __dripsharpCaught_476_26_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_476_26_0);
        }
      } catch (global::System.Exception __dripsharpCaught_475_31_0) {
        __dripsharpPrimary_475_31_0 = __dripsharpCaught_475_31_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(fos, __dripsharpPrimary_475_31_0);
      }
    }
    global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.LOG,
      global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("  size: ",
      embeddedFile.GetSize())));
    global::DripSharp.Testing.JavaAssertions.Equal((long)(embeddedFile.GetSize()),
      resultFile.Length, null);
    return resultFile;
  }

  private void testSymmEncrForKeySizeInner(int keyLength, bool preferAES, int sizePriorToEncr,
    sbyte[] inputFileWithEmbeddedFileAsByteArray,
    global::DripSharp.Runtime.JavaFile embeddedFilePriorToEncryption, string userpassword,
    string ownerpassword) {
    global::DripSharp.PdfCarton.Pdmodel.PDDocument document
      = global::DripSharp.PdfCarton.Loader.LoadPDF(inputFileWithEmbeddedFileAsByteArray); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument encryptedDoc = this.encrypt(keyLength,
        preferAES, sizePriorToEncr, document,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ContainsEmbedded-"),
        global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.permission,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", userpassword),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ownerpassword));
      global::System.Exception __dripsharpPrimary_493_25_0 = null!;
      try {
        global::DripSharp.Runtime.JavaFile decryptedFile
          = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption.TESTRESULTSDIR,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("DecryptedContainsEmbedded-",
          keyLength), "-bit-"), (preferAES ? "AES" : "RC4")), ".pdf")));
        encryptedDoc.SetAllSecurityToBeRemoved(true);
        global::DripSharp.Runtime.JavaFileBridge.Call(encryptedDoc, "Save",
          new global::System.Type[] { typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.Runtime.JavaFile)decryptedFile });
        global::DripSharp.Runtime.JavaFile extractedEmbeddedFile
          = this.extractEmbeddedFile(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(decryptedFile),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("decryptedInnerFile-",
          keyLength), "-bit-"), (preferAES ? "AES" : "RC4")), ".pdf")));
        global::DripSharp.Testing.JavaAssertions.Equal(embeddedFilePriorToEncryption.Length,
          extractedEmbeddedFile.Length, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(keyLength,
          "-bit "), (preferAES ? "AES" : "RC4")),
          " decrypted inner attachment pdf should have same size as plain one")));
        global::DripSharp.Testing.JavaAssertions.Equal(this.getFileAsByteArray(embeddedFilePriorToEncryption),
          this.getFileAsByteArray(extractedEmbeddedFile), null);
      } catch (global::System.Exception __dripsharpCaught_493_25_0) {
        __dripsharpPrimary_493_25_0 = __dripsharpCaught_493_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(encryptedDoc,
          __dripsharpPrimary_493_25_0);
      }
    }
  }

  private sbyte[] getFileResourceAsByteArray(string testFileName) { {
      global::System.IO.Stream @is
        = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Encryption.TestSymmetricKeyEncryption),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", testFileName));
      global::System.Exception __dripsharpPrimary_515_26_0 = null!;
      try {
        return global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(@is);
      } catch (global::System.Exception __dripsharpCaught_515_26_0) {
        __dripsharpPrimary_515_26_0 = __dripsharpCaught_515_26_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_515_26_0);
      }
    }
  }

  private sbyte[] getFileAsByteArray(global::DripSharp.Runtime.JavaFile f) {
    return global::DripSharp.Runtime.JavaCompat.ReadAllBytes(global::DripSharp.Runtime.JavaCompat.FileToPath(f));
  }

  [Xunit.Fact]
  public void __Upstream_1724576242_4459f72977251ee5() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBox4308();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724577353_3198f63b52824b24() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBox4453();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724609010_d8e61df4956f8486() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBox5639();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724611951_dd74655c6a0b4561() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBox5955();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2621712530_7e4e521e97dc4798() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPermissions();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4043582731_31ca50be216c0505() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testProtection();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1034060686_ebe07a730db2cbd9() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testProtectionInnerAttachment();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll;

  private static bool __RunUpstreamBeforeAll() {
    setUp();
    return true;
  }

  static TestSymmetricKeyEncryption() {
    LOG = global::Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;
    TESTRESULTSDIR
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/test-output/crypto"));
    __UpstreamBeforeAll = __RunUpstreamBeforeAll();
  }
}
