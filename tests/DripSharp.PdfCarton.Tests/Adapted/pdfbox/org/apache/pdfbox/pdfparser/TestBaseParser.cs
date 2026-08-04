// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdfparser;

public class TestBaseParser {
internal virtual void testCheckForEndOfString() {
sbyte[] inputBytes = new sbyte[] { unchecked((sbyte)(40)), unchecked((sbyte)(84)), unchecked((sbyte)(101)), unchecked((sbyte)(115)), unchecked((sbyte)(116)), unchecked((sbyte)(41)) };
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.BaseParser baseParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSString cosString = baseParser.ParseCOSString();
global::DripSharp.Testing.JavaAssertions.Equal("Test", cosString.GetString(), null);
string output = "(Test";
inputBytes = new sbyte[] { unchecked((sbyte)('(')), unchecked((sbyte)('(')), unchecked((sbyte)('T')), unchecked((sbyte)('e')), unchecked((sbyte)('s')), unchecked((sbyte)('t')), unchecked((sbyte)(')')), unchecked((sbyte)(10)), unchecked((sbyte)('/')), unchecked((sbyte)(' ')) };
buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
baseParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
cosString = baseParser.ParseCOSString();
global::DripSharp.Testing.JavaAssertions.Equal(output, cosString.GetString(), null);
inputBytes = new sbyte[] { unchecked((sbyte)('(')), unchecked((sbyte)('(')), unchecked((sbyte)('T')), unchecked((sbyte)('e')), unchecked((sbyte)('s')), unchecked((sbyte)('t')), unchecked((sbyte)(')')), unchecked((sbyte)(13)), unchecked((sbyte)('/')), unchecked((sbyte)(' ')) };
buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
baseParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
cosString = baseParser.ParseCOSString();
global::DripSharp.Testing.JavaAssertions.Equal(output, cosString.GetString(), null);
inputBytes = new sbyte[] { unchecked((sbyte)('(')), unchecked((sbyte)('(')), unchecked((sbyte)('T')), unchecked((sbyte)('e')), unchecked((sbyte)('s')), unchecked((sbyte)('t')), unchecked((sbyte)(')')), unchecked((sbyte)(13)), unchecked((sbyte)(10)), unchecked((sbyte)('/')) };
buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
baseParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
cosString = baseParser.ParseCOSString();
global::DripSharp.Testing.JavaAssertions.Equal(output, cosString.GetString(), null);
inputBytes = new sbyte[] { unchecked((sbyte)('(')), unchecked((sbyte)('(')), unchecked((sbyte)('T')), unchecked((sbyte)('e')), unchecked((sbyte)('s')), unchecked((sbyte)('t')), unchecked((sbyte)(')')), unchecked((sbyte)(10)), unchecked((sbyte)('>')), unchecked((sbyte)(' ')) };
buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
baseParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
cosString = baseParser.ParseCOSString();
global::DripSharp.Testing.JavaAssertions.Equal(output, cosString.GetString(), null);
inputBytes = new sbyte[] { unchecked((sbyte)('(')), unchecked((sbyte)('(')), unchecked((sbyte)('T')), unchecked((sbyte)('e')), unchecked((sbyte)('s')), unchecked((sbyte)('t')), unchecked((sbyte)(')')), unchecked((sbyte)(13)), unchecked((sbyte)('>')), unchecked((sbyte)(' ')) };
buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
baseParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
cosString = baseParser.ParseCOSString();
global::DripSharp.Testing.JavaAssertions.Equal(output, cosString.GetString(), null);
inputBytes = new sbyte[] { unchecked((sbyte)('(')), unchecked((sbyte)('(')), unchecked((sbyte)('T')), unchecked((sbyte)('e')), unchecked((sbyte)('s')), unchecked((sbyte)('t')), unchecked((sbyte)(')')), unchecked((sbyte)(13)), unchecked((sbyte)(10)), unchecked((sbyte)('>')) };
buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
baseParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
cosString = baseParser.ParseCOSString();
global::DripSharp.Testing.JavaAssertions.Equal(output, cosString.GetString(), null);
}

internal virtual void testBaseParserStackOverflow() {
try {
using (global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdfparser.TestBaseParser), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-6041-example.pdf"))) {
global::DripSharp.PdfCarton.Loader.LoadPDF(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(@is)).Dispose();
}
} catch (global::System.IO.IOException exception) {
global::DripSharp.Testing.JavaAssertions.Equal("Missing root object specification in trailer.", global::DripSharp.Runtime.JavaCompat.ExceptionMessage(exception), null);
}
}

internal virtual void testTable4Example_Name1() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/Name1 ", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("Name1", name.GetName(), null);
}

internal virtual void testTable4Example_ASomewhatLongerName() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/ASomewhatLongerName ", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("ASomewhatLongerName", name.GetName(), null);
}

internal virtual void testTable4Example_WithSpecialCharacters() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/A;Name_With-Various***Characters? ", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("A;Name_With-Various***Characters?", name.GetName(), null);
}

internal virtual void testTable4Example_Numeric() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/1.2 ", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("1.2", name.GetName(), null);
}

internal virtual void testTable4Example_DollarSigns() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/$$ ", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("$$", name.GetName(), null);
}

internal virtual void testTable4Example_AtPattern() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/@pattern ", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("@pattern", name.GetName(), null);
}

internal virtual void testTable4Example_DotNotdef() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/#2Enotdef ", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal(".notdef", name.GetName(), null);
}

internal virtual void testTable4Example_HexEncodedSpace() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/lime#20Green ", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("lime Green", name.GetName(), null);
}

internal virtual void testTable4Example_HexEncodedParentheses() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/paired#28#29parentheses ", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("paired()parentheses", name.GetName(), null);
}

internal virtual void testTable4Example_HexEncodedNumberSign() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/The_Key_of_F#23_Minor ", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("The_Key_of_F#_Minor", name.GetName(), null);
}

internal virtual void testTable4Example_HexEncodedLetter() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/A#42 ", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("AB", name.GetName(), null);
}

internal virtual void testTable4Example_EmptyName() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/ ", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("", name.GetName(), null);
}

internal virtual void testNullCharacterTermination() {
sbyte[] inputBytes = new sbyte[] { unchecked((sbyte)('/')), unchecked((sbyte)('N')), unchecked((sbyte)('a')), unchecked((sbyte)('m')), unchecked((sbyte)('e')), unchecked((sbyte)(0)), unchecked((sbyte)('E')), unchecked((sbyte)('x')), unchecked((sbyte)('t')), unchecked((sbyte)('r')), unchecked((sbyte)('a')), unchecked((sbyte)(' ')) };
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("Name", name.GetName(), null);
}

internal virtual void testInvalidHexSequence() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/Name#GG ", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("Name#GG", name.GetName(), null);
}

internal virtual void testHexEscapeLowercase() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/Name#2fTest ", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("Name/Test", name.GetName(), null);
}

internal virtual void testHexEscapeUppercase() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/Name#2FTest ", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("Name/Test", name.GetName(), null);
}

internal virtual void testNameTerminationByDelimiters() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/Name1>", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("Name1", name.GetName(), null);
inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/Name2<", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("Name2", name.GetName(), null);
inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/Name3[", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("Name3", name.GetName(), null);
inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/Name4]", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("Name4", name.GetName(), null);
inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/Name5(", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("Name5", name.GetName(), null);
inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/Name6)", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("Name6", name.GetName(), null);
inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/Name7/", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("Name7", name.GetName(), null);
inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/Name8%", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("Name8", name.GetName(), null);
}

internal virtual void testASCIIRegularCharacters() {
sbyte[] inputBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("/!\"$'*+-._:;=@~^`|\\", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer buffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(inputBytes);
global::DripSharp.PdfCarton.Pdfparser.COSParser cosParser = new global::DripSharp.PdfCarton.Pdfparser.COSParser(buffer);
global::DripSharp.PdfCarton.Cos.COSName name = cosParser.ParseCOSName();
global::DripSharp.Testing.JavaAssertions.Equal("!\"$'*+-._:;=@~^`|\\", name.GetName(), null);
}

internal virtual void testUTF8InNames() {
string nameStr = "Test\u4E2D\u56FD";
sbyte[] nameBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes(nameStr, global::DripSharp.Runtime.JavaStandardCharsets.UTF8);
global::DripSharp.PdfCarton.Cos.COSName name = global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(nameBytes);
sbyte[] retrievedBytes = name.GetBytes();
string retrievedStr = global::DripSharp.Runtime.JavaCompat.NewString(retrievedBytes, global::DripSharp.Runtime.JavaStandardCharsets.UTF8);
global::DripSharp.Testing.JavaAssertions.Equal(nameStr, retrievedStr, null);
}

internal virtual void testNameCanonicaliation() {
sbyte[] bytes1 = global::DripSharp.Runtime.JavaCompat.StringGetBytes("TestName", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
sbyte[] bytes2 = global::DripSharp.Runtime.JavaCompat.StringGetBytes("TestName", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.Cos.COSName name1 = global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(bytes1);
global::DripSharp.PdfCarton.Cos.COSName name2 = global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(bytes2);
global::DripSharp.Testing.JavaAssertions.Equal(name1, name2, null);
}

[Xunit.Fact]
public void __Upstream_2950770439_d11dafb18686c48a()
{
        try
        {
            this.testASCIIRegularCharacters();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3287958856_5935615ab1151d2e()
{
        try
        {
            this.testBaseParserStackOverflow();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1882667888_54c723f6e6a644da()
{
        try
        {
            this.testCheckForEndOfString();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0936692167_e9940ce53d5eb656()
{
        try
        {
            this.testHexEscapeLowercase();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1674723048_5835bda32d5b3b66()
{
        try
        {
            this.testHexEscapeUppercase();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2620230071_6e685141d44267d5()
{
        try
        {
            this.testInvalidHexSequence();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0539618851_c3a327e63d19e0df()
{
        try
        {
            this.testNameCanonicaliation();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1405927722_a8e04503cc8dea16()
{
        try
        {
            this.testNameTerminationByDelimiters();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1413845748_ff1a26f49d79b6b9()
{
        try
        {
            this.testNullCharacterTermination();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2260655488_35a81ad478c436bf()
{
        try
        {
            this.testTable4Example_ASomewhatLongerName();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1316403376_4a33a46b04494175()
{
        try
        {
            this.testTable4Example_AtPattern();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1100046093_06195ea227b195ef()
{
        try
        {
            this.testTable4Example_DollarSigns();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1401678798_1dc225ccb6e41a9c()
{
        try
        {
            this.testTable4Example_DotNotdef();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2244531787_52dbf2b79fa50ff0()
{
        try
        {
            this.testTable4Example_EmptyName();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3884908358_830256a5a6e3d892()
{
        try
        {
            this.testTable4Example_HexEncodedLetter();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0461024198_63eac4c8da1f755e()
{
        try
        {
            this.testTable4Example_HexEncodedNumberSign();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1703484602_d4e272300da3dec2()
{
        try
        {
            this.testTable4Example_HexEncodedParentheses();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3595776486_449e911c5a8eeefa()
{
        try
        {
            this.testTable4Example_HexEncodedSpace();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2927757657_81418184070cbea2()
{
        try
        {
            this.testTable4Example_Name1();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0944178336_e7ad434fbce2d2b0()
{
        try
        {
            this.testTable4Example_Numeric();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2356712496_6a41750141972ade()
{
        try
        {
            this.testTable4Example_WithSpecialCharacters();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2803699840_b5fba31cb9aede53()
{
        try
        {
            this.testUTF8InNames();
        }
        finally
        {
        }
}
}
