// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.IO;

public class RandomAccessReadWriteBufferTest {
private const int NUM_ITERATIONS = 3;

internal virtual void testClose() {
global::DripSharp.PdfCarton.IO.RandomAccess randomAccessReadWrite = new global::DripSharp.PdfCarton.IO.RandomAccessReadWriteBuffer();
randomAccessReadWrite.Write(new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)) });
global::DripSharp.Testing.JavaAssertions.False(randomAccessReadWrite.IsClosed(), null);
randomAccessReadWrite.Dispose();
global::DripSharp.Testing.JavaAssertions.True(randomAccessReadWrite.IsClosed(), null);
}

internal virtual void testClear() {
using (global::DripSharp.PdfCarton.IO.RandomAccess randomAccessReadWrite = new global::DripSharp.PdfCarton.IO.RandomAccessReadWriteBuffer(4)) {
randomAccessReadWrite.Write(new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)), unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)), unchecked((sbyte)(10)) });
global::DripSharp.Testing.JavaAssertions.Equal((long)(10), randomAccessReadWrite.Length(), null);
global::DripSharp.Testing.JavaAssertions.Equal((long)(10), randomAccessReadWrite.GetPosition(), null);
randomAccessReadWrite.Clear();
global::DripSharp.Testing.JavaAssertions.False(randomAccessReadWrite.IsClosed(), null);
global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessReadWrite.Length(), null);
global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessReadWrite.GetPosition(), null);
}
}

internal virtual void testLengthWriteByte() {
using (global::DripSharp.PdfCarton.IO.RandomAccess randomAccessReadWrite = new global::DripSharp.PdfCarton.IO.RandomAccessReadWriteBuffer()) {
global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessReadWrite.Length(), null);
randomAccessReadWrite.Write(1);
randomAccessReadWrite.Write(2);
randomAccessReadWrite.Write(3);
global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessReadWrite.Length(), null);
}
}

internal virtual void testLengthWriteBytes() {
using (global::DripSharp.PdfCarton.IO.RandomAccess randomAccessReadWrite = new global::DripSharp.PdfCarton.IO.RandomAccessReadWriteBuffer()) {
global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessReadWrite.Length(), null);
randomAccessReadWrite.Write(new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)), unchecked((sbyte)(6)), unchecked((sbyte)(7)) });
global::DripSharp.Testing.JavaAssertions.Equal((long)(7), randomAccessReadWrite.Length(), null);
randomAccessReadWrite.Write(new sbyte[] { unchecked((sbyte)(8)), unchecked((sbyte)(9)), unchecked((sbyte)(10)), unchecked((sbyte)(11)) });
global::DripSharp.Testing.JavaAssertions.Equal((long)(11), randomAccessReadWrite.Length(), null);
}
}

internal virtual void testPaging() {
using (global::DripSharp.PdfCarton.IO.RandomAccess randomAccessReadWrite = new global::DripSharp.PdfCarton.IO.RandomAccessReadWriteBuffer(5)) {
global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessReadWrite.Length(), null);
randomAccessReadWrite.Write(new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)), unchecked((sbyte)(6)), unchecked((sbyte)(7)) });
global::DripSharp.Testing.JavaAssertions.Equal((long)(7), randomAccessReadWrite.Length(), null);
randomAccessReadWrite.Write(new sbyte[] { unchecked((sbyte)(8)), unchecked((sbyte)(9)), unchecked((sbyte)(10)), unchecked((sbyte)(11)) });
global::DripSharp.Testing.JavaAssertions.Equal((long)(11), randomAccessReadWrite.Length(), null);
}
}

internal virtual void testRandomAccessRead() {
using (global::DripSharp.PdfCarton.IO.RandomAccess randomAccessReadWrite = new global::DripSharp.PdfCarton.IO.RandomAccessReadWriteBuffer()) {
randomAccessReadWrite.Write(new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)), unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)), unchecked((sbyte)(10)), unchecked((sbyte)(11)) });
global::DripSharp.Testing.JavaAssertions.Equal((long)(11), randomAccessReadWrite.Length(), null);
randomAccessReadWrite.Seek((long)(0));
global::DripSharp.Testing.JavaAssertions.Equal((long)(11), randomAccessReadWrite.Length(), null);
sbyte[] bytesRead = new sbyte[11];
global::DripSharp.Testing.JavaAssertions.Equal(11, ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessReadWrite))).Read(bytesRead), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, (int)(bytesRead[0]), null);
global::DripSharp.Testing.JavaAssertions.Equal(7, (int)(bytesRead[6]), null);
global::DripSharp.Testing.JavaAssertions.Equal(8, (int)(bytesRead[7]), null);
global::DripSharp.Testing.JavaAssertions.Equal(11, (int)(bytesRead[10]), null);
}
}

internal virtual void testEOFBugInSeek() {
using (global::DripSharp.PdfCarton.IO.RandomAccess randomAccessRwedWrite = new global::DripSharp.PdfCarton.IO.RandomAccessReadWriteBuffer()) {
sbyte[] bytes = new sbyte[global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.DefaultChunkSize4kb];
for (int i = 0; (i < global::DripSharp.PdfCarton.IO.RandomAccessReadWriteBufferTest.NUM_ITERATIONS); i++) {
long p0 = randomAccessRwedWrite.GetPosition();
randomAccessRwedWrite.Write(bytes);
long p1 = randomAccessRwedWrite.GetPosition();
global::DripSharp.Testing.JavaAssertions.Equal((long)(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.DefaultChunkSize4kb), (p1 - p0), null);
randomAccessRwedWrite.Write(bytes);
long p2 = randomAccessRwedWrite.GetPosition();
global::DripSharp.Testing.JavaAssertions.Equal((long)(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.DefaultChunkSize4kb), (p2 - p1), null);
randomAccessRwedWrite.Seek((long)(0));
randomAccessRwedWrite.Seek((long)(((i * 2) * global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.DefaultChunkSize4kb)));
}
}
}

internal virtual void testBufferLength() {
using (global::DripSharp.PdfCarton.IO.RandomAccess randomAccessReadWrite = new global::DripSharp.PdfCarton.IO.RandomAccessReadWriteBuffer()) {
sbyte[] bytes = new sbyte[global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.DefaultChunkSize4kb];
randomAccessReadWrite.Write(bytes);
global::DripSharp.Testing.JavaAssertions.Equal((long)(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.DefaultChunkSize4kb), randomAccessReadWrite.Length(), null);
}
}

internal virtual void testBufferSeek() {
using (global::DripSharp.PdfCarton.IO.RandomAccess randomAccessReadWrite = new global::DripSharp.PdfCarton.IO.RandomAccessReadWriteBuffer()) {
sbyte[] bytes = new sbyte[global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.DefaultChunkSize4kb];
randomAccessReadWrite.Write(bytes);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => randomAccessReadWrite.Seek((long)(-1)), null);
}
}

internal virtual void testBufferEOF() {
using (global::DripSharp.PdfCarton.IO.RandomAccess randomAccessReadWrite = new global::DripSharp.PdfCarton.IO.RandomAccessReadWriteBuffer()) {
sbyte[] bytes = new sbyte[global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.DefaultChunkSize4kb];
randomAccessReadWrite.Write(bytes);
randomAccessReadWrite.Seek((long)(0));
global::DripSharp.Testing.JavaAssertions.False(randomAccessReadWrite.IsEOF(), null);
randomAccessReadWrite.Seek((long)(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.DefaultChunkSize4kb));
global::DripSharp.Testing.JavaAssertions.True(randomAccessReadWrite.IsEOF(), null);
}
}

internal virtual void testAlreadyClose() {
using (global::DripSharp.PdfCarton.IO.RandomAccess randomAccessReadWrite = new global::DripSharp.PdfCarton.IO.RandomAccessReadWriteBuffer()) {
sbyte[] bytes = new sbyte[global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.DefaultChunkSize4kb];
randomAccessReadWrite.Write(bytes);
randomAccessReadWrite.Dispose();
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => randomAccessReadWrite.Seek((long)(0)), null);
}
}

[Xunit.Fact]
public void __Upstream_2559771186_da842f384b1a4d7a()
{
        try
        {
            this.testAlreadyClose();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2878664746_d480391b2c873558()
{
        try
        {
            this.testBufferEOF();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0911464696_ed55b5e9aa5e0ba9()
{
        try
        {
            this.testBufferLength();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3339700490_4cac0c9f45ce9c37()
{
        try
        {
            this.testBufferSeek();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0941264091_f95b617b31b20a0e()
{
        try
        {
            this.testClear();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0941274246_8d404e4487336801()
{
        try
        {
            this.testClose();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0069909735_5b6dfd1ffea2c74d()
{
        try
        {
            this.testEOFBugInSeek();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3902958159_c2d8d0741964c8ac()
{
        try
        {
            this.testLengthWriteByte();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0732618756_6c6270a4d8f0cb06()
{
        try
        {
            this.testLengthWriteBytes();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3771470526_a15fe758e51f2f07()
{
        try
        {
            this.testPaging();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3884728047_1e54b5ba13f58c72()
{
        try
        {
            this.testRandomAccessRead();
        }
        finally
        {
        }
}
}
