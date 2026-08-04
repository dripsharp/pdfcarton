// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Cff;

public class CFFParserTest {
private static global::DripSharp.PdfCarton.Fonts.Cff.CFFType1Font testCFFType1Font = null!;

internal static void loadCFFFont() {
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Cff.CFFFont> fonts = global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.readFont(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "target/fonts/SourceSansProBold.otf"));
global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font = (global::DripSharp.PdfCarton.Fonts.Cff.CFFType1Font)(global::DripSharp.Runtime.JavaCompat.ListGet(fonts, 0)!);
}

internal virtual void testFontname() {
global::DripSharp.Testing.JavaAssertions.Equal("SourceSansPro-Bold", global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font.GetName(), null);
}

internal virtual void testFontBBox() {
global::DripSharp.PdfCarton.Fonts.Util.BoundingBox fontBBox = global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font.GetFontBBox();
global::DripSharp.Testing.JavaAssertions.NotNull(fontBBox, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "FontBBox must not be null"));
global::DripSharp.Testing.JavaAssertions.Equal(-231.0F, fontBBox.GetLowerLeftX(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-384.0F, fontBBox.GetLowerLeftY(), null);
global::DripSharp.Testing.JavaAssertions.Equal(1223.0F, fontBBox.GetUpperRightX(), null);
global::DripSharp.Testing.JavaAssertions.Equal(974.0F, fontBBox.GetUpperRightY(), null);
}

internal virtual void testFontMatrix() {
global::System.Collections.Generic.IList<global::System.IConvertible> fontMatrix = global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font.GetFontMatrix();
global::DripSharp.Testing.JavaAssertions.NotNull(fontMatrix, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "FontMatrix must not be null"));
this.assertNumberList(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.Concat("FontMatrix values are different than expected", global::DripSharp.Runtime.JavaCompat.StringValueOf(fontMatrix))), new float[] { 0.001F, 0.0F, 0.0F, 0.001F, 0.0F, 0.0F }, fontMatrix);
}

internal virtual void testCharset() {
global::DripSharp.PdfCarton.Fonts.Cff.CFFCharset charset = global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font.GetCharset();
global::DripSharp.Testing.JavaAssertions.NotNull(charset, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Charset must not be null"));
global::DripSharp.Testing.JavaAssertions.False(charset.IsCIDFont(), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "isCIDFont has to be false"));
global::DripSharp.Testing.JavaAssertions.Equal("Format1Charset", ((object)(charset)).GetType().Name, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Charset is not an instance of Format1Charset"));
global::DripSharp.Testing.JavaAssertions.Equal(".notdef", charset.GetNameForGID(0), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Unexpected value for gid2name mapping"));
global::DripSharp.Testing.JavaAssertions.Equal("space", charset.GetNameForGID(1), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Unexpected value for gid2name mapping"));
global::DripSharp.Testing.JavaAssertions.Equal("F", charset.GetNameForGID(7), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Unexpected value for gid2name mapping"));
global::DripSharp.Testing.JavaAssertions.Equal("jcircumflex", charset.GetNameForGID(300), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Unexpected value for gid2name mapping"));
global::DripSharp.Testing.JavaAssertions.Equal("infinity", charset.GetNameForGID(700), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Unexpected value for gid2name mapping"));
global::DripSharp.Testing.JavaAssertions.Equal(0, charset.GetSIDForGID(0), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Unexpected value for gid2sid mapping"));
global::DripSharp.Testing.JavaAssertions.Equal(1, charset.GetSIDForGID(1), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Unexpected value for gid2sid mapping"));
global::DripSharp.Testing.JavaAssertions.Equal(39, charset.GetSIDForGID(7), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Unexpected value for gid2sid mapping"));
global::DripSharp.Testing.JavaAssertions.Equal(585, charset.GetSIDForGID(300), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Unexpected value for gid2sid mapping"));
global::DripSharp.Testing.JavaAssertions.Equal(872, charset.GetSIDForGID(700), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Unexpected value for gid2sid mapping"));
global::DripSharp.Testing.JavaAssertions.Equal(0, charset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", ".notdef")), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Unexpected value for name2sid mapping"));
global::DripSharp.Testing.JavaAssertions.Equal(1, charset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "space")), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Unexpected value for name2sid mapping"));
global::DripSharp.Testing.JavaAssertions.Equal(39, charset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "F")), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Unexpected value for name2sid mapping"));
global::DripSharp.Testing.JavaAssertions.Equal(585, charset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "jcircumflex")), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Unexpected value for name2sid mapping"));
global::DripSharp.Testing.JavaAssertions.Equal(872, charset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "infinity")), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Unexpected value for name2sid mapping"));
}

internal virtual void voidEncoding() {
global::DripSharp.PdfCarton.Fonts.Cff.CFFEncoding encoding = global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font.GetEncoding();
global::DripSharp.Testing.JavaAssertions.NotNull(encoding, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Encoding must not be null"));
global::DripSharp.Testing.JavaAssertions.InstanceOf<global::DripSharp.PdfCarton.Fonts.Cff.CFFStandardEncoding>(encoding, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Encoding is not an instance of CFFStandardEncoding"));
}

internal virtual void testCharStringBytess() {
global::System.Collections.Generic.IList<sbyte[]> charStringBytes = global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font.GetCharStringBytes();
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(charStringBytes), null);
global::DripSharp.Testing.JavaAssertions.Equal(824, global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font.GetNumCharStrings(), null);
global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)(-4)), unchecked((sbyte)(15)), unchecked((sbyte)(14)) }, global::DripSharp.Runtime.JavaCompat.ListGet(charStringBytes, 1), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Other char strings byte values than expected"));
global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)(72)), unchecked((sbyte)(29)), unchecked((sbyte)(-13)), unchecked((sbyte)(29)), unchecked((sbyte)(-9)), unchecked((sbyte)(-74)), unchecked((sbyte)(-9)), unchecked((sbyte)(43)), unchecked((sbyte)(3)), unchecked((sbyte)(33)), unchecked((sbyte)(29)), unchecked((sbyte)(14)) }, global::DripSharp.Runtime.JavaCompat.ListGet(charStringBytes, 16), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Other char strings byte values than expected"));
global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)(-41)), unchecked((sbyte)(88)), unchecked((sbyte)(29)), unchecked((sbyte)(-47)), unchecked((sbyte)(-9)), unchecked((sbyte)(12)), unchecked((sbyte)(1)), unchecked((sbyte)(-123)), unchecked((sbyte)(10)), unchecked((sbyte)(3)), unchecked((sbyte)(35)), unchecked((sbyte)(29)), unchecked((sbyte)(-9)), unchecked((sbyte)(-50)), unchecked((sbyte)(-9)), unchecked((sbyte)(62)), unchecked((sbyte)(-9)), unchecked((sbyte)(3)), unchecked((sbyte)(10)), unchecked((sbyte)(85)), unchecked((sbyte)(-56)), unchecked((sbyte)(61)), unchecked((sbyte)(10)) }, global::DripSharp.Runtime.JavaCompat.ListGet(charStringBytes, 195), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Other char strings byte values than expected"));
global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)(-5)), unchecked((sbyte)(-69)), unchecked((sbyte)(-61)), unchecked((sbyte)(-8)), unchecked((sbyte)(28)), unchecked((sbyte)(1)), unchecked((sbyte)(-9)), unchecked((sbyte)(57)), unchecked((sbyte)(-39)), unchecked((sbyte)(-65)), unchecked((sbyte)(29)), unchecked((sbyte)(14)) }, global::DripSharp.Runtime.JavaCompat.ListGet(charStringBytes, 525), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Other char strings byte values than expected"));
global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)(107)), unchecked((sbyte)(-48)), unchecked((sbyte)(10)), unchecked((sbyte)(-9)), unchecked((sbyte)(20)), unchecked((sbyte)(-9)), unchecked((sbyte)(123)), unchecked((sbyte)(3)), unchecked((sbyte)(-9)), unchecked((sbyte)(-112)), unchecked((sbyte)(-8)), unchecked((sbyte)(-46)), unchecked((sbyte)(21)), unchecked((sbyte)(-10)), unchecked((sbyte)(115)), unchecked((sbyte)(10)) }, global::DripSharp.Runtime.JavaCompat.ListGet(charStringBytes, 738), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Other char strings byte values than expected"));
}

internal virtual void testGlobalSubrIndex() {
global::System.Collections.Generic.IList<sbyte[]> globalSubrIndex = global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font.GetGlobalSubrIndex();
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(globalSubrIndex), null);
global::DripSharp.Testing.JavaAssertions.Equal(278, global::DripSharp.Runtime.JavaCompat.CollectionCount(globalSubrIndex), null);
global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)(21)), unchecked((sbyte)(-70)), unchecked((sbyte)(-83)), unchecked((sbyte)(-85)), unchecked((sbyte)(-72)), unchecked((sbyte)(-72)), unchecked((sbyte)(105)), unchecked((sbyte)(-85)), unchecked((sbyte)(92)), unchecked((sbyte)(91)), unchecked((sbyte)(105)), unchecked((sbyte)(107)), unchecked((sbyte)(10)), unchecked((sbyte)(-83)), unchecked((sbyte)(-9)), unchecked((sbyte)(62)), unchecked((sbyte)(10)) }, global::DripSharp.Runtime.JavaCompat.ListGet(globalSubrIndex, 12), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Other global subr index values than expected"));
global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)(58)), unchecked((sbyte)(122)), unchecked((sbyte)(29)), unchecked((sbyte)(-5)), unchecked((sbyte)(48)), unchecked((sbyte)(6)), unchecked((sbyte)(11)) }, global::DripSharp.Runtime.JavaCompat.ListGet(globalSubrIndex, 120), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Other global subr index values than expected"));
global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)(68)), unchecked((sbyte)(80)), unchecked((sbyte)(29)), unchecked((sbyte)(-45)), unchecked((sbyte)(-9)), unchecked((sbyte)(16)), unchecked((sbyte)(-8)), unchecked((sbyte)(-92)), unchecked((sbyte)(119)), unchecked((sbyte)(11)) }, global::DripSharp.Runtime.JavaCompat.ListGet(globalSubrIndex, 253), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Other global subr index values than expected"));
}

internal virtual void testDeltaLists() {
global::System.Collections.Generic.IList<global::System.IConvertible> blues = global::DripSharp.Runtime.JavaCompat.CastList<global::System.IConvertible>(global::DripSharp.Runtime.JavaCompat.MapGet(global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font.GetPrivateDict(), "BlueValues"));
this.assertNumberList(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.Concat("Blue values are different than expected: ", global::DripSharp.Runtime.JavaCompat.StringValueOf(blues))), new int[] { -12, 0, 496, 508, 578, 590, 635, 647, 652, 664, 701, 713 }, blues);
global::System.Collections.Generic.IList<global::System.IConvertible> otherBlues = global::DripSharp.Runtime.JavaCompat.CastList<global::System.IConvertible>(global::DripSharp.Runtime.JavaCompat.MapGet(global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font.GetPrivateDict(), "OtherBlues"));
this.assertNumberList(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.Concat("Other blues are different than expected: ", global::DripSharp.Runtime.JavaCompat.StringValueOf(otherBlues))), new int[] { -196, -184 }, otherBlues);
global::System.Collections.Generic.IList<global::System.IConvertible> familyBlues = global::DripSharp.Runtime.JavaCompat.CastList<global::System.IConvertible>(global::DripSharp.Runtime.JavaCompat.MapGet(global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font.GetPrivateDict(), "FamilyBlues"));
this.assertNumberList(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.Concat("Other blues are different than expected: ", global::DripSharp.Runtime.JavaCompat.StringValueOf(familyBlues))), new int[] { -12, 0, 486, 498, 574, 586, 638, 650, 656, 668, 712, 724 }, familyBlues);
global::System.Collections.Generic.IList<global::System.IConvertible> familyOtherBlues = global::DripSharp.Runtime.JavaCompat.CastList<global::System.IConvertible>(global::DripSharp.Runtime.JavaCompat.MapGet(global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font.GetPrivateDict(), "FamilyOtherBlues"));
this.assertNumberList(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.Concat("Other blues are different than expected: ", global::DripSharp.Runtime.JavaCompat.StringValueOf(familyOtherBlues))), new int[] { -217, -205 }, familyOtherBlues);
global::System.Collections.Generic.IList<global::System.IConvertible> stemSnapH = global::DripSharp.Runtime.JavaCompat.CastList<global::System.IConvertible>(global::DripSharp.Runtime.JavaCompat.MapGet(global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font.GetPrivateDict(), "StemSnapH"));
this.assertNumberList(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.Concat("StemSnapH values are different than expected: ", global::DripSharp.Runtime.JavaCompat.StringValueOf(stemSnapH))), new int[] { 115 }, stemSnapH);
global::System.Collections.Generic.IList<global::System.IConvertible> stemSnapV = global::DripSharp.Runtime.JavaCompat.CastList<global::System.IConvertible>(global::DripSharp.Runtime.JavaCompat.MapGet(global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font.GetPrivateDict(), "StemSnapV"));
this.assertNumberList(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.Concat("StemSnapV values are different than expected: ", global::DripSharp.Runtime.JavaCompat.StringValueOf(stemSnapV))), new int[] { 146, 150 }, stemSnapV);
}

internal virtual void testMultiThreadParse() {
global::System.Threading.CountdownEvent latch = new global::System.Threading.CountdownEvent(2);
global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.PathRunner pathRunner1 = new global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.PathRunner(latch, this);
global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.PathRunner pathRunner2 = new global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.PathRunner(latch, this);
global::DripSharp.Runtime.JavaAtomicBoolean wasCalled = new global::DripSharp.Runtime.JavaAtomicBoolean(false);
global::System.Action<global::DripSharp.PdfCarton.Tests.JavaTestThread, global::System.Exception> handler = (t, e) => wasCalled.Set(true);
global::DripSharp.PdfCarton.Tests.JavaTestThread thread1 = new global::DripSharp.PdfCarton.Tests.JavaTestThread(pathRunner1);
thread1.SetUncaughtExceptionHandler(handler);
global::DripSharp.PdfCarton.Tests.JavaTestThread thread2 = new global::DripSharp.PdfCarton.Tests.JavaTestThread(pathRunner2);
thread2.SetUncaughtExceptionHandler(handler);
thread1.Start();
thread2.Start();
latch.Wait();
global::DripSharp.Testing.JavaAssertions.False(wasCalled.Get(), null);
}

internal class PathRunner {
internal readonly global::System.Threading.CountdownEvent latch = null!;

internal PathRunner(global::System.Threading.CountdownEvent latch, global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest __outer) {
this.__outer = __outer;

this.latch = latch;
}

public virtual void Run() {
try {
for (char i = unchecked((char)(33)); ((int)(i) < 126); i++) {
global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.testCFFType1Font.GetPath(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.StringValueOf(i)));
}
} catch (global::System.Exception e) when (e is not global::System.TypeInitializationException) {
throw new global::System.InvalidOperationException(null, e);
} finally {
(this.latch).Signal();
}
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    loadCFFFont();
    return true;
}

private readonly global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest __outer;

public static implicit operator global::System.Action(global::DripSharp.PdfCarton.Fonts.Cff.CFFParserTest.PathRunner value) => value.Run;
}

private static global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Cff.CFFFont> readFont(string filename) {
global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile randomAccessRead = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", filename));
global::DripSharp.PdfCarton.Fonts.Cff.CFFParser parser = new global::DripSharp.PdfCarton.Fonts.Cff.CFFParser();
return parser.Parse(randomAccessRead);
}

private void assertNumberList(string message, int[] expected, global::System.Collections.Generic.IList<global::System.IConvertible> found) {
global::DripSharp.Testing.JavaAssertions.Equal(expected.Length, global::DripSharp.Runtime.JavaCompat.CollectionCount(found), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", message));
for (int i = 0; (i < expected.Length); i++) {
global::DripSharp.Testing.JavaAssertions.Equal(expected[i], global::DripSharp.Runtime.JavaCompat.NumberIntValue(global::DripSharp.Runtime.JavaCompat.ListGet(found, i)), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", message));
}
}

private void assertNumberList(string message, float[] expected, global::System.Collections.Generic.IList<global::System.IConvertible> found) {
global::DripSharp.Testing.JavaAssertions.Equal(expected.Length, global::DripSharp.Runtime.JavaCompat.CollectionCount(found), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", message));
for (int i = 0; (i < expected.Length); i++) {
global::DripSharp.Testing.JavaAssertions.Equal(expected[i], global::System.Convert.ToSingle(global::DripSharp.Runtime.JavaCompat.ListGet(found, i), global::System.Globalization.CultureInfo.InvariantCulture), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", message));
}
}

[Xunit.Fact]
public void __Upstream_3148039169_303f35b729c0b2b9()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCharStringBytess();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2493959258_5013422966d26fc9()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCharset();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3059309807_da20e5a42b2a4b1b()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testDeltaLists();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3226880426_2f65c3054345b261()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testFontBBox();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0409398050_1118604bd73d1422()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testFontMatrix();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3228220940_44e9aa51960c16be()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testFontname();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1342619243_281f007625ced089()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testGlobalSubrIndex();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3098147970_14f1e8aaea120f1b()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testMultiThreadParse();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0566234887_f0329ea70beebbbe()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.voidEncoding();
        }
        finally
        {
        }
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    loadCFFFont();
    return true;
}
}
