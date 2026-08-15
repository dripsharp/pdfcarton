// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Graphics.Color;

public class PDIndexedTest {
internal virtual void testFactory() {
global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDColorSpace baseColorspace = global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance;
int hival = 5;
string stringLookupData = global::DripSharp.Runtime.JavaCompat.ReplaceOrdinal("AA1166 112233 000000 FEDC01 4561FE DC34DA", " ", "");
string outputString = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("/Indexed /DeviceRGB 5 <", stringLookupData), ">");
sbyte[] lookupData = global::DripSharp.PdfCarton.Cos.COSString.ParseHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", stringLookupData)).GetBytes();
global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDIndexed pdIndexed = global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDIndexed.Create(baseColorspace, hival, lookupData);
global::DripSharp.PdfCarton.Cos.COSArray indexedCOSArray = (global::DripSharp.PdfCarton.Cos.COSArray)(pdIndexed.GetCOSObject()!);
global::DripSharp.Testing.JavaAssertions.Equal(hival, ((global::DripSharp.PdfCarton.Cos.COSNumber)(indexedCOSArray.GetObject(2)!)).IntValue(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "unexpected value for hival"));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Indexed.GetName(), pdIndexed.GetName(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "unexpected value for name"));
global::DripSharp.Testing.JavaAssertions.Equal(baseColorspace, pdIndexed.GetBaseColorSpace(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "unexpected value for base colorspace"));
string lookupDataString = ((global::DripSharp.PdfCarton.Cos.COSString)(indexedCOSArray.GetObject(3)!)).ToHexString();
global::DripSharp.Testing.JavaAssertions.Equal(stringLookupData, lookupDataString, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "unexpected value for lookup data"));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
global::DripSharp.PdfCarton.Pdmodel.PDResources resources = new global::DripSharp.PdfCarton.Pdmodel.PDResources();
resources.Add(pdIndexed);
page.SetResources(resources);
document.AddPage(page);
global::DripSharp.Runtime.JavaByteArrayOutputStream baos = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
document.Save(baos, global::DripSharp.PdfCarton.Pdfwriter.Compress.CompressParameters.NoCompression);
string pdfAsString = global::DripSharp.PdfCarton.Tests.Support.OutputText(baos);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(pdfAsString, outputString), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "output doesn't match expected string"));
}
}

internal virtual void testFactoryParameterChecks() {
global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDColorSpace baseColorspace = global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance;
sbyte[] lookupDataEmpty = new sbyte[5];
int hival = 5;
string stringLookupData = global::DripSharp.Runtime.JavaCompat.ReplaceOrdinal("AA1166 112233 000000 FEDC01 4561FE DC34DA", " ", "");
sbyte[] lookupData = global::DripSharp.PdfCarton.Cos.COSString.ParseHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", stringLookupData)).GetBytes();
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDIndexed.Create(baseColorspace, 0, (sbyte[])default!), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDIndexed.Create((global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDColorSpace)default!, 0, lookupDataEmpty), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDIndexed.Create(baseColorspace, -1, lookupDataEmpty), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDIndexed.Create(baseColorspace, 256, lookupDataEmpty), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDIndexed.Create(baseColorspace, hival, lookupDataEmpty), null);
sbyte[] lookupDataOK = lookupData;
global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDIndexed.Create(baseColorspace, hival, lookupDataOK), null);
}

[Xunit.Fact]
public void __Upstream_0663002136_6d62f590f88936c0()
{
        try
        {
            this.testFactory();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0722903612_c94f64557b823b84()
{
        try
        {
            this.testFactoryParameterChecks();
        }
        finally
        {
        }
}
}
