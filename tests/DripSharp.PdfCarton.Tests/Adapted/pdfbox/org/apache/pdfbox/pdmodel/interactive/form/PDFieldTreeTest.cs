// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class PDFieldTreeTest {
  internal virtual void test5044() {
    string sourceUrl
      = "https://issues.apache.org/jira/secure/attachment/13016994/PDFBOX-4131-0.pdf";
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.Runtime.JavaCompat.OpenUrlStream(global::DripSharp.Runtime.JavaCompat.NewUri(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      sourceUrl)))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog = doc.GetDocumentCatalog();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = catalog.GetAcroForm();
      int count = 0;
      foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field in acroForm.GetFieldTree()) {
        ++count;
      }
      global::DripSharp.Testing.JavaAssertions.Equal(4, count, null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_0999718381_2669d3578783dd43() {
    try {
      this.test5044();
    } finally {
    }
  }
}
