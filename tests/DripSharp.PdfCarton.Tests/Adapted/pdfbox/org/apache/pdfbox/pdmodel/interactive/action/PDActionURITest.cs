// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Action;

public class PDActionURITest {
  internal virtual void testUTF8URI() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI actionURI
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI();
    global::DripSharp.Testing.JavaAssertions.Null(actionURI.GetURI(), null);
    actionURI.SetURI(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "http://\u00E7\u00B5\u201E\u00E5\u0152\u00B6\u00E6\u203A\u00BF\u00E7\u00B6\u017D.com/"));
    global::DripSharp.Testing.JavaAssertions.Equal("http://\u7D4C\u55B6\u627F\u7D99.com/",
      actionURI.GetURI(), null);
  }

  internal virtual void testUTF16BEURI() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI actionURI
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI();
    global::DripSharp.PdfCarton.Cos.COSString utf16URI
      = global::DripSharp.PdfCarton.Cos.COSString.ParseHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("FEFF0068007400740070003A002F002F00770077",
      "0077002E006E00610070002E006500640075002F0063006100740061006C006F006700"),
      "2F00310031003100340030002E00680074006D006C")));
    actionURI.GetCOSObject().SetItem(global::DripSharp.PdfCarton.Cos.COSName.Uri, utf16URI);
    global::DripSharp.Testing.JavaAssertions.Equal("http://www.nap.edu/catalog/11140.html",
      actionURI.GetURI(), null);
  }

  internal virtual void testUTF16LEURI() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI actionURI
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI();
    global::DripSharp.PdfCarton.Cos.COSString utf16URI
      = global::DripSharp.PdfCarton.Cos.COSString.ParseHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "FFFE68007400740070003A00"));
    actionURI.GetCOSObject().SetItem(global::DripSharp.PdfCarton.Cos.COSName.Uri, utf16URI);
    global::DripSharp.Testing.JavaAssertions.Equal("http:", actionURI.GetURI(), null);
  }

  internal virtual void testUTF7URI() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI actionURI
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI();
    actionURI.SetURI(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "http://pdfbox.apache.org/"));
    global::DripSharp.Testing.JavaAssertions.Equal("http://pdfbox.apache.org/", actionURI.GetURI(),
      null);
  }

  [Xunit.Fact]
  public void __Upstream_2298623439_118f23d8c8bc48cd() {
    try {
      this.testUTF16BEURI();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2307858649_53e6a2b970358b33() {
    try {
      this.testUTF16LEURI();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0689851114_b111e30e25a8ceea() {
    try {
      this.testUTF7URI();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0689880905_b2c8f36bbb46f7e5() {
    try {
      this.testUTF8URI();
    } finally {
    }
  }
}
