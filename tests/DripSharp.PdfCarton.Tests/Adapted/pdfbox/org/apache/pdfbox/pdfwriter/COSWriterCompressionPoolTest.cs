// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdfwriter;

public class COSWriterCompressionPoolTest {
  internal virtual void testPDFBox6036() {
    for (int i = 1; (i <= 222222); i *= 2) {
      using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDDocumentOutline outline
          = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDDocumentOutline();
        document.GetDocumentCatalog().SetDocumentOutline(outline);
        for (int j = 0; (j < i); j++) {
          outline.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
        }
        global::DripSharp.Testing.JavaAssertions.DoesNotThrow(()
          => new global::DripSharp.PdfCarton.Pdfwriter.Compress.COSWriterCompressionPool(document,
          global::DripSharp.PdfCarton.Pdfwriter.Compress.CompressParameters.DefaultCompression),
          null);
      }
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724633032_663bbf64b3343b68() {
    try {
      this.testPDFBox6036();
    } finally {
    }
  }
}
