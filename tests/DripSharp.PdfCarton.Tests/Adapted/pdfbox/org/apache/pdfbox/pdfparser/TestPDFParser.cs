// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdfparser;

public class TestPDFParser {
  private static readonly global::System.IO.FileInfo TARGETPDFDIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/pdfs"));

  internal virtual void testPDFParserMissingCatalog() {
    global::DripSharp.Testing.JavaAssertions.DoesNotThrow(()
      => global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdfparser.TestPDFParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "MissingCatalog.pdf")))).Dispose(), null);
  }

  internal virtual void testPDFBox3208() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3208-L33MUTT2SVCWGCS6UIYL5TH3PNPXHIS6.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentInformation di = doc.GetDocumentInformation();
      global::DripSharp.Testing.JavaAssertions.Equal("Liquent Enterprise Services", di.GetAuthor(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal("Liquent services server", di.GetCreator(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal("Amyuni PDF Converter version 4.0.0.9",
        di.GetProducer(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("", di.GetKeywords(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("", di.GetSubject(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("892B77DE781B4E71A1BEFB81A51A5ABC_20140326022424.docx",
        di.GetTitle(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "D:20140326142505-02'00'")), di.GetCreationDate(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "20140326172513Z")), di.GetModificationDate(), null);
    }
  }

  internal virtual void testPDFBox3940() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-3940-079977.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentInformation di = doc.GetDocumentInformation();
      global::DripSharp.Testing.JavaAssertions.Equal("Unknown", di.GetAuthor(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("C:REGULA~1IREGSFR_EQ_EM.WP", di.GetCreator(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal("Acrobat PDFWriter 3.02 for Windows",
        di.GetProducer(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("", di.GetKeywords(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("", di.GetSubject(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("C:REGULA~1IREGSFR_EQ_EM.PDF", di.GetTitle(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Tuesday, July 28, 1998 4:00:09 PM")), di.GetCreationDate(), null);
    }
  }

  internal virtual void testPDFBox3783() {
    global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => {
        global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "PDFBOX-3783-72GLBIGUC6LB46ELZFBARRJTLN4RBSQM.pdf")))).Dispose();
      }, null);
  }

  internal virtual void testPDFBox3785() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-3785-202097.pdf"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal(11, doc.GetNumberOfPages(), null);
    }
  }

  internal virtual void testPDFBox3947() {
    global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => {
        global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "PDFBOX-3947-670064.pdf")))).Dispose();
      }, null);
  }

  internal virtual void testPDFBox3948() {
    global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => {
        global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "PDFBOX-3948-EUWO6SQS5TM4VGOMRD3FLXZHU35V2CP2.pdf")))).Dispose();
      }, null);
  }

  internal virtual void testPDFBox3949() {
    global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => {
        global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "PDFBOX-3949-MKFYUGZWS3OPXLLVU2Z4LWCTVA5WNOGF.pdf")))).Dispose();
      }, null);
  }

  internal virtual void testPDFBox3950() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3950-23EGDHXSBBYQLKYOKGZUOVYVNE675PRD.pdf"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal(4, doc.GetNumberOfPages(), null);
      global::DripSharp.PdfCarton.Rendering.PDFRenderer renderer
        = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(doc);
      for (int i = 0; (i < doc.GetNumberOfPages()); ++i) {
        try {
          renderer.RenderImage(i);
        } catch (global::System.IO.IOException ex) {
          if (((i == 3)
            && global::DripSharp.Runtime.JavaCompat.Equals(global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex),
            "Missing descendant font array"))) {
            continue;
          }
          throw;
        }
      }
    }
  }

  internal virtual void testPDFBox3951() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3951-FIHUZWDDL2VGPOE34N6YHWSIGSH5LVGZ.pdf"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal(143, doc.GetNumberOfPages(), null);
    }
  }

  internal virtual void testPDFBox3964() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3964-c687766d68ac766be3f02aaec5e0d713_2.pdf"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal(10, doc.GetNumberOfPages(), null);
    }
  }

  internal virtual void testPDFBox3977() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3977-63NGFQRI44HQNPIPEJH5W2TBM6DJZWMI.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentInformation di = doc.GetDocumentInformation();
      global::DripSharp.Testing.JavaAssertions.Equal("QuarkXPress(tm) 6.52", di.GetCreator(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("Acrobat Distiller 7.0 pour Macintosh",
        di.GetProducer(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("Fich sal Fabr corr1 (Page 6)", di.GetTitle(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "D:20070608151915+02'00'")), di.GetCreationDate(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "D:20080604152122+02'00'")), di.GetModificationDate(), null);
    }
  }

  internal virtual void testParseGenko() {
    global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => {
        global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "genko_oc_shiryo1.pdf")))).Dispose();
      }, null);
  }

  internal virtual void testPDFBox4338() {
    global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => {
        global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "PDFBOX-4338.pdf")))).Dispose();
      }, null);
  }

  internal virtual void testPDFBox4339() {
    global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => {
        global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "PDFBOX-4339.pdf")))).Dispose();
      }, null);
  }

  internal virtual void testPDFBox4153() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-4153-WXMDXCYRWFDCMOSFQJ5OAJIAFXYRZ5OA.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDDocumentOutline documentOutline
        = doc.GetDocumentCatalog().GetDocumentOutline();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem firstChild
        = documentOutline.GetFirstChild();
      global::DripSharp.Testing.JavaAssertions.Equal("Main Menu", firstChild.GetTitle(), null);
    }
  }

  internal virtual void testPDFBox4490() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4490.pdf"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal(3, doc.GetNumberOfPages(), null);
    }
  }

  internal virtual void testPDFBox5025() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfparser.TestPDFParser.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-5025.pdf"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal(1, doc.GetNumberOfPages(), null);
      global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font
        = doc.GetPage(0).GetResources().GetFont(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "F1")));
      int length1
        = font.GetFontDescriptor().GetFontFile2().GetCOSObject().GetInt(global::DripSharp.PdfCarton.Cos.COSName.Length1);
      global::DripSharp.Testing.JavaAssertions.Equal(74191, length1, null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724545490_e7a8224e1ef92887() {
    try {
      this.testPDFBox3208();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724550538_abc3d235e54442e8() {
    try {
      this.testPDFBox3783();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724550540_6ed3936fc46a2fad() {
    try {
      this.testPDFBox3785();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724552333_5782a9b77a740831() {
    try {
      this.testPDFBox3940();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724552340_42a48091e28c3eed() {
    try {
      this.testPDFBox3947();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724552341_ed63ece21d51c94a() {
    try {
      this.testPDFBox3948();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724552342_cc7799c1f838a52f() {
    try {
      this.testPDFBox3949();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724552364_cbc743cdda9cae87() {
    try {
      this.testPDFBox3950();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724552365_893614b3bc1bbb45() {
    try {
      this.testPDFBox3951();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724552399_d30ade97b01375c5() {
    try {
      this.testPDFBox3964();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724552433_1e6dffdc6477d1d0() {
    try {
      this.testPDFBox3977();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724574470_ce758dec5ba6bf5b() {
    try {
      this.testPDFBox4153();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724576335_d5a09a7673608475() {
    try {
      this.testPDFBox4338();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724576336_39bedf5db25e8994() {
    try {
      this.testPDFBox4339();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724577474_fb370fef5e49a9ab() {
    try {
      this.testPDFBox4490();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724603209_3a1f1e81c28e9146() {
    try {
      this.testPDFBox5025();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2362941682_14c4eb6760824ea4() {
    try {
      this.testPDFParserMissingCatalog();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0430229491_e3f03815fd055c44() {
    try {
      this.testParseGenko();
    } finally {
    }
  }
}
