// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel;

public class TestPDPageContentStream {
internal virtual void testSetCmykColors() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
doc.AddPage(page);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream__52_38 = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page, global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Overwrite, true)) {
contentStream__52_38.SetNonStrokingColor(0.1F, 0.2F, 0.3F, 0.4F);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__52_38.SetNonStrokingColor(1.1F, (float)(0), (float)(0), (float)(0)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__52_38.SetNonStrokingColor((float)(0), 1.1F, (float)(0), (float)(0)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__52_38.SetNonStrokingColor((float)(0), (float)(0), 1.1F, (float)(0)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__52_38.SetNonStrokingColor((float)(0), (float)(0), (float)(0), 1.1F), null);
}
global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser parser = new global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser(page);
global::System.Collections.Generic.IList<object> pageTokens = parser.Parse();
global::DripSharp.Testing.JavaAssertions.Equal(0.1F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 0)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.2F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 1)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.3F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 2)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.4F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 3)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Contentstream.@Operator.OperatorName.NonStrokingCmyk, ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 4)!)).GetName(), null);
page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
doc.AddPage(page);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream__86_39 = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page, global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Overwrite, false)) {
contentStream__86_39.SetStrokingColor(0.5F, 0.6F, 0.7F, 0.8F);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__86_39.SetStrokingColor(1.1F, (float)(0), (float)(0), (float)(0)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__86_39.SetStrokingColor((float)(0), 1.1F, (float)(0), (float)(0)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__86_39.SetStrokingColor((float)(0), (float)(0), 1.1F, (float)(0)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__86_39.SetStrokingColor((float)(0), (float)(0), (float)(0), 1.1F), null);
}
parser = new global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser(page);
pageTokens = parser.Parse();
global::DripSharp.Testing.JavaAssertions.Equal(0.5F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 0)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.6F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 1)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.7F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 2)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.8F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 3)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Contentstream.@Operator.OperatorName.StrokingColorCmyk, ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 4)!)).GetName(), null);
}
}

internal virtual void testSetRGBandGColors() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
doc.AddPage(page);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream__126_38 = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page, global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Overwrite, true)) {
contentStream__126_38.SetNonStrokingColor(0.1F, 0.2F, 0.3F);
contentStream__126_38.SetNonStrokingColor(0.8F);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__126_38.SetNonStrokingColor(1.1F, (float)(0), (float)(0)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__126_38.SetNonStrokingColor((float)(0), 1.1F, (float)(0)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__126_38.SetNonStrokingColor((float)(0), (float)(0), 1.1F), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__126_38.SetNonStrokingColor(1.1F), null);
}
global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser parser = new global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser(page);
global::System.Collections.Generic.IList<object> pageTokens = parser.Parse();
global::DripSharp.Testing.JavaAssertions.Equal(0.1F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 0)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.2F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 1)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.3F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 2)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Contentstream.@Operator.OperatorName.NonStrokingRgb, ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 3)!)).GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.8F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 4)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Contentstream.@Operator.OperatorName.NonStrokingGray, ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 5)!)).GetName(), null);
page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
doc.AddPage(page);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream__157_38 = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page, global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Overwrite, false)) {
contentStream__157_38.SetStrokingColor(0.5F, 0.6F, 0.7F);
contentStream__157_38.SetStrokingColor(0.8F);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__157_38.SetStrokingColor(1.1F, (float)(0), (float)(0)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__157_38.SetStrokingColor((float)(0), 1.1F, (float)(0)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__157_38.SetStrokingColor((float)(0), (float)(0), 1.1F), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => contentStream__157_38.SetStrokingColor(1.1F), null);
}
parser = new global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser(page);
pageTokens = parser.Parse();
global::DripSharp.Testing.JavaAssertions.Equal(0.5F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 0)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.6F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 1)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.7F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 2)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Contentstream.@Operator.OperatorName.StrokingColorRgb, ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 3)!)).GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.8F, ((global::DripSharp.PdfCarton.Cos.COSNumber)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 4)!)).FloatValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Contentstream.@Operator.OperatorName.StrokingColorGray, ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(pageTokens, 5)!)).GetName(), null);
}
}

internal virtual void testMissingContentStream() {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser parser = new global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser(page);
global::System.Collections.Generic.IList<object> tokens = parser.Parse();
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.Runtime.JavaCompat.CollectionCount(tokens), null);
}

internal virtual void testCloseContract() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
doc.AddPage(page);
global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page, global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Overwrite, true);
contentStream.Dispose();
contentStream.Dispose();
}
}

internal virtual void testGeneralGraphicStateOperatorTextMode() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
doc.AddPage(page);
global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page);
contentStream.BeginText();
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject img1 = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject(doc);
global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImage img2 = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDInlineImage(new global::DripSharp.PdfCarton.Cos.COSDictionary(), new sbyte[0], new global::DripSharp.PdfCarton.Pdmodel.PDResources());
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => contentStream.DrawImage(img1, 0.0F, 0.0F, 1.0F, 1.0F), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => contentStream.DrawImage(img1, new global::DripSharp.PdfCarton.Util.Matrix()), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => contentStream.DrawImage(img2, 0.0F, 0.0F, 1.0F, 1.0F), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => contentStream.AddRect((float)(0), (float)(0), (float)(1), (float)(1)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => contentStream.CurveTo((float)(0), (float)(0), (float)(1), (float)(1), (float)(2), (float)(2)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => contentStream.CurveTo1((float)(0), (float)(0), (float)(1), (float)(1)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => contentStream.CurveTo2((float)(0), (float)(0), (float)(1), (float)(1)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => contentStream.MoveTo((float)(0), (float)(0)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => contentStream.LineTo((float)(1), (float)(1)), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(() => contentStream.ShadingFill(new global::DripSharp.PdfCarton.Pdmodel.Graphics.Shading.PDShadingType1(new global::DripSharp.PdfCarton.Cos.COSDictionary())), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(contentStream.Stroke, null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(contentStream.CloseAndStroke, null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(contentStream.CloseAndFillAndStroke, null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(contentStream.CloseAndFillAndStrokeEvenOdd, null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(contentStream.Fill, null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(contentStream.FillAndStroke, null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(contentStream.FillAndStrokeEvenOdd, null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(contentStream.FillEvenOdd, null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(contentStream.ClosePath, null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(contentStream.Clip, null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidOperationException>(contentStream.ClipEvenOdd, null);
contentStream.SetLineCapStyle(0);
contentStream.SetLineJoinStyle(0);
contentStream.SetLineWidth(10.0F);
contentStream.SetLineDashPattern(new float[] { 2, 1 }, 0.0F);
contentStream.SetMiterLimit(1.0F);
contentStream.SetGraphicsStateParameters(new global::DripSharp.PdfCarton.Pdmodel.Graphics.State.PDExtendedGraphicsState());
contentStream.EndText();
contentStream.Dispose();
}
}

[Xunit.Fact]
public void __Upstream_0436749240_592a10af687a5424()
{
        try
        {
            this.testCloseContract();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3510148339_985ff1633e8eb4bf()
{
        try
        {
            this.testGeneralGraphicStateOperatorTextMode();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3348271429_ebc07c9591edc58e()
{
        try
        {
            this.testMissingContentStream();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1433408540_4083b71cbc2d825f()
{
        try
        {
            this.testSetCmykColors();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1263292125_559491d984d9f0ef()
{
        try
        {
            this.testSetRGBandGColors();
        }
        finally
        {
        }
}
}
