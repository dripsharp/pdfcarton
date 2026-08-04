// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel;

public class TestPDPageTree {
private global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = null!;

internal virtual void tearDown() {
if ((this.doc != default!)) {
this.doc.Dispose();
}
}

internal virtual void indexOfPageFromOutlineDestination() {
this.doc = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.TestPDPageTree), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "with_outline.pdf"))));
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDDocumentOutline outline = this.doc.GetDocumentCatalog().GetDocumentOutline();
foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem current in outline.Children()) {
if (global::DripSharp.Runtime.JavaCompat.StringContains(current.GetTitle(), "Second")) {
global::DripSharp.Testing.JavaAssertions.Equal(2, this.doc.GetPages().IndexOf(current.FindDestinationPage(this.doc)), null);
}
}
}

internal virtual void positiveSingleLevel() {
this.doc = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.TestPDPageTree), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "with_outline.pdf"))));
for (int i = 0; (i < this.doc.GetNumberOfPages()); i++) {
global::DripSharp.Testing.JavaAssertions.Equal(i, this.doc.GetPages().IndexOf(this.doc.GetPage(i)), null);
}
}

internal virtual void positiveMultipleLevel() {
this.doc = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.TestPDPageTree), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "page_tree_multiple_levels.pdf"))));
for (int i = 0; (i < this.doc.GetNumberOfPages()); i++) {
global::DripSharp.Testing.JavaAssertions.Equal(i, this.doc.GetPages().IndexOf(this.doc.GetPage(i)), null);
}
}

internal virtual void negative() {
this.doc = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.TestPDPageTree), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "with_outline.pdf"))));
global::DripSharp.Testing.JavaAssertions.Equal(-1, this.doc.GetPages().IndexOf(new global::DripSharp.PdfCarton.Pdmodel.PDPage()), null);
}

internal virtual void testInsertBeforeBlankPage() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage pageOne = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
global::DripSharp.PdfCarton.Pdmodel.PDPage pageTwo = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
global::DripSharp.PdfCarton.Pdmodel.PDPage pageThree = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
document.AddPage(pageOne);
document.AddPage(pageTwo);
document.GetPages().InsertBefore(pageThree, pageTwo);
global::DripSharp.Testing.JavaAssertions.Equal(0, document.GetPages().IndexOf(pageOne), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Page one should be placed at index 0."));
global::DripSharp.Testing.JavaAssertions.Equal(2, document.GetPages().IndexOf(pageTwo), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Page two should be placed at index 2."));
global::DripSharp.Testing.JavaAssertions.Equal(1, document.GetPages().IndexOf(pageThree), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Page three should be placed at index 1."));
}
}

internal virtual void testInsertAfterBlankPage() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage pageOne = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
global::DripSharp.PdfCarton.Pdmodel.PDPage pageTwo = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
global::DripSharp.PdfCarton.Pdmodel.PDPage pageThree = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
document.AddPage(pageOne);
document.AddPage(pageTwo);
document.GetPages().InsertAfter(pageThree, pageTwo);
global::DripSharp.Testing.JavaAssertions.Equal(0, document.GetPages().IndexOf(pageOne), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Page one should be placed at index 0."));
global::DripSharp.Testing.JavaAssertions.Equal(1, document.GetPages().IndexOf(pageTwo), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Page two should be placed at index 1."));
global::DripSharp.Testing.JavaAssertions.Equal(2, document.GetPages().IndexOf(pageThree), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Page three should be placed at index 2."));
}
}

internal virtual void testNodeLoop() {
this.doc = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.TestPDPageTree), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-6040-nodeloop.pdf"))));
global::DripSharp.Testing.JavaAssertions.Null(this.doc.GetPage(0).GetResources(), null);
}

[Xunit.Fact]
public void __Upstream_0741398094_1d48805557be044d()
{
        try
        {
            this.indexOfPageFromOutlineDestination();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3068595253_b2ce2c46fa0dee58()
{
        try
        {
            this.negative();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0380740059_dc9e2175b8531e7c()
{
        try
        {
            this.positiveMultipleLevel();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3337411683_dca72a9c74c04875()
{
        try
        {
            this.positiveSingleLevel();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0260301394_c4248996fbf60349()
{
        try
        {
            this.testInsertAfterBlankPage();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_2065400793_6955cc28279dfeec()
{
        try
        {
            this.testInsertBeforeBlankPage();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3984658040_5ec56271287c11c4()
{
        try
        {
            this.testNodeLoop();
        }
        finally
        {
            this.tearDown();
        }
}
}
