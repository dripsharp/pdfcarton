// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Graphics;

public class PDLineDashPatternTest {
internal virtual void testGetCOSObject() {
global::DripSharp.PdfCarton.Cos.COSArray ar = new global::DripSharp.PdfCarton.Cos.COSArray();
ar.Add(global::DripSharp.PdfCarton.Cos.COSInteger.One);
ar.Add(global::DripSharp.PdfCarton.Cos.COSInteger.Two);
global::DripSharp.PdfCarton.Pdmodel.Graphics.PDLineDashPattern dash = new global::DripSharp.PdfCarton.Pdmodel.Graphics.PDLineDashPattern(ar, 3);
global::DripSharp.PdfCarton.Cos.COSArray dashBase = (global::DripSharp.PdfCarton.Cos.COSArray)(dash.GetCOSObject()!);
global::DripSharp.PdfCarton.Cos.COSArray dashArray = (global::DripSharp.PdfCarton.Cos.COSArray)(dashBase.GetObject(0)!);
global::DripSharp.Testing.JavaAssertions.Equal(2, dashBase.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, dashArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSFloat.One, dashArray.Get(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat((float)(2)), dashArray.Get(1), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.Three, dashBase.Get(1), null);
(global::DripSharp.Runtime.JavaCompat.@out).WriteLine(dash);
}

[Xunit.Fact]
public void __Upstream_3571534498_b133dca356eec558()
{
        try
        {
            this.testGetCOSObject();
        }
        finally
        {
        }
}
}
