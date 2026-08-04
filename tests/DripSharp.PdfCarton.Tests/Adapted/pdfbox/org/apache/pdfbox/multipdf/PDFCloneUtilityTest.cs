// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Multipdf;

public class PDFCloneUtilityTest {
internal virtual void testClonePDFWithCosArrayStream() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument srcDoc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument dstDoc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage pdPage = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
srcDoc.AddPage(pdPage);
new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(srcDoc, pdPage, global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, true).Dispose();
new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(srcDoc, pdPage, global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, true).Dispose();
global::DripSharp.PdfCarton.Multipdf.PDFCloneUtility cloner = new global::DripSharp.PdfCarton.Multipdf.PDFCloneUtility(dstDoc);
global::DripSharp.Testing.JavaAssertions.Equal(dstDoc, cloner.getDestination(), null);
global::DripSharp.PdfCarton.Cos.COSDictionary clonedPageDictionary = cloner.CloneForNewDocument<global::DripSharp.PdfCarton.Cos.COSDictionary>(pdPage.GetCOSObject());
global::DripSharp.PdfCarton.Pdmodel.PDPage clonedPage = new global::DripSharp.PdfCarton.Pdmodel.PDPage(clonedPageDictionary);
global::DripSharp.Runtime.JavaIterator<global::DripSharp.PdfCarton.Pdmodel.Common.PDStream> contentStreams = clonedPage.GetContentStreams();
global::DripSharp.Testing.JavaAssertions.NotNull(contentStreams.Next()!, null);
global::DripSharp.Testing.JavaAssertions.NotNull(contentStreams.Next()!, null);
global::DripSharp.Testing.JavaAssertions.False(contentStreams.HasNext(), null);
}
}

internal virtual void testClonePDFWithCosArrayStream2() {
string TESTDIR = "target/test-output/clone/";
string CLONESRC = "clone-src.pdf";
string CLONEDST = "clone-dst.pdf";
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", TESTDIR)));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument srcDoc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage pdPage = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
srcDoc.AddPage(pdPage);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream pdPageContentStream1 = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(srcDoc, pdPage, global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false)) {
pdPageContentStream1.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Black);
pdPageContentStream1.AddRect((float)(100), (float)(600), (float)(300), (float)(100));
pdPageContentStream1.Fill();
}
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream pdPageContentStream2 = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(srcDoc, pdPage, global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false)) {
pdPageContentStream2.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Red);
pdPageContentStream2.AddRect((float)(100), (float)(500), (float)(300), (float)(100));
pdPageContentStream2.Fill();
}
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream pdPageContentStream3 = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(srcDoc, pdPage, global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Append, false)) {
pdPageContentStream3.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Yellow);
pdPageContentStream3.AddRect((float)(100), (float)(400), (float)(300), (float)(100));
pdPageContentStream3.Fill();
}
srcDoc.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(TESTDIR, CLONESRC)));
global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility merger = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument dstDoc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
merger.AppendDocument(dstDoc, srcDoc);
dstDoc.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(TESTDIR, CLONEDST)));
}
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__123_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(TESTDIR, CLONESRC))))) {
global::DripSharp.Testing.JavaAssertions.Equal(1, doc__123_25.GetNumberOfPages(), null);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__127_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(TESTDIR, CLONESRC))), (string)default!)) {
global::DripSharp.Testing.JavaAssertions.Equal(1, doc__127_25.GetNumberOfPages(), null);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__131_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(TESTDIR, CLONEDST))))) {
global::DripSharp.Testing.JavaAssertions.Equal(1, doc__131_25.GetNumberOfPages(), null);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__135_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(TESTDIR, CLONEDST))), (string)default!)) {
global::DripSharp.Testing.JavaAssertions.Equal(1, doc__135_25.GetNumberOfPages(), null);
}
}

internal virtual void testDirectIndirect() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc1 = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
doc1.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
doc1.GetDocumentCatalog().SetOCProperties(new global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentProperties());
global::DripSharp.Runtime.JavaByteArrayOutputStream baos = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
doc1.Save(baos);
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc2 = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos))) {
global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility merger = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
global::DripSharp.Testing.JavaAssertions.InstanceOf<global::DripSharp.PdfCarton.Cos.COSDictionary>(doc1.GetDocumentCatalog().GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Ocproperties), null);
global::DripSharp.Testing.JavaAssertions.InstanceOf<global::DripSharp.PdfCarton.Cos.COSObject>(doc2.GetDocumentCatalog().GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Ocproperties), null);
merger.AppendDocument(doc2, doc1);
global::DripSharp.Testing.JavaAssertions.Equal(2, doc2.GetNumberOfPages(), null);
}
}
}

[Xunit.Fact]
public void __Upstream_2475150079_4c619884d9c6175a()
{
        try
        {
            this.testClonePDFWithCosArrayStream();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3715208467_568a90fefd3031e2()
{
        try
        {
            this.testClonePDFWithCosArrayStream2();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0557656457_0d8f7c102aa8232e()
{
        try
        {
            this.testDirectIndirect();
        }
        finally
        {
        }
}
}
