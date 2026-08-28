// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf.Gsub;

public class GlyphArraySplitterRegexImplTest {
  internal virtual void testSplit_1() {
    global::System.Collections.Generic.ISet<global::System.Collections.Generic.IList<int>> matchers
      = new global::System.Collections.Generic.HashSet<global::System.Collections.Generic.IList<int>>(global::DripSharp.Runtime.JavaCompat.AsList<global::System.Collections.Generic.IList<int>>(global::DripSharp.Runtime.JavaCompat.AsList<int>(84,
      93), global::DripSharp.Runtime.JavaCompat.AsList<int>(102, 82),
      global::DripSharp.Runtime.JavaCompat.AsList<int>(104, 87)));
    global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GlyphArraySplitter testClass
      = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GlyphArraySplitterRegexImpl(matchers);
    global::System.Collections.Generic.IList<int> glyphIds
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(84, 112, 93, 104, 82, 61, 96, 102, 93, 104,
      87, 110);
    global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>> tokens
      = testClass.Split(glyphIds);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<global::System.Collections.Generic.IList<int>>(global::DripSharp.Runtime.JavaCompat.AsList<int>(84,
      112, 93, 104, 82, 61, 96, 102, 93), global::DripSharp.Runtime.JavaCompat.AsList<int>(104, 87),
      global::DripSharp.Runtime.JavaCompat.AsList<int>(110)), tokens, null);
  }

  internal virtual void testSplit_2() {
    global::System.Collections.Generic.ISet<global::System.Collections.Generic.IList<int>> matchers
      = new global::System.Collections.Generic.HashSet<global::System.Collections.Generic.IList<int>>(global::DripSharp.Runtime.JavaCompat.AsList<global::System.Collections.Generic.IList<int>>(global::DripSharp.Runtime.JavaCompat.AsList<int>(67,
      112, 96), global::DripSharp.Runtime.JavaCompat.AsList<int>(74, 112, 76)));
    global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GlyphArraySplitter testClass
      = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GlyphArraySplitterRegexImpl(matchers);
    global::System.Collections.Generic.IList<int> glyphIds
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(67, 112, 96, 103, 93, 108, 93);
    global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>> tokens
      = testClass.Split(glyphIds);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<global::System.Collections.Generic.IList<int>>(global::DripSharp.Runtime.JavaCompat.AsList<int>(67,
      112, 96), global::DripSharp.Runtime.JavaCompat.AsList<int>(103, 93, 108, 93)), tokens, null);
  }

  internal virtual void testSplit_3() {
    global::System.Collections.Generic.ISet<global::System.Collections.Generic.IList<int>> matchers
      = new global::System.Collections.Generic.HashSet<global::System.Collections.Generic.IList<int>>(global::DripSharp.Runtime.JavaCompat.AsList<global::System.Collections.Generic.IList<int>>(global::DripSharp.Runtime.JavaCompat.AsList<int>(67,
      112, 96), global::DripSharp.Runtime.JavaCompat.AsList<int>(74, 112, 76)));
    global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GlyphArraySplitter testClass
      = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GlyphArraySplitterRegexImpl(matchers);
    global::System.Collections.Generic.IList<int> glyphIds
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(94, 67, 112, 96, 112, 91, 103);
    global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>> tokens
      = testClass.Split(glyphIds);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<global::System.Collections.Generic.IList<int>>(global::DripSharp.Runtime.JavaCompat.AsList<int>(94),
      global::DripSharp.Runtime.JavaCompat.AsList<int>(67, 112, 96),
      global::DripSharp.Runtime.JavaCompat.AsList<int>(112, 91, 103)), tokens, null);
  }

  internal virtual void testSplit_4() {
    global::System.Collections.Generic.ISet<global::System.Collections.Generic.IList<int>> matchers
      = new global::System.Collections.Generic.HashSet<global::System.Collections.Generic.IList<int>>(global::DripSharp.Runtime.JavaCompat.AsList<global::System.Collections.Generic.IList<int>>(global::DripSharp.Runtime.JavaCompat.AsList<int>(67,
      112), global::DripSharp.Runtime.JavaCompat.AsList<int>(76, 112)));
    global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GlyphArraySplitter testClass
      = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GlyphArraySplitterRegexImpl(matchers);
    global::System.Collections.Generic.IList<int> glyphIds
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(94, 167, 112, 91, 103);
    global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>> tokens
      = testClass.Split(glyphIds);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<global::System.Collections.Generic.IList<int>>(global::DripSharp.Runtime.JavaCompat.AsList<int>(94,
      167, 112, 91, 103)), tokens, null);
  }

  [Xunit.Fact]
  public void __Upstream_4048040794_af323b5de5e35eae() {
    try {
      this.testSplit_1();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4048040795_5b1cc80375a3c243() {
    try {
      this.testSplit_2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4048040796_3c5b69f4324489d9() {
    try {
      this.testSplit_3();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4048040797_5bc3715643d10e6b() {
    try {
      this.testSplit_4();
    } finally {
    }
  }
}
