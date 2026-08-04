// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Text;

public class PDFTextStripperByAreaTest {
internal virtual void testSomeMethod() {
global::System.IO.FileInfo pdfFile = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "src/test/resources/input"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "eu-001.pdf"));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfFile)) {
string regionName = "region";
global::DripSharp.PdfCarton.Text.PDFTextStripperByArea textAreaStripper = new global::DripSharp.PdfCarton.Text.PDFTextStripperByArea();
textAreaStripper.SetShouldSeparateByBeads(false);
textAreaStripper.SetSortByPosition(true);
global::SkiaSharp.SKRect rect = global::DripSharp.Runtime.PdfCartonFontCompat.Rectangle((double)(65), (double)(227), (double)(472), (double)(34));
textAreaStripper.AddRegion(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", regionName), rect);
textAreaStripper.SetLineSeparator(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ""));
textAreaStripper.ExtractRegions(doc.GetPage(0));
string textForRegion = textAreaStripper.GetTextForRegion(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", regionName));
textForRegion = global::DripSharp.Runtime.JavaCompat.StringTrim(textForRegion);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("In the following tables you will find the 91 E-PRTR ", "pollutants and their thresholds broken down by the 7 groups used in all "), "the searches of the E-PRTR website."), textForRegion, null);
textAreaStripper.RemoveRegion(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", regionName));
rect = global::DripSharp.Runtime.PdfCartonFontCompat.Rectangle((double)(230), (double)(370), (double)(369), (double)(10));
textAreaStripper.AddRegion(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", regionName), rect);
textAreaStripper.ExtractRegions(doc.GetPage(2));
textForRegion = textAreaStripper.GetTextForRegion(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", regionName));
textForRegion = global::DripSharp.Runtime.JavaCompat.StringTrim(textForRegion);
global::DripSharp.Testing.JavaAssertions.Equal("Inorganic substances", textForRegion, null);
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.CollectionCount(textAreaStripper.GetRegions()), null);
}
}

[Xunit.Fact]
public void __Upstream_4277878055_5b0f17632c6ea298()
{
        try
        {
            this.testSomeMethod();
        }
        finally
        {
        }
}
}
