// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Graphics.Image;

public class PDImageXObjectTest {
  internal virtual void testCreateFromFileByExtension() {
    this.testCompareCreatedFileByExtensionWithCreatedByCCITTFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "ccittg4.tif"));
    this.testCompareCreatedFileByExtensionWithCreatedByJPEGFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "jpeg.jpg"));
    this.testCompareCreatedFileByExtensionWithCreatedByJPEGFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "jpegcmyk.jpg"));
    this.testCompareCreatedFileByExtensionWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "gif.gif"));
    this.testCompareCreatedFileByExtensionWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "gif-1bit-transparent.gif"));
    this.testCompareCreatedFileByExtensionWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "png_indexed_8bit_alpha.png"));
    this.testCompareCreatedFileByExtensionWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "png.png"));
    this.testCompareCreatedFileByExtensionWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "lzw.tif"));
  }

  internal virtual void testCreateFromFile() {
    this.testCompareCreatedFileWithCreatedByCCITTFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "ccittg4.tif"));
    this.testCompareCreatedFileWithCreatedByJPEGFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "jpeg.jpg"));
    this.testCompareCreatedFileWithCreatedByJPEGFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "jpegcmyk.jpg"));
    this.testCompareCreatedFileWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "gif.gif"));
    this.testCompareCreatedFileWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "gif-1bit-transparent.gif"));
    this.testCompareCreatedFileWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "png_indexed_8bit_alpha.png"));
    this.testCompareCreatedFileWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "png.png"));
    this.testCompareCreatedFileWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "lzw.tif"));
  }

  internal virtual void testCreateFromFileByContent() {
    this.testCompareCreateByContentWithCreatedByCCITTFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "ccittg4.tif"));
    this.testCompareCreatedByContentWithCreatedByJPEGFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "jpeg.jpg"));
    this.testCompareCreatedByContentWithCreatedByJPEGFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "jpegcmyk.jpg"));
    this.testCompareCreatedByContentWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "gif.gif"));
    this.testCompareCreatedByContentWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "gif-1bit-transparent.gif"));
    this.testCompareCreatedByContentWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "png_indexed_8bit_alpha.png"));
    this.testCompareCreatedByContentWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "png.png"));
    this.testCompareCreatedByContentWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "lzw.tif"));
  }

  internal virtual void testCreateFromByteArray() {
    this.testCompareCreatedFromByteArrayWithCreatedByCCITTFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "ccittg4.tif"));
    this.testCompareCreatedFromByteArrayWithCreatedByJPEGFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "jpeg.jpg"));
    this.testCompareCreatedFromByteArrayWithCreatedByJPEGFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "jpegcmyk.jpg"));
    this.testCompareCreatedFromByteArrayWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "gif.gif"));
    this.testCompareCreatedFromByteArrayWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "gif-1bit-transparent.gif"));
    this.testCompareCreatedFromByteArrayWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "png_indexed_8bit_alpha.png"));
    this.testCompareCreatedFromByteArrayWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "png.png"));
    this.testCompareCreatedFromByteArrayWithCreatedByLosslessFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "lzw.tif"));
  }

  internal virtual void testCreateFromByteArrayWithCustomFactory() {
    this.testCompareCreatedFromByteArrayWithCreatedByCustomFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "gif.gif"));
    this.testCompareCreatedFromByteArrayWithCreatedByCustomFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "gif-1bit-transparent.gif"));
    this.testCompareCreatedFromByteArrayWithCreatedByCustomFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "lzw.tif"));
  }

  private void testCompareCreatedFileByExtensionWithCreatedByLosslessFactory(string filename) {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename))) {
      global::System.IO.FileInfo file
        = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromFileByExtension(file,
        doc);
      global::SkiaSharp.SKBitmap bim = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(@is);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(doc,
        bim);
      global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
        null);
      this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
    }
  }

  private void testCompareCreatedFileByExtensionWithCreatedByCCITTFactory(string filename) {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::System.IO.FileInfo file
        = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromFileByExtension(file,
        doc);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory.CreateFromFile(doc, file);
      global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
        null);
      this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
    }
  }

  private void testCompareCreatedFileByExtensionWithCreatedByJPEGFactory(string filename) {
    global::System.IO.FileInfo file
      = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::System.IO.Stream @is
      = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file)) {
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromFileByExtension(file,
        doc);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromStream(doc, @is);
      global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
        null);
      this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
    }
  }

  private void testCompareCreatedFileWithCreatedByLosslessFactory(string filename) {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename))) {
      global::System.IO.FileInfo file
        = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        file.FullName), doc);
      global::SkiaSharp.SKBitmap bim = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(@is);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(doc,
        bim);
      global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
        null);
      this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
    }
  }

  private void testCompareCreatedFileWithCreatedByCCITTFactory(string filename) {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::System.IO.FileInfo file
        = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        file.FullName), doc);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory.CreateFromFile(doc, file);
      global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
        null);
      this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
    }
  }

  private void testCompareCreatedFileWithCreatedByJPEGFactory(string filename) {
    global::System.IO.FileInfo file
      = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::System.IO.Stream @is
      = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file)) {
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        file.FullName), doc);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromStream(doc, @is);
      global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
        null);
      this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
    }
  }

  private void testCompareCreatedByContentWithCreatedByLosslessFactory(string filename) {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename))) {
      global::System.IO.FileInfo file
        = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromFileByContent(file,
        doc);
      global::SkiaSharp.SKBitmap bim = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(@is);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(doc,
        bim);
      global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
        null);
      this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
    }
  }

  private void testCompareCreateByContentWithCreatedByCCITTFactory(string filename) {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::System.IO.FileInfo file
        = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromFileByContent(file,
        doc);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory.CreateFromFile(doc, file);
      global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
        null);
      this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
    }
  }

  private void testCompareCreatedByContentWithCreatedByJPEGFactory(string filename) {
    global::System.IO.FileInfo file
      = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::System.IO.Stream @is
      = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file)) {
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromFileByContent(file,
        doc);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromStream(doc, @is);
      global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
        null);
      this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
    }
  }

  private void testCompareCreatedFromByteArrayWithCreatedByLosslessFactory(string filename) {
    global::System.IO.FileInfo file
      = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::System.IO.Stream is1
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      filename))) using (global::System.IO.Stream is2
      = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file)) {
      sbyte[] byteArray = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(is2);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromByteArray(doc,
        byteArray, (string)default!);
      global::SkiaSharp.SKBitmap bim = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(is1);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(doc,
        bim);
      global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
        null);
      this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
    }
  }

  private void testCompareCreatedFromByteArrayWithCreatedByCCITTFactory(string filename) {
    global::System.IO.FileInfo file
      = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::System.IO.Stream @is
      = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file)) {
      sbyte[] byteArray = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(@is);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromByteArray(doc,
        byteArray, (string)default!);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory.CreateFromFile(doc, file);
      global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
        null);
      this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
    }
  }

  private void testCompareCreatedFromByteArrayWithCreatedByJPEGFactory(string filename) {
    global::System.IO.FileInfo file
      = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::System.IO.Stream is1
      = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file)) using (global::System.IO.Stream is2
      = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file)) {
      sbyte[] byteArray = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(is1);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromByteArray(doc,
        byteArray, (string)default!);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromStream(doc, is2);
      global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
        null);
      this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
    }
  }

  private void testCompareCreatedFromByteArrayWithCreatedByCustomFactory(string filename) {
    global::System.IO.FileInfo file
      = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::System.IO.Stream @is
      = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file)) {
      sbyte[] byteArray = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(@is);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CustomFactory customFactory
        = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.__CustomFactoryFunctionalAdapter(this.alphaFlattenedJPEGFactory);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
        = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromByteArray(doc,
        byteArray, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename),
        customFactory);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
        = this.alphaFlattenedJPEGFactory(doc, byteArray);
      global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
        null);
      this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
    }
  }

  private void checkIdentARGB(global::SkiaSharp.SKBitmap expectedImage,
    global::SkiaSharp.SKBitmap actualImage) {
    string errMsg = "";
    int w = expectedImage.Width;
    int h = expectedImage.Height;
    global::DripSharp.Testing.JavaAssertions.Equal(w, actualImage.Width, null);
    global::DripSharp.Testing.JavaAssertions.Equal(h, actualImage.Height, null);
    for (int y = 0; (y < h); ++y) {
      for (int x = 0; (x < w); ++x) {
        if ((global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(expectedImage, x, y)
          != global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(actualImage, x, y))) {
          errMsg
            = global::DripSharp.Runtime.JavaCompat.JavaStringFormat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            "(%d,%d) %06X != %06X"), x, y,
            global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(expectedImage, x, y),
            global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(actualImage, x, y));
        }
        global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(expectedImage,
          x, y), global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(actualImage, x, y),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", errMsg));
      }
    }
  }

  private global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject alphaFlattenedJPEGFactory(global::DripSharp.PdfCarton.Pdmodel.PDDocument document,
    sbyte[] byteArray) {
    global::System.IO.MemoryStream bais
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(byteArray);
    global::SkiaSharp.SKBitmap bim = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(bais);
    if (global::DripSharp.PdfCarton.Tests.Support.IsAlphaPremultiplied(bim)) {
      global::DripSharp.Runtime.JavaColorModel colorModel
        = global::DripSharp.Runtime.PdfCartonFontCompat.GetColorModel(bim);
      global::DripSharp.Runtime.JavaRaster raster
        = global::DripSharp.PdfCarton.Tests.Support.CopyImageData(bim,
        (global::DripSharp.Runtime.JavaRaster)default!);
      bim = global::DripSharp.Runtime.PdfCartonFontCompat.CreateImage(colorModel, raster, false,
        (global::DripSharp.Runtime.JavaHashtable<object, object>)default!);
    }
    global::SkiaSharp.SKBitmap flattened
      = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(bim.Width, bim.Height,
      global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_RGB);
    global::DripSharp.Runtime.PdfCartonGraphics2D g
      = global::DripSharp.Runtime.PdfCartonFontCompat.CreateGraphics(flattened);
    g.SetComposite(global::DripSharp.Runtime.JavaAlphaComposite.GetInstance(global::DripSharp.Runtime.JavaAlphaComposite.SRC_OVER,
      1f));
    g.SetColor(global::DripSharp.Runtime.JavaColor.White);
    g.FillRect(0, 0, flattened.Width, flattened.Height);
    g.DrawImage(bim, 0, 0, (object)default!);
    g.Dispose();
    return global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromImage(document,
      flattened);
  }

  [Xunit.Fact]
  public void __Upstream_2113068057_a7a5fa15a4429c2c() {
    try {
      this.testCreateFromByteArray();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0136517146_c9f83d829632aab8() {
    try {
      this.testCreateFromByteArrayWithCustomFactory();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0572493460_b323f1a5fc8526da() {
    try {
      this.testCreateFromFile();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3069720558_4bda8b8f5f50d7fe() {
    try {
      this.testCreateFromFileByContent();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3448444532_463c31aa5f3b341b() {
    try {
      this.testCreateFromFileByExtension();
    } finally {
    }
  }
}
