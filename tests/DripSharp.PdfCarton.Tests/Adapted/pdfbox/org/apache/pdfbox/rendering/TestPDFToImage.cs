// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Rendering;

public class TestPDFToImage {
private static readonly global::Microsoft.Extensions.Logging.ILogger LOG = global::Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;

public TestPDFToImage() {}

private static global::SkiaSharp.SKBitmap createEmptyDiffImage(int minWidth, int minHeight, int maxWidth, int maxHeight) {
global::SkiaSharp.SKBitmap bim3 = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(maxWidth, maxHeight, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_RGB);
global::DripSharp.Runtime.PdfCartonGraphics2D graphics = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(bim3);
if (((minWidth != maxWidth) || (minHeight != maxHeight))) {
graphics.SetColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Black);
graphics.FillRect(0, 0, maxWidth, maxHeight);
}
graphics.SetColor(global::DripSharp.Runtime.JavaColor.White);
graphics.FillRect(0, 0, minWidth, minHeight);
graphics.Dispose();
return bim3;
}

private static global::SkiaSharp.SKBitmap diffImages(global::SkiaSharp.SKBitmap bim1, global::SkiaSharp.SKBitmap bim2) {
int minWidth = global::System.Math.Min(bim1.Width, bim2.Width);
int minHeight = global::System.Math.Min(bim1.Height, bim2.Height);
int maxWidth = global::System.Math.Max(bim1.Width, bim2.Width);
int maxHeight = global::System.Math.Max(bim1.Height, bim2.Height);
global::SkiaSharp.SKBitmap bim3 = default!;
if (((minWidth != maxWidth) || (minHeight != maxHeight))) {
bim3 = global::DripSharp.PdfCarton.Rendering.TestPDFToImage.createEmptyDiffImage(minWidth, minHeight, maxWidth, maxHeight);
}
for (int x = 0; (x < minWidth); ++x) {
for (int y = 0; (y < minHeight); ++y) {
int rgb1 = global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(bim1, x, y);
int rgb2 = global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(bim2, x, y);
if (((rgb1 != rgb2) && (((global::System.Math.Abs(((rgb1 & 255) - (rgb2 & 255))) > 3) || (global::System.Math.Abs((((rgb1 >> unchecked((int)(8))) & 255) - ((rgb2 >> unchecked((int)(8))) & 255))) > 3)) || (global::System.Math.Abs((((rgb1 >> unchecked((int)(16))) & 255) - ((rgb2 >> unchecked((int)(16))) & 255))) > 3)))) {
if ((bim3! == default!)) {
bim3 = global::DripSharp.PdfCarton.Rendering.TestPDFToImage.createEmptyDiffImage(minWidth, minHeight, maxWidth, maxHeight);
}
int r = global::System.Math.Abs(((rgb1 & 255) - (rgb2 & 255)));
int g = global::System.Math.Abs(((rgb1 & 65280) - (rgb2 & 65280)));
int b = global::System.Math.Abs(((rgb1 & 16711680) - (rgb2 & 16711680)));
global::DripSharp.Runtime.PdfCartonFontCompat.SetRgb(bim3!, x, y, (16777215 - ((r | g) | b)));
} else {
if ((bim3! != default!)) {
global::DripSharp.Runtime.PdfCartonFontCompat.SetRgb(bim3!, x, y, global::DripSharp.PdfCarton.Tests.Support.ColorRgb(global::DripSharp.Runtime.JavaColor.White));
}
}
}
}
return bim3!;
}

public static bool DoTestFile(global::System.IO.FileInfo file, string inDir, string outDir) {
bool failed = false;
global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.LOG, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("Opening: ", file.Name)));
(global::DripSharp.Runtime.JavaCompat.OpenFileOutput(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(file.Name, ".parseerror"))))).Dispose();
try {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = global::DripSharp.PdfCarton.Loader.LoadPDF(file)) {
int numPages = document.GetNumberOfPages();
if ((numPages < 1)) {
failed = true;
global::Microsoft.Extensions.Logging.LoggerExtensions.LogError(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.LOG, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("file ", file.Name), " has < 1 page")));
} else {
global::DripSharp.Runtime.JavaCompat.FileDelete(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(file.Name, ".parseerror"))));
global::DripSharp.PdfCarton.Tests.Support.DeleteOnExit(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(file.Name, ".parseerror"))));
}
global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.LOG, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("Rendering: ", file.Name)));
global::DripSharp.PdfCarton.Rendering.PDFRenderer renderer = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(document);
for (int i = 0; (i < numPages); i++) {
string fileName = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(file.Name, "-"), (i + 1)), ".png");
(global::DripSharp.Runtime.JavaCompat.OpenFileOutput(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(fileName, ".rendererror"))))).Dispose();
global::SkiaSharp.SKBitmap image = renderer.RenderImageWithDPI(i, (float)(96));
global::DripSharp.Runtime.JavaCompat.FileDelete(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(fileName, ".rendererror"))));
global::DripSharp.PdfCarton.Tests.Support.DeleteOnExit(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(fileName, ".rendererror"))));
global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.LOG, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("Writing: ", fileName)));
(global::DripSharp.Runtime.JavaCompat.OpenFileOutput(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(fileName, ".writeerror"))))).Dispose();
bool writeSuccess = global::DripSharp.PdfCarton.Tests.Support.WriteImage(image, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PNG"), global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", fileName)));
if (writeSuccess) {
global::DripSharp.Runtime.JavaCompat.FileDelete(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(fileName, ".writeerror"))));
global::DripSharp.PdfCarton.Tests.Support.DeleteOnExit(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(fileName, ".writeerror"))));
}
}
(global::DripSharp.Runtime.JavaCompat.OpenFileOutput(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(file.Name, ".saveerror"))))).Dispose();
global::System.IO.FileInfo tmpFile = new global::System.IO.FileInfo(global::DripSharp.Runtime.JavaCompat.createTempFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "pdfbox"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ".pdf")));
document.SetAllSecurityToBeRemoved(true);
document.Save(tmpFile);
global::DripSharp.Runtime.JavaCompat.FileDelete(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(file.Name, ".saveerror"))));
global::DripSharp.PdfCarton.Tests.Support.DeleteOnExit(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(file.Name, ".saveerror"))));
(global::DripSharp.Runtime.JavaCompat.OpenFileOutput(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(file.Name, ".reloaderror"))))).Dispose();
global::DripSharp.PdfCarton.Loader.LoadPDF(tmpFile).Dispose();
global::DripSharp.Runtime.JavaCompat.FileDelete(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(file.Name, ".reloaderror"))));
global::DripSharp.PdfCarton.Tests.Support.DeleteOnExit(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(file.Name, ".reloaderror"))));
global::DripSharp.Runtime.JavaCompat.FileDelete(tmpFile);
global::DripSharp.PdfCarton.Tests.Support.DeleteOnExit(tmpFile);
}
} catch (global::System.IO.IOException) {
failed = true;
global::Microsoft.Extensions.Logging.LoggerExtensions.LogError(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.LOG, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("Error converting file ", file.Name)));
throw;
}
global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.LOG, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("Comparing: ", file.Name)));
try {
global::DripSharp.Runtime.JavaCompat.FileDelete(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(file.Name, ".cmperror"))));
global::System.IO.FileInfo[] outFiles = global::DripSharp.PdfCarton.Tests.Support.ListFiles(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir)), (dir, name) => {
return ((global::DripSharp.Runtime.JavaCompat.StringEndsWith(name, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ".png")) && global::DripSharp.Runtime.JavaCompat.StringStartsWith(name, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", file.Name), 0)) && !(global::DripSharp.Runtime.JavaCompat.StringEndsWith(name, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ".png-diff.png"))));
});
if ((outFiles.Length == 0)) {
failed = true;
global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.LOG, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("*** TEST FAILURE *** Output missing for file: ", file.Name)));
}
foreach (global::System.IO.FileInfo outFile in outFiles) {
global::DripSharp.Runtime.JavaCompat.FileDelete(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(outFile.FullName, "-diff.png"))));
global::System.IO.FileInfo inFile = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(inDir, '/'), outFile.Name)));
if (!global::System.IO.File.Exists(inFile.FullName)) {
failed = true;
global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.LOG, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("*** TEST FAILURE *** Input missing for file: ", inFile.Name)));
} else {
if (!(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.filesAreIdentical(outFile, inFile))) {
global::SkiaSharp.SKBitmap bim3 = global::DripSharp.PdfCarton.Rendering.TestPDFToImage.diffImages(global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(inFile), global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(outFile));
if ((bim3 != default!)) {
failed = true;
global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.LOG, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("*** TEST FAILURE *** Input and output not identical for file: ", inFile.Name)));
global::DripSharp.PdfCarton.Tests.Support.WriteImage(bim3, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(outFile.FullName, "-diff.png"))));
global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Files differ: ", inFile.FullName), "\n"), "              "), outFile.FullName)));
} else {
global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.LOG, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("*** TEST OK *** for file: ", inFile.Name)));
global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.LOG, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("Deleting: ", outFile.Name)));
global::DripSharp.Runtime.JavaCompat.FileDelete(outFile);
global::DripSharp.PdfCarton.Tests.Support.DeleteOnExit(outFile);
}
} else {
global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.LOG, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("*** TEST OK *** for file: ", inFile.Name)));
global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.LOG, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("Deleting: ", outFile.Name)));
global::DripSharp.Runtime.JavaCompat.FileDelete(outFile);
global::DripSharp.PdfCarton.Tests.Support.DeleteOnExit(outFile);
}
}
}
} catch (global::System.Exception e) when (e is not global::System.TypeInitializationException) {
(global::DripSharp.Runtime.JavaCompat.OpenFileOutput(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", outDir), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(file.Name, ".cmperror"))))).Dispose();
failed = true;
global::Microsoft.Extensions.Logging.LoggerExtensions.LogError(global::DripSharp.PdfCarton.Rendering.TestPDFToImage.LOG, (global::System.Exception)e, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("Error comparing file output for ", file.Name)));
}
return !failed;
}

private static bool filesAreIdentical(global::System.IO.FileInfo left, global::System.IO.FileInfo right) {
if (((((left != default!) && (right != default!)) && global::System.IO.File.Exists(left.FullName)) && global::System.IO.File.Exists(right.FullName))) {
if ((left.Length != right.Length)) {
return false;
}
global::System.IO.Stream lin = global::DripSharp.Runtime.JavaCompat.OpenFileInput(left);
global::System.IO.Stream rin = global::DripSharp.Runtime.JavaCompat.OpenFileInput(right);
try {
sbyte[] lbuffer = new sbyte[4096];
sbyte[] rbuffer = new sbyte[lbuffer.Length];
int lcount;
while (((lcount = global::DripSharp.Runtime.JavaCompat.InputStreamRead(lin, lbuffer)) > 0)) {
int bytesRead = 0;
int rcount;
while (((rcount = global::DripSharp.Runtime.JavaCompat.InputStreamRead(rin, rbuffer, bytesRead, (lcount - bytesRead))) > 0)) {
bytesRead += rcount;
}
for (int byteIndex = 0; (byteIndex < lcount); byteIndex++) {
if (((int)(lbuffer[byteIndex]) != (int)(rbuffer[byteIndex]))) {
return false;
}
}
}
} finally {
lin.Dispose();
rin.Dispose();
}
return true;
} else {
return false;
}
}
}
