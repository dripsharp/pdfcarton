// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Graphics.Color;

public class PDICCBasedTest {
internal virtual void testConstructor() {
global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDICCBased iccBased = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDICCBased(doc);
global::DripSharp.Testing.JavaAssertions.Equal("ICCBased", iccBased.GetName(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(iccBased.GetPDStream(), null);
}

[Xunit.Fact]
public void __Upstream_4194569224_6eb6955ea3260368()
{
        try
        {
            this.testConstructor();
        }
        finally
        {
        }
}
}
