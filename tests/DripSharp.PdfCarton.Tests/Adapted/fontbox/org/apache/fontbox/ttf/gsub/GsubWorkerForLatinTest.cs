// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf.Gsub;

public class GsubWorkerForLatinTest {
internal virtual void testApplyLigaturesCalibri() {
global::System.IO.FileInfo file = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "c:/windows/fonts/calibri.ttf"));
global::DripSharp.Testing.JavaAssertions.AssumeTrue(global::DripSharp.Runtime.PdfCartonFontDiscovery.FileExists(file), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "calibri ligature test skipped"));
global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup cmapLookup;
global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorker gsubWorkerForLatin;
using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(file))) {
cmapLookup = ttf.GetUnicodeCmapLookup();
gsubWorkerForLatin = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerFactory().GetGsubWorker(cmapLookup, ttf.GetGsubData());
}
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<int>(286, 299, 286, 272, 415, 448, 286), gsubWorkerForLatin.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "effective"), cmapLookup)), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<int>(258, 427, 410, 437, 282, 286), gsubWorkerForLatin.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "attitude"), cmapLookup)), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<int>(258, 312, 367, 349, 258, 410, 286), gsubWorkerForLatin.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "affiliate"), cmapLookup)), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<int>(302, 367, 373), gsubWorkerForLatin.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "film"), cmapLookup)), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<int>(327, 381, 258, 410), gsubWorkerForLatin.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "float"), cmapLookup)), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<int>(393, 367, 258, 414, 381, 396, 373), gsubWorkerForLatin.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "platform"), cmapLookup)), null);
}

internal virtual void testApplyLigaturesFoglihtenNo07() {
global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup cmapLookup;
global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorker gsubWorkerForLatin;
using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf = new global::DripSharp.PdfCarton.Fonts.Ttf.OTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "src/test/resources/otf/FoglihtenNo07.otf")))) {
cmapLookup = ttf.GetUnicodeCmapLookup();
gsubWorkerForLatin = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerFactory().GetGsubWorker(cmapLookup, ttf.GetGsubData());
}
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<int>(66, 1590, 645, 70), gsubWorkerForLatin.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "affine"), cmapLookup)), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<int>(538, 633, 85, 86, 69, 70), gsubWorkerForLatin.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "attitude"), cmapLookup)), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<int>(66, 1590, 525, 74, 683), gsubWorkerForLatin.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "affiliate"), cmapLookup)), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<int>(542, 1, 1591, 498), gsubWorkerForLatin.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "The film"), cmapLookup)), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<int>(542, 1, 45, 703, 85), gsubWorkerForLatin.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "The Last"), cmapLookup)), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<int>(81, 77, 538, 71, 80, 83, 78), gsubWorkerForLatin.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "platform"), cmapLookup)), null);
}

private global::System.Collections.Generic.IList<int> getGlyphIds(string word, global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup cmapLookup) {
global::System.Collections.Generic.IList<int> originalGlyphIds = new global::System.Collections.Generic.List<int>();
foreach (char unicodeChar in word.ToCharArray()) {
int glyphId = cmapLookup.GetGlyphId((int)(unicodeChar));
global::DripSharp.Testing.JavaAssertions.True((glyphId > 0), null);
global::DripSharp.Runtime.JavaCompat.Add(originalGlyphIds, glyphId);
}
return originalGlyphIds;
}

[Xunit.Fact]
public void __Upstream_3193805074_548fe841cdf062f3()
{
        try
        {
            this.testApplyLigaturesCalibri();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0962623436_ebe5899e8edb1712()
{
        try
        {
            this.testApplyLigaturesFoglihtenNo07();
        }
        finally
        {
        }
}
}
