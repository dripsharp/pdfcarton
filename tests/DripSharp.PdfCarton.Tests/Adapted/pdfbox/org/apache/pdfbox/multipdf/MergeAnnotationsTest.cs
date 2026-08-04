// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Multipdf;

public class MergeAnnotationsTest {
private static readonly global::System.IO.FileInfo OUT_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output/merge/"));

private static readonly global::System.IO.FileInfo TARGET_PDF_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/pdfs"));

internal static void setUp() {
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Multipdf.MergeAnnotationsTest.OUT_DIR);
}

internal virtual void testLinkAnnotations() {
global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility merger = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
global::System.IO.FileInfo file1 = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.MergeAnnotationsTest.TARGET_PDF_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-1065-1.pdf")));
global::System.IO.FileInfo file2 = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.MergeAnnotationsTest.TARGET_PDF_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-1065-2.pdf")));
global::System.IO.FileInfo pdfOutput = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.MergeAnnotationsTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-1065.pdf")));
merger.SetDestinationFileName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", pdfOutput.FullName));
merger.AddSource(file1);
merger.AddSource(file2);
merger.MergeDocuments((global::DripSharp.PdfCarton.IO.RandomAccessStreamCache.StreamCacheCreateFunction)default!);
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument mergedPDF = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfOutput)) {
global::DripSharp.Testing.JavaAssertions.Equal(6, mergedPDF.GetNumberOfPages(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 6 pages"));
global::DripSharp.PdfCarton.Pdmodel.PDDocumentNameDestinationDictionary destinations = mergedPDF.GetDocumentCatalog().GetDests();
global::DripSharp.Testing.JavaAssertions.Equal(12, destinations.GetCOSObject().EntrySet().Count, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 12 entries"));
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> sourceAnnotations01 = mergedPDF.GetPage(0).GetAnnotations();
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> sourceAnnotations02 = mergedPDF.GetPage(3).GetAnnotations();
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> targetAnnotations01 = mergedPDF.GetPage(2).GetAnnotations();
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> targetAnnotations02 = mergedPDF.GetPage(5).GetAnnotations();
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.Runtime.JavaCompat.CollectionCount(sourceAnnotations01), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 3 source annotations at the first page"));
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.Runtime.JavaCompat.CollectionCount(targetAnnotations01), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 3 source annotations at the third page"));
global::DripSharp.Testing.JavaAssertions.True(this.testAnnotationsMatch(sourceAnnotations01, targetAnnotations01), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The annotations shall match to each other"));
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.Runtime.JavaCompat.CollectionCount(sourceAnnotations02), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 3 source annotations at the first page"));
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.Runtime.JavaCompat.CollectionCount(targetAnnotations02), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 3 source annotations at the third page"));
global::DripSharp.Testing.JavaAssertions.True(this.testAnnotationsMatch(sourceAnnotations02, targetAnnotations02), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The annotations shall match to each other"));
}
}

private bool testAnnotationsMatch(global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> sourceAnnots, global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> targetAnnots) {
global::System.Collections.Generic.IDictionary<string, global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> targetAnnotsByName = global::DripSharp.Runtime.JavaCompat.NewJavaDictionary<string, global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>();
global::DripSharp.PdfCarton.Cos.COSName destinationName;
foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation targetAnnot in targetAnnots) {
destinationName = (global::DripSharp.PdfCarton.Cos.COSName)(targetAnnot.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Dest)!);
global::DripSharp.Runtime.JavaCompat.MapPut(targetAnnotsByName, destinationName.GetName(), targetAnnot);
}
foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation sourceAnnot in sourceAnnots) {
destinationName = (global::DripSharp.PdfCarton.Cos.COSName)(sourceAnnot.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Dest)!);
if ((global::DripSharp.Runtime.JavaCompat.MapGet(targetAnnotsByName, global::DripSharp.Runtime.JavaCompat.Concat("annoRef_", destinationName.GetName())) == default!)) {
return false;
}
}
return true;
}

[Xunit.Fact]
public void __Upstream_3756593112_c8ee712833f1be08()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testLinkAnnotations();
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
