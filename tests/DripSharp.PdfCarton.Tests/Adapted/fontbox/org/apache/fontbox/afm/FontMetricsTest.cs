// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Afm;

public class FontMetricsTest {
internal virtual void testFontMetricsNames() {
global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics fontMetrics = new global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics();
fontMetrics.SetFontName(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "fontName"));
fontMetrics.SetFamilyName(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "familyName"));
fontMetrics.SetFullName(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "fullName"));
fontMetrics.SetFontVersion(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "fontVersion"));
fontMetrics.SetNotice(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "notice"));
global::DripSharp.Testing.JavaAssertions.Equal("fontName", fontMetrics.GetFontName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("familyName", fontMetrics.GetFamilyName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("fullName", fontMetrics.GetFullName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("fontVersion", fontMetrics.GetFontVersion(), null);
global::DripSharp.Testing.JavaAssertions.Equal("notice", fontMetrics.GetNotice(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.Runtime.JavaCompat.CollectionCount(fontMetrics.GetComments()), null);
fontMetrics.AddComment(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "comment"));
global::System.Collections.Generic.IList<string> comments = fontMetrics.GetComments();
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.CollectionCount(comments), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(() => global::DripSharp.Runtime.JavaCompat.Add(comments, "comment"), null);
}

internal virtual void testFontMetricsSimpleValues() {
global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics fontMetrics = new global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics();
fontMetrics.SetAFMVersion(4.3F);
fontMetrics.SetWeight(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "weight"));
fontMetrics.SetEncodingScheme(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "encodingScheme"));
fontMetrics.SetMappingScheme(0);
fontMetrics.SetEscChar(0);
fontMetrics.SetCharacterSet(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "characterSet"));
fontMetrics.SetCharacters(10);
fontMetrics.SetIsBaseFont(true);
fontMetrics.SetIsFixedV(true);
fontMetrics.SetCapHeight(10.0F);
fontMetrics.SetXHeight(20.0F);
fontMetrics.SetAscender(30.0F);
fontMetrics.SetDescender(40.0F);
fontMetrics.SetStandardHorizontalWidth(50.0F);
fontMetrics.SetStandardVerticalWidth(60.0F);
fontMetrics.SetUnderlinePosition(70.0F);
fontMetrics.SetUnderlineThickness(80.0F);
fontMetrics.SetItalicAngle(90.0F);
fontMetrics.SetFixedPitch(true);
global::DripSharp.Testing.JavaAssertions.Equal(4.3F, fontMetrics.GetAFMVersion(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal("weight", fontMetrics.GetWeight(), null);
global::DripSharp.Testing.JavaAssertions.Equal("encodingScheme", fontMetrics.GetEncodingScheme(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, fontMetrics.GetMappingScheme(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, fontMetrics.GetEscChar(), null);
global::DripSharp.Testing.JavaAssertions.Equal("characterSet", fontMetrics.GetCharacterSet(), null);
global::DripSharp.Testing.JavaAssertions.Equal(10, fontMetrics.GetCharacters(), null);
global::DripSharp.Testing.JavaAssertions.True(fontMetrics.GetIsBaseFont(), null);
global::DripSharp.Testing.JavaAssertions.True(fontMetrics.GetIsFixedV(), null);
global::DripSharp.Testing.JavaAssertions.Equal(10.0F, fontMetrics.GetCapHeight(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(20.0F, fontMetrics.GetXHeight(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(30.0F, fontMetrics.GetAscender(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(40.0F, fontMetrics.GetDescender(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(50.0F, fontMetrics.GetStandardHorizontalWidth(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(60.0F, fontMetrics.GetStandardVerticalWidth(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(70.0F, fontMetrics.GetUnderlinePosition(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(80.0F, fontMetrics.GetUnderlineThickness(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(90.0F, fontMetrics.GetItalicAngle(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.True(fontMetrics.GetIsFixedPitch(), null);
}

internal virtual void testFontMetricsComplexValues() {
global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics fontMetrics = new global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics();
fontMetrics.SetFontBBox(new global::DripSharp.PdfCarton.Fonts.Util.BoundingBox((float)(10), (float)(20), (float)(30), (float)(40)));
fontMetrics.SetVVector(new float[] { 10, 20 });
fontMetrics.SetCharWidth(new float[] { 30, 40 });
global::DripSharp.Testing.JavaAssertions.Equal((float)(10), fontMetrics.GetFontBBox().GetLowerLeftX(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(20), fontMetrics.GetFontBBox().GetLowerLeftY(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(30), fontMetrics.GetFontBBox().GetUpperRightX(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(40), fontMetrics.GetFontBBox().GetUpperRightY(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(10), fontMetrics.GetVVector()[0], null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(20), fontMetrics.GetVVector()[1], null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(30), fontMetrics.GetCharWidth()[0], null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(40), fontMetrics.GetCharWidth()[1], null, (float)(0));
}

internal virtual void testMetricSets() {
global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics fontMetrics = new global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics();
fontMetrics.SetMetricSets(1);
global::DripSharp.Testing.JavaAssertions.Equal(1, fontMetrics.GetMetricSets(), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => fontMetrics.SetMetricSets(-1), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => fontMetrics.SetMetricSets(3), null);
}

internal virtual void testCharMetrics() {
global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics fontMetrics = new global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics();
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.Runtime.JavaCompat.CollectionCount(fontMetrics.GetCharMetrics()), null);
global::DripSharp.PdfCarton.Fonts.Afm.CharMetric charMetric = new global::DripSharp.PdfCarton.Fonts.Afm.CharMetric();
fontMetrics.AddCharMetric(charMetric);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Afm.CharMetric> charMetrics = fontMetrics.GetCharMetrics();
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.CollectionCount(charMetrics), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(() => global::DripSharp.Runtime.JavaCompat.Add(charMetrics, charMetric), null);
}

internal virtual void testComposites() {
global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics fontMetrics = new global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics();
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.Runtime.JavaCompat.CollectionCount(fontMetrics.GetComposites()), null);
global::DripSharp.PdfCarton.Fonts.Afm.Composite composite = new global::DripSharp.PdfCarton.Fonts.Afm.Composite(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "name"));
fontMetrics.AddComposite(composite);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Afm.Composite> composites = fontMetrics.GetComposites();
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.CollectionCount(composites), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(() => global::DripSharp.Runtime.JavaCompat.Add(composites, composite), null);
}

internal virtual void testKernData() {
global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics fontMetrics = new global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics();
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.Runtime.JavaCompat.CollectionCount(fontMetrics.GetKernPairs()), null);
global::DripSharp.PdfCarton.Fonts.Afm.KernPair kernPair = new global::DripSharp.PdfCarton.Fonts.Afm.KernPair(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "first"), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "second"), (float)(10), (float)(20));
fontMetrics.AddKernPair(kernPair);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Afm.KernPair> kernPairs = fontMetrics.GetKernPairs();
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.CollectionCount(kernPairs), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(() => global::DripSharp.Runtime.JavaCompat.Add(kernPairs, kernPair), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.Runtime.JavaCompat.CollectionCount(fontMetrics.GetKernPairs0()), null);
fontMetrics.AddKernPair0(kernPair);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Afm.KernPair> kernPairs0 = fontMetrics.GetKernPairs0();
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.CollectionCount(kernPairs0), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(() => global::DripSharp.Runtime.JavaCompat.Add(kernPairs0, kernPair), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.Runtime.JavaCompat.CollectionCount(fontMetrics.GetKernPairs1()), null);
fontMetrics.AddKernPair1(kernPair);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Afm.KernPair> kernPairs1 = fontMetrics.GetKernPairs1();
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.CollectionCount(kernPairs1), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(() => global::DripSharp.Runtime.JavaCompat.Add(kernPairs1, kernPair), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.Runtime.JavaCompat.CollectionCount(fontMetrics.GetTrackKern()), null);
global::DripSharp.PdfCarton.Fonts.Afm.TrackKern trackKern = new global::DripSharp.PdfCarton.Fonts.Afm.TrackKern(0, (float)(1), (float)(1), (float)(10), (float)(10));
fontMetrics.AddTrackKern(trackKern);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Afm.TrackKern> trackKerns = fontMetrics.GetTrackKern();
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.CollectionCount(trackKerns), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(() => global::DripSharp.Runtime.JavaCompat.Add(trackKerns, trackKern), null);
}

internal virtual void testCharMetricDimensions() {
global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics fontMetrics = new global::DripSharp.PdfCarton.Fonts.Afm.FontMetrics();
global::DripSharp.Testing.JavaAssertions.Equal((float)(0), fontMetrics.GetAverageCharacterWidth(), null, 0.0F);
global::DripSharp.PdfCarton.Fonts.Afm.CharMetric charMetric10 = new global::DripSharp.PdfCarton.Fonts.Afm.CharMetric();
charMetric10.SetName(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "ten"));
charMetric10.SetWx(10.0F);
charMetric10.SetWy(20.0F);
fontMetrics.AddCharMetric(charMetric10);
global::DripSharp.PdfCarton.Fonts.Afm.CharMetric charMetric20 = new global::DripSharp.PdfCarton.Fonts.Afm.CharMetric();
charMetric20.SetName(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "twenty"));
charMetric20.SetWx(20.0F);
charMetric20.SetWy(40.0F);
fontMetrics.AddCharMetric(charMetric20);
global::DripSharp.PdfCarton.Fonts.Afm.CharMetric charMetric30 = new global::DripSharp.PdfCarton.Fonts.Afm.CharMetric();
charMetric30.SetName(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "thirty"));
charMetric30.SetWx(30.0F);
charMetric30.SetWy(60.0F);
fontMetrics.AddCharMetric(charMetric30);
global::DripSharp.PdfCarton.Fonts.Afm.CharMetric charMetric40 = new global::DripSharp.PdfCarton.Fonts.Afm.CharMetric();
charMetric40.SetName(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "forty"));
charMetric40.SetWx(40.0F);
charMetric40.SetWy(80.0F);
fontMetrics.AddCharMetric(charMetric40);
global::DripSharp.Testing.JavaAssertions.Equal(10.0F, fontMetrics.GetCharacterWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "ten")), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(30.0F, fontMetrics.GetCharacterWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "thirty")), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(0.0F, fontMetrics.GetCharacterWidth(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "unknown")), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(40.0F, fontMetrics.GetCharacterHeight(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "twenty")), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(80.0F, fontMetrics.GetCharacterHeight(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "forty")), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(0.0F, fontMetrics.GetCharacterHeight(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "unknown")), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal((float)(25), fontMetrics.GetAverageCharacterWidth(), null, 0.0F);
}

[Xunit.Fact]
public void __Upstream_3561069765_1bfbda74ba98f3e7()
{
        try
        {
            this.testCharMetricDimensions();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0928885915_13ac2f8fcce28f88()
{
        try
        {
            this.testCharMetrics();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0990769406_0d05b82250443ad7()
{
        try
        {
            this.testComposites();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0178127760_ce555ae51da17a4e()
{
        try
        {
            this.testFontMetricsComplexValues();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3628379878_732f01d4d2f2e286()
{
        try
        {
            this.testFontMetricsNames();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1083189270_1652522fd5de55ab()
{
        try
        {
            this.testFontMetricsSimpleValues();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3174960274_20cb2d14231b918d()
{
        try
        {
            this.testKernData();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0822867027_811752a1741f29fd()
{
        try
        {
            this.testMetricSets();
        }
        finally
        {
        }
}
}
