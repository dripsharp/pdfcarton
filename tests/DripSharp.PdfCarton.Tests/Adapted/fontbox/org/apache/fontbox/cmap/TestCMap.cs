// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Cmap;

public class TestCMap {
  internal virtual void testLookup() {
    sbyte[] bs = new sbyte[] { unchecked((sbyte)(200)) };
    global::DripSharp.PdfCarton.Fonts.Cmap.CMap cMap
      = new global::DripSharp.PdfCarton.Fonts.Cmap.CMap();
    cMap.addCharMapping(bs, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "a"));
    global::DripSharp.Testing.JavaAssertions.Equal("a", cMap.ToUnicode(bs), null);
  }

  internal virtual void testPDFBox3997() {
    using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "target/fonts/NotoEmoji-Regular.ttf")))) {
      global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup cmap = ttf.GetUnicodeCmapLookup(false);
      global::DripSharp.Testing.JavaAssertions.Equal(886, cmap.GetGlyphId(128641), null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_3670123692_e14a4774b2d417c9() {
    try {
      this.testLookup();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724552495_2e4a79ed7f23a252() {
    try {
      this.testPDFBox3997();
    } finally {
    }
  }
}
