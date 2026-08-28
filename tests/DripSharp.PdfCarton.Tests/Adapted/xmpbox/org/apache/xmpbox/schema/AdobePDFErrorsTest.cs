// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Schema;

public class AdobePDFErrorsTest {
  private readonly global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata
    = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();

  internal virtual void testPDFAIdentification() {
    global::DripSharp.PdfCarton.Xmp.Schema.AdobePDFSchema schem
      = this.metadata.CreateAndAddAdobePDFSchema();
    string keywords = "keywords ihih";
    string pdfVersion = "1.4";
    string producer = "producer";
    schem.SetKeywords(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", keywords));
    schem.SetPDFVersion(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", pdfVersion));
    global::DripSharp.Testing.JavaAssertions.Null(schem.GetProducer(), null);
    schem.SetProducer(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", producer));
    global::DripSharp.Testing.JavaAssertions.Equal("Keywords",
      schem.GetKeywordsProperty().GetPropertyName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(keywords, schem.GetKeywords(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("PDFVersion",
      schem.GetPDFVersionProperty().GetPropertyName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(pdfVersion, schem.GetPDFVersion(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Producer",
      schem.GetProducerProperty().GetPropertyName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(producer, schem.GetProducer(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(schem, this.metadata.GetAdobePDFSchema(), null);
    global::DripSharp.Runtime.JavaByteArrayOutputStream bos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer().Serialize(this.metadata, bos, true);
    schem
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser().Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(bos)).GetAdobePDFSchema();
    global::DripSharp.Testing.JavaAssertions.Equal("Keywords",
      schem.GetKeywordsProperty().GetPropertyName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(keywords, schem.GetKeywords(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("PDFVersion",
      schem.GetPDFVersionProperty().GetPropertyName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(pdfVersion, schem.GetPDFVersion(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Producer",
      schem.GetProducerProperty().GetPropertyName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(producer, schem.GetProducer(), null);
  }

  internal virtual void testBadPDFAConformanceId() {
    global::DripSharp.PdfCarton.Xmp.Schema.PDFAIdentificationSchema pdfaid
      = this.metadata.CreateAndAddPDFAIdentificationSchema();
    string conformance = "kiohiohiohiohio";
    global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Type.BadFieldValueException>(()
      => {
        pdfaid.SetConformance(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        conformance));
      }, null);
  }

  internal virtual void testBadVersionIdValueType() {
    global::DripSharp.PdfCarton.Xmp.Schema.PDFAIdentificationSchema pdfaid
      = this.metadata.CreateAndAddPDFAIdentificationSchema();
    pdfaid.SetPartValueWithString(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "1"));
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => {
        pdfaid.SetPartValueWithString(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "ojoj"));
      }, null);
  }

  [Xunit.Fact]
  public void __Upstream_1655032942_0ff3716437ef79e2() {
    try {
      this.testBadPDFAConformanceId();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2869871851_e2dd474b852253d4() {
    try {
      this.testBadVersionIdValueType();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3790297615_0513ce43d736d0bb() {
    try {
      this.testPDFAIdentification();
    } finally {
    }
  }
}
