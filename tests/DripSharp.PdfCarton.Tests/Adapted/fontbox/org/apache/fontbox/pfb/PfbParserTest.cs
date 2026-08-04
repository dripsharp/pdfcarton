// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Pfb;

public class PfbParserTest {
internal virtual void testPfb() {
global::DripSharp.PdfCarton.Fonts.Type1.Type1Font font;
using (global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "target/fonts/OpenSans-Regular.pfb"))) {
font = global::DripSharp.PdfCarton.Fonts.Type1.Type1Font.CreateWithPFB(@is);
}
global::DripSharp.Testing.JavaAssertions.Equal("1.10", font.GetVersion(), null);
global::DripSharp.Testing.JavaAssertions.Equal("OpenSans-Regular", font.GetFontName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Open Sans Regular", font.GetFullName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Open Sans", font.GetFamilyName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Digitized data copyright (c) 2010-2011, Google Corporation.", font.GetNotice(), null);
global::DripSharp.Testing.JavaAssertions.False(font.IsFixedPitch(), null);
global::DripSharp.Testing.JavaAssertions.False(font.IsForceBold(), null);
global::DripSharp.Testing.JavaAssertions.Equal((float)(0), font.GetItalicAngle(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Book", font.GetWeight(), null);
global::DripSharp.Testing.JavaAssertions.InstanceOf<global::DripSharp.PdfCarton.Fonts.Encoding.BuiltInEncoding>(font.GetEncoding(), null);
global::DripSharp.Testing.JavaAssertions.Equal(4498, font.GetASCIISegment().Length, null);
global::DripSharp.Testing.JavaAssertions.Equal(95911, font.GetBinarySegment().Length, null);
global::DripSharp.Testing.JavaAssertions.Equal(938, global::DripSharp.Runtime.JavaCompat.MapCount(font.GetCharStringsDict()), null);
foreach (string s in global::DripSharp.Runtime.JavaCompat.MapKeySet(font.GetCharStringsDict())) {
global::DripSharp.Testing.JavaAssertions.NotNull(font.GetPath(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", s)), null);
global::DripSharp.Testing.JavaAssertions.True(font.HasGlyph(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", s)), null);
}
}

internal virtual void testPfbPDFBox5713() {
global::DripSharp.PdfCarton.Fonts.Type1.Type1Font font;
using (global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "target/fonts/DejaVuSerifCondensed.pfb"))) {
font = global::DripSharp.PdfCarton.Fonts.Type1.Type1Font.CreateWithPFB(@is);
}
global::DripSharp.Testing.JavaAssertions.Equal("Version 2.33", font.GetVersion(), null);
global::DripSharp.Testing.JavaAssertions.Equal("DejaVuSerifCondensed", font.GetFontName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("DejaVu Serif Condensed", font.GetFullName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("DejaVu Serif Condensed", font.GetFamilyName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Copyright [c] 2003 by Bitstream, Inc. All Rights Reserved.", font.GetNotice(), null);
global::DripSharp.Testing.JavaAssertions.False(font.IsFixedPitch(), null);
global::DripSharp.Testing.JavaAssertions.False(font.IsForceBold(), null);
global::DripSharp.Testing.JavaAssertions.Equal((float)(0), font.GetItalicAngle(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Book", font.GetWeight(), null);
global::DripSharp.Testing.JavaAssertions.InstanceOf<global::DripSharp.PdfCarton.Fonts.Encoding.BuiltInEncoding>(font.GetEncoding(), null);
global::DripSharp.Testing.JavaAssertions.Equal(5959, font.GetASCIISegment().Length, null);
global::DripSharp.Testing.JavaAssertions.Equal(1056090, font.GetBinarySegment().Length, null);
global::DripSharp.Testing.JavaAssertions.Equal(3399, global::DripSharp.Runtime.JavaCompat.MapCount(font.GetCharStringsDict()), null);
}

internal virtual void testEmpty() {
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => global::DripSharp.PdfCarton.Fonts.Type1.Type1Font.CreateWithPFB(new sbyte[0]), null);
}

internal virtual void testNegativeRecordSize() {
sbyte[] crashInput = new sbyte[] { unchecked((sbyte)(128)), unchecked((sbyte)(1)), unchecked((sbyte)(1)), unchecked((sbyte)(0)), unchecked((sbyte)(0)), unchecked((sbyte)(255)), unchecked((sbyte)(255)), unchecked((sbyte)(255)), unchecked((sbyte)(255)), unchecked((sbyte)(255)), unchecked((sbyte)(255)), unchecked((sbyte)(255)), unchecked((sbyte)(39)), unchecked((sbyte)(5)), unchecked((sbyte)(248)), unchecked((sbyte)(255)), unchecked((sbyte)(210)), unchecked((sbyte)(64)) };
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => new global::DripSharp.PdfCarton.Fonts.Pfb.PfbParser(crashInput), null);
}

[Xunit.Fact]
public void __Upstream_0943152091_3f578c7f862f2c60()
{
        try
        {
            this.testEmpty();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1243404857_2dda0afbc33b6741()
{
        try
        {
            this.testNegativeRecordSize();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0725013306_d2be8d82c59e8ac4()
{
        try
        {
            this.testPfb();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3808940567_2f1f03db27154302()
{
        try
        {
            this.testPfbPDFBox5713();
        }
        finally
        {
        }
}
}
