// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Multipdf;

public class PageExtractorTest {
  private void closeDoc(global::DripSharp.PdfCarton.Pdmodel.PDDocument doc) {
    if ((doc != default!)) {
      try {
        doc.Dispose();
      } catch (global::System.Exception e) when (e is not global::System.TypeInitializationException) {}
    }
  }

  internal virtual void testExtract() {
    global::DripSharp.PdfCarton.Pdmodel.PDDocument sourcePdf = default!;
    global::DripSharp.PdfCarton.Pdmodel.PDDocument result = default!;
    try {
      sourcePdf
        = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "src/test/resources/input/cweb.pdf")));
      global::DripSharp.PdfCarton.Multipdf.PageExtractor instance
        = new global::DripSharp.PdfCarton.Multipdf.PageExtractor(sourcePdf!);
      result = instance.Extract();
      global::DripSharp.Testing.JavaAssertions.Equal(sourcePdf!.GetNumberOfPages(),
        result!.GetNumberOfPages(), null);
      this.closeDoc(result!);
      instance = new global::DripSharp.PdfCarton.Multipdf.PageExtractor(sourcePdf!, 1, 1);
      result = instance.Extract();
      global::DripSharp.Testing.JavaAssertions.Equal(1, result!.GetNumberOfPages(), null);
      this.closeDoc(result!);
      instance = new global::DripSharp.PdfCarton.Multipdf.PageExtractor(sourcePdf!, 1, 5);
      result = instance.Extract();
      global::DripSharp.Testing.JavaAssertions.Equal(5, result!.GetNumberOfPages(), null);
      this.closeDoc(result!);
      instance = new global::DripSharp.PdfCarton.Multipdf.PageExtractor(sourcePdf!, 5, 10);
      result = instance.Extract();
      global::DripSharp.Testing.JavaAssertions.Equal(6, result!.GetNumberOfPages(), null);
      this.closeDoc(result!);
      instance = new global::DripSharp.PdfCarton.Multipdf.PageExtractor(sourcePdf!, 2, 1);
      result = instance.Extract();
      global::DripSharp.Testing.JavaAssertions.Equal(0, result!.GetNumberOfPages(), null);
      this.closeDoc(result!);
    } finally {
      this.closeDoc(sourcePdf!);
      this.closeDoc(result!);
    }
  }

  [Xunit.Fact]
  public void __Upstream_0449595279_9780e89c503afc55() {
    try {
      this.testExtract();
    } finally {
    }
  }
}
