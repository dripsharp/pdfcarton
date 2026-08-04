// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Rendering;

public class TestQuality {
private static readonly global::System.IO.FileInfo TARGET_PDF_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/pdfs"));

internal virtual void testPDFBox4831() {
global::System.IO.FileInfo file = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Rendering.TestQuality.TARGET_PDF_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4831.pdf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = global::DripSharp.PdfCarton.Loader.LoadPDF(file)) {
global::DripSharp.PdfCarton.Rendering.PDFRenderer renderer = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(doc);
global::SkiaSharp.SKBitmap renderedImage = renderer.RenderImageWithDPI(0, (float)(300));
global::DripSharp.Testing.JavaAssertions.Equal(2, global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.ColorCount(renderedImage), null);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject xObjectImage = (global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject)(doc.GetPage(0).GetResources().GetXObject(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "I0")))!);
global::SkiaSharp.SKBitmap extractedImage = xObjectImage.GetImage();
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.ValidateXImage.CheckIdent(extractedImage, renderedImage);
}
}

[Xunit.Fact]
public void __Upstream_1724581133_37f42bbbe17799db()
{
        try
        {
            this.testPDFBox4831();
        }
        finally
        {
        }
}
}
