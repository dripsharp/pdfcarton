// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Font;

public class PDFontTest {
  private static readonly global::DripSharp.Runtime.JavaFile OUT_DIR;

  internal static void setUp() {
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Font.PDFontTest.OUT_DIR);
  }

  internal virtual void testPDFBox988() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Font.PDFontTest),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "F001u_3_7j.pdf"))) });
      global::System.Exception __dripsharpPrimary_89_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Rendering.PDFRenderer renderer
          = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(doc);
        renderer.RenderImage(0);
      } catch (global::System.Exception __dripsharpCaught_89_25_0) {
        __dripsharpPrimary_89_25_0 = __dripsharpCaught_89_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_89_25_0);
      }
    }
  }

  internal virtual void testPDFBOX5486() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_101_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.Font.PDTrueTypeFont ttf
          = global::DripSharp.PdfCarton.Pdmodel.Font.PDTrueTypeFont.Load(doc,
          global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Font.PDFontTest),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "/org/apache/pdfbox/resources/ttf/LiberationSans-Regular.ttf")),
          global::DripSharp.PdfCarton.Pdmodel.Font.Encoding.WinAnsiEncoding.Instance);
        global::DripSharp.Testing.JavaAssertions.True(ttf.HasGlyph(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "A")), null);
        ttf.GetPath(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "A"));
      } catch (global::System.Exception __dripsharpCaught_101_25_0) {
        __dripsharpPrimary_101_25_0 = __dripsharpCaught_101_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_101_25_0);
      }
    }
  }

  internal virtual void testPDFBox3747() {
    global::DripSharp.Runtime.JavaFile file
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "c:/windows/fonts"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "calibri.ttf"));
    global::DripSharp.Testing.JavaAssertions.AssumeTrue(global::System.IO.File.Exists(file.FullName),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "testPDFBox3747 skipped"));
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream(); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__125_25
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_125_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
        doc__125_25.AddPage(page);
        global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font
          = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font>(typeof(global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font),
          "Load",
          new global::System.Type[] { typeof(global::DripSharp.PdfCarton.Pdmodel.PDDocument),
            typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.PdfCarton.Pdmodel.PDDocument)doc__125_25,
            (global::DripSharp.Runtime.JavaFile)file }); {
          global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream cs
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc__125_25, page);
          global::System.Exception __dripsharpPrimary_130_38_0 = null!;
          try {
            cs.BeginText();
            cs.SetFont(font, (float)(10));
            cs.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "PDFBOX-3747"));
            cs.EndText();
          } catch (global::System.Exception __dripsharpCaught_130_38_0) {
            __dripsharpPrimary_130_38_0 = __dripsharpCaught_130_38_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(cs, __dripsharpPrimary_130_38_0);
          }
        }
        doc__125_25.Save(baos);
      } catch (global::System.Exception __dripsharpCaught_125_25_0) {
        __dripsharpPrimary_125_25_0 = __dripsharpCaught_125_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__125_25,
          __dripsharpPrimary_125_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__140_25
        = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
      global::System.Exception __dripsharpPrimary_140_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Text.PDFTextStripper stripper
          = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
        string text = stripper.GetText(doc__140_25);
        global::DripSharp.Testing.JavaAssertions.Equal("PDFBOX-3747",
          global::DripSharp.Runtime.JavaCompat.StringTrim(text), null);
      } catch (global::System.Exception __dripsharpCaught_140_25_0) {
        __dripsharpPrimary_140_25_0 = __dripsharpCaught_140_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__140_25,
          __dripsharpPrimary_140_25_0);
      }
    }
  }

  internal virtual void testPDFBox3826() {
    global::System.Uri url
      = global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Font.PDFont),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "/org/apache/pdfbox/resources/ttf/LiberationSans-Regular.ttf"));
    global::DripSharp.Runtime.JavaFile fontFile
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(url); {
      global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf1
        = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(fontFile));
      global::System.Exception __dripsharpPrimary_163_27_0 = null!;
      try {
        this.testPDFBox3826checkFonts(this.testPDFBox3826createDoc(ttf1), fontFile);
      } catch (global::System.Exception __dripsharpCaught_163_27_0) {
        __dripsharpPrimary_163_27_0 = __dripsharpCaught_163_27_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(ttf1, __dripsharpPrimary_163_27_0);
      }
    } {
      global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf2
        = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(fontFile));
      global::System.Exception __dripsharpPrimary_168_27_0 = null!;
      try {
        this.testPDFBox3826checkFonts(this.testPDFBox3826createDoc(ttf2), fontFile);
      } catch (global::System.Exception __dripsharpCaught_168_27_0) {
        __dripsharpPrimary_168_27_0 = __dripsharpCaught_168_27_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(ttf2, __dripsharpPrimary_168_27_0);
      }
    }
  }

  internal virtual void testPDFBOX4115() {
    global::DripSharp.Runtime.JavaFile fontFile
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/fonts"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "n019003l.pfb"));
    global::DripSharp.Runtime.JavaFile outputFile
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Font.PDFontTest.OUT_DIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "FontType1.pdf"));
    string text = "\u00E4\u00F6\u00FC\u00C4\u00D6\u00DC"; {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__187_25
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_187_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage(); {
          global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc__187_25, page);
          global::System.Exception __dripsharpPrimary_190_38_0 = null!;
          try {
            global::System.IO.Stream @is
              = global::DripSharp.Runtime.JavaCompat.OpenFileInput(fontFile);
            global::System.Exception __dripsharpPrimary_191_30_0 = null!;
            try {
              global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font font__193_29
                = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(doc__187_25, @is,
                global::DripSharp.PdfCarton.Pdmodel.Font.Encoding.WinAnsiEncoding.Instance);
              contentStream.BeginText();
              contentStream.SetFont(font__193_29, (float)(10));
              contentStream.NewLineAtOffset((float)(10), (float)(700));
              contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                text));
              contentStream.EndText();
            } catch (global::System.Exception __dripsharpCaught_191_30_0) {
              __dripsharpPrimary_191_30_0 = __dripsharpCaught_191_30_0;
              throw;
            } finally {
              global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_191_30_0);
            }
          } catch (global::System.Exception __dripsharpCaught_190_38_0) {
            __dripsharpPrimary_190_38_0 = __dripsharpCaught_190_38_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(contentStream,
              __dripsharpPrimary_190_38_0);
          }
        }
        doc__187_25.AddPage(page);
        global::DripSharp.Runtime.JavaFileBridge.Call(doc__187_25, "Save",
          new global::System.Type[] { typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.Runtime.JavaFile)outputFile });
      } catch (global::System.Exception __dripsharpCaught_187_25_0) {
        __dripsharpPrimary_187_25_0 = __dripsharpCaught_187_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__187_25,
          __dripsharpPrimary_187_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__206_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)outputFile });
      global::System.Exception __dripsharpPrimary_206_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font font__208_25
          = (global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font)(doc__206_25.GetPage(0).GetResources().GetFont(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "F1")))!);
        global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Font.Encoding.WinAnsiEncoding.Instance,
          font__208_25.GetEncoding(), null);
        foreach (char c in text.ToCharArray()) {
          string name = font__208_25.GetEncoding().GetName((int)(c));
          global::DripSharp.Testing.JavaAssertions.Equal("dieresis", name.Substring(1), null);
          global::DripSharp.Testing.JavaAssertions.False(font__208_25.GetPath(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            name)).Bounds.IsEmpty, null);
        }
        global::DripSharp.PdfCarton.Text.PDFTextStripper stripper
          = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
        global::DripSharp.Testing.JavaAssertions.Equal(text,
          global::DripSharp.Runtime.JavaCompat.StringTrim(stripper.GetText(doc__206_25)), null);
      } catch (global::System.Exception __dripsharpCaught_206_25_0) {
        __dripsharpPrimary_206_25_0 = __dripsharpCaught_206_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__206_25,
          __dripsharpPrimary_206_25_0);
      }
    }
  }

  internal virtual void testPDFox4318() {
    global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font helveticaBold
      = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.HelveticaBold);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(()
      => helveticaBold.Encode(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "\u0080")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "should have thrown IllegalArgumentException"));
    helveticaBold.Encode(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "\u20AC"));
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(()
      => helveticaBold.Encode(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "\u0080")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "should have thrown IllegalArgumentException"));
  }

  internal virtual void testFullEmbeddingTTC() {
    global::DripSharp.PdfCarton.Fonts.Util.Autodetect.FontFileFinder fff
      = new global::DripSharp.PdfCarton.Fonts.Util.Autodetect.FontFileFinder();
    global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeCollection ttc = default!;
    foreach (global::System.Uri uri in fff.Find()) {
      if (global::DripSharp.Runtime.JavaCompat.StringEndsWith(global::DripSharp.Runtime.JavaCompat.UriPath(uri)!,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ".ttc"))) {
        global::DripSharp.Runtime.JavaFile file
          = global::DripSharp.Runtime.JavaCompat.NewJavaFile(uri);
        global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat("TrueType collection file: ", file)));
        ttc = new global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeCollection(file);
        break;
      }
    }
    global::DripSharp.Testing.JavaAssertions.AssumeTrue((ttc! != default!),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "testFullEmbeddingTTC skipped, no .ttc files available"));
    global::System.Collections.Generic.IList<string> names
      = new global::System.Collections.Generic.List<string>();
    ttc!.ProcessAllFonts(new global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeCollection.__TrueTypeFontProcessorFunctionalAdapter((ttf)
      => {
        global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat("TrueType font in collection: ",
        ttf.GetName())));
        global::DripSharp.Runtime.JavaCompat.Add(names, ttf.GetName());
      }));
    global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf
      = ttc!.GetFontByName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.ListGet(names, 0)));
    global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat("TrueType font used for test: ", ttf.GetName())));
    global::System.IO.IOException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(new global::DripSharp.PdfCarton.Pdmodel.PDDocument(),
      ttf, false), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "should have thrown IOException"));
    global::DripSharp.Testing.JavaAssertions.Equal("Full embedding of TrueType font collections not supported",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  internal virtual void testPDFox5048() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "https://issues.apache.org/jira/secure/attachment/13017227/stringwidth.pdf")))));
      global::System.Exception __dripsharpPrimary_282_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page = doc.GetPage(0);
        global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font
          = page.GetResources().GetFont(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "F70")));
        global::DripSharp.Testing.JavaAssertions.True(font.IsDamaged(), null);
        global::DripSharp.Testing.JavaAssertions.Equal((float)(0), font.GetHeight(0), null);
        global::DripSharp.Testing.JavaAssertions.Equal((float)(0),
          font.GetStringWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Pa")),
          null);
      } catch (global::System.Exception __dripsharpCaught_282_25_0) {
        __dripsharpPrimary_282_25_0 = __dripsharpCaught_282_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_282_25_0);
      }
    }
  }

  private void testPDFBox3826checkFonts(sbyte[] byteArray,
    global::DripSharp.Runtime.JavaFile fontFile) { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = global::DripSharp.PdfCarton.Loader.LoadPDF(byteArray);
      global::System.Exception __dripsharpPrimary_296_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page2 = doc.GetPage(0);
        global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font fontF1
          = (global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font)(page2.GetResources().GetFont(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "F1")))!);
        global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(fontF1.GetName(),
          "+"), null);
        global::DripSharp.Testing.JavaAssertions.True((fontFile.Length > fontF1.GetFontDescriptor().GetFontFile2().ToByteArray().Length),
          null);
        global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font fontF2
          = (global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font)(page2.GetResources().GetFont(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "F2")))!);
        global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.StringContains(fontF2.GetName(),
          "+"), null);
        global::DripSharp.Testing.JavaAssertions.Equal(fontFile.Length,
          (long)(fontF2.GetFontDescriptor().GetFontFile2().ToByteArray().Length), null);
        global::DripSharp.PdfCarton.Pdmodel.Font.PDTrueTypeFont fontF3
          = (global::DripSharp.PdfCarton.Pdmodel.Font.PDTrueTypeFont)(page2.GetResources().GetFont(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "F3")))!);
        global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.StringContains(fontF3.GetName(),
          "+"), null);
        global::DripSharp.Testing.JavaAssertions.Equal(fontFile.Length,
          (long)(fontF3.GetFontDescriptor().GetFontFile2().ToByteArray().Length), null);
        new global::DripSharp.PdfCarton.Rendering.PDFRenderer(doc).RenderImage(0);
        global::DripSharp.PdfCarton.Text.PDFTextStripper stripper
          = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
        stripper.SetLineSeparator(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "\n"));
        string text = stripper.GetText(doc);
        global::DripSharp.Testing.JavaAssertions.Equal("testMultipleFontFileReuse1\ntestMultipleFontFileReuse2\ntestMultipleFontFileReuse3",
          global::DripSharp.Runtime.JavaCompat.StringTrim(text), null);
      } catch (global::System.Exception __dripsharpCaught_296_25_0) {
        __dripsharpPrimary_296_25_0 = __dripsharpCaught_296_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_296_25_0);
      }
    }
  }

  private sbyte[] testPDFBox3826createDoc(global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf) {
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream(); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_327_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
        doc.AddPage(page);
        global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font
          = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(doc, ttf, true); {
          global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream cs
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page);
          global::System.Exception __dripsharpPrimary_333_38_0 = null!;
          try {
            cs.BeginText();
            cs.NewLineAtOffset((float)(10), (float)(700));
            cs.SetFont(font, (float)(10));
            cs.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "testMultipleFontFileReuse1"));
            cs.EndText();
            font = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(doc, ttf, false);
            cs.BeginText();
            cs.NewLineAtOffset((float)(10), (float)(650));
            cs.SetFont(font, (float)(10));
            cs.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "testMultipleFontFileReuse2"));
            cs.EndText();
            font = global::DripSharp.PdfCarton.Pdmodel.Font.PDTrueTypeFont.Load(doc, ttf,
              global::DripSharp.PdfCarton.Pdmodel.Font.Encoding.WinAnsiEncoding.Instance);
            cs.BeginText();
            cs.NewLineAtOffset((float)(10), (float)(600));
            cs.SetFont(font, (float)(10));
            cs.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "testMultipleFontFileReuse3"));
            cs.EndText();
          } catch (global::System.Exception __dripsharpCaught_333_38_0) {
            __dripsharpPrimary_333_38_0 = __dripsharpCaught_333_38_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(cs, __dripsharpPrimary_333_38_0);
          }
        }
        doc.Save(baos);
      } catch (global::System.Exception __dripsharpCaught_327_25_0) {
        __dripsharpPrimary_327_25_0 = __dripsharpCaught_327_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_327_25_0);
      }
    }
    return global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos);
  }

  internal virtual void testDeleteFont() {
    global::DripSharp.Runtime.JavaFile tempFontFile
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Font.PDFontTest.OUT_DIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "LiberationSans-Regular.ttf"));
    global::DripSharp.Runtime.JavaFile tempPdfFile
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Font.PDFontTest.OUT_DIR,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "testDeleteFont.pdf"));
    string text = "Test PDFBOX-4823"; {
      global::System.IO.Stream @is
        = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Font.PDFont),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "/org/apache/pdfbox/resources/ttf/LiberationSans-Regular.ttf"));
      global::System.Exception __dripsharpPrimary_373_26_0 = null!;
      try {
        global::DripSharp.Runtime.JavaCompat.Copy(@is,
          global::DripSharp.Runtime.JavaCompat.FileToPath(tempFontFile), new object());
      } catch (global::System.Exception __dripsharpCaught_373_26_0) {
        __dripsharpPrimary_373_26_0 = __dripsharpCaught_373_26_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_373_26_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__379_25
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_379_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
        doc__379_25.AddPage(page); {
          global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream cs
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc__379_25, page);
          global::System.Exception __dripsharpPrimary_383_38_0 = null!;
          try {
            global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font
              = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font>(typeof(global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font),
              "Load",
              new global::System.Type[] { typeof(global::DripSharp.PdfCarton.Pdmodel.PDDocument),
                typeof(global::System.IO.FileInfo) },
              new object[] { (global::DripSharp.PdfCarton.Pdmodel.PDDocument)doc__379_25,
                (global::DripSharp.Runtime.JavaFile)tempFontFile });
            cs.BeginText();
            cs.SetFont(font, (float)(50));
            cs.NewLineAtOffset((float)(50), (float)(700));
            cs.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", text));
            cs.EndText();
          } catch (global::System.Exception __dripsharpCaught_383_38_0) {
            __dripsharpPrimary_383_38_0 = __dripsharpCaught_383_38_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(cs, __dripsharpPrimary_383_38_0);
          }
        }
        global::DripSharp.Runtime.JavaFileBridge.Call(doc__379_25, "Save",
          new global::System.Type[] { typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.Runtime.JavaFile)tempPdfFile });
      } catch (global::System.Exception __dripsharpCaught_379_25_0) {
        __dripsharpPrimary_379_25_0 = __dripsharpCaught_379_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__379_25,
          __dripsharpPrimary_379_25_0);
      }
    }
    global::DripSharp.Runtime.JavaCompat.DeleteIfExists(global::DripSharp.Runtime.JavaCompat.FileToPath(tempFontFile));
    {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__397_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)tempPdfFile });
      global::System.Exception __dripsharpPrimary_397_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Text.PDFTextStripper stripper
          = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
        string extractedText = stripper.GetText(doc__397_25);
        global::DripSharp.Testing.JavaAssertions.Equal(text,
          global::DripSharp.Runtime.JavaCompat.StringTrim(extractedText), null);
      } catch (global::System.Exception __dripsharpCaught_397_25_0) {
        __dripsharpPrimary_397_25_0 = __dripsharpCaught_397_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__397_25,
          __dripsharpPrimary_397_25_0);
      }
    }
    global::DripSharp.Runtime.JavaCompat.DeleteIfExists(global::DripSharp.Runtime.JavaCompat.FileToPath(tempPdfFile));
  }

  internal virtual void testSoftHyphen() {
    string text = "- \u00AD";
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream(); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__415_25
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_415_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
        doc__415_25.AddPage(page);
        global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font1
          = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica);
        global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font2
          = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(doc__415_25,
          global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Font.PDFontTest),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "/org/apache/pdfbox/resources/ttf/LiberationSans-Regular.ttf")));
        global::DripSharp.Testing.JavaAssertions.Equal(font1.GetStringWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "-")), font1.GetStringWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "\u00AD")), null);
        global::DripSharp.Testing.JavaAssertions.Equal(font2.GetStringWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "-")), font2.GetStringWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "\u00AD")), null); {
          global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream cs
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc__415_25, page);
          global::System.Exception __dripsharpPrimary_426_38_0 = null!;
          try {
            cs.BeginText();
            cs.NewLineAtOffset((float)(100), (float)(500));
            cs.SetFont(font1, (float)(10));
            cs.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", text));
            cs.NewLineAtOffset((float)(0), (float)(100));
            cs.SetFont(font2, (float)(10));
            cs.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", text));
            cs.EndText();
          } catch (global::System.Exception __dripsharpCaught_426_38_0) {
            __dripsharpPrimary_426_38_0 = __dripsharpCaught_426_38_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(cs, __dripsharpPrimary_426_38_0);
          }
        }
        doc__415_25.Save(baos);
      } catch (global::System.Exception __dripsharpCaught_415_25_0) {
        __dripsharpPrimary_415_25_0 = __dripsharpCaught_415_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__415_25,
          __dripsharpPrimary_415_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__440_25
        = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
      global::System.Exception __dripsharpPrimary_440_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Text.PDFTextStripper stripper
          = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
        stripper.SetLineSeparator(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "\n"));
        string extractedText = stripper.GetText(doc__440_25);
        global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(text,
          "\n"), text), global::DripSharp.Runtime.JavaCompat.StringTrim(extractedText), null);
      } catch (global::System.Exception __dripsharpCaught_440_25_0) {
        __dripsharpPrimary_440_25_0 = __dripsharpCaught_440_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__440_25,
          __dripsharpPrimary_440_25_0);
      }
    }
  }

  internal virtual void testPDFBox5484() {
    global::DripSharp.Runtime.JavaFile fontFile
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/fonts"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-5484.ttf"));
    global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(fontFile));
    {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_459_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.Font.PDTrueTypeFont tr
          = global::DripSharp.PdfCarton.Pdmodel.Font.PDTrueTypeFont.Load(doc, ttf,
          global::DripSharp.PdfCarton.Pdmodel.Font.Encoding.WinAnsiEncoding.Instance);
        global::SkiaSharp.SKPath path1
          = tr.GetPath(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "oslash"));
        global::SkiaSharp.SKPath path2 = tr.GetPath(248);
        global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.PdfCartonFontCompat.PathIterator(path2,
          (global::SkiaSharp.SKMatrix)default!).IsDone(), null);
        global::DripSharp.Testing.JavaAssertions.True((new global::DripSharp.Runtime.JavaArea(path1)).Equals(new global::DripSharp.Runtime.JavaArea(path2)),
          null);
      } catch (global::System.Exception __dripsharpCaught_459_25_0) {
        __dripsharpPrimary_459_25_0 = __dripsharpCaught_459_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_459_25_0);
      }
    }
  }

  internal virtual void PDFBOX5920Type0() { {
      global::System.IO.Stream @is
        = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Font.PDFontTest),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "/org/apache/pdfbox/resources/ttf/LiberationSans-Regular.ttf"));
      global::System.Exception __dripsharpPrimary_477_26_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDDocument document
          = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
        global::System.Exception __dripsharpPrimary_479_28_0 = null!;
        try {
          global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font
            = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(document, @is, false);
          global::DripSharp.Testing.JavaAssertions.Equal(20064.0F,
            font.GetStringWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            "The quick brown fox jumps over the lazy dog.")), null);
          global::DripSharp.Testing.JavaAssertions.Equal(278.0F, font.GetSpaceWidth(), null);
        } catch (global::System.Exception __dripsharpCaught_479_28_0) {
          __dripsharpPrimary_479_28_0 = __dripsharpCaught_479_28_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(document, __dripsharpPrimary_479_28_0);
        }
      } catch (global::System.Exception __dripsharpCaught_477_26_0) {
        __dripsharpPrimary_477_26_0 = __dripsharpCaught_477_26_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_477_26_0);
      }
    }
  }

  internal virtual void PDFBOX5920TrueType() { {
      global::System.IO.Stream @is
        = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Font.PDFontTest),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "/org/apache/pdfbox/resources/ttf/LiberationSans-Regular.ttf"));
      global::System.Exception __dripsharpPrimary_496_26_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDDocument document
          = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
        global::System.Exception __dripsharpPrimary_498_28_0 = null!;
        try {
          global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font
            = global::DripSharp.PdfCarton.Pdmodel.Font.PDTrueTypeFont.Load(document, @is,
            global::DripSharp.PdfCarton.Pdmodel.Font.Encoding.WinAnsiEncoding.Instance);
          global::DripSharp.Testing.JavaAssertions.Equal(20064.0F,
            font.GetStringWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            "The quick brown fox jumps over the lazy dog.")), null);
          global::DripSharp.Testing.JavaAssertions.Equal(278.0F, font.GetSpaceWidth(), null);
        } catch (global::System.Exception __dripsharpCaught_498_28_0) {
          __dripsharpPrimary_498_28_0 = __dripsharpCaught_498_28_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(document, __dripsharpPrimary_498_28_0);
        }
      } catch (global::System.Exception __dripsharpCaught_496_26_0) {
        __dripsharpPrimary_496_26_0 = __dripsharpCaught_496_26_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_496_26_0);
      }
    }
  }

  internal virtual void testSymbol() {
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream(); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__511_25
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_511_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage(); {
          global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc__511_25, page);
          global::System.Exception __dripsharpPrimary_514_38_0 = null!;
          try {
            global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font font
              = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Symbol);
            contentStream.BeginText();
            contentStream.SetFont(font, (float)(10));
            contentStream.NewLineAtOffset((float)(10), (float)(700));
            contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "\u0391 \u2126"));
            contentStream.EndText();
          } catch (global::System.Exception __dripsharpCaught_514_38_0) {
            __dripsharpPrimary_514_38_0 = __dripsharpCaught_514_38_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(contentStream,
              __dripsharpPrimary_514_38_0);
          }
        }
        doc__511_25.AddPage(page);
        doc__511_25.Save(baos);
      } catch (global::System.Exception __dripsharpCaught_511_25_0) {
        __dripsharpPrimary_511_25_0 = __dripsharpCaught_511_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__511_25,
          __dripsharpPrimary_511_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__530_25
        = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
      global::System.Exception __dripsharpPrimary_530_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Text.PDFTextStripper stripper
          = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
        string text = stripper.GetText(doc__530_25);
        global::DripSharp.Testing.JavaAssertions.Equal("\u0391 \u2126",
          global::DripSharp.Runtime.JavaCompat.StringTrim(text), null);
      } catch (global::System.Exception __dripsharpCaught_530_25_0) {
        __dripsharpPrimary_530_25_0 = __dripsharpCaught_530_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__530_25,
          __dripsharpPrimary_530_25_0);
      }
    }
  }

  internal virtual void testPDFBox6172() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_542_25_0 = null!;
      try {
        global::System.IO.Stream @is
          = global::DripSharp.Runtime.JavaCompat.OpenFileInput(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "target/fonts/NotoSansSC-Regular.otf"));
        global::DripSharp.PdfCarton.Fonts.Ttf.OpenTypeFont otf
          = new global::DripSharp.PdfCarton.Fonts.Ttf.OTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(@is));
        global::System.Exception t
          = global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(()
          => global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(document, otf, false),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "should have thrown IllegalStateException"));
        global::DripSharp.Testing.JavaAssertions.Equal("CID and GID not identical: CID 628 != GID 372, use a ttf font instead",
          global::DripSharp.Runtime.JavaCompat.ExceptionMessage(t), null);
      } catch (global::System.Exception __dripsharpCaught_542_25_0) {
        __dripsharpPrimary_542_25_0 = __dripsharpCaught_542_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document, __dripsharpPrimary_542_25_0);
      }
    }
  }

  [Xunit.Fact]
  public void __Upstream_2538372611_4870cab1b981e512() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.PDFBOX5920TrueType();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0838060539_385c3e29efe99fbc() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.PDFBOX5920Type0();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3197651660_f5c9a6be4ff958c9() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testDeleteFont();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2394908653_6d59a4d3aef62d27() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testFullEmbeddingTTC();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0778888844_231ccd1b1b51d58b() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBOX4115();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0778921736_7564e5ae08b04642() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBOX5486();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724550418_e9b09033182f2b1f() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBox3747();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724551316_211d8b93ab7c3850() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBox3826();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724607238_586ad8f7e489b233() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBox5484();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724634113_5575f076c86a34d1() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBox6172();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0194183790_12bea62ec14140f8() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBox988();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1488775503_6514523b6c26641c() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFox4318();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1488802504_b4ed59fc29146e66() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFox5048();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0970998830_551120fd5747455f() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testSoftHyphen();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3879694538_6030219f62df0a81() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testSymbol();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll;

  private static bool __RunUpstreamBeforeAll() {
    setUp();
    return true;
  }

  static PDFontTest() {
    OUT_DIR
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/test-output"));
    __UpstreamBeforeAll = __RunUpstreamBeforeAll();
  }
}
