// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf.Gsub;

public class GsubWorkerForAaltTest {
internal virtual void testFoglihtenNo07() {
global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup cmapLookup;
global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorker gsubWorkerForAlt;
using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf = ((global::DripSharp.PdfCarton.Fonts.Ttf.OpenTypeFont)(((global::DripSharp.PdfCarton.Fonts.Ttf.OpenTypeFont)(new global::DripSharp.PdfCarton.Fonts.Ttf.OTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "src/test/resources/otf/FoglihtenNo07.otf")))))))) {
cmapLookup = ttf.GetUnicodeCmapLookup();
gsubWorkerForAlt = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForAalt(ttf.GetGsubData());
}
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.AsList<int>(1139, 1562, 1477), gsubWorkerForAlt.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Abc"), cmapLookup)), null);
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
public void __Upstream_4107968550_cd26e3f76985e407()
{
        try
        {
            this.testFoglihtenNo07();
        }
        finally
        {
        }
}
}
