// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf;

public class TTFSubsetterTest {
  internal virtual void testEmptySubset() {
    global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont x
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "src/test/resources/ttf/LiberationSans-Regular.ttf")));
    global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter ttfSubsetter
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter(x);
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    ttfSubsetter.WriteToStream(baos);
    using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont subset
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser(true).Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos)))) {
      global::DripSharp.Testing.JavaAssertions.Equal(1, subset.GetNumberOfGlyphs(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", ".notdef")),
        null);
      global::DripSharp.Testing.JavaAssertions.NotNull(subset.GetGlyph().GetGlyph(0), null);
    }
  }

  internal virtual void testEmptySubset2() {
    global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont x
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "src/test/resources/ttf/LiberationSans-Regular.ttf")));
    global::System.Collections.Generic.IList<string> tables
      = new global::System.Collections.Generic.List<string>();
    global::DripSharp.Runtime.JavaCompat.Add(tables, "head");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "hhea");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "loca");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "maxp");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "cvt ");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "prep");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "glyf");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "hmtx");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "fpgm");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "gasp");
    global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter ttfSubsetter
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter(x, tables);
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    ttfSubsetter.WriteToStream(baos);
    using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont subset
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser(true).Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos)))) {
      global::DripSharp.Testing.JavaAssertions.Equal(1, subset.GetNumberOfGlyphs(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", ".notdef")),
        null);
      global::DripSharp.Testing.JavaAssertions.NotNull(subset.GetGlyph().GetGlyph(0), null);
    }
  }

  internal virtual void testNonEmptySubset() {
    global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont full
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "src/test/resources/ttf/LiberationSans-Regular.ttf")));
    global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter ttfSubsetter
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter(full);
    ttfSubsetter.Add((int)('a'));
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    ttfSubsetter.WriteToStream(baos);
    using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont subset
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser(true).Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos)))) {
      global::DripSharp.Testing.JavaAssertions.Equal(2, subset.GetNumberOfGlyphs(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", ".notdef")),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "a")), null);
      global::DripSharp.Testing.JavaAssertions.NotNull(subset.GetGlyph().GetGlyph(0), null);
      global::DripSharp.Testing.JavaAssertions.NotNull(subset.GetGlyph().GetGlyph(1), null);
      global::DripSharp.Testing.JavaAssertions.Null(subset.GetGlyph().GetGlyph(2), null);
      global::DripSharp.Testing.JavaAssertions.Equal(full.GetAdvanceWidth(full.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "a"))),
        subset.GetAdvanceWidth(subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "a"))), null);
      global::DripSharp.Testing.JavaAssertions.Equal(full.GetHorizontalMetrics().GetLeftSideBearing(full.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "a"))),
        subset.GetHorizontalMetrics().GetLeftSideBearing(subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "a"))), null);
    }
  }

  internal virtual void testPDFBox3319() {
    global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "Searching for SimHei font..."));
    global::DripSharp.PdfCarton.Fonts.Util.Autodetect.FontFileFinder fontFileFinder
      = new global::DripSharp.PdfCarton.Fonts.Util.Autodetect.FontFileFinder();
    global::System.Collections.Generic.IList<global::System.Uri> files = fontFileFinder.Find();
    global::System.IO.FileInfo simhei = default!;
    foreach (global::System.Uri uri in files) {
      string path = global::DripSharp.Runtime.JavaCompat.UriPath(uri)!;
      if (((path != default!)
        && global::DripSharp.Runtime.JavaCompat.StringEndsWith(path.ToLowerInvariant(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "simhei.ttf")))) {
        simhei = global::DripSharp.Runtime.JavaCompat.NewFileInfo(uri);
        break;
      }
    }
    global::DripSharp.Testing.JavaAssertions.AssumeTrue((simhei! != default!),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "SimHei font not available on this machine, test skipped"));
    global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "SimHei font found!"));
    global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont full
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(simhei!));
    global::System.Collections.Generic.IList<string> tables
      = new global::System.Collections.Generic.List<string>();
    global::DripSharp.Runtime.JavaCompat.Add(tables, "head");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "hhea");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "loca");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "maxp");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "cvt ");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "prep");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "glyf");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "hmtx");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "fpgm");
    global::DripSharp.Runtime.JavaCompat.Add(tables, "gasp");
    global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter ttfSubsetter
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter(full, tables);
    string chinese = "\u4E2D\u56FD\u4F60\u597D!";
    for (int offset = 0; (offset < chinese.Length); ) {
      int codePoint = global::DripSharp.Runtime.JavaCompat.CodePointAt(chinese, offset);
      ttfSubsetter.Add(codePoint);
      offset += global::DripSharp.Runtime.JavaCompat.CharacterCharCount(codePoint);
    }
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    ttfSubsetter.WriteToStream(baos);
    using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont subset
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser(true).Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos)))) {
      global::DripSharp.Testing.JavaAssertions.Equal(6, subset.GetNumberOfGlyphs(), null);
      foreach (global::DripSharp.Runtime.JavaMapEntry<int,
        int> entry in global::DripSharp.Runtime.JavaCompat.MapEntrySet(ttfSubsetter.GetGIDMap())) {
        int newGID = entry.Key;
        int oldGID = entry.Value;
        global::DripSharp.Testing.JavaAssertions.Equal(full.GetAdvanceWidth((int)(oldGID)),
          subset.GetAdvanceWidth((int)(newGID)), null);
        global::DripSharp.Testing.JavaAssertions.Equal(full.GetHorizontalMetrics().GetLeftSideBearing((int)(oldGID)),
          subset.GetHorizontalMetrics().GetLeftSideBearing((int)(newGID)), null);
      }
    }
  }

  internal virtual void testPDFBox3379() {
    global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont full
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "target/fonts/DejaVuSansMono.ttf")));
    global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter ttfSubsetter
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter(full);
    ttfSubsetter.Add((int)('A'));
    ttfSubsetter.Add((int)(' '));
    ttfSubsetter.Add((int)('B'));
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    ttfSubsetter.WriteToStream(baos);
    using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont subset
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos)))) {
      global::DripSharp.Testing.JavaAssertions.Equal(4, subset.GetNumberOfGlyphs(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", ".notdef")),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "space")),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(2,
        subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "A")), null);
      global::DripSharp.Testing.JavaAssertions.Equal(3,
        subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "B")), null);
      string[] names = new string[] { "A", "B", "space" };
      foreach (string name in names) {
        global::DripSharp.Testing.JavaAssertions.Equal(full.GetAdvanceWidth(full.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
          name))),
          subset.GetAdvanceWidth(subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
          name))), null);
        global::DripSharp.Testing.JavaAssertions.Equal(full.GetHorizontalMetrics().GetLeftSideBearing(full.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
          name))),
          subset.GetHorizontalMetrics().GetLeftSideBearing(subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
          name))), null);
      }
    }
  }

  internal virtual void testPDFBox3757() {
    global::System.IO.FileInfo testFile
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "src/test/resources/ttf/LiberationSans-Regular.ttf"));
    global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(testFile));
    global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter ttfSubsetter
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter(ttf);
    ttfSubsetter.Add((int)('\u00D6'));
    ttfSubsetter.Add((int)('\u200A'));
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    ttfSubsetter.WriteToStream(baos);
    using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont subset
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser(true).Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos)))) {
      global::DripSharp.Testing.JavaAssertions.Equal(5, subset.GetNumberOfGlyphs(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", ".notdef")),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "O")), null);
      global::DripSharp.Testing.JavaAssertions.Equal(2,
        subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "Odieresis")), null);
      global::DripSharp.Testing.JavaAssertions.Equal(3,
        subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "uni200A")),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(4,
        subset.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "dieresis.uc")), null);
      global::DripSharp.PdfCarton.Fonts.Ttf.PostScriptTable pst = subset.GetPostScript();
      global::DripSharp.Testing.JavaAssertions.Equal(".notdef", pst.GetName(0), null);
      global::DripSharp.Testing.JavaAssertions.Equal("O", pst.GetName(1), null);
      global::DripSharp.Testing.JavaAssertions.Equal("Odieresis", pst.GetName(2), null);
      global::DripSharp.Testing.JavaAssertions.Equal("uni200A", pst.GetName(3), null);
      global::DripSharp.Testing.JavaAssertions.Equal("dieresis.uc", pst.GetName(4), null);
      global::DripSharp.Testing.JavaAssertions.True(subset.GetPath(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "uni200A")).Bounds.IsEmpty, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "Hair space path should be empty"));
      global::DripSharp.Testing.JavaAssertions.False(subset.GetPath(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "dieresis.uc")).Bounds.IsEmpty,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "UC dieresis path should not be empty"));
    }
  }

  internal virtual void testPDFBox5728() {
    using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "target/fonts/NotoMono-Regular.ttf")))) {
      global::DripSharp.PdfCarton.Fonts.Ttf.PostScriptTable postScript = ttf.GetPostScript();
      global::DripSharp.Testing.JavaAssertions.Equal(3.0D, (double)(postScript.GetFormatType()),
        null);
      global::DripSharp.Testing.JavaAssertions.Null(postScript.GetGlyphNames(), null);
      global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter subsetter
        = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter(ttf);
      subsetter.Add((int)('a'));
      global::DripSharp.Runtime.JavaByteArrayOutputStream output
        = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
      subsetter.WriteToStream(output);
    }
  }

  internal virtual void testPDFBox5230() {
    global::System.IO.FileInfo testFile
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "src/test/resources/ttf/LiberationSans-Regular.ttf"));
    global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(testFile));
    global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter ttfSubsetter
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFSubsetter(ttf);
    ttfSubsetter.Add((int)('A'));
    ttfSubsetter.Add((int)('B'));
    ttfSubsetter.Add((int)('\u200C'));
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    ttfSubsetter.WriteToStream(baos);
    using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont subset__318_27
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser(true).Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos)))) {
      global::DripSharp.Testing.JavaAssertions.Equal(4, subset__318_27.GetNumberOfGlyphs(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        subset__318_27.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        ".notdef")), null);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        subset__318_27.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "A")), null);
      global::DripSharp.Testing.JavaAssertions.Equal(2,
        subset__318_27.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "B")), null);
      global::DripSharp.Testing.JavaAssertions.Equal(3,
        subset__318_27.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "uni200C")), null);
      global::DripSharp.PdfCarton.Fonts.Ttf.PostScriptTable pst__327_29
        = subset__318_27.GetPostScript();
      global::DripSharp.Testing.JavaAssertions.Equal(".notdef", pst__327_29.GetName(0), null);
      global::DripSharp.Testing.JavaAssertions.Equal("A", pst__327_29.GetName(1), null);
      global::DripSharp.Testing.JavaAssertions.Equal("B", pst__327_29.GetName(2), null);
      global::DripSharp.Testing.JavaAssertions.Equal("uni200C", pst__327_29.GetName(3), null);
      global::DripSharp.Testing.JavaAssertions.False(subset__318_27.GetPath(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "A")).Bounds.IsEmpty, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "A path should not be empty"));
      global::DripSharp.Testing.JavaAssertions.False(subset__318_27.GetPath(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "B")).Bounds.IsEmpty, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "B path should not be empty"));
      global::DripSharp.Testing.JavaAssertions.False(subset__318_27.GetPath(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "uni200C")).Bounds.IsEmpty, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "ZWNJ path should not be empty"));
      global::DripSharp.Testing.JavaAssertions.NotEqual((float)(0),
        subset__318_27.GetWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "A")),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "A width should not be zero."));
      global::DripSharp.Testing.JavaAssertions.NotEqual((float)(0),
        subset__318_27.GetWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "B")),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "B width should not be zero."));
      global::DripSharp.Testing.JavaAssertions.Equal((float)(0),
        subset__318_27.GetWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "uni200C")), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "ZWNJ width should be zero"));
    }
    ttfSubsetter.ForceInvisible((int)('B'));
    ttfSubsetter.ForceInvisible((int)('\u200C'));
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos2
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    ttfSubsetter.WriteToStream(baos2);
    using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont subset__347_27
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser(true).Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos2)))) {
      global::DripSharp.Testing.JavaAssertions.Equal(4, subset__347_27.GetNumberOfGlyphs(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        subset__347_27.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        ".notdef")), null);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        subset__347_27.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "A")), null);
      global::DripSharp.Testing.JavaAssertions.Equal(2,
        subset__347_27.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "B")), null);
      global::DripSharp.Testing.JavaAssertions.Equal(3,
        subset__347_27.NameToGID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "uni200C")), null);
      global::DripSharp.PdfCarton.Fonts.Ttf.PostScriptTable pst__356_29
        = subset__347_27.GetPostScript();
      global::DripSharp.Testing.JavaAssertions.Equal(".notdef", pst__356_29.GetName(0), null);
      global::DripSharp.Testing.JavaAssertions.Equal("A", pst__356_29.GetName(1), null);
      global::DripSharp.Testing.JavaAssertions.Equal("B", pst__356_29.GetName(2), null);
      global::DripSharp.Testing.JavaAssertions.Equal("uni200C", pst__356_29.GetName(3), null);
      global::DripSharp.Testing.JavaAssertions.False(subset__347_27.GetPath(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "A")).Bounds.IsEmpty, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "A path should not be empty"));
      global::DripSharp.Testing.JavaAssertions.True(subset__347_27.GetPath(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "B")).Bounds.IsEmpty, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "B path should be empty"));
      global::DripSharp.Testing.JavaAssertions.True(subset__347_27.GetPath(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "uni200C")).Bounds.IsEmpty, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "ZWNJ path should be empty"));
      global::DripSharp.Testing.JavaAssertions.NotEqual((float)(0),
        subset__347_27.GetWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "A")),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "A width should not be zero."));
      global::DripSharp.Testing.JavaAssertions.Equal((float)(0),
        subset__347_27.GetWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "B")),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "B width should be zero."));
      global::DripSharp.Testing.JavaAssertions.Equal((float)(0),
        subset__347_27.GetWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "uni200C")), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        "ZWNJ width should be zero"));
    }
  }

  internal virtual void testPDFBox6015() {
    using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "target/fonts/Keyboard.ttf")))) {
      global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup unicodeCmapLookup
        = ttf.GetUnicodeCmapLookup();
      global::DripSharp.Testing.JavaAssertions.Equal(185, unicodeCmapLookup.GetGlyphId((int)('a')),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(210, unicodeCmapLookup.GetGlyphId((int)('z')),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(159, unicodeCmapLookup.GetGlyphId((int)('A')),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(184, unicodeCmapLookup.GetGlyphId((int)('Z')),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(49, unicodeCmapLookup.GetGlyphId((int)('0')),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(58, unicodeCmapLookup.GetGlyphId((int)('9')),
        null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_2671578589_0d3e2b5c85e718b4() {
    try {
      this.testEmptySubset();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1214557685_c3dab7de554d9504() {
    try {
      this.testEmptySubset2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2780802548_aaf6139fa8460918() {
    try {
      this.testNonEmptySubset();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724546483_d2d6a6cf0f3e874b() {
    try {
      this.testPDFBox3319();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724546669_271cd26fce7b7e14() {
    try {
      this.testPDFBox3379();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724550449_fd0d6ec97d4eaa3b() {
    try {
      this.testPDFBox3757();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724605157_19b7acb6bc97e8cf() {
    try {
      this.testPDFBox5230();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724609939_935205c88f2ea8d8() {
    try {
      this.testPDFBox5728();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724632969_71d28b6a84950693() {
    try {
      this.testPDFBox6015();
    } finally {
    }
  }
}
