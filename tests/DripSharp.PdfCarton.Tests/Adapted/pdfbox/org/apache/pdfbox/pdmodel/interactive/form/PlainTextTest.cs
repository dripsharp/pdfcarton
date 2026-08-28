// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class PlainTextTest {
  internal virtual void characterCR() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PlainText text
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PlainText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "CR\rCR"));
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(text.getParagraphs()), null);
  }

  internal virtual void characterLF() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PlainText text
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PlainText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "LF\nLF"));
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(text.getParagraphs()), null);
  }

  internal virtual void characterCRLF() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PlainText text
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PlainText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "CRLF\r\nCRLF"));
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(text.getParagraphs()), null);
  }

  internal virtual void characterLFCR() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PlainText text
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PlainText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "LFCR\n\rLFCR"));
    global::DripSharp.Testing.JavaAssertions.Equal(3,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(text.getParagraphs()), null);
  }

  internal virtual void characterUnicodeLinebreak() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PlainText text
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PlainText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "linebreak\u2028linebreak"));
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(text.getParagraphs()), null);
  }

  internal virtual void characterUnicodeParagraphbreak() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PlainText text
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PlainText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "paragraphbreak\u2029paragraphbreak"));
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(text.getParagraphs()), null);
  }

  [Xunit.Fact]
  public void __Upstream_2100927832_e609725779b62c45() {
    try {
      this.characterCR();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0357019858_becd24d18ed5c443() {
    try {
      this.characterCRLF();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2100928099_8a055db474fe95f1() {
    try {
      this.characterLF();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0357276178_34d3596e33774eb1() {
    try {
      this.characterLFCR();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1456970871_33ecc7a88cca73a6() {
    try {
      this.characterUnicodeLinebreak();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1964055781_48b0b5ad9f4a984c() {
    try {
      this.characterUnicodeParagraphbreak();
    } finally {
    }
  }
}
