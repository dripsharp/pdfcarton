// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.IO;

public class RandomAccessReadBufferedFileTest {
  internal virtual void testPositionSkip() {
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
        null);
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Skip(5);
      global::DripSharp.Testing.JavaAssertions.Equal((int)('5'), randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessSource.GetPosition(),
        null);
    }
  }

  internal virtual void testPositionRead() {
    global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))));
    global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal((int)('0'), randomAccessSource.Read(), null);
    global::DripSharp.Testing.JavaAssertions.Equal((int)('1'), randomAccessSource.Read(), null);
    global::DripSharp.Testing.JavaAssertions.Equal((int)('2'), randomAccessSource.Read(), null);
    global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessSource.GetPosition(),
      null);
    global::DripSharp.Testing.JavaAssertions.False(randomAccessSource.IsClosed(), null);
    randomAccessSource.Dispose();
    global::DripSharp.Testing.JavaAssertions.True(randomAccessSource.IsClosed(), null);
  }

  internal virtual void testSeekEOF() {
    global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))));
    randomAccessSource.Seek((long)(3));
    global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessSource.GetPosition(),
      null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => randomAccessSource.Seek((long)(-1)),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "seek should have thrown an IOException"));
    global::DripSharp.Testing.JavaAssertions.False(randomAccessSource.IsEOF(), null);
    randomAccessSource.Seek(randomAccessSource.Length());
    global::DripSharp.Testing.JavaAssertions.True(randomAccessSource.IsEOF(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1, randomAccessSource.Read(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1, randomAccessSource.Read(new sbyte[1], 0, 1),
      null);
    randomAccessSource.Dispose();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => { randomAccessSource.Read(); }, global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "checkClosed should have thrown an IOException"));
  }

  internal virtual void testPositionReadBytes() {
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
        null);
      sbyte[] buffer = new sbyte[4];
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource))).Read(buffer);
      global::DripSharp.Testing.JavaAssertions.Equal((int)('0'), (int)(buffer[0]), null);
      global::DripSharp.Testing.JavaAssertions.Equal((int)('3'), (int)(buffer[3]), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(4), randomAccessSource.GetPosition(),
        null);
      randomAccessSource.Read(buffer, 1, 2);
      global::DripSharp.Testing.JavaAssertions.Equal((int)('0'), (int)(buffer[0]), null);
      global::DripSharp.Testing.JavaAssertions.Equal((int)('4'), (int)(buffer[1]), null);
      global::DripSharp.Testing.JavaAssertions.Equal((int)('5'), (int)(buffer[2]), null);
      global::DripSharp.Testing.JavaAssertions.Equal((int)('3'), (int)(buffer[3]), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessSource.GetPosition(),
        null);
    }
  }

  internal virtual void testPositionPeek() {
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
        null);
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Skip(6);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessSource.GetPosition(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal((int)('6'),
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Peek(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessSource.GetPosition(),
        null);
    }
  }

  internal virtual void testPathConstructor() {
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.PathOfUri(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)(130), randomAccessSource.Length(),
        null);
    }
  }

  internal virtual void testPositionUnreadBytes() {
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))))) {
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
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Rewind(readBytes.Length);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(2), randomAccessSource.GetPosition(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal((int)('2'), randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessSource.GetPosition(),
        null);
      randomAccessSource.Read(readBytes, 2, 4);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(7), randomAccessSource.GetPosition(),
        null);
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Rewind(4);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessSource.GetPosition(),
        null);
    }
  }

  internal virtual void testEmptyBuffer() {
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "RandomAccessReadEmptyFile.txt"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal(-1, randomAccessSource.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(-1,
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Peek(), null);
      sbyte[] readBytes = new sbyte[6];
      global::DripSharp.Testing.JavaAssertions.Equal(-1,
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource))).Read(readBytes),
        null);
      randomAccessSource.Seek((long)(0));
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
        null);
      randomAccessSource.Seek((long)(6));
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
        null);
      global::DripSharp.Testing.JavaAssertions.True(randomAccessSource.IsEOF(), null);
      global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
        => ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Rewind(3),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
        "seek should have thrown an IOException"));
    }
  }

  internal virtual void testView() {
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "RandomAccessReadFile1.txt"))))) using (global::DripSharp.PdfCarton.IO.RandomAccessReadView view
      = randomAccessSource.CreateView((long)(3), (long)(10))) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), view.GetPosition(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((int)('3'), view.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((int)('4'), view.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((int)('5'), view.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(3), view.GetPosition(), null);
    }
  }

  internal virtual void testReadFully1() {
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))))) {
      sbyte[] b = new sbyte[10];
      randomAccessSource.Seek((long)(1));
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).ReadFully(b);
      string s = global::DripSharp.Runtime.JavaCompat.NewString(b,
        global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
      global::DripSharp.Testing.JavaAssertions.Equal("1234567890", s, null);
    }
  }

  internal virtual void testReadFully2() {
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))))) {
      sbyte[] b = new sbyte[10];
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).ReadFully(b, 2, 8);
      string s = global::DripSharp.Runtime.JavaCompat.NewString(b, 2, 8,
        global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
      global::DripSharp.Testing.JavaAssertions.Equal("01234567", s, null);
      global::DripSharp.Testing.JavaAssertions.Equal(0, (int)(b[0]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(0, (int)(b[1]), null);
    }
  }

  internal virtual void testReadFully3() {
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))))) {
      sbyte[] b = new sbyte[10];
      randomAccessSource.Seek((randomAccessSource.Length() - b.Length));
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).ReadFully(b);
      string s = global::DripSharp.Runtime.JavaCompat.NewString(b,
        global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
      global::DripSharp.Testing.JavaAssertions.Equal("0123456789", s, null);
    }
  }

  internal virtual void testReadFullyEOF() {
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))))) {
      sbyte[] b = new sbyte[10];
      randomAccessSource.Seek(((randomAccessSource.Length() - b.Length) + 1));
      global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.EndOfStreamException>(()
        => ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).ReadFully(b),
        null);
    }
  }

  internal virtual void testReadFullyExact() {
    global::DripSharp.Runtime.JavaPath path
      = global::DripSharp.Runtime.JavaCompat.PathOfUri(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt")));
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(path)) {
      int length = (int)(randomAccessSource.Length());
      sbyte[] b = new sbyte[length];
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).ReadFully(b);
      sbyte[] allBytes = global::DripSharp.Runtime.JavaCompat.ReadAllBytes(path);
      global::DripSharp.Testing.JavaAssertions.Equal(allBytes, b, null);
    }
  }

  internal virtual void testReadFullyAcrossBuffers() {
    int bufferLen;
    global::System.IO.FileInfo file
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "src/test/java/org/apache/pdfbox/io/NonSeekableRandomAccessReadInputStreamTest.java"));
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource__275_31
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(file)) {
      int length = (int)(randomAccessSource__275_31.Length());
      sbyte[] b__278_20 = new sbyte[length];
      bufferLen
        = ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource__275_31))).Read(b__278_20);
      global::DripSharp.Testing.JavaAssertions.True(((bufferLen * 2) < length), null);
    }
    sbyte[] expectedBytes;
    using (global::System.IO.Stream @is
      = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file)) {
      long skipped = global::DripSharp.Runtime.JavaCompat.InputStreamSkip(@is, (long)((bufferLen
        / 2)));
      global::DripSharp.Testing.JavaAssertions.Equal(skipped, (long)((bufferLen / 2)), null);
      expectedBytes = new sbyte[(bufferLen * 2)];
      int actualRead = global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is, expectedBytes, 1,
        (expectedBytes.Length - 1));
      global::DripSharp.Testing.JavaAssertions.Equal((expectedBytes.Length - 1), actualRead, null);
    }
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource__293_31
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(file)) {
      randomAccessSource__293_31.Seek((long)((bufferLen / 2)));
      sbyte[] b__296_20 = new sbyte[(bufferLen * 2)];
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource__293_31)).ReadFully(b__296_20,
        1, (b__296_20.Length - 1));
      global::DripSharp.Testing.JavaAssertions.Equal(expectedBytes, b__296_20, null);
    }
  }

  internal virtual void testReadFullyNothing() {
    using (global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
        null);
      sbyte[] b = new sbyte[0];
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).ReadFully(b);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
        null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_2184989691_dc80d0d37eeb26b8() {
    try {
      this.testEmptyBuffer();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2466971555_2cdf385de3857dc4() {
    try {
      this.testPathConstructor();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212513238_1ee3d69456b85971() {
    try {
      this.testPositionPeek();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212572689_036bbfa4cf772af4() {
    try {
      this.testPositionRead();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0136067802_d2af8f1a7a2de915() {
    try {
      this.testPositionReadBytes();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212608506_fa3f2acb9a88bf2c() {
    try {
      this.testPositionSkip();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1224508193_e5c7c28e6ff21d12() {
    try {
      this.testPositionUnreadBytes();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0561846543_ceb2166345b6a593() {
    try {
      this.testReadFully1();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0561846544_6462108114595e22() {
    try {
      this.testReadFully2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0561846545_c6e8a356682b9ffa() {
    try {
      this.testReadFully3();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1687457394_d0f180f363360704() {
    try {
      this.testReadFullyAcrossBuffers();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3063637562_407e7f92e1a9f557() {
    try {
      this.testReadFullyEOF();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2104349885_3206184f672cdc90() {
    try {
      this.testReadFullyExact();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2803235339_9a19f0e3d13d6a8f() {
    try {
      this.testReadFullyNothing();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3726669426_8b5bdff1706ed673() {
    try {
      this.testSeekEOF();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1000757847_24f2d2943ff74dc4() {
    try {
      this.testView();
    } finally {
    }
  }
}
