// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class PDAcroFormGenerateAppearancesTest {
  internal virtual void testGetAcroForm(string sourceUrl) { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument testPdf
        = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        sourceUrl)))));
      global::System.Exception __dripsharpPrimary_53_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog
          = testPdf.GetDocumentCatalog();
        global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => catalog.GetAcroForm(),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "Getting the AcroForm shall not throw an exception"));
      } catch (global::System.Exception __dripsharpCaught_53_25_0) {
        __dripsharpPrimary_53_25_0 = __dripsharpCaught_53_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(testPdf, __dripsharpPrimary_53_25_0);
      }
    }
  }

  [Xunit.Theory]
  [Xunit.InlineData("https://issues.apache.org/jira/secure/attachment/13016941/REDHAT-1301016-0.pdf")]
  [Xunit.InlineData("https://issues.apache.org/jira/secure/attachment/12908175/AML1.PDF")]
  [Xunit.InlineData("https://issues.apache.org/jira/secure/attachment/13016992/PDFBOX-3891-5.pdf")]
  public void __Upstream_1856799943_0d27a08698189767(string sourceUrl) {
    try {
      this.testGetAcroForm(sourceUrl);
    } finally {
    }
  }
}
