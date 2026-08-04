// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Multipdf;

public class OverlayTest {
private static readonly global::System.IO.FileInfo IN_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "src/test/resources/org/apache/pdfbox/multipdf"));

private static readonly global::System.IO.FileInfo OUT_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output/overlay"));

internal static void setUp() {
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR);
}

internal virtual void testRotatedOverlays() {
this.testRotatedOverlay(0);
this.testRotatedOverlay(90);
this.testRotatedOverlay(180);
this.testRotatedOverlay(270);
}

internal virtual void testRotatedOverlaysMap() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument baseDocument__73_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "OverlayTestBaseRot0.pdf"))))) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
for (int p = 0; (p < 4); ++p) {
doc.ImportPage(baseDocument__73_25.GetPage(0));
}
doc.Save(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "OverlayTestBaseRot0_4Pages.pdf"))));
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument baseDocument__84_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "OverlayTestBaseRot0_4Pages.pdf"))))) using (global::DripSharp.PdfCarton.Multipdf.Overlay overlay = new global::DripSharp.PdfCarton.Multipdf.Overlay()) {
global::System.Collections.Generic.IDictionary<int, string> specificPageOverlayMap = global::DripSharp.Runtime.JavaCompat.NewJavaDictionary<int, string>();
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => overlay.overlay(specificPageOverlayMap), null);
global::DripSharp.Runtime.JavaCompat.MapPut(specificPageOverlayMap, 1, new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "rot0.pdf"))).FullName);
global::DripSharp.Runtime.JavaCompat.MapPut(specificPageOverlayMap, 2, new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "rot90.pdf"))).FullName);
global::DripSharp.Runtime.JavaCompat.MapPut(specificPageOverlayMap, 3, new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "rot180.pdf"))).FullName);
global::DripSharp.Runtime.JavaCompat.MapPut(specificPageOverlayMap, 4, new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "rot270.pdf"))).FullName);
overlay.SetInputPDF(baseDocument__84_25);
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument overlayedResultPDF = overlay.overlay(specificPageOverlayMap)) {
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.PDDocument> documentList = new global::DripSharp.PdfCarton.Multipdf.Splitter().Split(overlayedResultPDF);
global::DripSharp.Runtime.JavaCompat.ListGet(documentList, 0).Save(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Overlayed-with-rot0.pdf"))));
global::DripSharp.Runtime.JavaCompat.ListGet(documentList, 1).Save(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Overlayed-with-rot90.pdf"))));
global::DripSharp.Runtime.JavaCompat.ListGet(documentList, 2).Save(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Overlayed-with-rot180.pdf"))));
global::DripSharp.Runtime.JavaCompat.ListGet(documentList, 3).Save(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Overlayed-with-rot270.pdf"))));
this.checkIdenticalRendering(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Overlayed-with-rot0.pdf"))), new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Overlayed-with-rot0.pdf"))));
this.checkIdenticalRendering(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Overlayed-with-rot90.pdf"))), new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Overlayed-with-rot90.pdf"))));
this.checkIdenticalRendering(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Overlayed-with-rot180.pdf"))), new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Overlayed-with-rot180.pdf"))));
this.checkIdenticalRendering(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Overlayed-with-rot270.pdf"))), new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Overlayed-with-rot270.pdf"))));
}
}
global::DripSharp.Runtime.JavaCompat.FileDelete(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "OverlayTestBaseRot0_4Pages.pdf"))));
}

internal virtual void testOverlayOnRotatedSourcePages() {
using (global::DripSharp.PdfCarton.Multipdf.Overlay overlay = new global::DripSharp.PdfCarton.Multipdf.Overlay()) {
overlay.SetInputFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR, "/PDFBOX-6049-Source.pdf")));
overlay.SetDefaultOverlayFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR, "/PDFBOX-6049-Overlay.pdf")));
overlay.SetOverlayPosition(global::DripSharp.PdfCarton.Multipdf.Overlay.Position.Foreground);
overlay.SetAdjustRotation(true);
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument resultDoc = overlay.overlay(global::DripSharp.Runtime.JavaCompat.EmptyMap<int, string>())) {
resultDoc.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR, "/PDFBOX-6049-Result.pdf")));
}
this.checkIdenticalRendering(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR, "/PDFBOX-6049-ExpectedResult.pdf"))), new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-6049-Result.pdf"))));
global::DripSharp.Runtime.JavaCompat.FileDelete(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-6049-Result.pdf"))));
}
}

private void testRotatedOverlay(int rotation) {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument baseDocument = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "OverlayTestBaseRot0.pdf"))))) using (global::DripSharp.PdfCarton.Multipdf.Overlay overlay = new global::DripSharp.PdfCarton.Multipdf.Overlay()) {
overlay.SetInputPDF(baseDocument);
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument overlayDocument = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("rot", rotation), ".pdf")))))) {
overlay.SetDefaultOverlayPDF(overlayDocument);
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument overlayedResultPDF = overlay.overlay(global::DripSharp.Runtime.JavaCompat.NewJavaDictionary<int, string>())) {
overlayedResultPDF.Save(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Overlayed-with-rot", rotation), ".pdf")))));
}
}
}
global::System.IO.FileInfo modelFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Overlayed-with-rot", rotation), ".pdf"))));
global::System.IO.FileInfo resultFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.OverlayTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Overlayed-with-rot", rotation), ".pdf"))));
this.checkIdenticalRendering(modelFile, resultFile);
}

private void checkIdenticalRendering(global::System.IO.FileInfo modelFile, global::System.IO.FileInfo resultFile) {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument modelDocument = global::DripSharp.PdfCarton.Loader.LoadPDF(modelFile)) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument resultDocument = global::DripSharp.PdfCarton.Loader.LoadPDF(resultFile)) {
global::DripSharp.Testing.JavaAssertions.Equal(modelDocument.GetNumberOfPages(), resultDocument.GetNumberOfPages(), null);
for (int page = 0; (page < modelDocument.GetNumberOfPages()); ++page) {
global::SkiaSharp.SKBitmap modelImage = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(modelDocument).RenderImage(page);
global::SkiaSharp.SKBitmap resultImage = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(resultDocument).RenderImage(page);
global::DripSharp.Testing.JavaAssertions.Equal(modelImage.Width, resultImage.Width, null);
global::DripSharp.Testing.JavaAssertions.Equal(modelImage.Height, resultImage.Height, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.PdfCartonFontCompat.GetImageType(modelImage), global::DripSharp.Runtime.PdfCartonFontCompat.GetImageType(resultImage), null);
global::DripSharp.Runtime.JavaDataBufferInt modelDataBuffer = (global::DripSharp.Runtime.JavaDataBufferInt)(global::DripSharp.Runtime.PdfCartonFontCompat.GetRaster(modelImage).GetDataBuffer()!);
global::DripSharp.Runtime.JavaDataBufferInt resultDataBuffer = (global::DripSharp.Runtime.JavaDataBufferInt)(global::DripSharp.Runtime.PdfCartonFontCompat.GetRaster(resultImage).GetDataBuffer()!);
global::DripSharp.Testing.JavaAssertions.Equal(modelDataBuffer.GetData(), resultDataBuffer.GetData(), null);
}
}
global::DripSharp.Runtime.JavaCompat.FileDelete(resultFile);
}

private void createBaseFile() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream cs = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page)) {
float fontHeight = 12;
float y = (page.GetMediaBox().GetHeight() - (fontHeight * 2));
global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica);
cs.SetFont(font, fontHeight);
cs.BeginText();
cs.SetLeading(((fontHeight * 2) + 1));
cs.NewLineAtOffset((fontHeight * 2), y);
while ((y > (fontHeight * 2))) {
cs.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("A quick movement of the enemy will jeopardize six gunboats. ", "Heavy boxes perform quick waltzes and jigs.")));
cs.NewLine();
y -= (fontHeight * 2);
}
cs.EndText();
}
doc.AddPage(page);
doc.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "OverlayTestBaseRot0.pdf"));
}
}

[Xunit.Fact]
public void __Upstream_3974534909_9afbf520614df326()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testOverlayOnRotatedSourcePages();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1292860602_8388bf2d8995a27a()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testRotatedOverlays();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2638528066_15647e7a67df7937()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testRotatedOverlaysMap();
        }
        finally
        {
        }
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    setUp();
    return true;
}
}
