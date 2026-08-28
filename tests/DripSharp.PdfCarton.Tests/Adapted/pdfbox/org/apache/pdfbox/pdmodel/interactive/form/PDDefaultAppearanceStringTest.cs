// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class PDDefaultAppearanceStringTest {
  private global::DripSharp.PdfCarton.Pdmodel.PDResources resources = null!;

  private global::DripSharp.PdfCarton.Cos.COSName fontResourceName = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font helvetica = null!;

  internal virtual void setUp() {
    this.resources = new global::DripSharp.PdfCarton.Pdmodel.PDResources();
    this.helvetica
      = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica);
    this.fontResourceName = this.resources.Add(this.helvetica);
  }

  internal virtual void testParseDAString() {
    global::DripSharp.PdfCarton.Cos.COSString sampleString
      = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("/",
      this.fontResourceName.GetName()), " 12 Tf 0.019 0.305 0.627 rg")));
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDDefaultAppearanceString defaultAppearanceString
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDDefaultAppearanceString(sampleString,
      this.resources);
    global::DripSharp.Testing.JavaAssertions.Equal((double)(12),
      (double)(defaultAppearanceString.GetFontSize()), null, 0.001D);
    global::DripSharp.Testing.JavaAssertions.Equal(this.helvetica,
      defaultAppearanceString.getFont(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance,
      defaultAppearanceString.getFontColor().GetColorSpace(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(0.019D,
      (double)(defaultAppearanceString.getFontColor().GetComponents()[0]), null, 1.0E-4D);
    global::DripSharp.Testing.JavaAssertions.Equal(0.305D,
      (double)(defaultAppearanceString.getFontColor().GetComponents()[1]), null, 1.0E-4D);
    global::DripSharp.Testing.JavaAssertions.Equal(0.627D,
      (double)(defaultAppearanceString.getFontColor().GetComponents()[2]), null, 1.0E-4D);
  }

  internal virtual void testFontResourceUnavailable() {
    global::DripSharp.PdfCarton.Cos.COSString sampleString
      = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "/Helvetica 12 Tf 0.019 0.305 0.627 rg"));
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => {
        new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDDefaultAppearanceString(sampleString,
        this.resources);
      }, null);
  }

  internal virtual void testWrongNumberOfColorArguments() {
    global::DripSharp.PdfCarton.Cos.COSString sampleString
      = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "/Helvetica 12 Tf 0.305 0.627 rg"));
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => {
        new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDDefaultAppearanceString(sampleString,
        this.resources);
      }, null);
  }

  [Xunit.Fact]
  public void __Upstream_1656175009_8e14b987e6278a50() {
    this.setUp();
    try {
      this.testFontResourceUnavailable();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1496015663_f3620e6c1aef4044() {
    this.setUp();
    try {
      this.testParseDAString();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3310358126_5797e154c6302317() {
    this.setUp();
    try {
      this.testWrongNumberOfColorArguments();
    } finally {
    }
  }
}
