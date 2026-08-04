// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Graphics.Blend;

public class BlendModeTest {
internal virtual void testInstances() {
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Normal, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.Normal), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Normal, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.Compatible), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Multiply, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.Multiply), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Screen, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.Screen), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Overlay, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.Overlay), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Darken, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.Darken), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Lighten, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.Lighten), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.ColorDodge, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.ColorDodge), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.ColorBurn, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.ColorBurn), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.HardLight, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.HardLight), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.SoftLight, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.SoftLight), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Difference, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.Difference), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Exclusion, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.Exclusion), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Hue, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.Hue), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Saturation, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.Saturation), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Luminosity, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.Luminosity), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Color, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.Color), null);
global::DripSharp.PdfCarton.Cos.COSArray cosArrayOverlay = new global::DripSharp.PdfCarton.Cos.COSArray();
cosArrayOverlay.Add(global::DripSharp.PdfCarton.Cos.COSName.Overlay);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Overlay, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(cosArrayOverlay), null);
global::DripSharp.PdfCarton.Cos.COSArray cosArrayInteger = new global::DripSharp.PdfCarton.Cos.COSArray();
cosArrayInteger.Add(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(0)));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Normal, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.GetInstance(cosArrayInteger), null);
}

internal virtual void testBlendModeNormal() {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Normal.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Normal.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Normal.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Normal, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Normal.GetCOSName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(3.0F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Normal.GetBlendChannelFunction().BlendChannel(3.0F, 5.0F), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Normal, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Compatible.GetCOSName(), null);
}

internal virtual void testBlendModeMultiply() {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Multiply.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Multiply.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Multiply.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Multiply, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Multiply.GetCOSName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(15.0F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Multiply.GetBlendChannelFunction().BlendChannel(3.0F, 5.0F), null);
}

internal virtual void testBlendModeScreen() {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Screen.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Screen.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Screen.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Screen, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Screen.GetCOSName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-7.0F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Screen.GetBlendChannelFunction().BlendChannel(3.0F, 5.0F), null);
}

internal virtual void testBlendModeOverlay() {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Overlay.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Overlay.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Overlay.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Overlay, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Overlay.GetCOSName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.0F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Overlay.GetBlendChannelFunction().BlendChannel(1.0F, 0.0F), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.3F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Overlay.GetBlendChannelFunction().BlendChannel(0.5F, 0.3F), null);
}

internal virtual void testBlendModeDarken() {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Darken.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Darken.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Darken.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Darken, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Darken.GetCOSName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(3.0F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Darken.GetBlendChannelFunction().BlendChannel(3.0F, 5.0F), null);
}

internal virtual void testBlendModeLighten() {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Lighten.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Lighten.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Lighten.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Lighten, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Lighten.GetCOSName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(5.0F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Lighten.GetBlendChannelFunction().BlendChannel(3.0F, 5.0F), null);
}

internal virtual void testBlendModeColorDodge() {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.ColorDodge.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.ColorDodge.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.ColorDodge.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.ColorDodge, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.ColorDodge.GetCOSName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.0F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.ColorDodge.GetBlendChannelFunction().BlendChannel(1.0F, 0.0F), null);
global::DripSharp.Testing.JavaAssertions.Equal(1.0F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.ColorDodge.GetBlendChannelFunction().BlendChannel(0.3F, 0.7F), null);
}

internal virtual void testBlendModeColorBurn() {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.ColorBurn.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.ColorBurn.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.ColorBurn.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.ColorBurn, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.ColorBurn.GetCOSName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(1.0F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.ColorBurn.GetBlendChannelFunction().BlendChannel(0.0F, 1.0F), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.0F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.ColorBurn.GetBlendChannelFunction().BlendChannel(0.7F, 0.3F), null);
}

internal virtual void testBlendModeHardLight() {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.HardLight.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.HardLight.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.HardLight.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.HardLight, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.HardLight.GetCOSName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.0F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.HardLight.GetBlendChannelFunction().BlendChannel(0.0F, 0.5F), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.2F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.HardLight.GetBlendChannelFunction().BlendChannel(0.2F, 0.5F), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.52F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.HardLight.GetBlendChannelFunction().BlendChannel(0.6F, 0.4F), null);
}

internal virtual void testBlendModeSoftLight() {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.SoftLight.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.SoftLight.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.SoftLight.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.SoftLight, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.SoftLight.GetCOSName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.25F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.SoftLight.GetBlendChannelFunction().BlendChannel(0.0F, 0.5F), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.35F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.SoftLight.GetBlendChannelFunction().BlendChannel(0.2F, 0.5F), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.2F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.SoftLight.GetBlendChannelFunction().BlendChannel(0.5F, 0.2F), null);
}

internal virtual void testBlendModeDifference() {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Difference.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Difference.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Difference.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Difference, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Difference.GetCOSName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(2.0F, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Difference.GetBlendChannelFunction().BlendChannel(3.0F, 5.0F), null);
}

internal virtual void testBlendModeExclusion() {
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Exclusion.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Exclusion.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Exclusion.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Exclusion, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Exclusion.GetCOSName(), null);
}

internal virtual void testBlendModeHue() {
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Hue.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Hue.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Hue.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Hue, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Hue.GetCOSName(), null);
}

internal virtual void testBlendModeSaturation() {
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Saturation.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Saturation.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Saturation.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Saturation, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Saturation.GetCOSName(), null);
}

internal virtual void testBlendModeLuminosity() {
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Luminosity.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Luminosity.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Luminosity.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Luminosity, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Luminosity.GetCOSName(), null);
}

internal virtual void testBlendModeColor() {
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Color.IsSeparableBlendMode(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Color.GetBlendFunction(), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Color.GetBlendChannelFunction(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Color, global::DripSharp.PdfCarton.Pdmodel.Graphics.Blend.BlendMode.Color.GetCOSName(), null);
}

[Xunit.Fact]
public void __Upstream_3103164257_c1cca7d55d06c9fb()
{
        try
        {
            this.testBlendModeColor();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3251746000_3b808415eaddc528()
{
        try
        {
            this.testBlendModeColorBurn();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2021532918_c69920078028e397()
{
        try
        {
            this.testBlendModeColorDodge();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1724685921_dbe5844163958b6a()
{
        try
        {
            this.testBlendModeDarken();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2485300223_0fbe677e6d3cfaee()
{
        try
        {
            this.testBlendModeDifference();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2957960908_60f0ebdfe2304e8a()
{
        try
        {
            this.testBlendModeExclusion();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0561088489_ff0ef92e4b248a8d()
{
        try
        {
            this.testBlendModeHardLight();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3600995446_f4bd42ae944e1e41()
{
        try
        {
            this.testBlendModeHue();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0654550205_093a10040517047d()
{
        try
        {
            this.testBlendModeLighten();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2931161219_6558d7b641d0a92b()
{
        try
        {
            this.testBlendModeLuminosity();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2773050726_589a429d52026489()
{
        try
        {
            this.testBlendModeMultiply();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2023908521_e771830f4a248d4a()
{
        try
        {
            this.testBlendModeNormal();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3687683278_9747b183cc54eac0()
{
        try
        {
            this.testBlendModeOverlay();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0526447252_c95deb87ab8ea8d1()
{
        try
        {
            this.testBlendModeSaturation();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2155964462_8dd54061d19b456d()
{
        try
        {
            this.testBlendModeScreen();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3476390922_7499fa1198ff0ec0()
{
        try
        {
            this.testBlendModeSoftLight();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2846285324_7c44287d8ddee0d6()
{
        try
        {
            this.testInstances();
        }
        finally
        {
        }
}
}
