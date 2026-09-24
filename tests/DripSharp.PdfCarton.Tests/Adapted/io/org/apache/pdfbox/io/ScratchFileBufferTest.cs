// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.IO;

public class ScratchFileBufferTest {
  private const int PAGE_SIZE = 4096;

  private const int NUM_ITERATIONS = 3;

  internal virtual void testEOFBugInSeek() { {
      global::DripSharp.PdfCarton.IO.ScratchFile scratchFile
        = new global::DripSharp.PdfCarton.IO.ScratchFile(global::DripSharp.PdfCarton.IO.MemoryUsageSetting.SetupMainMemoryOnly());
      global::System.Exception __dripsharpPrimary_49_26_0 = null!;
      try {
        global::DripSharp.PdfCarton.IO.RandomAccess scratchFileBuffer = scratchFile.CreateBuffer();
        sbyte[] bytes = new sbyte[global::DripSharp.PdfCarton.IO.ScratchFileBufferTest.PAGE_SIZE];
        for (int i = 0; (i < global::DripSharp.PdfCarton.IO.ScratchFileBufferTest.NUM_ITERATIONS);
          i++) {
          long p0 = scratchFileBuffer.GetPosition();
          scratchFileBuffer.Write(bytes);
          long p1 = scratchFileBuffer.GetPosition();
          global::DripSharp.Testing.JavaAssertions.Equal((long)(global::DripSharp.PdfCarton.IO.ScratchFileBufferTest.PAGE_SIZE),
            unchecked((p1 - p0)), null);
          scratchFileBuffer.Write(bytes);
          long p2 = scratchFileBuffer.GetPosition();
          global::DripSharp.Testing.JavaAssertions.Equal((long)(global::DripSharp.PdfCarton.IO.ScratchFileBufferTest.PAGE_SIZE),
            unchecked((p2 - p1)), null);
          scratchFileBuffer.Seek((long)(0));
          scratchFileBuffer.Seek((long)(unchecked((unchecked((i * 2))
            * global::DripSharp.PdfCarton.IO.ScratchFileBufferTest.PAGE_SIZE))));
        }
      } catch (global::System.Exception __dripsharpCaught_49_26_0) {
        __dripsharpPrimary_49_26_0 = __dripsharpCaught_49_26_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(scratchFile, __dripsharpPrimary_49_26_0);
      }
    }
  }

  internal virtual void testBufferLength() { {
      global::DripSharp.PdfCarton.IO.ScratchFile scratchFile
        = new global::DripSharp.PdfCarton.IO.ScratchFile(global::DripSharp.PdfCarton.IO.MemoryUsageSetting.SetupMainMemoryOnly());
      global::System.Exception __dripsharpPrimary_71_26_0 = null!;
      try {
        sbyte[] bytes = new sbyte[global::DripSharp.PdfCarton.IO.ScratchFileBufferTest.PAGE_SIZE];
        global::DripSharp.PdfCarton.IO.RandomAccess scratchFileBuffer1 = scratchFile.CreateBuffer();
        scratchFileBuffer1.Write(bytes);
        global::DripSharp.Testing.JavaAssertions.Equal((long)(global::DripSharp.PdfCarton.IO.ScratchFileBufferTest.PAGE_SIZE),
          scratchFileBuffer1.Length(), null);
      } catch (global::System.Exception __dripsharpCaught_71_26_0) {
        __dripsharpPrimary_71_26_0 = __dripsharpCaught_71_26_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(scratchFile, __dripsharpPrimary_71_26_0);
      }
    }
  }

  internal virtual void testBufferSeek() { {
      global::DripSharp.PdfCarton.IO.ScratchFile scratchFile
        = new global::DripSharp.PdfCarton.IO.ScratchFile(global::DripSharp.PdfCarton.IO.MemoryUsageSetting.SetupMainMemoryOnly());
      global::System.Exception __dripsharpPrimary_83_26_0 = null!;
      try {
        sbyte[] bytes = new sbyte[global::DripSharp.PdfCarton.IO.ScratchFileBufferTest.PAGE_SIZE];
        global::DripSharp.PdfCarton.IO.RandomAccess scratchFileBuffer1 = scratchFile.CreateBuffer();
        scratchFileBuffer1.Write(bytes);
        global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
          => scratchFileBuffer1.Seek((long)(unchecked(-1))), null);
        global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.EndOfStreamException>(()
          => scratchFileBuffer1.Seek((long)(unchecked((global::DripSharp.PdfCarton.IO.ScratchFileBufferTest.PAGE_SIZE
          + 1)))), null);
      } catch (global::System.Exception __dripsharpCaught_83_26_0) {
        __dripsharpPrimary_83_26_0 = __dripsharpCaught_83_26_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(scratchFile, __dripsharpPrimary_83_26_0);
      }
    }
  }

  internal virtual void testBufferEOF() { {
      global::DripSharp.PdfCarton.IO.ScratchFile scratchFile
        = new global::DripSharp.PdfCarton.IO.ScratchFile(global::DripSharp.PdfCarton.IO.MemoryUsageSetting.SetupMainMemoryOnly());
      global::System.Exception __dripsharpPrimary_96_26_0 = null!;
      try {
        sbyte[] bytes = new sbyte[global::DripSharp.PdfCarton.IO.ScratchFileBufferTest.PAGE_SIZE];
        global::DripSharp.PdfCarton.IO.RandomAccess scratchFileBuffer1 = scratchFile.CreateBuffer();
        scratchFileBuffer1.Write(bytes);
        scratchFileBuffer1.Seek((long)(0));
        global::DripSharp.Testing.JavaAssertions.False(scratchFileBuffer1.IsEOF(), null);
        scratchFileBuffer1.Seek((long)(global::DripSharp.PdfCarton.IO.ScratchFileBufferTest.PAGE_SIZE));
        global::DripSharp.Testing.JavaAssertions.True(scratchFileBuffer1.IsEOF(), null);
      } catch (global::System.Exception __dripsharpCaught_96_26_0) {
        __dripsharpPrimary_96_26_0 = __dripsharpCaught_96_26_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(scratchFile, __dripsharpPrimary_96_26_0);
      }
    }
  }

  internal virtual void testAlreadyClose() { {
      global::DripSharp.PdfCarton.IO.ScratchFile scratchFile
        = new global::DripSharp.PdfCarton.IO.ScratchFile(global::DripSharp.PdfCarton.IO.MemoryUsageSetting.SetupMainMemoryOnly());
      global::System.Exception __dripsharpPrimary_111_26_0 = null!;
      try {
        sbyte[] bytes = new sbyte[global::DripSharp.PdfCarton.IO.ScratchFileBufferTest.PAGE_SIZE];
        global::DripSharp.PdfCarton.IO.RandomAccess scratchFileBuffer = scratchFile.CreateBuffer();
        scratchFileBuffer.Write(bytes);
        scratchFileBuffer.Dispose();
        global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
          => scratchFileBuffer.Seek((long)(0)), null);
      } catch (global::System.Exception __dripsharpCaught_111_26_0) {
        __dripsharpPrimary_111_26_0 = __dripsharpCaught_111_26_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(scratchFile,
          __dripsharpPrimary_111_26_0);
      }
    }
  }

  internal virtual void testBuffersClosed() { {
      global::DripSharp.PdfCarton.IO.ScratchFile scratchFile
        = new global::DripSharp.PdfCarton.IO.ScratchFile(global::DripSharp.PdfCarton.IO.MemoryUsageSetting.SetupMainMemoryOnly());
      global::System.Exception __dripsharpPrimary_124_26_0 = null!;
      try {
        sbyte[] bytes = new sbyte[global::DripSharp.PdfCarton.IO.ScratchFileBufferTest.PAGE_SIZE];
        global::DripSharp.PdfCarton.IO.RandomAccess scratchFileBuffer1 = scratchFile.CreateBuffer();
        scratchFileBuffer1.Write(bytes);
        global::DripSharp.PdfCarton.IO.RandomAccess scratchFileBuffer2 = scratchFile.CreateBuffer();
        scratchFileBuffer2.Write(bytes);
        global::DripSharp.PdfCarton.IO.RandomAccess scratchFileBuffer3 = scratchFile.CreateBuffer();
        scratchFileBuffer3.Write(bytes);
        global::DripSharp.PdfCarton.IO.RandomAccess scratchFileBuffer4 = scratchFile.CreateBuffer();
        scratchFileBuffer4.Write(bytes);
        scratchFileBuffer1.Dispose();
        scratchFileBuffer3.Dispose();
        global::DripSharp.Testing.JavaAssertions.True(scratchFileBuffer1.IsClosed(), null);
        global::DripSharp.Testing.JavaAssertions.False(scratchFileBuffer2.IsClosed(), null);
        global::DripSharp.Testing.JavaAssertions.True(scratchFileBuffer3.IsClosed(), null);
        global::DripSharp.Testing.JavaAssertions.False(scratchFileBuffer4.IsClosed(), null);
        scratchFile.Dispose();
        global::DripSharp.Testing.JavaAssertions.True(scratchFileBuffer2.IsClosed(), null);
        global::DripSharp.Testing.JavaAssertions.True(scratchFileBuffer4.IsClosed(), null);
      } catch (global::System.Exception __dripsharpCaught_124_26_0) {
        __dripsharpPrimary_124_26_0 = __dripsharpCaught_124_26_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(scratchFile,
          __dripsharpPrimary_124_26_0);
      }
    }
  }

  internal virtual void testView() { {
      global::DripSharp.PdfCarton.IO.ScratchFile scratchFile
        = new global::DripSharp.PdfCarton.IO.ScratchFile(global::DripSharp.PdfCarton.IO.MemoryUsageSetting.SetupMainMemoryOnly());
      global::System.Exception __dripsharpPrimary_156_26_0 = null!;
      try {
        global::DripSharp.PdfCarton.IO.RandomAccess scratchFileBuffer = scratchFile.CreateBuffer();
        sbyte[] inputValues = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(1)),
          unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)),
          unchecked((sbyte)(5)), unchecked((sbyte)(6)), unchecked((sbyte)(7)),
          unchecked((sbyte)(8)), unchecked((sbyte)(9)), unchecked((sbyte)(10)) };
        scratchFileBuffer.Write(inputValues);
        global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
          => scratchFileBuffer.CreateView((long)(0), (long)(10)), null);
      } catch (global::System.Exception __dripsharpCaught_156_26_0) {
        __dripsharpPrimary_156_26_0 = __dripsharpCaught_156_26_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(scratchFile,
          __dripsharpPrimary_156_26_0);
      }
    }
  }

  [Xunit.Fact]
  public void __Upstream_2559771186_9034b2f0f5a45715() {
    try {
      this.testAlreadyClose();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2878664746_ed413d68326dafec() {
    try {
      this.testBufferEOF();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0911464696_711aaab1d5ff743e() {
    try {
      this.testBufferLength();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3339700490_f590266cd25e8fc0() {
    try {
      this.testBufferSeek();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1763506189_9e5560aae333b2ed() {
    try {
      this.testBuffersClosed();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0069909735_2a95cc55f9f745d2() {
    try {
      this.testEOFBugInSeek();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1000757847_a6daf21eb4ab457b() {
    try {
      this.testView();
    } finally {
    }
  }
}
