// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Graphics.Color;

public class PDLabTest {
  internal virtual void testLAB() {
    global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDLab pdLab
      = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDLab();
    global::DripSharp.PdfCarton.Cos.COSArray cosArray
      = (global::DripSharp.PdfCarton.Cos.COSArray)(pdLab.GetCOSObject()!);
    global::DripSharp.PdfCarton.Cos.COSDictionary dict
      = (global::DripSharp.PdfCarton.Cos.COSDictionary)(cosArray.GetObject(1)!);
    global::DripSharp.Testing.JavaAssertions.Equal("Lab", pdLab.GetName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(3, pdLab.GetNumberOfComponents(), null);
    global::DripSharp.Testing.JavaAssertions.NotNull(pdLab.GetInitialColor(), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ArrayEquals(new float[] { 0,
        0, 0 }, pdLab.GetInitialColor().GetComponents()), null);
    global::DripSharp.Testing.JavaAssertions.Equal(0.0F, pdLab.GetBlackPoint().GetX(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(0.0F, pdLab.GetBlackPoint().GetY(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(0.0F, pdLab.GetBlackPoint().GetZ(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(1.0F, pdLab.GetWhitepoint().GetX(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(1.0F, pdLab.GetWhitepoint().GetY(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(1.0F, pdLab.GetWhitepoint().GetZ(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(-100.0F, pdLab.GetARange().GetMin(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(100.0F, pdLab.GetARange().GetMax(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(-100.0F, pdLab.GetBRange().GetMin(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(100.0F, pdLab.GetBRange().GetMax(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(0, dict.Size(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "read operations should not change the size of /Lab objects"));
    dict.ToString();
    global::DripSharp.PdfCarton.Pdmodel.Common.PDRange pdRange
      = new global::DripSharp.PdfCarton.Pdmodel.Common.PDRange();
    pdRange.SetMin((float)(-1));
    pdRange.SetMax((float)(2));
    pdLab.SetARange(pdRange);
    pdRange = new global::DripSharp.PdfCarton.Pdmodel.Common.PDRange();
    pdRange.SetMin((float)(3));
    pdRange.SetMax((float)(4));
    pdLab.SetBRange(pdRange);
    global::DripSharp.Testing.JavaAssertions.Equal(-1.0F, pdLab.GetARange().GetMin(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(2.0F, pdLab.GetARange().GetMax(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(3.0F, pdLab.GetBRange().GetMin(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(4.0F, pdLab.GetBRange().GetMax(), null, 0.0F);
    global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDTristimulus pdTristimulus
      = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDTristimulus();
    pdTristimulus.SetX((float)(5));
    pdTristimulus.SetY((float)(6));
    pdTristimulus.SetZ((float)(7));
    pdLab.SetWhitePoint(pdTristimulus);
    pdTristimulus = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDTristimulus();
    pdTristimulus.SetX((float)(8));
    pdTristimulus.SetY((float)(9));
    pdTristimulus.SetZ((float)(10));
    pdLab.SetBlackPoint(pdTristimulus);
    global::DripSharp.Testing.JavaAssertions.Equal(5.0F, pdLab.GetWhitepoint().GetX(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(6.0F, pdLab.GetWhitepoint().GetY(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(7.0F, pdLab.GetWhitepoint().GetZ(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(8.0F, pdLab.GetBlackPoint().GetX(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(9.0F, pdLab.GetBlackPoint().GetY(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.Equal(10.0F, pdLab.GetBlackPoint().GetZ(), null, 0.0F);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ArrayEquals(new float[] { 0,
        0, 3 }, pdLab.GetInitialColor().GetComponents()), null);
  }

  [Xunit.Fact]
  public void __Upstream_0725008283_775af4aa4c8ed679() {
    try {
      this.testLAB();
    } finally {
    }
  }
}
