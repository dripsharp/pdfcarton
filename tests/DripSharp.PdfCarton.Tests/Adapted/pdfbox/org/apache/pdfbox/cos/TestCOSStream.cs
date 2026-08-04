// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Cos;

public class TestCOSStream {
internal virtual void testUncompressedStreamEncode() {
sbyte[] testString = global::DripSharp.Runtime.JavaCompat.StringGetBytes("This is a test string to be used as input for TestCOSStream", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.Cos.COSStream stream = this.createStream(testString, (global::DripSharp.PdfCarton.Cos.COSBase)default!);
this.validateEncoded(stream, testString);
}

internal virtual void testUncompressedStreamDecode() {
sbyte[] testString = global::DripSharp.Runtime.JavaCompat.StringGetBytes("This is a test string to be used as input for TestCOSStream", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.Cos.COSStream stream = this.createStream(testString, (global::DripSharp.PdfCarton.Cos.COSBase)default!);
this.validateDecoded(stream, testString);
}

internal virtual void testCompressedStream1Encode() {
sbyte[] testString = global::DripSharp.Runtime.JavaCompat.StringGetBytes("This is a test string to be used as input for TestCOSStream", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
sbyte[] testStringEncoded = this.encodeData(testString, global::DripSharp.PdfCarton.Cos.COSName.FlateDecode);
global::DripSharp.PdfCarton.Cos.COSStream stream = this.createStream(testString, global::DripSharp.PdfCarton.Cos.COSName.FlateDecode);
this.validateEncoded(stream, testStringEncoded);
}

internal virtual void testCompressedStream1Decode() {
sbyte[] testString = global::DripSharp.Runtime.JavaCompat.StringGetBytes("This is a test string to be used as input for TestCOSStream", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
sbyte[] testStringEncoded = this.encodeData(testString, global::DripSharp.PdfCarton.Cos.COSName.FlateDecode);
global::DripSharp.PdfCarton.Cos.COSStream stream = new global::DripSharp.PdfCarton.Cos.COSStream();
using (global::System.IO.Stream output = stream.CreateRawOutputStream()) {
global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(output, testStringEncoded);
}
stream.SetItem(global::DripSharp.PdfCarton.Cos.COSName.Filter, global::DripSharp.PdfCarton.Cos.COSName.FlateDecode);
this.validateDecoded(stream, testString);
}

internal virtual void testCompressedStream2Encode() {
sbyte[] testString = global::DripSharp.Runtime.JavaCompat.StringGetBytes("This is a test string to be used as input for TestCOSStream", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
sbyte[] testStringEncoded = this.encodeData(testString, global::DripSharp.PdfCarton.Cos.COSName.FlateDecode);
testStringEncoded = this.encodeData(testStringEncoded, global::DripSharp.PdfCarton.Cos.COSName.Ascii85Decode);
global::DripSharp.PdfCarton.Cos.COSArray filters = new global::DripSharp.PdfCarton.Cos.COSArray();
filters.Add(global::DripSharp.PdfCarton.Cos.COSName.Ascii85Decode);
filters.Add(global::DripSharp.PdfCarton.Cos.COSName.FlateDecode);
global::DripSharp.PdfCarton.Cos.COSStream stream = this.createStream(testString, filters);
this.validateEncoded(stream, testStringEncoded);
}

internal virtual void testCompressedStream2Decode() {
sbyte[] testString = global::DripSharp.Runtime.JavaCompat.StringGetBytes("This is a test string to be used as input for TestCOSStream", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
sbyte[] testStringEncoded = this.encodeData(testString, global::DripSharp.PdfCarton.Cos.COSName.FlateDecode);
testStringEncoded = this.encodeData(testStringEncoded, global::DripSharp.PdfCarton.Cos.COSName.Ascii85Decode);
global::DripSharp.PdfCarton.Cos.COSStream stream = new global::DripSharp.PdfCarton.Cos.COSStream();
global::DripSharp.PdfCarton.Cos.COSArray filters = new global::DripSharp.PdfCarton.Cos.COSArray();
filters.Add(global::DripSharp.PdfCarton.Cos.COSName.Ascii85Decode);
filters.Add(global::DripSharp.PdfCarton.Cos.COSName.FlateDecode);
stream.SetItem(global::DripSharp.PdfCarton.Cos.COSName.Filter, filters);
using (global::System.IO.Stream output = stream.CreateRawOutputStream()) {
global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(output, testStringEncoded);
}
this.validateDecoded(stream, testString);
}

internal virtual void testCompressedStreamDoubleClose() {
sbyte[] testString = global::DripSharp.Runtime.JavaCompat.StringGetBytes("This is a test string to be used as input for TestCOSStream", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
sbyte[] testStringEncoded = this.encodeData(testString, global::DripSharp.PdfCarton.Cos.COSName.FlateDecode);
global::DripSharp.PdfCarton.Cos.COSStream stream = new global::DripSharp.PdfCarton.Cos.COSStream();
global::System.IO.Stream output = stream.CreateOutputStream(global::DripSharp.PdfCarton.Cos.COSName.FlateDecode);
global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(output, testString);
output.Dispose();
output.Dispose();
this.validateEncoded(stream, testStringEncoded);
}

internal virtual void testHasStreamData() {
using (global::DripSharp.PdfCarton.Cos.COSStream stream = new global::DripSharp.PdfCarton.Cos.COSStream()) {
global::DripSharp.Testing.JavaAssertions.False(stream.HasData(), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => { stream.CreateInputStream(); }, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "createInputStream should have thrown an IOException"));
sbyte[] testString = global::DripSharp.Runtime.JavaCompat.StringGetBytes("This is a test string to be used as input for TestCOSStream", global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
using (global::System.IO.Stream output = stream.CreateOutputStream()) {
global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(output, testString);
}
global::DripSharp.Testing.JavaAssertions.True(stream.HasData(), null);
}
}

private sbyte[] encodeData(sbyte[] original, global::DripSharp.PdfCarton.Cos.COSName filter) {
global::DripSharp.PdfCarton.Filter.Filter encodingFilter = global::DripSharp.PdfCarton.Filter.FilterFactory.Instance.GetFilter(filter);
global::DripSharp.Runtime.JavaByteArrayOutputStream encoded = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
encodingFilter.Encode(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(original), encoded, new global::DripSharp.PdfCarton.Cos.COSDictionary(), 0);
return global::DripSharp.Runtime.JavaCompat.ToSignedBytes(encoded);
}

private global::DripSharp.PdfCarton.Cos.COSStream createStream(sbyte[] testString, global::DripSharp.PdfCarton.Cos.COSBase filters) {
global::DripSharp.PdfCarton.Cos.COSStream stream = new global::DripSharp.PdfCarton.Cos.COSStream();
using (global::System.IO.Stream output = stream.CreateOutputStream(filters)) {
global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(output, testString);
}
return stream;
}

private void validateEncoded(global::DripSharp.PdfCarton.Cos.COSStream stream, sbyte[] expected) {
sbyte[] decoded = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(stream.CreateRawInputStream());
stream.Dispose();
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ArrayEquals(expected, decoded), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Encoded data doesn't match input"));
}

private void validateDecoded(global::DripSharp.PdfCarton.Cos.COSStream stream, sbyte[] expected) {
sbyte[] encoded = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(stream.CreateInputStream());
stream.Dispose();
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ArrayEquals(expected, encoded), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Decoded data doesn't match input"));
}

[Xunit.Fact]
public void __Upstream_0498018060_2ccd3e62346c7ea7()
{
        try
        {
            this.testCompressedStream1Decode();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0534958900_5b2f204acf282353()
{
        try
        {
            this.testCompressedStream1Encode();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1385521741_4f970dfc7235e8a1()
{
        try
        {
            this.testCompressedStream2Decode();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1422462581_8fc9063e3e3270b8()
{
        try
        {
            this.testCompressedStream2Encode();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0662149012_7f7e03ccb818d40d()
{
        try
        {
            this.testCompressedStreamDoubleClose();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3540963858_30ccedcb7446139a()
{
        try
        {
            this.testHasStreamData();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2320984122_a1e511bd3e47aeb6()
{
        try
        {
            this.testUncompressedStreamDecode();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2357924962_6baf56f097182399()
{
        try
        {
            this.testUncompressedStreamEncode();
        }
        finally
        {
        }
}
}
