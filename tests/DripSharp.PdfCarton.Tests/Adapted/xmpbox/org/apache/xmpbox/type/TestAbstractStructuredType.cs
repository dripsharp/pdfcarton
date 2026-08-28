// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Type;

public class TestAbstractStructuredType {
  public class MyStructuredType : global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType {
    [global::DripSharp.PdfCarton.Xmp.Type.PropertyTypeAttribute("Text", "Simple")]
    public const string Mytext = "my-text";

    [global::DripSharp.PdfCarton.Xmp.Type.PropertyTypeAttribute("Date", "Simple")]
    public const string Mydate = "my-date";

    internal MyStructuredType(global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata,
      string namespaceURI, string fieldPrefix) : base(metadata,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", namespaceURI),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldPrefix),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "structuredPN")) {

    }
  }

  internal readonly global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
    = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();

  public const string MyNs = "http://www.apache.org/test#";

  public const string MyPrefix = "test";

  protected internal readonly global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyStructuredType St;

  internal virtual void validate() {
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyNs,
      this.St.GetNamespace(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyPrefix,
      this.St.GetPrefix(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyPrefix,
      this.St.GetPrefix(), null);
  }

  internal virtual void testNonExistingProperty() {
    global::DripSharp.Testing.JavaAssertions.Null(this.St.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "NOT_EXISTING")), null);
  }

  internal virtual void testNotValuatedPropertyProperty() {
    global::DripSharp.Testing.JavaAssertions.Null(this.St.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyStructuredType.Mytext)),
      null);
  }

  internal virtual void testValuatedTextProperty() {
    string s = "my value";
    this.St.AddSimpleProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyStructuredType.Mytext), s);
    global::DripSharp.Testing.JavaAssertions.Equal(s,
      this.St.GetPropertyValueAsString(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyStructuredType.Mytext)),
      null);
    global::DripSharp.Testing.JavaAssertions.Null(this.St.GetPropertyValueAsString(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyStructuredType.Mydate)),
      null);
    global::DripSharp.Testing.JavaAssertions.NotNull(this.St.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyStructuredType.Mytext)),
      null);
  }

  internal virtual void testValuatedDateProperty() {
    global::System.DateTimeOffset? c = global::System.DateTimeOffset.Now;
    this.St.AddSimpleProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyStructuredType.Mydate), c);
    global::DripSharp.Testing.JavaAssertions.Equal(c,
      this.St.GetDatePropertyAsCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyStructuredType.Mydate)),
      null);
    global::DripSharp.Testing.JavaAssertions.Null(this.St.GetDatePropertyAsCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyStructuredType.Mytext)),
      null);
    global::DripSharp.Testing.JavaAssertions.NotNull(this.St.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyStructuredType.Mydate)),
      null);
  }

  [Xunit.Fact]
  public void __Upstream_0125417339_6c2d0ec0ca7c5818() {
    try {
      this.testNonExistingProperty();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0286764145_1779d3c7c070f4af() {
    try {
      this.testNotValuatedPropertyProperty();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2297067003_e4ffcd2b74a40329() {
    try {
      this.testValuatedDateProperty();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3636452474_fd8c6c49503b71e9() {
    try {
      this.testValuatedTextProperty();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0726210838_5848c22cbd312611() {
    try {
      this.validate();
    } finally {
    }
  }

  public TestAbstractStructuredType() {
    this.St
      = new global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyStructuredType(this.xmp,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyNs),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Type.TestAbstractStructuredType.MyPrefix));
  }
}
