// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Schema;

public class PDFAIdentificationOthersTest {
  internal virtual void testPDFAIdentification() {
    global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata
      = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
    global::DripSharp.PdfCarton.Xmp.Schema.PDFAIdentificationSchema pdfaid
      = metadata.CreateAndAddPDFAIdentificationSchema();
    int versionId = 1;
    string amdId = "2005";
    string conformance = "B";
    pdfaid.SetPartValueWithInt((int)(versionId));
    pdfaid.SetAmd(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", amdId));
    pdfaid.SetConformance(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      conformance));
    global::DripSharp.Testing.JavaAssertions.Equal(versionId, pdfaid.GetPart(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(amdId, pdfaid.GetAmendment(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(conformance, pdfaid.GetConformance(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat("",
      versionId), pdfaid.GetPartProperty().GetStringValue(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(amdId, pdfaid.GetAmdProperty().GetStringValue(),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(conformance,
      pdfaid.GetConformanceProperty().GetStringValue(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(pdfaid, metadata.GetPDFAIdentificationSchema(),
      null);
    global::DripSharp.Runtime.JavaByteArrayOutputStream bos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer().Serialize(metadata, bos, true);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata rxmp
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser().Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(bos));
    pdfaid = rxmp.GetPDFAIdentificationSchema();
    global::DripSharp.Testing.JavaAssertions.Equal(versionId, pdfaid.GetPart(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(amdId, pdfaid.GetAmendment(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(conformance, pdfaid.GetConformance(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat("",
      versionId), pdfaid.GetPartProperty().GetStringValue(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(amdId, pdfaid.GetAmdProperty().GetStringValue(),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(conformance,
      pdfaid.GetConformanceProperty().GetStringValue(), null);
  }

  internal virtual void testBadPDFAConformanceId() {
    global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata
      = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
    global::DripSharp.PdfCarton.Xmp.Schema.PDFAIdentificationSchema pdfaid
      = metadata.CreateAndAddPDFAIdentificationSchema();
    string conformance = "kiohiohiohiohio";
    global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Type.BadFieldValueException>(()
      => pdfaid.SetConformance(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      conformance)), null);
  }

  internal virtual void testBadVersionIdValueType() {
    global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata
      = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
    global::DripSharp.PdfCarton.Xmp.Schema.PDFAIdentificationSchema pdfaid
      = metadata.CreateAndAddPDFAIdentificationSchema();
    pdfaid.SetPartValueWithString(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "1"));
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(()
      => pdfaid.SetPartValueWithString(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "ojoj")), null);
  }

  [Xunit.Fact]
  public void __Upstream_1655032942_590950f3ca9e271e() {
    try {
      this.testBadPDFAConformanceId();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2869871851_403dd2ee07b7e42d() {
    try {
      this.testBadVersionIdValueType();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3790297615_5c2050b2df64bdef() {
    try {
      this.testPDFAIdentification();
    } finally {
    }
  }
}
