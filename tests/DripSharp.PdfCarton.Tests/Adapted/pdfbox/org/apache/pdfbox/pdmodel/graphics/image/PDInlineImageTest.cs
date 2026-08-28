// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Graphics.Image;

public class PDInlineImageTest {
  private static readonly global::System.IO.FileInfo TESTRESULTSDIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/test-output/graphics"));

  internal static void setUp() {
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImageTest.TESTRESULTSDIR);
  }

  internal virtual void testInlineImage() {
    global::DripSharp.PdfCarton.Cos.COSDictionary dict
      = new global::DripSharp.PdfCarton.Cos.COSDictionary();
    dict.SetBoolean(global::DripSharp.PdfCarton.Cos.COSName.Im, true);
    int width = 31;
    int height = 27;
    dict.SetInt(global::DripSharp.PdfCarton.Cos.COSName.W, width);
    dict.SetInt(global::DripSharp.PdfCarton.Cos.COSName.H, height);
    dict.SetInt(global::DripSharp.PdfCarton.Cos.COSName.Bpc, 1);
    int rowbytes = (width / 8);
    if (((rowbytes * 8) < width)) {
      ++rowbytes;
    }
    int datalen = (rowbytes * height);
    sbyte[] data = new sbyte[datalen];
    for (int i = 0; (i < datalen); ++i) {
      data[i] = unchecked((sbyte)(((((i / 4) % 2) == 0)
        ? unchecked((sbyte)(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "10101010"), 2))) : 0)));
    }
    global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImage inlineImage1
      = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImage(dict, data,
      (global::DripSharp.PdfCarton.Pdmodel.PDResources)default!);
    global::DripSharp.Testing.JavaAssertions.True(inlineImage1.IsStencil(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(width, inlineImage1.GetWidth(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(height, inlineImage1.GetHeight(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(1, inlineImage1.GetBitsPerComponent(), null);
    global::DripSharp.PdfCarton.Cos.COSDictionary dict2
      = new global::DripSharp.PdfCarton.Cos.COSDictionary();
    dict2.AddAll(dict);
    global::DripSharp.PdfCarton.Cos.COSArray decodeArray
      = new global::DripSharp.PdfCarton.Cos.COSArray();
    decodeArray.Add(global::DripSharp.PdfCarton.Cos.COSInteger.One);
    decodeArray.Add(global::DripSharp.PdfCarton.Cos.COSInteger.Zero);
    dict2.SetItem(global::DripSharp.PdfCarton.Cos.COSName.Decode, decodeArray);
    global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImage inlineImage2
      = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImage(dict2, data,
      (global::DripSharp.PdfCarton.Pdmodel.PDResources)default!);
    global::DripSharp.Runtime.JavaPaint paint
      = global::DripSharp.Runtime.PdfCartonFontCompat.ColorFromComponents(0, 0, 0);
    global::SkiaSharp.SKBitmap stencilImage = inlineImage1.GetStencilImage(paint);
    global::DripSharp.Testing.JavaAssertions.Equal(width, stencilImage.Width, null);
    global::DripSharp.Testing.JavaAssertions.Equal(height, stencilImage.Height, null);
    global::SkiaSharp.SKBitmap stencilImage2 = inlineImage2.GetStencilImage(paint);
    global::DripSharp.Testing.JavaAssertions.Equal(width, stencilImage2.Width, null);
    global::DripSharp.Testing.JavaAssertions.Equal(height, stencilImage2.Height, null);
    global::SkiaSharp.SKBitmap image1 = inlineImage1.GetImage();
    global::DripSharp.Testing.JavaAssertions.Equal(width, image1.Width, null);
    global::DripSharp.Testing.JavaAssertions.Equal(height, image1.Height, null);
    global::SkiaSharp.SKBitmap image2 = inlineImage2.GetImage();
    global::DripSharp.Testing.JavaAssertions.Equal(width, image2.Width, null);
    global::DripSharp.Testing.JavaAssertions.Equal(height, image2.Height, null);
    bool writeOk = global::DripSharp.PdfCarton.Tests.Support.WriteImage(image1,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"),
      global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImageTest.TESTRESULTSDIR,
      "/inline-grid1.png"))));
    global::DripSharp.Testing.JavaAssertions.True(writeOk, null);
    global::SkiaSharp.SKBitmap bim1
      = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImageTest.TESTRESULTSDIR,
      "/inline-grid1.png"))));
    global::DripSharp.Testing.JavaAssertions.NotNull(bim1, null);
    global::DripSharp.Testing.JavaAssertions.Equal(width, bim1.Width, null);
    global::DripSharp.Testing.JavaAssertions.Equal(height, bim1.Height, null);
    writeOk = global::DripSharp.PdfCarton.Tests.Support.WriteImage(image2,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"),
      global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImageTest.TESTRESULTSDIR,
      "/inline-grid2.png"))));
    global::DripSharp.Testing.JavaAssertions.True(writeOk, null);
    global::SkiaSharp.SKBitmap bim2
      = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImageTest.TESTRESULTSDIR,
      "/inline-grid2.png"))));
    global::DripSharp.Testing.JavaAssertions.NotNull(bim2, null);
    global::DripSharp.Testing.JavaAssertions.Equal(width, bim2.Width, null);
    global::DripSharp.Testing.JavaAssertions.Equal(height, bim2.Height, null);
    for (int x__140_18 = 0; (x__140_18 < width); ++x__140_18) {
      for (int y__142_22 = 0; (y__142_22 < height); ++y__142_22) {
        if ((((x__140_18 % 2) == 0) && ((y__142_22 % 2) == 0))) {
          global::DripSharp.Testing.JavaAssertions.Equal(16777215,
            (global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(bim1, x__140_18,
            y__142_22) & 16777215), null);
        } else {
          global::DripSharp.Testing.JavaAssertions.Equal(0,
            (global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(bim1, x__140_18,
            y__142_22) & 16777215), null);
        }
      }
    }
    for (int x__156_18 = 0; (x__156_18 < width); ++x__156_18) {
      for (int y__158_22 = 0; (y__158_22 < height); ++y__158_22) {
        if ((((x__156_18 % 2) == 0) && ((y__158_22 % 2) == 0))) {
          global::DripSharp.Testing.JavaAssertions.Equal(0,
            (global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(bim2, x__156_18,
            y__158_22) & 16777215), null);
        } else {
          global::DripSharp.Testing.JavaAssertions.Equal(16777215,
            (global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(bim2, x__156_18,
            y__158_22) & 16777215), null);
        }
      }
    }
    global::System.IO.FileInfo pdfFile
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImageTest.TESTRESULTSDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "inline.pdf")));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__173_25
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.PDPage page
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
      document__173_25.AddPage(page);
      using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream
        = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__173_25, page,
        global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false)) {
        contentStream.DrawImage(inlineImage1, (float)(150), (float)(400));
        contentStream.DrawImage(inlineImage1, (float)(150), (float)(500),
          (float)((inlineImage1.GetWidth() * 2)), (float)((inlineImage1.GetHeight() * 2)));
        contentStream.DrawImage(inlineImage1, (float)(150), (float)(600),
          (float)((inlineImage1.GetWidth() * 4)), (float)((inlineImage1.GetHeight() * 4)));
        contentStream.DrawImage(inlineImage2, (float)(350), (float)(400));
        contentStream.DrawImage(inlineImage2, (float)(350), (float)(500),
          (float)((inlineImage2.GetWidth() * 2)), (float)((inlineImage2.GetHeight() * 2)));
        contentStream.DrawImage(inlineImage2, (float)(350), (float)(600),
          (float)((inlineImage2.GetWidth() * 4)), (float)((inlineImage2.GetHeight() * 4)));
      }
      document__173_25.Save(pdfFile);
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__189_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfFile)) {
      new global::DripSharp.PdfCarton.Rendering.PDFRenderer(document__189_25).RenderImage(0);
    }
  }

  internal virtual void testShortCCITT1() {
    sbyte[] ba = new sbyte[] { unchecked((sbyte)(8)), unchecked((sbyte)(16)),
      unchecked((sbyte)(32)), unchecked((sbyte)(64)), unchecked((sbyte)(129)),
      unchecked((sbyte)(2)), unchecked((sbyte)(4)), unchecked((sbyte)(8)), unchecked((sbyte)(16)),
      unchecked((sbyte)(0)), unchecked((sbyte)(64)), unchecked((sbyte)(4)), unchecked((sbyte)(0)),
      unchecked((sbyte)(64)), unchecked((sbyte)(4)), unchecked((sbyte)(0)), unchecked((sbyte)(64)),
      unchecked((sbyte)(4)) };
    this.doInlineCcittImage(23, 10, ba);
  }

  internal virtual void testShortCCITT2() {
    sbyte[] ba = new sbyte[] { unchecked((sbyte)(8)), unchecked((sbyte)(16)),
      unchecked((sbyte)(32)), unchecked((sbyte)(64)), unchecked((sbyte)(129)),
      unchecked((sbyte)(2)), unchecked((sbyte)(0)), unchecked((sbyte)(8)), unchecked((sbyte)(0)),
      unchecked((sbyte)(128)), unchecked((sbyte)(8)), unchecked((sbyte)(8)),
      unchecked((sbyte)(128)), unchecked((sbyte)(8)), unchecked((sbyte)(0)),
      unchecked((sbyte)(128)) };
    this.doInlineCcittImage(23, 7, ba);
  }

  internal virtual void testShortCCITT3() {
    sbyte[] ba = new sbyte[] { unchecked((sbyte)(103)), unchecked((sbyte)(44)),
      unchecked((sbyte)(103)), unchecked((sbyte)(44)), unchecked((sbyte)(103)),
      unchecked((sbyte)(44)), unchecked((sbyte)(103)), unchecked((sbyte)(44)),
      unchecked((sbyte)(0)), unchecked((sbyte)(16)), unchecked((sbyte)(1)), unchecked((sbyte)(0)),
      unchecked((sbyte)(16)), unchecked((sbyte)(1)), unchecked((sbyte)(0)), unchecked((sbyte)(16)),
      unchecked((sbyte)(1)), unchecked((sbyte)(10)) };
    this.doInlineCcittImage(683, 4, ba);
  }

  private void doInlineCcittImage(int width, int height, sbyte[] ba) {
    global::DripSharp.PdfCarton.Cos.COSDictionary dict
      = new global::DripSharp.PdfCarton.Cos.COSDictionary();
    dict.SetInt(global::DripSharp.PdfCarton.Cos.COSName.W, width);
    dict.SetInt(global::DripSharp.PdfCarton.Cos.COSName.H, height);
    dict.SetInt(global::DripSharp.PdfCarton.Cos.COSName.Bpc, 1);
    global::DripSharp.PdfCarton.Cos.COSArray array = new global::DripSharp.PdfCarton.Cos.COSArray();
    array.Add(global::DripSharp.PdfCarton.Cos.COSInteger.One);
    array.Add(global::DripSharp.PdfCarton.Cos.COSInteger.Zero);
    dict.SetItem(global::DripSharp.PdfCarton.Cos.COSName.D, array);
    dict.SetBoolean(global::DripSharp.PdfCarton.Cos.COSName.Im, true);
    dict.SetItem(global::DripSharp.PdfCarton.Cos.COSName.F,
      global::DripSharp.PdfCarton.Cos.COSName.CcittfaxDecodeAbbreviation);
    global::DripSharp.PdfCarton.Cos.COSDictionary dict2
      = new global::DripSharp.PdfCarton.Cos.COSDictionary();
    dict2.SetInt(global::DripSharp.PdfCarton.Cos.COSName.Columns,
      dict.GetInt(global::DripSharp.PdfCarton.Cos.COSName.W));
    dict.SetItem(global::DripSharp.PdfCarton.Cos.COSName.Dp, dict2);
    global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImage inlineImage
      = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImage(dict, ba,
      (global::DripSharp.PdfCarton.Pdmodel.PDResources)default!);
    global::DripSharp.Testing.JavaAssertions.Equal(true, inlineImage.IsStencil(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(false, inlineImage.IsEmpty(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(false, inlineImage.GetInterpolate(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(dict, inlineImage.GetCOSObject(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance,
      inlineImage.GetColorSpace(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(1, inlineImage.GetBitsPerComponent(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("tiff", inlineImage.GetSuffix(), null);
    global::SkiaSharp.SKBitmap bim = inlineImage.GetImage();
    global::DripSharp.Testing.JavaAssertions.Equal(width, bim.Width, null);
    global::DripSharp.Testing.JavaAssertions.Equal(height, bim.Height, null);
    global::DripSharp.Testing.JavaAssertions.Equal(inlineImage.GetWidth(), bim.Width, null);
    global::DripSharp.Testing.JavaAssertions.Equal(inlineImage.GetHeight(), bim.Height, null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_BYTE_GRAY,
      global::DripSharp.Runtime.PdfCartonFontCompat.GetImageType(bim), null);
    global::DripSharp.Runtime.JavaDataBufferByte dbb
      = (global::DripSharp.Runtime.JavaDataBufferByte)(global::DripSharp.Runtime.PdfCartonFontCompat.GetRaster(bim).GetDataBuffer()!);
    global::DripSharp.Testing.JavaAssertions.Equal((bim.Width * bim.Height), dbb.Size, null);
    sbyte[] data = dbb.GetData();
    for (int i = 0; (i < data.Length); ++i) {
      global::DripSharp.Testing.JavaAssertions.Equal(0, (int)(data[i]), null);
    }
  }

  internal virtual void testGetDecodeWithInvalidType() {
    global::DripSharp.PdfCarton.Cos.COSDictionary dict
      = new global::DripSharp.PdfCarton.Cos.COSDictionary();
    dict.SetBoolean(global::DripSharp.PdfCarton.Cos.COSName.Im, true);
    dict.SetInt(global::DripSharp.PdfCarton.Cos.COSName.W, 1);
    dict.SetInt(global::DripSharp.PdfCarton.Cos.COSName.H, 1);
    dict.SetInt(global::DripSharp.PdfCarton.Cos.COSName.Bpc, 1);
    dict.SetInt(global::DripSharp.PdfCarton.Cos.COSName.D, 123);
    sbyte[] data = new sbyte[] { unchecked((sbyte)(0)) };
    global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImage inlineImage
      = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImage(dict, data,
      (global::DripSharp.PdfCarton.Pdmodel.PDResources)default!);
    global::DripSharp.Testing.JavaAssertions.Null(inlineImage.GetDecode(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "getDecode() should return null for non-array /D value"));
    global::DripSharp.PdfCarton.Cos.COSDictionary dict2
      = new global::DripSharp.PdfCarton.Cos.COSDictionary();
    dict2.SetBoolean(global::DripSharp.PdfCarton.Cos.COSName.Im, true);
    dict2.SetInt(global::DripSharp.PdfCarton.Cos.COSName.W, 1);
    dict2.SetInt(global::DripSharp.PdfCarton.Cos.COSName.H, 1);
    dict2.SetInt(global::DripSharp.PdfCarton.Cos.COSName.Bpc, 1);
    global::DripSharp.PdfCarton.Cos.COSArray decodeArray
      = new global::DripSharp.PdfCarton.Cos.COSArray();
    decodeArray.Add(global::DripSharp.PdfCarton.Cos.COSInteger.One);
    decodeArray.Add(global::DripSharp.PdfCarton.Cos.COSInteger.Zero);
    dict2.SetItem(global::DripSharp.PdfCarton.Cos.COSName.D, decodeArray);
    global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImage inlineImage2
      = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImage(dict2, data,
      (global::DripSharp.PdfCarton.Pdmodel.PDResources)default!);
    global::DripSharp.Testing.JavaAssertions.NotNull(inlineImage2.GetDecode(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "getDecode() should return array for valid /D value"));
    global::DripSharp.Testing.JavaAssertions.Equal(2, inlineImage2.GetDecode().Size(), null);
    global::DripSharp.PdfCarton.Cos.COSDictionary dict3
      = new global::DripSharp.PdfCarton.Cos.COSDictionary();
    dict3.SetBoolean(global::DripSharp.PdfCarton.Cos.COSName.Im, true);
    dict3.SetInt(global::DripSharp.PdfCarton.Cos.COSName.W, 1);
    dict3.SetInt(global::DripSharp.PdfCarton.Cos.COSName.H, 1);
    dict3.SetInt(global::DripSharp.PdfCarton.Cos.COSName.Bpc, 1);
    global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImage inlineImage3
      = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImage(dict3, data,
      (global::DripSharp.PdfCarton.Pdmodel.PDResources)default!);
    global::DripSharp.Testing.JavaAssertions.Null(inlineImage3.GetDecode(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "getDecode() should return null when /D is not set"));
  }

  [Xunit.Fact]
  public void __Upstream_2701292121_2d1dba1ceccccd6c() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testGetDecodeWithInvalidType();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4123394640_d94a1c9e7d3f221a() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testInlineImage();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1940895922_4bcf937853fb99bc() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testShortCCITT1();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1940895923_00255b1a3ffe4d7a() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testShortCCITT2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1940895924_7e96819c067b281b() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testShortCCITT3();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

  private static bool __RunUpstreamBeforeAll() {
    setUp();
    return true;
  }
}
