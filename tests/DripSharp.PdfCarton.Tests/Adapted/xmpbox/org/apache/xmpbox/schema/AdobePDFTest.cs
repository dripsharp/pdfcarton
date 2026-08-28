// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Schema;

public class AdobePDFTest {
  private global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = null!;

  private global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema = null!;

  private global::System.Type schemaClass = null!;

  internal virtual void initMetadata() {
    this.metadata = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
    this.schema = this.metadata.CreateAndAddAdobePDFSchema();
    this.schemaClass = typeof(global::DripSharp.PdfCarton.Xmp.Schema.AdobePDFSchema);
  }

  internal virtual void testElementValue(string property,
    global::DripSharp.PdfCarton.Xmp.Type.PropertyType type, string value) {
    global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester xmpSchemaTester
      = new global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester(this.metadata, this.schema,
      this.schemaClass, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", property),
      type, value);
    xmpSchemaTester.TestGetSetValue();
  }

  internal virtual void testElementProperty(string property,
    global::DripSharp.PdfCarton.Xmp.Type.PropertyType type, string value) {
    global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester xmpSchemaTester
      = new global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester(this.metadata, this.schema,
      this.schemaClass, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", property),
      type, value);
    xmpSchemaTester.TestGetSetProperty();
  }

  internal static global::System.Collections.Generic.IEnumerable<object[]> initializeParameters() {
    return global::DripSharp.Runtime.JavaCompat.StreamOf(new object[] { "Keywords",
        global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Text),
      "kw1 kw2 kw3" }, new object[] { "PDFVersion",
        global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Text),
      "1.4" }, new object[] { "Producer",
        global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Text),
      "testcase" });
  }

  internal virtual void testPDFAIdentification() {
    global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata2
      = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
    global::DripSharp.PdfCarton.Xmp.Schema.AdobePDFSchema schem
      = metadata2.CreateAndAddAdobePDFSchema();
    string keywords = "keywords ihih";
    string pdfVersion = "1.4";
    string producer = "producer";
    schem.SetKeywords(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", keywords));
    schem.SetPDFVersion(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", pdfVersion));
    global::DripSharp.Testing.JavaAssertions.Null(schem.GetProducer(), null);
    schem.SetProducer(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", producer));
    global::DripSharp.Testing.JavaAssertions.Equal("pdf", schem.GetKeywordsProperty().GetPrefix(),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal("Keywords",
      schem.GetKeywordsProperty().GetPropertyName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(keywords, schem.GetKeywords(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("pdf", schem.GetPDFVersionProperty().GetPrefix(),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal("PDFVersion",
      schem.GetPDFVersionProperty().GetPropertyName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(pdfVersion, schem.GetPDFVersion(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("pdf", schem.GetProducerProperty().GetPrefix(),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal("Producer",
      schem.GetProducerProperty().GetPropertyName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(producer, schem.GetProducer(), null);
  }

  internal virtual void testBadPDFAConformanceId() {
    global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata2
      = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
    global::DripSharp.PdfCarton.Xmp.Schema.PDFAIdentificationSchema pdfaid
      = metadata2.CreateAndAddPDFAIdentificationSchema();
    string conformance = "kiohiohiohiohio";
    global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Type.BadFieldValueException>(()
      => {
        pdfaid.SetConformance(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        conformance));
      }, null);
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_72360d4ff6f4ddb2() {
    foreach (var value in initializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.PropertyType>(row[1]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[2]) };
    }
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_7a27442fa6395e6e() {
    foreach (var value in initializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.PropertyType>(row[1]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[2]) };
    }
  }

  [Xunit.Fact]
  public void __Upstream_1655032942_75a20cb52b367ca2() {
    this.initMetadata();
    try {
      this.testBadPDFAConformanceId();
    } finally {
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_72360d4ff6f4ddb2))]
  public void __Upstream_1084695039_d73afb776a94e59c(string property,
    global::DripSharp.PdfCarton.Xmp.Type.PropertyType type, string value) {
    this.initMetadata();
    try {
      this.testElementProperty(property, type, value);
    } finally {
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_7a27442fa6395e6e))]
  public void __Upstream_2596523399_347caddb44c68241(string property,
    global::DripSharp.PdfCarton.Xmp.Type.PropertyType type, string value) {
    this.initMetadata();
    try {
      this.testElementValue(property, type, value);
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3790297615_36a5712055d1a772() {
    this.initMetadata();
    try {
      this.testPDFAIdentification();
    } finally {
    }
  }
}
