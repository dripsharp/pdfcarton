// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Text;

public class TestTextStripper {
private static readonly global::Microsoft.Extensions.Logging.ILogger log = global::Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;

private bool bFail;

private static global::DripSharp.PdfCarton.Text.PDFTextStripper stripper = null!;

private const string ENCODING = "UTF-8";

internal static void init() {
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetLineSeparator(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "\n"));
}

private bool stringsEqual(string expected, string actual) {
bool equals = true;
if (((expected == default!) && (actual == default!))) {
return true;
} else {
if (((expected != default!) && (actual != default!))) {
expected = global::DripSharp.Runtime.JavaCompat.StringTrim(expected);
actual = global::DripSharp.Runtime.JavaCompat.StringTrim(actual);
char[] expectedArray = expected.ToCharArray();
char[] actualArray = actual.ToCharArray();
int expectedIndex = 0;
int actualIndex = 0;
while (((expectedIndex < expectedArray.Length) && (actualIndex < actualArray.Length))) {
if (((int)(expectedArray[expectedIndex]) != (int)(actualArray[actualIndex]))) {
equals = false;
global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Text.TestTextStripper.log, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Lines differ at index", " expected:"), expectedIndex), "-"), (int)(expectedArray[expectedIndex])), " actual:"), actualIndex), "-"), (int)(actualArray[actualIndex]))));
break;
}
expectedIndex = this.skipWhitespace(expectedArray, expectedIndex);
actualIndex = this.skipWhitespace(actualArray, actualIndex);
expectedIndex++;
actualIndex++;
}
if (equals) {
if ((expectedIndex != expectedArray.Length)) {
equals = false;
global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Text.TestTextStripper.log, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("Expected line is longer at:", expectedIndex)));
}
if ((actualIndex != actualArray.Length)) {
equals = false;
global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Text.TestTextStripper.log, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("Actual line is longer at:", actualIndex)));
}
if ((expectedArray.Length != actualArray.Length)) {
equals = false;
global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Text.TestTextStripper.log, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Expected lines: ", expectedArray.Length), ", actual lines: "), actualArray.Length)));
}
}
} else {
equals = ((((expected == default!) && (actual != default!)) && (global::DripSharp.Runtime.JavaCompat.StringTrim(actual).Length == 0)) || (((actual == default!) && (expected != default!)) && (global::DripSharp.Runtime.JavaCompat.StringTrim(expected).Length == 0)));
}
}
return equals;
}

private int skipWhitespace(char[] array, int index) {
if ((((int)(array[index]) == (int)(' ')) || ((int)(array[index]) > 256))) {
while (((index < array.Length) && (((int)(array[index]) == (int)(' ')) || ((int)(array[index]) > 256)))) {
index++;
}
index--;
}
return index;
}

private void doTestFile(global::System.IO.FileInfo inFile, global::System.IO.FileInfo outDir, bool bLogResult, bool bSort) {
if (bSort) {
global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Text.TestTextStripper.log, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Preparing to parse ", inFile.Name), " for sorted test")));
} else {
global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Text.TestTextStripper.log, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Preparing to parse ", inFile.Name), " for standard test")));
}
global::DripSharp.Runtime.JavaCompat.CreateDirectories(new global::DripSharp.Runtime.JavaPath(outDir.FullName));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = global::DripSharp.PdfCarton.Loader.LoadPDF(inFile)) {
global::System.IO.FileInfo outFile;
global::System.IO.FileInfo diffFile;
global::System.IO.FileInfo expectedFile;
if (bSort) {
outFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine(outDir.FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(inFile.Name, "-sorted.txt"))));
diffFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine(outDir.FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(inFile.Name, "-sorted-diff.txt"))));
expectedFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine(global::DripSharp.PdfCarton.Tests.Support.ParentFile(inFile).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(inFile.Name, "-sorted.txt"))));
} else {
outFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine(outDir.FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(inFile.Name, ".txt"))));
diffFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine(outDir.FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(inFile.Name, "-diff.txt"))));
expectedFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine(global::DripSharp.PdfCarton.Tests.Support.ParentFile(inFile).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(inFile.Name, ".txt"))));
}
global::DripSharp.Runtime.JavaCompat.FileDelete(diffFile);
using (global::System.IO.Stream os = global::DripSharp.Runtime.JavaCompat.OpenFileOutput(outFile)) {
global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(os, 239);
global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(os, 187);
global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(os, 191);
using (global::System.IO.TextWriter writer = new global::System.IO.StreamWriter(os, global::DripSharp.PdfCarton.Tests.Support.EncodingByName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Text.TestTextStripper.ENCODING)), 1024, false)) {
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetSortByPosition(bSort);
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.WriteText(document, writer);
}
}
if (bLogResult) {
global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Text.TestTextStripper.log, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Text for ", inFile.Name), ":")));
global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Text.TestTextStripper.log, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.GetText(document)));
}
if (!global::System.IO.File.Exists(expectedFile.FullName)) {
this.bFail = true;
global::Microsoft.Extensions.Logging.LoggerExtensions.LogError(global::DripSharp.PdfCarton.Text.TestTextStripper.log, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("FAILURE: Input verification file: ", expectedFile.FullName), " did not exist")));
return;
}
this.compareResult(expectedFile, outFile, inFile, bSort, diffFile);
}
}

private void compareResult(global::System.IO.FileInfo expectedFile, global::System.IO.FileInfo outFile, global::System.IO.FileInfo inFile, bool bSort, global::System.IO.FileInfo diffFile) {
bool localFail = false;
using (global::DripSharp.Runtime.JavaLineNumberReader expectedReader = new global::DripSharp.Runtime.JavaLineNumberReader(global::DripSharp.PdfCarton.Tests.Support.NewInputStreamReader(global::DripSharp.Runtime.JavaCompat.OpenFileInput(expectedFile), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Text.TestTextStripper.ENCODING)))) using (global::DripSharp.Runtime.JavaLineNumberReader actualReader = new global::DripSharp.Runtime.JavaLineNumberReader(global::DripSharp.PdfCarton.Tests.Support.NewInputStreamReader(global::DripSharp.Runtime.JavaCompat.OpenFileInput(outFile), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Text.TestTextStripper.ENCODING)))) {
while (true) {
string expectedLine = expectedReader.ReadLine();
while (((expectedLine != default!) && (global::DripSharp.Runtime.JavaCompat.StringTrim(expectedLine).Length == 0))) {
expectedLine = expectedReader.ReadLine();
}
string actualLine = actualReader.ReadLine();
while (((actualLine != default!) && (global::DripSharp.Runtime.JavaCompat.StringTrim(actualLine).Length == 0))) {
actualLine = actualReader.ReadLine();
}
if (!(this.stringsEqual(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", expectedLine), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", actualLine)))) {
this.bFail = true;
localFail = true;
global::Microsoft.Extensions.Logging.LoggerExtensions.LogError(global::DripSharp.PdfCarton.Text.TestTextStripper.log, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("FAILURE: Line mismatch for file ", inFile.Name), " (sort = "), bSort), ")"), " at expected line: "), 0), " at actual line: "), 0), "\nexpected line was: \""), expectedLine), "\""), "\nactual line was:   \""), actualLine), "\""), "\n")));
}
if (((expectedLine == default!) || (actualLine == default!))) {
break;
}
}
}
if (!localFail) {
global::DripSharp.Runtime.JavaCompat.FileDelete(outFile);
} else {
global::System.Collections.Generic.IList<string> original = global::DripSharp.PdfCarton.Text.TestTextStripper.fileToLines(expectedFile);
global::System.Collections.Generic.IList<string> revised = global::DripSharp.PdfCarton.Text.TestTextStripper.fileToLines(outFile);
global::DripSharp.PdfCarton.Tests.JavaPatch<string> patch = global::DripSharp.PdfCarton.Tests.JavaDiffUtils.Diff(original, revised);
using (global::System.IO.TextWriter diffPS = new global::System.IO.StreamWriter(diffFile.FullName, false, global::DripSharp.PdfCarton.Tests.Support.EncodingByName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Text.TestTextStripper.ENCODING)))) {
global::DripSharp.Runtime.JavaCompat.ForEach(patch.GetDeltas(), (delta) => {
if ((delta is global::DripSharp.PdfCarton.Tests.JavaChangeDelta)) {
global::DripSharp.PdfCarton.Tests.JavaChangeDelta<string> cdelta = (global::DripSharp.PdfCarton.Tests.JavaChangeDelta<string>)(delta!);
diffPS.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("Org: ", cdelta.GetOriginal())));
diffPS.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("New: ", cdelta.GetRevised())));
diffPS.WriteLine();
} else {
if ((delta is global::DripSharp.PdfCarton.Tests.JavaDeleteDelta)) {
global::DripSharp.PdfCarton.Tests.JavaDeleteDelta<string> ddelta = (global::DripSharp.PdfCarton.Tests.JavaDeleteDelta<string>)(delta!);
diffPS.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("Org: ", ddelta.GetOriginal())));
diffPS.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("New: ", ddelta.GetRevised())));
diffPS.WriteLine();
} else {
if ((delta is global::DripSharp.PdfCarton.Tests.JavaInsertDelta)) {
global::DripSharp.PdfCarton.Tests.JavaInsertDelta<string> idelta = (global::DripSharp.PdfCarton.Tests.JavaInsertDelta<string>)(delta!);
diffPS.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("Org: ", idelta.GetOriginal())));
diffPS.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("New: ", idelta.GetRevised())));
diffPS.WriteLine();
} else {
diffPS.WriteLine(delta);
}
}
}
});
}
}
}

private static global::System.Collections.Generic.IList<string> fileToLines(global::System.IO.FileInfo file) {
global::System.Collections.Generic.IList<string> lines = new global::System.Collections.Generic.List<string>();
string line;
using (global::System.IO.TextReader @in = global::DripSharp.PdfCarton.Tests.Support.NewInputStreamReader(global::DripSharp.Runtime.JavaCompat.OpenFileInput(file), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Text.TestTextStripper.ENCODING))) {
while (((line = @in.ReadLine()) != default!)) {
global::DripSharp.Runtime.JavaCompat.Add(lines, line);
}
}
return lines;
}

private int findOutlineItemDestPageNum(global::DripSharp.PdfCarton.Pdmodel.PDDocument doc, global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem oi) {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination pageDest = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination)(oi.GetDestination()!);
int indexOfPage = doc.GetPages().IndexOf(oi.FindDestinationPage(doc));
int pageNum = pageDest.RetrievePageNumber();
global::DripSharp.Testing.JavaAssertions.Equal(indexOfPage, pageNum, null);
return pageNum;
}

internal virtual void testStripByOutlineItems() {
global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "../pdmodel/with_outline.pdf"))));
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDDocumentOutline outline = doc.GetDocumentCatalog().GetDocumentOutline();
global::System.Collections.Generic.IEnumerable<global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem> children = outline.Children();
global::DripSharp.Runtime.JavaIterator<global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem> it = global::DripSharp.Runtime.JavaCompat.Iterator(children);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem oi0 = it.Next()!;
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem oi2 = it.Next()!;
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem oi3 = it.Next()!;
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem oi4 = it.Next()!;
global::DripSharp.Testing.JavaAssertions.Equal(0, this.findOutlineItemDestPageNum(doc, oi0), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, this.findOutlineItemDestPageNum(doc, oi2), null);
global::DripSharp.Testing.JavaAssertions.Equal(3, this.findOutlineItemDestPageNum(doc, oi3), null);
global::DripSharp.Testing.JavaAssertions.Equal(4, this.findOutlineItemDestPageNum(doc, oi4), null);
string textFull = global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.GetText(doc);
global::DripSharp.Testing.JavaAssertions.False((textFull.Length == 0), null);
string expectedTextFull = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("First level 1\n", "First level 2\n"), "Fist level 3\n"), "Some content\n"), "Some other content\n"), "Second at level 1\n"), "Second level 2\n"), "Content\n"), "Third level 1\n"), "Third level 2\n"), "Third level 3\n"), "Content\n"), "Fourth level 1\n"), "Content\n"), "Content\n");
global::DripSharp.Testing.JavaAssertions.Equal(expectedTextFull, global::DripSharp.Runtime.JavaCompat.StringReplaceAll(textFull, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "\r"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "")), null);
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetStartBookmark(oi2);
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetEndBookmark(oi3);
string textoi23 = global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.GetText(doc);
global::DripSharp.Testing.JavaAssertions.False((textoi23.Length == 0), null);
global::DripSharp.Testing.JavaAssertions.NotEqual(textoi23, textFull, null);
string expectedTextoi23 = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Second at level 1\n", "Second level 2\n"), "Content\n"), "Third level 1\n"), "Third level 2\n"), "Third level 3\n"), "Content\n");
global::DripSharp.Testing.JavaAssertions.Equal(expectedTextoi23, global::DripSharp.Runtime.JavaCompat.StringReplaceAll(textoi23, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "\r"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "")), null);
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetStartBookmark((global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem)default!);
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetEndBookmark((global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem)default!);
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetStartPage(3);
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetEndPage(4);
string textp34 = global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.GetText(doc);
global::DripSharp.Testing.JavaAssertions.False((textp34.Length == 0), null);
global::DripSharp.Testing.JavaAssertions.NotEqual(textoi23, textFull, null);
global::DripSharp.Testing.JavaAssertions.Equal(textoi23, textp34, null);
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetStartBookmark(oi2);
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetEndBookmark(oi2);
string textoi2 = global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.GetText(doc);
global::DripSharp.Testing.JavaAssertions.False((textoi2.Length == 0), null);
global::DripSharp.Testing.JavaAssertions.NotEqual(textoi2, textoi23, null);
global::DripSharp.Testing.JavaAssertions.NotEqual(textoi23, textFull, null);
string expectedTextoi2 = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Second at level 1\n", "Second level 2\n"), "Content\n");
global::DripSharp.Testing.JavaAssertions.Equal(expectedTextoi2, global::DripSharp.Runtime.JavaCompat.StringReplaceAll(textoi2, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "\r"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "")), null);
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetStartBookmark((global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem)default!);
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetEndBookmark((global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem)default!);
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetStartPage(3);
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetEndPage(3);
string textp3 = global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.GetText(doc);
global::DripSharp.Testing.JavaAssertions.False((textp3.Length == 0), null);
global::DripSharp.Testing.JavaAssertions.NotEqual(textp3, textp34, null);
global::DripSharp.Testing.JavaAssertions.NotEqual(textoi23, textFull, null);
global::DripSharp.Testing.JavaAssertions.Equal(textoi2, textp3, null);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem oiOrphan = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetStartBookmark(oiOrphan);
global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.SetEndBookmark(oiOrphan);
string textOiOrphan = global::DripSharp.PdfCarton.Text.TestTextStripper.stripper.GetText(doc);
global::DripSharp.Testing.JavaAssertions.True((textOiOrphan.Length == 0), null);
}

private void doTestDir(global::System.IO.FileInfo inDir, global::System.IO.FileInfo outDir) {
global::System.IO.FileInfo[] testFiles = global::DripSharp.PdfCarton.Tests.Support.ListFiles(inDir, (dir, name) => global::DripSharp.Runtime.JavaCompat.StringEndsWith(name, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ".pdf")));
foreach (global::System.IO.FileInfo testFile in testFiles) {
this.doTestFile(testFile, outDir, false, false);
this.doTestFile(testFile, outDir, false, true);
}
}

internal virtual void testExtract() {
string filename = global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "org.apache.pdfbox.util.TextStripper.file"));
global::System.IO.FileInfo inDir = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "src/test/resources/input"));
global::System.IO.FileInfo outDir = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output"));
global::System.IO.FileInfo inDirExt = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-input-ext"));
global::System.IO.FileInfo outDirExt = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output-ext"));
if (((filename == default!) || (filename.Length == 0))) {
this.doTestDir(inDir, outDir);
if (global::System.IO.File.Exists(inDirExt.FullName)) {
this.doTestDir(inDirExt, outDirExt);
}
} else {
this.doTestFile(new global::System.IO.FileInfo(global::System.IO.Path.Combine(inDir.FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename))), outDir, true, false);
this.doTestFile(new global::System.IO.FileInfo(global::System.IO.Path.Combine(inDir.FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename))), outDir, true, true);
}
if (this.bFail) {
global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
}
}

internal virtual void testTabula() {
global::System.IO.FileInfo pdfFile = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "src/test/resources/input"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "eu-001.pdf"));
global::System.IO.FileInfo outFile = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "eu-001.pdf-tabula.txt"));
global::System.IO.FileInfo expectedOutFile = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "src/test/resources/input"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "eu-001.pdf-tabula.txt"));
global::System.IO.FileInfo diffFile = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "eu-001.pdf-tabula-diff.txt"));
global::DripSharp.PdfCarton.Pdmodel.PDDocument tabulaDocument = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfFile);
global::DripSharp.PdfCarton.Text.PDFTextStripper tabulaStripper = new global::DripSharp.PdfCarton.Text.TestTextStripper.PDFTabulaTextStripper(this);
using (global::System.IO.Stream os = global::DripSharp.Runtime.JavaCompat.OpenFileOutput(outFile)) {
global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(os, 239);
global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(os, 187);
global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(os, 191);
using (global::System.IO.TextWriter writer = new global::System.IO.StreamWriter(os, global::DripSharp.PdfCarton.Tests.Support.EncodingByName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Text.TestTextStripper.ENCODING)), 1024, false)) {
tabulaStripper.WriteText(tabulaDocument, writer);
}
}
this.compareResult(expectedOutFile, outFile, pdfFile, false, diffFile);
global::DripSharp.Testing.JavaAssertions.False(this.bFail, null);
}

internal class PDFTabulaTextStripper : global::DripSharp.PdfCarton.Text.PDFTextStripper {
internal PDFTabulaTextStripper(global::DripSharp.PdfCarton.Text.TestTextStripper __outer) {
this.__outer = __outer;


}

protected internal override float ComputeFontHeight(global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font) {
global::DripSharp.PdfCarton.Fonts.Util.BoundingBox bbox = font.GetBoundingBox();
if ((bbox.GetLowerLeftY() < (int)(short.MinValue))) {
bbox.SetLowerLeftY(-((bbox.GetLowerLeftY() + 65536)));
}
float glyphHeight = ((float)(bbox.GetHeight()) / 2);
global::DripSharp.PdfCarton.Pdmodel.Font.PDFontDescriptor fontDescriptor = font.GetFontDescriptor();
if ((fontDescriptor != default!)) {
float capHeight = fontDescriptor.GetCapHeight();
if (((global::DripSharp.Runtime.JavaCompat.CompareFloat(capHeight, (float)(0)) != 0) && ((capHeight < glyphHeight) || (global::DripSharp.Runtime.JavaCompat.CompareFloat(glyphHeight, (float)(0)) == 0)))) {
glyphHeight = capHeight;
}
float ascent = fontDescriptor.GetAscent();
float descent = fontDescriptor.GetDescent();
if ((((ascent > 0) && (descent < 0)) && ((((float)((ascent - descent)) / 2) < glyphHeight) || (global::DripSharp.Runtime.JavaCompat.CompareFloat(glyphHeight, (float)(0)) == 0)))) {
glyphHeight = ((float)((ascent - descent)) / 2);
}
}
float height;
if ((font is global::DripSharp.PdfCarton.Pdmodel.Font.PDType3Font)) {
height = (float)(font.GetFontMatrix().TransformPoint((float)(0), glyphHeight).Y);
} else {
height = ((float)(glyphHeight) / 1000);
}
return height;
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    init();
    return true;
}

private readonly global::DripSharp.PdfCarton.Text.TestTextStripper __outer;
}

internal virtual void testStartEndPage() {
global::System.IO.FileInfo pdfFile = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "src/test/resources/input"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "eu-001.pdf"));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfFile)) {
global::DripSharp.PdfCarton.Text.PDFTextStripper textStripper = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
textStripper.SetStartPage(2);
textStripper.SetEndPage(2);
string text = global::DripSharp.Runtime.JavaCompat.StringTrim(textStripper.GetText(doc));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringStartsWith(text, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Pesticides")), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringEndsWith(text, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "1 000 10 10")), null);
global::DripSharp.Testing.JavaAssertions.Equal(1378, global::DripSharp.Runtime.JavaCompat.StringReplaceAll(text, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "\r"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "")).Length, null);
}
}

internal virtual void testIgnoreContentStreamSpaceGlyphs() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream cs = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page)) {
float fontHeight = 8;
float x = 50;
float y = (page.GetMediaBox().GetHeight() - 50);
global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica);
cs.BeginText();
cs.SetFont(font, fontHeight);
cs.NewLineAtOffset(x, y);
cs.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "(                                      )"));
cs.EndText();
int indent = 6;
float overlapX = (x + (((float)((indent * font.GetAverageFontWidth())) / (float)(1000.0F)) * fontHeight));
global::DripSharp.PdfCarton.Pdmodel.Font.PDFont overlapFont = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.TimesRoman);
cs.BeginText();
cs.SetFont(overlapFont, (fontHeight * 2.0F));
cs.NewLineAtOffset(overlapX, y);
cs.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "overlap"));
cs.EndText();
}
doc.AddPage(page);
global::DripSharp.PdfCarton.Text.PDFTextStripper localStripper = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
localStripper.SetLineSeparator(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "\n"));
localStripper.SetPageEnd(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "\n"));
localStripper.SetStartPage(1);
localStripper.SetEndPage(1);
localStripper.SetSortByPosition(true);
localStripper.SetIgnoreContentStreamSpaceGlyphs(true);
string text = localStripper.GetText(doc);
global::DripSharp.Testing.JavaAssertions.Equal("( overlap )\n", text, null);
}
}

[Xunit.Fact]
public void __Upstream_0449595279_e7ab607af03ba9d9()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testExtract();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0382577528_7d45aa92e60bf618()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testIgnoreContentStreamSpaceGlyphs();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1436764410_e555e9ec80b2c1a2()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testStartEndPage();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4170066395_d6f6178682221445()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testStripByOutlineItems();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3885849639_5425036c4232698c()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testTabula();
        }
        finally
        {
        }
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    init();
    return true;
}

public TestTextStripper() {
this.bFail = false;
}
}
