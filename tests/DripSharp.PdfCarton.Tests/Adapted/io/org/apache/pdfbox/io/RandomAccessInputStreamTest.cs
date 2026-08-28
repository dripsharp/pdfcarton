// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.IO;

public class RandomAccessInputStreamTest {
  internal virtual void testPositionSkip() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.RandomAccessInputStream randomAccessInputStream
      = new global::DripSharp.PdfCarton.IO.RandomAccessInputStream(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(bais))) {
      global::DripSharp.Testing.JavaAssertions.Equal(11, randomAccessInputStream.Available(), null);
      randomAccessInputStream.Skip((long)(5));
      global::DripSharp.Testing.JavaAssertions.Equal(5, randomAccessInputStream.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(5, randomAccessInputStream.Available(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0),
        randomAccessInputStream.Skip((long)(-10)), null);
    }
  }

  internal virtual void testPositionRead() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.RandomAccessInputStream randomAccessInputStream
      = new global::DripSharp.PdfCarton.IO.RandomAccessInputStream(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(bais))) {
      global::DripSharp.Testing.JavaAssertions.Equal(11, randomAccessInputStream.Available(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(0, randomAccessInputStream.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(1, randomAccessInputStream.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(2, randomAccessInputStream.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(8, randomAccessInputStream.Available(), null);
    }
  }

  internal virtual void testSeekEOF() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.RandomAccessInputStream randomAccessInputStream
      = new global::DripSharp.PdfCarton.IO.RandomAccessInputStream(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(bais))) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)(12),
        randomAccessInputStream.Skip((long)((inputValues.Length + 1))), null);
      global::DripSharp.Testing.JavaAssertions.Equal(0, randomAccessInputStream.Available(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(-1, randomAccessInputStream.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(-1, randomAccessInputStream.Read(new sbyte[1],
        0, 1), null);
    }
  }

  internal virtual void testPositionReadBytes() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.RandomAccessInputStream randomAccessInputStream
      = new global::DripSharp.PdfCarton.IO.RandomAccessInputStream(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(bais))) {
      global::DripSharp.Testing.JavaAssertions.Equal(11, randomAccessInputStream.Available(), null);
      sbyte[] buffer = new sbyte[4];
      global::DripSharp.Runtime.JavaCompat.InputStreamRead(randomAccessInputStream, buffer);
      global::DripSharp.Testing.JavaAssertions.Equal(0, (int)(buffer[0]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(3, (int)(buffer[3]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(7, randomAccessInputStream.Available(), null);
      randomAccessInputStream.Read(buffer, 1, 2);
      global::DripSharp.Testing.JavaAssertions.Equal(0, (int)(buffer[0]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(4, (int)(buffer[1]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(5, (int)(buffer[2]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(3, (int)(buffer[3]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(5, randomAccessInputStream.Available(), null);
    }
  }

  internal virtual void testEmptyBuffer() {
    using (global::DripSharp.PdfCarton.IO.RandomAccessInputStream randomAccessInputStream
      = new global::DripSharp.PdfCarton.IO.RandomAccessInputStream(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(new global::DripSharp.Runtime.JavaByteArrayOutputStream())))) {
      global::DripSharp.Testing.JavaAssertions.Equal(-1, randomAccessInputStream.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(-1,
        global::DripSharp.Runtime.JavaCompat.InputStreamRead(randomAccessInputStream, new sbyte[6]),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(0, randomAccessInputStream.Available(), null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_2184989691_3bca7954d48bf27c() {
    try {
      this.testEmptyBuffer();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212572689_3f41c3b988087afd() {
    try {
      this.testPositionRead();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0136067802_43d3462c7661f2ca() {
    try {
      this.testPositionReadBytes();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212608506_1dec748414831e55() {
    try {
      this.testPositionSkip();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3726669426_83bdc945d1189352() {
    try {
      this.testSeekEOF();
    } finally {
    }
  }
}
