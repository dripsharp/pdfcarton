// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf;

public class WGL4NamesTest {
internal virtual void testAllNames() {
string[] allNames = global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetAllNames();
global::DripSharp.Testing.JavaAssertions.NotNull(allNames, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.NumberOfMacGlyphs, allNames.Length, null);
}

internal virtual void testGetGlyphName() {
global::DripSharp.Testing.JavaAssertions.Equal(".notdef", global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetGlyphName(0), null);
global::DripSharp.Testing.JavaAssertions.Equal("equal", global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetGlyphName(32), null);
global::DripSharp.Testing.JavaAssertions.Equal("h", global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetGlyphName(75), null);
global::DripSharp.Testing.JavaAssertions.Equal("Aacute", global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetGlyphName(201), null);
global::DripSharp.Testing.JavaAssertions.Equal("Ocircumflex", global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetGlyphName(209), null);
global::DripSharp.Testing.JavaAssertions.Equal("ccaron", global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetGlyphName(256), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetGlyphName((global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.NumberOfMacGlyphs + 1)), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetGlyphName(-1), null);
}

internal virtual void testGlyphIndices() {
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetGlyphIndex(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", ".notdef")), null);
global::DripSharp.Testing.JavaAssertions.Equal(32, global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetGlyphIndex(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "equal")), null);
global::DripSharp.Testing.JavaAssertions.Equal(75, global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetGlyphIndex(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "h")), null);
global::DripSharp.Testing.JavaAssertions.Equal(201, global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetGlyphIndex(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Aacute")), null);
global::DripSharp.Testing.JavaAssertions.Equal(209, global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetGlyphIndex(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Ocircumflex")), null);
global::DripSharp.Testing.JavaAssertions.Equal(256, global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetGlyphIndex(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "ccaron")), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Fonts.Ttf.WGL4Names.GetGlyphIndex(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "INVALID")), null);
}

[Xunit.Fact]
public void __Upstream_0348864729_91422c65184d9538()
{
        try
        {
            this.testAllNames();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4248410323_81b9d0da63b8a10e()
{
        try
        {
            this.testGetGlyphName();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0093972109_afbd12ee8cb3a69e()
{
        try
        {
            this.testGlyphIndices();
        }
        finally
        {
        }
}
}
