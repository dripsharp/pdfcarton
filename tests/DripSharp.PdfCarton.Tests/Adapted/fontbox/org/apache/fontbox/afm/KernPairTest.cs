// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Afm;

public class KernPairTest {
internal virtual void testKernPair() {
global::DripSharp.PdfCarton.Fonts.Afm.KernPair kernPair = new global::DripSharp.PdfCarton.Fonts.Afm.KernPair(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "firstKernCharacter"), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "secondKernCharacter"), 10.0F, 20.0F);
global::DripSharp.Testing.JavaAssertions.Equal("firstKernCharacter", kernPair.GetFirstKernCharacter(), null);
global::DripSharp.Testing.JavaAssertions.Equal("secondKernCharacter", kernPair.GetSecondKernCharacter(), null);
global::DripSharp.Testing.JavaAssertions.Equal(10.0F, kernPair.GetX(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(20.0F, kernPair.GetY(), null, 0.0F);
}

[Xunit.Fact]
public void __Upstream_3175317442_e67827d6ce66be80()
{
        try
        {
            this.testKernPair();
        }
        finally
        {
        }
}
}
