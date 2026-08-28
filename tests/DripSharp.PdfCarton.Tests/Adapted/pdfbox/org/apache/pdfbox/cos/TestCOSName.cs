// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Cos;

public class TestCOSName {
  private static readonly global::System.IO.FileInfo TARGETPDFDIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/pdfs"));

  internal virtual void PDFBox4076() {
    string special = "\u4E2D\u56FD\u4F60\u597D!";
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__47_25
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.PDPage page
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
      document__47_25.AddPage(page);
      document__47_25.GetDocumentCatalog().GetCOSObject().SetString(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        special)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", special));
      document__47_25.Save(baos);
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__55_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos))) {
      global::DripSharp.PdfCarton.Cos.COSDictionary catalogDict
        = document__55_25.GetDocumentCatalog().GetCOSObject();
      global::DripSharp.Testing.JavaAssertions.True(catalogDict.ContainsKey(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        special)), null);
      global::DripSharp.Testing.JavaAssertions.Equal(special,
        catalogDict.GetString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        special)), null);
    }
  }

  internal virtual void PDFBox6178() {
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Cos.TestCOSName.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-6178.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field
        = document.GetDocumentCatalog().GetAcroForm((global::DripSharp.PdfCarton.Pdmodel.Fixup.PDDocumentFixup)default!).GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Geschlecht"));
      field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "m\u00E4nnlich"));
      global::DripSharp.Runtime.JavaCompat.ForEach(global::DripSharp.Runtime.JavaCompat.ListGet(field.GetWidgets(),
        0).GetAppearance().GetNormalAppearance().GetCOSObject().KeySet(), (k) => {
          try {
            k.WritePDF(baos);
          } catch (global::System.IO.IOException) {}
        });
      string writtenKeys
        = global::DripSharp.Runtime.JavaCompat.NewString(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos),
        global::DripSharp.PdfCarton.Tests.Support.EncodingByName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "UTF-8")));
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(writtenKeys,
        "/m#E4nnlich"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Output should be /m#e4nnlich (with 0xE4 as hex escape)"));
    }
  }

  internal virtual void NameWithASCII_NUL() {
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Cos.TestCOSName.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-6178-1.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field
        = document.GetDocumentCatalog().GetAcroForm((global::DripSharp.PdfCarton.Pdmodel.Fixup.PDDocumentFixup)default!).GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Geschlecht"));
      global::DripSharp.Runtime.JavaCompat.ForEach(global::DripSharp.Runtime.JavaCompat.ListGet(field.GetWidgets(),
        0).GetAppearance().GetNormalAppearance().GetCOSObject().KeySet(), (k) => {
          try {
            k.WritePDF(baos);
          } catch (global::System.IO.IOException) {}
        });
      string writtenKeys
        = global::DripSharp.Runtime.JavaCompat.NewString(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos),
        global::DripSharp.PdfCarton.Tests.Support.EncodingByName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "UTF-8")));
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(writtenKeys,
        "/m#00nnlich"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Output should be /m#00nnlich (with 0xE4 as hex escape)"));
    }
  }

  [Xunit.Fact]
  public void __Upstream_2201260646_9b55e498b0b807d3() {
    try {
      this.NameWithASCII_NUL();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0137081204_e2df5f6375fce32a() {
    try {
      this.PDFBox4076();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0137141749_bd4989541d527e82() {
    try {
      this.PDFBox6178();
    } finally {
    }
  }
}
