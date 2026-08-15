// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Font;

public class TestFontEmbedding {
private static readonly global::System.IO.FileInfo OUT_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output"));

private static readonly global::System.IO.FileInfo IN_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "src/test/resources/org/apache/pdfbox/ttf"));

internal static void setUp() {
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR);
}

internal virtual void testCIDFontType2() {
this.validateCIDFontType2(false);
}

internal virtual void testCIDFontType2Subset() {
this.validateCIDFontType2(true);
}

internal virtual void testCIDFontType2VerticalSubsetMonospace() {
string text = "\u300CABC\u300D";
string expectedExtractedtext = "\u300C\nA\nB\nC\n\u300D";
global::System.IO.FileInfo pdf = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "CIDFontType2VM.pdf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
document.AddPage(page);
global::System.IO.FileInfo ipafont = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/fonts/ipag00303"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ipag.ttf"));
global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font vfont = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.LoadVertical(document, ipafont);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document, page)) {
contentStream.BeginText();
contentStream.SetFont(vfont, (float)(20));
contentStream.NewLineAtOffset((float)(50), (float)(700));
contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", text));
contentStream.EndText();
}
sbyte[] encode = vfont.Encode(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", text));
int cid = (((encode[0] & 255) << unchecked((int)(8))) + (encode[1] & 255));
global::DripSharp.Testing.JavaAssertions.Equal(7392, cid, null);
global::DripSharp.PdfCarton.Cos.COSDictionary fontDict = vfont.GetCOSObject();
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.IdentityV, fontDict.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Encoding), null);
document.Save(pdf);
global::DripSharp.PdfCarton.Cos.COSDictionary descFontDict = vfont.GetDescendantFont().GetCOSObject();
global::DripSharp.PdfCarton.Cos.COSArray dw2 = (global::DripSharp.PdfCarton.Cos.COSArray)(descFontDict.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Dw2)!);
global::DripSharp.Testing.JavaAssertions.Null(dw2, null);
global::DripSharp.PdfCarton.Cos.COSArray w2 = (global::DripSharp.PdfCarton.Cos.COSArray)(descFontDict.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.W2)!);
global::DripSharp.Testing.JavaAssertions.Equal(0, w2.Size(), null);
}
string extracted = this.getUnicodeText(pdf);
global::DripSharp.Testing.JavaAssertions.Equal(expectedExtractedtext, global::DripSharp.Runtime.JavaCompat.StringTrim(global::DripSharp.Runtime.JavaCompat.StringReplaceAll(extracted, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "\r"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ""))), null);
}

internal virtual void testCIDFontType2VerticalSubsetProportional() {
string text = "\u300CABC\u300D";
string expectedExtractedtext = "\u300C\nA\nB\nC\n\u300D";
global::System.IO.FileInfo pdf = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "CIDFontType2VP.pdf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
document.AddPage(page);
global::System.IO.FileInfo ipafont = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/fonts/ipagp00303"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ipagp.ttf"));
global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font vfont = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.LoadVertical(document, ipafont);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document, page)) {
contentStream.BeginText();
contentStream.SetFont(vfont, (float)(20));
contentStream.NewLineAtOffset((float)(50), (float)(700));
contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", text));
contentStream.EndText();
}
sbyte[] encode = vfont.Encode(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", text));
int cid = (((encode[0] & 255) << unchecked((int)(8))) + (encode[1] & 255));
global::DripSharp.Testing.JavaAssertions.Equal(12607, cid, null);
global::DripSharp.PdfCarton.Cos.COSDictionary fontDict = vfont.GetCOSObject();
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.IdentityV, fontDict.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Encoding), null);
document.Save(pdf);
global::DripSharp.PdfCarton.Cos.COSDictionary descFontDict = vfont.GetDescendantFont().GetCOSObject();
global::DripSharp.PdfCarton.Cos.COSArray dw2 = (global::DripSharp.PdfCarton.Cos.COSArray)(descFontDict.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Dw2)!);
global::DripSharp.Testing.JavaAssertions.Null(dw2, null);
global::DripSharp.PdfCarton.Cos.COSArray w2 = (global::DripSharp.PdfCarton.Cos.COSArray)(descFontDict.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.W2)!);
global::DripSharp.Testing.JavaAssertions.Equal(2, w2.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal(12607, w2.GetInt(0), null);
global::DripSharp.PdfCarton.Cos.COSArray metrics = (global::DripSharp.PdfCarton.Cos.COSArray)(w2.GetObject(1)!);
int i = 0;
foreach (int n in new int[] { -570, 500, 450, -570, 500, 880 }) {
global::DripSharp.Testing.JavaAssertions.Equal(n, metrics.GetInt(i++), null);
}
}
string extracted = this.getUnicodeText(pdf);
global::DripSharp.Testing.JavaAssertions.Equal(expectedExtractedtext, global::DripSharp.Runtime.JavaCompat.StringTrim(global::DripSharp.Runtime.JavaCompat.StringReplaceAll(extracted, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "\r"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ""))), null);
}

internal virtual void testBengali() {
string BANGLA_TEXT_1 = "\u0986\u09AE\u09BF \u0995\u09CB\u09A8 \u09AA\u09A5\u09C7 \u0995\u09CD\u09B7\u09C0\u09B0\u09C7\u09B0 \u09B2\u0995\u09CD\u09B7\u09CD\u09AE\u09C0 \u09B7\u09A8\u09CD\u09A1 \u09AA\u09C1\u09A4\u09C1\u09B2 \u09B0\u09C1\u09AA\u09CB \u0997\u0999\u09CD\u0997\u09BE \u098B\u09B7\u09BF";
string BANGLA_TEXT_2 = "\u09A6\u09CD\u09B0\u09C1\u09A4 \u0997\u09BE\u09A2\u09BC \u09B6\u09C7\u09AF\u09BC\u09BE\u09B2 \u0985\u09B2\u09B8 \u0995\u09C1\u0995\u09C1\u09B0 \u099C\u09C1\u09A1\u09BC\u09C7 \u099C\u09BE\u09AE\u09CD\u09AA \u09A7\u09C1\u09B0\u09CD\u09A4  \u09B9\u09A0\u09BE\u09CE \u09AD\u09BE\u0999\u09C7\u09A8\u09BF \u09AE\u09CC\u09B2\u09BF\u0995 \u0990\u09B6\u09BF \u09A6\u09C8";
string BANGLA_TEXT_3 = "\u098B\u09B7\u09BF \u0995\u09B2\u09CD\u09B2\u09CB\u09B2 \u09AC\u09CD\u09AF\u09BE\u09B8 \u09A8\u09BF\u09B0\u09CD\u09AD\u09DF ";
string expectedExtractedtext = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(BANGLA_TEXT_1, "\n"), BANGLA_TEXT_2), "\n"), BANGLA_TEXT_3);
global::System.IO.FileInfo pdf = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Bengali.pdf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
document.AddPage(page);
global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(document, global::DripSharp.PdfCarton.Tests.Support.ResourceStream(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "/org/apache/pdfbox/ttf/Lohit-Bengali.ttf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document, page)) {
contentStream.BeginText();
contentStream.SetFont(font, (float)(18));
contentStream.NewLineAtOffset((float)(10), (float)(750));
contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", BANGLA_TEXT_1));
contentStream.NewLineAtOffset((float)(0), (float)(-30));
contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", BANGLA_TEXT_2));
contentStream.NewLineAtOffset((float)(0), (float)(-30));
contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", BANGLA_TEXT_3));
contentStream.EndText();
}
document.Save(pdf);
}
if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.DoTestFile(pdf, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.IN_DIR.FullName), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR.FullName)))) {
global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Rendering of ", pdf), " failed or is not identical to expected rendering in "), global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.IN_DIR), " directory")));
}
string extracted = this.getUnicodeText(pdf);
}

internal virtual void testDevanagari() {
string DEVANAGARI_TEXT_0 = "\u092A\u094D\u0930\u0926\u0947\u0936 \u0917\u094D\u0930\u093E\u092E\u0940\u0923 \u0935\u094D\u092F\u0935\u0938\u093E\u092F\u093F\u0915, \u0932\u0915\u094D\u0937\u094D\u092E\u093F\u092A\u0924\u093F, \u0932\u0915\u094D\u0937\u093F\u0924, \u092E\u0915\u094D\u0916\u093F \u0909\u092A\u0932\u092C\u094D\u0927\u093F, \u092A\u094D\u0930\u0938\u093F\u0926\u094D\u0927\u093F";
string DEVANAGARI_TEXT_1 = "\u0915\u094D\u0937\u0924\u094D\u0930\u093F\u092F \u091C\u094D\u091E\u093E\u0928\u0940 \u0915\u093E \u0936\u0943\u0902\u0917\u093E\u0930";
string DEVANAGARI_TEXT_2 = "\u0916\u0941\u0930\u094D\u0930\u092E \u0916\u0930\u094D\u091A\u0947\u0902 \u091F\u094D\u0930\u0915 \u0909\u0926\u094D\u0917\u092E \u0932\u0915\u094D\u0937\u094D\u092E\u093F\u092A\u0924\u093F \u0917\u094D\u0930\u0939 \u0936\u0943\u0902\u0917\u093E\u0930 \u0939\u0943\u0926\u092F \u0932\u093E\u0921\u093C\u0941 \u0935\u093F\u091F\u094D\u0920\u0932 \u091F\u091F\u094D\u091F\u0942 \u092C\u0941\u0926\u094D\u0927\u0942 \u0922\u0930\u094D\u0930\u093E \u092D\u093C\u0941\u0930\u094D\u0924\u093E \u0915\u092E\u094D\u092A\u094D\u092F\u0941\u091F\u0930";
string DEVANAGARI_TEXT_3 = "\u0932\u0915\u094D\u0937\u094D\u092E\u093F\u092A\u0924\u093F \u0930\u0935\u093F\u0935\u093E\u0930 \u0915\u094B \u0915\u092E\u094D\u092A\u094D\u092F\u0942\u091F\u0930 \u092A\u0930 \u0915\u0935\u093F\u0924\u093E \u0938\u093E\u0901\u0908\u0902 \u0915\u093E \u0928\u093E\u092E \u0932\u0947\u0915\u0930 \u092A\u0922\u093C\u0924\u093E \u0939\u0948";
string expectedExtractedtext = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(DEVANAGARI_TEXT_0, "\n"), DEVANAGARI_TEXT_1), "\n"), DEVANAGARI_TEXT_2), "\n"), DEVANAGARI_TEXT_3);
global::System.IO.FileInfo pdf = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Devanagari.pdf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
document.AddPage(page);
global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(document, global::DripSharp.PdfCarton.Tests.Support.ResourceStream(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "/org/apache/pdfbox/ttf/Lohit-Devanagari.ttf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document, page)) {
contentStream.BeginText();
contentStream.SetFont(font, (float)(18));
contentStream.NewLineAtOffset((float)(10), (float)(750));
contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", DEVANAGARI_TEXT_0));
contentStream.NewLineAtOffset((float)(0), (float)(-30));
contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", DEVANAGARI_TEXT_1));
contentStream.NewLineAtOffset((float)(0), (float)(-30));
contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", DEVANAGARI_TEXT_2));
contentStream.NewLineAtOffset((float)(0), (float)(-30));
contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", DEVANAGARI_TEXT_3));
contentStream.EndText();
}
document.Save(pdf);
}
if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.DoTestFile(pdf, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.IN_DIR.FullName), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR.FullName)))) {
global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Rendering of ", pdf), " failed or is not identical to expected rendering in "), global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.IN_DIR), " directory")));
}
string extracted = this.getUnicodeText(pdf);
}

internal virtual void testDevanagari2() {
global::System.IO.FileInfo pdf = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Devanagari2.pdf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
doc.AddPage(page);
int[] codepoints = new int[] { 2305, 2306, 2309, 2310, 2311, 2312, 2313, 2315, 2319, 2324, 2325, 2326, 2327, 2328, 2329, 2330, 2331, 2332, 2333, 2335, 2336, 2337, 2339, 2340, 2341, 2342, 2343, 2344, 2346, 2348, 2349, 2350, 2351, 2352, 2354, 2355, 2357, 2358, 2359, 2360, 2361, 2364, 2366, 2367, 2368, 2369, 2370, 2375, 2376, 2379, 2380, 2381, 2396, 2404, 2406, 2407, 2408, 2409, 2410, 2411, 2414, 8204 };
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream cs = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page)) {
global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "/org/apache/pdfbox/ttf/NotoSansDevanagari-Regular.ttf"));
global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font font = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(doc, @is);
sbyte[] encoded = font.Encode(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "A\u200C"));
int val1 = ((encoded[0] << unchecked((int)(8))) + (encoded[1] & 255));
int val2 = ((encoded[2] << unchecked((int)(8))) + (encoded[3] & 255));
global::DripSharp.Testing.JavaAssertions.Equal(960, val1, null);
global::DripSharp.Testing.JavaAssertions.Equal(132, val2, null);
string s = global::DripSharp.Runtime.JavaCompat.NewString(codepoints, 0, codepoints.Length);
cs.BeginText();
cs.NewLineAtOffset((float)(20), (float)(800));
cs.SetFont(font, (float)(18));
cs.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", s));
cs.EndText();
}
doc.Save(pdf);
}
if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.DoTestFile(pdf, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.IN_DIR.FullName), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR.FullName)))) {
global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Rendering of ", pdf), " failed or is not identical to expected rendering in "), global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.IN_DIR), " directory")));
}
}

internal virtual void testGujarati() {
string GUJARATI_TEXT_0 = "\u0AA6\u0AB0\u0AC7\u0A95 \u0AB5\u0ACD\u0AAF\u0A95\u0ACD\u0AA4\u0ABF\u0AA8\u0AC7 \u0AB6\u0ABF\u0A95\u0ACD\u0AB7\u0AA3\u0AA8\u0ACB \u0A85\u0AA7\u0ABF\u0A95\u0ABE\u0AB0 \u0A9B\u0AC7";
string GUJARATI_TEXT_1 = "\u0AB6\u0ABF\u0A95\u0ACD\u0AB7\u0ABF\u0AA4 \u0AAE\u0ABE\u0AA3\u0AB8 \u0AB5\u0ABF\u0AB5\u0ABF\u0AA7 \u0AAA\u0ACD\u0AB0\u0A95\u0ABE\u0AB0\u0AA8\u0ABE \u0A95\u0ABE\u0AB0\u0ACD\u0AAF \u0AAA\u0AB0\u0ABF\u0AB2\u0A95\u0ACD\u0AB7\u0ABF\u0AA4 \u0A95\u0AB0\u0AC0 \u0AB6\u0A95\u0AC7";
string GUJARATI_TEXT_2 = "\u0A9F\u0ACD\u0AB0\u0A95 \u0A97\u0AC3\u0AB9 \u0AAA\u0ACD\u0AB0\u0AB8\u0ABF\u0AA6\u0ACD\u0AA7\u0ABF \u0AB6\u0ACD\u0AB0\u0AAE\u0ABF\u0A95 \u0A85\u0A97\u0ACD\u0AA8\u0ABF \u0AA0\u0A95\u0ACD\u0A95\u0AB0 \u0A89\u0AA4\u0ACD\u0AAA\u0AB2 \u0A95\u0AB0\u0ACD\u0AAF\u0AC7";
string GUJARATI_TEXT_3 = "\u0A9C\u0ACD\u0A9E\u0ABE\u0AA8\u0AC0 \u0AAC\u0AC1\u0AA6\u0ACD\u0AA7\u0ABF\u0AAE\u0ABE\u0AA8 \u0A95\u0ACD\u0AB0\u0AAE \u0A97\u0ACD\u0AB0\u0ABE\u0AAE \u0A95\u0AC1\u0AB0\u0ACD\u0AB8\u0AC0 \u0A9F\u0ACD\u0AB0\u0AC1";
string expectedExtractedtext = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(GUJARATI_TEXT_0, "\n"), GUJARATI_TEXT_1), "\n"), GUJARATI_TEXT_2), "\n"), GUJARATI_TEXT_3);
global::System.IO.FileInfo pdf = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Gujarati.pdf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
document.AddPage(page);
global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(document, global::DripSharp.PdfCarton.Tests.Support.ResourceStream(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "/org/apache/pdfbox/ttf/Lohit-Gujarati.ttf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document, page)) {
contentStream.BeginText();
contentStream.SetFont(font, (float)(25));
contentStream.NewLineAtOffset((float)(10), (float)(750));
contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", GUJARATI_TEXT_0));
contentStream.NewLineAtOffset((float)(0), (float)(-30));
contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", GUJARATI_TEXT_1));
contentStream.NewLineAtOffset((float)(0), (float)(-30));
contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", GUJARATI_TEXT_2));
contentStream.NewLineAtOffset((float)(0), (float)(-30));
contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", GUJARATI_TEXT_3));
contentStream.EndText();
}
document.Save(pdf);
}
if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.DoTestFile(pdf, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.IN_DIR.FullName), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR.FullName)))) {
global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Rendering of ", pdf), " failed or is not identical to expected rendering in "), global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.IN_DIR), " directory")));
}
string extracted = this.getUnicodeText(pdf);
}

internal virtual void testMaxEntries() {
global::System.IO.FileInfo file;
string text;
text = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("\u3042\u3044\u3046\u3048\u304A\u304B\u304D\u304F\u3051\u3053\u3055\u3057\u3059\u305B\u305D\u305F\u3061\u3064\u3066\u3068\u306A\u306B\u306C\u306D\u306E\u306F\u3072\u3075\u3078\u307B\u307E\u307F\u3080\u3081\u3082\u3084\u3086\u3088\u3089\u308A\u308B\u308C\u308D\u308F\u3092\u3093", "\u30A2\u30A4\u30A6\u30A8\u30AA\u30AB\u30AD\u30AF\u30B1\u30B3\u30B5\u30B7\u30B9\u30BB\u30BD\u30BF\u30C1\u30C4\u30C6\u30C8\u30CA\u30CB\u30CC\u30CD\u30CE\u30CF\u30D2\u30D5\u30D8\u30DB\u30DE\u30DF\u30E0\u30E1\u30E2\u30E4\u30E6\u30E8\u30E9\u30EA\u30EB\u30EC\u30ED\u30EF\u30F2\u30F3"), "\uFF11\uFF12\uFF13\uFF14\uFF15\uFF16\uFF17\uFF18");
global::System.Collections.Generic.ISet<char> set = new global::System.Collections.Generic.HashSet<char>();
for (int i = 0; (i < text.Length); ++i) {
set.Add(text[i]);
}
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.MAX_ENTRIES_PER_OPERATOR, set.Count, null);
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A0);
document.AddPage(page);
global::System.IO.FileInfo ipafont = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/fonts/ipag00303"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ipag.ttf"));
global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font font = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(document, ipafont);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document, page)) {
contentStream.BeginText();
contentStream.SetFont(font, (float)(20));
contentStream.NewLineAtOffset((float)(50), (float)(3000));
contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", text));
contentStream.EndText();
}
file = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4302-test.pdf")));
document.Save(file);
}
string extracted = this.getUnicodeText(file);
global::DripSharp.Testing.JavaAssertions.Equal(text, global::DripSharp.Runtime.JavaCompat.StringTrim(extracted), null);
}

internal virtual void testToUnicodePrefersUsedCodePoint() {
int lowCp = -1;
int highCp = -1;
using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.getNotoCjk()))) {
global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup cmap = ttf.GetUnicodeCmapLookup();
int numGlyphs = ttf.GetMaximumProfile().GetNumGlyphs();
bool cjkPair = false;
for (int gid = 1; ((gid <= numGlyphs) && !cjkPair); gid++) {
global::System.Collections.Generic.IList<int> codes = cmap.GetCharCodes(gid);
if (((codes == default!) || (global::DripSharp.Runtime.JavaCompat.CollectionCount(codes) < 2))) {
continue;
}
int lo = -1;
int hi = -1;
foreach (int cp in codes) {
if ((((cp <= 65535) && !global::DripSharp.PdfCarton.Tests.Support.IsWhitespace(cp)) && !global::DripSharp.PdfCarton.Tests.Support.IsISOControl(cp))) {
if ((lo == -1)) {
lo = cp;
} else {
hi = cp;
break;
}
}
}
if (((hi != -1) && ((lowCp == -1) || (lo >= 11904)))) {
lowCp = lo;
highCp = hi;
cjkPair = (lo >= 11904);
}
}
}
global::DripSharp.Testing.JavaAssertions.NotEqual(-1, highCp, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "test font has no glyph shared between two printable code points"));
global::DripSharp.Testing.JavaAssertions.Equal(new string(global::DripSharp.PdfCarton.Tests.Support.ToChars(highCp)), global::DripSharp.Runtime.JavaCompat.StringTrim(this.renderAndExtract(1, highCp)), null);
global::DripSharp.Testing.JavaAssertions.Equal(new string(global::DripSharp.PdfCarton.Tests.Support.ToChars(lowCp)), global::DripSharp.Runtime.JavaCompat.StringTrim(this.renderAndExtract(2, lowCp)), null);
}

internal virtual void testToUnicodeCjkAndRadicalLookAlike() {
int ideograph = 39135;
int radical = 11997;
using (global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.getNotoCjk()))) {
global::DripSharp.PdfCarton.Fonts.Ttf.CmapLookup cmap = ttf.GetUnicodeCmapLookup();
int gid = cmap.GetGlyphId(ideograph);
global::DripSharp.Testing.JavaAssertions.True(((gid > 0) && (gid == cmap.GetGlyphId(radical))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "test font must map both code points to the same glyph"));
global::DripSharp.Testing.JavaAssertions.Equal(radical, (int)((int)(global::DripSharp.Runtime.JavaCompat.ListGet(cmap.GetCharCodes(gid), 0))), null);
}
global::DripSharp.Testing.JavaAssertions.Equal(new string(global::DripSharp.PdfCarton.Tests.Support.ToChars(ideograph)), global::DripSharp.Runtime.JavaCompat.StringTrim(this.renderAndExtract(3, ideograph)), null);
global::DripSharp.Testing.JavaAssertions.Equal(new string(global::DripSharp.PdfCarton.Tests.Support.ToChars(radical)), global::DripSharp.Runtime.JavaCompat.StringTrim(this.renderAndExtract(4, radical)), null);
}

private static global::System.IO.Stream getNotoCjk() {
return global::DripSharp.Runtime.JavaCompat.OpenFileInput(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/fonts/NotoSansCJKkr-VF.ttf"));
}

private string renderAndExtract(int num, int codePoint) {
global::System.IO.FileInfo file = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("ToUnicode-", num), "-U+"), global::DripSharp.Runtime.JavaCompat.ToHexString(codePoint)), ".pdf"))));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
document.AddPage(page);
global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font font = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(document, global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.getNotoCjk());
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream stream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document, page)) {
stream.BeginText();
stream.SetFont(font, (float)(20));
stream.NewLineAtOffset((float)(50), (float)(700));
stream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", new string(global::DripSharp.PdfCarton.Tests.Support.ToChars(codePoint))));
stream.EndText();
}
document.Save(file);
}
return this.getUnicodeText(file);
}

private void validateCIDFontType2(bool useSubset) {
string text;
global::System.IO.FileInfo file;
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
document.AddPage(page);
global::System.IO.Stream input = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Font.PDFont), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "/org/apache/pdfbox/resources/ttf/LiberationSans-Regular.ttf"));
global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font font = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(document, input, useSubset);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream stream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document, page)) {
stream.BeginText();
stream.SetFont(font, (float)(12));
text = "Unicode \u0440\u0443\u0441\u0441\u043A\u0438\u0439 \u044F\u0437\u044B\u043A Ti\u1EBFng Vi\u1EC7t";
stream.NewLineAtOffset((float)(50), (float)(600));
stream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", text));
stream.EndText();
}
file = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("CIDFontType2", (useSubset ? "-useSubset" : "")), ".pdf"))));
document.Save(file);
}
string extracted = this.getUnicodeText(file);
global::DripSharp.Testing.JavaAssertions.Equal(text, global::DripSharp.Runtime.JavaCompat.StringTrim(extracted), null);
}

private string getUnicodeText(global::System.IO.FileInfo file) {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = global::DripSharp.PdfCarton.Loader.LoadPDF(file)) {
global::DripSharp.PdfCarton.Text.PDFTextStripper stripper = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
return stripper.GetText(document);
}
}

internal virtual void testReuseEmbeddedSubsettedFont() {
string text1 = "The quick brown fox";
string text2 = "xof nworb kciuq ehT";
global::DripSharp.Runtime.JavaByteArrayOutputStream baos = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__614_25 = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page__616_20 = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
document__614_25.AddPage(page__616_20);
global::System.IO.Stream input = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Font.PDFont), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "/org/apache/pdfbox/resources/ttf/LiberationSans-Regular.ttf"));
global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font font__620_25 = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(document__614_25, input);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream stream__621_38 = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__614_25, page__616_20)) {
stream__621_38.BeginText();
stream__621_38.SetFont(font__620_25, (float)(20));
stream__621_38.NewLineAtOffset((float)(50), (float)(600));
stream__621_38.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", text1));
stream__621_38.EndText();
}
document__614_25.Save(baos);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__632_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos))) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page__634_20 = document__632_25.GetPage(0);
global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font__635_20 = page__634_20.GetResources().GetFont(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "F1")));
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream stream__636_38 = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__632_25, page__634_20, global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, true)) {
stream__636_38.BeginText();
stream__636_38.SetFont(font__635_20, (float)(20));
stream__636_38.NewLineAtOffset((float)(250), (float)(600));
stream__636_38.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", text2));
stream__636_38.EndText();
}
global::DripSharp.Runtime.JavaCompat.ResetMemoryStream(baos);
document__632_25.Save(baos);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__648_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos))) {
global::DripSharp.PdfCarton.Text.PDFTextStripper stripper = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
string extractedText = stripper.GetText(document__648_25);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(text1, " "), text2), global::DripSharp.Runtime.JavaCompat.StringTrim(extractedText), null);
}
}

internal class TrueTypeEmbedderTester : global::DripSharp.PdfCarton.Pdmodel.Font.TrueTypeEmbedder {
internal TrueTypeEmbedderTester(global::DripSharp.PdfCarton.Pdmodel.PDDocument document, global::DripSharp.PdfCarton.Cos.COSDictionary dict, global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf, bool embedSubset, global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding __outer) : base(document, dict, ttf, embedSubset) {
this.__outer = __outer;
}

protected internal override void BuildSubset(global::System.IO.Stream ttfSubset, string tag, global::System.Collections.Generic.IDictionary<int, int> gidToCid) {}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    setUp();
    return true;
}

private readonly global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding __outer;
}

internal virtual void testIsEmbeddingPermittedMultipleVersions() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Cos.COSDictionary cosDictionary = new global::DripSharp.PdfCarton.Cos.COSDictionary();
global::System.IO.Stream input = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Font.PDFont), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "/org/apache/pdfbox/resources/ttf/LiberationSans-Regular.ttf"));
global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser().ParseEmbedded(input);
global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.TrueTypeEmbedderTester tester = new global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.TrueTypeEmbedderTester(doc, cosDictionary, ttf, true, this);
global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont mockTtf = global::DripSharp.Testing.JavaMockito.Mock<global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont>();
global::DripSharp.PdfCarton.Fonts.Ttf.OS2WindowsMetricsTable mockOS2 = global::DripSharp.Testing.JavaMockito.Mock<global::DripSharp.PdfCarton.Fonts.Ttf.OS2WindowsMetricsTable>();
global::DripSharp.Testing.JavaMockito.Given(mockTtf.GetOS2Windows()).WillReturn(mockOS2);
bool embeddingIsPermitted;
global::DripSharp.Testing.JavaMockito.Given(mockTtf.GetOS2Windows().GetFsType()).WillReturn(0);
embeddingIsPermitted = tester.isEmbeddingPermitted(mockTtf);
global::DripSharp.Testing.JavaAssertions.True(embeddingIsPermitted, null);
global::DripSharp.Testing.JavaMockito.Given(mockTtf.GetOS2Windows().GetFsType()).WillReturn(2);
embeddingIsPermitted = tester.isEmbeddingPermitted(mockTtf);
global::DripSharp.Testing.JavaAssertions.False(embeddingIsPermitted, null);
global::DripSharp.Testing.JavaMockito.Given(mockTtf.GetOS2Windows().GetFsType()).WillReturn(4);
embeddingIsPermitted = tester.isEmbeddingPermitted(mockTtf);
global::DripSharp.Testing.JavaAssertions.True(embeddingIsPermitted, null);
global::DripSharp.Testing.JavaMockito.Given(mockTtf.GetOS2Windows().GetFsType()).WillReturn(6);
embeddingIsPermitted = tester.isEmbeddingPermitted(mockTtf);
global::DripSharp.Testing.JavaAssertions.True(embeddingIsPermitted, null);
global::DripSharp.Testing.JavaMockito.Given(mockTtf.GetOS2Windows().GetFsType()).WillReturn(8);
embeddingIsPermitted = tester.isEmbeddingPermitted(mockTtf);
global::DripSharp.Testing.JavaAssertions.True(embeddingIsPermitted, null);
global::DripSharp.Testing.JavaMockito.Given(mockTtf.GetOS2Windows().GetFsType()).WillReturn(10);
embeddingIsPermitted = tester.isEmbeddingPermitted(mockTtf);
global::DripSharp.Testing.JavaAssertions.True(embeddingIsPermitted, null);
global::DripSharp.Testing.JavaMockito.Given(mockTtf.GetOS2Windows().GetFsType()).WillReturn(12);
embeddingIsPermitted = tester.isEmbeddingPermitted(mockTtf);
global::DripSharp.Testing.JavaAssertions.True(embeddingIsPermitted, null);
global::DripSharp.Testing.JavaMockito.Given(mockTtf.GetOS2Windows().GetFsType()).WillReturn(14);
embeddingIsPermitted = tester.isEmbeddingPermitted(mockTtf);
global::DripSharp.Testing.JavaAssertions.True(embeddingIsPermitted, null);
}
}

internal virtual void testSurrogatePairCharacter() {
string message = "\uD867\uDE3D\uD867\uDE3D";
global::System.IO.FileInfo pdf = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-5812.pdf")));
global::DripSharp.Runtime.JavaByteArrayOutputStream baos;
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__779_25 = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
doc__779_25.AddPage(page);
global::System.IO.FileInfo ipafont = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/fonts/ipag00303"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ipag.ttf"));
global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(doc__779_25, ipafont);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contents = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc__779_25, page)) {
contents.BeginText();
contents.SetFont(font, (float)(64));
contents.NewLineAtOffset((float)(100), (float)(700));
contents.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", message));
contents.EndText();
}
baos = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
doc__779_25.Save(baos);
doc__779_25.Save(pdf);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__798_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos))) {
global::DripSharp.PdfCarton.Text.PDFTextStripper stripper = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
string text = global::DripSharp.Runtime.JavaCompat.StringTrim(stripper.GetText(doc__798_25));
global::DripSharp.Testing.JavaAssertions.Equal(message, text, null);
}
if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.DoTestFile(pdf, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.IN_DIR.FullName), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.OUT_DIR.FullName)))) {
global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Rendering of ", pdf), " failed or is not identical to expected rendering in "), global::DripSharp.PdfCarton.Pdmodel.Font.TestFontEmbedding.IN_DIR), " directory")));
}
}

internal virtual void testSurrogatePairCharacterExceptionIsBmpCodePoint() {
string message = "\u3042";
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
doc.AddPage(page);
global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(doc, global::DripSharp.PdfCarton.Tests.Support.ResourceStream(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "/org/apache/pdfbox/resources/ttf/LiberationSans-Regular.ttf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contents = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page)) {
contents.BeginText();
contents.SetFont(font, (float)(64));
contents.NewLineAtOffset((float)(100), (float)(700));
global::System.Exception ex = global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => contents.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", message)), null);
global::DripSharp.Testing.JavaAssertions.Equal("could not find the glyphId for the character: \u3042, codePoint: 12354 (0x3042)", global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
contents.EndText();
}
}
}

internal virtual void testSurrogatePairCharacterExceptionIsValidCodePoint() {
string message = "\uD867\uDE3D";
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
doc.AddPage(page);
global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(doc, global::DripSharp.PdfCarton.Tests.Support.ResourceStream(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "/org/apache/pdfbox/resources/ttf/LiberationSans-Regular.ttf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contents = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page)) {
contents.BeginText();
contents.SetFont(font, (float)(64));
contents.NewLineAtOffset((float)(100), (float)(700));
global::System.InvalidOperationException ex = global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => contents.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", message)), null);
global::DripSharp.Testing.JavaAssertions.Equal("could not find the glyphId for the character: \uD867\uDE3D, codePoint: 171581 (0x29E3D)", global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
contents.EndText();
}
}
}

internal virtual void testEmbeddedFontWithZeroWidthChars() {
string text = "AAA\u200CBBB";
global::DripSharp.Runtime.JavaByteArrayOutputStream baos = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__871_25 = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page__873_20 = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
document__871_25.AddPage(page__873_20);
global::System.IO.Stream input = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Font.PDFont), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "/org/apache/pdfbox/resources/ttf/LiberationSans-Regular.ttf"));
global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font font__877_25 = global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font.Load(document__871_25, input);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream stream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__871_25, page__873_20)) {
stream.BeginText();
stream.SetFont(font__877_25, (float)(20));
stream.NewLineAtOffset((float)(50), (float)(600));
stream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", text));
stream.EndText();
}
document__871_25.Save(baos);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__888_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos))) {
global::DripSharp.PdfCarton.Text.PDFTextStripper stripper = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
string extractedText = global::DripSharp.Runtime.JavaCompat.StringTrim(stripper.GetText(document__888_25));
global::DripSharp.Testing.JavaAssertions.Equal(text, extractedText, null);
global::DripSharp.Testing.JavaAssertions.Equal(7, extractedText.Length, null);
global::DripSharp.Testing.JavaAssertions.Equal('\u200C', extractedText[3], null);
global::DripSharp.PdfCarton.Pdmodel.PDPage page__898_20 = document__888_25.GetPage(0);
global::DripSharp.PdfCarton.Pdmodel.PDResources resources = page__898_20.GetResources();
global::System.Collections.Generic.IEnumerable<global::DripSharp.PdfCarton.Cos.COSName> fontNames = resources.GetFontNames();
global::DripSharp.PdfCarton.Cos.COSName fontName = (global::DripSharp.Runtime.JavaCompat.Iterator(fontNames)).Next()!;
global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font font__902_25 = (global::DripSharp.PdfCarton.Pdmodel.Font.PDType0Font)(resources.GetFont(fontName)!);
sbyte[] encoded = font__902_25.Encode((int)('\u200C'));
int code = (((encoded[0] & 255) << unchecked((int)(8))) | (encoded[1] & 255));
global::DripSharp.Testing.JavaAssertions.Equal((float)(0), font__902_25.GetWidth(code), null);
global::DripSharp.Testing.JavaAssertions.Equal((float)(0), font__902_25.GetWidthFromFont(code), null);
global::DripSharp.Testing.JavaAssertions.True(font__902_25.GetPath(code).Bounds.IsEmpty, null);
global::DripSharp.Testing.JavaAssertions.False(font__902_25.IsDamaged(), null);
}
}

[Xunit.Fact]
public void __Upstream_1532229104_0dd5eb93453ec45f()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testBengali();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0720509885_6bd734d69b36b58e()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCIDFontType2();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2548882495_14f8b2f96e45ad51()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCIDFontType2Subset();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0925378862_f07d1c778a55fcb6()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCIDFontType2VerticalSubsetMonospace();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4092567866_b44ec43e5e462d75()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCIDFontType2VerticalSubsetProportional();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4016339170_80a66211233c0d54()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testDevanagari();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4247430032_098837e102a1201d()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testDevanagari2();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4239234032_b56d5bad87cd21f7()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testEmbeddedFontWithZeroWidthChars();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1574174651_2a9630d6fb16af11()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testGujarati();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1498832360_3d1d750d682418a3()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testIsEmbeddingPermittedMultipleVersions();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1015836862_ddf0fdc8901b8040()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testMaxEntries();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4291873876_62ad8efed964bf9e()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testReuseEmbeddedSubsettedFont();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2317728937_2f187268d3077870()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testSurrogatePairCharacter();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1022144814_6aff46a338444f7a()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testSurrogatePairCharacterExceptionIsBmpCodePoint();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2839433367_47844f72da4cdd08()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testSurrogatePairCharacterExceptionIsValidCodePoint();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0075874530_89899f68ad06b4e6()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testToUnicodeCjkAndRadicalLookAlike();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1132192851_01ac89a410e73405()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testToUnicodePrefersUsedCodePoint();
        }
        finally
        {
        }
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    setUp();
    return true;
}
}
