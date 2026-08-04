// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Printing;

public class TestPDFPrintable {
private const int IMAGE_WIDTH = 100;

private const int IMAGE_HEIGHT = 100;

internal virtual void testShowPageBorderIsGrayWithoutRasterization() {
this.testShowPageBorderIsGray(global::DripSharp.PdfCarton.Printing.PDFPrintable.RasterizeOff);
}

internal virtual void testShowPageBorderIsGrayWithRasterization() {
this.testShowPageBorderIsGray(150.0F);
}

internal virtual void testPrinterGraphicsStateIsUnchangedAfterPrint() {
this.assertPrinterGraphicsStateUnchanged(global::DripSharp.PdfCarton.Printing.PDFPrintable.RasterizeOff);
}

internal virtual void testPrinterGraphicsStateIsUnchangedAfterPrintWhenRasterizing() {
this.assertPrinterGraphicsStateUnchanged(150.0F);
}

private void assertPrinterGraphicsStateUnchanged(float dpi) {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
doc.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage(new global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle((float)(global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_WIDTH), (float)(global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_HEIGHT))));
global::DripSharp.PdfCarton.Printing.PDFPrintable printable = new global::DripSharp.PdfCarton.Printing.PDFPrintable(doc, global::DripSharp.PdfCarton.Printing.Scaling.ActualSize, true, dpi);
global::SkiaSharp.SKBitmap output = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_WIDTH, global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_HEIGHT, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_ARGB);
global::DripSharp.Runtime.PdfCartonGraphics2D g2d = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(output);
g2d.Translate(7.0D, 11.0D);
g2d.Scale(1.3D, 1.3D);
global::DripSharp.Runtime.JavaColor originalColor = (global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Red;
global::DripSharp.Runtime.JavaColor originalBackground = (global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Blue;
global::DripSharp.Runtime.JavaStroke originalStroke = new global::DripSharp.Runtime.JavaBasicStroke(3.7F);
g2d.SetColor(originalColor);
g2d.SetBackground(originalBackground);
g2d.SetStroke(originalStroke);
global::SkiaSharp.SKMatrix originalTransform = g2d.GetTransform();
global::SkiaSharp.SKRect originalClipDeviceBounds = global::DripSharp.PdfCarton.Printing.TestPDFPrintable.deviceClipBounds(g2d);
global::DripSharp.Runtime.JavaPageFormat pf = global::DripSharp.PdfCarton.Printing.TestPDFPrintable.createPageFormat((double)(global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_WIDTH), (double)(global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_HEIGHT));
int result = printable.Print(g2d, pf, 0);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaPrintable.PAGE_EXISTS, result, null);
global::DripSharp.Testing.JavaAssertions.Equal(originalColor, g2d.GetColor(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "color should be unchanged after print()"));
global::DripSharp.Testing.JavaAssertions.Equal(originalBackground, g2d.GetBackground(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "background should be unchanged after print()"));
global::DripSharp.Testing.JavaAssertions.Equal(originalStroke, g2d.GetStroke(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "stroke should be unchanged after print()"));
global::DripSharp.Testing.JavaAssertions.Equal(originalTransform, g2d.GetTransform(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "transform should be unchanged after print() (translate/scale inside print() must not leak)"));
global::DripSharp.Testing.JavaAssertions.Equal(originalClipDeviceBounds, global::DripSharp.PdfCarton.Printing.TestPDFPrintable.deviceClipBounds(g2d), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "clip should be unchanged after print()"));
g2d.Dispose();
}
}

private static global::SkiaSharp.SKRect deviceClipBounds(global::DripSharp.Runtime.PdfCartonGraphics2D g2d) {
object clip = g2d.GetClip();
if ((clip == default!)) {
return default!;
}
return global::DripSharp.Runtime.PdfCartonFontCompat.ShapeBounds(global::DripSharp.Runtime.PdfCartonFontCompat.CreateTransformedShape(g2d.GetTransform(), clip));
}

internal virtual void testPrintReturnsNoSuchPageForInvalidIndex() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
doc.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
global::DripSharp.PdfCarton.Printing.PDFPrintable printable = new global::DripSharp.PdfCarton.Printing.PDFPrintable(doc);
global::SkiaSharp.SKBitmap output = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_WIDTH, global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_HEIGHT, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_ARGB);
global::DripSharp.Runtime.PdfCartonGraphics2D g2d = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(output);
global::DripSharp.Runtime.JavaPageFormat pf = global::DripSharp.PdfCarton.Printing.TestPDFPrintable.createPageFormat((double)(global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_WIDTH), (double)(global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_HEIGHT));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaPrintable.NO_SUCH_PAGE, printable.Print(g2d, pf, -1), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaPrintable.NO_SUCH_PAGE, printable.Print(g2d, pf, 1), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaPrintable.PAGE_EXISTS, printable.Print(g2d, pf, 0), null);
g2d.Dispose();
}
}

private void testShowPageBorderIsGray(float dpi) {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage(new global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle((float)(global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_WIDTH), (float)(global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_HEIGHT)));
doc.AddPage(page);
global::DripSharp.PdfCarton.Printing.PDFPrintable printable = new global::DripSharp.PdfCarton.Printing.PDFPrintable(doc, global::DripSharp.PdfCarton.Printing.Scaling.ActualSize, true, dpi);
global::SkiaSharp.SKBitmap output = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_WIDTH, global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_HEIGHT, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_ARGB);
global::DripSharp.Runtime.PdfCartonGraphics2D g2d = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(output);
g2d.SetColor(global::DripSharp.Runtime.JavaColor.White);
g2d.FillRect(0, 0, global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_WIDTH, global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_HEIGHT);
global::DripSharp.Runtime.JavaPageFormat pf = global::DripSharp.PdfCarton.Printing.TestPDFPrintable.createPageFormat((double)(global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_WIDTH), (double)(global::DripSharp.PdfCarton.Printing.TestPDFPrintable.IMAGE_HEIGHT));
int result = printable.Print(g2d, pf, 0);
g2d.Dispose();
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaPrintable.PAGE_EXISTS, result, null);
global::DripSharp.PdfCarton.Printing.TestPDFPrintable.assertBorderPixelIsGray(output);
}
}

private static void assertBorderPixelIsGray(global::SkiaSharp.SKBitmap image) {
bool foundGray = false;
int width = image.Width;
for (int x = 0; (x < width); x++) {
if (global::DripSharp.PdfCarton.Printing.TestPDFPrintable.isGray(global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(image, x, 0))) {
foundGray = true;
break;
}
}
if (!foundGray) {
int height = image.Height;
for (int y = 0; (y < height); y++) {
if (global::DripSharp.PdfCarton.Printing.TestPDFPrintable.isGray(global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(image, 0, y))) {
foundGray = true;
break;
}
}
}
global::DripSharp.Testing.JavaAssertions.True(foundGray, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("Expected a gray border pixel in the top-left corner. ", "If this fails, drawRect may be called on the wrong Graphics object.")));
}

private static bool isGray(int argb) {
int a = ((argb >> unchecked((int)(24))) & 255);
int r = ((argb >> unchecked((int)(16))) & 255);
int g = ((argb >> unchecked((int)(8))) & 255);
int b = (argb & 255);
return (((((a > 0) && (r == g)) && (g == b)) && (r > 50)) && (r < 200));
}

private static global::DripSharp.Runtime.JavaPageFormat createPageFormat(double width, double height) {
global::DripSharp.Runtime.JavaPaper paper = new global::DripSharp.Runtime.JavaPaper();
paper.SetSize(width, height);
paper.SetImageableArea((double)(0), (double)(0), width, height);
global::DripSharp.Runtime.JavaPageFormat pf = new global::DripSharp.Runtime.JavaPageFormat();
pf.SetPaper(paper);
return pf;
}

[Xunit.Fact]
public void __Upstream_1059681925_3beff5472479a80c()
{
        try
        {
            this.testPrintReturnsNoSuchPageForInvalidIndex();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0847680804_6abdc0e884a4e94e()
{
        try
        {
            this.testPrinterGraphicsStateIsUnchangedAfterPrint();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2555083862_94a571ba2fae2543()
{
        try
        {
            this.testPrinterGraphicsStateIsUnchangedAfterPrintWhenRasterizing();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2308306666_aa2f12b1bad597ff()
{
        try
        {
            this.testShowPageBorderIsGrayWithRasterization();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1369685494_420bd09b6cfde1be()
{
        try
        {
            this.testShowPageBorderIsGrayWithoutRasterization();
        }
        finally
        {
        }
}
}
