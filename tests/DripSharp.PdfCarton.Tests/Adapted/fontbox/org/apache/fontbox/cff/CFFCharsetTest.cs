// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Cff;

public class CFFCharsetTest {
internal virtual void testEmbeddedCharset() {
global::DripSharp.PdfCarton.Fonts.Cff.EmbeddedCharset embeddedCharsetCID = new global::DripSharp.PdfCarton.Fonts.Cff.EmbeddedCharset(true);
global::DripSharp.Testing.JavaAssertions.True(embeddedCharsetCID.IsCIDFont(), null);
embeddedCharsetCID.AddCID(10, 20);
global::DripSharp.Testing.JavaAssertions.Equal(10, embeddedCharsetCID.GetGIDForCID(20), null);
global::DripSharp.Testing.JavaAssertions.Equal(20, embeddedCharsetCID.GetCIDForGID(10), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, embeddedCharsetCID.GetGIDForCID(99), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, embeddedCharsetCID.GetCIDForGID(99), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => embeddedCharsetCID.GetSIDForGID(0), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => embeddedCharsetCID.GetGIDForSID(0), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => embeddedCharsetCID.AddSID(0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "test")), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => embeddedCharsetCID.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "test")), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => embeddedCharsetCID.GetNameForGID(0), null);
global::DripSharp.PdfCarton.Fonts.Cff.EmbeddedCharset embeddedCharsetType1 = new global::DripSharp.PdfCarton.Fonts.Cff.EmbeddedCharset(false);
global::DripSharp.Testing.JavaAssertions.False(embeddedCharsetType1.IsCIDFont(), null);
embeddedCharsetType1.AddSID(10, 20, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "test"));
global::DripSharp.Testing.JavaAssertions.Equal(20, embeddedCharsetType1.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "test")), null);
global::DripSharp.Testing.JavaAssertions.Equal(10, embeddedCharsetType1.GetGIDForSID(20), null);
global::DripSharp.Testing.JavaAssertions.Equal(20, embeddedCharsetType1.GetSIDForGID(10), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, embeddedCharsetType1.GetGIDForSID(99), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, embeddedCharsetType1.GetSIDForGID(99), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => embeddedCharsetType1.GetCIDForGID(0), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => embeddedCharsetType1.GetGIDForCID(0), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => embeddedCharsetType1.AddCID(0, 0), null);
}

internal virtual void testCFFCharsetCID() {
global::DripSharp.PdfCarton.Fonts.Cff.CFFCharsetCID cffCharsetCID = new global::DripSharp.PdfCarton.Fonts.Cff.CFFCharsetCID();
global::DripSharp.Testing.JavaAssertions.True(cffCharsetCID.IsCIDFont(), null);
cffCharsetCID.AddCID(10, 20);
global::DripSharp.Testing.JavaAssertions.Equal(10, cffCharsetCID.GetGIDForCID(20), null);
global::DripSharp.Testing.JavaAssertions.Equal(20, cffCharsetCID.GetCIDForGID(10), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, cffCharsetCID.GetGIDForCID(99), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, cffCharsetCID.GetCIDForGID(99), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => cffCharsetCID.GetSIDForGID(0), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => cffCharsetCID.GetGIDForSID(0), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => cffCharsetCID.AddSID(0, 0, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "test")), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => cffCharsetCID.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "test")), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => cffCharsetCID.GetNameForGID(0), null);
}

internal virtual void testCFFCharsetType1() {
global::DripSharp.PdfCarton.Fonts.Cff.CFFCharsetType1 cffCharsetType1 = new global::DripSharp.PdfCarton.Fonts.Cff.CFFCharsetType1();
global::DripSharp.Testing.JavaAssertions.False(cffCharsetType1.IsCIDFont(), null);
cffCharsetType1.AddSID(10, 20, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "test"));
global::DripSharp.Testing.JavaAssertions.Equal(20, cffCharsetType1.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "test")), null);
global::DripSharp.Testing.JavaAssertions.Equal(10, cffCharsetType1.GetGIDForSID(20), null);
global::DripSharp.Testing.JavaAssertions.Equal(20, cffCharsetType1.GetSIDForGID(10), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, cffCharsetType1.GetGIDForSID(99), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, cffCharsetType1.GetSIDForGID(99), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => cffCharsetType1.GetCIDForGID(0), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => cffCharsetType1.GetGIDForCID(0), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => cffCharsetType1.AddCID(0, 0), null);
}

internal virtual void testCFFExpertCharset() {
global::DripSharp.PdfCarton.Fonts.Cff.CFFExpertCharset cffExpertCharset = global::DripSharp.PdfCarton.Fonts.Cff.CFFExpertCharset.GetInstance();
global::DripSharp.Testing.JavaAssertions.Equal(0, cffExpertCharset.GetSIDForGID(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, cffExpertCharset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", ".notdef")), null);
global::DripSharp.Testing.JavaAssertions.Equal(".notdef", cffExpertCharset.GetNameForGID(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(253, cffExpertCharset.GetSIDForGID(32), null);
global::DripSharp.Testing.JavaAssertions.Equal(253, cffExpertCharset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "asuperior")), null);
global::DripSharp.Testing.JavaAssertions.Equal("asuperior", cffExpertCharset.GetNameForGID(32), null);
global::DripSharp.Testing.JavaAssertions.Equal(240, cffExpertCharset.GetSIDForGID(17), null);
global::DripSharp.Testing.JavaAssertions.Equal(240, cffExpertCharset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "oneoldstyle")), null);
global::DripSharp.Testing.JavaAssertions.Equal("oneoldstyle", cffExpertCharset.GetNameForGID(17), null);
global::DripSharp.Testing.JavaAssertions.Equal(347, cffExpertCharset.GetSIDForGID(134), null);
global::DripSharp.Testing.JavaAssertions.Equal(347, cffExpertCharset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Agravesmall")), null);
global::DripSharp.Testing.JavaAssertions.Equal("Agravesmall", cffExpertCharset.GetNameForGID(134), null);
}

internal virtual void testCFFExpertSubsetCharset() {
global::DripSharp.PdfCarton.Fonts.Cff.CFFExpertSubsetCharset cffExpertSubsetCharset = global::DripSharp.PdfCarton.Fonts.Cff.CFFExpertSubsetCharset.GetInstance();
global::DripSharp.Testing.JavaAssertions.Equal(0, cffExpertSubsetCharset.GetSIDForGID(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, cffExpertSubsetCharset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", ".notdef")), null);
global::DripSharp.Testing.JavaAssertions.Equal(".notdef", cffExpertSubsetCharset.GetNameForGID(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(246, cffExpertSubsetCharset.GetSIDForGID(19), null);
global::DripSharp.Testing.JavaAssertions.Equal(246, cffExpertSubsetCharset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "sevenoldstyle")), null);
global::DripSharp.Testing.JavaAssertions.Equal("sevenoldstyle", cffExpertSubsetCharset.GetNameForGID(19), null);
global::DripSharp.Testing.JavaAssertions.Equal(324, cffExpertSubsetCharset.GetSIDForGID(61), null);
global::DripSharp.Testing.JavaAssertions.Equal(324, cffExpertSubsetCharset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "onethird")), null);
global::DripSharp.Testing.JavaAssertions.Equal("onethird", cffExpertSubsetCharset.GetNameForGID(61), null);
global::DripSharp.Testing.JavaAssertions.Equal(345, cffExpertSubsetCharset.GetSIDForGID(85), null);
global::DripSharp.Testing.JavaAssertions.Equal(345, cffExpertSubsetCharset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "periodinferior")), null);
global::DripSharp.Testing.JavaAssertions.Equal("periodinferior", cffExpertSubsetCharset.GetNameForGID(85), null);
}

internal virtual void testCFFISOAdobeCharset() {
global::DripSharp.PdfCarton.Fonts.Cff.CFFISOAdobeCharset cffISOAdobeCharset = global::DripSharp.PdfCarton.Fonts.Cff.CFFISOAdobeCharset.GetInstance();
global::DripSharp.Testing.JavaAssertions.Equal(0, cffISOAdobeCharset.GetSIDForGID(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, cffISOAdobeCharset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", ".notdef")), null);
global::DripSharp.Testing.JavaAssertions.Equal(".notdef", cffISOAdobeCharset.GetNameForGID(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(32, cffISOAdobeCharset.GetSIDForGID(32), null);
global::DripSharp.Testing.JavaAssertions.Equal(32, cffISOAdobeCharset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "question")), null);
global::DripSharp.Testing.JavaAssertions.Equal("question", cffISOAdobeCharset.GetNameForGID(32), null);
global::DripSharp.Testing.JavaAssertions.Equal(76, cffISOAdobeCharset.GetSIDForGID(76), null);
global::DripSharp.Testing.JavaAssertions.Equal(76, cffISOAdobeCharset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "k")), null);
global::DripSharp.Testing.JavaAssertions.Equal("k", cffISOAdobeCharset.GetNameForGID(76), null);
global::DripSharp.Testing.JavaAssertions.Equal(218, cffISOAdobeCharset.GetSIDForGID(218), null);
global::DripSharp.Testing.JavaAssertions.Equal(218, cffISOAdobeCharset.GetSID(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "odieresis")), null);
global::DripSharp.Testing.JavaAssertions.Equal("odieresis", cffISOAdobeCharset.GetNameForGID(218), null);
}

[Xunit.Fact]
public void __Upstream_3738988835_deb7980cdf212583()
{
        try
        {
            this.testCFFCharsetCID();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2592786268_1d1583f99f32ee64()
{
        try
        {
            this.testCFFCharsetType1();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3813013713_1906543b1dce6dea()
{
        try
        {
            this.testCFFExpertCharset();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1001191567_954d464dc5fd630f()
{
        try
        {
            this.testCFFExpertSubsetCharset();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2782742225_f9b47569bef9b317()
{
        try
        {
            this.testCFFISOAdobeCharset();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2755415152_6555473ed2bb70b3()
{
        try
        {
            this.testEmbeddedCharset();
        }
        finally
        {
        }
}
}
