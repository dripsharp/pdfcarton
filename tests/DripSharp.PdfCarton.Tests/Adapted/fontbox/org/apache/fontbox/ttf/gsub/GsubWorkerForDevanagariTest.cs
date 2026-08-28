// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf.Gsub;

public class GsubWorkerForDevanagariTest {
  private const string LOHIT_DEVANAGARI_TTF = "src/test/resources/ttf/Lohit-Devanagari.ttf";

  private global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup cmapLookup = null!;

  private global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorker gsubWorkerForDevanagari = null!;

  internal virtual void init() {
    using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForDevanagariTest.LOHIT_DEVANAGARI_TTF)))) {
      this.cmapLookup = ttf.GetUnicodeCmapLookup();
      this.gsubWorkerForDevanagari
        = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerFactory().GetGsubWorker(this.cmapLookup,
        ttf.GetGsubData());
    }
  }

  internal virtual void testApplyTransforms_locl() {
    global::System.Collections.Generic.IList<int> glyphsAfterGsub
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(642);
    global::System.Collections.Generic.IList<int> result
      = this.gsubWorkerForDevanagari.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "\u092A\u094D\u0924")));
    global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
  }

  internal virtual void testApplyTransforms_nukt() {
    global::System.Collections.Generic.IList<int> glyphsAfterGsub
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(400, 396, 393);
    global::System.Collections.Generic.IList<int> result
      = this.gsubWorkerForDevanagari.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "\u092F\u093C\u091C\u093C\u0915\u093C")));
    global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
  }

  internal virtual void testApplyTransforms_akhn() {
    global::System.Collections.Generic.IList<int> glyphsAfterGsub
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(520, 521);
    global::System.Collections.Generic.IList<int> result
      = this.gsubWorkerForDevanagari.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "\u0915\u094D\u0937\u091C\u094D\u091E")));
    global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
  }

  internal virtual void testApplyTransforms_rphf() {
    global::System.Collections.Generic.IList<int> glyphsAfterGsub
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(513);
    global::System.Collections.Generic.IList<int> result
      = this.gsubWorkerForDevanagari.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "\u0930\u094D")));
    global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
  }

  internal virtual void testApplyTransforms_rkrf() {
    global::System.Collections.Generic.IList<int> glyphsAfterGsub
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(588, 597, 595, 602);
    global::System.Collections.Generic.IList<int> result
      = this.gsubWorkerForDevanagari.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "\u0915\u094D\u0930\u092C\u094D\u0930\u092A\u094D\u0930\u0939\u094D\u0930")));
    global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
  }

  internal virtual void testApplyTransforms_blwf() {
    global::System.Collections.Generic.IList<int> glyphsAfterGsub
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(602, 336, 516);
    global::System.Collections.Generic.IList<int> result
      = this.gsubWorkerForDevanagari.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "\u0939\u094D\u0930\u091F\u094D\u0930")));
    global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
  }

  internal virtual void testApplyTransforms_half() {
    global::System.Collections.Generic.IList<int> glyphsAfterGsub
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(558, 557, 546, 537);
    global::System.Collections.Generic.IList<int> result
      = this.gsubWorkerForDevanagari.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "\u0939\u094D\u0938\u094D\u092D\u094D\u0924\u094D")));
    global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
  }

  internal virtual void testApplyTransforms_vatu() {
    global::System.Collections.Generic.IList<int> glyphsAfterGsub
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(517, 593, 601, 665);
    global::System.Collections.Generic.IList<int> result
      = this.gsubWorkerForDevanagari.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "\u0936\u094D\u0930\u0924\u094D\u0930\u0938\u094D\u0930\u0918\u094D\u0930")));
    global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
  }

  internal virtual void testApplyTransforms_cjct() {
    global::System.Collections.Generic.IList<int> glyphsAfterGsub
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(638, 688, 636, 640, 639);
    global::System.Collections.Generic.IList<int> result
      = this.gsubWorkerForDevanagari.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "\u0926\u094D\u092E\u0926\u094D\u0927\u094D\u0930\u094D\u092F\u092C\u094D\u0926\u0926\u094D\u0935\u0926\u094D\u092F")));
    global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
  }

  internal virtual void testApplyTransforms_pres() {
    global::System.Collections.Generic.IList<int> glyphsAfterGsub
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(603, 605, 617, 652);
    global::System.Collections.Generic.IList<int> result
      = this.gsubWorkerForDevanagari.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "\u0936\u0943\u0915\u094D\u0924\u091C\u094D\u091C\u0939\u094D\u0923")));
    global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
  }

  internal virtual void testApplyTransforms_abvs() {
    global::System.Collections.Generic.IList<int> glyphsAfterGsub
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(353, 512, 353, 675, 353, 673);
    global::System.Collections.Generic.IList<int> result
      = this.gsubWorkerForDevanagari.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "\u0930\u094D\u0930\u0948\u0902\u0930\u094C\u0902\u0930\u094D\u0930\u094B")));
    global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
  }

  internal virtual void testApplyTransforms_blws() {
    global::System.Collections.Generic.IList<int> glyphsAfterGsub
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(660, 663, 336, 584, 336, 583);
    global::System.Collections.Generic.IList<int> result
      = this.gsubWorkerForDevanagari.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "\u0926\u0943\u0939\u0943\u091F\u094D\u0930\u0942\u091F\u094D\u0930\u0941")));
    global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
  }

  internal virtual void testApplyTransforms_psts() {
    global::System.Collections.Generic.IList<int> glyphsAfterGsub
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(326, 704, 326, 582, 661, 662);
    global::System.Collections.Generic.IList<int> result
      = this.gsubWorkerForDevanagari.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "\u0915\u093F\u0902\u0930\u094D\u0915\u0940\u0902\u0930\u0941\u0930\u0942")));
    global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
  }

  internal virtual void testApplyTransforms_haln() {
    global::System.Collections.Generic.IList<int> glyphsAfterGsub
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(539);
    global::System.Collections.Generic.IList<int> result
      = this.gsubWorkerForDevanagari.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "\u0926\u094D")));
    global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
  }

  internal virtual void testApplyTransforms_calt() {
    global::System.Collections.Generic.IList<int> glyphsAfterGsub
      = global::DripSharp.Runtime.JavaCompat.AsList<int>();
    global::System.Collections.Generic.IList<int> result
      = this.gsubWorkerForDevanagari.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "")));
    global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
  }

  private global::System.Collections.Generic.IList<int> getGlyphIds(string word) {
    global::System.Collections.Generic.IList<int> originalGlyphIds
      = new global::System.Collections.Generic.List<int>();
    foreach (char unicodeChar in word.ToCharArray()) {
      int glyphId = this.cmapLookup.GetGlyphId((int)(unicodeChar));
      global::DripSharp.Testing.JavaAssertions.True((glyphId > 0), null);
      global::DripSharp.Runtime.JavaCompat.Add(originalGlyphIds, glyphId);
    }
    return originalGlyphIds;
  }

  [Xunit.Fact(Skip = "Upstream @Disabled/@Ignore has no reason.")]
  public void __Upstream_1544843194_ec25d622854edb48() {
    this.init();
    try {
      this.testApplyTransforms_abvs();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1544851404_7e73d486cdc6f8a8() {
    this.init();
    try {
      this.testApplyTransforms_akhn();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1544882613_1becb41180891b64() {
    this.init();
    try {
      this.testApplyTransforms_blwf();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1544882626_83ada7058615ebcb() {
    this.init();
    try {
      this.testApplyTransforms_blws();
    } finally {
    }
  }

  [Xunit.Fact(Skip = "Upstream @Disabled/@Ignore has no reason.")]
  public void __Upstream_1544909876_b5013940d030d0f5() {
    this.init();
    try {
      this.testApplyTransforms_cjct();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1545050447_fee75e70508a25b8() {
    this.init();
    try {
      this.testApplyTransforms_half();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1545050455_9b7f0f246d5b3946() {
    this.init();
    try {
      this.testApplyTransforms_haln();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1545182792_d4305306f531ac5d() {
    this.init();
    try {
      this.testApplyTransforms_locl();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1545248396_93b5bb2b1a5fe141() {
    this.init();
    try {
      this.testApplyTransforms_nukt();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1545304908_ebdabf6fdce107b5() {
    this.init();
    try {
      this.testApplyTransforms_pres();
    } finally {
    }
  }

  [Xunit.Fact(Skip = "Upstream @Disabled/@Ignore has no reason.")]
  public void __Upstream_1545306334_80e916630aa2b45a() {
    this.init();
    try {
      this.testApplyTransforms_psts();
    } finally {
    }
  }

  [Xunit.Fact(Skip = "Upstream @Disabled/@Ignore has no reason.")]
  public void __Upstream_1545358153_95f6289b20e8bbc8() {
    this.init();
    try {
      this.testApplyTransforms_rkrf();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1545362648_b5fb160c7c4c1095() {
    this.init();
    try {
      this.testApplyTransforms_rphf();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1545467784_1820af65dfc86761() {
    this.init();
    try {
      this.testApplyTransforms_vatu();
    } finally {
    }
  }
}
