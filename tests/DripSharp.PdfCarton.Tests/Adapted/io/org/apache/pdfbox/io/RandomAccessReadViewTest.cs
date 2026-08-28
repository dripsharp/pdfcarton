// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.IO;

public class RandomAccessReadViewTest {
  internal virtual void testPositionSkip() {
    sbyte[] values = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)), unchecked((sbyte)(11)), unchecked((sbyte)(12)),
      unchecked((sbyte)(13)), unchecked((sbyte)(14)), unchecked((sbyte)(15)),
      unchecked((sbyte)(16)), unchecked((sbyte)(17)), unchecked((sbyte)(18)),
      unchecked((sbyte)(19)), unchecked((sbyte)(20)) };
    using (global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(values))) using (global::DripSharp.PdfCarton.IO.RandomAccessReadView randomAccessReadView
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadView(randomAccessSource, (long)(10),
      (long)(20))) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessReadView.GetPosition(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(10,
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessReadView)).Peek(), null);
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessReadView)).Skip(5);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(5), randomAccessReadView.GetPosition(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(15,
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessReadView)).Peek(), null);
    }
  }

  internal virtual void testPositionRead() {
    sbyte[] values = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)), unchecked((sbyte)(11)), unchecked((sbyte)(12)),
      unchecked((sbyte)(13)), unchecked((sbyte)(14)), unchecked((sbyte)(15)),
      unchecked((sbyte)(16)), unchecked((sbyte)(17)), unchecked((sbyte)(18)),
      unchecked((sbyte)(19)), unchecked((sbyte)(20)) };
    using (global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(values))) {
      global::DripSharp.PdfCarton.IO.RandomAccessReadView randomAccessReadView
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadView(randomAccessSource, (long)(10),
        (long)(20));
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessReadView.GetPosition(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(10, randomAccessReadView.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(11, randomAccessReadView.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(12, randomAccessReadView.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessReadView.GetPosition(),
        null);
      global::DripSharp.Testing.JavaAssertions.False(randomAccessReadView.IsClosed(), null);
      randomAccessReadView.Dispose();
      global::DripSharp.Testing.JavaAssertions.True(randomAccessReadView.IsClosed(), null);
      randomAccessReadView.Dispose();
    }
  }

  internal virtual void testSeekEOF() {
    sbyte[] values = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)), unchecked((sbyte)(11)), unchecked((sbyte)(12)),
      unchecked((sbyte)(13)), unchecked((sbyte)(14)), unchecked((sbyte)(15)),
      unchecked((sbyte)(16)), unchecked((sbyte)(17)), unchecked((sbyte)(18)),
      unchecked((sbyte)(19)), unchecked((sbyte)(20)) };
    global::DripSharp.PdfCarton.IO.RandomAccessReadView randomAccessReadView;
    using (global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(values))) {
      randomAccessReadView
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadView(randomAccessSource, (long)(10),
        (long)(20));
      randomAccessReadView.Seek((long)(3));
      global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessReadView.GetPosition(),
        null);
      global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
        => randomAccessReadView.Seek((long)(-1)),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
        "seek should have thrown an IOException"));
      global::DripSharp.Testing.JavaAssertions.False(randomAccessReadView.IsEOF(), null);
      randomAccessReadView.Seek((long)(20));
      global::DripSharp.Testing.JavaAssertions.True(randomAccessReadView.IsEOF(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(-1, randomAccessReadView.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(-1, randomAccessReadView.Read(new sbyte[1], 0,
        1), null);
      randomAccessReadView.Dispose();
    }
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => { randomAccessReadView.Read(); }, global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "checkClosed should have thrown an IOException"));
  }

  internal virtual void testPositionReadBytes() {
    sbyte[] values = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)), unchecked((sbyte)(11)), unchecked((sbyte)(12)),
      unchecked((sbyte)(13)), unchecked((sbyte)(14)), unchecked((sbyte)(15)),
      unchecked((sbyte)(16)), unchecked((sbyte)(17)), unchecked((sbyte)(18)),
      unchecked((sbyte)(19)), unchecked((sbyte)(20)) };
    using (global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(values))) using (global::DripSharp.PdfCarton.IO.RandomAccessReadView randomAccessReadView
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadView(randomAccessSource, (long)(10),
      (long)(20))) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessReadView.GetPosition(),
        null);
      sbyte[] buffer = new sbyte[4];
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessReadView))).Read(buffer);
      global::DripSharp.Testing.JavaAssertions.Equal(10, (int)(buffer[0]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(13, (int)(buffer[3]), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(4), randomAccessReadView.GetPosition(),
        null);
      randomAccessReadView.Read(buffer, 1, 2);
      global::DripSharp.Testing.JavaAssertions.Equal(10, (int)(buffer[0]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(14, (int)(buffer[1]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(15, (int)(buffer[2]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(13, (int)(buffer[3]), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessReadView.GetPosition(),
        null);
    }
  }

  internal virtual void testPositionPeek() {
    sbyte[] values = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)), unchecked((sbyte)(11)), unchecked((sbyte)(12)),
      unchecked((sbyte)(13)), unchecked((sbyte)(14)), unchecked((sbyte)(15)),
      unchecked((sbyte)(16)), unchecked((sbyte)(17)), unchecked((sbyte)(18)),
      unchecked((sbyte)(19)), unchecked((sbyte)(20)) };
    using (global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(values))) using (global::DripSharp.PdfCarton.IO.RandomAccessReadView randomAccessReadView
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadView(randomAccessSource, (long)(10),
      (long)(20))) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessReadView.GetPosition(),
        null);
      ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessReadView)).Skip(6);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessReadView.GetPosition(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(16,
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessReadView)).Peek(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessReadView.GetPosition(),
        null);
    }
  }

  internal virtual void testPositionUnreadBytes() {
    sbyte[] values = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)), unchecked((sbyte)(11)), unchecked((sbyte)(12)),
      unchecked((sbyte)(13)), unchecked((sbyte)(14)), unchecked((sbyte)(15)),
      unchecked((sbyte)(16)), unchecked((sbyte)(17)), unchecked((sbyte)(18)),
      unchecked((sbyte)(19)), unchecked((sbyte)(20)) };
    using (global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(values))) using (global::DripSharp.PdfCarton.IO.RandomAccessReadView randomAccessReadView
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadView(randomAccessSource, (long)(10),
      (long)(20))) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessReadView.GetPosition(),
        null);
      randomAccessReadView.Read();
      randomAccessReadView.Read();
      sbyte[] readBytes = new sbyte[6];
      global::DripSharp.Testing.JavaAssertions.Equal(readBytes.Length,
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessReadView))).Read(readBytes),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(8), randomAccessReadView.GetPosition(),
        null);
      randomAccessReadView.Rewind(readBytes.Length);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(2), randomAccessReadView.GetPosition(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(12, randomAccessReadView.Read(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessReadView.GetPosition(),
        null);
      randomAccessReadView.Read(readBytes, 2, 4);
      global::DripSharp.Testing.JavaAssertions.Equal(12, (int)(readBytes[0]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(13, (int)(readBytes[2]), null);
      global::DripSharp.Testing.JavaAssertions.Equal(16, (int)(readBytes[5]), null);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(7), randomAccessReadView.GetPosition(),
        null);
      randomAccessReadView.Rewind(4);
      global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessReadView.GetPosition(),
        null);
    }
  }

  internal virtual void testCreateView() {
    sbyte[] values = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)), unchecked((sbyte)(11)), unchecked((sbyte)(12)),
      unchecked((sbyte)(13)), unchecked((sbyte)(14)), unchecked((sbyte)(15)),
      unchecked((sbyte)(16)), unchecked((sbyte)(17)), unchecked((sbyte)(18)),
      unchecked((sbyte)(19)), unchecked((sbyte)(20)) };
    using (global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(values))) using (global::DripSharp.PdfCarton.IO.RandomAccessReadView randomAccessReadView
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadView(randomAccessSource, (long)(10),
      (long)(20))) {
      global::System.IO.IOException ex
        = global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
        => randomAccessReadView.CreateView((long)(0), (long)(20)), null);
      global::DripSharp.Testing.JavaAssertions.Equal("org.apache.pdfbox.io.RandomAccessReadView.createView isn't supported.",
        global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_2802746355_3e86a66c343c2423() {
    try {
      this.testCreateView();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212513238_da7978eb92f5914b() {
    try {
      this.testPositionPeek();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212572689_85fecde9cabfc554() {
    try {
      this.testPositionRead();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0136067802_c02fb02f7ae521b2() {
    try {
      this.testPositionReadBytes();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212608506_5597e7de1e8d0378() {
    try {
      this.testPositionSkip();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1224508193_430e9802858a9b33() {
    try {
      this.testPositionUnreadBytes();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3726669426_0acccf37aac05166() {
    try {
      this.testSeekEOF();
    } finally {
    }
  }
}
