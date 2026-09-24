// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.IO;

public class RandomAccessReadMemoryMappedFileTest {
  internal virtual void testPositionSkip() { {
      global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadMemoryMappedFile(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))));
      global::System.Exception __dripsharpPrimary_43_31_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
          null);
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Skip(5);
        global::DripSharp.Testing.JavaAssertions.Equal((int)('5'), randomAccessSource.Read(), null);
        global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessSource.GetPosition(),
          null);
      } catch (global::System.Exception __dripsharpCaught_43_31_0) {
        __dripsharpPrimary_43_31_0 = __dripsharpCaught_43_31_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(randomAccessSource,
          __dripsharpPrimary_43_31_0);
      }
    }
  }

  internal virtual void testPathConstructor() { {
      global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadMemoryMappedFile(global::DripSharp.Runtime.JavaCompat.PathOfUri(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))));
      global::System.Exception __dripsharpPrimary_56_31_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal((long)(130), randomAccessSource.Length(),
          null);
      } catch (global::System.Exception __dripsharpCaught_56_31_0) {
        __dripsharpPrimary_56_31_0 = __dripsharpCaught_56_31_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(randomAccessSource,
          __dripsharpPrimary_56_31_0);
      }
    }
  }

  internal virtual void testPositionRead() {
    global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadMemoryMappedFile(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
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
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadMemoryMappedFile(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))));
    randomAccessSource.Seek((long)(3));
    global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessSource.GetPosition(),
      null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => randomAccessSource.Seek((long)(unchecked(-1))),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "seek should have thrown an IOException"));
    global::DripSharp.Testing.JavaAssertions.False(randomAccessSource.IsEOF(), null);
    randomAccessSource.Seek(randomAccessSource.Length());
    global::DripSharp.Testing.JavaAssertions.True(randomAccessSource.IsEOF(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(unchecked(-1), randomAccessSource.Read(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(unchecked(-1),
      randomAccessSource.Read(new sbyte[1], 0, 1), null);
    randomAccessSource.Dispose();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => { randomAccessSource.Read(); }, global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "checkClosed should have thrown an IOException"));
  }

  internal virtual void testPositionReadBytes() { {
      global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadMemoryMappedFile(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))));
      global::System.Exception __dripsharpPrimary_106_31_0 = null!;
      try {
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
      } catch (global::System.Exception __dripsharpCaught_106_31_0) {
        __dripsharpPrimary_106_31_0 = __dripsharpCaught_106_31_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(randomAccessSource,
          __dripsharpPrimary_106_31_0);
      }
    }
  }

  internal virtual void testPositionPeek() { {
      global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadMemoryMappedFile(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))));
      global::System.Exception __dripsharpPrimary_128_31_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal((long)(0), randomAccessSource.GetPosition(),
          null);
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Skip(6);
        global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessSource.GetPosition(),
          null);
        global::DripSharp.Testing.JavaAssertions.Equal((int)('6'),
          ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Peek(), null);
        global::DripSharp.Testing.JavaAssertions.Equal((long)(6), randomAccessSource.GetPosition(),
          null);
      } catch (global::System.Exception __dripsharpCaught_128_31_0) {
        __dripsharpPrimary_128_31_0 = __dripsharpCaught_128_31_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(randomAccessSource,
          __dripsharpPrimary_128_31_0);
      }
    }
  }

  internal virtual void testPositionUnreadBytes() { {
      global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadMemoryMappedFile(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))));
      global::System.Exception __dripsharpPrimary_143_31_0 = null!;
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
        global::DripSharp.Testing.JavaAssertions.Equal((int)('2'), randomAccessSource.Read(), null);
        global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessSource.GetPosition(),
          null);
        randomAccessSource.Read(readBytes, 2, 4);
        global::DripSharp.Testing.JavaAssertions.Equal((long)(7), randomAccessSource.GetPosition(),
          null);
        ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(randomAccessSource)).Rewind(4);
        global::DripSharp.Testing.JavaAssertions.Equal((long)(3), randomAccessSource.GetPosition(),
          null);
      } catch (global::System.Exception __dripsharpCaught_143_31_0) {
        __dripsharpPrimary_143_31_0 = __dripsharpCaught_143_31_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(randomAccessSource,
          __dripsharpPrimary_143_31_0);
      }
    }
  }

  internal virtual void testEmptyBuffer() { {
      global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadMemoryMappedFile(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
        "RandomAccessReadEmptyFile.txt"))));
      global::System.Exception __dripsharpPrimary_166_31_0 = null!;
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
      } catch (global::System.Exception __dripsharpCaught_166_31_0) {
        __dripsharpPrimary_166_31_0 = __dripsharpCaught_166_31_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(randomAccessSource,
          __dripsharpPrimary_166_31_0);
      }
    }
  }

  internal virtual void testUnmapping() {
    global::DripSharp.Runtime.JavaPath tempFile
      = global::DripSharp.Runtime.JavaCompat.createTempFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
      "PDFBOX"), global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "txt")); {
      global::System.IO.TextWriter bufferedWriter
        = global::DripSharp.PdfCarton.Tests.Support.NewBufferedWriter(tempFile, new object());
      global::System.Exception __dripsharpPrimary_189_29_0 = null!;
      try {
        bufferedWriter.Write(global::DripSharp.PdfCarton.Tests.Support.TestPath("io",
          "Apache PDFBox test"));
      } catch (global::System.Exception __dripsharpCaught_189_29_0) {
        __dripsharpPrimary_189_29_0 = __dripsharpCaught_189_29_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(bufferedWriter,
          __dripsharpPrimary_189_29_0);
      }
    } {
      global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadMemoryMappedFile(global::DripSharp.Runtime.JavaCompat.NewJavaFile(tempFile));
      global::System.Exception __dripsharpPrimary_194_31_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(65, randomAccessSource.Read(), null);
      } catch (global::System.Exception __dripsharpCaught_194_31_0) {
        __dripsharpPrimary_194_31_0 = __dripsharpCaught_194_31_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(randomAccessSource,
          __dripsharpPrimary_194_31_0);
      }
    }
    global::DripSharp.Runtime.JavaCompat.DeleteIfExists(tempFile);
  }

  internal virtual void testView() { {
      global::DripSharp.PdfCarton.IO.RandomAccessRead randomAccessSource
        = new global::DripSharp.PdfCarton.IO.RandomAccessReadMemoryMappedFile(global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "RandomAccessReadFile1.txt"))));
      global::System.Exception __dripsharpPrimary_206_31_0 = null!;
      try {
        global::DripSharp.PdfCarton.IO.RandomAccessReadView view
          = randomAccessSource.CreateView((long)(3), (long)(10));
        global::System.Exception __dripsharpPrimary_208_35_0 = null!;
        try {
          global::DripSharp.Testing.JavaAssertions.Equal((long)(0), view.GetPosition(), null);
          global::DripSharp.Testing.JavaAssertions.Equal((int)('3'), view.Read(), null);
          global::DripSharp.Testing.JavaAssertions.Equal((int)('4'), view.Read(), null);
          global::DripSharp.Testing.JavaAssertions.Equal((int)('5'), view.Read(), null);
          global::DripSharp.Testing.JavaAssertions.Equal((long)(3), view.GetPosition(), null);
        } catch (global::System.Exception __dripsharpCaught_208_35_0) {
          __dripsharpPrimary_208_35_0 = __dripsharpCaught_208_35_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(view, __dripsharpPrimary_208_35_0);
        }
      } catch (global::System.Exception __dripsharpCaught_206_31_0) {
        __dripsharpPrimary_206_31_0 = __dripsharpCaught_206_31_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(randomAccessSource,
          __dripsharpPrimary_206_31_0);
      }
    }
  }

  [Xunit.Fact]
  public void __Upstream_2184989691_09f294cc4db0be57() {
    try {
      this.testEmptyBuffer();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2466971555_c90141e08b4dc93b() {
    try {
      this.testPathConstructor();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212513238_5c5004b21e80b1e1() {
    try {
      this.testPositionPeek();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212572689_b266132e4ce06552() {
    try {
      this.testPositionRead();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0136067802_c0fa7ba022be28e4() {
    try {
      this.testPositionReadBytes();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3212608506_17d36ee318577a84() {
    try {
      this.testPositionSkip();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1224508193_d1ad394ba58efcb1() {
    try {
      this.testPositionUnreadBytes();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3726669426_97943305474af938() {
    try {
      this.testSeekEOF();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1071578019_219d671c9cb792f1() {
    try {
      this.testUnmapping();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1000757847_6696dd2f2346cfe9() {
    try {
      this.testView();
    } finally {
    }
  }
}
