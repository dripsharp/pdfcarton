// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel;

public class TestPDDocumentInformation {
  internal virtual void testMetadataExtraction() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "src/test/resources/input/hello3.pdf")))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentInformation info = doc.GetDocumentInformation();
      global::DripSharp.Testing.JavaAssertions.Equal("Brian Carrier", info.GetAuthor(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Wrong author"));
      global::DripSharp.Testing.JavaAssertions.NotNull(info.GetCreationDate(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Wrong creationDate"));
      global::DripSharp.Testing.JavaAssertions.Equal("Acrobat PDFMaker 8.1 for Word",
        info.GetCreator(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Wrong creator"));
      global::DripSharp.Testing.JavaAssertions.Null(info.GetKeywords(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Wrong keywords"));
      global::DripSharp.Testing.JavaAssertions.NotNull(info.GetModificationDate(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Wrong modificationDate"));
      global::DripSharp.Testing.JavaAssertions.Equal("Acrobat Distiller 8.1.0 (Windows)",
        info.GetProducer(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Wrong producer"));
      global::DripSharp.Testing.JavaAssertions.Null(info.GetSubject(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Wrong subject"));
      global::DripSharp.Testing.JavaAssertions.Null(info.GetTrapped(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Wrong trapped"));
      global::System.Collections.Generic.IList<string> expectedMetadataKeys
        = global::DripSharp.Runtime.JavaCompat.AsList<string>("CreationDate", "Author", "Creator",
        "Producer", "ModDate", "Company", "SourceModified", "Title");
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.CollectionCount(expectedMetadataKeys),
        info.GetMetadataKeys().Count, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Wrong metadata key count"));
      global::DripSharp.Runtime.JavaCompat.ForEach(expectedMetadataKeys, (key)
        => global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(info.GetMetadataKeys(),
        key), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat("Missing metadata key:", key))));
      global::DripSharp.Testing.JavaAssertions.Equal("Basis Technology Corp.",
        info.GetCustomMetadataValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Company")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Wrong company"));
      global::DripSharp.Testing.JavaAssertions.Equal("D:20080819181502",
        info.GetCustomMetadataValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "SourceModified")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Wrong sourceModified"));
    }
  }

  internal virtual void testPDFBox3068() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.TestPDDocumentInformation),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-3068.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentInformation documentInformation
        = doc.GetDocumentInformation();
      global::DripSharp.Testing.JavaAssertions.Equal("Title", documentInformation.GetTitle(), null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_0101124264_90f7badaa012a355() {
    try {
      this.testMetadataExtraction();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724543754_cdd6eefe656f3293() {
    try {
      this.testPDFBox3068();
    } finally {
    }
  }
}
