// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel;

public class TestPDDocumentCatalog {
  internal virtual void retrievePageLabels() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.TestPDDocumentCatalog),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "test_pagelabels.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog cat = doc.GetDocumentCatalog();
      string[] labels = cat.GetPageLabels().GetLabelsByPageIndices();
      global::DripSharp.Testing.JavaAssertions.Equal(12, labels.Length, null);
      global::DripSharp.Testing.JavaAssertions.Equal("A1", labels[0], null);
      global::DripSharp.Testing.JavaAssertions.Equal("A2", labels[1], null);
      global::DripSharp.Testing.JavaAssertions.Equal("A3", labels[2], null);
      global::DripSharp.Testing.JavaAssertions.Equal("i", labels[3], null);
      global::DripSharp.Testing.JavaAssertions.Equal("ii", labels[4], null);
      global::DripSharp.Testing.JavaAssertions.Equal("iii", labels[5], null);
      global::DripSharp.Testing.JavaAssertions.Equal("iv", labels[6], null);
      global::DripSharp.Testing.JavaAssertions.Equal("v", labels[7], null);
      global::DripSharp.Testing.JavaAssertions.Equal("vi", labels[8], null);
      global::DripSharp.Testing.JavaAssertions.Equal("vii", labels[9], null);
      global::DripSharp.Testing.JavaAssertions.Equal("Appendix I", labels[10], null);
      global::DripSharp.Testing.JavaAssertions.Equal("Appendix II", labels[11], null);
    }
  }

  internal virtual void retrievePageLabelsOnMalformedPdf() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.TestPDDocumentCatalog),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "badpagelabels.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog cat = doc.GetDocumentCatalog();
      global::DripSharp.Testing.JavaAssertions.DoesNotThrow(()
        => cat.GetPageLabels().GetLabelsByPageIndices(), null);
    }
  }

  internal virtual void retrieveNumberOfPages() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.TestPDDocumentCatalog),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "test.unc.pdf"))))) {
      global::DripSharp.Testing.JavaAssertions.Equal(4, doc.GetNumberOfPages(), null);
    }
  }

  internal virtual void handleOutputIntents() {
    using (global::System.IO.Stream colorProfile
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.TestPDDocumentCatalog),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "sRGB.icc"))) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.TestPDDocumentCatalog),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "test.unc.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog = doc.GetDocumentCatalog();
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDOutputIntent> outputIntents
        = catalog.GetOutputIntents();
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(outputIntents),
        null);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDOutputIntent oi
        = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDOutputIntent(doc, colorProfile);
      oi.SetInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "sRGB IEC61966-2.1"));
      oi.SetOutputCondition(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "sRGB IEC61966-2.1"));
      oi.SetOutputConditionIdentifier(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "sRGB IEC61966-2.1"));
      oi.SetRegistryName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "http://www.color.org"));
      doc.GetDocumentCatalog().AddOutputIntent(oi);
      outputIntents = catalog.GetOutputIntents();
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(outputIntents), null);
      catalog.SetOutputIntents(outputIntents);
      outputIntents = catalog.GetOutputIntents();
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(outputIntents), null);
    }
  }

  internal virtual void handleBooleanInOpenAction() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      doc.GetDocumentCatalog().GetCOSObject().SetBoolean(global::DripSharp.PdfCarton.Cos.COSName.OpenAction,
        false);
      global::DripSharp.Testing.JavaAssertions.Null(doc.GetDocumentCatalog().GetOpenAction(), null);
    }
  }

  internal virtual void testNullThreads() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog documentCatalog
        = doc.GetDocumentCatalog();
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(documentCatalog.GetThreads()), null);
      documentCatalog.SetThreads(new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDThread>());
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(documentCatalog.GetThreads()), null);
      documentCatalog.SetThreads((global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDThread>)default!);
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(documentCatalog.GetThreads()), null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_1380617509_4c480be3457e13fb() {
    try {
      this.handleBooleanInOpenAction();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1999055822_61992621ec4e5658() {
    try {
      this.handleOutputIntents();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3045939656_8d2558d8a05080fc() {
    try {
      this.retrieveNumberOfPages();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3558099146_bca7ccaa8ef588cd() {
    try {
      this.retrievePageLabels();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0605263392_1e70b283f321a8a7() {
    try {
      this.retrievePageLabelsOnMalformedPdf();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1809695792_4282be6e8af24a2e() {
    try {
      this.testNullThreads();
    } finally {
    }
  }
}
