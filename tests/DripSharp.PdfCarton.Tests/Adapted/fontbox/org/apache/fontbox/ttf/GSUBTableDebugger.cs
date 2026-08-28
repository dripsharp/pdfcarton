// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf;

public class GSUBTableDebugger {
  private const string LOHIT_BENGALI_FONT_FILE = "/ttf/Lohit-Bengali.ttf";

  internal virtual void printLohitBengaliTTF() {
    using (global::System.IO.Stream is1
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Fonts.Ttf.GSUBTableDebugger),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      global::DripSharp.PdfCarton.Fonts.Ttf.GSUBTableDebugger.LOHIT_BENGALI_FONT_FILE))) using (global::System.IO.Stream is2
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Fonts.Ttf.GSUBTableDebugger),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      global::DripSharp.PdfCarton.Fonts.Ttf.GSUBTableDebugger.LOHIT_BENGALI_FONT_FILE))) {
      global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessReadBuffer
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(is1);
      global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream randomAccessReadBufferDataStream
        = new global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream(randomAccessReadBuffer);
      randomAccessReadBufferDataStream.Seek((long)(global::DripSharp.PdfCarton.Fonts.Ttf.GlyphSubstitutionTableTest.DATA_POSITION_FOR_GSUB_TABLE));
      global::DripSharp.PdfCarton.Fonts.Ttf.GlyphSubstitutionTable glyphSubstitutionTable
        = new global::DripSharp.PdfCarton.Fonts.Ttf.GlyphSubstitutionTable();
      glyphSubstitutionTable.read((global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont)default!,
        randomAccessReadBufferDataStream);
      global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont trueTypeFont
        = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(is2));
      global::DripSharp.PdfCarton.Fonts.Ttf.Model.GsubData gsubData
        = glyphSubstitutionTable.GetGsubData();
      new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GSUBTablePrintUtil().PrintCharacterToGlyph(gsubData,
        trueTypeFont.GetUnicodeCmapLookup());
    }
  }

  [Xunit.Fact]
  public void __Upstream_0496664711_d1a4dc644f408775() {
    try {
      this.printLohitBengaliTTF();
    } finally {
    }
  }
}
