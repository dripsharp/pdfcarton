// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Afm;

public class LigatureTest {
internal virtual void testLigature() {
global::DripSharp.PdfCarton.Fonts.Afm.Ligature ligature = new global::DripSharp.PdfCarton.Fonts.Afm.Ligature(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "successor"), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "ligature"));
global::DripSharp.Testing.JavaAssertions.Equal("successor", ligature.GetSuccessor(), null);
global::DripSharp.Testing.JavaAssertions.Equal("ligature", ligature.GetLigature(), null);
}

[Xunit.Fact]
public void __Upstream_3847340733_d0b397b2be09c63b()
{
        try
        {
            this.testLigature();
        }
        finally
        {
        }
}
}
