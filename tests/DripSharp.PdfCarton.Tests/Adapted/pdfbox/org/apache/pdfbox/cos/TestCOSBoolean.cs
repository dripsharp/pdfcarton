// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Cos;

public class TestCOSBoolean : global::DripSharp.PdfCarton.Cos.TestCOSBase {
  internal readonly global::DripSharp.PdfCarton.Cos.COSBoolean cosBooleanTrue
    = global::DripSharp.PdfCarton.Cos.COSBoolean.True;

  internal readonly global::DripSharp.PdfCarton.Cos.COSBoolean cosBooleanFalse
    = global::DripSharp.PdfCarton.Cos.COSBoolean.False;

  internal static void setUp() {
    global::DripSharp.PdfCarton.Cos.TestCOSBase.__field_TestCOSBase
      = global::DripSharp.PdfCarton.Cos.COSBoolean.True;
  }

  internal virtual void testGetValue() {
    global::DripSharp.Testing.JavaAssertions.True(this.cosBooleanTrue.GetValue(), null);
    global::DripSharp.Testing.JavaAssertions.False(this.cosBooleanFalse.GetValue(), null);
  }

  internal virtual void testGetValueAsObject() {
    global::DripSharp.Testing.JavaAssertions.True((this.cosBooleanTrue.GetValueAsObject() is bool),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(true, this.cosBooleanTrue.GetValueAsObject(),
      null);
    global::DripSharp.Testing.JavaAssertions.True((this.cosBooleanFalse.GetValueAsObject() is bool),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(false, this.cosBooleanFalse.GetValueAsObject(),
      null);
  }

  internal virtual void testGetBoolean() {
    global::DripSharp.Testing.JavaAssertions.Equal(this.cosBooleanTrue,
      global::DripSharp.PdfCarton.Cos.COSBoolean.GetBoolean(true), null);
    global::DripSharp.Testing.JavaAssertions.Equal(this.cosBooleanFalse,
      global::DripSharp.PdfCarton.Cos.COSBoolean.GetBoolean(false), null);
  }

  internal virtual void testEquals() {
    global::DripSharp.PdfCarton.Cos.COSBoolean test1
      = global::DripSharp.PdfCarton.Cos.COSBoolean.True;
    global::DripSharp.PdfCarton.Cos.COSBoolean test2
      = global::DripSharp.PdfCarton.Cos.COSBoolean.True;
    global::DripSharp.PdfCarton.Cos.COSBoolean test3
      = global::DripSharp.PdfCarton.Cos.COSBoolean.True;
    global::DripSharp.Testing.JavaAssertions.Equal(test1, test1, null);
    global::DripSharp.Testing.JavaAssertions.Equal(test2, test1, null);
    global::DripSharp.Testing.JavaAssertions.Equal(test1, test2, null);
    global::DripSharp.Testing.JavaAssertions.Equal(test1, test2, null);
    global::DripSharp.Testing.JavaAssertions.Equal(test2, test3, null);
    global::DripSharp.Testing.JavaAssertions.Equal(test1, test3, null);
    global::DripSharp.Testing.JavaAssertions.NotEqual(global::DripSharp.PdfCarton.Cos.COSBoolean.True,
      global::DripSharp.PdfCarton.Cos.COSBoolean.False, null);
    global::DripSharp.Testing.JavaAssertions.NotEqual(true,
      global::DripSharp.PdfCarton.Cos.COSBoolean.True, null);
    global::DripSharp.Testing.JavaAssertions.NotEqual(false,
      global::DripSharp.PdfCarton.Cos.COSBoolean.False, null);
    global::DripSharp.Testing.JavaAssertions.NotEqual(true,
      global::DripSharp.PdfCarton.Cos.COSBoolean.True, null);
    global::DripSharp.Testing.JavaAssertions.NotEqual(true,
      global::DripSharp.PdfCarton.Cos.COSBoolean.False, null);
  }

  internal override void testAccept() {
    global::DripSharp.Runtime.JavaByteArrayOutputStream outStream
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    global::DripSharp.PdfCarton.Pdfwriter.COSWriter visitor
      = new global::DripSharp.PdfCarton.Pdfwriter.COSWriter(outStream);
    this.cosBooleanTrue.Accept(visitor);
    this.TestByteArrays(global::DripSharp.Runtime.JavaCompat.StringGetBytes(global::DripSharp.Runtime.JavaCompat.StringValueOf(this.cosBooleanTrue),
      global::DripSharp.Runtime.JavaStandardCharsets.ISO88591),
      global::DripSharp.Runtime.JavaCompat.ToSignedBytes(outStream));
    global::DripSharp.Runtime.JavaCompat.ResetMemoryStream(outStream);
    this.cosBooleanFalse.Accept(visitor);
    this.TestByteArrays(global::DripSharp.Runtime.JavaCompat.StringGetBytes(global::DripSharp.Runtime.JavaCompat.StringValueOf(this.cosBooleanFalse),
      global::DripSharp.Runtime.JavaStandardCharsets.ISO88591),
      global::DripSharp.Runtime.JavaCompat.ToSignedBytes(outStream));
  }

  [Xunit.Fact]
  public void __Upstream_3343757370_0b03c98dd9f1a412() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testAccept();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3471735537_d9839425d6741edb() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testEquals();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2535045668_c758dd24263fedc3() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testGetBoolean();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3571534498_8af388b19e176fe5() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testGetCOSObject();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0534654573_01408c0ed782ac41() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testGetValue();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2129789854_5385a7b9386d9691() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testGetValueAsObject();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2816239855_a15492a4af9f3f47() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testIsSetDirect();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

  private static bool __RunUpstreamBeforeAll() {
    setUp();
    return true;
  }
}
