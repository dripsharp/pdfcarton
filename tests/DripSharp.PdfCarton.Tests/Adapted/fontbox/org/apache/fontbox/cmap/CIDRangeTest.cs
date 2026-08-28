// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Cmap;

public class CIDRangeTest {
  internal virtual void testCIDRangeOneByte() {
    global::DripSharp.PdfCarton.Fonts.Cmap.CIDRange cidRange
      = new global::DripSharp.PdfCarton.Fonts.Cmap.CIDRange(0, 20, 65, 1);
    global::DripSharp.Testing.JavaAssertions.Equal(1, cidRange.GetCodeLength(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(65,
      cidRange.Map(new sbyte[] { unchecked((sbyte)(0)) }), null);
    global::DripSharp.Testing.JavaAssertions.Equal(75,
      cidRange.Map(new sbyte[] { unchecked((sbyte)(10)) }), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1,
      cidRange.Map(new sbyte[] { unchecked((sbyte)(30)) }), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1,
      cidRange.Map(new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(10)) }), null);
    global::DripSharp.Testing.JavaAssertions.Equal(65, cidRange.Map(0, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(75, cidRange.Map(10, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1, cidRange.Map(30, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1, cidRange.Map(10, 2), null);
    global::DripSharp.Testing.JavaAssertions.Equal(0, cidRange.Unmap(65), null);
    global::DripSharp.Testing.JavaAssertions.Equal(10, cidRange.Unmap(75), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1, cidRange.Unmap(100), null);
  }

  internal virtual void testCIDRangeTwoByte() {
    global::DripSharp.PdfCarton.Fonts.Cmap.CIDRange cidRange
      = new global::DripSharp.PdfCarton.Fonts.Cmap.CIDRange(256, 280, 65, 2);
    global::DripSharp.Testing.JavaAssertions.Equal(2, cidRange.GetCodeLength(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(65,
      cidRange.Map(new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(0)) }), null);
    global::DripSharp.Testing.JavaAssertions.Equal(75,
      cidRange.Map(new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(10)) }), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1,
      cidRange.Map(new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(30)) }), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1,
      cidRange.Map(new sbyte[] { unchecked((sbyte)(10)) }), null);
    global::DripSharp.Testing.JavaAssertions.Equal(65, cidRange.Map(256, 2), null);
    global::DripSharp.Testing.JavaAssertions.Equal(75, cidRange.Map(266, 2), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1, cidRange.Map(290, 2), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1, cidRange.Map(256, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(256, cidRange.Unmap(65), null);
    global::DripSharp.Testing.JavaAssertions.Equal(266, cidRange.Unmap(75), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1, cidRange.Unmap(100), null);
  }

  [Xunit.Fact]
  public void __Upstream_2307912061_5f923c339630e821() {
    try {
      this.testCIDRangeOneByte();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2717360739_49347381dae4b763() {
    try {
      this.testCIDRangeTwoByte();
    } finally {
    }
  }
}
