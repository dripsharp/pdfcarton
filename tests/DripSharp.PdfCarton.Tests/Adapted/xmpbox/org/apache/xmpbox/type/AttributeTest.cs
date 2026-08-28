// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Type;

public class AttributeTest {
  internal virtual void testAtt() {
    string nsUri = "nsUri";
    string localName = "localName";
    string value = "value";
    global::DripSharp.PdfCarton.Xmp.Type.Attribute att
      = new global::DripSharp.PdfCarton.Xmp.Type.Attribute(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      nsUri), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", localName),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", value));
    global::DripSharp.Testing.JavaAssertions.Equal(nsUri, att.GetNamespace(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(localName, att.GetName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(value, att.GetValue(), null);
    string nsUri2 = "nsUri2";
    string localName2 = "localName2";
    string value2 = "value2";
    att.SetNsURI(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", nsUri2));
    att.SetName(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", localName2));
    att.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", value2));
    global::DripSharp.Testing.JavaAssertions.Equal(nsUri2, att.GetNamespace(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(localName2, att.GetName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(value2, att.GetValue(), null);
  }

  internal virtual void testAttWithoutPrefix() {
    string nsUri = "nsUri";
    string localName = "localName";
    string value = "value";
    global::DripSharp.PdfCarton.Xmp.Type.Attribute att
      = new global::DripSharp.PdfCarton.Xmp.Type.Attribute(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      nsUri), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", localName),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", value));
    global::DripSharp.Testing.JavaAssertions.Equal(nsUri, att.GetNamespace(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(localName, att.GetName(), null);
    att
      = new global::DripSharp.PdfCarton.Xmp.Type.Attribute(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      nsUri), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", localName),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", value));
    global::DripSharp.Testing.JavaAssertions.Equal(nsUri, att.GetNamespace(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(localName, att.GetName(), null);
  }

  [Xunit.Fact]
  public void __Upstream_0724999343_b1545e70abfaba50() {
    try {
      this.testAtt();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0012636427_c04ccbdbc793b4d0() {
    try {
      this.testAttWithoutPrefix();
    } finally {
    }
  }
}
