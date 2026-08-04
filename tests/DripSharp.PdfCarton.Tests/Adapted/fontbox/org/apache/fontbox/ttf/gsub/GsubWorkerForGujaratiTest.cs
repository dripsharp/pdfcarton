// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf.Gsub;

public class GsubWorkerForGujaratiTest {
private const string LOHIT_GUJARATI_TTF = "src/test/resources/ttf/Lohit-Gujarati.ttf";

private global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup cmapLookup = null!;

private global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorker gsubWorkerForGujarati = null!;

internal virtual void init() {
using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForGujaratiTest.LOHIT_GUJARATI_TTF)))) {
this.cmapLookup = ttf.GetUnicodeCmapLookup();
this.gsubWorkerForGujarati = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerFactory().GetGsubWorker(this.cmapLookup, ttf.GetGsubData());
}
}

internal virtual void testApplyTransforms_akhn() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(330, 331, 304, 251);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForGujarati.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u0A95\u0ACD\u0AB7\u0A9C\u0ACD\u0A9E\u0AA4\u0ACD\u0AA4\u0AB6\u0ACD\u0AB0")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_rphf() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(98, 335);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForGujarati.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u0AB0\u0ACD\u0AB8")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_rkrf() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(242, 228, 250);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForGujarati.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u0AAA\u0ACD\u0AB0\u0A95\u0ACD\u0AB0\u0AB5\u0ACD\u0AB0")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_blwf() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(76, 332);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForGujarati.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u0A9F\u0ACD\u0AB0")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_half() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(205, 195, 206);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForGujarati.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u0AA4\u0ACD\u0A9A\u0ACD\u0AA5\u0ACD")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_vatu() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(237, 245, 233);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForGujarati.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u0AA4\u0ACD\u0AB0\u0AAD\u0ACD\u0AB0\u0A9C\u0ACD\u0AB0")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_cjct() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(309, 312, 305);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForGujarati.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u0AA6\u0ACD\u0AA7\u0AA6\u0ACD\u0AA8\u0AA6\u0ACD\u0AAF")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_pres() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(284, 294, 314, 315);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForGujarati.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u0A97\u0ACD\u0AA8\u0A9F\u0ACD\u0A9F\u0AAA\u0ACD\u0AA4\u0AB2\u0ACD\u0AB2")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_abvs() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(92, 255, 92, 258, 91, 102, 336);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForGujarati.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u0AB0\u0AC7\u0A82\u0AB0\u0AC8\u0A82\u0AB0\u0ACD\u0AAF\u0ABE\u0A82")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_blws() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(278, 76, 333, 337, 276);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForGujarati.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u0AB9\u0AC3\u0A9F\u0ACD\u0AB0\u0AC1\u0AA3\u0AC1\u0AB0\u0AC1")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_psts() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(280, 273, 92, 261);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForGujarati.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u0A9C\u0AC0\u0A88\u0A82\u0AB0\u0AC0\u0A82")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

private global::System.Collections.Generic.IList<int> getGlyphIds(string word) {
global::System.Collections.Generic.IList<int> originalGlyphIds = new global::System.Collections.Generic.List<int>();
foreach (char unicodeChar in word.ToCharArray()) {
int glyphId = this.cmapLookup.GetGlyphId((int)(unicodeChar));
global::DripSharp.Testing.JavaAssertions.True((glyphId > 0), null);
global::DripSharp.Runtime.JavaCompat.Add(originalGlyphIds, glyphId);
}
return originalGlyphIds;
}

[Xunit.Fact]
public void __Upstream_1544843194_64cf09de49397b6c()
{
        this.init();
        try
        {
            this.testApplyTransforms_abvs();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1544851404_970628c2c5698357()
{
        this.init();
        try
        {
            this.testApplyTransforms_akhn();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1544882613_3e2101edf90d38e4()
{
        this.init();
        try
        {
            this.testApplyTransforms_blwf();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1544882626_1718259dcbf97583()
{
        this.init();
        try
        {
            this.testApplyTransforms_blws();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1544909876_333ff5132449025d()
{
        this.init();
        try
        {
            this.testApplyTransforms_cjct();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1545050447_3d1a72aded422797()
{
        this.init();
        try
        {
            this.testApplyTransforms_half();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1545304908_b64494f99af68a89()
{
        this.init();
        try
        {
            this.testApplyTransforms_pres();
        }
        finally
        {
        }
}

[Xunit.Fact(Skip = "Upstream @Disabled/@Ignore has no reason.")]
public void __Upstream_1545306334_50f98026bc6ca84e()
{
        this.init();
        try
        {
            this.testApplyTransforms_psts();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1545358153_837c10fbf00bf1b0()
{
        this.init();
        try
        {
            this.testApplyTransforms_rkrf();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1545362648_7191efd2b013d7c1()
{
        this.init();
        try
        {
            this.testApplyTransforms_rphf();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1545467784_8c7009994332b318()
{
        this.init();
        try
        {
            this.testApplyTransforms_vatu();
        }
        finally
        {
        }
}
}
