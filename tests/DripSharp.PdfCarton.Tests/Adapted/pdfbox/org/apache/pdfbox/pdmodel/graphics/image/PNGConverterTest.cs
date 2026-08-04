// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Graphics.Image;

public class PNGConverterTest {
private static readonly global::System.IO.FileInfo PARENTDIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output/graphics/graphics"));

internal static void setup() {
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverterTest.PARENTDIR);
}

public virtual void DumpChunkTypes() {
string[] chunkTypes = new string[] { "IHDR", "IDAT", "PLTE", "IEND", "tRNS", "cHRM", "gAMA", "iCCP", "sBIT", "sRGB", "tEXt", "zTXt", "iTXt", "kBKG", "hIST", "pHYs", "sPLT", "tIME" };
foreach (string chunkType in chunkTypes) {
sbyte[] bytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes(chunkType, global::System.Text.Encoding.UTF8);
global::DripSharp.Testing.JavaAssertions.Equal(4, bytes.Length, null);
global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.JavaStringFormat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("\tprivate static final int CHUNK_", chunkType), " = 0x%02X%02X%02X%02X; // %s: %d %d %d %d")), ((int)(bytes[0]) & 255), ((int)(bytes[1]) & 255), ((int)(bytes[2]) & 255), ((int)(bytes[3]) & 255), chunkType, ((int)(bytes[0]) & 255), ((int)(bytes[1]) & 255), ((int)(bytes[2]) & 255), ((int)(bytes[3]) & 255))));
}
}

internal virtual void testImageConversionRGB() {
this.checkImageConvert(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png.png"));
}

internal virtual void testImageConversionRGBGamma() {
this.checkImageConvert(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png_rgb_gamma.png"));
}

internal virtual void testImageConversionRGB16BitICC() {
this.checkImageConvert(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png_rgb_romm_16bit.png"));
}

internal virtual void testImageConversionRGBIndexed() {
this.checkImageConvert(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png_indexed.png"));
}

internal virtual void testImageConversionRGBIndexedAlpha1Bit() {
this.checkImageConvert(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png_indexed_1bit_alpha.png"));
}

internal virtual void testImageConversionRGBIndexedAlpha2Bit() {
this.checkImageConvert(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png_indexed_2bit_alpha.png"));
}

internal virtual void testImageConversionRGBIndexedAlpha4Bit() {
this.checkImageConvert(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png_indexed_4bit_alpha.png"));
}

internal virtual void testImageConversionRGBIndexedAlpha8Bit() {
this.checkImageConvert(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png_indexed_8bit_alpha.png"));
}

internal virtual void testImageConversionRGBAlpha() {
this.checkImageConvertFail(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png_alpha_rgb.png"));
}

internal virtual void testImageConversionGrayAlpha() {
this.checkImageConvertFail(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png_alpha_gray.png"));
}

internal virtual void testImageConversionGray() {
this.checkImageConvertFail(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png_gray.png"));
}

internal virtual void testImageConversionGrayGamma() {
this.checkImageConvertFail(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png_gray_with_gama.png"));
}

private void checkImageConvertFail(string name) {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverterTest), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", name))) {
sbyte[] imageBytes = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(@is);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject pdImageXObject = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.convertPNGImage(doc, imageBytes);
global::DripSharp.Testing.JavaAssertions.Null(pdImageXObject, null);
}
}

private void checkImageConvert(string name) {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverterTest), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", name))) {
sbyte[] imageBytes = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(@is);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject pdImageXObject = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.convertPNGImage(doc, imageBytes);
global::DripSharp.Testing.JavaAssertions.NotNull(pdImageXObject, null);
global::DripSharp.Runtime.JavaIccProfile imageProfile = default!;
if ((pdImageXObject.GetColorSpace() is global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDICCBased)) {
global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDICCBased iccColorSpace = (global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDICCBased)(pdImageXObject.GetColorSpace()!);
imageProfile = global::DripSharp.Runtime.PdfCartonFontCompat.GetIccProfile(iccColorSpace.GetPDStream().ToByteArray());
}
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
doc.AddPage(page);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page)) {
contentStream.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Pink);
contentStream.AddRect((float)(0), (float)(0), page.GetCropBox().GetWidth(), page.GetCropBox().GetHeight());
contentStream.Fill();
contentStream.DrawImage(pdImageXObject, (float)(0), (float)(0), (float)(pdImageXObject.GetWidth()), (float)(pdImageXObject.GetHeight()));
}
doc.Save(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverterTest.PARENTDIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(name, ".pdf")))));
global::SkiaSharp.SKBitmap image = pdImageXObject.GetImage();
global::DripSharp.Testing.JavaAssertions.NotNull(pdImageXObject.GetRawRaster(), null);
global::SkiaSharp.SKBitmap expectedImage = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(imageBytes));
if (((imageProfile! != default!) && global::DripSharp.Runtime.PdfCartonFontCompat.GetColorModel(expectedImage).ColorSpace.IsSrgb)) {
expectedImage = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverterTest.GetImageWithProfileData(expectedImage, imageProfile!);
}
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(expectedImage, image);
global::SkiaSharp.SKBitmap rawImage = pdImageXObject.GetRawImage();
if ((rawImage != default!)) {
global::DripSharp.Testing.JavaAssertions.Equal(rawImage.Width, pdImageXObject.GetWidth(), null);
global::DripSharp.Testing.JavaAssertions.Equal(rawImage.Height, pdImageXObject.GetHeight(), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactoryTest.checkIdentRaw(expectedImage, pdImageXObject);
}
}
}

public static global::SkiaSharp.SKBitmap GetImageWithProfileData(global::SkiaSharp.SKBitmap sourceImage, global::DripSharp.Runtime.JavaIccProfile realProfile) {
global::DripSharp.Runtime.JavaHashtable<string, object> properties = new global::DripSharp.Runtime.JavaHashtable<string, object>();
string[] propertyNames = global::System.Array.Empty<string>();
if ((propertyNames != default!)) {
foreach (string propertyName in propertyNames) {
global::DripSharp.Runtime.JavaCompat.MapPut(properties, propertyName, null);
}
}
global::DripSharp.Runtime.JavaColorModel oldColorModel = (global::DripSharp.Runtime.JavaColorModel)(global::DripSharp.Runtime.PdfCartonFontCompat.GetColorModel(sourceImage)!);
bool hasAlpha = oldColorModel.HasAlpha;
int transparency = global::DripSharp.PdfCarton.Tests.Support.ColorModelTransparency(oldColorModel);
bool alphaPremultiplied = false;
global::DripSharp.Runtime.JavaRaster raster = global::DripSharp.Runtime.PdfCartonFontCompat.GetRaster(sourceImage);
int dataType = raster.GetDataBuffer().DataType;
int[] componentSize = global::DripSharp.PdfCarton.Tests.Support.ComponentSizes(oldColorModel);
global::DripSharp.Runtime.JavaColorModel colorModel = new global::DripSharp.Runtime.JavaColorModel(new global::DripSharp.Runtime.JavaIccColorSpace(realProfile), hasAlpha, dataType, componentSize);
return global::DripSharp.Runtime.PdfCartonFontCompat.CreateImage(colorModel, raster, global::DripSharp.PdfCarton.Tests.Support.IsAlphaPremultiplied(sourceImage), properties);
}

internal virtual void testCheckConverterState() {
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.PNGConverterState)default!), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.PNGConverterState state = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.PNGConverterState();
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.Chunk invalidChunk = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.Chunk();
invalidChunk.bytes = new sbyte[0];
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkChunkSane(invalidChunk), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.Chunk validChunk = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.Chunk();
validChunk.bytes = new sbyte[16];
validChunk.start = 4;
validChunk.length = 8;
validChunk.crc = 2077607535;
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkChunkSane(validChunk), null);
state.IHDR = invalidChunk;
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.IDATs = global::DripSharp.Runtime.JavaCompat.ListOf<global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.Chunk>(validChunk);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.IHDR = validChunk;
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.IDATs = new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.Chunk>();
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.IDATs = global::DripSharp.Runtime.JavaCompat.ListOf<global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.Chunk>(validChunk);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.PLTE = invalidChunk;
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.PLTE = validChunk;
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.cHRM = invalidChunk;
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.cHRM = validChunk;
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.tRNS = invalidChunk;
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.tRNS = validChunk;
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.iCCP = invalidChunk;
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.iCCP = validChunk;
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.sRGB = invalidChunk;
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.sRGB = validChunk;
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.gAMA = invalidChunk;
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.gAMA = validChunk;
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
state.IDATs = global::DripSharp.Runtime.JavaCompat.AsList<global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.Chunk>(validChunk, invalidChunk);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkConverterState(state), null);
}

internal virtual void testChunkSane() {
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.Chunk chunk = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.Chunk();
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkChunkSane((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.Chunk)default!), null);
chunk.bytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes("IHDRsomedummyvaluesDummyValuesAtEnd", global::System.Text.Encoding.UTF8);
chunk.length = 19;
global::DripSharp.Testing.JavaAssertions.Equal(35, chunk.bytes.Length, null);
global::DripSharp.Testing.JavaAssertions.Equal("IHDRsomedummyvalues", global::DripSharp.Runtime.JavaCompat.NewString(chunk.getData(), global::System.Text.Encoding.UTF8), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkChunkSane(chunk), null);
chunk.start = 4;
global::DripSharp.Testing.JavaAssertions.Equal("somedummyvaluesDumm", global::DripSharp.Runtime.JavaCompat.NewString(chunk.getData(), global::System.Text.Encoding.UTF8), null);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkChunkSane(chunk), null);
chunk.crc = -1729802258;
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkChunkSane(chunk), null);
chunk.start = 6;
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkChunkSane(chunk), null);
chunk.length = 60;
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.checkChunkSane(chunk), null);
}

internal virtual void testCRCImpl() {
sbyte[] b1 = global::DripSharp.Runtime.JavaCompat.StringGetBytes("Hello World!", global::System.Text.Encoding.UTF8);
global::DripSharp.Testing.JavaAssertions.Equal(472456355, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.crc(b1, 0, b1.Length), null);
global::DripSharp.Testing.JavaAssertions.Equal(-632335482, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.crc(b1, 2, (b1.Length - 4)), null);
}

internal virtual void testMapPNGRenderIntent() {
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Perceptual, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.mapPNGRenderIntent(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.RelativeColorimetric, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.mapPNGRenderIntent(1), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Saturation, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.mapPNGRenderIntent(2), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.AbsoluteColorimetric, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.mapPNGRenderIntent(3), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.mapPNGRenderIntent(-1), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.mapPNGRenderIntent(4), null);
}

internal virtual void testImageConversionIntentIndexed() {
this.checkImageConvert(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "929316.png"));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverterTest), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "929316.png"))) {
sbyte[] imageBytes = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(@is);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject pdImageXObject = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PNGConverter.convertPNGImage(doc, imageBytes);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Perceptual, pdImageXObject.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Intent), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDIndexed indexedColorspace = (global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDIndexed)(pdImageXObject.GetColorSpace()!);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDICCBased iccColorspace = (global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDICCBased)(indexedColorspace.GetBaseColorSpace()!);
global::DripSharp.Runtime.JavaIccProfile rgbProfile = global::DripSharp.Runtime.PdfCartonFontCompat.GetIccProfile(global::DripSharp.Runtime.JavaColorSpace.CS_sRGB);
sbyte[] sRGB_bytes = rgbProfile.GetData();
global::DripSharp.Testing.JavaAssertions.Equal(sRGB_bytes, iccColorspace.GetPDStream().ToByteArray(), null);
}
}

[Xunit.Fact]
public void __Upstream_1835185442_a15c53644bb77887()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCRCImpl();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2994853895_fbd3bb1255bf0e7d()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCheckConverterState();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0550844448_1188407c271f96a2()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testChunkSane();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3956705506_a97516ac8eaffc77()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testImageConversionGray();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2725016988_ab936f493850d64e()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testImageConversionGrayAlpha();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2730227685_7bde87eab1695ddb()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testImageConversionGrayGamma();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0097592086_8ecd9203c0b12e4a()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testImageConversionIntentIndexed();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1651665518_a8d69b17ac66565c()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testImageConversionRGB();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1561822511_75f7fa8786ba43fa()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testImageConversionRGB16BitICC();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4126911376_b865066f2888b6ef()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testImageConversionRGBAlpha();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4132122073_6a7e6354e4f82e7f()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testImageConversionRGBGamma();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0263224995_d4f48d83befca5c9()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testImageConversionRGBIndexed();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2596242967_3d68d64d78fed7d9()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testImageConversionRGBIndexedAlpha1Bit();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2596272758_b842b4f0c7074889()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testImageConversionRGBIndexedAlpha2Bit();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2596332340_19d1aa7915ec0ae2()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testImageConversionRGBIndexedAlpha4Bit();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2596451504_3b621d3db7129fe8()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testImageConversionRGBIndexedAlpha8Bit();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1023563729_986c378992c0ca3d()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testMapPNGRenderIntent();
        }
        finally
        {
        }
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    setup();
    return true;
}
}
