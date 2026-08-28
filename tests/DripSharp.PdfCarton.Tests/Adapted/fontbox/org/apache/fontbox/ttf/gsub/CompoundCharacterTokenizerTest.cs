// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf.Gsub;

public class CompoundCharacterTokenizerTest {
  internal virtual void testTokenize_happyPath_2() {
    global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer tokenizer
      = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer(new global::System.Collections.Generic.HashSet<string>(global::DripSharp.Runtime.JavaCompat.AsList<string>(new string[] { "_84_93_",
        "_104_82_", "_104_87_" })));
    string text = "_84_112_93_104_82_61_96_102_93_104_87_110_";
    global::System.Collections.Generic.IList<string> tokens
      = tokenizer.Tokenize(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", text));
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<string>("_84_112_93",
      "_104_82_", "_61_96_102_93", "_104_87_", "_110_"), tokens, null);
  }

  internal virtual void testTokenize_happyPath_3() {
    global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer tokenizer
      = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer(new global::System.Collections.Generic.HashSet<string>(global::DripSharp.Runtime.JavaCompat.AsList<string>(new string[] { "_67_112_96_",
      "_74_112_76_" })));
    string text = "_67_112_96_103_93_108_93_";
    global::System.Collections.Generic.IList<string> tokens
      = tokenizer.Tokenize(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", text));
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<string>("_67_112_96_",
      "_103_93_108_93_"), tokens, null);
  }

  internal virtual void testTokenize_happyPath_4() {
    global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer tokenizer
      = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer(new global::System.Collections.Generic.HashSet<string>(global::DripSharp.Runtime.JavaCompat.AsList<string>(new string[] { "_67_112_96_",
      "_74_112_76_" })));
    string text = "_94_67_112_96_112_91_103_";
    global::System.Collections.Generic.IList<string> tokens
      = tokenizer.Tokenize(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", text));
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<string>("_94",
      "_67_112_96_", "_112_91_103_"), tokens, null);
  }

  internal virtual void testTokenize_happyPath_5() {
    global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer tokenizer
      = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer(new global::System.Collections.Generic.HashSet<string>(global::DripSharp.Runtime.JavaCompat.AsList<string>(new string[] { "_67_112_",
      "_76_112_" })));
    string text = "_94_167_112_91_103_";
    global::System.Collections.Generic.IList<string> tokens
      = tokenizer.Tokenize(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", text));
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<string>("_94_167_112_91_103_"),
      tokens, null);
  }

  internal virtual void testTokenize_happyPath_6() {
    global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer tokenizer
      = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer(new global::System.Collections.Generic.HashSet<string>(global::DripSharp.Runtime.JavaCompat.AsList<string>("_100_",
      "_101_", "_102_", "_103_", "_104_")));
    string text = "_100_101_102_103_104_";
    global::System.Collections.Generic.IList<string> tokens
      = tokenizer.Tokenize(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", text));
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<string>("_100_",
      "_101_", "_102_", "_103_", "_104_"), tokens, null);
  }

  internal virtual void testTokenize_happyPath_7() {
    global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer tokenizer
      = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer(new global::System.Collections.Generic.HashSet<string>(global::DripSharp.Runtime.JavaCompat.AsList<string>("_100_101_",
      "_102_", "_103_104_")));
    string text = "_100_101_102_103_104_";
    global::System.Collections.Generic.IList<string> tokens
      = tokenizer.Tokenize(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", text));
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<string>("_100_101_",
      "_102_", "_103_104_"), tokens, null);
  }

  internal virtual void testTokenize_happyPath_8() {
    global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer tokenizer
      = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer(new global::System.Collections.Generic.HashSet<string>(global::DripSharp.Runtime.JavaCompat.AsList<string>("_100_101_102_",
      "_101_102_", "_103_104_")));
    string text = "_100_101_102_103_104_";
    global::System.Collections.Generic.IList<string> tokens
      = tokenizer.Tokenize(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", text));
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<string>("_100_101_102_",
      "_103_104_"), tokens, null);
  }

  internal virtual void testTokenize_happyPath_9() {
    global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer tokenizer
      = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer(new global::System.Collections.Generic.HashSet<string>(global::DripSharp.Runtime.JavaCompat.AsList<string>("_101_102_",
      "_101_102_")));
    string text = "_100_101_102_103_104_";
    global::System.Collections.Generic.IList<string> tokens
      = tokenizer.Tokenize(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", text));
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<string>("_100",
      "_101_102_", "_103_104_"), tokens, null);
  }

  internal virtual void testTokenize_happyPath_10() {
    global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer tokenizer
      = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.CompoundCharacterTokenizer(new global::System.Collections.Generic.HashSet<string>(global::DripSharp.Runtime.JavaCompat.AsList<string>("_201_",
      "_202_")));
    string text = "_100_101_102_103_104_";
    global::System.Collections.Generic.IList<string> tokens
      = tokenizer.Tokenize(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", text));
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ListOf<string>("_100_101_102_103_104_"),
      tokens, null);
  }

  [Xunit.Fact]
  public void __Upstream_1717786891_2f1e91976ecd201e() {
    try {
      this.testTokenize_happyPath_10();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2410717126_27ac9f8985ca6bb1() {
    try {
      this.testTokenize_happyPath_2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2410717127_56ae22523a47305d() {
    try {
      this.testTokenize_happyPath_3();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2410717128_7d73c939f9033ea9() {
    try {
      this.testTokenize_happyPath_4();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2410717129_e89bc6a04e7cecda() {
    try {
      this.testTokenize_happyPath_5();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2410717130_bfc9734298d1ae8a() {
    try {
      this.testTokenize_happyPath_6();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2410717131_fae1dfe96df1d1a5() {
    try {
      this.testTokenize_happyPath_7();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2410717132_1bb50cdaac12626c() {
    try {
      this.testTokenize_happyPath_8();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2410717133_900bf68791ce2320() {
    try {
      this.testTokenize_happyPath_9();
    } finally {
    }
  }
}
