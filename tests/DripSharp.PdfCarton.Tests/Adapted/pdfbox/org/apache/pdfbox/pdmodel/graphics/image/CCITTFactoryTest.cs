// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Graphics.Image;

public class CCITTFactoryTest {
  private static readonly global::System.IO.FileInfo TESTRESULTSDIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/test-output/graphics"));

  internal static void setUp() {
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactoryTest.TESTRESULTSDIR);
  }

  internal virtual void testCreateFromRandomAccessSingle() {
    string tiffG3Path = "src/test/resources/org/apache/pdfbox/pdmodel/graphics/image/ccittg3.tif";
    string tiffG4Path = "src/test/resources/org/apache/pdfbox/pdmodel/graphics/image/ccittg4.tif";
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__81_25
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage3
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory.CreateFromFile(document__81_25,
        global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        tiffG3Path)));
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage3, 1, 344,
        287, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "tiff"),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
      global::SkiaSharp.SKBitmap bim3
        = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        tiffG3Path)));
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(bim3,
        ximage3.GetOpaqueImage((global::SkiaSharp.SKRectI)default!, 1));
      global::DripSharp.PdfCarton.Pdmodel.PDPage page
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
      document__81_25.AddPage(page);
      using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream__89_38
        = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__81_25, page,
        global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false)) {
        contentStream__89_38.DrawImage(ximage3, (float)(0), (float)(0), (float)(ximage3.GetWidth()),
          (float)(ximage3.GetHeight()));
      }
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage4
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory.CreateFromFile(document__81_25,
        global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        tiffG4Path)));
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage4, 1, 344,
        287, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "tiff"),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
      global::SkiaSharp.SKBitmap bim4
        = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        tiffG3Path)));
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(bim4,
        ximage4.GetOpaqueImage((global::SkiaSharp.SKRectI)default!, 1));
      page
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
      document__81_25.AddPage(page);
      using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream__100_38
        = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__81_25, page,
        global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false)) {
        contentStream__100_38.DrawImage(ximage4, (float)(0), (float)(0));
      }
      document__81_25.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactoryTest.TESTRESULTSDIR,
        "/singletiff.pdf")));
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__108_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactoryTest.TESTRESULTSDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "singletiff.pdf"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal(2, document__108_25.GetNumberOfPages(), null);
    }
  }

  internal virtual void testCreateFromRandomAccessMulti() {
    string tiffPath
      = "src/test/resources/org/apache/pdfbox/pdmodel/graphics/image/ccittg4multi.tif";
    using (global::DripSharp.Runtime.JavaImageInputStream @is
      = global::DripSharp.Runtime.PdfCartonImageIO.CreateImageInputStream(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      tiffPath)))) {
      global::DripSharp.Runtime.JavaImageReader imageReader
        = global::DripSharp.PdfCarton.Tests.Support.GetImageReaders(@is).Next()!;
      imageReader.SetInput(@is);
      int countTiffImages = global::DripSharp.PdfCarton.Tests.Support.ImageCount(imageReader);
      global::DripSharp.Testing.JavaAssertions.True((countTiffImages > 1), null);
      using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__129_29
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
        int pdfPageNum = 0;
        while (true) {
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage
            = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory.CreateFromFile(document__129_29,
            global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            tiffPath)), pdfPageNum);
          if ((ximage == default!)) {
            break;
          }
          global::SkiaSharp.SKBitmap bim = imageReader.Read(pdfPageNum, null);
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage, 1,
            bim.Width, bim.Height, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            "tiff"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(bim,
            ximage.GetOpaqueImage((global::SkiaSharp.SKRectI)default!, 1));
          global::DripSharp.PdfCarton.Pdmodel.PDPage page
            = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
          float fX = (ximage.GetWidth() / (float)(page.GetMediaBox().GetWidth()));
          float fY = (ximage.GetHeight() / (float)(page.GetMediaBox().GetHeight()));
          float factor = global::System.Math.Max(fX, fY);
          document__129_29.AddPage(page);
          using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__129_29, page,
            global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false)) {
            contentStream.DrawImage(ximage, (float)(0), (float)(0), (ximage.GetWidth()
              / (float)factor), (ximage.GetHeight() / (float)factor));
          }
          ++pdfPageNum;
        }
        global::DripSharp.Testing.JavaAssertions.Equal(countTiffImages, pdfPageNum, null);
        document__129_29.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactoryTest.TESTRESULTSDIR,
          "/multitiff.pdf")));
      }
      using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__158_29
        = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactoryTest.TESTRESULTSDIR).FullName,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "multitiff.pdf"))),
        (string)default!)) {
        global::DripSharp.Testing.JavaAssertions.Equal(countTiffImages,
          document__158_29.GetNumberOfPages(), null);
      }
      imageReader.Dispose();
    }
  }

  internal virtual void testCreateFromBufferedImage() {
    string tiffG4Path = "src/test/resources/org/apache/pdfbox/pdmodel/graphics/image/ccittg4.tif";
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__171_25
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::SkiaSharp.SKBitmap bim
        = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        tiffG4Path)));
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage3
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory.CreateFromImage(document__171_25,
        bim);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage3, 1, 344,
        287, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "tiff"),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(bim,
        ximage3.GetOpaqueImage((global::SkiaSharp.SKRectI)default!, 1));
      global::DripSharp.PdfCarton.Pdmodel.PDPage page
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
      document__171_25.AddPage(page);
      using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream
        = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__171_25, page,
        global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false)) {
        contentStream.DrawImage(ximage3, (float)(0), (float)(0), (float)(ximage3.GetWidth()),
          (float)(ximage3.GetHeight()));
      }
      document__171_25.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactoryTest.TESTRESULTSDIR,
        "/singletifffrombi.pdf")));
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__188_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactoryTest.TESTRESULTSDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "singletifffrombi.pdf"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal(1, document__188_25.GetNumberOfPages(), null);
    }
  }

  internal virtual void testCreateFromBufferedChessImage() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__197_25
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::SkiaSharp.SKBitmap bim
        = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(343, 287,
        global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_BYTE_BINARY);
      global::DripSharp.Testing.JavaAssertions.NotEqual(((bim.Width / 8) * 8), bim.Width, null);
      int col = 0;
      for (int x = 0; (x < bim.Width); ++x) {
        for (int y = 0; (y < bim.Height); ++y) {
          global::DripSharp.Runtime.PdfCartonFontCompat.SetRgb(bim, x, y, (col & 16777215));
          col = ~col;
        }
      }
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage3
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory.CreateFromImage(document__197_25,
        bim);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage3, 1, 343,
        287, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "tiff"),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(bim,
        ximage3.GetOpaqueImage((global::SkiaSharp.SKRectI)default!, 1));
      global::DripSharp.PdfCarton.Pdmodel.PDPage page
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
      document__197_25.AddPage(page);
      using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream
        = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__197_25, page,
        global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false)) {
        contentStream.DrawImage(ximage3, (float)(0), (float)(0), (float)(ximage3.GetWidth()),
          (float)(ximage3.GetHeight()));
      }
      document__197_25.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactoryTest.TESTRESULTSDIR,
        "/singletifffromchessbi.pdf")));
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__225_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactoryTest.TESTRESULTSDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "singletifffromchessbi.pdf"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal(1, document__225_25.GetNumberOfPages(), null);
    }
  }

  internal virtual void testCreateFromFileLock() {
    string tiffG3Path = "src/test/resources/org/apache/pdfbox/pdmodel/graphics/image/ccittg3.tif";
    global::System.IO.FileInfo copiedTiffFile
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactoryTest.TESTRESULTSDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ccittg3.tif")));
    global::DripSharp.Runtime.JavaCompat.Copy(new global::DripSharp.Runtime.JavaPath(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      tiffG3Path)).FullName), new global::DripSharp.Runtime.JavaPath(copiedTiffFile.FullName),
      new object());
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory.CreateFromFile(document,
        copiedTiffFile);
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.FileDelete(copiedTiffFile),
        null);
    }
  }

  internal virtual void testCreateFromFileNumberLock() {
    string tiffG3Path = "src/test/resources/org/apache/pdfbox/pdmodel/graphics/image/ccittg3.tif";
    global::System.IO.FileInfo copiedTiffFile
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactoryTest.TESTRESULTSDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ccittg3n.tif")));
    global::DripSharp.Runtime.JavaCompat.Copy(new global::DripSharp.Runtime.JavaPath(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      tiffG3Path)).FullName), new global::DripSharp.Runtime.JavaPath(copiedTiffFile.FullName),
      new object());
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory.CreateFromFile(document,
        copiedTiffFile, 0);
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.FileDelete(copiedTiffFile),
        null);
    }
  }

  internal virtual void testByteShortPaddedWithGarbage() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      string basePath
        = "src/test/resources/org/apache/pdfbox/pdmodel/graphics/image/ccittg3-garbage-padded-fields";
      foreach (string ext in global::DripSharp.Runtime.JavaCompat.AsList<string>(".tif",
        "-bigendian.tif")) {
        string tiffPath = global::DripSharp.Runtime.JavaCompat.Concat(basePath, ext);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximage3
          = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory.CreateFromFile(document,
          global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          tiffPath)));
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximage3, 1, 344,
          287, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "tiff"),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
      }
    }
  }

  internal virtual void testFillOrder2() {
    sbyte[] ba;
    using (global::System.IO.Stream @is
      = global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "https://issues.apache.org/jira/secure/attachment/12558110/Wing.tif")))) {
      ba = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(@is);
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__301_25
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject ximg
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory.CreateFromByteArray(document__301_25,
        ba);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.Validate(ximg, 1, 4575,
        2232, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "tiff"),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceGray.Instance.GetName()));
      global::SkiaSharp.SKBitmap bim
        = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(ba));
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(bim,
        ximg.GetOpaqueImage((global::SkiaSharp.SKRectI)default!, 1));
      global::DripSharp.PdfCarton.Pdmodel.PDPage page
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
      document__301_25.AddPage(page);
      using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream
        = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__301_25, page,
        global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false)) {
        contentStream.DrawImage(ximg, (float)(0), (float)(0), (float)((ximg.GetWidth() / 8)),
          (float)((ximg.GetHeight() / 8)));
      }
      document__301_25.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactoryTest.TESTRESULTSDIR,
        "/Wing.pdf")));
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__316_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactoryTest.TESTRESULTSDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Wing.pdf"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal(1, document__316_25.GetNumberOfPages(), null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_0572429341_1a918159080b6c24() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testByteShortPaddedWithGarbage();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0634069906_995902b8f541e403() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testCreateFromBufferedChessImage();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0807533988_483fe0cd55761e44() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testCreateFromBufferedImage();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3555876319_6bf012f34ea5d4d7() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testCreateFromFileLock();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2519435720_38df7086024016f3() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testCreateFromFileNumberLock();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2246514522_a3755f696ba6fb9f() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testCreateFromRandomAccessMulti();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1083213383_c246e3748e1133a7() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testCreateFromRandomAccessSingle();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0740943929_bf61196617e2b3dc() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testFillOrder2();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

  private static bool __RunUpstreamBeforeAll() {
    setUp();
    return true;
  }
}
