// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Cff;

public class CFFEncodingTest {
internal virtual void testCFFExpertEncoding() {
global::DripSharp.PdfCarton.Fonts.Cff.CFFExpertEncoding cffExpertEncoding = global::DripSharp.PdfCarton.Fonts.Cff.CFFExpertEncoding.GetInstance();
global::DripSharp.Testing.JavaAssertions.Equal(".notdef", cffExpertEncoding.GetName(0), null);
global::DripSharp.Testing.JavaAssertions.Equal("space", cffExpertEncoding.GetName(32), null);
global::DripSharp.Testing.JavaAssertions.Equal("Psmall", cffExpertEncoding.GetName(112), null);
global::DripSharp.Testing.JavaAssertions.Equal("Ucircumflexsmall", cffExpertEncoding.GetName(251), null);
global::DripSharp.Testing.JavaAssertions.Equal(32, cffExpertEncoding.GetCode(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "space")), null);
global::DripSharp.Testing.JavaAssertions.Equal(112, cffExpertEncoding.GetCode(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Psmall")), null);
global::DripSharp.Testing.JavaAssertions.Equal(251, cffExpertEncoding.GetCode(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Ucircumflexsmall")), null);
}

internal virtual void testCFFStandardEncoding() {
global::DripSharp.PdfCarton.Fonts.Cff.CFFStandardEncoding cffStandardEncoding = global::DripSharp.PdfCarton.Fonts.Cff.CFFStandardEncoding.GetInstance();
global::DripSharp.Testing.JavaAssertions.Equal(".notdef", cffStandardEncoding.GetName(0), null);
global::DripSharp.Testing.JavaAssertions.Equal("space", cffStandardEncoding.GetName(32), null);
global::DripSharp.Testing.JavaAssertions.Equal("p", cffStandardEncoding.GetName(112), null);
global::DripSharp.Testing.JavaAssertions.Equal("germandbls", cffStandardEncoding.GetName(251), null);
global::DripSharp.Testing.JavaAssertions.Equal(32, cffStandardEncoding.GetCode(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "space")), null);
global::DripSharp.Testing.JavaAssertions.Equal(112, cffStandardEncoding.GetCode(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "p")), null);
global::DripSharp.Testing.JavaAssertions.Equal(251, cffStandardEncoding.GetCode(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "germandbls")), null);
}

[Xunit.Fact]
public void __Upstream_2514060910_292f735dcc7377cc()
{
        try
        {
            this.testCFFExpertEncoding();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3851977665_c0f51653ea287de9()
{
        try
        {
            this.testCFFStandardEncoding();
        }
        finally
        {
        }
}
}
