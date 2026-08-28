// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel;

public class PageModeTest {
  internal virtual void fromStringInputNotNullOutputNotNull() {
    string value = "FullScreen";
    global::DripSharp.PdfCarton.Pdmodel.PageMode retval
      = global::DripSharp.PdfCarton.Pdmodel.PageMode.FromString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      value));
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.PageMode.FullScreen,
      retval, null);
  }

  internal virtual void fromStringInputNotNullOutputNotNull2() {
    string value = "UseThumbs";
    global::DripSharp.PdfCarton.Pdmodel.PageMode retval
      = global::DripSharp.PdfCarton.Pdmodel.PageMode.FromString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      value));
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.PageMode.UseThumbs,
      retval, null);
  }

  internal virtual void fromStringInputNotNullOutputNotNull3() {
    string value = "UseOC";
    global::DripSharp.PdfCarton.Pdmodel.PageMode retval
      = global::DripSharp.PdfCarton.Pdmodel.PageMode.FromString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      value));
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.PageMode.UseOptionalContent,
      retval, null);
  }

  internal virtual void fromStringInputNotNullOutputNotNull4() {
    string value = "UseNone";
    global::DripSharp.PdfCarton.Pdmodel.PageMode retval
      = global::DripSharp.PdfCarton.Pdmodel.PageMode.FromString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      value));
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.PageMode.UseNone,
      retval, null);
  }

  internal virtual void fromStringInputNotNullOutputNotNull5() {
    string value = "UseAttachments";
    global::DripSharp.PdfCarton.Pdmodel.PageMode retval
      = global::DripSharp.PdfCarton.Pdmodel.PageMode.FromString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      value));
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.PageMode.UseAttachments,
      retval, null);
  }

  internal virtual void fromStringInputNotNullOutputNotNull6() {
    string value = "UseOutlines";
    global::DripSharp.PdfCarton.Pdmodel.PageMode retval
      = global::DripSharp.PdfCarton.Pdmodel.PageMode.FromString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      value));
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.PageMode.UseOutlines,
      retval, null);
  }

  internal virtual void fromStringInputNotNullOutputIllegalArgumentException() {
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(()
      => global::DripSharp.PdfCarton.Pdmodel.PageMode.FromString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "")), null);
  }

  internal virtual void fromStringInputNotNullOutputIllegalArgumentException2() {
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(()
      => global::DripSharp.PdfCarton.Pdmodel.PageMode.FromString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Dulacb`ecj")), null);
  }

  internal virtual void stringValueOutputNotNull() {
    global::DripSharp.PdfCarton.Pdmodel.PageMode objectUnderTest
      = global::DripSharp.PdfCarton.Pdmodel.PageMode.UseOptionalContent;
    string retval = objectUnderTest.StringValue();
    global::DripSharp.Testing.JavaAssertions.Equal("UseOC", retval, null);
  }

  [Xunit.Fact]
  public void __Upstream_3325848072_5118000add226fc5() {
    try {
      this.fromStringInputNotNullOutputIllegalArgumentException();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0022075178_e62d35e645ef2af8() {
    try {
      this.fromStringInputNotNullOutputIllegalArgumentException2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1578538158_902b116738722e11() {
    try {
      this.fromStringInputNotNullOutputNotNull();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1690042692_6d390dbe3b8820a4() {
    try {
      this.fromStringInputNotNullOutputNotNull2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1690042693_972f35e61ca4fde9() {
    try {
      this.fromStringInputNotNullOutputNotNull3();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1690042694_b3a875f44e2f847a() {
    try {
      this.fromStringInputNotNullOutputNotNull4();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1690042695_cdf44edaafa20436() {
    try {
      this.fromStringInputNotNullOutputNotNull5();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1690042696_272a83030f97bd17() {
    try {
      this.fromStringInputNotNullOutputNotNull6();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3406276281_116da97aa3747cc0() {
    try {
      this.stringValueOutputNotNull();
    } finally {
    }
  }
}
