// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf.Gsub;

public class GSUBTablePrintUtil {
public virtual void PrintCharacterToGlyph(global::DripSharp.PdfCarton.Fonts.Ttf.Model.GsubData gsubData, global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup cmap) {
global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Format:\n<Serial no.>.) <Space separated characters to be replaced> : ", "RawUnicode: [<Space separated unicode representation of each character "), "to be replaced in hexadecimal>] : <The compound character> : "), "<The GlyphId with which these characters are replaced>")));
global::System.Collections.Generic.IDictionary<int, global::System.Collections.Generic.IList<int>> rawGSubTableData = global::DripSharp.Runtime.JavaCompat.NewJavaDictionary<int, global::System.Collections.Generic.IList<int>>();
foreach (string featureName__52_21 in gsubData.GetSupportedFeatures()) {
global::DripSharp.PdfCarton.Fonts.Ttf.Model.ScriptFeature scriptFeature__54_27 = gsubData.GetFeature(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", featureName__52_21));
foreach (global::System.Collections.Generic.IList<int> glyphsToBeReplaced__55_32 in scriptFeature__54_27.GetAllGlyphIdsForSubstitution()) {
global::DripSharp.Runtime.JavaCompat.MapPut(rawGSubTableData, global::DripSharp.Runtime.JavaCompat.Unbox(scriptFeature__54_27.GetReplacementForGlyphs(glyphsToBeReplaced__55_32)), glyphsToBeReplaced__55_32);
}
}
foreach (string featureName__63_21 in gsubData.GetSupportedFeatures()) {
global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("******************      ", featureName__63_21), "      ******************")));
global::DripSharp.PdfCarton.Fonts.Ttf.Model.ScriptFeature scriptFeature__67_27 = gsubData.GetFeature(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", featureName__63_21));
int index = 0;
foreach (global::System.Collections.Generic.IList<int> glyphsToBeReplaced__69_32 in scriptFeature__67_27.GetAllGlyphIdsForSubstitution()) {
string unicodeText = this.getUnicodeString(rawGSubTableData, cmap, glyphsToBeReplaced__69_32);
global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(++index, ".) "), this.getExplainedUnicodeText(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", unicodeText))), " : "), scriptFeature__67_27.GetReplacementForGlyphs(glyphsToBeReplaced__69_32))));
}
}
}

private string getUnicodeChar(global::System.Collections.Generic.IDictionary<int, global::System.Collections.Generic.IList<int>> rawGSubTableData, global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup cmap, int? glyphId) {
global::System.Collections.Generic.IList<int> keyChars = cmap.GetCharCodes((int)(global::DripSharp.Runtime.JavaCompat.Unbox(glyphId)));
if ((keyChars == default!)) {
global::System.Collections.Generic.IList<int> constituentGlyphs = global::DripSharp.Runtime.JavaCompat.MapGet(rawGSubTableData, glyphId);
if (((constituentGlyphs == default!) || global::DripSharp.Runtime.JavaCompat.ListIsEmpty(constituentGlyphs))) {
string message = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("lookup for the glyphId: ", glyphId), " failed, as no corresponding Unicode char found mapped to it");
throw new global::System.InvalidOperationException(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", message));
} else {
return this.getUnicodeString(rawGSubTableData, cmap, constituentGlyphs);
}
} else {
global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();
foreach (int unicodeChar in keyChars) {
sb.Append(unchecked((char)(unchecked((char)(unicodeChar)))));
}
return sb.ToString();
}
}

private string getUnicodeString(global::System.Collections.Generic.IDictionary<int, global::System.Collections.Generic.IList<int>> rawGSubTableData, global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup cmap, global::System.Collections.Generic.IList<int> glyphIDs) {
global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();
foreach (int glyphId in glyphIDs) {
sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", this.getUnicodeChar(rawGSubTableData, cmap, glyphId)));
}
return sb.ToString();
}

private string getExplainedUnicodeText(string unicodeText) {
global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();
foreach (char unicode__128_19 in unicodeText.ToCharArray()) {
sb.Append(unicode__128_19).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", " "));
}
sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", ":"));
sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", " RawUnicode: ["));
foreach (char unicode__135_19 in unicodeText.ToCharArray()) {
sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "\\u0")).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.ToHexString((int)(unicode__135_19)).ToUpper())).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", " "));
}
sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "] : "));
sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", unicodeText));
return sb.ToString();
}
}
