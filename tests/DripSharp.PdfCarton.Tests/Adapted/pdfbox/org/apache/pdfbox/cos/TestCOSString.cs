// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Cos;

public class TestCOSString : global::DripSharp.PdfCarton.Cos.TestCOSBase {
private const string ESC_CHAR_STRING = "( test#some) escaped< \\chars>!~1239857 ";

private const string ESC_CHAR_STRING_PDF_FORMAT = "\\( test#some\\) escaped< \\\\chars>!~1239857 ";

internal static void setUp() {
global::DripSharp.PdfCarton.Cos.TestCOSBase.__field_TestCOSBase = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "test cos string"));
}

internal virtual void testSetForceHexLiteralForm() {
string inputString = "Test with a text and a few numbers 1, 2 and 3";
string pdfHex = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<", this.createHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", inputString))), ">");
global::DripSharp.PdfCarton.Cos.COSString cosStr = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", inputString));
cosStr.SetForceHexForm(true);
this.writePDFTests(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", pdfHex), cosStr);
global::DripSharp.PdfCarton.Cos.COSString escStr = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING));
this.writePDFTests(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("(", global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING_PDF_FORMAT), ")")), escStr);
escStr.SetForceHexForm(true);
this.writePDFTests(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<", this.createHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING))), ">")), escStr);
}

private void writePDFTests(string expected, global::DripSharp.PdfCarton.Cos.COSString testSubj) {
global::DripSharp.Runtime.JavaByteArrayOutputStream outStream = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
global::DripSharp.PdfCarton.Pdfwriter.COSWriter.WriteString(testSubj, outStream);
global::DripSharp.Testing.JavaAssertions.Equal(expected, global::DripSharp.PdfCarton.Tests.Support.OutputText(outStream), null);
}

internal virtual void testFromHex() {
string expected = "Quick and simple test";
string hexForm = this.createHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", expected));
global::DripSharp.PdfCarton.Cos.COSString test1 = global::DripSharp.PdfCarton.Cos.COSString.ParseHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", hexForm));
this.writePDFTests(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("(", expected), ")")), test1);
global::DripSharp.PdfCarton.Cos.COSString test2 = global::DripSharp.PdfCarton.Cos.COSString.ParseHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", this.createHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING))));
this.writePDFTests(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("(", global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING_PDF_FORMAT), ")")), test2);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => global::DripSharp.PdfCarton.Cos.COSString.ParseHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(hexForm, "xx"))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Should have thrown an IOException here"));
}

private string createHex(string str) {
global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();
foreach (char c in str.ToCharArray()) {
sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.ToStringRadix((int)(c), 16)));
}
return sb.ToString().ToUpper();
}

internal virtual void testGetHex() {
string expected = "Test subject for testing getHex";
global::DripSharp.PdfCarton.Cos.COSString test1 = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", expected));
string hexForm = this.createHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", expected));
global::DripSharp.Testing.JavaAssertions.Equal(hexForm, test1.ToHexString(), null);
global::DripSharp.PdfCarton.Cos.COSString escCS = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING));
global::DripSharp.Testing.JavaAssertions.Equal(this.createHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING)), escCS.ToHexString(), null);
}

internal virtual void testGetString() {
string testStr = "Test subject for getString()";
global::DripSharp.PdfCarton.Cos.COSString test1 = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", testStr));
global::DripSharp.Testing.JavaAssertions.Equal(testStr, test1.GetString(), null);
global::DripSharp.PdfCarton.Cos.COSString hexStr = global::DripSharp.PdfCarton.Cos.COSString.ParseHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", this.createHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", testStr))));
global::DripSharp.Testing.JavaAssertions.Equal(testStr, hexStr.GetString(), null);
global::DripSharp.PdfCarton.Cos.COSString escapedString = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING, escapedString.GetString(), null);
testStr = "Line1\nLine2\nLine3\n";
global::DripSharp.PdfCarton.Cos.COSString lineFeedString = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", testStr));
global::DripSharp.Testing.JavaAssertions.Equal(testStr, lineFeedString.GetString(), null);
}

internal virtual void testGetBytes() {
global::DripSharp.PdfCarton.Cos.COSString str = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING));
this.TestByteArrays(global::DripSharp.Runtime.JavaCompat.StringGetBytes(global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING, global::System.Text.Encoding.UTF8), str.GetBytes());
}

internal virtual void testWritePDF() {
global::DripSharp.PdfCarton.Cos.COSString testSubj = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING));
this.writePDFTests(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("(", global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING_PDF_FORMAT), ")")), testSubj);
string textString = "This is just an arbitrary piece of text for testing";
global::DripSharp.PdfCarton.Cos.COSString testSubj2 = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", textString));
this.writePDFTests(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("(", textString), ")")), testSubj2);
}

internal virtual void testUnicode() {
string theString = "\u4E16";
global::DripSharp.PdfCarton.Cos.COSString @string = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", theString));
global::DripSharp.Testing.JavaAssertions.Equal(@string.GetString(), theString, null);
string textAscii = "This is some regular text. It should all be expressible in ASCII";
string text8Bit = "En fran\u00E7ais o\u00F9 les choses sont accentu\u00E9s. En espa\u00F1ol, as\u00ED";
string textHighBits = "\u3092\u30AF\u30EA\u30C3\u30AF\u3057\u3066\u304F";
global::DripSharp.PdfCarton.Cos.COSString stringAscii = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", textAscii));
global::DripSharp.Testing.JavaAssertions.Equal(stringAscii.GetString(), textAscii, null);
global::DripSharp.PdfCarton.Cos.COSString string8Bit = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", text8Bit));
global::DripSharp.Testing.JavaAssertions.Equal(string8Bit.GetString(), text8Bit, null);
global::DripSharp.PdfCarton.Cos.COSString stringHighBits = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", textHighBits));
global::DripSharp.Testing.JavaAssertions.Equal(stringHighBits.GetString(), textHighBits, null);
global::DripSharp.Testing.JavaAssertions.Equal(textAscii, global::DripSharp.Runtime.JavaCompat.NewString(stringAscii.GetBytes(), global::DripSharp.Runtime.JavaStandardCharsets.ISO88591), null);
global::DripSharp.Testing.JavaAssertions.Equal(text8Bit, global::DripSharp.Runtime.JavaCompat.NewString(string8Bit.GetBytes(), global::DripSharp.Runtime.JavaStandardCharsets.ISO88591), null);
global::DripSharp.Testing.JavaAssertions.Equal(textHighBits, global::DripSharp.Runtime.JavaCompat.NewString(stringHighBits.GetBytes(), global::DripSharp.PdfCarton.Tests.Support.EncodingByName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "UnicodeBig"))), null);
global::DripSharp.Runtime.JavaByteArrayOutputStream @out = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
global::DripSharp.PdfCarton.Pdfwriter.COSWriter.WriteString(stringAscii, @out);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("(", textAscii), ")"), global::DripSharp.Runtime.JavaCompat.NewString(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(@out), global::DripSharp.PdfCarton.Tests.Support.EncodingByName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ASCII"))), null);
global::DripSharp.Runtime.JavaCompat.ResetMemoryStream(@out);
global::DripSharp.PdfCarton.Pdfwriter.COSWriter.WriteString(string8Bit, @out);
global::System.Text.StringBuilder hex = new global::System.Text.StringBuilder();
foreach (char c__229_18 in text8Bit.ToCharArray()) {
hex.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.ToHexString((int)(c__229_18)).ToUpper()));
}
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<", hex.ToString()), ">"), global::DripSharp.Runtime.JavaCompat.NewString(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(@out), global::DripSharp.PdfCarton.Tests.Support.EncodingByName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ASCII"))), null);
global::DripSharp.Runtime.JavaCompat.ResetMemoryStream(@out);
global::DripSharp.PdfCarton.Pdfwriter.COSWriter.WriteString(stringHighBits, @out);
hex = new global::System.Text.StringBuilder();
hex.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "FEFF"));
foreach (char c__239_18 in textHighBits.ToCharArray()) {
hex.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.ToHexString((int)(c__239_18)).ToUpper()));
}
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<", hex.ToString()), ">"), global::DripSharp.Runtime.JavaCompat.NewString(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(@out), global::DripSharp.PdfCarton.Tests.Support.EncodingByName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ASCII"))), null);
}

internal override void testAccept() {
global::DripSharp.Runtime.JavaByteArrayOutputStream outStream = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
global::DripSharp.PdfCarton.Cos.ICOSVisitor visitor = new global::DripSharp.PdfCarton.Pdfwriter.COSWriter(outStream);
global::DripSharp.PdfCarton.Cos.COSString testSubj = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING));
testSubj.Accept(visitor);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("(", global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING_PDF_FORMAT), ")"), global::DripSharp.PdfCarton.Tests.Support.OutputText(outStream), null);
global::DripSharp.Runtime.JavaCompat.ResetMemoryStream(outStream);
testSubj.SetForceHexForm(true);
testSubj.Accept(visitor);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<", this.createHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Cos.TestCOSString.ESC_CHAR_STRING))), ">"), global::DripSharp.PdfCarton.Tests.Support.OutputText(outStream), null);
}

internal virtual void testEquals() {
for (int i = 0; (i < 10); i++) {
global::DripSharp.PdfCarton.Cos.COSString x1 = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test"));
global::DripSharp.Testing.JavaAssertions.Equal(x1, x1, null);
global::DripSharp.PdfCarton.Cos.COSString y1 = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test"));
global::DripSharp.Testing.JavaAssertions.Equal(x1, y1, null);
global::DripSharp.Testing.JavaAssertions.Equal(y1, x1, null);
global::DripSharp.PdfCarton.Cos.COSString x2 = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test"));
x2.SetForceHexForm(true);
global::DripSharp.Testing.JavaAssertions.NotEqual(x1, x2, null);
global::DripSharp.Testing.JavaAssertions.NotEqual(x2, x1, null);
global::DripSharp.PdfCarton.Cos.COSString z1 = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test"));
global::DripSharp.Testing.JavaAssertions.Equal(x1, y1, null);
global::DripSharp.Testing.JavaAssertions.Equal(y1, z1, null);
global::DripSharp.Testing.JavaAssertions.Equal(x1, z1, null);
global::DripSharp.Testing.JavaAssertions.Equal(x1, y1, null);
global::DripSharp.Testing.JavaAssertions.NotEqual(y1, x2, null);
global::DripSharp.Testing.JavaAssertions.NotEqual(x1, x2, null);
}
}

internal virtual void testHashCode() {
global::DripSharp.PdfCarton.Cos.COSString str1 = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test1"));
global::DripSharp.PdfCarton.Cos.COSString str2 = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test2"));
global::DripSharp.Testing.JavaAssertions.NotEqual(str1.GetHashCode(), str2.GetHashCode(), null);
global::DripSharp.PdfCarton.Cos.COSString str3 = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test1"));
global::DripSharp.Testing.JavaAssertions.Equal(str1.GetHashCode(), str3.GetHashCode(), null);
str3.SetForceHexForm(true);
global::DripSharp.Testing.JavaAssertions.NotEqual(str1.GetHashCode(), str3.GetHashCode(), null);
}

internal virtual void testCompareFromHexString() {
global::DripSharp.PdfCarton.Cos.COSString test1 = global::DripSharp.PdfCarton.Cos.COSString.ParseHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "000000FF000000"));
global::DripSharp.PdfCarton.Cos.COSString test2 = global::DripSharp.PdfCarton.Cos.COSString.ParseHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "000000FF00FFFF"));
global::DripSharp.Testing.JavaAssertions.Equal(test1, test1, null);
global::DripSharp.Testing.JavaAssertions.Equal(test2, test2, null);
global::DripSharp.Testing.JavaAssertions.NotEqual(test1.ToHexString(), test2.ToHexString(), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.ArrayEquals(test1.GetBytes(), test2.GetBytes()), null);
global::DripSharp.Testing.JavaAssertions.NotEqual(test1, test2, null);
global::DripSharp.Testing.JavaAssertions.NotEqual(test2, test1, null);
global::DripSharp.Testing.JavaAssertions.NotEqual(test1.GetString(), test2.GetString(), null);
}

internal virtual void testEmptyStringWithBOM() {
global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.PdfCarton.Cos.COSString.ParseHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "FEFF")).GetString().Length == 0), null);
global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.PdfCarton.Cos.COSString.ParseHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "FFFE")).GetString().Length == 0), null);
}

[Xunit.Fact]
public void __Upstream_3343757370_aadb805439fac285()
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
public void __Upstream_3244765519_bc34f52e6ff227b0()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCompareFromHexString();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2927605166_ef0667dc91c1e64d()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testEmptyStringWithBOM();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3471735537_7d1ae62308fc58cc()
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
public void __Upstream_1160533535_b8ca56ade2412234()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testFromHex();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0516906343_9f33160d43d4d15f()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testGetBytes();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3571534498_d8d600a150d70016()
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
public void __Upstream_3517857559_b5d6699a755fb069()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testGetHex();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3621216917_a27761c59f45e1f2()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testGetString();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3009520333_8367b382f7af8cc5()
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
public void __Upstream_2816239855_dfc2982b715381a7()
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
public void __Upstream_4102662963_060316df1788805d()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testSetForceHexLiteralForm();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1467868651_e9127b1ce7b73823()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testUnicode();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1015337797_e1b98251b888c297()
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
