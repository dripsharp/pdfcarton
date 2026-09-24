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

  private void testCompareCreatedFileByExtensionWithCreatedByLosslessFactory(string filename) { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_150_25_0 = null!;
      try {
        global::System.IO.Stream @is
          = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename));
        global::System.Exception __dripsharpPrimary_151_26_0 = null!;
        try {
          global::DripSharp.Runtime.JavaFile file
            = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
            global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
            = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject>(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject),
            "CreateFromFileByExtension",
            new global::System.Type[] { typeof(global::System.IO.FileInfo),
              typeof(global::DripSharp.PdfCarton.Pdmodel.PDDocument) },
            new object[] { (global::DripSharp.Runtime.JavaFile)file,
              (global::DripSharp.PdfCarton.Pdmodel.PDDocument)doc });
          global::SkiaSharp.SKBitmap bim
            = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(@is);
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
            = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(doc,
            bim);
          global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(),
            image.GetSuffix(), null);
          this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
        } catch (global::System.Exception __dripsharpCaught_151_26_0) {
          __dripsharpPrimary_151_26_0 = __dripsharpCaught_151_26_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_151_26_0);
        }
      } catch (global::System.Exception __dripsharpCaught_150_25_0) {
        __dripsharpPrimary_150_25_0 = __dripsharpCaught_150_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_150_25_0);
      }
    }
  }

  private void testCompareCreatedFileByExtensionWithCreatedByCCITTFactory(string filename) { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_167_25_0 = null!;
      try {
        global::DripSharp.Runtime.JavaFile file
          = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
          = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject>(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject),
          "CreateFromFileByExtension",
          new global::System.Type[] { typeof(global::System.IO.FileInfo),
            typeof(global::DripSharp.PdfCarton.Pdmodel.PDDocument) },
          new object[] { (global::DripSharp.Runtime.JavaFile)file,
            (global::DripSharp.PdfCarton.Pdmodel.PDDocument)doc });
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
          = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject>(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory),
          "CreateFromFile",
          new global::System.Type[] { typeof(global::DripSharp.PdfCarton.Pdmodel.PDDocument),
            typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.PdfCarton.Pdmodel.PDDocument)doc,
            (global::DripSharp.Runtime.JavaFile)file });
        global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
          null);
        this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
      } catch (global::System.Exception __dripsharpCaught_167_25_0) {
        __dripsharpPrimary_167_25_0 = __dripsharpCaught_167_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_167_25_0);
      }
    }
  }

  private void testCompareCreatedFileByExtensionWithCreatedByJPEGFactory(string filename) {
    global::DripSharp.Runtime.JavaFile file
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename))); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_183_25_0 = null!;
      try {
        global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file);
        global::System.Exception __dripsharpPrimary_184_26_0 = null!;
        try {
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
            = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject>(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject),
            "CreateFromFileByExtension",
            new global::System.Type[] { typeof(global::System.IO.FileInfo),
              typeof(global::DripSharp.PdfCarton.Pdmodel.PDDocument) },
            new object[] { (global::DripSharp.Runtime.JavaFile)file,
              (global::DripSharp.PdfCarton.Pdmodel.PDDocument)doc });
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
            = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromStream(doc,
            @is);
          global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(),
            image.GetSuffix(), null);
          this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
        } catch (global::System.Exception __dripsharpCaught_184_26_0) {
          __dripsharpPrimary_184_26_0 = __dripsharpCaught_184_26_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_184_26_0);
        }
      } catch (global::System.Exception __dripsharpCaught_183_25_0) {
        __dripsharpPrimary_183_25_0 = __dripsharpCaught_183_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_183_25_0);
      }
    }
  }

  private void testCompareCreatedFileWithCreatedByLosslessFactory(string filename) { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_198_25_0 = null!;
      try {
        global::System.IO.Stream @is
          = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename));
        global::System.Exception __dripsharpPrimary_199_26_0 = null!;
        try {
          global::DripSharp.Runtime.JavaFile file
            = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
            global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
            = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(file)), doc);
          global::SkiaSharp.SKBitmap bim
            = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(@is);
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
            = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(doc,
            bim);
          global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(),
            image.GetSuffix(), null);
          this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
        } catch (global::System.Exception __dripsharpCaught_199_26_0) {
          __dripsharpPrimary_199_26_0 = __dripsharpCaught_199_26_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_199_26_0);
        }
      } catch (global::System.Exception __dripsharpCaught_198_25_0) {
        __dripsharpPrimary_198_25_0 = __dripsharpCaught_198_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_198_25_0);
      }
    }
  }

  private void testCompareCreatedFileWithCreatedByCCITTFactory(string filename) { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_215_25_0 = null!;
      try {
        global::DripSharp.Runtime.JavaFile file
          = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
          = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(file)), doc);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
          = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject>(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory),
          "CreateFromFile",
          new global::System.Type[] { typeof(global::DripSharp.PdfCarton.Pdmodel.PDDocument),
            typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.PdfCarton.Pdmodel.PDDocument)doc,
            (global::DripSharp.Runtime.JavaFile)file });
        global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
          null);
        this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
      } catch (global::System.Exception __dripsharpCaught_215_25_0) {
        __dripsharpPrimary_215_25_0 = __dripsharpCaught_215_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_215_25_0);
      }
    }
  }

  private void testCompareCreatedFileWithCreatedByJPEGFactory(string filename) {
    global::DripSharp.Runtime.JavaFile file
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename))); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_231_25_0 = null!;
      try {
        global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file);
        global::System.Exception __dripsharpPrimary_232_26_0 = null!;
        try {
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
            = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(file)), doc);
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
            = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromStream(doc,
            @is);
          global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(),
            image.GetSuffix(), null);
          this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
        } catch (global::System.Exception __dripsharpCaught_232_26_0) {
          __dripsharpPrimary_232_26_0 = __dripsharpCaught_232_26_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_232_26_0);
        }
      } catch (global::System.Exception __dripsharpCaught_231_25_0) {
        __dripsharpPrimary_231_25_0 = __dripsharpCaught_231_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_231_25_0);
      }
    }
  }

  private void testCompareCreatedByContentWithCreatedByLosslessFactory(string filename) { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_246_25_0 = null!;
      try {
        global::System.IO.Stream @is
          = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename));
        global::System.Exception __dripsharpPrimary_247_26_0 = null!;
        try {
          global::DripSharp.Runtime.JavaFile file
            = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
            global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
            = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject>(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject),
            "CreateFromFileByContent",
            new global::System.Type[] { typeof(global::System.IO.FileInfo),
              typeof(global::DripSharp.PdfCarton.Pdmodel.PDDocument) },
            new object[] { (global::DripSharp.Runtime.JavaFile)file,
              (global::DripSharp.PdfCarton.Pdmodel.PDDocument)doc });
          global::SkiaSharp.SKBitmap bim
            = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(@is);
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
            = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(doc,
            bim);
          global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(),
            image.GetSuffix(), null);
          this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
        } catch (global::System.Exception __dripsharpCaught_247_26_0) {
          __dripsharpPrimary_247_26_0 = __dripsharpCaught_247_26_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_247_26_0);
        }
      } catch (global::System.Exception __dripsharpCaught_246_25_0) {
        __dripsharpPrimary_246_25_0 = __dripsharpCaught_246_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_246_25_0);
      }
    }
  }

  private void testCompareCreateByContentWithCreatedByCCITTFactory(string filename) { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_263_25_0 = null!;
      try {
        global::DripSharp.Runtime.JavaFile file
          = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename)));
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
          = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject>(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject),
          "CreateFromFileByContent", new global::System.Type[] { typeof(global::System.IO.FileInfo),
            typeof(global::DripSharp.PdfCarton.Pdmodel.PDDocument) },
          new object[] { (global::DripSharp.Runtime.JavaFile)file,
            (global::DripSharp.PdfCarton.Pdmodel.PDDocument)doc });
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
          = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject>(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory),
          "CreateFromFile",
          new global::System.Type[] { typeof(global::DripSharp.PdfCarton.Pdmodel.PDDocument),
            typeof(global::System.IO.FileInfo) },
          new object[] { (global::DripSharp.PdfCarton.Pdmodel.PDDocument)doc,
            (global::DripSharp.Runtime.JavaFile)file });
        global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(), image.GetSuffix(),
          null);
        this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
      } catch (global::System.Exception __dripsharpCaught_263_25_0) {
        __dripsharpPrimary_263_25_0 = __dripsharpCaught_263_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_263_25_0);
      }
    }
  }

  private void testCompareCreatedByContentWithCreatedByJPEGFactory(string filename) {
    global::DripSharp.Runtime.JavaFile file
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename))); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_279_25_0 = null!;
      try {
        global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file);
        global::System.Exception __dripsharpPrimary_280_26_0 = null!;
        try {
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
            = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject>(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject),
            "CreateFromFileByContent",
            new global::System.Type[] { typeof(global::System.IO.FileInfo),
              typeof(global::DripSharp.PdfCarton.Pdmodel.PDDocument) },
            new object[] { (global::DripSharp.Runtime.JavaFile)file,
              (global::DripSharp.PdfCarton.Pdmodel.PDDocument)doc });
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
            = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromStream(doc,
            @is);
          global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(),
            image.GetSuffix(), null);
          this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
        } catch (global::System.Exception __dripsharpCaught_280_26_0) {
          __dripsharpPrimary_280_26_0 = __dripsharpCaught_280_26_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_280_26_0);
        }
      } catch (global::System.Exception __dripsharpCaught_279_25_0) {
        __dripsharpPrimary_279_25_0 = __dripsharpCaught_279_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_279_25_0);
      }
    }
  }

  private void testCompareCreatedFromByteArrayWithCreatedByLosslessFactory(string filename) {
    global::DripSharp.Runtime.JavaFile file
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename))); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_298_25_0 = null!;
      try {
        global::System.IO.Stream is1
          = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename));
        global::System.Exception __dripsharpPrimary_299_25_0 = null!;
        try {
          global::System.IO.Stream is2 = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file);
          global::System.Exception __dripsharpPrimary_300_25_0 = null!;
          try {
            sbyte[] byteArray = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(is2);
            global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
              = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromByteArray(doc,
              byteArray, (string)default!);
            global::SkiaSharp.SKBitmap bim
              = global::DripSharp.Runtime.PdfCartonFontCompat.ReadImage(is1);
            global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
              = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.LosslessFactory.CreateFromImage(doc,
              bim);
            global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(),
              image.GetSuffix(), null);
            this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
          } catch (global::System.Exception __dripsharpCaught_300_25_0) {
            __dripsharpPrimary_300_25_0 = __dripsharpCaught_300_25_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(is2, __dripsharpPrimary_300_25_0);
          }
        } catch (global::System.Exception __dripsharpCaught_299_25_0) {
          __dripsharpPrimary_299_25_0 = __dripsharpCaught_299_25_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(is1, __dripsharpPrimary_299_25_0);
        }
      } catch (global::System.Exception __dripsharpCaught_298_25_0) {
        __dripsharpPrimary_298_25_0 = __dripsharpCaught_298_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_298_25_0);
      }
    }
  }

  private void testCompareCreatedFromByteArrayWithCreatedByCCITTFactory(string filename) {
    global::DripSharp.Runtime.JavaFile file
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename))); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_317_25_0 = null!;
      try {
        global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file);
        global::System.Exception __dripsharpPrimary_318_25_0 = null!;
        try {
          sbyte[] byteArray = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(@is);
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
            = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromByteArray(doc,
            byteArray, (string)default!);
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
            = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject>(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CCITTFactory),
            "CreateFromFile",
            new global::System.Type[] { typeof(global::DripSharp.PdfCarton.Pdmodel.PDDocument),
              typeof(global::System.IO.FileInfo) },
            new object[] { (global::DripSharp.PdfCarton.Pdmodel.PDDocument)doc,
              (global::DripSharp.Runtime.JavaFile)file });
          global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(),
            image.GetSuffix(), null);
          this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
        } catch (global::System.Exception __dripsharpCaught_318_25_0) {
          __dripsharpPrimary_318_25_0 = __dripsharpCaught_318_25_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_318_25_0);
        }
      } catch (global::System.Exception __dripsharpCaught_317_25_0) {
        __dripsharpPrimary_317_25_0 = __dripsharpCaught_317_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_317_25_0);
      }
    }
  }

  private void testCompareCreatedFromByteArrayWithCreatedByJPEGFactory(string filename) {
    global::DripSharp.Runtime.JavaFile file
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename))); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_334_25_0 = null!;
      try {
        global::System.IO.Stream is1 = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file);
        global::System.Exception __dripsharpPrimary_335_25_0 = null!;
        try {
          global::System.IO.Stream is2 = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file);
          global::System.Exception __dripsharpPrimary_336_25_0 = null!;
          try {
            sbyte[] byteArray = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(is1);
            global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
              = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromByteArray(doc,
              byteArray, (string)default!);
            global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
              = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.JPEGFactory.CreateFromStream(doc,
              is2);
            global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(),
              image.GetSuffix(), null);
            this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
          } catch (global::System.Exception __dripsharpCaught_336_25_0) {
            __dripsharpPrimary_336_25_0 = __dripsharpCaught_336_25_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(is2, __dripsharpPrimary_336_25_0);
          }
        } catch (global::System.Exception __dripsharpCaught_335_25_0) {
          __dripsharpPrimary_335_25_0 = __dripsharpCaught_335_25_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(is1, __dripsharpPrimary_335_25_0);
        }
      } catch (global::System.Exception __dripsharpCaught_334_25_0) {
        __dripsharpPrimary_334_25_0 = __dripsharpCaught_334_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_334_25_0);
      }
    }
  }

  private void testCompareCreatedFromByteArrayWithCreatedByCustomFactory(string filename) {
    global::DripSharp.Runtime.JavaFile file
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObjectTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename))); {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_352_25_0 = null!;
      try {
        global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(file);
        global::System.Exception __dripsharpPrimary_353_25_0 = null!;
        try {
          sbyte[] byteArray = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(@is);
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.CustomFactory customFactory
            = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.__CustomFactoryFunctionalAdapter(this.alphaFlattenedJPEGFactory);
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject image
            = global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject.CreateFromByteArray(doc,
            byteArray, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename),
            customFactory);
          global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject expectedImage
            = this.alphaFlattenedJPEGFactory(doc, byteArray);
          global::DripSharp.Testing.JavaAssertions.Equal(expectedImage.GetSuffix(),
            image.GetSuffix(), null);
          this.checkIdentARGB(image.GetImage(), expectedImage.GetImage());
        } catch (global::System.Exception __dripsharpCaught_353_25_0) {
          __dripsharpPrimary_353_25_0 = __dripsharpCaught_353_25_0;
          throw;
        } finally {
          global::DripSharp.Runtime.JavaCompat.CloseResource(@is, __dripsharpPrimary_353_25_0);
        }
      } catch (global::System.Exception __dripsharpCaught_352_25_0) {
        __dripsharpPrimary_352_25_0 = __dripsharpCaught_352_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_352_25_0);
      }
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
