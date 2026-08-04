// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Cos;

public class TestCOSFloat : global::DripSharp.PdfCarton.Cos.TestCOSNumber {
internal static void setUp() {
global::DripSharp.PdfCarton.Cos.TestCOSBase.__field_TestCOSBase = global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "1.1"));
}

internal abstract class BaseTester {
internal int low = -100000;

internal int high = 300000;

internal int step = 20000;

public virtual void SetLoop(int low, int high, int step) {
this.low = low;
this.high = high;
this.step = step;
}

public virtual void RunTests() {
this.loop((long)(123456));
this.loop(global::System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
}

internal void loop(long seed) {
global::DripSharp.PdfCarton.Tests.JavaRandom rnd = new global::DripSharp.PdfCarton.Tests.JavaRandom(seed);
for (int i = this.low; (i < this.high); i += this.step) {
float num = (i * rnd.NextFloat());
try {
this.runTest(num);
} catch (global::DripSharp.Runtime.JavaAssertionError a) {
global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
}
}
}

internal abstract void runTest(float num);

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    setUp();
    return true;
}

private readonly global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer;

internal BaseTester(global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer) {
this.__outer = __outer;
}
}

internal virtual void testEquals() {
new Anonymous_107_9(this).RunTests();
}

private sealed class Anonymous_107_9 : global::DripSharp.PdfCarton.Cos.TestCOSFloat.BaseTester {
private readonly global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer;

public Anonymous_107_9(global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer) : base(__outer) {
this.__outer = __outer;
}

internal override void runTest(float num) {
global::DripSharp.PdfCarton.Cos.COSFloat test1 = new global::DripSharp.PdfCarton.Cos.COSFloat(num);
global::DripSharp.PdfCarton.Cos.COSFloat test2 = new global::DripSharp.PdfCarton.Cos.COSFloat(num);
global::DripSharp.PdfCarton.Cos.COSFloat test3 = new global::DripSharp.PdfCarton.Cos.COSFloat(num);
global::DripSharp.Testing.JavaAssertions.Equal(test1, test1, null);
global::DripSharp.Testing.JavaAssertions.Equal(test2, test3, null);
global::DripSharp.Testing.JavaAssertions.Equal(test3, test2, null);
global::DripSharp.Testing.JavaAssertions.Equal(test1, test2, null);
global::DripSharp.Testing.JavaAssertions.Equal(test2, test3, null);
global::DripSharp.Testing.JavaAssertions.Equal(test1, test3, null);
float nf = global::System.BitConverter.Int32BitsToSingle((global::DripSharp.Runtime.JavaCompat.FloatToIntBits(num) + 1));
global::DripSharp.PdfCarton.Cos.COSFloat test4 = new global::DripSharp.PdfCarton.Cos.COSFloat(nf);
global::DripSharp.Testing.JavaAssertions.NotEqual(test4, test1, null);
}
}

internal class HashCodeTester : global::DripSharp.PdfCarton.Cos.TestCOSFloat.BaseTester {
internal override void runTest(float num) {
global::DripSharp.PdfCarton.Cos.COSFloat test1 = new global::DripSharp.PdfCarton.Cos.COSFloat(num);
global::DripSharp.PdfCarton.Cos.COSFloat test2 = new global::DripSharp.PdfCarton.Cos.COSFloat(num);
global::DripSharp.Testing.JavaAssertions.Equal(test1.GetHashCode(), test2.GetHashCode(), null);
float nf = global::System.BitConverter.Int32BitsToSingle((global::DripSharp.Runtime.JavaCompat.FloatToIntBits(num) + 1));
global::DripSharp.PdfCarton.Cos.COSFloat test3 = new global::DripSharp.PdfCarton.Cos.COSFloat(nf);
global::DripSharp.Testing.JavaAssertions.NotSame(test3.GetHashCode(), test1.GetHashCode(), null);
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    setUp();
    return true;
}

private readonly global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer;

internal HashCodeTester(global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer) : base(__outer) {
this.__outer = __outer;
}
}

internal virtual void testHashCode() {
new global::DripSharp.PdfCarton.Cos.TestCOSFloat.HashCodeTester(this).RunTests();
}

internal class FloatValueTester : global::DripSharp.PdfCarton.Cos.TestCOSFloat.BaseTester {
internal override void runTest(float num) {
global::DripSharp.PdfCarton.Cos.COSFloat testFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(num);
global::DripSharp.Testing.JavaAssertions.Equal(num, testFloat.FloatValue(), null);
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    setUp();
    return true;
}

private readonly global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer;

internal FloatValueTester(global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer) : base(__outer) {
this.__outer = __outer;
}
}

internal override void testFloatValue() {
new global::DripSharp.PdfCarton.Cos.TestCOSFloat.FloatValueTester(this).RunTests();
}

internal class IntValueTester : global::DripSharp.PdfCarton.Cos.TestCOSFloat.BaseTester {
internal override void runTest(float num) {
global::DripSharp.PdfCarton.Cos.COSFloat testFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(num);
global::DripSharp.Testing.JavaAssertions.Equal((int)((int)(num)), testFloat.IntValue(), null);
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    setUp();
    return true;
}

private readonly global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer;

internal IntValueTester(global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer) : base(__outer) {
this.__outer = __outer;
}
}

internal override void testIntValue() {
new global::DripSharp.PdfCarton.Cos.TestCOSFloat.IntValueTester(this).RunTests();
}

internal class LongValueTester : global::DripSharp.PdfCarton.Cos.TestCOSFloat.BaseTester {
internal override void runTest(float num) {
global::DripSharp.PdfCarton.Cos.COSFloat testFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(num);
global::DripSharp.Testing.JavaAssertions.Equal((long)((long)(num)), testFloat.LongValue(), null);
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    setUp();
    return true;
}

private readonly global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer;

internal LongValueTester(global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer) : base(__outer) {
this.__outer = __outer;
}
}

internal override void testLongValue() {
new global::DripSharp.PdfCarton.Cos.TestCOSFloat.LongValueTester(this).RunTests();
}

internal class AcceptTester : global::DripSharp.PdfCarton.Cos.TestCOSFloat.BaseTester {
internal readonly global::DripSharp.Runtime.JavaByteArrayOutputStream outStream = new global::DripSharp.Runtime.JavaByteArrayOutputStream();

internal readonly global::DripSharp.PdfCarton.Pdfwriter.COSWriter visitor;

internal override void runTest(float num) {
try {
global::DripSharp.PdfCarton.Cos.COSFloat cosFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(num);
cosFloat.Accept(this.visitor);
global::DripSharp.Testing.JavaAssertions.Equal(this.__outer.floatToString(cosFloat.FloatValue()), global::DripSharp.Runtime.JavaCompat.MemoryStreamToString(this.outStream, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ISO-8859-1")), null);
this.__outer.TestByteArrays(global::DripSharp.Runtime.JavaCompat.StringGetBytes(this.__outer.floatToString(num), global::DripSharp.Runtime.JavaStandardCharsets.ISO88591), global::DripSharp.Runtime.JavaCompat.ToSignedBytes(this.outStream));
global::DripSharp.Runtime.JavaCompat.ResetMemoryStream(this.outStream);
} catch (global::System.IO.IOException e) {
global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
}
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    setUp();
    return true;
}

private readonly global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer;

internal AcceptTester(global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer) : base(__outer) {
this.__outer = __outer;
this.visitor = new global::DripSharp.PdfCarton.Pdfwriter.COSWriter(this.outStream);
}
}

internal override void testAccept() {
new global::DripSharp.PdfCarton.Cos.TestCOSFloat.AcceptTester(this).RunTests();
}

internal class WritePDFTester : global::DripSharp.PdfCarton.Cos.TestCOSFloat.BaseTester {
internal readonly global::DripSharp.Runtime.JavaByteArrayOutputStream outStream = new global::DripSharp.Runtime.JavaByteArrayOutputStream();

internal WritePDFTester(global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer) : base(__outer) {
this.__outer = __outer;

this.SetLoop(-1000, 3000, 200);
}

internal override void runTest(float num) {
try {
global::DripSharp.PdfCarton.Cos.COSFloat cosFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(num);
cosFloat.WritePDF(this.outStream);
string expected = this.__outer.floatToString(cosFloat.FloatValue());
global::DripSharp.Testing.JavaAssertions.Equal(expected, global::DripSharp.Runtime.JavaCompat.MemoryStreamToString(this.outStream, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ISO-8859-1")), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("COSFloat{", expected), "}"), cosFloat.ToString(), null);
expected = this.__outer.floatToString(num);
global::DripSharp.Testing.JavaAssertions.Equal(expected, global::DripSharp.Runtime.JavaCompat.MemoryStreamToString(this.outStream, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ISO-8859-1")), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("COSFloat{", expected), "}"), cosFloat.ToString(), null);
this.__outer.TestByteArrays(global::DripSharp.Runtime.JavaCompat.StringGetBytes(expected, global::DripSharp.Runtime.JavaStandardCharsets.ISO88591), global::DripSharp.Runtime.JavaCompat.ToSignedBytes(this.outStream));
global::DripSharp.Runtime.JavaCompat.ResetMemoryStream(this.outStream);
} catch (global::System.IO.IOException e) {
global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
}
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    setUp();
    return true;
}

private readonly global::DripSharp.PdfCarton.Cos.TestCOSFloat __outer;
}

internal virtual void testWritePDF() {
global::DripSharp.PdfCarton.Cos.TestCOSFloat.WritePDFTester writePDFTester = new global::DripSharp.PdfCarton.Cos.TestCOSFloat.WritePDFTester(this);
writePDFTester.RunTests();
writePDFTester.runTest(1.0E-33F);
}

internal virtual void testDoubleNegative() {
global::DripSharp.PdfCarton.Cos.COSFloat cosFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "--16.33"));
global::DripSharp.Testing.JavaAssertions.Equal(-16.33F, cosFloat.FloatValue(), null);
}

internal virtual void testVerySmallValues() {
double smallValue = ((float)(float.Epsilon) / (double)(10.0D));
global::DripSharp.Testing.JavaAssertions.Equal(-1, global::DripSharp.Runtime.JavaCompat.CompareDouble(smallValue, (double)(float.Epsilon)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test must be performed with a value smaller than Float.MIN_VALUE."));
string asString = global::DripSharp.Runtime.JavaCompat.StringValueOf(smallValue);
global::DripSharp.PdfCarton.Cos.COSFloat cosFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", asString));
global::DripSharp.Testing.JavaAssertions.Equal(0.0F, cosFloat.FloatValue(), null);
asString = global::DripSharp.Runtime.JavaCompat.JavaBigDecimalToPlainString(global::DripSharp.Runtime.JavaCompat.JavaBigDecimalParse(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", asString)));
cosFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", asString));
global::DripSharp.Testing.JavaAssertions.Equal(0.0F, cosFloat.FloatValue(), null);
smallValue *= -1;
asString = global::DripSharp.Runtime.JavaCompat.StringValueOf(smallValue);
cosFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", asString));
global::DripSharp.Testing.JavaAssertions.Equal(0.0F, cosFloat.FloatValue(), null);
asString = global::DripSharp.Runtime.JavaCompat.JavaBigDecimalToPlainString(global::DripSharp.Runtime.JavaCompat.JavaBigDecimalParse(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", asString)));
cosFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", asString));
global::DripSharp.Testing.JavaAssertions.Equal(0.0F, cosFloat.FloatValue(), null);
}

internal virtual void testVeryLargeValues() {
double largeValue = (float.MaxValue * 10.0D);
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.CompareDouble(largeValue, (double)(float.MaxValue)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test must be performed with a value larger than Float.MAX_VALUE."));
string asString = global::DripSharp.Runtime.JavaCompat.StringValueOf(largeValue);
global::DripSharp.PdfCarton.Cos.COSFloat cosFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", asString));
global::DripSharp.Testing.JavaAssertions.Equal(float.MaxValue, cosFloat.FloatValue(), null);
asString = global::DripSharp.Runtime.JavaCompat.JavaBigDecimalToPlainString(global::DripSharp.Runtime.JavaCompat.JavaBigDecimalParse(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", asString)));
cosFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", asString));
global::DripSharp.Testing.JavaAssertions.Equal(float.MaxValue, cosFloat.FloatValue(), null);
largeValue *= -1;
asString = global::DripSharp.Runtime.JavaCompat.StringValueOf(largeValue);
cosFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", asString));
global::DripSharp.Testing.JavaAssertions.Equal(-(float.MaxValue), cosFloat.FloatValue(), null);
asString = global::DripSharp.Runtime.JavaCompat.JavaBigDecimalToPlainString(global::DripSharp.Runtime.JavaCompat.JavaBigDecimalParse(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", asString)));
cosFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", asString));
global::DripSharp.Testing.JavaAssertions.Equal(-(float.MaxValue), cosFloat.FloatValue(), null);
}

internal virtual void testMisplacedNegative() {
global::DripSharp.PdfCarton.Cos.COSFloat cosFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "0.00000-33917698"));
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-0.0000033917698")), cosFloat, null);
cosFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "0.-262"));
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-0.262")), cosFloat, null);
cosFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-0.-262"));
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-0.262")), cosFloat, null);
cosFloat = new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-12.-1"));
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-12.1")), cosFloat, null);
}

internal virtual void testDuplicateMisplacedNegative() {
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "0.-26-2")), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "---0.262")), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => new global::DripSharp.PdfCarton.Cos.COSFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "--0.2-62")), null);
}

internal virtual void testStubOperatorMinMaxValues() {
float largeValue = 32768.0F;
float largeNegativeValue = -32768.0F;
global::DripSharp.Testing.JavaAssertions.Equal(largeValue, new global::DripSharp.PdfCarton.Cos.COSFloat(largeValue).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(largeNegativeValue, new global::DripSharp.PdfCarton.Cos.COSFloat(largeNegativeValue).FloatValue(), null);
}

private string floatToString(float value) {
return this.removeTrailingNull(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.JavaBigDecimalToPlainString(global::DripSharp.Runtime.JavaCompat.JavaBigDecimalParse(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.StringValueOf(value))))));
}

private string removeTrailingNull(string value) {
if (((global::DripSharp.Runtime.JavaCompat.StringIndexOf(value, (int)('.')) > -1) && !(global::DripSharp.Runtime.JavaCompat.StringEndsWith(value, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ".0"))))) {
while ((global::DripSharp.Runtime.JavaCompat.StringEndsWith(value, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "0")) && !(global::DripSharp.Runtime.JavaCompat.StringEndsWith(value, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ".0"))))) {
value = global::DripSharp.Runtime.JavaCompat.StringSubstring(value, 0, (value.Length - 1));
}
}
return value;
}

[Xunit.Fact]
public void __Upstream_3343757370_07d5568ed60ec679()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testAccept();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0658846808_225b179aee7a9212()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testDoubleNegative();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3773113872_63827d8f47a9ffa5()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testDuplicateMisplacedNegative();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3471735537_53c0afab3a596814()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testEquals();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0407743143_490879df11ffd8f0()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testFloatValue();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0725004644_b9e5f213f8369fb1()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testGet();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3571534498_569b58d96bc9524c()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testGetCOSObject();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3009520333_d470b47dc8c22b89()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testHashCode();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3417873780_61addf1c453da637()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testIntValue();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2725022894_e601141d3f633f1e()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testInvalidNumber();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2816239855_53ae77b5d634741b()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testIsSetDirect();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4121304690_c48d1e938196307c()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testLargeNumber();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2936432611_17109c7efa959f6b()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testLongValue();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2832195383_d690f94962df06dc()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testMisplacedNegative();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2376670392_7b491a070b1f48ab()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testStubOperatorMinMaxValues();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3818612277_7005d500aae6ec4b()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testVeryLargeValues();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0175355649_4bc34c65e53bd556()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testVerySmallValues();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1015337797_f491a3413b5fbf67()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testWritePDF();
        }
        finally
        {
        }
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    setUp();
    return true;
}
}
