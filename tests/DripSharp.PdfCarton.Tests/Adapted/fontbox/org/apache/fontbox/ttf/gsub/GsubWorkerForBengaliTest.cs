// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf.Gsub;

public class GsubWorkerForBengaliTest {
private const string LOHIT_BENGALI_TTF = "src/test/resources/ttf/Lohit-Bengali.ttf";

private global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup cmapLookup = null!;

private global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorker gsubWorkerForBengali = null!;

internal virtual void init() {
using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForBengaliTest.LOHIT_BENGALI_TTF)))) {
this.cmapLookup = ttf.GetUnicodeCmapLookup();
this.gsubWorkerForBengali = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerFactory().GetGsubWorker(this.cmapLookup, ttf.GetGsubData());
}
}

internal virtual void testApplyTransforms_simple_hosshoi_kar() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(56, 102, 91);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForBengali.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u0986\u09AE\u09BF")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_ja_phala() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(89, 156, 101, 97);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForBengali.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u09AC\u09CD\u09AF\u09BE\u09B8")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_e_kar() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(438, 89, 94, 101);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForBengali.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u09AC\u09C7\u09B2\u09BE")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_o_kar() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(108, 89, 101, 97);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForBengali.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u09AC\u09CB\u09B8")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_o_kar_repeated_1_not_working_yet() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(108, 96, 101, 108, 94, 101);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForBengali.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u09B7\u09CB\u09B2\u09CB")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_o_kar_repeated_2_not_working_yet() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(108, 73, 101, 108, 77, 101);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForBengali.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u099B\u09CB\u099F\u09CB")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_ou_kar() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(108, 91, 114, 94);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForBengali.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u09AE\u09CC\u09B2")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_oi_kar() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(439, 89, 93);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForBengali.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u09AC\u09C8\u09B0")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_kha_e_murddhana_swa_e_khiwa() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(167, 103, 438, 93, 93);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForBengali.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u0995\u09CD\u09B7\u09C0\u09B0\u09C7\u09B0")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_ra_phala() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(274, 82);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForBengali.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u09A6\u09CD\u09B0\u09C1\u09A4")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_ref() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(85, 104, 440, 82);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForBengali.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u09A7\u09C1\u09B0\u09CD\u09A4")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_ra_e_hosshu() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(352, 108, 87, 101);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForBengali.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u09B0\u09C1\u09AA\u09CB")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_la_e_la_e() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(67, 108, 369, 101, 94);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForBengali.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u0995\u09B2\u09CD\u09B2\u09CB\u09B2")));
global::DripSharp.Testing.JavaAssertions.Equal(glyphsAfterGsub, result, null);
}

internal virtual void testApplyTransforms_khanda_ta() {
global::System.Collections.Generic.IList<int> glyphsAfterGsub = global::DripSharp.Runtime.JavaCompat.AsList<int>(98, 78, 101, 113);
global::System.Collections.Generic.IList<int> result = this.gsubWorkerForBengali.ApplyTransforms(this.getGlyphIds(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\u09B9\u09A0\u09BE\u09CE")));
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
public void __Upstream_0649092454_d256a0754f016b63()
{
        this.init();
        try
        {
            this.testApplyTransforms_e_kar();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2739756722_9bc1a4d91f6d5d38()
{
        this.init();
        try
        {
            this.testApplyTransforms_ja_phala();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3386201920_b64d24400a94924e()
{
        this.init();
        try
        {
            this.testApplyTransforms_kha_e_murddhana_swa_e_khiwa();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2549438921_cf0af7951ce94674()
{
        this.init();
        try
        {
            this.testApplyTransforms_khanda_ta();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3685222947_a217bce05f7959c9()
{
        this.init();
        try
        {
            this.testApplyTransforms_la_e_la_e();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0658327664_2cc46deab84fbfdf()
{
        this.init();
        try
        {
            this.testApplyTransforms_o_kar();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3237175315_7bbb73e0d3330b8a()
{
        this.init();
        try
        {
            this.testApplyTransforms_oi_kar();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3248257567_763348686d7f0c05()
{
        this.init();
        try
        {
            this.testApplyTransforms_ou_kar();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0153451906_061392c7fef8e0ea()
{
        this.init();
        try
        {
            this.testApplyTransforms_ra_e_hosshu();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3797337514_7deef6786dbeacfb()
{
        this.init();
        try
        {
            this.testApplyTransforms_ra_phala();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1435323383_eb809bff362214be()
{
        this.init();
        try
        {
            this.testApplyTransforms_ref();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1300262375_a1571056b53f2888()
{
        this.init();
        try
        {
            this.testApplyTransforms_simple_hosshoi_kar();
        }
        finally
        {
        }
}
}
