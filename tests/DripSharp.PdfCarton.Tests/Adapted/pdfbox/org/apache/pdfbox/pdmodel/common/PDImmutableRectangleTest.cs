// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Common;

public class PDImmutableRectangleTest {
  private global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle rect
    = global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4;

  public PDImmutableRectangleTest() {}

  internal virtual void testClass() {
    global::DripSharp.Testing.JavaAssertions.True((this.rect is global::DripSharp.PdfCarton.Pdmodel.Common.PDImmutableRectangle),
      null);
    global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A0 is global::DripSharp.PdfCarton.Pdmodel.Common.PDImmutableRectangle),
      null);
    global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A1 is global::DripSharp.PdfCarton.Pdmodel.Common.PDImmutableRectangle),
      null);
    global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A2 is global::DripSharp.PdfCarton.Pdmodel.Common.PDImmutableRectangle),
      null);
    global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A3 is global::DripSharp.PdfCarton.Pdmodel.Common.PDImmutableRectangle),
      null);
    global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4 is global::DripSharp.PdfCarton.Pdmodel.Common.PDImmutableRectangle),
      null);
    global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A5 is global::DripSharp.PdfCarton.Pdmodel.Common.PDImmutableRectangle),
      null);
    global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A6 is global::DripSharp.PdfCarton.Pdmodel.Common.PDImmutableRectangle),
      null);
    global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.Legal is global::DripSharp.PdfCarton.Pdmodel.Common.PDImmutableRectangle),
      null);
    global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.Letter is global::DripSharp.PdfCarton.Pdmodel.Common.PDImmutableRectangle),
      null);
  }

  internal virtual void testSetUpperRightY() {
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => this.rect.SetUpperRightY((float)(0)), null);
  }

  internal virtual void testSetUpperRightX() {
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => this.rect.SetUpperRightX((float)(0)), null);
  }

  internal virtual void testSetLowerLeftY() {
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => this.rect.SetLowerLeftY((float)(0)), null);
  }

  internal virtual void testSetLowerLeftX() {
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => this.rect.SetLowerLeftX((float)(0)), null);
  }

  [Xunit.Fact]
  public void __Upstream_0941260806_447f2e36f5f4a78b() {
    try {
      this.testClass();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1437166912_793f4e9195418711() {
    try {
      this.testSetLowerLeftX();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1437166913_c79be7e11a955f41() {
    try {
      this.testSetLowerLeftY();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2356062318_3bc14bd967140e9a() {
    try {
      this.testSetUpperRightX();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2356062319_64a3276bfc72e802() {
    try {
      this.testSetUpperRightY();
    } finally {
    }
  }
}
