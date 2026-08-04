// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Graphics.Image;

public class JPEGFactoryTest {
private static readonly global::System.IO.FileInfo TESTRESULTSDIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output/graphics"));

internal static void setUp() {
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest.TESTRESULTSDIR);
}

internal virtual void testCreateFromStream() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::System.IO.Stream is1 = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpeg.jpg"))) using (global::System.IO.Stream is2 = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpeg.jpg"))) {
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromStream(document, is1);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, 344, 287, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpg"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpegrgbstream.pdf"));
this.checkJpegStream(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpegrgbstream.pdf"), is2);
}
}

internal virtual void testCreateFromStreamCMYK() {
using (global::System.IO.Stream is1 = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpegcmyk.jpg"))) using (global::System.IO.Stream is2 = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpegcmyk.jpg"))) {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromStream(document, is1);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, 343, 287, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpg"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceCMYK.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpegcmykstream.pdf"));
this.checkJpegStream(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpegcmykstream.pdf"), is2);
}
}

internal virtual void testCreateFromStream256() {
using (global::System.IO.Stream is1 = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpeg256.jpg"))) using (global::System.IO.Stream is2 = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpeg256.jpg"))) {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromStream(document, is1);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, 344, 287, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpg"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpeg256stream.pdf"));
this.checkJpegStream(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpeg256stream.pdf"), is2);
}
}

internal virtual void testCreateFromImageRGB() {
using (global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpeg.jpg"))) {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::SkiaSharp.SKBitmap image = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(@is);
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.Runtime.PdfCartonFontCompat.GetColorModel(image).NumberOfComponents, null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromImage(document, image);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, 344, 287, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpg"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpegrgb.pdf"));
}
}

internal virtual void testCreateFromImage256() {
using (global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpeg256.jpg"))) {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::SkiaSharp.SKBitmap image = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(@is);
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.PdfCartonFontCompat.GetColorModel(image).NumberOfComponents, null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromImage(document, image);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, 344, 287, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpg"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpeg256.pdf"));
}
}

internal virtual void testCreateFromImageINT_ARGB() {
if ((global::DripSharp.Runtime.JavaCompat.Equals(global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "java.runtime.name")), "OpenJDK Runtime Environment") && ((global::DripSharp.Runtime.JavaCompat.Equals(global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "java.specification.version")), "1.6") || global::DripSharp.Runtime.JavaCompat.Equals(global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "java.specification.version")), "1.7")) || global::DripSharp.Runtime.JavaCompat.Equals(global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "java.specification.version")), "1.8")))) {
return;
}
using (global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpeg.jpg"))) {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::SkiaSharp.SKBitmap image = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(@is);
int width = image.Width;
int height = image.Height;
global::SkiaSharp.SKBitmap argbImage = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(width, height, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_ARGB);
global::DripSharp.Runtime.PdfCartonGraphics2D ag = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(argbImage);
ag.DrawImage(image, 0, 0, (object)default!);
ag.Dispose();
for (int x = 0; (x < argbImage.Width); ++x) {
for (int y = 0; (y < argbImage.Height); ++y) {
global::DripSharp.Runtime.PdfCartonFontCompat.SetRgb(argbImage, x, y, ((global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(argbImage, x, y) & 16777215) | (((y / 10) * 10) << unchecked((int)(24)))));
}
}
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromImage(document, argbImage);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, width, height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpg"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.Testing.JavaAssertions.NotNull(ximage.GetSoftMask(), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage.GetSoftMask(), 8, width, height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpg"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.ColorCount(ximage.GetSoftMask().GetImage()) > (image.Height / 10)), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpeg-intargb.pdf"));
}
}

internal virtual void testCreateFromImage4BYTE_ABGR() {
if ((global::DripSharp.Runtime.JavaCompat.Equals(global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "java.runtime.name")), "OpenJDK Runtime Environment") && ((global::DripSharp.Runtime.JavaCompat.Equals(global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "java.specification.version")), "1.6") || global::DripSharp.Runtime.JavaCompat.Equals(global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "java.specification.version")), "1.7")) || global::DripSharp.Runtime.JavaCompat.Equals(global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "java.specification.version")), "1.8")))) {
return;
}
using (global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpeg.jpg"))) {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::SkiaSharp.SKBitmap image = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(@is);
int width = image.Width;
int height = image.Height;
global::SkiaSharp.SKBitmap argbImage = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(width, height, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_4BYTE_ABGR);
global::DripSharp.Runtime.PdfCartonGraphics2D ag = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(argbImage);
ag.DrawImage(image, 0, 0, (object)default!);
ag.Dispose();
for (int x = 0; (x < argbImage.Width); ++x) {
for (int y = 0; (y < argbImage.Height); ++y) {
global::DripSharp.Runtime.PdfCartonFontCompat.SetRgb(argbImage, x, y, ((global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(argbImage, x, y) & 16777215) | (((y / 10) * 10) << unchecked((int)(24)))));
}
}
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromImage(document, argbImage);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, width, height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpg"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.Testing.JavaAssertions.NotNull(ximage.GetSoftMask(), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage.GetSoftMask(), 8, width, height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpg"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.ColorCount(ximage.GetSoftMask().GetImage()) > (image.Height / 10)), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpeg-4bargb.pdf"));
}
}

internal virtual void testCreateFromImageUSHORT_555_RGB() {
if ((global::DripSharp.Runtime.JavaCompat.Equals(global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "java.runtime.name")), "OpenJDK Runtime Environment") && ((global::DripSharp.Runtime.JavaCompat.Equals(global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "java.specification.version")), "1.6") || global::DripSharp.Runtime.JavaCompat.Equals(global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "java.specification.version")), "1.7")) || global::DripSharp.Runtime.JavaCompat.Equals(global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "java.specification.version")), "1.8")))) {
return;
}
using (global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpeg.jpg"))) {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::SkiaSharp.SKBitmap image = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(@is);
int width = image.Width;
int height = image.Height;
global::SkiaSharp.SKBitmap rgbImage = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(width, height, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_RGB);
global::DripSharp.Runtime.PdfCartonGraphics2D ag = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(rgbImage);
ag.DrawImage(image, 0, 0, (object)default!);
ag.Dispose();
for (int x = 0; (x < rgbImage.Width); ++x) {
for (int y = 0; (y < rgbImage.Height); ++y) {
global::DripSharp.Runtime.PdfCartonFontCompat.SetRgb(rgbImage, x, y, ((global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(rgbImage, x, y) & 16777215) | (((y / 10) * 10) << unchecked((int)(24)))));
}
}
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromImage(document, rgbImage);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, width, height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpg"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.Testing.JavaAssertions.Null(ximage.GetSoftMask(), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpeg-ushort555rgb.pdf"));
}
}

internal virtual void testPDFBox5137() {
sbyte[] ba = global::DripSharp.Runtime.JavaCompat.ReadAllBytes(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.PathOf(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/imgs"), "PDFBOX-5196-lotus.jpg")));
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromByteArray(document, ba);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 8, 500, 500, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "jpg"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance.GetName()));
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.doWritePDF(document, ximage, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-5196-lotus.pdf"));
this.checkJpegStream(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactoryTest.TESTRESULTSDIR, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-5196-lotus.pdf"), global::DripSharp.Runtime.JavaCompat.NewMemoryStream(ba));
}

private void checkJpegStream(global::System.IO.FileInfo testResultsDir, string filename, global::System.IO.Stream expected) {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine(testResultsDir.FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename))))) {
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject img = (global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject)(doc.GetPage(0).GetResources().GetXObject(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Im1")))!);
using (global::System.IO.Stream dctStream = img.CreateInputStream(global::DripSharp.Runtime.JavaCompat.AsList<string>(global::DripSharp.PdfCarton.Cos.COSName.DctDecode.GetName()))) {
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(expected), global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(dctStream), null);
}
}
}

[Xunit.Fact]
public void __Upstream_3431998512_9da159e757dc9d14()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateFromImage256();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2423293810_3a7c00d665490343()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateFromImage4BYTE_ABGR();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0101756799_9921befac2c52a89()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateFromImageINT_ARGB();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3432029834_e4e641c2d77d76d1()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateFromImageRGB();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0997929454_83493c0db66d63e4()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateFromImageUSHORT_555_RGB();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0792920728_a63b87bc554ad620()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateFromStream();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3876296891_8f8a34bbc9884d48()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateFromStream256();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4201617300_8a7874bc4f9ea797()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCreateFromStreamCMYK();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1724604203_e62c7c3ef80b73a6()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testPDFBox5137();
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
