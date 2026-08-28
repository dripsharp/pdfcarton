// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Util;

public class StringUtilTest {
  internal virtual void testSplitOnSpace_happyPath() {
    string[] result
      = global::DripSharp.PdfCarton.Util.StringUtil.SplitOnSpace(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "a b c"));
    global::DripSharp.Testing.JavaAssertions.Equal(new string[] { "a", "b", "c" }, result, null);
  }

  internal virtual void testSplitOnSpace_emptyString() {
    string[] result
      = global::DripSharp.PdfCarton.Util.StringUtil.SplitOnSpace(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      ""));
    global::DripSharp.Testing.JavaAssertions.Equal(new string[] { "" }, result, null);
  }

  internal virtual void testSplitOnSpace_onlySpaces() {
    string[] result
      = global::DripSharp.PdfCarton.Util.StringUtil.SplitOnSpace(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "   "));
    global::DripSharp.Testing.JavaAssertions.Equal(new string[] {  }, result, null);
  }

  internal virtual void testTokenizeOnSpace_happyPath() {
    string[] result
      = global::DripSharp.PdfCarton.Util.StringUtil.TokenizeOnSpace(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "a b c"));
    global::DripSharp.Testing.JavaAssertions.Equal(new string[] { "a", " ", "b", " ", "c" }, result,
      null);
  }

  internal virtual void testTokenizeOnSpace_emptyString() {
    string[] result
      = global::DripSharp.PdfCarton.Util.StringUtil.TokenizeOnSpace(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      ""));
    global::DripSharp.Testing.JavaAssertions.Equal(new string[] { "" }, result, null);
  }

  internal virtual void testTokenizeOnSpace_onlySpaces() {
    string[] result
      = global::DripSharp.PdfCarton.Util.StringUtil.TokenizeOnSpace(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "   "));
    global::DripSharp.Testing.JavaAssertions.Equal(new string[] { " ", " ", " " }, result, null);
  }

  internal virtual void testTokenizeOnSpace_onlySpacesWithText() {
    string[] result
      = global::DripSharp.PdfCarton.Util.StringUtil.TokenizeOnSpace(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "  a  "));
    global::DripSharp.Testing.JavaAssertions.Equal(new string[] { " ", " ", "a", " ", " " }, result,
      null);
  }

  [Xunit.Fact]
  public void __Upstream_1712950046_7fca8da3e95891c6() {
    try {
      this.testSplitOnSpace_emptyString();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2619195013_1fd60e05e6659971() {
    try {
      this.testSplitOnSpace_happyPath();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0445888409_733802c248314f84() {
    try {
      this.testSplitOnSpace_onlySpaces();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0183627065_a3ef4b23d0fdb032() {
    try {
      this.testTokenizeOnSpace_emptyString();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2353916768_8714d6b3f923b9ed() {
    try {
      this.testTokenizeOnSpace_happyPath();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0812197406_7ba33cd068924ff3() {
    try {
      this.testTokenizeOnSpace_onlySpaces();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0196092753_4c5d8155ee5359ed() {
    try {
      this.testTokenizeOnSpace_onlySpacesWithText();
    } finally {
    }
  }
}
