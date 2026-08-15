// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf;

public class TestCMapSubtable {
internal virtual void testPDFBox5328() {
global::System.Collections.Generic.IList<int> expectedCharCodes = global::DripSharp.Runtime.JavaCompat.AsList<int>(19981, 63847);
int gid = 8712;
global::System.IO.FileInfo fontFile = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "target/fonts"), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "NotoSansSC-Regular.otf"));
global::DripSharp.PdfCarton.Fonts.Ttf.OTFParser otfParser = new global::DripSharp.PdfCarton.Fonts.Ttf.OTFParser(false);
global::DripSharp.PdfCarton.Fonts.Ttf.OpenTypeFont otf = otfParser.Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(fontFile));
global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup unicodeCmapLookup = otf.GetUnicodeCmapLookup();
global::System.Collections.Generic.IList<int> charCodes = unicodeCmapLookup.GetCharCodes(gid);
global::DripSharp.Testing.JavaAssertions.Equal(expectedCharCodes, charCodes, null);
global::DripSharp.PdfCarton.Fonts.Ttf.CmapTable cmapTable = otf.GetCmap();
global::DripSharp.PdfCarton.Fonts.Ttf.CmapSubtable unicodeFullCmapTable = cmapTable.GetSubtable(global::DripSharp.PdfCarton.Fonts.Ttf.CmapTable.PlatformUnicode, global::DripSharp.PdfCarton.Fonts.Ttf.CmapTable.EncodingUnicode20Full);
global::DripSharp.PdfCarton.Fonts.Ttf.CmapSubtable unicodeBmpCmapTable = cmapTable.GetSubtable(global::DripSharp.PdfCarton.Fonts.Ttf.CmapTable.PlatformUnicode, global::DripSharp.PdfCarton.Fonts.Ttf.CmapTable.EncodingUnicode20Bmp);
global::System.Collections.Generic.IList<int> unicodeBmpCharCodes = unicodeBmpCmapTable.GetCharCodes(gid);
global::System.Collections.Generic.IList<int> unicodeFullCharCodes = unicodeFullCmapTable.GetCharCodes(gid);
global::DripSharp.Testing.JavaAssertions.Equal(expectedCharCodes, unicodeBmpCharCodes, null);
global::DripSharp.Testing.JavaAssertions.Equal(expectedCharCodes, unicodeFullCharCodes, null);
}

internal virtual void testVerticalSubstitution() {
global::System.IO.FileInfo ipaFont = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "target/fonts/ipag00303"), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "ipag.ttf"));
global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(ipaFont));
global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup unicodeCmapLookup1 = ttf.GetUnicodeCmapLookup();
int hgid1 = unicodeCmapLookup1.GetGlyphId((int)('\u300C'));
int hgid2 = unicodeCmapLookup1.GetGlyphId((int)('\u300D'));
ttf.EnableVerticalSubstitutions();
global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup unicodeCmapLookup2 = ttf.GetUnicodeCmapLookup();
int vgid1 = unicodeCmapLookup2.GetGlyphId((int)('\u300C'));
int vgid2 = unicodeCmapLookup2.GetGlyphId((int)('\u300D'));
global::DripSharp.Testing.JavaAssertions.Equal(441, hgid1, null);
global::DripSharp.Testing.JavaAssertions.Equal(442, hgid2, null);
global::DripSharp.Testing.JavaAssertions.Equal(7392, vgid1, null);
global::DripSharp.Testing.JavaAssertions.Equal(7393, vgid2, null);
}

[Xunit.Fact]
public void __Upstream_1724606095_17e858cb733c41b8()
{
        try
        {
            this.testPDFBox5328();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3627399493_4e37dff01c469cbe()
{
        try
        {
            this.testVerticalSubstitution();
        }
        finally
        {
        }
}
}
