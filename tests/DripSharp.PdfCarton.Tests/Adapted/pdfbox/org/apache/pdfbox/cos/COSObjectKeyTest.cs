// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Cos;

public class COSObjectKeyTest {
  internal virtual void testInputValues() {
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(()
      => new global::DripSharp.PdfCarton.Cos.COSObjectKey(-1L, 0), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(()
      => new global::DripSharp.PdfCarton.Cos.COSObjectKey(1L, -1), null);
  }

  internal virtual void compareToInputNotNullOutputZero() {
    global::DripSharp.PdfCarton.Cos.COSObjectKey objectUnderTest
      = new global::DripSharp.PdfCarton.Cos.COSObjectKey(1L, 0);
    global::DripSharp.PdfCarton.Cos.COSObjectKey other
      = new global::DripSharp.PdfCarton.Cos.COSObjectKey(1L, 0);
    int retval = objectUnderTest.CompareTo(other);
    global::DripSharp.Testing.JavaAssertions.Equal(0, retval, null);
  }

  internal virtual void compareToInputNotNullOutputNotNull() {
    global::DripSharp.PdfCarton.Cos.COSObjectKey objectUnderTest
      = new global::DripSharp.PdfCarton.Cos.COSObjectKey(1L, 0);
    global::DripSharp.PdfCarton.Cos.COSObjectKey other
      = new global::DripSharp.PdfCarton.Cos.COSObjectKey(9999999L, 0);
    int retvalNegative = objectUnderTest.CompareTo(other);
    int retvalPositive = other.CompareTo(objectUnderTest);
    global::DripSharp.Testing.JavaAssertions.Equal(-1, retvalNegative, null);
    global::DripSharp.Testing.JavaAssertions.Equal(1, retvalPositive, null);
  }

  internal virtual void testEquals() {
    global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(100),
      0), new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(100), 0), null);
    global::DripSharp.Testing.JavaAssertions.NotEqual(new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(100),
      0), new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(101), 0), null);
  }

  internal virtual void testInternalRepresentation() {
    global::DripSharp.PdfCarton.Cos.COSObjectKey key
      = new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(100), 0);
    global::DripSharp.Testing.JavaAssertions.Equal((long)(100), key.GetNumber(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(0, key.GetGeneration(), null);
    key = new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(200), 4);
    global::DripSharp.Testing.JavaAssertions.Equal((long)(200), key.GetNumber(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(4, key.GetGeneration(), null);
    key = new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(200000), 0);
    global::DripSharp.Testing.JavaAssertions.Equal((long)(200000), key.GetNumber(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(0, key.GetGeneration(), null);
    key = new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(87654321), 123);
    global::DripSharp.Testing.JavaAssertions.Equal((long)(87654321), key.GetNumber(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(123, key.GetGeneration(), null);
  }

  internal virtual void testSortingOrder() {
    global::DripSharp.PdfCarton.Cos.COSObjectKey key40
      = new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(4), 0);
    global::DripSharp.PdfCarton.Cos.COSObjectKey key41
      = new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(4), 1);
    global::DripSharp.PdfCarton.Cos.COSObjectKey key50
      = new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(5), 0);
    global::DripSharp.Testing.JavaAssertions.Equal(0, key40.CompareTo(key40), null);
    global::DripSharp.Testing.JavaAssertions.Equal(0, key41.CompareTo(key41), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1, key40.CompareTo(key41), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1, key40.CompareTo(key50), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1, key41.CompareTo(key50), null);
  }

  internal virtual void checkHashCode() {
    global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(100),
      0).GetHashCode(), new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(100),
      0).GetHashCode(), null);
    global::DripSharp.Testing.JavaAssertions.NotEqual(new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(100),
      0).GetHashCode(), new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(200),
      0).GetHashCode(), null);
    global::DripSharp.Testing.JavaAssertions.NotEqual(new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(100),
      0).GetHashCode(), new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(99),
      1).GetHashCode(), null);
  }

  internal virtual void testPDFBox5742() {
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos1
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos2
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    global::SkiaSharp.SKBitmap bim1orig;
    global::SkiaSharp.SKBitmap bim2orig;
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/pdfs"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-5742.pdf")))) {
      global::DripSharp.PdfCarton.Rendering.PDFRenderer renderer
        = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(doc);
      bim1orig = renderer.RenderImage(0);
      bim2orig = renderer.RenderImage(1);
      global::DripSharp.PdfCarton.Multipdf.Splitter splitter
        = new global::DripSharp.PdfCarton.Multipdf.Splitter();
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.PDDocument> splits
        = splitter.Split(doc);
      global::DripSharp.Testing.JavaAssertions.Equal(2,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(splits), null);
      using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc1__153_29
        = global::DripSharp.Runtime.JavaCompat.ListGet(splits,
        0)) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc2__154_29
        = global::DripSharp.Runtime.JavaCompat.ListGet(splits, 1)) {
        doc1__153_29.Save(baos1);
        doc2__154_29.Save(baos2);
      }
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc1__160_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos1))) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc2__161_25
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos2))) {
      global::DripSharp.Testing.JavaAssertions.Equal(1, doc1__160_25.GetNumberOfPages(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(1, doc2__161_25.GetNumberOfPages(), null);
      global::DripSharp.PdfCarton.Rendering.PDFRenderer renderer1
        = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(doc1__160_25);
      global::DripSharp.PdfCarton.Rendering.PDFRenderer renderer2
        = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(doc2__161_25);
      global::SkiaSharp.SKBitmap bim1new = renderer1.RenderImage(0);
      global::SkiaSharp.SKBitmap bim2new = renderer2.RenderImage(0);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(bim1orig,
        bim1new);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(bim2orig,
        bim2new);
    }
  }

  [Xunit.Fact]
  public void __Upstream_0414870851_f30412dc496283a4() {
    try {
      this.checkHashCode();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2578868841_43ab294bcad116e1() {
    try {
      this.compareToInputNotNullOutputNotNull();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3049629081_d98440224a86372a() {
    try {
      this.compareToInputNotNullOutputZero();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3471735537_544d0c96d4870e40() {
    try {
      this.testEquals();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1250203034_d4f17768df5da2b2() {
    try {
      this.testInputValues();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1596929052_5696a30cbac20e9b() {
    try {
      this.testInternalRepresentation();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724609995_c3e6fa3c642b66c7() {
    try {
      this.testPDFBox5742();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3283968476_69b69ebfa3a84b72() {
    try {
      this.testSortingOrder();
    } finally {
    }
  }
}
