// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf;

public class GlyphSubstitutionTableTest {
internal const int DATA_POSITION_FOR_GSUB_TABLE = 120544;

private static readonly global::System.Collections.Generic.ICollection<string> EXPECTED_FEATURE_NAMES = global::DripSharp.Runtime.JavaCompat.AsList<string>("abvs", "akhn", "blwf", "blws", "half", "haln", "init", "nukt", "pres", "pstf", "rphf", "vatu");

internal virtual void testGetGsubData() {
using (global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Fonts.Ttf.GSUBTableDebugger), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "/ttf/Lohit-Bengali.ttf"))) using (global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer rarb = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(@is)) using (global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream rarbds = new global::DripSharp.PdfCarton.Fonts.Ttf.RandomAccessReadDataStream(rarb)) {
rarbds.Seek((long)(global::DripSharp.PdfCarton.Fonts.Ttf.GlyphSubstitutionTableTest.DATA_POSITION_FOR_GSUB_TABLE));
global::DripSharp.PdfCarton.Fonts.Ttf.GlyphSubstitutionTable testClass = new global::DripSharp.PdfCarton.Fonts.Ttf.GlyphSubstitutionTable();
testClass.read((global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont)default!, rarbds);
global::DripSharp.PdfCarton.Fonts.Ttf.Model.GsubData gsubData = testClass.GetGsubData();
global::DripSharp.Testing.JavaAssertions.NotNull(gsubData, null);
global::DripSharp.Testing.JavaAssertions.NotEqual(global::DripSharp.PdfCarton.Fonts.Ttf.Model.GsubData.NoDataFound, gsubData, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Ttf.Model.Language.Bengali, gsubData.GetLanguage(), null);
global::DripSharp.Testing.JavaAssertions.Equal("bng2", gsubData.GetActiveScriptName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(new global::System.Collections.Generic.HashSet<string>(global::DripSharp.PdfCarton.Fonts.Ttf.GlyphSubstitutionTableTest.EXPECTED_FEATURE_NAMES), gsubData.GetSupportedFeatures(), null);
string templatePathToFile = "/gsub/lohit_bengali/bng2/%s.txt";
foreach (string featureName in global::DripSharp.PdfCarton.Fonts.Ttf.GlyphSubstitutionTableTest.EXPECTED_FEATURE_NAMES) {
global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.Concat("******* Testing feature: ", featureName)));
global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.Concat("******* Testing feature: ", featureName)));
global::System.Collections.Generic.IDictionary<global::System.Collections.Generic.IList<int>, int> expectedGsubTableRawData = this.getExpectedGsubTableRawData(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.JavaStringFormat(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", templatePathToFile), featureName)));
global::DripSharp.PdfCarton.Fonts.Ttf.Model.ScriptFeature scriptFeature = new global::DripSharp.PdfCarton.Fonts.Ttf.Model.MapBackedScriptFeature(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", featureName), expectedGsubTableRawData);
global::DripSharp.Testing.JavaAssertions.Equal(scriptFeature, gsubData.GetFeature(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", featureName)), null);
}
}
}

private global::System.Collections.Generic.IDictionary<global::System.Collections.Generic.IList<int>, int> getExpectedGsubTableRawData(string pathToResource) {
global::System.Collections.Generic.IDictionary<global::System.Collections.Generic.IList<int>, int> gsubData = global::DripSharp.Runtime.JavaCompat.NewJavaDictionary<global::System.Collections.Generic.IList<int>, int>();
using (global::System.IO.TextReader br = global::DripSharp.PdfCarton.Tests.Support.NewInputStreamReader(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Fonts.Ttf.TestTTFParser), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", pathToResource)), global::DripSharp.Runtime.JavaStandardCharsets.USASCII)) {
while (true) {
string line = br.ReadLine();
if ((line == default!)) {
break;
}
if ((global::DripSharp.Runtime.JavaCompat.StringTrim(line).Length == 0)) {
continue;
}
if (global::DripSharp.Runtime.JavaCompat.StringStartsWith(line, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "#"))) {
continue;
}
string[] lineSplittedByKeyValue = global::DripSharp.Runtime.JavaCompat.StringSplit(line, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "="), 0);
if ((lineSplittedByKeyValue.Length != 2)) {
throw new global::System.ArgumentException(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "invalid format"));
}
global::System.Collections.Generic.IList<int> oldGlyphIds = new global::System.Collections.Generic.List<int>();
foreach (string value in global::DripSharp.Runtime.JavaCompat.StringSplit(lineSplittedByKeyValue[0], global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", ","), 0)) {
global::DripSharp.Runtime.JavaCompat.Add(oldGlyphIds, global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", value), 10));
}
int newGlyphId = global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", lineSplittedByKeyValue[1]), 10);
global::DripSharp.Runtime.JavaCompat.MapPut(gsubData, oldGlyphIds, newGlyphId);
}
}
return gsubData;
}

[Xunit.Fact]
public void __Upstream_0817725767_85885688e65ce532()
{
        try
        {
            this.testGetGsubData();
        }
        finally
        {
        }
}
}
