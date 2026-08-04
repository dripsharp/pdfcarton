// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Afm;

public class CharMetricTest {
internal virtual void testCharMetricSimpleValues() {
global::DripSharp.PdfCarton.Fonts.Afm.CharMetric charMetric = new global::DripSharp.PdfCarton.Fonts.Afm.CharMetric();
charMetric.SetCharacterCode(0);
charMetric.SetName(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "name"));
charMetric.SetWx(10.0F);
charMetric.SetW0x(20.0F);
charMetric.SetW1x(30.0F);
charMetric.SetWy(40.0F);
charMetric.SetW0y(50.0F);
charMetric.SetW1y(60.0F);
global::DripSharp.Testing.JavaAssertions.Equal(0, charMetric.GetCharacterCode(), null);
global::DripSharp.Testing.JavaAssertions.Equal("name", charMetric.GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(10.0F, charMetric.GetWx(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(20.0F, charMetric.GetW0x(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(30.0F, charMetric.GetW1x(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(40.0F, charMetric.GetWy(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(50.0F, charMetric.GetW0y(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(60.0F, charMetric.GetW1y(), null, 0.0F);
}

internal virtual void testCharMetricArrayValues() {
global::DripSharp.PdfCarton.Fonts.Afm.CharMetric charMetric = new global::DripSharp.PdfCarton.Fonts.Afm.CharMetric();
charMetric.SetW(new float[] { 10.0F, 20.0F });
charMetric.SetW0(new float[] { 30.0F, 40.0F });
charMetric.SetW1(new float[] { 50.0F, 60.0F });
charMetric.SetVv(new float[] { 70.0F, 80.0F });
global::DripSharp.Testing.JavaAssertions.Equal(10.0F, charMetric.GetW()[0], null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(20.0F, charMetric.GetW()[1], null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(30.0F, charMetric.GetW0()[0], null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(40.0F, charMetric.GetW0()[1], null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(50.0F, charMetric.GetW1()[0], null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(60.0F, charMetric.GetW1()[1], null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(70.0F, charMetric.GetVv()[0], null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(80.0F, charMetric.GetVv()[1], null, 0.0F);
}

internal virtual void testCharMetricComplexValues() {
global::DripSharp.PdfCarton.Fonts.Afm.CharMetric charMetric = new global::DripSharp.PdfCarton.Fonts.Afm.CharMetric();
charMetric.SetBoundingBox(new global::DripSharp.PdfCarton.Fonts.Util.BoundingBox((float)(10), (float)(20), (float)(30), (float)(40)));
global::DripSharp.Testing.JavaAssertions.Equal((float)(10), charMetric.GetBoundingBox().GetLowerLeftX(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(20), charMetric.GetBoundingBox().GetLowerLeftY(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(30), charMetric.GetBoundingBox().GetUpperRightX(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(40), charMetric.GetBoundingBox().GetUpperRightY(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.Runtime.JavaCompat.CollectionCount(charMetric.GetLigatures()), null);
global::DripSharp.PdfCarton.Fonts.Afm.Ligature ligature = new global::DripSharp.PdfCarton.Fonts.Afm.Ligature(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "successor"), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "ligature"));
charMetric.AddLigature(ligature);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Afm.Ligature> ligatures = charMetric.GetLigatures();
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.CollectionCount(ligatures), null);
global::DripSharp.Testing.JavaAssertions.Equal("successor", global::DripSharp.Runtime.JavaCompat.ListGet(ligatures, 0).GetSuccessor(), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(() => global::DripSharp.Runtime.JavaCompat.Add(ligatures, ligature), null);
}

[Xunit.Fact]
public void __Upstream_3852490467_bf305022eacf506c()
{
        try
        {
            this.testCharMetricArrayValues();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1433635322_15a5afa63702ce07()
{
        try
        {
            this.testCharMetricComplexValues();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3340446828_43ad86195fa4915a()
{
        try
        {
            this.testCharMetricSimpleValues();
        }
        finally
        {
        }
}
}
