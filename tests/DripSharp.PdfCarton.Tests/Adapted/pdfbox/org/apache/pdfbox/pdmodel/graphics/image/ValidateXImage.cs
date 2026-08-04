// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Graphics.Image;

public class ValidateXImage {
public static void Validate(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage, int bpc, int width, int height, string format, string colorSpaceName) {
global::DripSharp.Testing.JavaAssertions.NotNull(ximage, null);
global::DripSharp.PdfCarton.Cos.COSStream cosStream = ximage.GetCOSObject();
global::DripSharp.Testing.JavaAssertions.NotNull(cosStream, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Xobject, cosStream.GetItem(global::DripSharp.PdfCarton.Cos.COSName.Type), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Image, cosStream.GetItem(global::DripSharp.PdfCarton.Cos.COSName.Subtype), null);
global::DripSharp.Testing.JavaAssertions.True((ximage.GetCOSObject().GetLength() > 0), null);
global::DripSharp.Testing.JavaAssertions.Equal(bpc, ximage.GetBitsPerComponent(), null);
global::DripSharp.Testing.JavaAssertions.Equal(width, ximage.GetWidth(), null);
global::DripSharp.Testing.JavaAssertions.Equal(height, ximage.GetHeight(), null);
global::DripSharp.Testing.JavaAssertions.Equal(format, ximage.GetSuffix(), null);
global::DripSharp.Testing.JavaAssertions.Equal(colorSpaceName, ximage.GetColorSpace().GetName(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(ximage.GetImage(), null);
global::DripSharp.Testing.JavaAssertions.Equal(ximage.GetWidth(), ximage.GetImage().Width, null);
global::DripSharp.Testing.JavaAssertions.Equal(ximage.GetHeight(), ximage.GetImage().Height, null);
global::DripSharp.Runtime.JavaRaster rawRaster = ximage.GetRawRaster();
global::DripSharp.Testing.JavaAssertions.NotNull(rawRaster, null);
global::DripSharp.Testing.JavaAssertions.Equal(rawRaster.Width, ximage.GetWidth(), null);
global::DripSharp.Testing.JavaAssertions.Equal(rawRaster.Height, ximage.GetHeight(), null);
if (global::DripSharp.Runtime.JavaCompat.Equals(colorSpaceName, "ICCBased")) {
global::SkiaSharp.SKBitmap rawImage = ximage.GetRawImage();
global::DripSharp.Testing.JavaAssertions.NotNull(rawImage, null);
global::DripSharp.Testing.JavaAssertions.Equal(rawImage.Width, ximage.GetWidth(), null);
global::DripSharp.Testing.JavaAssertions.Equal(rawImage.Height, ximage.GetHeight(), null);
}
bool canEncode = true;
bool writeOk;
if ((global::DripSharp.Runtime.JavaCompat.Equals("jpg", format) && (global::DripSharp.Runtime.PdfCartonFontCompat.GetImageType(ximage.GetImage()) == global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_ARGB))) {
global::DripSharp.Runtime.JavaImageWriter writer = (global::DripSharp.Runtime.PdfCartonImageIO.GetImageWritersBySuffix(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", format))).Next()!;
global::DripSharp.Runtime.JavaImageWriter originatingProvider = writer;
canEncode = true;
}
if (canEncode) {
writeOk = global::DripSharp.PdfCarton.Tests.Support.WriteImage(ximage.GetImage(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", format), new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.NullOutputStream());
global::DripSharp.Testing.JavaAssertions.True(writeOk, null);
}
writeOk = global::DripSharp.PdfCarton.Tests.Support.WriteImage(ximage.GetOpaqueImage((global::SkiaSharp.SKRectI)default!, 1), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", format), new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.NullOutputStream());
global::DripSharp.Testing.JavaAssertions.True(writeOk, null);
}

internal class NullOutputStream : global::DripSharp.Runtime.JavaOutputStream {
public override void Write(int b) {}
}

public static int ColorCount(global::SkiaSharp.SKBitmap bim) {
global::System.Collections.Generic.ISet<int> colors = new global::System.Collections.Generic.HashSet<int>();
int w = bim.Width;
int h = bim.Height;
for (int y = 0; (y < h); y++) {
for (int x = 0; (x < w); x++) {
colors.Add(global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(bim, x, y));
}
}
return colors.Count;
}

internal static void doWritePDF(global::DripSharp.PdfCarton.Pdmodel.PDDocument document, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage, global::System.IO.FileInfo testResultsDir, string filename) {
global::System.IO.FileInfo pdfFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine(testResultsDir.FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
document.AddPage(page);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document, page, global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false)) {
contentStream.DrawImage(ximage, (float)(150), (float)(300));
contentStream.DrawImage(ximage, (float)(200), (float)(350));
}
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.count(document.GetPage(0).GetResources().GetXObjectNames()), null);
document.Save(pdfFile);
document.Dispose();
document = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfFile);
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.count(document.GetPage(0).GetResources().GetXObjectNames()), null);
new global::DripSharp.PdfCarton.Rendering.PDFRenderer(document).RenderImage(0);
document.Dispose();
}

private static int count(global::System.Collections.Generic.IEnumerable<global::DripSharp.PdfCarton.Cos.COSName> iterable) {
int count = 0;
foreach (global::DripSharp.PdfCarton.Cos.COSName name in iterable) {
count++;
}
return count;
}

public static void CheckIdent(global::SkiaSharp.SKBitmap expectedImage, global::SkiaSharp.SKBitmap actualImage) {
string errMsg = "";
expectedImage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.ConvertToSRGB(expectedImage);
actualImage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.ConvertToSRGB(actualImage);
int w = expectedImage.Width;
int h = expectedImage.Height;
global::DripSharp.Testing.JavaAssertions.Equal(w, actualImage.Width, null);
global::DripSharp.Testing.JavaAssertions.Equal(h, actualImage.Height, null);
for (int y = 0; (y < h); ++y) {
for (int x = 0; (x < w); ++x) {
if ((global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(expectedImage, x, y) != global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(actualImage, x, y))) {
errMsg = global::DripSharp.Runtime.JavaCompat.JavaStringFormat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "(%d,%d) expected: <%08X> but was: <%08X>; "), x, y, global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(expectedImage, x, y), global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(actualImage, x, y));
}
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(expectedImage, x, y), global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(actualImage, x, y), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", errMsg));
}
}
}

public static global::SkiaSharp.SKBitmap ConvertToSRGB(global::SkiaSharp.SKBitmap image) {
if (global::DripSharp.Runtime.PdfCartonFontCompat.GetColorModel(image).ColorSpace.IsSrgb) {
return image;
}
if ((global::DripSharp.Runtime.PdfCartonFontCompat.GetRaster(image).GetDataBuffer().DataType == global::DripSharp.Runtime.PdfCartonFontCompat.DATA_BUFFER_TYPE_USHORT)) {
int width = image.Width;
bool hasAlpha = global::DripSharp.Runtime.PdfCartonFontCompat.GetColorModel(image).HasAlpha;
global::DripSharp.PdfCarton.Tests.JavaDirectColorModel colorModel = new global::DripSharp.PdfCarton.Tests.JavaDirectColorModel(global::DripSharp.Runtime.PdfCartonFontCompat.GetColorModel(image).ColorSpace, 32, 255, 65280, 16711680, -16777216, false, global::DripSharp.Runtime.PdfCartonFontCompat.DATA_BUFFER_TYPE_INT);
global::DripSharp.Runtime.JavaRaster targetRaster = global::DripSharp.PdfCarton.Tests.Support.CreatePackedRaster(global::DripSharp.Runtime.PdfCartonFontCompat.DATA_BUFFER_TYPE_INT, image.Width, image.Height, colorModel.GetMasks(), new global::DripSharp.Runtime.JavaPoint(0, 0));
global::SkiaSharp.SKBitmap image8Bit = global::DripSharp.Runtime.PdfCartonFontCompat.CreateImage(colorModel, targetRaster, false, new global::DripSharp.Runtime.JavaHashtable<object, object>());
global::DripSharp.Runtime.JavaRaster sourceRaster = global::DripSharp.Runtime.PdfCartonFontCompat.GetRaster(image);
int numShortPixelElements = (hasAlpha ? 3 : 4);
short[] pixelShort = new short[(numShortPixelElements * width)];
int[] pixelInt = new int[width];
for (int y = 0; (y < image.Height); y++) {
sourceRaster.GetDataElements(0, y, width, 1, pixelShort);
int ptrShort = 0;
for (int x = 0; (x < width); x++) {
int r = (pixelShort[ptrShort++] & 65535);
int g = (pixelShort[ptrShort++] & 65535);
int b = (pixelShort[ptrShort++] & 65535);
if (hasAlpha) {
ptrShort++;
}
int r8bit = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.convert16To8Bit(r);
int g8bit = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.convert16To8Bit(g);
int b8bit = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.convert16To8Bit(b);
int v = (((r8bit | (g8bit << unchecked((int)(8)))) | (b8bit << unchecked((int)(16)))) | -16777216);
pixelInt[x] = v;
}
global::DripSharp.PdfCarton.Tests.Support.SetDataElements(targetRaster, 0, y, width, 1, pixelInt);
}
image = image8Bit;
}
global::SkiaSharp.SKBitmap destination = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(image.Width, image.Height, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_RGB);
global::DripSharp.Runtime.JavaColorConvertOp op = new global::DripSharp.Runtime.JavaColorConvertOp(global::DripSharp.Runtime.PdfCartonFontCompat.GetColorSpace(global::DripSharp.Runtime.JavaColorSpace.CS_sRGB));
return op.Filter(image, destination);
}

private static int convert16To8Bit(int v) {
float output = (v / (float)(65535));
return global::DripSharp.Runtime.JavaCompat.MathRoundFloat((output * 255));
}
}
