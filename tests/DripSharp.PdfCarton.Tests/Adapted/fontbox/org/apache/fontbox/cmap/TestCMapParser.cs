// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Cmap;

public class TestCMapParser {
internal virtual void testLookup() {
string resourceDir = "src/test/resources/cmap";
global::System.IO.FileInfo inDir = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", resourceDir));
global::DripSharp.PdfCarton.Fonts.Cmap.CMap cMap = new global::DripSharp.PdfCarton.Fonts.Cmap.CMapParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(new global::System.IO.FileInfo(global::System.IO.Path.Combine(inDir.FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "CMapTest")))));
sbyte[] bytes1 = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)) };
global::DripSharp.Testing.JavaAssertions.Equal("A", cMap.ToUnicode(bytes1), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "bytes 00 01 from bfrange <0001> <0005> <0041>"));
sbyte[] bytes2 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(0)) };
string str2 = "0";
global::DripSharp.Testing.JavaAssertions.Equal(str2, cMap.ToUnicode(bytes2), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "bytes 01 00 from bfrange <0100> <0109> <0030>"));
sbyte[] bytes3 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(32)) };
global::DripSharp.Testing.JavaAssertions.Equal("P", cMap.ToUnicode(bytes3), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "bytes 01 00 from bfrange <0100> <0109> <0030>"));
sbyte[] bytes4 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(33)) };
global::DripSharp.Testing.JavaAssertions.Equal("R", cMap.ToUnicode(bytes4), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "bytes 01 00 from bfrange <0100> <0109> <0030>"));
sbyte[] bytes5 = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(10)) };
string str5 = "*";
global::DripSharp.Testing.JavaAssertions.Equal(str5, cMap.ToUnicode(bytes5), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "bytes 00 0A from bfchar <000A> <002A>"));
sbyte[] bytes6 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(10)) };
string str6 = "+";
global::DripSharp.Testing.JavaAssertions.Equal(str6, cMap.ToUnicode(bytes6), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "bytes 01 0A from bfchar <010A> <002B>"));
sbyte[] cid1 = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(65)) };
global::DripSharp.Testing.JavaAssertions.Equal(65, cMap.ToCID(cid1), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "CID 65 from cidrange <0000> <00ff> 0 "));
sbyte[] cid2 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(24)) };
int strCID2 = 280;
global::DripSharp.Testing.JavaAssertions.Equal(strCID2, cMap.ToCID(cid2), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "CID 280 from cidrange <0100> <01ff> 256"));
sbyte[] cid3 = new sbyte[] { unchecked((sbyte)(2)), unchecked((sbyte)(8)) };
int strCID3 = 520;
global::DripSharp.Testing.JavaAssertions.Equal(strCID3, cMap.ToCID(cid3), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "CID 520 from cidchar <0208> 520"));
sbyte[] cid4 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(44)) };
int strCID4 = 300;
global::DripSharp.Testing.JavaAssertions.Equal(strCID4, cMap.ToCID(cid4), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "CID 300 from cidrange <0300> <0300> 300"));
}

internal virtual void testIdentity() {
global::DripSharp.PdfCarton.Fonts.Cmap.CMap cMap = new global::DripSharp.PdfCarton.Fonts.Cmap.CMapParser().ParsePredefined(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Identity-H"));
global::DripSharp.Testing.JavaAssertions.Equal(65, cMap.ToCID(new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(65)) }), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Indentity-H CID 65"));
global::DripSharp.Testing.JavaAssertions.Equal(12345, cMap.ToCID(new sbyte[] { unchecked((sbyte)(48)), unchecked((sbyte)(57)) }), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Indentity-H CID 12345"));
global::DripSharp.Testing.JavaAssertions.Equal(65535, cMap.ToCID(new sbyte[] { unchecked((sbyte)(255)), unchecked((sbyte)(255)) }), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Indentity-H CID 0xFFFF"));
}

internal virtual void testUniJIS_UTF16_H() {
global::DripSharp.PdfCarton.Fonts.Cmap.CMap cMap = new global::DripSharp.PdfCarton.Fonts.Cmap.CMapParser().ParsePredefined(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "UniJIS-UTF16-H"));
global::DripSharp.Testing.JavaAssertions.Equal(694, cMap.ToCID(177), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "UniJIS-UTF16-H CID 0xb1 -> 694"));
global::DripSharp.Testing.JavaAssertions.NotEqual(694, cMap.ToCID(177, 1), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "UniJIS-UTF16-H CID 0xb1 -> 694"));
global::DripSharp.Testing.JavaAssertions.Equal(694, cMap.ToCID(177, 2), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "UniJIS-UTF16-H CID 0x00b1 -> 694"));
global::DripSharp.Testing.JavaAssertions.Equal(694, cMap.ToCID(new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(177)) }), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "UniJIS-UTF16-H CID 0x00b1 -> 694"));
global::DripSharp.Testing.JavaAssertions.Equal(20168, cMap.ToCID(new sbyte[] { unchecked((sbyte)(216)), unchecked((sbyte)(80)), unchecked((sbyte)(220)), unchecked((sbyte)(75)) }), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "UniJIS-UTF16-H CID 0xd850dc4b -> 20168"));
global::DripSharp.Testing.JavaAssertions.Equal(19223, cMap.ToCID(new sbyte[] { unchecked((sbyte)(84)), unchecked((sbyte)(52)) }), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "UniJIS-UTF16-H CID 0x5434 -> 19223"));
global::DripSharp.Testing.JavaAssertions.Equal(10006, cMap.ToCID(new sbyte[] { unchecked((sbyte)(216)), unchecked((sbyte)(60)), unchecked((sbyte)(221)), unchecked((sbyte)(18)) }), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "UniJIS-UTF16-H CID 0xd83cdd12 -> 10006"));
}

internal virtual void testUniJIS_UCS2_H() {
global::DripSharp.PdfCarton.Fonts.Cmap.CMap cMap = new global::DripSharp.PdfCarton.Fonts.Cmap.CMapParser().ParsePredefined(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "UniJIS-UCS2-H"));
global::DripSharp.Testing.JavaAssertions.Equal(34, cMap.ToCID(new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(65)) }), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "UniJIS-UCS2-H CID 65 -> 34"));
}

internal virtual void testAdobe_GB1_UCS2() {
global::DripSharp.PdfCarton.Fonts.Cmap.CMap cMap = new global::DripSharp.PdfCarton.Fonts.Cmap.CMapParser().ParsePredefined(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Adobe-GB1-UCS2"));
global::DripSharp.Testing.JavaAssertions.Equal("0", cMap.ToUnicode(new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(17)) }), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Adobe-GB1-UCS2 CID 0x11 -> \"0\""));
}

internal virtual void testParserWithPoorWhitespace() {
global::DripSharp.PdfCarton.Fonts.Cmap.CMap cMap = new global::DripSharp.PdfCarton.Fonts.Cmap.CMapParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "src/test/resources/cmap"), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "CMapNoWhitespace"))));
global::DripSharp.Testing.JavaAssertions.NotNull(cMap, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Failed to parse nasty CMap file"));
}

internal virtual void testParserWithMalformedbfrange1() {
global::DripSharp.PdfCarton.Fonts.Cmap.CMap cMap = new global::DripSharp.PdfCarton.Fonts.Cmap.CMapParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "src/test/resources/cmap"), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "CMapMalformedbfrange1"))));
global::DripSharp.Testing.JavaAssertions.NotNull(cMap, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Failed to parse malformed CMap file"));
sbyte[] bytes1 = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)) };
global::DripSharp.Testing.JavaAssertions.Equal("A", cMap.ToUnicode(bytes1), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "bytes 00 01 from bfrange <0001> <0009> <0041>"));
sbyte[] bytes2 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(0)) };
global::DripSharp.Testing.JavaAssertions.Null(cMap.ToUnicode(bytes2), null);
}

internal virtual void testParserWithMalformedbfrange2() {
global::DripSharp.PdfCarton.Fonts.Cmap.CMap cMap = new global::DripSharp.PdfCarton.Fonts.Cmap.CMapParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "src/test/resources/cmap"), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "CMapMalformedbfrange2"))));
global::DripSharp.Testing.JavaAssertions.NotNull(cMap, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Failed to parse malformed CMap file"));
global::DripSharp.Testing.JavaAssertions.Equal("0", cMap.ToUnicode(new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)) }), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "bytes 00 01 from bfrange <0001> <0009> <0030>"));
global::DripSharp.Testing.JavaAssertions.Equal("A", cMap.ToUnicode(new sbyte[] { unchecked((sbyte)(2)), unchecked((sbyte)(50)) }), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "bytes 02 32 from bfrange <0232> <0432> <0041>"));
global::DripSharp.Testing.JavaAssertions.NotNull(cMap.ToUnicode(new sbyte[] { unchecked((sbyte)(2)), unchecked((sbyte)(240)) }), null);
global::DripSharp.Testing.JavaAssertions.NotNull(cMap.ToUnicode(new sbyte[] { unchecked((sbyte)(2)), unchecked((sbyte)(241)) }), null);
cMap = new global::DripSharp.PdfCarton.Fonts.Cmap.CMapParser(true).Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "src/test/resources/cmap"), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "CMapMalformedbfrange2"))));
global::DripSharp.Testing.JavaAssertions.NotNull(cMap.ToUnicode(new sbyte[] { unchecked((sbyte)(2)), unchecked((sbyte)(240)) }), null);
global::DripSharp.Testing.JavaAssertions.Null(cMap.ToUnicode(new sbyte[] { unchecked((sbyte)(2)), unchecked((sbyte)(241)) }), null);
}

internal virtual void testPredefinedMap() {
global::DripSharp.PdfCarton.Fonts.Cmap.CMap cMap = new global::DripSharp.PdfCarton.Fonts.Cmap.CMapParser().ParsePredefined(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Adobe-Korea1-UCS2"));
global::DripSharp.Testing.JavaAssertions.NotNull(cMap, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Failed to parse predefined CMap Adobe-Korea1-UCS2"));
global::DripSharp.Testing.JavaAssertions.Equal("Adobe-Korea1-UCS2", cMap.GetName(), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "wrong CMap name"));
global::DripSharp.Testing.JavaAssertions.Equal(0, cMap.GetWMode(), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "wrong WMode"));
global::DripSharp.Testing.JavaAssertions.False(cMap.HasCIDMappings(), null);
global::DripSharp.Testing.JavaAssertions.True(cMap.HasUnicodeMappings(), null);
cMap = new global::DripSharp.PdfCarton.Fonts.Cmap.CMapParser().ParsePredefined(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Identity-V"));
global::DripSharp.Testing.JavaAssertions.NotNull(cMap, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Failed to parse predefined CMap Identity-V"));
}

internal virtual void testIdentitybfrange() {
global::DripSharp.PdfCarton.Fonts.Cmap.CMap cMap = new global::DripSharp.PdfCarton.Fonts.Cmap.CMapParser(true).Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "src/test/resources/cmap"), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Identitybfrange"))));
global::DripSharp.Testing.JavaAssertions.Equal("Adobe-Identity-UCS", cMap.GetName(), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "wrong CMap name"));
sbyte[] bytes = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(65)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.NewString(bytes, global::DripSharp.Runtime.JavaStandardCharsets.UTF16BE), cMap.ToUnicode(bytes), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Indentity 0x0048"));
bytes = new sbyte[] { unchecked((sbyte)(48)), unchecked((sbyte)(57)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.NewString(bytes, global::DripSharp.Runtime.JavaStandardCharsets.UTF16BE), cMap.ToUnicode(bytes), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Indentity 0x3039"));
bytes = new sbyte[] { unchecked((sbyte)(48)), unchecked((sbyte)(255)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.NewString(bytes, global::DripSharp.Runtime.JavaStandardCharsets.UTF16BE), cMap.ToUnicode(bytes), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Indentity 0x30FF"));
bytes = new sbyte[] { unchecked((sbyte)(49)), unchecked((sbyte)(0)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.NewString(bytes, global::DripSharp.Runtime.JavaStandardCharsets.UTF16BE), cMap.ToUnicode(bytes), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Indentity 0x3100"));
bytes = new sbyte[] { unchecked((sbyte)(255)), unchecked((sbyte)(255)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.NewString(bytes, global::DripSharp.Runtime.JavaStandardCharsets.UTF16BE), cMap.ToUnicode(bytes), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Indentity 0xFFFF"));
}

internal virtual void testBadIncrement() {
sbyte[] cmapData = global::DripSharp.Runtime.JavaCompat.StringGetBytes("1 beginbfrange\n<> <> <2223>\nendbfrange", global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "US-ASCII"));
global::DripSharp.PdfCarton.Fonts.Cmap.CMapParser parser = new global::DripSharp.PdfCarton.Fonts.Cmap.CMapParser();
global::DripSharp.PdfCarton.Fonts.Cmap.CMap cmap = parser.Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(cmapData));
global::DripSharp.Testing.JavaAssertions.NotNull(cmap, null);
}

[Xunit.Fact]
public void __Upstream_2102468280_dc9a4f98d099a94a()
{
        try
        {
            this.testAdobe_GB1_UCS2();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2925998748_132f6732ac12921e()
{
        try
        {
            this.testBadIncrement();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2726061936_b39a8c81fe583ae8()
{
        try
        {
            this.testIdentity();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3661271561_3e965c095cdc126f()
{
        try
        {
            this.testIdentitybfrange();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3670123692_35fae1bbff65f97b()
{
        try
        {
            this.testLookup();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3898212764_4c8485e867fcd300()
{
        try
        {
            this.testParserWithMalformedbfrange1();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3898212765_5c5c0c1c7309b589()
{
        try
        {
            this.testParserWithMalformedbfrange2();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0575034326_19536bf8a6f25d6e()
{
        try
        {
            this.testParserWithPoorWhitespace();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0958829060_49270c23c005d2d6()
{
        try
        {
            this.testPredefinedMap();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0474692351_c349927f30a83859()
{
        try
        {
            this.testUniJIS_UCS2_H();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2305182380_4d7db9ed002f55c4()
{
        try
        {
            this.testUniJIS_UTF16_H();
        }
        finally
        {
        }
}
}
