// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Cmap;

public class TestCodespaceRange {
  internal virtual void testCodeLength() {
    sbyte[] startBytes1 = new sbyte[] { unchecked((sbyte)(0)) };
    sbyte[] endBytes1 = new sbyte[] { unchecked((sbyte)(32)) };
    global::DripSharp.PdfCarton.Fonts.Cmap.CodespaceRange range1
      = new global::DripSharp.PdfCarton.Fonts.Cmap.CodespaceRange(startBytes1, endBytes1);
    global::DripSharp.Testing.JavaAssertions.Equal(1, range1.GetCodeLength(), null);
    sbyte[] startBytes2 = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(0)) };
    sbyte[] endBytes2 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(32)) };
    global::DripSharp.PdfCarton.Fonts.Cmap.CodespaceRange range2
      = new global::DripSharp.PdfCarton.Fonts.Cmap.CodespaceRange(startBytes2, endBytes2);
    global::DripSharp.Testing.JavaAssertions.Equal(2, range2.GetCodeLength(), null);
  }

  internal virtual void testConstructor() {
    sbyte[] startBytes1 = new sbyte[] { unchecked((sbyte)(0)) };
    sbyte[] endBytes2 = new sbyte[] { unchecked((sbyte)(-1)), unchecked((sbyte)(-1)) };
    new global::DripSharp.PdfCarton.Fonts.Cmap.CodespaceRange(startBytes1, endBytes2);
    sbyte[] startBytes3 = new sbyte[] { unchecked((sbyte)(1)) };
    sbyte[] endBytes4 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(32)) };
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(()
      => new global::DripSharp.PdfCarton.Fonts.Cmap.CodespaceRange(startBytes3, endBytes4), null);
  }

  internal virtual void testMatches() {
    sbyte[] startBytes1 = new sbyte[] { unchecked((sbyte)(0)) };
    sbyte[] endBytes1 = new sbyte[] { unchecked((sbyte)(160)) };
    global::DripSharp.PdfCarton.Fonts.Cmap.CodespaceRange range1
      = new global::DripSharp.PdfCarton.Fonts.Cmap.CodespaceRange(startBytes1, endBytes1);
    global::DripSharp.Testing.JavaAssertions.True(range1.Matches(new sbyte[] { unchecked((sbyte)(0)) }),
      null);
    global::DripSharp.Testing.JavaAssertions.True(range1.Matches(new sbyte[] { unchecked((sbyte)(160)) }),
      null);
    global::DripSharp.Testing.JavaAssertions.True(range1.Matches(new sbyte[] { unchecked((sbyte)(16)) }),
      null);
    global::DripSharp.Testing.JavaAssertions.False(range1.Matches(new sbyte[] { unchecked((sbyte)(161)) }),
      null);
    global::DripSharp.Testing.JavaAssertions.False(range1.Matches(new sbyte[] { unchecked((sbyte)(208)) }),
      null);
    global::DripSharp.Testing.JavaAssertions.False(range1.Matches(new sbyte[] { unchecked((sbyte)(0)),
        unchecked((sbyte)(16)) }), null);
    sbyte[] startBytes2 = new sbyte[] { unchecked((sbyte)(129)), unchecked((sbyte)(64)) };
    sbyte[] endBytes2 = new sbyte[] { unchecked((sbyte)(159)), unchecked((sbyte)(252)) };
    global::DripSharp.PdfCarton.Fonts.Cmap.CodespaceRange range2
      = new global::DripSharp.PdfCarton.Fonts.Cmap.CodespaceRange(startBytes2, endBytes2);
    global::DripSharp.Testing.JavaAssertions.True(range2.Matches(new sbyte[] { unchecked((sbyte)(129)),
        unchecked((sbyte)(64)) }), null);
    global::DripSharp.Testing.JavaAssertions.True(range2.Matches(new sbyte[] { unchecked((sbyte)(129)),
        unchecked((sbyte)(252)) }), null);
    global::DripSharp.Testing.JavaAssertions.True(range2.Matches(new sbyte[] { unchecked((sbyte)(129)),
        unchecked((sbyte)(64)) }), null);
    global::DripSharp.Testing.JavaAssertions.True(range2.Matches(new sbyte[] { unchecked((sbyte)(159)),
        unchecked((sbyte)(64)) }), null);
    global::DripSharp.Testing.JavaAssertions.True(range2.Matches(new sbyte[] { unchecked((sbyte)(129)),
        unchecked((sbyte)(101)) }), null);
    global::DripSharp.Testing.JavaAssertions.True(range2.Matches(new sbyte[] { unchecked((sbyte)(144)),
        unchecked((sbyte)(64)) }), null);
    global::DripSharp.Testing.JavaAssertions.False(range2.Matches(new sbyte[] { unchecked((sbyte)(129)),
        unchecked((sbyte)(253)) }), null);
    global::DripSharp.Testing.JavaAssertions.False(range2.Matches(new sbyte[] { unchecked((sbyte)(160)),
        unchecked((sbyte)(64)) }), null);
    global::DripSharp.Testing.JavaAssertions.False(range2.Matches(new sbyte[] { unchecked((sbyte)(129)),
        unchecked((sbyte)(32)) }), null);
    global::DripSharp.Testing.JavaAssertions.False(range2.Matches(new sbyte[] { unchecked((sbyte)(16)),
        unchecked((sbyte)(64)) }), null);
    global::DripSharp.Testing.JavaAssertions.False(range2.Matches(new sbyte[] { unchecked((sbyte)(130)),
        unchecked((sbyte)(32)) }), null);
    global::DripSharp.Testing.JavaAssertions.False(range2.Matches(new sbyte[] { unchecked((sbyte)(0)) }),
      null);
  }

  [Xunit.Fact]
  public void __Upstream_0297927013_11b313f19262d04c() {
    try {
      this.testCodeLength();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4194569224_b5761cb612b0f651() {
    try {
      this.testConstructor();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2595746881_ae057b5348642a96() {
    try {
      this.testMatches();
    } finally {
    }
  }
}
