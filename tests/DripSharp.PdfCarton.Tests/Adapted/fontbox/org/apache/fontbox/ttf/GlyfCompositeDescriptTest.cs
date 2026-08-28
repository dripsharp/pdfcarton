// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf;

public class GlyfCompositeDescriptTest {
  internal virtual void getComponentsView() {
    global::DripSharp.PdfCarton.Fonts.Ttf.OTFParser otfParser
      = new global::DripSharp.PdfCarton.Fonts.Ttf.OTFParser();
    string fontPath = "src/test/resources/ttf/LiberationSans-Regular.ttf";
    global::DripSharp.PdfCarton.Fonts.Ttf.OpenTypeFont font;
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead fontFile
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      fontPath))) {
      font = otfParser.Parse(fontFile);
    }
    global::DripSharp.PdfCarton.Fonts.Ttf.GlyphTable glyphTable = font.GetGlyph();
    global::DripSharp.PdfCarton.Fonts.Ttf.GlyphData aacuteGlyph = glyphTable.GetGlyph(131);
    global::DripSharp.PdfCarton.Fonts.Ttf.GlyphDescription glyphDescription
      = aacuteGlyph.GetDescription();
    global::DripSharp.Testing.JavaAssertions.True(glyphDescription.IsComposite(), null);
    global::DripSharp.PdfCarton.Fonts.Ttf.GlyfCompositeDescript compositeGlyphDescription
      = (global::DripSharp.PdfCarton.Fonts.Ttf.GlyfCompositeDescript)(glyphDescription!);
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Ttf.GlyfCompositeComp> componentsView
      = compositeGlyphDescription.GetComponents();
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(componentsView), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => global::DripSharp.Runtime.JavaCompat.ListRemove(componentsView, 0), null);
  }

  [Xunit.Fact(DisplayName
    = "getComponents() method returns read-only list of all glyph components")]
  public void __Upstream_3243344849_82d315ac85c9595f() {
    try {
      this.getComponentsView();
    } finally {
    }
  }
}
