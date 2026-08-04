// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation;

public class PDTransitionDirectionTest {
internal virtual void getCOSBase() {
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.None, global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionDirection.None.GetCOSBase(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, ((global::DripSharp.PdfCarton.Cos.COSInteger)(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionDirection.LeftToRight.GetCOSBase()!)).IntValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(90, ((global::DripSharp.PdfCarton.Cos.COSInteger)(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionDirection.BottomToTop.GetCOSBase()!)).IntValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(180, ((global::DripSharp.PdfCarton.Cos.COSInteger)(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionDirection.RightToLeft.GetCOSBase()!)).IntValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(270, ((global::DripSharp.PdfCarton.Cos.COSInteger)(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionDirection.TopToBottom.GetCOSBase()!)).IntValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(315, ((global::DripSharp.PdfCarton.Cos.COSInteger)(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionDirection.TopLeftToBottomRight.GetCOSBase()!)).IntValue(), null);
}

[Xunit.Fact]
public void __Upstream_3193313474_b41f74a7533f81cc()
{
        try
        {
            this.getCOSBase();
        }
        finally
        {
        }
}
}
