// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Graphics.State;

public class RenderingIntentTest {
internal virtual void fromStringInputNotNullOutputNotNull() {
string value = "AbsoluteColorimetric";
global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent retval = global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent.FromString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", value));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent.AbsoluteColorimetric, retval, null);
}

internal virtual void fromStringInputNotNullOutputNotNull2() {
string value = "RelativeColorimetric";
global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent retval = global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent.FromString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", value));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent.RelativeColorimetric, retval, null);
}

internal virtual void fromStringInputNotNullOutputNotNull3() {
string value = "Perceptual";
global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent retval = global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent.FromString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", value));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent.Perceptual, retval, null);
}

internal virtual void fromStringInputNotNullOutputNotNull4() {
string value = "Saturation";
global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent retval = global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent.FromString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", value));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent.Saturation, retval, null);
}

internal virtual void fromStringInputNotNullOutputNotNull5() {
string value = "";
global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent retval = global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent.FromString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", value));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent.RelativeColorimetric, retval, null);
}

internal virtual void stringValueOutputNotNull() {
global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent objectUnderTest = global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingIntent.AbsoluteColorimetric;
string retval = objectUnderTest.StringValue();
global::DripSharp.Testing.JavaAssertions.Equal("AbsoluteColorimetric", retval, null);
}

internal virtual void testIsFill() {
global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingMode objectUnderTest = global::DripSharp.PdfCarton.Pdmodel.Graphics.State.RenderingMode.Fill;
bool retval = objectUnderTest.IsFill();
global::DripSharp.Testing.JavaAssertions.Equal(true, retval, null);
}

[Xunit.Fact]
public void __Upstream_1578538158_9287c60369a464ad()
{
        try
        {
            this.fromStringInputNotNullOutputNotNull();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1690042692_8b6387d1846108a3()
{
        try
        {
            this.fromStringInputNotNullOutputNotNull2();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1690042693_f7e36bdaa5700ffe()
{
        try
        {
            this.fromStringInputNotNullOutputNotNull3();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1690042694_79d7dfa48cd2866a()
{
        try
        {
            this.fromStringInputNotNullOutputNotNull4();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1690042695_12ba5d49324c4c73()
{
        try
        {
            this.fromStringInputNotNullOutputNotNull5();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3406276281_3a41629263629a8f()
{
        try
        {
            this.stringValueOutputNotNull();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3586706687_333dcf9199905de7()
{
        try
        {
            this.testIsFill();
        }
        finally
        {
        }
}
}
