// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.IO;

public class NonSeekableRandomAccessReadInputStreamTest {
  internal virtual void testPositionSkip() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream randomAccessSource
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais)) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
        null);
      randomAccessSource.Skip(5);
      global::DripSharp.Testing.JavaAssertions.Equal(5, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessSource.GetPosition(),
        null);
    }
  }

  internal virtual void testPositionRead() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream randomAccessSource
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais);
    global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(0, randomAccessSource.Read(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(1, randomAccessSource.Read(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(2, randomAccessSource.Read(), null);
    global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessSource.GetPosition(),
      null);
    global::DripSharp.Testing.JavaAssertions.False(randomAccessSource.IsClosed(), null);
    randomAccessSource.Dispose();
    global::DripSharp.Testing.JavaAssertions.True(randomAccessSource.IsClosed(), null);
  }

  internal virtual void testSeekEOF() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream randomAccessSource
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais)) {
      global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
        => randomAccessSource.Seek((long)(3)),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
        "seek should have thrown an IOException"));
    }
  }

  internal virtual void testPositionReadBytes() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream randomAccessSource
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais)) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
        null);
      sbyte[] buffer = new sbyte[4];
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource))).Read(buffer);
      global::DripSharp.Testing.JavaAssertions.Equal(0, (int)(buffer[0]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(3, (int)(buffer[3]), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(4), randomAccessSource.GetPosition(),
        null);
      randomAccessSource.Read(buffer, 1, 2);
      global::DripSharp.Testing.JavaAssertions.Equal(0, (int)(buffer[0]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(4, (int)(buffer[1]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(5, (int)(buffer[2]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(3, (int)(buffer[3]), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessSource.GetPosition(),
        null);
    }
  }

  internal virtual void testPositionPeek() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream randomAccessSource
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais)) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
        null);
      randomAccessSource.Skip(6);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessSource.GetPosition(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(6,
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Peek(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessSource.GetPosition(),
        null);
    }
  }

  internal virtual void testPositionUnreadBytes() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream randomAccessSource
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais)) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
        null);
      randomAccessSource.Read();
      randomAccessSource.Read();
      sbyte[] readBytes = new sbyte[6];
      global::DripSharp.Testing.JavaAssertions.Equal(readBytes.Length,
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource))).Read(readBytes),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(8), randomAccessSource.GetPosition(),
        null);
      randomAccessSource.Rewind(readBytes.Length);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(2), randomAccessSource.GetPosition(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(2, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessSource.GetPosition(),
        null);
      randomAccessSource.Read(readBytes, 2, 4);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(7), randomAccessSource.GetPosition(),
        null);
      randomAccessSource.Rewind(4);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessSource.GetPosition(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(3, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(4, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(5, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(6, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(7, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(8, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(9, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(10, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(-1, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.True(randomAccessSource.IsEOF(), null);
      randomAccessSource.Rewind(4);
      global::DripSharp.Testing.JavaAssertions.False(randomAccessSource.IsEOF(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(7, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(8, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(9, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(10, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(-1, randomAccessSource.Read(), null);
    }
  }

  internal virtual void testView() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream randomAccessSource
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais)) {
      global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
        => randomAccessSource.CreateView((long)(3), (long)(5)),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
        "createView should have thrown an IOException"));
    }
  }

  internal virtual void testBufferSwitch() {
    sbyte[] original = this.createRandomData();
    global::System.IO.MemoryStream byteArrayInputStream
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(original);
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead rar
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(byteArrayInputStream)) {
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(rar)).Skip(4098);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(4098), rar.GetPosition(), null);
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(rar)).Rewind(4);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(4094), rar.GetPosition(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((original[4094] & 255), rar.Read(), null);
    }
  }

  internal virtual void testRewindException() {
    global::System.IO.MemoryStream byteArrayInputStream
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(this.createRandomData());
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead rar
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(byteArrayInputStream)) {
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(rar)).Skip(10000);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(10000), rar.GetPosition(), null);
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(rar)).Rewind(4096);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(5904), rar.GetPosition(), null);
      global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
        => ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(rar)).Rewind(4096),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
        "createView should have thrown an IOException"));
    }
  }

  internal virtual void testRewindAcrossBuffers() {
    sbyte[] ba = new sbyte[(4096 + 5)];
    int rewSize = 7;
    sbyte testVal = unchecked((sbyte)(123));
    ba[(ba.Length - rewSize)] = unchecked((sbyte)(testVal));
    global::System.IO.MemoryStream bais = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(ba);
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead rar
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais)) {
      int len
        = ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(rar))).Read(new sbyte[(ba.Length
        - rewSize)]);
      global::DripSharp.Testing.JavaAssertions.Equal((ba.Length - rewSize), len, null);
      len
        = ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(rar))).Read(new sbyte[rewSize]);
      global::DripSharp.Testing.JavaAssertions.Equal(rewSize, len, null);
      int by = rar.Read();
      global::DripSharp.Testing.JavaAssertions.Equal(-1, by, null);
      global::DripSharp.Testing.JavaAssertions.True(rar.IsEOF(), null);
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(rar)).Rewind(len);
      by = rar.Read();
      global::DripSharp.Testing.JavaAssertions.Equal((int)(testVal), by, null);
    }
  }

  internal virtual void testRewindAcrossBuffers2() {
    sbyte[] ba = new sbyte[(4096 * 2)];
    ba[4095] = unchecked((sbyte)(1));
    ba[4096] = unchecked((sbyte)(2));
    ba[4097] = unchecked((sbyte)(3));
    ba[((4096 * 2) - 1)] = unchecked((sbyte)(4));
    global::System.IO.MemoryStream bais = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(ba);
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead rar
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais)) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)((4096 * 2)), rar.Length(), null);
      int len
        = ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(rar))).Read(new sbyte[(4096
        + 1)]);
      global::DripSharp.Testing.JavaAssertions.Equal((long)((4096 * 2)), rar.Length(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((4096 + 1), len, null);
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(rar)).Rewind(2);
      global::DripSharp.Testing.JavaAssertions.Equal(1, rar.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(2, rar.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(3, rar.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)((4096 * 2)), rar.Length(), null);
      sbyte[] buf = new sbyte[4096];
      len
        = ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(rar))).Read(buf);
      global::DripSharp.Testing.JavaAssertions.Equal((4096 - 2), len, null);
      global::DripSharp.Testing.JavaAssertions.Equal(4, (int)(buf[(len - 1)]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(-1, rar.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(-1,
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(rar))).Read(new sbyte[1]),
        null);
    }
  }

  internal virtual void testAccessClosed() {
    sbyte[] ba = new sbyte[1];
    ba[0] = unchecked((sbyte)(1));
    global::System.IO.MemoryStream bais = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(ba);
    global::DripSharp.PdfCarton.IO.RandomAccessRead rar
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais);
    global::DripSharp.Testing.JavaAssertions.Equal(1, rar.Read(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1, rar.Read(), null);
    rar.Dispose();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => { rar.Read(); }, global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "read() should have thrown an IOException"));
  }

  internal virtual void testClosedStreamMethods() {
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(new sbyte[] { unchecked((sbyte)(1)),
        unchecked((sbyte)(2)), unchecked((sbyte)(3)) });
    global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream rar
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais);
    rar.Dispose();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => { rar.Read(); }, global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "read() on closed stream should throw IOException"));
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => rar.Read(new sbyte[1], 0, 1), global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "read(byte[], int, int) on closed stream should throw IOException"));
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => rar.ReadFully(new sbyte[1], 0, 1), global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "readFully() on closed stream should throw IOException"));
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => { rar.GetPosition(); }, global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "getPosition() on closed stream should throw IOException"));
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => { rar.Available(); }, global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "available() on closed stream should throw IOException"));
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => { rar.Length(); }, global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "length() on closed stream should throw IOException"));
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => { rar.IsEOF(); }, global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "isEOF() on closed stream should throw IOException"));
  }

  internal virtual void testReadBytesParameterValidation() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream rar
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais)) {
      global::DripSharp.Testing.JavaAssertions.Throws<global::System.NullReferenceException>(()
        => rar.Read((sbyte[])default!, 0, 1),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
        "null buffer should throw NullPointerException"));
      sbyte[] buf = new sbyte[4];
      global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentOutOfRangeException>(()
        => rar.Read(buf, -1, 2), global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
        "negative offset should throw IndexOutOfBoundsException"));
      global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentOutOfRangeException>(()
        => rar.Read(buf, 0, -1), global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
        "negative length should throw IndexOutOfBoundsException"));
      global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentOutOfRangeException>(()
        => rar.Read(buf, 2, 4), global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
        "offset + length > buf.length should throw IndexOutOfBoundsException"));
      global::DripSharp.Testing.JavaAssertions.Equal(0, rar.Read(buf, 0, 0), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), rar.GetPosition(), null);
    }
  }

  internal virtual void testReadFully() {
    sbyte[] inputValues = new sbyte[10];
    for (int i__361_18 = 0; (i__361_18 < inputValues.Length); i__361_18++) {
      inputValues[i__361_18] = unchecked((sbyte)(unchecked((sbyte)(i__361_18))));
    }
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream rar
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais)) {
      sbyte[] buf = new sbyte[10];
      rar.ReadFully(buf, 0, 10);
      for (int i__371_22 = 0; (i__371_22 < 10); i__371_22++) {
        global::DripSharp.Testing.JavaAssertions.Equal(i__371_22, (int)(buf[i__371_22]), null);
      }
      global::DripSharp.Testing.JavaAssertions.Equal((long)(10), rar.GetPosition(), null);
    }
  }

  internal virtual void testReadFullyEOF() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream rar
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais)) {
      global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.EndOfStreamException>(()
        => rar.ReadFully(new sbyte[10], 0, 10),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
        "readFully() should throw EOFException when stream ends before length bytes"));
    }
  }

  internal virtual void testSkipPastEOF() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream rar
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais)) {
      rar.Skip(100);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(5), rar.GetPosition(), null);
      global::DripSharp.Testing.JavaAssertions.True(rar.IsEOF(), null);
    }
  }

  internal virtual void testAvailable() {
    sbyte[] inputValues = new sbyte[10];
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream rar
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais)) {
      global::DripSharp.Testing.JavaAssertions.Equal(10, rar.Available(), null);
      rar.Read();
      global::DripSharp.Testing.JavaAssertions.Equal(9, rar.Available(), null);
      while ((rar.Read() != -1)) {}
      global::DripSharp.Testing.JavaAssertions.Equal(0, rar.Available(), null);
    }
  }

  internal virtual void testLengthAfterFullConsumption() {
    sbyte[] inputValues = new sbyte[100];
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    using (global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream rar
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(bais)) {
      while ((rar.Read() != -1)) {}
      global::DripSharp.Testing.JavaAssertions.True(rar.IsEOF(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(100), rar.Length(), null);
    }
  }

  private sbyte[] createRandomData() {
    long seed = new global::DripSharp.PdfCarton.Tests.JavaRandom().NextLong();
    global::DripSharp.PdfCarton.Tests.JavaRandom random
      = new global::DripSharp.PdfCarton.Tests.JavaRandom(seed);
    int numBytes = (10000 + random.NextInt(20000));
    sbyte[] original = new sbyte[numBytes];
    int upto = 0;
    while ((upto < numBytes)) {
      int left = (numBytes - upto);
      if ((random.NextBoolean() || (left < 2))) {
        int end__472_27 = (upto + global::System.Math.Min(left, (10 + random.NextInt(100))));
        while ((upto < end__472_27)) {
          original[upto++] = unchecked((sbyte)(unchecked((sbyte)(random.NextInt()))));
        }
      } else {
        int end__481_27 = (upto + global::System.Math.Min(left, (2 + random.NextInt(10))));
        sbyte value = unchecked((sbyte)(unchecked((sbyte)(random.NextInt(4)))));
        while ((upto < end__481_27)) {
          original[upto++] = unchecked((sbyte)(value));
        }
      }
    }
    return original;
  }

  internal virtual void testPDFBOX5158() {
    global::DripSharp.Runtime.JavaPath path
      = global::DripSharp.Runtime.JavaCompat.createTempFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "len4096"), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", ".pdf"));
    using (global::System.IO.Stream os
      = global::DripSharp.Runtime.JavaCompat.NewOutputStream(path)) {
      global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(os, new sbyte[4096]);
    }
    global::DripSharp.Testing.JavaAssertions.Equal((long)(4096),
      new global::System.IO.FileInfo(path).Length, null);
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead rar
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(global::DripSharp.Runtime.JavaCompat.OpenInputStream(path))) {
      global::DripSharp.Testing.JavaAssertions.Equal(0, rar.Read(), null);
    }
    global::DripSharp.Runtime.JavaCompat.DeleteIfExists(path);
  }

  internal virtual void testPDFBOX5161() {
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead rar
      = new global::DripSharp.PdfCarton.IO.NonSeekableRandomAccessReadInputStream(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(new sbyte[4099]))) {
      sbyte[] buf = new sbyte[4096];
      int bytesRead
        = ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(rar))).Read(buf);
      global::DripSharp.Testing.JavaAssertions.Equal(4096, bytesRead, null);
      bytesRead = rar.Read(buf, 0, 3);
      global::DripSharp.Testing.JavaAssertions.Equal(3, bytesRead, null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_0430650786_7f62de105f63c456() {
    try {
      this.testAccessClosed();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2083285591_d4030f3c49b85fb6() {
    try {
      this.testAvailable();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1128355142_40cd8444f60c0f2a() {
    try {
      this.testBufferSwitch();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0294807572_944eaf05012ae50a() {
    try {
      this.testClosedStreamMethods();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0533907016_ec8b555ab7f81928() {
    try {
      this.testLengthAfterFullConsumption();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0778918762_a00754678b706cce() {
    try {
      this.testPDFBOX5158();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0778918786_3b236224784d734c() {
    try {
      this.testPDFBOX5161();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212513238_e5ff871f6141af0a() {
    try {
      this.testPositionPeek();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212572689_6991321ec0aa933b() {
    try {
      this.testPositionRead();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0136067802_3d650f6cd4f6b221() {
    try {
      this.testPositionReadBytes();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212608506_5b3f45526260fffe() {
    try {
      this.testPositionSkip();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1224508193_b9f65b2be6b924ec() {
    try {
      this.testPositionUnreadBytes();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4160618495_8ffe96de1539de9f() {
    try {
      this.testReadBytesParameterValidation();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1680692066_a985d8880e8c937e() {
    try {
      this.testReadFully();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3063637562_0b549dc1bf968bd8() {
    try {
      this.testReadFullyEOF();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2423878599_e9e4c2474c249f18() {
    try {
      this.testRewindAcrossBuffers();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2125792587_38d0cc648be7f159() {
    try {
      this.testRewindAcrossBuffers2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3547210466_e1b8bd6239a8b5ad() {
    try {
      this.testRewindException();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3726669426_1a8a10a075f14fdc() {
    try {
      this.testSeekEOF();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3434602777_9319339cefd7c62a() {
    try {
      this.testSkipPastEOF();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1000757847_a7a1bf26290fadbd() {
    try {
      this.testView();
    } finally {
    }
  }
}
