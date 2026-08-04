// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Afm;

public class AFMParserTest {
public const string HelveticaAfm = "src/test/resources/afm/Helvetica.afm";

internal virtual void testStartFontMetrics() {
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => new global::DripSharp.PdfCarton.Fonts.Afm.AFMParser(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(global::DripSharp.Runtime.JavaCompat.StringGetBytes("huhu", global::DripSharp.Runtime.JavaStandardCharsets.USASCII))).Parse(), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.Concat("The AFMParser should have thrown an IOException because of a missing ", global::DripSharp.PdfCarton.Fonts.Afm.AFMParser.StartFontMetrics)));
}

internal virtual void testEndFontMetrics() {
using (global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "src/test/resources/afm/NoEndFontMetrics.afm"))) {
global::DripSharp.PdfCarton.Fonts.Afm.AFMParser parser = new global::DripSharp.PdfCarton.Fonts.Afm.AFMParser(@is);
global::System.IO.IOException e = global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => { parser.Parse(); }, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.Runtime.JavaCompat.Concat("The AFMParser should have thrown an IOException because of a missing ", global::DripSharp.PdfCarton.Fonts.Afm.AFMParser.EndFontMetrics)));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(global::DripSharp.Runtime.JavaCompat.ExceptionMessage(e), "Unknown AFM key"), null);
}
}

internal virtual void testMalformedFloat() {
using (global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "src/test/resources/afm/MalformedFloat.afm"))) {
global::DripSharp.PdfCarton.Fonts.Afm.AFMParser parser = new global::DripSharp.PdfCarton.Fonts.Afm.AFMParser(@is);
global::System.IO.IOException e = global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => { parser.Parse(); }, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "The AFMParser should have thrown an IOException because of a malformed float value"));
global::DripSharp.Testing.JavaAssertions.InstanceOf<global::DripSharp.Runtime.JavaNumberFormatException>(global::DripSharp.Runtime.JavaCompat.GetCause(e)!, null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(global::DripSharp.Runtime.JavaCompat.ExceptionMessage(e), "4,1ab"), null);
}
}

internal virtual void testMalformedInteger() {
using (global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "src/test/resources/afm/MalformedInteger.afm"))) {
global::DripSharp.PdfCarton.Fonts.Afm.AFMParser parser = new global::DripSharp.PdfCarton.Fonts.Afm.AFMParser(@is);
global::System.IO.IOException e = global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => { parser.Parse(); }, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "The AFMParser should have thrown an IOException because of a malformed int value"));
global::DripSharp.Testing.JavaAssertions.InstanceOf<global::DripSharp.Runtime.JavaNumberFormatException>(global::DripSharp.Runtime.JavaCompat.GetCause(e)!, null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(global::DripSharp.Runtime.JavaCompat.ExceptionMessage(e), "3.4"), null);
}
}

internal virtual void testHelveticaFontMetrics() {
using (global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.PdfCarton.Fonts.Afm.AFMParserTest.HelveticaAfm))) {
global::DripSharp.PdfCarton.Fonts.Afm.AFMParser parser = new global::DripSharp.PdfCarton.Fonts.Afm.AFMParser(@is);
this.checkHelveticaFontMetrics(parser.Parse());
}
}

internal virtual void testHelveticaCharMetrics() {
using (global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.PdfCarton.Fonts.Afm.AFMParserTest.HelveticaAfm))) {
global::DripSharp.PdfCarton.Fonts.Afm.AFMParser parser = new global::DripSharp.PdfCarton.Fonts.Afm.AFMParser(@is);
global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics fontMetrics = parser.Parse();
this.checkHelveticaCharMetrics(fontMetrics.GetCharMetrics());
}
}

internal virtual void testHelveticaKernPairs() {
using (global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.PdfCarton.Fonts.Afm.AFMParserTest.HelveticaAfm))) {
global::DripSharp.PdfCarton.Fonts.Afm.AFMParser parser = new global::DripSharp.PdfCarton.Fonts.Afm.AFMParser(@is);
global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics fontMetrics = parser.Parse();
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Afm.KernPair> kernPairs = fontMetrics.GetKernPairs();
global::DripSharp.Testing.JavaAssertions.Equal(2705, global::DripSharp.Runtime.JavaCompat.CollectionCount(kernPairs), null);
this.checkKernPair(kernPairs, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "A"), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Ucircumflex"), (float)(-50), (float)(0));
this.checkKernPair(kernPairs, global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "W"), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "agrave"), (float)(-40), (float)(0));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(fontMetrics.GetKernPairs0()), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(fontMetrics.GetKernPairs1()), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(fontMetrics.GetComposites()), null);
}
}

internal virtual void testHelveticaFontMetricsReducedDataset() {
using (global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.PdfCarton.Fonts.Afm.AFMParserTest.HelveticaAfm))) {
global::DripSharp.PdfCarton.Fonts.Afm.AFMParser parser = new global::DripSharp.PdfCarton.Fonts.Afm.AFMParser(@is);
this.checkHelveticaFontMetrics(parser.Parse(true));
}
}

internal virtual void testHelveticaCharMetricsReducedDataset() {
using (global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.PdfCarton.Fonts.Afm.AFMParserTest.HelveticaAfm))) {
global::DripSharp.PdfCarton.Fonts.Afm.AFMParser parser = new global::DripSharp.PdfCarton.Fonts.Afm.AFMParser(@is);
global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics fontMetrics = parser.Parse(true);
this.checkHelveticaCharMetrics(fontMetrics.GetCharMetrics());
}
}

internal virtual void testHelveticaKernPairsReducedDataset() {
using (global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.OpenFileInput(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", global::DripSharp.PdfCarton.Fonts.Afm.AFMParserTest.HelveticaAfm))) {
global::DripSharp.PdfCarton.Fonts.Afm.AFMParser parser = new global::DripSharp.PdfCarton.Fonts.Afm.AFMParser(@is);
global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics fontMetrics = parser.Parse(true);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(fontMetrics.GetKernPairs()), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(fontMetrics.GetKernPairs0()), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(fontMetrics.GetKernPairs1()), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(fontMetrics.GetComposites()), null);
}
}

private void checkHelveticaCharMetrics(global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Afm.CharMetric> charMetrics) {
global::DripSharp.Testing.JavaAssertions.Equal(315, global::DripSharp.Runtime.JavaCompat.CollectionCount(charMetrics), null);
global::DripSharp.Runtime.JavaOptional<global::DripSharp.PdfCarton.Fonts.Afm.CharMetric> space = global::DripSharp.Runtime.JavaCompat.FindFirstOptional(global::DripSharp.Runtime.JavaCompat.StreamFilter(global::DripSharp.Runtime.JavaCompat.Stream(charMetrics), (c) => global::DripSharp.Runtime.JavaCompat.Equals("space", c.GetName())));
global::DripSharp.Testing.JavaAssertions.True(space.IsPresent(), null);
global::DripSharp.PdfCarton.Fonts.Afm.CharMetric spaceCharMetric = space.Get();
global::DripSharp.Testing.JavaAssertions.Equal(278.0F, spaceCharMetric.GetWx(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(32, spaceCharMetric.GetCharacterCode(), null);
this.checkBBox(spaceCharMetric.GetBoundingBox(), (float)(0), (float)(0), (float)(0), (float)(0));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(spaceCharMetric.GetLigatures()), null);
global::DripSharp.Testing.JavaAssertions.Null(spaceCharMetric.GetW(), null);
global::DripSharp.Testing.JavaAssertions.Null(spaceCharMetric.GetW0(), null);
global::DripSharp.Testing.JavaAssertions.Null(spaceCharMetric.GetW1(), null);
global::DripSharp.Testing.JavaAssertions.Null(spaceCharMetric.GetVv(), null);
global::DripSharp.Runtime.JavaOptional<global::DripSharp.PdfCarton.Fonts.Afm.CharMetric> ring = global::DripSharp.Runtime.JavaCompat.FindFirstOptional(global::DripSharp.Runtime.JavaCompat.StreamFilter(global::DripSharp.Runtime.JavaCompat.Stream(charMetrics), (c) => global::DripSharp.Runtime.JavaCompat.Equals("ring", c.GetName())));
global::DripSharp.Testing.JavaAssertions.True(ring.IsPresent(), null);
global::DripSharp.PdfCarton.Fonts.Afm.CharMetric ringCharMetric = ring.Get();
global::DripSharp.Testing.JavaAssertions.Equal(333.0F, ringCharMetric.GetWx(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(202, ringCharMetric.GetCharacterCode(), null);
this.checkBBox(ringCharMetric.GetBoundingBox(), (float)(75), (float)(572), (float)(259), (float)(756));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(ringCharMetric.GetLigatures()), null);
global::DripSharp.Testing.JavaAssertions.Null(ringCharMetric.GetW(), null);
global::DripSharp.Testing.JavaAssertions.Null(ringCharMetric.GetW0(), null);
global::DripSharp.Testing.JavaAssertions.Null(ringCharMetric.GetW1(), null);
global::DripSharp.Testing.JavaAssertions.Null(ringCharMetric.GetVv(), null);
}

private void checkHelveticaFontMetrics(global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics fontMetrics) {
global::DripSharp.Testing.JavaAssertions.Equal(4.1F, fontMetrics.GetAFMVersion(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal("Helvetica", fontMetrics.GetFontName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Helvetica", fontMetrics.GetFullName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Helvetica", fontMetrics.GetFamilyName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Medium", fontMetrics.GetWeight(), null);
this.checkBBox(fontMetrics.GetFontBBox(), -166.0F, -225.0F, 1000.0F, 931.0F);
global::DripSharp.Testing.JavaAssertions.Equal("002.000", fontMetrics.GetFontVersion(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Copyright (c) 1985, 1987, 1989, 1990, 1997 Adobe Systems Incorporated.  All Rights Reserved.Helvetica is a trademark of Linotype-Hell AG and/or its subsidiaries.", fontMetrics.GetNotice(), null);
global::DripSharp.Testing.JavaAssertions.Equal("AdobeStandardEncoding", fontMetrics.GetEncodingScheme(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, fontMetrics.GetMappingScheme(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, fontMetrics.GetEscChar(), null);
global::DripSharp.Testing.JavaAssertions.Equal("ExtendedRoman", fontMetrics.GetCharacterSet(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, fontMetrics.GetCharacters(), null);
global::DripSharp.Testing.JavaAssertions.True(fontMetrics.GetIsBaseFont(), null);
global::DripSharp.Testing.JavaAssertions.Null(fontMetrics.GetVVector(), null);
global::DripSharp.Testing.JavaAssertions.False(fontMetrics.GetIsFixedV(), null);
global::DripSharp.Testing.JavaAssertions.Equal(718.0F, fontMetrics.GetCapHeight(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(523.0F, fontMetrics.GetXHeight(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(718.0F, fontMetrics.GetAscender(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(-207.0F, fontMetrics.GetDescender(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(76.0F, fontMetrics.GetStandardHorizontalWidth(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(88.0F, fontMetrics.GetStandardVerticalWidth(), null, 0.0F);
global::System.Collections.Generic.IList<string> comments = fontMetrics.GetComments();
global::DripSharp.Testing.JavaAssertions.Equal(4, global::DripSharp.Runtime.JavaCompat.CollectionCount(comments), null);
global::DripSharp.Testing.JavaAssertions.Equal("Copyright (c) 1985, 1987, 1989, 1990, 1997 Adobe Systems Incorporated.  All Rights Reserved.", global::DripSharp.Runtime.JavaCompat.ListGet(comments, 0), null);
global::DripSharp.Testing.JavaAssertions.Equal("UniqueID 43054", global::DripSharp.Runtime.JavaCompat.ListGet(comments, 2), null);
global::DripSharp.Testing.JavaAssertions.Equal(-100.0F, fontMetrics.GetUnderlinePosition(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(50.0F, fontMetrics.GetUnderlineThickness(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(0.0F, fontMetrics.GetItalicAngle(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Null(fontMetrics.GetCharWidth(), null);
global::DripSharp.Testing.JavaAssertions.False(fontMetrics.GetIsFixedPitch(), null);
}

private void checkBBox(global::DripSharp.PdfCarton.Fonts.Util.BoundingBox bBox, float lowerX, float lowerY, float upperX, float upperY) {
global::DripSharp.Testing.JavaAssertions.NotNull(bBox, null);
global::DripSharp.Testing.JavaAssertions.Equal(lowerX, bBox.GetLowerLeftX(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(lowerY, bBox.GetLowerLeftY(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(upperX, bBox.GetUpperRightX(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(upperY, bBox.GetUpperRightY(), null, 0.0F);
}

private void checkKernPair(global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Afm.KernPair> kernPairs, string firstKernChar, string secondKernChar, float x, float y) {
global::DripSharp.Runtime.JavaOptional<global::DripSharp.PdfCarton.Fonts.Afm.KernPair> kernPair = global::DripSharp.Runtime.JavaCompat.FindFirstOptional(global::DripSharp.Runtime.JavaCompat.StreamFilter(global::DripSharp.Runtime.JavaCompat.StreamFilter(global::DripSharp.Runtime.JavaCompat.Stream(kernPairs), (k) => global::DripSharp.Runtime.JavaCompat.Equals(firstKernChar, k.GetFirstKernCharacter())), (k) => global::DripSharp.Runtime.JavaCompat.Equals(secondKernChar, k.GetSecondKernCharacter())));
global::DripSharp.Testing.JavaAssertions.True(kernPair.IsPresent(), null);
global::DripSharp.Testing.JavaAssertions.Equal(x, kernPair.Get().GetX(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(y, kernPair.Get().GetY(), null, 0.0F);
}

[Xunit.Fact]
public void __Upstream_3582781131_410e1d71d70953fe()
{
        try
        {
            this.testEndFontMetrics();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1111395054_e6fc38871c1dd1ff()
{
        try
        {
            this.testHelveticaCharMetrics();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0339911016_3364426f2a7bcfe4()
{
        try
        {
            this.testHelveticaCharMetricsReducedDataset();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0103462869_eecefff6015dd2e9()
{
        try
        {
            this.testHelveticaFontMetrics();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1450094095_747e34df4e0b1773()
{
        try
        {
            this.testHelveticaFontMetricsReducedDataset();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2470891524_5bbfc4c6155e682a()
{
        try
        {
            this.testHelveticaKernPairs();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3553183742_b2f2bc6edae127cd()
{
        try
        {
            this.testHelveticaKernPairsReducedDataset();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0221691027_1282cbb067aa1abd()
{
        try
        {
            this.testMalformedFloat();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1021209013_334e299826bfdc2f()
{
        try
        {
            this.testMalformedInteger();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2611575908_28367511b84df86f()
{
        try
        {
            this.testStartFontMetrics();
        }
        finally
        {
        }
}
}
