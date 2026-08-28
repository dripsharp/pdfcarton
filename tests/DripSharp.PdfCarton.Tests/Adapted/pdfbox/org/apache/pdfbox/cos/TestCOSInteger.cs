// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Cos;

public class TestCOSInteger : global::DripSharp.PdfCarton.Cos.TestCOSNumber {
  internal static void setUp() {
    global::DripSharp.PdfCarton.Cos.TestCOSBase.__field_TestCOSBase
      = global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "0"));
  }

  internal virtual void testEquals() {
    for (int i = -1000; (i < 3000); i += 200) {
      global::DripSharp.PdfCarton.Cos.COSInteger test1
        = global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(i));
      global::DripSharp.PdfCarton.Cos.COSInteger test2
        = global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(i));
      global::DripSharp.PdfCarton.Cos.COSInteger test3
        = global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(i));
      global::DripSharp.Testing.JavaAssertions.Equal(test1, test1, null);
      global::DripSharp.Testing.JavaAssertions.Equal(test2, test1, null);
      global::DripSharp.Testing.JavaAssertions.Equal(test1, test2, null);
      global::DripSharp.Testing.JavaAssertions.Equal(test1, test2, null);
      global::DripSharp.Testing.JavaAssertions.Equal(test2, test3, null);
      global::DripSharp.Testing.JavaAssertions.Equal(test1, test3, null);
      global::DripSharp.PdfCarton.Cos.COSInteger test4
        = global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)((i + 1)));
      global::DripSharp.Testing.JavaAssertions.NotEqual(test4, test1, null);
    }
  }

  internal virtual void testHashCode() {
    for (int i = -1000; (i < 3000); i += 200) {
      global::DripSharp.PdfCarton.Cos.COSInteger test1
        = global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(i));
      global::DripSharp.PdfCarton.Cos.COSInteger test2
        = global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(i));
      global::DripSharp.Testing.JavaAssertions.Equal(test1.GetHashCode(), test2.GetHashCode(),
        null);
      global::DripSharp.PdfCarton.Cos.COSInteger test3
        = global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)((i + 1)));
      global::DripSharp.Testing.JavaAssertions.NotSame(test3.GetHashCode(), test1.GetHashCode(),
        null);
    }
  }

  internal override void testFloatValue() {
    for (int i = -1000; (i < 3000); i += 200) {
      global::DripSharp.Testing.JavaAssertions.Equal((float)((float)i),
        global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(i)).FloatValue(), null);
    }
  }

  internal override void testIntValue() {
    for (int i = -1000; (i < 3000); i += 200) {
      global::DripSharp.Testing.JavaAssertions.Equal(i,
        global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(i)).IntValue(), null);
    }
  }

  internal override void testLongValue() {
    for (int i = -1000; (i < 3000); i += 200) {
      global::DripSharp.Testing.JavaAssertions.Equal((long)((long)i),
        global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(i)).LongValue(), null);
    }
  }

  internal override void testAccept() {
    global::DripSharp.Runtime.JavaByteArrayOutputStream outStream
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    global::DripSharp.PdfCarton.Pdfwriter.COSWriter visitor
      = new global::DripSharp.PdfCarton.Pdfwriter.COSWriter(outStream);
    for (int i = -1000; (i < 3000); i += 200) {
      int index = i;
      global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => {
          global::DripSharp.PdfCarton.Cos.COSInteger cosInt
          = global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(index));
          cosInt.Accept(visitor);
          this.TestByteArrays(global::DripSharp.Runtime.JavaCompat.StringGetBytes(global::DripSharp.Runtime.JavaCompat.StringValueOf(index),
          global::DripSharp.Runtime.JavaStandardCharsets.ISO88591),
          global::DripSharp.Runtime.JavaCompat.ToSignedBytes(outStream));
          global::DripSharp.Runtime.JavaCompat.ResetMemoryStream(outStream);
        }, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat("Failed to write ", index)));
    }
  }

  internal virtual void testWritePDF() {
    global::DripSharp.Runtime.JavaByteArrayOutputStream outStream
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    for (int i = -1000; (i < 3000); i += 200) {
      int index = i;
      global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => {
          global::DripSharp.PdfCarton.Cos.COSInteger cosInt
          = global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(index));
          cosInt.WritePDF(outStream);
          this.TestByteArrays(global::DripSharp.Runtime.JavaCompat.StringGetBytes(global::DripSharp.Runtime.JavaCompat.StringValueOf(index),
          global::DripSharp.Runtime.JavaStandardCharsets.ISO88591),
          global::DripSharp.Runtime.JavaCompat.ToSignedBytes(outStream));
          global::DripSharp.Runtime.JavaCompat.ResetMemoryStream(outStream);
        }, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat("Failed to write ", index)));
    }
  }

  [Xunit.Fact]
  public void __Upstream_3343757370_b0291769e0a69361() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testAccept();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3471735537_ea91f0a3a072b646() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testEquals();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0407743143_cc106ba349d9d57f() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testFloatValue();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725004644_83b4832007e23f82() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testGet();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3571534498_8fac0f03859d336b() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testGetCOSObject();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3009520333_34ad2c9ec86d6510() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testHashCode();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3417873780_d52d5624a65eafc6() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testIntValue();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2725022894_123c9945505984f8() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testInvalidNumber();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2816239855_f4419dad0745085c() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testIsSetDirect();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4121304690_fa908bf81674a18a() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testLargeNumber();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2936432611_a2cc00236bfce69b() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testLongValue();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1015337797_160a818c0b324f37() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testWritePDF();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

  private static bool __RunUpstreamBeforeAll() {
    setUp();
    return true;
  }
}
