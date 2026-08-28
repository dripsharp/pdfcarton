// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Cos;

public class COSDocumentTest {
  internal virtual void testPDFBox6132() {
    global::DripSharp.PdfCarton.Cos.COSDocument document
      = new global::DripSharp.PdfCarton.Cos.COSDocument();
    global::System.Collections.Generic.IDictionary<global::DripSharp.PdfCarton.Cos.COSObjectKey,
      long> xrefTable
      = global::DripSharp.Runtime.JavaCompat.NewJavaDictionary<global::DripSharp.PdfCarton.Cos.COSObjectKey,
      long>();
    global::DripSharp.Runtime.JavaCompat.MapPut(xrefTable, default!, 10L);
    document.AddXRefTable(xrefTable);
    global::DripSharp.Testing.JavaAssertions.Equal(global::System.Array.Empty<object>(),
      document.GetObjectsByType(global::DripSharp.PdfCarton.Cos.COSName.T), null);
    global::DripSharp.Testing.JavaAssertions.Null(document.GetLinearizedDictionary(), null);
  }

  [Xunit.Fact]
  public void __Upstream_1724633989_28668cdca7cc80f9() {
    try {
      this.testPDFBox6132();
    } finally {
    }
  }
}
