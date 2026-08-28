// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf.Gsub;

public class GsubWorkerForDfltTest {
  private const string JOSEFIN_SANS_TTF = "src/test/resources/ttf/JosefinSans-Italic.ttf";

  private static global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup cmapLookup = null!;

  private static global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorker gsubWorkerForDflt = null!;

  internal static void init() {
    using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf
      = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForDfltTest.JOSEFIN_SANS_TTF)))) {
      global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForDfltTest.cmapLookup
        = ttf.GetUnicodeCmapLookup();
      global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForDfltTest.gsubWorkerForDflt
        = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerFactory().GetGsubWorker(global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForDfltTest.cmapLookup,
        ttf.GetGsubData());
    }
  }

  internal virtual void testCorrectWorkerType() {
    global::DripSharp.Testing.JavaAssertions.InstanceOf<global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForDflt>(global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForDfltTest.gsubWorkerForDflt,
      null);
  }

  internal static global::System.Collections.Generic.IEnumerable<object[]> provideTransformTestCases() {
    return global::DripSharp.Runtime.JavaCompat.StreamOf(new object[] { "code",
        global::DripSharp.Runtime.JavaCompat.AsList<int>(229, 293, 235, 237),
      "no ligature sequences" }, new object[] { "fi",
        global::DripSharp.Runtime.JavaCompat.ListOf<int>(407), "fi -> ligature" },
      new object[] { "office", global::DripSharp.Runtime.JavaCompat.AsList<int>(293, 257, 407, 229,
        237), "ffi -> f + fi-ligature" }, new object[] { "ffl",
        global::DripSharp.Runtime.JavaCompat.AsList<int>(257, 408), "ffl -> f + fl-ligature" });
  }

  internal virtual void testApplyTransforms(string input,
    global::System.Collections.Generic.IList<int> expectedGlyphs, string description) {
    global::System.Collections.Generic.IList<int> result
      = global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForDfltTest.gsubWorkerForDflt.ApplyTransforms(global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForDfltTest.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      input)));
    global::DripSharp.Testing.JavaAssertions.Equal(expectedGlyphs, result, null);
  }

  internal virtual void testApplyTransforms_immutableResult() {
    global::System.Collections.Generic.IList<int> result
      = global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForDfltTest.gsubWorkerForDflt.ApplyTransforms(global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForDfltTest.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "abc")));
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => global::DripSharp.Runtime.JavaCompat.Add(result, 999), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => global::DripSharp.Runtime.JavaCompat.ListRemove(result, 0), null);
  }

  private static global::System.Collections.Generic.IList<int> getGlyphIds(string word) {
    global::System.Collections.Generic.IList<int> originalGlyphIds
      = new global::System.Collections.Generic.List<int>();
    foreach (char unicodeChar in word.ToCharArray()) {
      int glyphId
        = global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForDfltTest.cmapLookup.GetGlyphId((int)(unicodeChar));
      global::DripSharp.Testing.JavaAssertions.True((glyphId > 0), null);
      global::DripSharp.Runtime.JavaCompat.Add(originalGlyphIds, glyphId);
    }
    return originalGlyphIds;
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_17172efc8d986a19() {
    foreach (var value in provideTransformTestCases()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::System.Collections.Generic.IList<int>>(row[1]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[2]) };
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_17172efc8d986a19))]
  public void __Upstream_1529212323_fc2a9684e4629306(string input,
    global::System.Collections.Generic.IList<int> expectedGlyphs, string description) {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testApplyTransforms(input, expectedGlyphs, description);
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3935027619_8da1e13420b64b21() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testApplyTransforms_immutableResult();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2078957936_945eef91d467cdb7() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testCorrectWorkerType();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

  private static bool __RunUpstreamBeforeAll() {
    init();
    return true;
  }
}
