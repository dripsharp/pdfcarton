// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf;

public class RandomAccessReadBufferDataStreamTest {
internal virtual void testEOF() {
sbyte[] byteArray = new sbyte[10];
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessReadBuffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(byteArray);
using (global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream dataStream = new global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream(randomAccessReadBuffer)) {
int value = dataStream.Read();
while ((value > -1)) {
value = global::DripSharp.Runtime.JavaCompat.UnboxObject<int>(global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => dataStream.Read(), null));
}
}
}

internal virtual void testEOFUnsignedShort() {
sbyte[] byteArray = new sbyte[3];
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessReadBuffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(byteArray);
using (global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream dataStream = new global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream(randomAccessReadBuffer)) {
dataStream.ReadUnsignedShort();
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.EndOfStreamException>(() => { dataStream.ReadUnsignedShort(); }, null);
}
}

internal virtual void testEOFUnsignedInt() {
sbyte[] byteArray = new sbyte[5];
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessReadBuffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(byteArray);
using (global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream dataStream = new global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream(randomAccessReadBuffer)) {
dataStream.ReadUnsignedInt();
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.EndOfStreamException>(() => { dataStream.ReadUnsignedInt(); }, null);
}
}

internal virtual void testEOFUnsignedByte() {
sbyte[] byteArray = new sbyte[2];
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessReadBuffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(byteArray);
using (global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream dataStream = new global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream(randomAccessReadBuffer)) {
dataStream.ReadUnsignedByte();
dataStream.ReadUnsignedByte();
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.EndOfStreamException>(() => { dataStream.ReadUnsignedByte(); }, null);
}
}

internal virtual void testDoubleClose() {
global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessRead = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "src/test/resources/ttf/LiberationSans-Regular.ttf"));
global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream randomAccessReadDataStream = new global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream(randomAccessRead);
randomAccessReadDataStream.Dispose();
global::DripSharp.Testing.JavaAssertions.DoesNotThrow(randomAccessReadDataStream.Dispose, null);
}

internal virtual void ensureReadFinishes() {
global::DripSharp.Runtime.JavaPath path = global::DripSharp.Runtime.JavaCompat.createTempFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "apache-pdfbox"), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", ".dat"));
using (global::System.IO.Stream outputStream = new global::System.IO.BufferedStream(global::DripSharp.Runtime.JavaCompat.NewOutputStream(path))) {
string content = "1234567890";
global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(outputStream, global::DripSharp.Runtime.JavaCompat.StringGetBytes(content, global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
outputStream.Flush();
}
sbyte[] readBuffer = new sbyte[2];
global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessRead = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(new global::System.IO.FileInfo(path));
using (global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream randomAccessReadDataStream = new global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream(randomAccessRead)) {
int amountRead;
int totalAmountRead = 0;
while (((amountRead = randomAccessReadDataStream.Read(readBuffer, 0, 2)) != -1)) {
totalAmountRead += amountRead;
}
global::DripSharp.Testing.JavaAssertions.Equal(10, totalAmountRead, null);
}
global::DripSharp.Runtime.JavaCompat.DeleteIfExists(path);
}

internal virtual void testReadBuffer() {
global::DripSharp.Runtime.JavaPath path = global::DripSharp.Runtime.JavaCompat.createTempFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "apache-pdfbox"), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", ".dat"));
using (global::System.IO.Stream outputStream = new global::System.IO.BufferedStream(global::DripSharp.Runtime.JavaCompat.NewOutputStream(path))) {
string content = "012345678A012345678B012345678C012345678D";
global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(outputStream, global::DripSharp.Runtime.JavaCompat.StringGetBytes(content, global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
outputStream.Flush();
}
global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessRead = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(new global::System.IO.FileInfo(path));
sbyte[] readBuffer = new sbyte[40];
using (global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream randomAccessReadDataStream = new global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream(randomAccessRead)) {
int count = 4;
int bytesRead = randomAccessReadDataStream.Read(readBuffer, 0, count);
global::DripSharp.Testing.JavaAssertions.Equal((long)(4), randomAccessReadDataStream.GetCurrentPosition(), null);
global::DripSharp.Testing.JavaAssertions.Equal(count, bytesRead, null);
global::DripSharp.Testing.JavaAssertions.Equal("0123", global::DripSharp.Runtime.JavaCompat.NewString(readBuffer, 0, count, global::System.Text.Encoding.UTF8), null);
count = 6;
bytesRead = randomAccessReadDataStream.Read(readBuffer, 0, count);
global::DripSharp.Testing.JavaAssertions.Equal((long)(10), randomAccessReadDataStream.GetCurrentPosition(), null);
global::DripSharp.Testing.JavaAssertions.Equal(count, bytesRead, null);
global::DripSharp.Testing.JavaAssertions.Equal("45678A", global::DripSharp.Runtime.JavaCompat.NewString(readBuffer, 0, count, global::System.Text.Encoding.UTF8), null);
count = 10;
bytesRead = randomAccessReadDataStream.Read(readBuffer, 0, count);
global::DripSharp.Testing.JavaAssertions.Equal((long)(20), randomAccessReadDataStream.GetCurrentPosition(), null);
global::DripSharp.Testing.JavaAssertions.Equal(count, bytesRead, null);
global::DripSharp.Testing.JavaAssertions.Equal("012345678B", global::DripSharp.Runtime.JavaCompat.NewString(readBuffer, 0, count, global::System.Text.Encoding.UTF8), null);
count = 10;
bytesRead = randomAccessReadDataStream.Read(readBuffer, 0, count);
global::DripSharp.Testing.JavaAssertions.Equal((long)(30), randomAccessReadDataStream.GetCurrentPosition(), null);
global::DripSharp.Testing.JavaAssertions.Equal(count, bytesRead, null);
global::DripSharp.Testing.JavaAssertions.Equal("012345678C", global::DripSharp.Runtime.JavaCompat.NewString(readBuffer, 0, count, global::System.Text.Encoding.UTF8), null);
count = 10;
bytesRead = randomAccessReadDataStream.Read(readBuffer, 0, count);
global::DripSharp.Testing.JavaAssertions.Equal((long)(40), randomAccessReadDataStream.GetCurrentPosition(), null);
global::DripSharp.Testing.JavaAssertions.Equal(count, bytesRead, null);
global::DripSharp.Testing.JavaAssertions.Equal("012345678D", global::DripSharp.Runtime.JavaCompat.NewString(readBuffer, 0, count, global::System.Text.Encoding.UTF8), null);
global::DripSharp.Testing.JavaAssertions.Equal(-1, randomAccessReadDataStream.Read(), null);
randomAccessReadDataStream.Seek((long)(0));
randomAccessReadDataStream.Read(readBuffer, 0, 7);
global::DripSharp.Testing.JavaAssertions.Equal((long)(7), randomAccessReadDataStream.GetCurrentPosition(), null);
count = 16;
bytesRead = randomAccessReadDataStream.Read(readBuffer, 0, count);
global::DripSharp.Testing.JavaAssertions.Equal((long)(23), randomAccessReadDataStream.GetCurrentPosition(), null);
global::DripSharp.Testing.JavaAssertions.Equal(count, bytesRead, null);
global::DripSharp.Testing.JavaAssertions.Equal("78A012345678B012", global::DripSharp.Runtime.JavaCompat.NewString(readBuffer, 0, count, global::System.Text.Encoding.UTF8), null);
bytesRead = randomAccessReadDataStream.Read(readBuffer, 0, 99);
global::DripSharp.Testing.JavaAssertions.Equal((long)(40), randomAccessReadDataStream.GetCurrentPosition(), null);
global::DripSharp.Testing.JavaAssertions.Equal(17, bytesRead, null);
global::DripSharp.Testing.JavaAssertions.Equal("345678C012345678D", global::DripSharp.Runtime.JavaCompat.NewString(readBuffer, 0, 17, global::System.Text.Encoding.UTF8), null);
global::DripSharp.Testing.JavaAssertions.Equal(-1, randomAccessReadDataStream.Read(), null);
randomAccessReadDataStream.Seek((long)(0));
randomAccessReadDataStream.Read(readBuffer, 0, 7);
global::DripSharp.Testing.JavaAssertions.Equal((long)(7), randomAccessReadDataStream.GetCurrentPosition(), null);
count = 23;
bytesRead = randomAccessReadDataStream.Read(readBuffer, 0, count);
global::DripSharp.Testing.JavaAssertions.Equal((long)(30), randomAccessReadDataStream.GetCurrentPosition(), null);
global::DripSharp.Testing.JavaAssertions.Equal(count, bytesRead, null);
global::DripSharp.Testing.JavaAssertions.Equal("78A012345678B012345678C", global::DripSharp.Runtime.JavaCompat.NewString(readBuffer, 0, count, global::System.Text.Encoding.UTF8), null);
randomAccessReadDataStream.Seek((long)(0));
randomAccessReadDataStream.Read(readBuffer, 0, 10);
global::DripSharp.Testing.JavaAssertions.Equal((long)(10), randomAccessReadDataStream.GetCurrentPosition(), null);
count = 23;
bytesRead = randomAccessReadDataStream.Read(readBuffer, 0, count);
global::DripSharp.Testing.JavaAssertions.Equal((long)(33), randomAccessReadDataStream.GetCurrentPosition(), null);
global::DripSharp.Testing.JavaAssertions.Equal(count, bytesRead, null);
global::DripSharp.Testing.JavaAssertions.Equal("012345678B012345678C012", global::DripSharp.Runtime.JavaCompat.NewString(readBuffer, 0, count, global::System.Text.Encoding.UTF8), null);
}
global::DripSharp.Runtime.JavaCompat.DeleteIfExists(path);
}

[Xunit.Fact]
public void __Upstream_1446185877_199165a55921b3e2()
{
        try
        {
            this.ensureReadFinishes();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4139147445_f40005b9d69344d3()
{
        try
        {
            this.testDoubleClose();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0725001994_11c58d0a82f1ba4e()
{
        try
        {
            this.testEOF();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0576943559_cdcadb0649e61e9e()
{
        try
        {
            this.testEOFUnsignedByte();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2928111440_536128569874f648()
{
        try
        {
            this.testEOFUnsignedInt();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0720570269_534cbb6baace8b2a()
{
        try
        {
            this.testEOFUnsignedShort();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0447144872_061b5a01bc5c4e1c()
{
        try
        {
            this.testReadBuffer();
        }
        finally
        {
        }
}
}
