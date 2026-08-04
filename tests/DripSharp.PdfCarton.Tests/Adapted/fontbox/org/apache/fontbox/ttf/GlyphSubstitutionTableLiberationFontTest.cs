// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf;

public class GlyphSubstitutionTableLiberationFontTest {
private global::DripSharp.PdfCarton.Fonts.Ttf.OpenTypeFont font = null!;

internal virtual void setUp() {
global::DripSharp.PdfCarton.Fonts.Ttf.OTFParser otfParser = new global::DripSharp.PdfCarton.Fonts.Ttf.OTFParser();
string fontPath = "src/test/resources/ttf/LiberationSans-Regular.ttf";
using (global::DripSharp.PdfCarton.IO.RandomAccessRead fontFile = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", fontPath))) {
this.font = otfParser.Parse(fontFile);
}
}

internal virtual void tearDown() {
this.font.Dispose();
}

internal virtual void getGsubDataDefault() {
global::DripSharp.PdfCarton.Fonts.Ttf.Model.GsubData gsubData = this.font.GetGsubData();
global::DripSharp.Testing.JavaAssertions.Equal("latn", gsubData.GetActiveScriptName(), null);
}

internal virtual void getGsubDataForUnsupportedScriptTag() {
global::DripSharp.PdfCarton.Fonts.Ttf.GlyphSubstitutionTable gsub = this.font.GetGsub();
global::DripSharp.PdfCarton.Fonts.Ttf.Model.GsubData gsubData = gsub.GetGsubData(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "<some_non_existent_script_tag>"));
global::DripSharp.Testing.JavaAssertions.Null(gsubData, null);
}

internal virtual void testGetGsubDataForCyrillic() {
global::DripSharp.PdfCarton.Fonts.Ttf.GlyphSubstitutionTable gsub = this.font.GetGsub();
string cyrillicScriptTag = "cyrl";
global::System.Collections.Generic.IList<string> expectedFeatures = global::DripSharp.Runtime.JavaCompat.AsList<string>("subs", "sups");
global::DripSharp.PdfCarton.Fonts.Ttf.Model.GsubData cyrillicGsubData = gsub.GetGsubData(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", cyrillicScriptTag));
global::DripSharp.Testing.JavaAssertions.NotNull(cyrillicGsubData, null);
global::DripSharp.Testing.JavaAssertions.Equal(cyrillicScriptTag, cyrillicGsubData.GetActiveScriptName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(new global::System.Collections.Generic.HashSet<string>(expectedFeatures), cyrillicGsubData.GetSupportedFeatures(), null);
}

internal virtual void getSupportedScriptTags() {
global::DripSharp.PdfCarton.Fonts.Ttf.GlyphSubstitutionTable gsub = this.font.GetGsub();
global::System.Collections.Generic.IList<string> expectedSet = global::DripSharp.Runtime.JavaCompat.AsList<string>("DFLT", "bopo", "copt", "cyrl", "grek", "hebr", "latn");
global::System.Collections.Generic.ISet<string> supportedScriptTags = gsub.GetSupportedScriptTags();
global::DripSharp.Testing.JavaAssertions.Equal(new global::System.Collections.Generic.HashSet<string>(expectedSet), supportedScriptTags, null);
}

internal virtual void checkGsubDataLoadingForAllSupportedScripts(string scriptTag) {
global::DripSharp.PdfCarton.Fonts.Ttf.GlyphSubstitutionTable gsub = this.font.GetGsub();
global::DripSharp.PdfCarton.Fonts.Ttf.Model.GsubData gsubData = gsub.GetGsubData(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", scriptTag));
global::DripSharp.Testing.JavaAssertions.NotNull(gsubData, null);
global::DripSharp.Testing.JavaAssertions.NotSame(global::DripSharp.PdfCarton.Fonts.Ttf.Model.GsubData.NoDataFound, gsubData, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Ttf.Model.Language.Unspecified, gsubData.GetLanguage(), null);
global::DripSharp.Testing.JavaAssertions.Equal(scriptTag, gsubData.GetActiveScriptName(), null);
}

[Xunit.Theory(DisplayName = "GSUB data is loaded for all scripts supported by the font")]
[Xunit.InlineData("DFLT")]
[Xunit.InlineData("bopo")]
[Xunit.InlineData("copt")]
[Xunit.InlineData("cyrl")]
[Xunit.InlineData("grek")]
[Xunit.InlineData("hebr")]
[Xunit.InlineData("latn")]
public void __Upstream_3262928867_4de03b1268950364(string scriptTag)
{
        this.setUp();
        try
        {
            this.checkGsubDataLoadingForAllSupportedScripts(scriptTag);
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact(DisplayName = "getGsubData() with no args yields latn")]
public void __Upstream_1566736072_3b6da8dabca59896()
{
        this.setUp();
        try
        {
            this.getGsubDataDefault();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact(DisplayName = "getGsubData() for an unsupported script yields null")]
public void __Upstream_4003505418_c3d6fc7d48362ae7()
{
        this.setUp();
        try
        {
            this.getGsubDataForUnsupportedScriptTag();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact(DisplayName = "All the script tags are loaded from GSUB as is")]
public void __Upstream_0568207260_017d79994e35c026()
{
        this.setUp();
        try
        {
            this.getSupportedScriptTags();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact(DisplayName = "getGsubData() for 'cyrl' tag yields GSUB features of Cyrillic script")]
public void __Upstream_0802860393_7883940a733cfe64()
{
        this.setUp();
        try
        {
            this.testGetGsubDataForCyrillic();
        }
        finally
        {
            this.tearDown();
        }
}
}
