// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Graphics.Color;

public class PDDeviceCMYKTest {
internal virtual void testCMYK() {
global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceCMYK.Instance = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceCMYKTest.CustomDeviceCMYK();
}

internal class CustomDeviceCMYK : global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceCMYK {
protected internal CustomDeviceCMYK() {}
}

internal virtual void testPDFBox5787() {
global::DripSharp.Runtime.JavaColorConvertOp colorConvertOp = new global::DripSharp.Runtime.JavaColorConvertOp();
string resourceName = "/org/apache/pdfbox/resources/icc/CGATS001Compat-v2-micro.icc";
global::DripSharp.Runtime.JavaIccProfile iccProfile;
using (global::System.IO.Stream @is = new global::System.IO.BufferedStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceCMYK), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", resourceName)))) {
iccProfile = global::DripSharp.Runtime.PdfCartonFontCompat.GetIccProfile(@is);
}
global::DripSharp.Runtime.JavaIccColorSpace icc_ColorSpace = new global::DripSharp.Runtime.JavaIccColorSpace(iccProfile);
global::DripSharp.Runtime.JavaRaster raster = global::DripSharp.Runtime.PdfCartonFontCompat.CreateInterleavedRaster(global::DripSharp.Runtime.PdfCartonFontCompat.DATA_BUFFER_TYPE_BYTE, 1, 1, 4, new global::DripSharp.Runtime.JavaPoint(0, 0));
global::DripSharp.Runtime.JavaColorModel colorModel = global::DripSharp.Runtime.PdfCartonFontCompat.ComponentColorModel(icc_ColorSpace, false, false, global::DripSharp.Runtime.PdfCartonTransparency.OPAQUE, raster.GetDataBuffer().DataType);
global::SkiaSharp.SKBitmap src = global::DripSharp.Runtime.PdfCartonFontCompat.CreateImage(colorModel, raster, false, (global::DripSharp.Runtime.JavaHashtable<object, object>)default!);
global::SkiaSharp.SKBitmap dest = global::DripSharp.Runtime.PdfCartonFontCompat.CreateBitmap(raster.Width, raster.Height, global::DripSharp.Runtime.PdfCartonFontCompat.TYPE_INT_RGB);
colorConvertOp.Filter(src, dest);
}

[Xunit.Fact]
public void __Upstream_1000164494_7fdd74d09b1673b7()
{
        try
        {
            this.testCMYK();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1724610124_9988fdc18da1742f()
{
        try
        {
            this.testPDFBox5787();
        }
        finally
        {
        }
}
}
