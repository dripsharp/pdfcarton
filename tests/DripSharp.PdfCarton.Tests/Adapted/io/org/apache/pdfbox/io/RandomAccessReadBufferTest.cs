// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.IO;

public class RandomAccessReadBufferTest {
  internal virtual void testPositionSkip() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues); {
      global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(bais);
      global::System.Exception __dripsharpPrimary_49_37_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
          null);
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Skip(5);
        global::DripSharp.Testing.JavaAssertions.Equal(5, randomAccessSource.Read(), null);
        global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessSource.GetPosition(),
          null);
      } catch (global::System.Exception __dripsharpCaught_49_37_0) {
        __dripsharpPrimary_49_37_0 = __dripsharpCaught_49_37_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(randomAccessSource,
          __dripsharpPrimary_49_37_0);
      }
    }
  }

  internal virtual void testPositionRead() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues);
    global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(bais);
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
    global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(bais);
    randomAccessSource.Seek((long)(3));
    global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessSource.GetPosition(),
      null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => randomAccessSource.Seek((long)(unchecked(-1))),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "seek should have thrown an IOException"));
    global::DripSharp.Testing.JavaAssertions.False(randomAccessSource.IsEOF(), null);
    randomAccessSource.Seek((long)(20));
    global::DripSharp.Testing.JavaAssertions.True(randomAccessSource.IsEOF(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(unchecked(-1), randomAccessSource.Read(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(unchecked(-1),
      randomAccessSource.Read(new sbyte[1], 0, 1), null);
    randomAccessSource.Dispose();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => { randomAccessSource.Read(); }, global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "checkClosed should have thrown an IOException"));
  }

  internal virtual void testPositionReadBytes() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues); {
      global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(bais);
      global::System.Exception __dripsharpPrimary_108_37_0 = null!;
      try {
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
      } catch (global::System.Exception __dripsharpCaught_108_37_0) {
        __dripsharpPrimary_108_37_0 = __dripsharpCaught_108_37_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(randomAccessSource,
          __dripsharpPrimary_108_37_0);
      }
    }
  }

  internal virtual void testPositionPeek() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues); {
      global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(bais);
      global::System.Exception __dripsharpPrimary_132_37_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
          null);
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Skip(6);
        global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessSource.GetPosition(),
          null);
        global::DripSharp.Testing.JavaAssertions.Equal(6,
          ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Peek(), null);
        global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessSource.GetPosition(),
          null);
      } catch (global::System.Exception __dripsharpCaught_132_37_0) {
        __dripsharpPrimary_132_37_0 = __dripsharpCaught_132_37_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(randomAccessSource,
          __dripsharpPrimary_132_37_0);
      }
    }
  }

  internal virtual void testPositionUnreadBytes() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues); {
      global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(bais);
      global::System.Exception __dripsharpPrimary_149_37_0 = null!;
      try {
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
        global::DripSharp.Testing.JavaAssertions.Equal(2, randomAccessSource.Read(), null);
        global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessSource.GetPosition(),
          null);
        randomAccessSource.Read(readBytes, 2, 4);
        global::DripSharp.Testing.JavaAssertions.Equal((long)(7), randomAccessSource.GetPosition(),
          null);
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Rewind(4);
        global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessSource.GetPosition(),
          null);
      } catch (global::System.Exception __dripsharpCaught_149_37_0) {
        __dripsharpPrimary_149_37_0 = __dripsharpCaught_149_37_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(randomAccessSource,
          __dripsharpPrimary_149_37_0);
      }
    }
  }

  internal virtual void testEmptyBuffer() { {
      global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(new global::DripSharp.Runtime.JavaByteArrayOutputStream()));
      global::System.Exception __dripsharpPrimary_171_37_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(unchecked(-1), randomAccessSource.Read(),
          null);
        global::DripSharp.Testing.JavaAssertions.Equal(unchecked(-1),
          ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Peek(), null);
        sbyte[] readBytes = new sbyte[6];
        global::DripSharp.Testing.JavaAssertions.Equal(unchecked(-1),
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
      } catch (global::System.Exception __dripsharpCaught_171_37_0) {
        __dripsharpPrimary_171_37_0 = __dripsharpCaught_171_37_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(randomAccessSource,
          __dripsharpPrimary_171_37_0);
      }
    }
  }

  internal virtual void testView() {
    sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
      unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)),
      unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)(8)), unchecked((sbyte)(9)),
      unchecked((sbyte)(10)) };
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(inputValues); {
      global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(bais);
      global::System.Exception __dripsharpPrimary_194_37_0 = null!;
      try {
        global::DripSharp.PdfCarton.IO.RandomAccessReadView view
          = randomAccessSource.CreateView((long)(3), (long)(5));
        global::System.Exception __dripsharpPrimary_195_35_0 = null!;
        try {
          global::DripSharp.Testing.JavaAssertions.Equal((long)(0), view.GetPosition(), null);
          global::DripSharp.Testing.JavaAssertions.Equal(3, view.Read(), null);
          global::DripSharp.Testing.JavaAssertions.Equal(4, view.Read(), null);
          global::DripSharp.Testing.JavaAssertions.Equal(5, view.Read(), null);
          global::DripSharp.Testing.JavaAssertions.Equal((long)(3), view.GetPosition(), null);
        } catch (global::System.Exception __dripsharpCaught_195_35_0) {
          __dripsharpPrimary_195_35_0 = __dripsharpCaught_195_35_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(view, __dripsharpPrimary_195_35_0);
        }
      } catch (global::System.Exception __dripsharpCaught_194_37_0) {
        __dripsharpPrimary_194_37_0 = __dripsharpCaught_194_37_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(randomAccessSource,
          __dripsharpPrimary_194_37_0);
      }
    }
  }

  internal virtual void testPDFBOX5111() { {
      global::System.IO.Stream @is
        = global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
        "https://issues.apache.org/jira/secure/attachment/13017227/stringwidth.pdf")));
      global::System.Exception __dripsharpPrimary_208_26_0 = null!;
      try {
        global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessSource
          = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(@is);
        global::System.Exception __dripsharpPrimary_211_37_0 = null!;
        try {
          global::DripSharp.Testing.JavaAssertions.Equal((long)(34060), randomAccessSource.Length(),
            null);
        } catch (global::System.Exception __dripsharpCaught_211_37_0) {
          __dripsharpPrimary_211_37_0 = __dripsharpCaught_211_37_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(randomAccessSource,
            __dripsharpPrimary_211_37_0);
        }
      } catch (global::System.Exception __dripsharpCaught_208_26_0) {
        __dripsharpPrimary_208_26_0 = __dripsharpCaught_208_26_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_208_26_0);
      }
    }
  }

  internal virtual void testPDFBOX5158() {
    global::DripSharp.Runtime.JavaPath path
      = global::DripSharp.Runtime.JavaCompat.createTempFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "len4096"), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", ".pdf")); {
      global::System.IO.Stream os = global::DripSharp.Runtime.JavaCompat.NewOutputStream(path);
      global::System.Exception __dripsharpPrimary_228_27_0 = null!;
      try {
        global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(os, new sbyte[4096]);
      } catch (global::System.Exception __dripsharpCaught_228_27_0) {
        __dripsharpPrimary_228_27_0 = __dripsharpCaught_228_27_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(os, __dripsharpPrimary_228_27_0);
      }
    }
    global::DripSharp.Testing.JavaAssertions.Equal((long)(4096),
      global::DripSharp.Runtime.JavaCompat.NewJavaFile(path).Length, null); {
      global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenInputStream(path);
      global::System.Exception __dripsharpPrimary_233_26_0 = null!;
      try {
        global::DripSharp.PdfCarton.IO.RandomAccessRead rar
          = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(@is);
        global::System.Exception __dripsharpPrimary_234_31_0 = null!;
        try {
          global::DripSharp.Testing.JavaAssertions.Equal(0, rar.Read(), null);
        } catch (global::System.Exception __dripsharpCaught_234_31_0) {
          __dripsharpPrimary_234_31_0 = __dripsharpCaught_234_31_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(rar, __dripsharpPrimary_234_31_0);
        }
      } catch (global::System.Exception __dripsharpCaught_233_26_0) {
        __dripsharpPrimary_233_26_0 = __dripsharpCaught_233_26_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_233_26_0);
      }
    }
    global::DripSharp.Runtime.JavaCompat.DeleteIfExists(path);
  }

  internal virtual void testPDFBOX5161() { {
      global::DripSharp.PdfCarton.IO.RandomAccessRead rar
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(new sbyte[4099]));
      global::System.Exception __dripsharpPrimary_250_31_0 = null!;
      try {
        sbyte[] buf = new sbyte[4096];
        int bytesRead
          = ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(rar))).Read(buf);
        global::DripSharp.Testing.JavaAssertions.Equal(4096, bytesRead, null);
        bytesRead = rar.Read(buf, 0, 3);
        global::DripSharp.Testing.JavaAssertions.Equal(3, bytesRead, null);
      } catch (global::System.Exception __dripsharpCaught_250_31_0) {
        __dripsharpPrimary_250_31_0 = __dripsharpCaught_250_31_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(rar, __dripsharpPrimary_250_31_0);
      }
    }
  }

  internal virtual void testPDFBOX5764() {
    int bufferSize = 4096;
    int limit = 2048;
    global::DripSharp.Runtime.JavaByteBuffer buffer
      = global::DripSharp.Runtime.JavaByteBuffer.wrap(new sbyte[bufferSize]);
    buffer.limit(limit); {
      global::DripSharp.PdfCarton.IO.RandomAccessRead rar
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(buffer);
      global::System.Exception __dripsharpPrimary_272_31_0 = null!;
      try {
        sbyte[] buf = new sbyte[bufferSize];
        int bytesRead
          = ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(rar))).Read(buf);
        global::DripSharp.Testing.JavaAssertions.Equal(limit, bytesRead, null);
      } catch (global::System.Exception __dripsharpCaught_272_31_0) {
        __dripsharpPrimary_272_31_0 = __dripsharpCaught_272_31_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(rar, __dripsharpPrimary_272_31_0);
      }
    }
  }

  [Xunit.Fact]
  public void __Upstream_2184989691_eb35d455a9af82c8() {
    try {
      this.testEmptyBuffer();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0778918631_5dc412849264183d() {
    try {
      this.testPDFBOX5111();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0778918762_e918f80b0c094a89() {
    try {
      this.testPDFBOX5158();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0778918786_3f669e6aa83d427a() {
    try {
      this.testPDFBOX5161();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0778924555_9987abeb901799a8() {
    try {
      this.testPDFBOX5764();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212513238_a3fe487edbf3cea0() {
    try {
      this.testPositionPeek();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212572689_5b8046109835ac2e() {
    try {
      this.testPositionRead();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0136067802_14bca0f49b9d235b() {
    try {
      this.testPositionReadBytes();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212608506_cd7745e2063fbaf8() {
    try {
      this.testPositionSkip();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1224508193_e133a5224541192b() {
    try {
      this.testPositionUnreadBytes();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3726669426_2e19c1329933fb3b() {
    try {
      this.testSeekEOF();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1000757847_2ea0c62c2ee3901e() {
    try {
      this.testView();
    } finally {
    }
  }
}
