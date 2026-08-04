// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Graphics.Image;

public class LosslessFactoryTest {
private static readonly global::System.IO.FileInfo TESTRESULTSDIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output/graphics"));

internal static void setUp() {
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactoryTest.TESTRESULTSDIR);
}

internal virtual void testCreateLosslessFromImageRGB() {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::SkiaSharp.SKBitmap image = global::DripSharp.PdfCarton.Tests.Support.ReadImage(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png.png")));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage1 = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document, image);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage1, 8, image.Width, image.Height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(image, ximage1.GetImage());
global::SkiaSharp.SKBitmap grayImage = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(image.Width, image.Height, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_BYTE_GRAY);
global::DripSharp.Runtime.PdfCartonGraphics2D g = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(grayImage);
g.DrawImage(image, 0, 0, (object)default!);
g.Dispose();
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage2 = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document, grayImage);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage2, 8, grayImage.Width, grayImage.Height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(grayImage, ximage2.GetImage());
global::SkiaSharp.SKBitmap bitonalImage = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(image.Width, image.Height, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_BYTE_BINARY);
global::DripSharp.Testing.JavaAssertions.NotEqual(0, (bitonalImage.Width % 8), null);
g = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(bitonalImage);
g.DrawImage(image, 0, 0, (object)default!);
g.Dispose();
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage3 = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document, bitonalImage);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage3, 1, bitonalImage.Width, bitonalImage.Height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(bitonalImage, ximage3.GetImage());
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
document.AddPage(page);
global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document, page, global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false);
contentStream.DrawImage(ximage1, (float)(200), (float)(300), (float)((ximage1.GetWidth() / 2)), (float)((ximage1.GetHeight() / 2)));
contentStream.DrawImage(ximage2, (float)(200), (float)(450), (float)((ximage2.GetWidth() / 2)), (float)((ximage2.GetHeight() / 2)));
contentStream.DrawImage(ximage3, (float)(200), (float)(600), (float)((ximage3.GetWidth() / 2)), (float)((ximage3.GetHeight() / 2)));
contentStream.Dispose();
global::System.IO.FileInfo pdfFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactoryTest.TESTRESULTSDIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "misc.pdf")));
document.Save(pdfFile);
document.Dispose();
document = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfFile, (string)default!);
new global::DripSharp.PdfCarton.Rendering.PDFRenderer(document).RenderImage(0);
document.Dispose();
}

internal virtual void testCreateLosslessFromImageINT_ARGB() {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::SkiaSharp.SKBitmap image = global::DripSharp.PdfCarton.Tests.Support.ReadImage(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png.png")));
int w = image.Width;
int h = image.Height;
global::SkiaSharp.SKBitmap argbImage = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(w, h, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_ARGB);
global::DripSharp.Runtime.PdfCartonGraphics2D ag = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(argbImage);
ag.DrawImage(image, 0, 0, (object)default!);
ag.Dispose();
for (int x = 0; (x < argbImage.Width); ++x) {
for (int y = 0; (y < argbImage.Height); ++y) {
global::DripSharp.Runtime.PdfCartonFontCompat.SetRgb(argbImage, x, y, ((global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(argbImage, x, y) & 16777215) | (((y / 10) * 10) << unchecked((int)(24)))));
}
}
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document, argbImage);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, argbImage.Width, argbImage.Height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(argbImage, ximage.GetImage());
this.checkIdentRGB(argbImage, ximage.GetOpaqueImage((global::SkiaSharp.SKRectI)default!, 1));
global::DripSharp.Testing.JavaAssertions.NotNull(ximage.GetSoftMask(), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage.GetSoftMask(), 8, argbImage.Width, argbImage.Height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.ColorCount(ximage.GetSoftMask().GetImage()) > (image.Height / 10)), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "intargb.pdf"));
}

internal virtual void testCreateLosslessFromImageBITMASK_INT_ARGB() {
this.doBitmaskTransparencyTest(global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_ARGB, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "bitmaskintargb.pdf"));
}

internal virtual void testCreateLosslessFromImageBITMASK4BYTE_ABGR() {
this.doBitmaskTransparencyTest(global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_4BYTE_ABGR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "bitmask4babgr.pdf"));
}

internal virtual void testCreateLosslessFromImage4BYTE_ABGR() {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::SkiaSharp.SKBitmap image = global::DripSharp.PdfCarton.Tests.Support.ReadImage(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png.png")));
int w = image.Width;
int h = image.Height;
global::SkiaSharp.SKBitmap argbImage = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(w, h, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_4BYTE_ABGR);
global::DripSharp.Runtime.PdfCartonGraphics2D ag = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(argbImage);
ag.DrawImage(image, 0, 0, (object)default!);
ag.Dispose();
for (int x = 0; (x < argbImage.Width); ++x) {
for (int y = 0; (y < argbImage.Height); ++y) {
global::DripSharp.Runtime.PdfCartonFontCompat.SetRgb(argbImage, x, y, ((global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(argbImage, x, y) & 16777215) | (((y / 10) * 10) << unchecked((int)(24)))));
}
}
argbImage = global::DripSharp.PdfCarton.Tests.Support.Subimage(argbImage, 1, 1, (argbImage.Width - 2), (argbImage.Height - 2));
w -= 2;
h -= 2;
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document, argbImage);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, w, h, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(argbImage, ximage.GetImage());
this.checkIdentRGB(argbImage, ximage.GetOpaqueImage((global::SkiaSharp.SKRectI)default!, 1));
global::DripSharp.Testing.JavaAssertions.NotNull(ximage.GetSoftMask(), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage.GetSoftMask(), 8, w, h, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.ColorCount(ximage.GetSoftMask().GetImage()) > (image.Height / 10)), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "4babgr.pdf"));
}

internal virtual void testCreateLosslessFromImageUSHORT_555_RGB() {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::SkiaSharp.SKBitmap image = global::DripSharp.PdfCarton.Tests.Support.ReadImage(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png.png")));
int w = image.Width;
int h = image.Height;
global::SkiaSharp.SKBitmap rgbImage = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(w, h, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_RGB);
global::DripSharp.Runtime.PdfCartonGraphics2D ag = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(rgbImage);
ag.DrawImage(image, 0, 0, (object)default!);
ag.Dispose();
for (int x = 0; (x < rgbImage.Width); ++x) {
for (int y = 0; (y < rgbImage.Height); ++y) {
global::DripSharp.Runtime.PdfCartonFontCompat.SetRgb(rgbImage, x, y, ((global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(rgbImage, x, y) & 16777215) | (((y / 10) * 10) << unchecked((int)(24)))));
}
}
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document, rgbImage);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, w, h, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(rgbImage, ximage.GetImage());
this.checkIdentRGB(rgbImage, ximage.GetOpaqueImage((global::SkiaSharp.SKRectI)default!, 1));
global::DripSharp.Testing.JavaAssertions.Null(ximage.GetSoftMask(), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ushort555rgb.pdf"));
}

internal virtual void testCreateLosslessFromTransparentGIF() {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::SkiaSharp.SKBitmap image = global::DripSharp.PdfCarton.Tests.Support.ReadImage(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "gif.gif")));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.PdfCartonTransparency.BITMASK, global::DripSharp.PdfCarton.Tests.Support.ColorModelTransparency(global::DripSharp.Runtime.PdfCartonFontCompat.GetColorModel(image)), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document, image);
int w = image.Width;
int h = image.Height;
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, w, h, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(image, ximage.GetImage());
this.checkIdentRGB(image, ximage.GetOpaqueImage((global::SkiaSharp.SKRectI)default!, 1));
global::DripSharp.Testing.JavaAssertions.NotNull(ximage.GetSoftMask(), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage.GetSoftMask(), 1, w, h, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
global::DripSharp.Testing.JavaAssertions.Equal(2, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.ColorCount(ximage.GetSoftMask().GetImage()), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "gif.pdf"));
}

internal virtual void testCreateLosslessFromTransparent1BitGIF() {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::SkiaSharp.SKBitmap image = global::DripSharp.PdfCarton.Tests.Support.ReadImage(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "gif-1bit-transparent.gif")));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.PdfCartonTransparency.BITMASK, global::DripSharp.PdfCarton.Tests.Support.ColorModelTransparency(global::DripSharp.Runtime.PdfCartonFontCompat.GetColorModel(image)), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_BYTE_BINARY, global::DripSharp.Runtime.PdfCartonFontCompat.GetImageType(image), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document, image);
int w = image.Width;
int h = image.Height;
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, w, h, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(image, ximage.GetImage());
this.checkIdentRGB(image, ximage.GetOpaqueImage((global::SkiaSharp.SKRectI)default!, 1));
global::DripSharp.Testing.JavaAssertions.NotNull(ximage.GetSoftMask(), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage.GetSoftMask(), 1, w, h, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
global::DripSharp.Testing.JavaAssertions.Equal(2, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.ColorCount(ximage.GetSoftMask().GetImage()), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "gif-1bit-transparent.pdf"));
}

internal virtual void testCreateLosslessFromGovdocs032163() {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::SkiaSharp.SKBitmap image = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/imgs"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4184-032163.jpg")));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document, image);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, image.Width, image.Height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(image, ximage.GetImage());
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4184-032163.pdf"));
}

private void checkIdentRGB(global::SkiaSharp.SKBitmap expectedImage, global::SkiaSharp.SKBitmap actualImage) {
string errMsg = "";
int w = expectedImage.Width;
int h = expectedImage.Height;
global::DripSharp.Testing.JavaAssertions.Equal(w, actualImage.Width, null);
global::DripSharp.Testing.JavaAssertions.Equal(h, actualImage.Height, null);
for (int y = 0; (y < h); ++y) {
for (int x = 0; (x < w); ++x) {
if (((global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(expectedImage, x, y) & 16777215) != (global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(actualImage, x, y) & 16777215))) {
errMsg = global::DripSharp.Runtime.JavaCompat.JavaStringFormat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "(%d,%d) %06X != %06X"), x, y, (global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(expectedImage, x, y) & 16777215), (global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(actualImage, x, y) & 16777215));
}
global::DripSharp.Testing.JavaAssertions.Equal((global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(expectedImage, x, y) & 16777215), (global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(actualImage, x, y) & 16777215), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", errMsg));
}
}
}

internal static void checkIdentRaw(global::SkiaSharp.SKBitmap expectedImage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject actualImage) {
global::DripSharp.Runtime.JavaRaster expectedRaster = global::DripSharp.Runtime.PdfCartonFontCompat.GetRaster(expectedImage);
global::DripSharp.Runtime.JavaRaster actualRaster = actualImage.GetRawRaster();
int w = expectedRaster.Width;
int h = expectedRaster.Height;
global::DripSharp.Testing.JavaAssertions.Equal(w, actualRaster.Width, null);
global::DripSharp.Testing.JavaAssertions.Equal(h, actualRaster.Height, null);
global::DripSharp.Testing.JavaAssertions.Equal(expectedRaster.GetDataBuffer().DataType, actualRaster.GetDataBuffer().DataType, null);
int numDataElements = expectedRaster.NumberOfBands;
int numDataElementsToCompare;
if ((global::DripSharp.Runtime.PdfCartonFontCompat.GetAlphaRaster(expectedImage) != default!)) {
numDataElementsToCompare = (numDataElements - 1);
global::DripSharp.Testing.JavaAssertions.Equal(numDataElementsToCompare, actualRaster.NumberOfBands, null);
} else {
numDataElementsToCompare = numDataElements;
global::DripSharp.Testing.JavaAssertions.Equal(numDataElements, actualRaster.NumberOfBands, null);
}
int[] expectedData = new int[numDataElements];
int[] actualData = new int[numDataElements];
for (int y = 0; (y < h); ++y) {
for (int x = 0; (x < w); ++x) {
expectedRaster.GetPixel(x, y, expectedData);
actualRaster.GetPixel(x, y, actualData);
for (int i = 0; (i < numDataElementsToCompare); i++) {
int expectedValue = expectedData[i];
int actualValue = actualData[i];
if ((expectedValue != actualValue)) {
string errMsg = global::DripSharp.Runtime.JavaCompat.JavaStringFormat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "(%d,%d) Channel %d %04X != %04X"), x, y, i, expectedValue, actualValue);
global::DripSharp.Testing.JavaAssertions.Equal(expectedValue, actualValue, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", errMsg));
}
}
}
}
}

private void doBitmaskTransparencyTest(int imageType, string pdfFilename) {
global::System.IO.FileInfo pdfFile;
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__452_25 = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
int width = 257;
int height = 256;
global::SkiaSharp.SKBitmap argbImage = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(width, height, imageType);
global::DripSharp.Runtime.PdfCartonGraphics2D g = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(argbImage);
global::DripSharp.Runtime.JavaGraphicsConfiguration gc = g.GetDeviceConfiguration();
argbImage = global::DripSharp.PdfCarton.Tests.Support.CreateCompatibleImage(width, height, global::DripSharp.Runtime.PdfCartonTransparency.BITMASK);
g.Dispose();
g = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(argbImage);
g.SetColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Red);
g.FillRect(0, 0, width, height);
g.Dispose();
global::DripSharp.PdfCarton.Tests.JavaRandom random = new global::DripSharp.PdfCarton.Tests.JavaRandom();
random.SetSeed((long)(12345));
int startX = ((width / 2) - (width / 8));
int endX = ((width / 2) + (width / 8));
int startY = ((height / 2) - (height / 8));
int endY = ((height / 2) + (height / 8));
for (int x__476_22 = 0; (x__476_22 < width); ++x__476_22) {
for (int y__478_26 = 0; (y__478_26 < height); ++y__478_26) {
int alpha;
if ((((x__476_22 >= startX) && (x__476_22 <= endX)) || ((y__478_26 >= startY) && (y__478_26 <= endY)))) {
alpha = (128 + random.NextInt(128));
global::DripSharp.Testing.JavaAssertions.True((alpha >= 128), null);
global::DripSharp.Runtime.PdfCartonFontCompat.SetRgb(argbImage, x__476_22, y__478_26, ((global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(argbImage, x__476_22, y__478_26) & 16777215) | (alpha << unchecked((int)(24)))));
global::DripSharp.Testing.JavaAssertions.Equal(255, (global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(argbImage, x__476_22, y__478_26) >>> unchecked((int)(24))), null);
} else {
alpha = random.NextInt(128);
global::DripSharp.Testing.JavaAssertions.True((alpha < 128), null);
global::DripSharp.Runtime.PdfCartonFontCompat.SetRgb(argbImage, x__476_22, y__478_26, ((global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(argbImage, x__476_22, y__478_26) & 16777215) | (alpha << unchecked((int)(24)))));
global::DripSharp.Testing.JavaAssertions.Equal(0, (global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(argbImage, x__476_22, y__478_26) >>> unchecked((int)(24))), null);
}
}
}
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document__452_25, argbImage);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, width, height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(argbImage, ximage.GetImage());
this.checkIdentRGB(argbImage, ximage.GetOpaqueImage((global::SkiaSharp.SKRectI)default!, 1));
global::DripSharp.Testing.JavaAssertions.NotNull(ximage.GetSoftMask(), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage.GetSoftMask(), 1, width, height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
global::DripSharp.Testing.JavaAssertions.Equal(2, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.ColorCount(ximage.GetSoftMask().GetImage()), null);
global::SkiaSharp.SKBitmap maskImage = ximage.GetSoftMask().GetImage();
global::DripSharp.Testing.JavaAssertions.NotEqual(0, (maskImage.Width % 8), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.PdfCartonTransparency.OPAQUE, global::DripSharp.Runtime.PdfCartonFontCompat.GetTransparency(maskImage), null);
for (int x__511_22 = 0; (x__511_22 < width); ++x__511_22) {
for (int y__513_26 = 0; (y__513_26 < height); ++y__513_26) {
if ((((x__511_22 >= startX) && (x__511_22 <= endX)) || ((y__513_26 >= startY) && (y__513_26 <= endY)))) {
global::DripSharp.Testing.JavaAssertions.Equal(16777215, (global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(maskImage, x__511_22, y__513_26) & 16777215), null);
} else {
global::DripSharp.Testing.JavaAssertions.Equal(0, (global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(maskImage, x__511_22, y__513_26) & 16777215), null);
}
}
}
global::SkiaSharp.SKBitmap rectImage = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(width, height, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_RGB);
g = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(rectImage);
g.SetColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Blue);
g.FillRect(0, 0, width, height);
g.Dispose();
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage2 = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document__452_25, rectImage);
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
document__452_25.AddPage(page);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__452_25, page, global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false)) {
contentStream.DrawImage(ximage2, (float)(150), (float)(300), (float)(ximage2.GetWidth()), (float)(ximage2.GetHeight()));
contentStream.DrawImage(ximage, (float)(150), (float)(300), (float)(ximage.GetWidth()), (float)(ximage.GetHeight()));
}
pdfFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactoryTest.TESTRESULTSDIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", pdfFilename)));
document__452_25.Save(pdfFile);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__545_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfFile, (string)default!)) {
new global::DripSharp.PdfCarton.Rendering.PDFRenderer(document__545_25).RenderImage(0);
}
}

internal virtual void testCreateLosslessFromImageCMYK() {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::SkiaSharp.SKBitmap image = global::DripSharp.PdfCarton.Tests.Support.ReadImage(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png.png")));
global::DripSharp.Runtime.JavaColorSpace targetCS;
using (global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "/org/apache/pdfbox/resources/icc/ISOcoated_v2_300_bas.icc"))) {
targetCS = new global::DripSharp.Runtime.JavaIccColorSpace(global::DripSharp.Runtime.PdfCartonFontCompat.GetIccProfile(@is));
}
global::DripSharp.Runtime.JavaColorConvertOp op = new global::DripSharp.Runtime.JavaColorConvertOp(global::DripSharp.Runtime.PdfCartonFontCompat.GetColorModel(image).ColorSpace, targetCS);
global::SkiaSharp.SKBitmap imageCMYK = op.Filter(image, (global::SkiaSharp.SKBitmap)default!);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document, imageCMYK);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, imageCMYK.Width, imageCMYK.Height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ICCBased"));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "cmyk.pdf"));
}

internal virtual void testCreateLosslessFrom16Bit() {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::SkiaSharp.SKBitmap image = global::DripSharp.PdfCarton.Tests.Support.ReadImage(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png.png")));
global::DripSharp.Runtime.JavaColorSpace targetCS = global::DripSharp.Runtime.PdfCartonFontCompat.GetColorSpace(global::DripSharp.Runtime.JavaColorSpace.CS_sRGB);
int dataBufferType = global::DripSharp.Runtime.PdfCartonFontCompat.DATA_BUFFER_TYPE_USHORT;
global::DripSharp.Runtime.JavaColorModel colorModel = global::DripSharp.Runtime.PdfCartonFontCompat.ComponentColorModel(targetCS, false, false, global::DripSharp.Runtime.PdfCartonTransparency.OPAQUE, dataBufferType);
global::DripSharp.Runtime.JavaRaster targetRaster = global::DripSharp.Runtime.PdfCartonFontCompat.CreateInterleavedRaster(dataBufferType, image.Width, image.Height, targetCS.NumberOfComponents, new global::DripSharp.Runtime.JavaPoint(0, 0));
global::SkiaSharp.SKBitmap img16Bit = global::DripSharp.Runtime.PdfCartonFontCompat.CreateImage(colorModel, targetRaster, false, new global::DripSharp.Runtime.JavaHashtable<object, object>());
global::DripSharp.Runtime.JavaColorConvertOp op = new global::DripSharp.Runtime.JavaColorConvertOp(global::DripSharp.Runtime.PdfCartonFontCompat.GetColorModel(image).ColorSpace, targetCS);
op.Filter(image, img16Bit);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document, img16Bit);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 16, img16Bit.Width, img16Bit.Height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(image, ximage.GetImage());
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "misc-16bit.pdf"));
}

internal virtual void testCreateLosslessFromImageINT_BGR() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::SkiaSharp.SKBitmap image = global::DripSharp.PdfCarton.Tests.Support.ReadImage(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png.png")));
global::SkiaSharp.SKBitmap imgBgr = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(image.Width, image.Height, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_BGR);
global::DripSharp.Runtime.PdfCartonGraphics2D graphics = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(imgBgr);
graphics.DrawImage(image, 0, 0, (object)default!);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document, imgBgr);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, imgBgr.Width, imgBgr.Height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(image, ximage.GetImage());
}
}

internal virtual void testCreateLosslessFromImageINT_RGB() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::SkiaSharp.SKBitmap image = global::DripSharp.PdfCarton.Tests.Support.ReadImage(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png.png")));
global::SkiaSharp.SKBitmap imgRgb = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(image.Width, image.Height, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_RGB);
global::DripSharp.Runtime.PdfCartonGraphics2D graphics = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(imgRgb);
graphics.DrawImage(image, 0, 0, (object)default!);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document, imgRgb);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, imgRgb.Width, imgRgb.Height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(image, ximage.GetImage());
}
}

internal virtual void testCreateLosslessFromImageBYTE_3BGR() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::SkiaSharp.SKBitmap image = global::DripSharp.PdfCarton.Tests.Support.ReadImage(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png.png")));
global::SkiaSharp.SKBitmap imgRgb = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(image.Width, image.Height, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_3BYTE_BGR);
global::DripSharp.Runtime.PdfCartonGraphics2D graphics = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(imgRgb);
graphics.DrawImage(image, 0, 0, (object)default!);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document, imgRgb);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, imgRgb.Width, imgRgb.Height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(image, ximage.GetImage());
}
}

internal virtual void testCreateLosslessFrom16BitPNG() {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::SkiaSharp.SKBitmap image = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/imgs"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4184-16bit.png")));
global::DripSharp.Testing.JavaAssertions.Equal(64, global::DripSharp.Runtime.PdfCartonFontCompat.GetColorModel(image).PixelSize, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.PdfCartonTransparency.TRANSLUCENT, global::DripSharp.PdfCarton.Tests.Support.ColorModelTransparency(global::DripSharp.Runtime.PdfCartonFontCompat.GetColorModel(image)), null);
global::DripSharp.Testing.JavaAssertions.Equal(4, global::DripSharp.Runtime.PdfCartonFontCompat.GetRaster(image).NumberOfBands, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.PdfCartonFontCompat.DATA_BUFFER_TYPE_USHORT, global::DripSharp.Runtime.PdfCartonFontCompat.GetRaster(image).GetDataBuffer().DataType, null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(document, image);
int w = image.Width;
int h = image.Height;
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 16, w, h, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(image, ximage.GetImage());
this.checkIdentRGB(image, ximage.GetOpaqueImage((global::SkiaSharp.SKRectI)default!, 1));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactoryTest.checkIdentRaw(image, ximage);
global::DripSharp.Testing.JavaAssertions.NotNull(ximage.GetSoftMask(), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage.GetSoftMask(), 16, w, h, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
global::DripSharp.Testing.JavaAssertions.Equal(35, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.ColorCount(ximage.GetSoftMask().GetImage()), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png16bit.pdf"));
}

[Xunit.Fact]
public void __Upstream_3932773588_65c5cd0397443493()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateLosslessFrom16Bit();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3140139189_48e483f893889969()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateLosslessFrom16BitPNG();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3754448596_d5c45c022190d4fb()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateLosslessFromGovdocs032163();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0294780054_e146743b4ad828cb()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateLosslessFromImage4BYTE_ABGR();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2354612097_0226ad34b297f38b()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateLosslessFromImageBITMASK4BYTE_ABGR();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0739617481_55d0337256a064a0()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateLosslessFromImageBITMASK_INT_ARGB();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2048332522_206d9bbc2da664a8()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateLosslessFromImageBYTE_3BGR();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1167432419_bf96615ecbf96cf2()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateLosslessFromImageCMYK();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2526354851_bc028f31cae2beb3()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateLosslessFromImageINT_ARGB();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3683726582_4e98f32e797506c1()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateLosslessFromImageINT_BGR();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3683741942_60caf46929579bac()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateLosslessFromImageINT_RGB();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0176220646_f9a944b75716b20a()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateLosslessFromImageRGB();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3067442450_3c58a0708254834d()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateLosslessFromImageUSHORT_555_RGB();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0281058538_a9f175f491264ad9()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateLosslessFromTransparent1BitGIF();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2471448198_2b52e34291b5d239()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateLosslessFromTransparentGIF();
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
