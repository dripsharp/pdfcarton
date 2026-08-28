// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Multipdf;

public class PDFMergerUtilityTest {
  private const string SRCDIR = "src/test/resources/input/merge/";

  private const string TARGETTESTDIR = "target/test-output/merge/";

  private static readonly global::System.IO.FileInfo TARGETPDFDIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/pdfs"));

  private const int DPI = 96;

  internal static void setUp() {
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR)));
  }

  internal virtual void testPDFMergerUtility() {
    this.checkMergeIdentical(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBox.GlobalResourceMergeTest.Doc01.decoded.pdf"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBox.GlobalResourceMergeTest.Doc02.decoded.pdf"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "GlobalResourceMergeTestResult1.pdf"),
      global::DripSharp.PdfCarton.IO.IOUtils.CreateMemoryOnlyStreamCache());
    this.checkMergeIdentical(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBox.GlobalResourceMergeTest.Doc01.decoded.pdf"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBox.GlobalResourceMergeTest.Doc02.decoded.pdf"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "GlobalResourceMergeTestResult2.pdf"),
      global::DripSharp.PdfCarton.IO.IOUtils.CreateTempFileOnlyStreamCache());
  }

  internal virtual void testPDFMergerUtility2() {
    this.checkMergeIdentical(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBox.GlobalResourceMergeTest.Doc01.pdf"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBox.GlobalResourceMergeTest.Doc02.pdf"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "GlobalResourceMergeTestResult3.pdf"),
      global::DripSharp.PdfCarton.IO.IOUtils.CreateMemoryOnlyStreamCache());
    this.checkMergeIdentical(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBox.GlobalResourceMergeTest.Doc01.pdf"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBox.GlobalResourceMergeTest.Doc02.pdf"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "GlobalResourceMergeTestResult4.pdf"),
      global::DripSharp.PdfCarton.IO.IOUtils.CreateTempFileOnlyStreamCache());
  }

  internal virtual void testJpegCcitt() {
    this.checkMergeIdentical(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "jpegrgb.pdf"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "multitiff.pdf"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "JpegMultiMergeTestResult.pdf"),
      global::DripSharp.PdfCarton.IO.IOUtils.CreateMemoryOnlyStreamCache());
    this.checkMergeIdentical(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "jpegrgb.pdf"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "multitiff.pdf"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "JpegMultiMergeTestResult.pdf"),
      global::DripSharp.PdfCarton.IO.IOUtils.CreateTempFileOnlyStreamCache());
  }

  internal virtual void testPDFMergerOpenAction() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc1
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      doc1.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
      doc1.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
      doc1.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
      doc1.Save(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "MergerOpenActionTest1.pdf")));
    }
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination dest;
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc2
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      doc2.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
      doc2.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
      doc2.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
      dest
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageFitDestination();
      dest.SetPage(doc2.GetPage(1));
      doc2.GetDocumentCatalog().SetOpenAction(dest);
      doc2.Save(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "MergerOpenActionTest2.pdf")));
    }
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    pdfMergerUtility.AddSource(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "MergerOpenActionTest1.pdf")));
    pdfMergerUtility.AddSource(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "MergerOpenActionTest2.pdf")));
    pdfMergerUtility.SetDestinationFileName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR,
      "MergerOpenActionTestResult.pdf")));
    pdfMergerUtility.MergeDocuments(global::DripSharp.PdfCarton.IO.IOUtils.CreateMemoryOnlyStreamCache());
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument mergedDoc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "MergerOpenActionTestResult.pdf")))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog documentCatalog
        = mergedDoc.GetDocumentCatalog();
      dest
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination)(documentCatalog.GetOpenAction()!);
      global::DripSharp.Testing.JavaAssertions.Equal(4,
        documentCatalog.GetPages().IndexOf(dest.GetPage()), null);
    }
  }

  internal virtual void testStructureTreeMerge() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    global::DripSharp.PdfCarton.Pdmodel.PDDocument src
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3999-GeneralForbearance.pdf"))));
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter elementCounter
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter(this);
    elementCounter.walk(src.GetDocumentCatalog().GetStructureTreeRoot().GetK());
    int singleCnt = elementCounter.cnt;
    int singleSetSize = elementCounter.set.Count;
    global::DripSharp.Testing.JavaAssertions.Equal(134, singleCnt, null);
    global::DripSharp.Testing.JavaAssertions.Equal(134, singleSetSize, null);
    global::DripSharp.PdfCarton.Pdmodel.PDDocument dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3999-GeneralForbearance.pdf"))));
    pdfMergerUtility.AppendDocument(dst, src);
    src.Dispose();
    dst.Save(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3999-GeneralForbearance-merged.pdf")));
    dst.Dispose();
    global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3999-GeneralForbearance-merged.pdf")));
    elementCounter
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter(this);
    elementCounter.walk(doc.GetDocumentCatalog().GetStructureTreeRoot().GetK());
    global::DripSharp.Testing.JavaAssertions.Equal((singleCnt * 2), elementCounter.cnt, null);
    global::DripSharp.Testing.JavaAssertions.Equal((singleSetSize * 2), elementCounter.set.Count,
      null);
    this.checkForPageOrphans(doc);
    doc.Dispose();
  }

  internal virtual void testStructureTreeMerge2() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3999-GeneralForbearance.pdf"))));
    doc.GetDocumentCatalog().GetAcroForm().Flatten();
    doc.Save(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3999-GeneralForbearance-flattened.pdf")));
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter elementCounter
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter(this);
    elementCounter.walk(doc.GetDocumentCatalog().GetStructureTreeRoot().GetK());
    int singleCnt = elementCounter.cnt;
    int singleSetSize = elementCounter.set.Count;
    global::DripSharp.Testing.JavaAssertions.Equal(134, singleCnt, null);
    global::DripSharp.Testing.JavaAssertions.Equal(134, singleSetSize, null);
    doc.Dispose();
    global::DripSharp.PdfCarton.Pdmodel.PDDocument src
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3999-GeneralForbearance-flattened.pdf")));
    global::DripSharp.PdfCarton.Pdmodel.PDDocument dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3999-GeneralForbearance-flattened.pdf")));
    pdfMergerUtility.AppendDocument(dst, src);
    src.Dispose();
    dst.Save(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3999-GeneralForbearance-flattened-merged.pdf")));
    dst.Dispose();
    doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3999-GeneralForbearance-flattened-merged.pdf")));
    this.checkForPageOrphans(doc);
    elementCounter
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter(this);
    elementCounter.walk(doc.GetDocumentCatalog().GetStructureTreeRoot().GetK());
    global::DripSharp.Testing.JavaAssertions.Equal((singleCnt * 2), elementCounter.cnt, null);
    global::DripSharp.Testing.JavaAssertions.Equal((singleSetSize * 2), elementCounter.set.Count,
      null);
    doc.Dispose();
  }

  internal virtual void testStructureTreeMerge3() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    global::DripSharp.PdfCarton.Pdmodel.PDDocument src
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4408.pdf"))));
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter elementCounter
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter(this);
    elementCounter.walk(src.GetDocumentCatalog().GetStructureTreeRoot().GetK());
    int singleCnt = elementCounter.cnt;
    int singleSetSize = elementCounter.set.Count;
    global::DripSharp.Testing.JavaAssertions.Equal(25, singleCnt, null);
    global::DripSharp.Testing.JavaAssertions.Equal(25, singleSetSize, null);
    global::DripSharp.PdfCarton.Pdmodel.PDDocument dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4408.pdf"))));
    pdfMergerUtility.AppendDocument(dst, src);
    src.Dispose();
    dst.Save(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4408-merged.pdf")));
    dst.Dispose();
    dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4408-merged.pdf")));
    elementCounter
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter(this);
    elementCounter.walk(dst.GetDocumentCatalog().GetStructureTreeRoot().GetK());
    global::DripSharp.Testing.JavaAssertions.Equal((singleCnt * 2), elementCounter.cnt, null);
    global::DripSharp.Testing.JavaAssertions.Equal((singleSetSize * 2), elementCounter.set.Count,
      null);
    this.checkWithNumberTree(dst);
    this.checkForPageOrphans(dst);
    dst.Dispose();
    this.checkStructTreeRootCount(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4408-merged.pdf")));
  }

  internal virtual void testStructureTreeMerge4() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    global::DripSharp.PdfCarton.Pdmodel.PDDocument src
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4417-001031.pdf")));
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter elementCounter
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter(this);
    elementCounter.walk(src.GetDocumentCatalog().GetStructureTreeRoot().GetK());
    int singleCnt = elementCounter.cnt;
    int singleSetSize = elementCounter.set.Count;
    global::DripSharp.Testing.JavaAssertions.Equal(104, singleCnt, null);
    global::DripSharp.Testing.JavaAssertions.Equal(104, singleSetSize, null);
    global::DripSharp.PdfCarton.Pdmodel.PDDocument dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4417-001031.pdf")));
    pdfMergerUtility.AppendDocument(dst, src);
    src.Dispose();
    dst.Save(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-4417-001031-merged.pdf")));
    dst.Dispose();
    dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-4417-001031-merged.pdf")));
    elementCounter
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter(this);
    elementCounter.walk(dst.GetDocumentCatalog().GetStructureTreeRoot().GetK());
    global::DripSharp.Testing.JavaAssertions.Equal((singleCnt * 2), elementCounter.cnt, null);
    global::DripSharp.Testing.JavaAssertions.Equal((singleSetSize * 2), elementCounter.set.Count,
      null);
    this.checkWithNumberTree(dst);
    this.checkForPageOrphans(dst);
    dst.Dispose();
    this.checkStructTreeRootCount(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-4417-001031-merged.pdf")));
  }

  internal virtual void testStructureTreeMerge5() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    global::DripSharp.PdfCarton.Pdmodel.PDDocument src
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4417-054080.pdf")));
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter elementCounter
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter(this);
    elementCounter.walk(src.GetDocumentCatalog().GetStructureTreeRoot().GetK());
    int singleCnt = elementCounter.cnt;
    int singleSetSize = elementCounter.set.Count;
    global::DripSharp.PdfCarton.Pdmodel.PDDocument dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4417-054080.pdf")));
    pdfMergerUtility.AppendDocument(dst, src);
    src.Dispose();
    dst.Save(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-4417-054080-merged.pdf")));
    dst.Dispose();
    dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-4417-054080-merged.pdf")));
    this.checkWithNumberTree(dst);
    this.checkForPageOrphans(dst);
    elementCounter
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter(this);
    elementCounter.walk(dst.GetDocumentCatalog().GetStructureTreeRoot().GetK());
    global::DripSharp.Testing.JavaAssertions.Equal((singleCnt * 2), elementCounter.cnt, null);
    global::DripSharp.Testing.JavaAssertions.Equal((singleSetSize * 2), elementCounter.set.Count,
      null);
    dst.Dispose();
    this.checkStructTreeRootCount(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-4417-054080-merged.pdf")));
  }

  internal virtual void testStructureTreeMerge6() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    global::DripSharp.PdfCarton.Pdmodel.PDDocument src
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4418-000671.pdf"))));
    global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot
      = src.GetDocumentCatalog().GetStructureTreeRoot();
    global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode parentTree
      = structureTreeRoot.GetParentTree();
    global::System.Collections.Generic.IDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable> numberTreeAsMap
      = global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(parentTree);
    global::DripSharp.Testing.JavaAssertions.Equal(381,
      global::DripSharp.Runtime.JavaCompat.MapCount(numberTreeAsMap), null);
    global::DripSharp.Testing.JavaAssertions.Equal(743,
      (global::DripSharp.Runtime.JavaCompat.CollectionMax(global::DripSharp.Runtime.JavaCompat.MapKeySet(numberTreeAsMap))
      + 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(0,
      (int)((int)global::DripSharp.Runtime.JavaCompat.CollectionMin(global::DripSharp.Runtime.JavaCompat.MapKeySet(numberTreeAsMap))),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(743, structureTreeRoot.GetParentTreeNextKey(),
      null);
    global::DripSharp.PdfCarton.Pdmodel.PDDocument dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4418-000314.pdf"))));
    structureTreeRoot = dst.GetDocumentCatalog().GetStructureTreeRoot();
    parentTree = structureTreeRoot.GetParentTree();
    numberTreeAsMap
      = global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(parentTree);
    global::DripSharp.Testing.JavaAssertions.Equal(7,
      global::DripSharp.Runtime.JavaCompat.MapCount(numberTreeAsMap), null);
    global::DripSharp.Testing.JavaAssertions.Equal(328,
      (global::DripSharp.Runtime.JavaCompat.CollectionMax(global::DripSharp.Runtime.JavaCompat.MapKeySet(numberTreeAsMap))
      + 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(321,
      (int)((int)global::DripSharp.Runtime.JavaCompat.CollectionMin(global::DripSharp.Runtime.JavaCompat.MapKeySet(numberTreeAsMap))),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(408, structureTreeRoot.GetParentTreeNextKey(),
      null);
    pdfMergerUtility.AppendDocument(dst, src);
    src.Dispose();
    dst.Save(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4418-merged.pdf")));
    dst.Dispose();
    dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4418-merged.pdf")));
    this.checkWithNumberTree(dst);
    this.checkForPageOrphans(dst);
    structureTreeRoot = dst.GetDocumentCatalog().GetStructureTreeRoot();
    parentTree = structureTreeRoot.GetParentTree();
    numberTreeAsMap
      = global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(parentTree);
    global::DripSharp.Testing.JavaAssertions.Equal((381 + 7),
      global::DripSharp.Runtime.JavaCompat.MapCount(numberTreeAsMap), null);
    global::DripSharp.Testing.JavaAssertions.Equal((408 + 743),
      (global::DripSharp.Runtime.JavaCompat.CollectionMax(global::DripSharp.Runtime.JavaCompat.MapKeySet(numberTreeAsMap))
      + 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(321,
      (int)((int)global::DripSharp.Runtime.JavaCompat.CollectionMin(global::DripSharp.Runtime.JavaCompat.MapKeySet(numberTreeAsMap))),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal((408 + 743),
      structureTreeRoot.GetParentTreeNextKey(), null);
    dst.Dispose();
    this.checkStructTreeRootCount(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4418-merged.pdf")));
  }

  internal virtual void testStructureTreeMerge7() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    global::DripSharp.PdfCarton.Pdmodel.PDDocument src
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4423-000746.pdf"))));
    global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot
      = src.GetDocumentCatalog().GetStructureTreeRoot();
    global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode parentTree
      = structureTreeRoot.GetParentTree();
    global::System.Collections.Generic.IDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable> numberTreeAsMap
      = global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(parentTree);
    global::DripSharp.Testing.JavaAssertions.Equal(33,
      global::DripSharp.Runtime.JavaCompat.MapCount(numberTreeAsMap), null);
    global::DripSharp.Testing.JavaAssertions.Equal(64,
      (global::DripSharp.Runtime.JavaCompat.CollectionMax(global::DripSharp.Runtime.JavaCompat.MapKeySet(numberTreeAsMap))
      + 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(31,
      (int)((int)global::DripSharp.Runtime.JavaCompat.CollectionMin(global::DripSharp.Runtime.JavaCompat.MapKeySet(numberTreeAsMap))),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(126, structureTreeRoot.GetParentTreeNextKey(),
      null);
    global::DripSharp.PdfCarton.Pdmodel.PDDocument dst
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
    pdfMergerUtility.AppendDocument(dst, src);
    src.Dispose();
    dst.Save(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4423-merged.pdf")));
    dst.Dispose();
    dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4423-merged.pdf")));
    this.checkWithNumberTree(dst);
    this.checkForPageOrphans(dst);
    structureTreeRoot = dst.GetDocumentCatalog().GetStructureTreeRoot();
    parentTree = structureTreeRoot.GetParentTree();
    numberTreeAsMap
      = global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(parentTree);
    global::DripSharp.Testing.JavaAssertions.Equal(33,
      global::DripSharp.Runtime.JavaCompat.MapCount(numberTreeAsMap), null);
    global::DripSharp.Testing.JavaAssertions.Equal(64,
      (global::DripSharp.Runtime.JavaCompat.CollectionMax(global::DripSharp.Runtime.JavaCompat.MapKeySet(numberTreeAsMap))
      + 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(31,
      (int)((int)global::DripSharp.Runtime.JavaCompat.CollectionMin(global::DripSharp.Runtime.JavaCompat.MapKeySet(numberTreeAsMap))),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(64, structureTreeRoot.GetParentTreeNextKey(),
      null);
    dst.Dispose();
    this.checkStructTreeRootCount(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4423-merged.pdf")));
  }

  internal virtual void testMissingParentTreeNextKey() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    global::DripSharp.PdfCarton.Pdmodel.PDDocument src
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4418-000314.pdf"))));
    global::DripSharp.PdfCarton.Pdmodel.PDDocument dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4418-000314.pdf"))));
    dst.GetDocumentCatalog().GetStructureTreeRoot().GetCOSObject().RemoveItem(global::DripSharp.PdfCarton.Cos.COSName.ParentTreeNextKey);
    pdfMergerUtility.AppendDocument(dst, src);
    src.Dispose();
    dst.Save(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-4418-000314-merged.pdf")));
    dst.Dispose();
    dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-4418-000314-merged.pdf")));
    global::DripSharp.Testing.JavaAssertions.Equal(656,
      dst.GetDocumentCatalog().GetStructureTreeRoot().GetParentTreeNextKey(), null);
    dst.Dispose();
  }

  internal virtual void testStructureTreeMergeIDTree() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    global::DripSharp.PdfCarton.Pdmodel.PDDocument src
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4417-001031.pdf")));
    global::DripSharp.PdfCarton.Pdmodel.PDDocument dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4417-054080.pdf")));
    global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement> srcIDTree
      = src.GetDocumentCatalog().GetStructureTreeRoot().GetIDTree();
    global::System.Collections.Generic.IDictionary<string,
      global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement> srcIDTreeMap
      = global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getIDTreeAsMap(srcIDTree);
    global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement> dstIDTree
      = dst.GetDocumentCatalog().GetStructureTreeRoot().GetIDTree();
    global::System.Collections.Generic.IDictionary<string,
      global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement> dstIDTreeMap
      = global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getIDTreeAsMap(dstIDTree);
    int expectedTotal = (global::DripSharp.Runtime.JavaCompat.MapCount(srcIDTreeMap)
      + global::DripSharp.Runtime.JavaCompat.MapCount(dstIDTreeMap));
    global::DripSharp.Testing.JavaAssertions.Equal(192, expectedTotal, null);
    global::DripSharp.PdfCarton.Pdmodel.PDDocument emptyDest
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
    pdfMergerUtility.AppendDocument(emptyDest, src);
    src.Dispose();
    src = emptyDest;
    global::DripSharp.Testing.JavaAssertions.Equal(4,
      src.GetDocumentCatalog().GetStructureTreeRoot().GetParentTreeNextKey(), null);
    pdfMergerUtility.AppendDocument(dst, src);
    src.Dispose();
    dst.Save(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-4416-IDTree-merged.pdf")));
    dst.Dispose();
    dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-4416-IDTree-merged.pdf")));
    this.checkWithNumberTree(dst);
    this.checkForPageOrphans(dst);
    dstIDTree = dst.GetDocumentCatalog().GetStructureTreeRoot().GetIDTree();
    dstIDTreeMap = global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getIDTreeAsMap(dstIDTree);
    global::DripSharp.Testing.JavaAssertions.Equal(expectedTotal,
      global::DripSharp.Runtime.JavaCompat.MapCount(dstIDTreeMap), null);
    dst.Dispose();
    this.checkStructTreeRootCount(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-4416-IDTree-merged.pdf")));
  }

  internal virtual void testMergeBogusStructParents1() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument src
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-4408.pdf"))))) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4408.pdf"))))) {
      dst.GetDocumentCatalog().SetStructureTreeRoot((global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot)default!);
      dst.GetPage(0).SetStructParents(9999);
      global::DripSharp.Runtime.JavaCompat.ListGet(dst.GetPage(0).GetAnnotations(),
        0).SetStructParent(9998);
      pdfMergerUtility.AppendDocument(dst, src);
      this.checkWithNumberTree(dst);
      this.checkForPageOrphans(dst);
    }
  }

  internal virtual void testMergeBogusStructParents2() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument src
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-4408.pdf"))))) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument dst
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4408.pdf"))))) {
      src.GetDocumentCatalog().SetStructureTreeRoot((global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot)default!);
      src.GetPage(0).SetStructParents(9999);
      global::DripSharp.Runtime.JavaCompat.ListGet(src.GetPage(0).GetAnnotations(),
        0).SetStructParent(9998);
      pdfMergerUtility.AppendDocument(dst, src);
      this.checkWithNumberTree(dst);
      this.checkForPageOrphans(dst);
    }
  }

  internal virtual void testParentTree() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-3999-GeneralForbearance.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot
        = doc.GetDocumentCatalog().GetStructureTreeRoot();
      global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode parentTree
        = structureTreeRoot.GetParentTree();
      parentTree.GetValue(0);
      global::System.Collections.Generic.IDictionary<int,
        global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable> numberTreeAsMap
        = global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(parentTree);
      global::DripSharp.Testing.JavaAssertions.Equal(31,
        global::DripSharp.Runtime.JavaCompat.MapCount(numberTreeAsMap), null);
      global::DripSharp.Testing.JavaAssertions.Equal(31,
        (global::DripSharp.Runtime.JavaCompat.CollectionMax(global::DripSharp.Runtime.JavaCompat.MapKeySet(numberTreeAsMap))
        + 1), null);
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        (int)((int)global::DripSharp.Runtime.JavaCompat.CollectionMin(global::DripSharp.Runtime.JavaCompat.MapKeySet(numberTreeAsMap))),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(31, structureTreeRoot.GetParentTreeNextKey(),
        null);
    }
  }

  private void checkStructTreeRootCount(global::System.IO.FileInfo file) {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument pdf
      = global::DripSharp.PdfCarton.Loader.LoadPDF(file)) {
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Cos.COSObject> structTreeRootObjects
        = pdf.GetDocument().GetObjectsByType(global::DripSharp.PdfCarton.Cos.COSName.StructTreeRoot);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(structTreeRootObjects),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(file.ToString(),
        " "), structTreeRootObjects)));
    }
  }

  internal virtual void checkWithNumberTree(global::DripSharp.PdfCarton.Pdmodel.PDDocument document) {
    global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog documentCatalog
      = document.GetDocumentCatalog();
    global::DripSharp.Testing.JavaAssertions.NotEqual(-1,
      documentCatalog.GetStructureTreeRoot().GetParentTreeNextKey(), null);
    global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode parentTree
      = documentCatalog.GetStructureTreeRoot().GetParentTree();
    global::System.Collections.Generic.IDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable> numberTreeAsMap
      = global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(parentTree);
    global::System.Collections.Generic.ISet<int> keySet
      = global::DripSharp.Runtime.JavaCompat.MapKeySet(numberTreeAsMap);
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
      = documentCatalog.GetAcroForm();
    if ((acroForm != default!)) {
      foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field in acroForm.GetFieldTree()) {
        foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget in field.GetWidgets()) {
          if ((widget.GetStructParent() >= 0)) {
            global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(keySet,
              widget.GetStructParent()),
              global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("field '",
              field.GetFullyQualifiedName()), "' /StructParent "), widget.GetStructParent()),
              " missing in /ParentTree")));
          }
        }
      }
    }
    global::DripSharp.PdfCarton.Pdmodel.PDPageTree pageTree = document.GetPages();
    foreach (global::DripSharp.PdfCarton.Pdmodel.PDPage page in pageTree) {
      int pageNum = (pageTree.IndexOf(page) + 1);
      if ((page.GetStructParents() >= 0)) {
        global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(keySet,
          page.GetStructParents()), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("/StructParents ",
          page.GetStructParents()), " from page "), pageNum), " not found in /ParentTree")));
        global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDParentTreeValue obj
          = (global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDParentTreeValue)(global::DripSharp.Runtime.JavaCompat.MapGet(numberTreeAsMap,
          page.GetStructParents())!);
        global::DripSharp.Testing.JavaAssertions.True((obj.GetCOSObject() is global::DripSharp.PdfCarton.Cos.COSArray),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Expected array in page ",
          pageNum), ", got "), ((object)(obj)).GetType())));
        global::DripSharp.PdfCarton.Cos.COSArray array
          = (global::DripSharp.PdfCarton.Cos.COSArray)(obj.GetCOSObject()!);
        global::DripSharp.PdfCarton.Text.PDFMarkedContentExtractor markedContentExtractor
          = new global::DripSharp.PdfCarton.Text.PDFMarkedContentExtractor();
        markedContentExtractor.ProcessPage(page);
        global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Markedcontent.PDMarkedContent> markedContents
          = markedContentExtractor.GetMarkedContents();
        global::System.Collections.Generic.SortedSet<int> set
          = global::DripSharp.Runtime.JavaCompat.NewSortedSet<int>();
        foreach (global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Markedcontent.PDMarkedContent pdMarkedContent in markedContents) {
          global::DripSharp.PdfCarton.Cos.COSDictionary pdmcProperties
            = pdMarkedContent.GetProperties();
          if ((pdmcProperties == default!)) {
            continue;
          }
          int mcid = pdMarkedContent.GetMCID();
          if ((mcid >= 0)) {
            global::DripSharp.PdfCarton.Cos.COSDictionary dict
              = (global::DripSharp.PdfCarton.Cos.COSDictionary)(array.GetObject(mcid)!);
            global::DripSharp.Testing.JavaAssertions.NotNull(dict, null);
            set.Add(mcid);
            global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement structureElemen
              = (global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement)(global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureNode.Create(dict)!);
            global::System.Collections.Generic.IList<object> kids = structureElemen.GetKids();
            bool found = false;
            foreach (object kid in kids) {
              if (((kid is int) && (global::DripSharp.Runtime.JavaCompat.UnboxObject<int>((int?)kid)
                == mcid))) {
                found = true;
                break;
              }
              if ((kid is global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDMarkedContentReference)) {
                global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDMarkedContentReference mcr
                  = (global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDMarkedContentReference)(kid!);
                if ((mcid == mcr.GetMCID())) {
                  found = true;
                  if ((mcr.GetPage() != default!)) {
                    global::DripSharp.Testing.JavaAssertions.Equal(page, mcr.GetPage(), null);
                  } else {
                    global::DripSharp.Testing.JavaAssertions.Equal(page, structureElemen.GetPage(),
                      null);
                  }
                  break;
                }
              }
            }
            global::DripSharp.Testing.JavaAssertions.True(found,
              global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("page: ",
              pageNum), ", mcid: "), mcid), " not found")));
          }
        }
        global::DripSharp.Testing.JavaAssertions.True((set.Count == 0
          || (global::System.Linq.Enumerable.Last(set) <= (array.Size() - 1))), null);
      }
      foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation ann in page.GetAnnotations()) {
        if ((ann.GetStructParent() >= 0)) {
          global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(keySet,
            ann.GetStructParent()), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
            global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("/StructParent ",
            ann.GetStructParent()), " missing in /ParentTree")));
        }
      }
    }
  }

  internal virtual void testFileDeletion() {
    global::System.IO.FileInfo outFile
      = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4383-result.pdf"));
    global::System.IO.FileInfo inFile1
      = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4383-src1.pdf"));
    global::System.IO.FileInfo inFile2
      = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4383-src2.pdf"));
    this.createSimpleFile(inFile1);
    this.createSimpleFile(inFile2);
    using (global::System.IO.Stream @out
      = global::DripSharp.Runtime.JavaCompat.OpenFileOutput(outFile)) using (global::DripSharp.PdfCarton.IO.RandomAccessRead rar1
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(inFile1)) using (global::DripSharp.PdfCarton.IO.RandomAccessRead rar2
      = new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(inFile2)) {
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility merger
        = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
      merger.SetDestinationStream(@out);
      global::DripSharp.Testing.JavaAssertions.Equal(@out, merger.GetDestinationStream(), null);
      merger.AddSource(rar1);
      merger.AddSource(rar2);
      merger.MergeDocuments(global::DripSharp.PdfCarton.IO.IOUtils.CreateMemoryOnlyStreamCache());
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(outFile)) {
      global::DripSharp.Testing.JavaAssertions.Equal(2, doc.GetNumberOfPages(), null);
    }
    global::DripSharp.Runtime.JavaCompat.DeleteIfExists(new global::DripSharp.Runtime.JavaPath(inFile1.FullName));
    global::DripSharp.Runtime.JavaCompat.DeleteIfExists(new global::DripSharp.Runtime.JavaPath(inFile2.FullName));
    global::DripSharp.Runtime.JavaCompat.DeleteIfExists(new global::DripSharp.Runtime.JavaPath(outFile.FullName));
  }

  internal virtual void testPDFBox5198_2() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    pdfMergerUtility.AddSource(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFA3A.pdf")));
    pdfMergerUtility.AddSource(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFA3A.pdf")));
    pdfMergerUtility.SetDestinationFileName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR,
      "PDFA3A-merged2.pdf")));
    pdfMergerUtility.MergeDocuments(global::DripSharp.PdfCarton.IO.IOUtils.CreateMemoryOnlyStreamCache());
    this.checkParts(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR,
      "PDFA3A-merged2.pdf"))));
  }

  internal virtual void testPDFBox5198_3() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    pdfMergerUtility.AddSource(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFA3A.pdf")));
    pdfMergerUtility.AddSource(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFA3A.pdf")));
    pdfMergerUtility.AddSource(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFA3A.pdf")));
    pdfMergerUtility.SetDestinationFileName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR,
      "PDFA3A-merged3.pdf")));
    pdfMergerUtility.MergeDocuments(global::DripSharp.PdfCarton.IO.IOUtils.CreateMemoryOnlyStreamCache());
    this.checkParts(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR,
      "PDFA3A-merged3.pdf"))));
  }

  private void checkParts(global::System.IO.FileInfo file) {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(file)) {
      global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot
        = doc.GetDocumentCatalog().GetStructureTreeRoot();
      global::DripSharp.PdfCarton.Cos.COSDictionary topDict
        = (global::DripSharp.PdfCarton.Cos.COSDictionary)(structureTreeRoot.GetK()!);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Document,
        topDict.GetItem(global::DripSharp.PdfCarton.Cos.COSName.S), null);
      global::DripSharp.Testing.JavaAssertions.Equal(structureTreeRoot.GetCOSObject(),
        topDict.GetCOSDictionary(global::DripSharp.PdfCarton.Cos.COSName.P), null);
      global::DripSharp.PdfCarton.Cos.COSArray kArray
        = topDict.GetCOSArray(global::DripSharp.PdfCarton.Cos.COSName.K);
      global::DripSharp.Testing.JavaAssertions.Equal(doc.GetNumberOfPages(), kArray.Size(), null);
      for (int i = 0; (i < kArray.Size()); ++i) {
        global::DripSharp.PdfCarton.Cos.COSDictionary dict
          = (global::DripSharp.PdfCarton.Cos.COSDictionary)(kArray.GetObject(i)!);
        global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Part,
          dict.GetItem(global::DripSharp.PdfCarton.Cos.COSName.S), null);
        global::DripSharp.Testing.JavaAssertions.Equal(topDict,
          dict.GetCOSDictionary(global::DripSharp.PdfCarton.Cos.COSName.P), null);
      }
    }
  }

  private void checkForPageOrphans(global::DripSharp.PdfCarton.Pdmodel.PDDocument doc) {
    global::DripSharp.PdfCarton.Pdmodel.PDPageTree pageTree = doc.GetPages();
    global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot
      = doc.GetDocumentCatalog().GetStructureTreeRoot();
    this.checkElement(pageTree, structureTreeRoot.GetParentTree().GetCOSObject(),
      structureTreeRoot.GetCOSObject());
    global::DripSharp.Testing.JavaAssertions.NotNull(structureTreeRoot.GetK(), null);
    this.checkElement(pageTree, structureTreeRoot.GetK(), structureTreeRoot.GetCOSObject());
    this.checkForIDTreeOrphans(pageTree, structureTreeRoot);
    this.checkParentTreeAgainstK(structureTreeRoot);
  }

  private void checkParentTreeAgainstK(global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot) {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter elementCounter
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.ElementCounter(this);
    elementCounter.walk(structureTreeRoot.GetK());
    global::System.Collections.Generic.IDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable> numberTreeAsMap
      = global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(structureTreeRoot.GetParentTree());
    foreach (global::DripSharp.Runtime.JavaMapEntry<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable> entry in global::DripSharp.Runtime.JavaCompat.MapEntrySet(numberTreeAsMap)) {
      global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDParentTreeValue val
        = (global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDParentTreeValue)(entry.Value!);
      global::DripSharp.PdfCarton.Cos.COSBase @base = val.GetCOSObject();
      if ((@base is global::DripSharp.PdfCarton.Cos.COSArray)) {
        global::DripSharp.PdfCarton.Cos.COSArray array
          = (global::DripSharp.PdfCarton.Cos.COSArray)(@base!);
        for (int i = 0; (i < array.Size()); ++i) {
          global::DripSharp.PdfCarton.Cos.COSBase arrayElement = array.GetObject(i);
          if ((arrayElement is global::DripSharp.PdfCarton.Cos.COSDictionary)) {
            global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(elementCounter.set,
              arrayElement), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Element ",
              entry.Key), ":"), i), " from /ParentTree missing in /K ")));
          }
        }
      }
    }
  }

  private void checkForIDTreeOrphans(global::DripSharp.PdfCarton.Pdmodel.PDPageTree pageTree,
    global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot) {
    global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement> idTree
      = structureTreeRoot.GetIDTree();
    if ((idTree == default!)) {
      return;
    }
    global::System.Collections.Generic.IDictionary<string,
      global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement> map
      = global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getIDTreeAsMap(idTree);
    foreach (global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement element in map.Values) {
      if ((element.GetPage() != default!)) {
        this.checkForPage(pageTree, element);
      }
      if (!global::DripSharp.Runtime.JavaCompat.ListIsEmpty(element.GetKids())) {
        this.checkElement(pageTree,
          element.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.K),
          element.GetCOSObject());
      }
    }
  }

  private void createSimpleFile(global::System.IO.FileInfo file) {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      doc.AddPage(new global::DripSharp.PdfCarton.Pdmodel.PDPage());
      doc.Save(file);
    }
  }

  internal class ElementCounter {
    internal int cnt = 0;

    internal readonly global::System.Collections.Generic.ISet<global::DripSharp.PdfCarton.Cos.COSBase> set
      = new global::System.Collections.Generic.HashSet<global::DripSharp.PdfCarton.Cos.COSBase>();

    internal virtual void walk(global::DripSharp.PdfCarton.Cos.COSBase @base) {
      if ((@base is global::DripSharp.PdfCarton.Cos.COSArray)) {
        foreach (global::DripSharp.PdfCarton.Cos.COSBase __foreachValue_base2__949_30 in (global::DripSharp.PdfCarton.Cos.COSArray)(@base!)) {
          global::DripSharp.PdfCarton.Cos.COSBase base2__949_30 = __foreachValue_base2__949_30; {
            if ((base2__949_30 is global::DripSharp.PdfCarton.Cos.COSObject)) {
              base2__949_30
                = ((global::DripSharp.PdfCarton.Cos.COSObject)(base2__949_30!)).GetObject();
            }
            this.walk(base2__949_30);
          }
        }
      } else {
        if ((@base is global::DripSharp.PdfCarton.Cos.COSDictionary)) {
          global::DripSharp.PdfCarton.Cos.COSDictionary kdict
            = (global::DripSharp.PdfCarton.Cos.COSDictionary)(@base!);
          if (kdict.ContainsKey(global::DripSharp.PdfCarton.Cos.COSName.Pg)) {
            ++(this.cnt);
            this.set.Add(kdict);
          } else {
            if (kdict.ContainsKey(global::DripSharp.PdfCarton.Cos.COSName.K)) {
              global::DripSharp.PdfCarton.Cos.COSArray kidArray
                = kdict.GetCOSArray(global::DripSharp.PdfCarton.Cos.COSName.K);
              if ((kidArray != default!)) {
                for (int i = 0; (i < kidArray.Size()); ++i) {
                  global::DripSharp.PdfCarton.Cos.COSBase base2__975_37 = kidArray.GetObject(i);
                  if ((((base2__975_37 is global::DripSharp.PdfCarton.Cos.COSDictionary)
                    && ((global::DripSharp.PdfCarton.Cos.COSDictionary)(base2__975_37!)).ContainsKey(global::DripSharp.PdfCarton.Cos.COSName.Pg))
                    && ((global::DripSharp.PdfCarton.Cos.COSDictionary)(base2__975_37!)).ContainsKey(global::DripSharp.PdfCarton.Cos.COSName.Mcid))) {
                    ++(this.cnt);
                    this.set.Add(kdict);
                    break;
                  }
                }
              }
            }
          }
          if (kdict.ContainsKey(global::DripSharp.PdfCarton.Cos.COSName.K)) {
            this.walk(kdict.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.K));
          }
        }
      }
    }

    private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

    private static bool __RunUpstreamBeforeAll() {
      setUp();
      return true;
    }

    private readonly global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest __outer;

    internal ElementCounter(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest __outer) {
      this.__outer = __outer;
    }
  }

  private void checkElement(global::DripSharp.PdfCarton.Pdmodel.PDPageTree pageTree,
    global::DripSharp.PdfCarton.Cos.COSBase @base,
    global::DripSharp.PdfCarton.Cos.COSDictionary parentDict) {
    if ((@base is global::DripSharp.PdfCarton.Cos.COSArray)) {
      foreach (global::DripSharp.PdfCarton.Cos.COSBase __foreachValue_base2 in (global::DripSharp.PdfCarton.Cos.COSArray)(@base!)) {
        global::DripSharp.PdfCarton.Cos.COSBase base2 = __foreachValue_base2; {
          if ((base2 is global::DripSharp.PdfCarton.Cos.COSObject)) {
            base2 = ((global::DripSharp.PdfCarton.Cos.COSObject)(base2!)).GetObject();
          }
          this.checkElement(pageTree, base2, parentDict);
        }
      }
    } else {
      if ((@base is global::DripSharp.PdfCarton.Cos.COSDictionary)) {
        global::DripSharp.PdfCarton.Cos.COSDictionary kdict
          = (global::DripSharp.PdfCarton.Cos.COSDictionary)(@base!);
        if (kdict.ContainsKey(global::DripSharp.PdfCarton.Cos.COSName.Pg)) {
          global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement structureElement
            = new global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement(kdict);
          this.checkForPage(pageTree, structureElement);
        }
        if (kdict.ContainsKey(global::DripSharp.PdfCarton.Cos.COSName.K)) {
          this.checkElement(pageTree,
            kdict.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.K), kdict);
          global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureNode node
            = global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureNode.Create(kdict);
          foreach (object obj__1029_29 in node.GetKids()) {
            if ((obj__1029_29 is global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement)) {
              global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureNode parent
                = ((global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement)(obj__1029_29!)).GetParent();
              global::DripSharp.Testing.JavaAssertions.Same(parent.GetCOSObject(), kdict, null);
            }
          }
          return;
        }
        if (kdict.ContainsKey(global::DripSharp.PdfCarton.Cos.COSName.Kids)) {
          this.checkElement(pageTree,
            kdict.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Kids), kdict);
        } else {
          if (kdict.ContainsKey(global::DripSharp.PdfCarton.Cos.COSName.Nums)) {
            this.checkElement(pageTree,
              kdict.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Nums), kdict);
          }
        }
        if ((global::DripSharp.PdfCarton.Cos.COSName.Objr.Equals(kdict.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Type))
          || global::DripSharp.PdfCarton.Cos.COSName.Mcr.Equals(kdict.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Type)))) {
          global::DripSharp.Testing.JavaAssertions.False(((kdict.GetCOSDictionary(global::DripSharp.PdfCarton.Cos.COSName.Pg)
            == default!) && (parentDict.GetCOSDictionary(global::DripSharp.PdfCarton.Cos.COSName.Pg)
            == default!)), null);
        }
        if (kdict.ContainsKey(global::DripSharp.PdfCarton.Cos.COSName.Obj)) {
          global::DripSharp.PdfCarton.Cos.COSDictionary obj__1059_31
            = (global::DripSharp.PdfCarton.Cos.COSDictionary)(kdict.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Obj)!);
          global::DripSharp.PdfCarton.Cos.COSBase type
            = obj__1059_31.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Type);
          global::DripSharp.PdfCarton.Cos.COSBase subtype
            = obj__1059_31.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Subtype);
          if ((global::DripSharp.PdfCarton.Cos.COSName.Annot.Equals(type)
            || global::DripSharp.PdfCarton.Cos.COSName.Link.Equals(subtype))) {
            global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation annotation
              = global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation.CreateAnnotation(obj__1059_31);
            global::DripSharp.PdfCarton.Pdmodel.PDPage page = annotation.GetPage();
            if ((annotation is global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)) {
              global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink link
                = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)(annotation!);
              global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDDestination destination
                = link.GetDestination();
              if ((destination == default!)) {
                global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDAction action
                  = link.GetAction();
                if ((action is global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo)) {
                  global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo goToAction
                    = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo)(action!);
                  destination = goToAction.GetDestination();
                }
              }
              if ((destination is global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination)) {
                global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination pageDestination
                  = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination)(destination!);
                global::DripSharp.PdfCarton.Pdmodel.PDPage destPage = pageDestination.GetPage();
                if ((destPage != default!)) {
                  global::DripSharp.Testing.JavaAssertions.NotEqual(-1, pageTree.IndexOf(destPage),
                    global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                    global::DripSharp.Runtime.JavaCompat.Concat("Annotation destination page is not in the page tree: ",
                    destPage)));
                }
              }
            }
            if (((page != default!) && (pageTree.IndexOf(page) == -1))) {
              global::DripSharp.PdfCarton.Cos.COSBase item
                = kdict.GetItem(global::DripSharp.PdfCarton.Cos.COSName.Obj);
              if ((item is global::DripSharp.PdfCarton.Cos.COSObject)) {
                global::DripSharp.Testing.JavaAssertions.NotEqual(-1, pageTree.IndexOf(page),
                  global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                  global::DripSharp.Runtime.JavaCompat.Concat("Annotation page is not in the page tree: ",
                  item)));
              } else {
                global::DripSharp.Testing.JavaAssertions.NotEqual(-1, pageTree.IndexOf(page),
                  global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                  "Annotation page is not in the page tree"));
              }
            }
          } else {
            global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
          }
        }
      }
    }
  }

  private void checkMergeIdentical(string filename1, string filename2, string mergeFilename,
    global::DripSharp.PdfCarton.IO.RandomAccessStreamCache.StreamCacheCreateFunction streamCache) {
    int src1PageCount;
    global::SkiaSharp.SKBitmap[] src1ImageTab;
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument srcDoc1
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename1)), (string)default!)) {
      src1PageCount = srcDoc1.GetNumberOfPages();
      global::DripSharp.PdfCarton.Rendering.PDFRenderer src1PdfRenderer
        = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(srcDoc1);
      src1ImageTab = new global::SkiaSharp.SKBitmap[src1PageCount];
      for (int page__1129_22 = 0; (page__1129_22 < src1PageCount); ++page__1129_22) {
        src1ImageTab[page__1129_22] = src1PdfRenderer.RenderImageWithDPI(page__1129_22,
          (float)(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.DPI));
      }
    }
    int src2PageCount;
    global::SkiaSharp.SKBitmap[] src2ImageTab;
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument srcDoc2
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename2)), (string)default!)) {
      src2PageCount = srcDoc2.GetNumberOfPages();
      global::DripSharp.PdfCarton.Rendering.PDFRenderer src2PdfRenderer
        = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(srcDoc2);
      src2ImageTab = new global::SkiaSharp.SKBitmap[src2PageCount];
      for (int page__1142_22 = 0; (page__1142_22 < src2PageCount); ++page__1142_22) {
        src2ImageTab[page__1142_22] = src2PdfRenderer.RenderImageWithDPI(page__1142_22,
          (float)(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.DPI));
      }
    }
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    pdfMergerUtility.AddSource(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename1)));
    pdfMergerUtility.AddSource(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", filename2)));
    pdfMergerUtility.SetDestinationFileName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR,
      mergeFilename)));
    pdfMergerUtility.MergeDocuments(streamCache);
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument mergedDoc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", mergeFilename)),
      (string)default!)) {
      global::DripSharp.PdfCarton.Rendering.PDFRenderer mergePdfRenderer
        = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(mergedDoc);
      int mergePageCount = mergedDoc.GetNumberOfPages();
      global::DripSharp.Testing.JavaAssertions.Equal((src1PageCount + src2PageCount),
        mergePageCount, null);
      for (int page__1160_22 = 0; (page__1160_22 < src1PageCount); ++page__1160_22) {
        global::SkiaSharp.SKBitmap bim__1162_31 = mergePdfRenderer.RenderImageWithDPI(page__1160_22,
          (float)(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.DPI));
        this.checkImagesIdentical(bim__1162_31, src1ImageTab[page__1160_22]);
      }
      for (int page__1165_22 = 0; (page__1165_22 < src2PageCount); ++page__1165_22) {
        int mergePage = (page__1165_22 + src1PageCount);
        global::SkiaSharp.SKBitmap bim__1168_31 = mergePdfRenderer.RenderImageWithDPI(mergePage,
          (float)(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.DPI));
        this.checkImagesIdentical(bim__1168_31, src2ImageTab[page__1165_22]);
      }
    }
  }

  private void checkImagesIdentical(global::SkiaSharp.SKBitmap bim1,
    global::SkiaSharp.SKBitmap bim2) {
    global::DripSharp.Testing.JavaAssertions.Equal(bim1.Height, bim2.Height, null);
    global::DripSharp.Testing.JavaAssertions.Equal(bim1.Width, bim2.Width, null);
    int w = bim1.Width;
    int h = bim1.Height;
    for (int i = 0; (i < w); ++i) {
      for (int j = 0; (j < h); ++j) {
        global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(bim1,
          i, j), global::DripSharp.Runtime.PdfCartonFontCompat.GetRgb(bim2, i, j), null);
      }
    }
  }

  private void checkForPage(global::DripSharp.PdfCarton.Pdmodel.PDPageTree pageTree,
    global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement structureElement) {
    global::DripSharp.PdfCarton.Pdmodel.PDPage page = structureElement.GetPage();
    if ((page != default!)) {
      global::DripSharp.Testing.JavaAssertions.NotEqual(-1, pageTree.IndexOf(page),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Page is not in the page tree"));
    }
  }

  internal virtual void testSplitWithStructureTree() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4417-001031.pdf")))) {
      global::DripSharp.PdfCarton.Multipdf.Splitter splitter
        = new global::DripSharp.PdfCarton.Multipdf.Splitter();
      splitter.SetStartPage(1);
      splitter.SetEndPage(2);
      splitter.SetSplitAtPage(2);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.PDDocument> splitResult
        = splitter.Split(doc);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(splitResult), null);
      using (global::DripSharp.PdfCarton.Pdmodel.PDDocument dstDoc
        = global::DripSharp.Runtime.JavaCompat.ListGet(splitResult, 0)) {
        global::DripSharp.Testing.JavaAssertions.Equal(2, dstDoc.GetNumberOfPages(), null);
        this.checkForPageOrphans(dstDoc);
        global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot
          = dstDoc.GetDocumentCatalog().GetStructureTreeRoot();
        global::DripSharp.Testing.JavaAssertions.Equal(126,
          global::DripSharp.Runtime.JavaCompat.MapCount(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getIDTreeAsMap(structureTreeRoot.GetIDTree())),
          null);
        global::DripSharp.Testing.JavaAssertions.Equal(2,
          global::DripSharp.Runtime.JavaCompat.MapCount(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(structureTreeRoot.GetParentTree())),
          null);
        global::DripSharp.Testing.JavaAssertions.Equal(6,
          global::DripSharp.Runtime.JavaCompat.MapCount(structureTreeRoot.GetRoleMap()), null);
      }
    }
  }

  internal virtual void testSplitWithStructureTreeAndDestinations() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-5762-722238.pdf")))) {
      global::DripSharp.PdfCarton.Multipdf.Splitter splitter
        = new global::DripSharp.PdfCarton.Multipdf.Splitter();
      splitter.SetStartPage(1);
      splitter.SetEndPage(2);
      splitter.SetSplitAtPage(2);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.PDDocument> splitResult
        = splitter.Split(doc);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(splitResult), null);
      using (global::DripSharp.PdfCarton.Pdmodel.PDDocument dstDoc
        = global::DripSharp.Runtime.JavaCompat.ListGet(splitResult, 0)) {
        global::DripSharp.Testing.JavaAssertions.Equal(2, dstDoc.GetNumberOfPages(), null);
        this.checkForPageOrphans(dstDoc);
        global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot
          = dstDoc.GetDocumentCatalog().GetStructureTreeRoot();
        global::DripSharp.Testing.JavaAssertions.Equal(7,
          global::DripSharp.Runtime.JavaCompat.MapCount(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(structureTreeRoot.GetParentTree())),
          null);
        global::DripSharp.Testing.JavaAssertions.Equal(4,
          global::DripSharp.Runtime.JavaCompat.MapCount(structureTreeRoot.GetRoleMap()), null);
        global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotations
          = dstDoc.GetPage(0).GetAnnotations();
        global::DripSharp.Testing.JavaAssertions.Equal(5,
          global::DripSharp.Runtime.JavaCompat.CollectionCount(annotations), null);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink link1
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          0)!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink link2
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          1)!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink link3
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          2)!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink link4
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          3)!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink link5
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          4)!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination pd1
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination)(((global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo)(link1.GetAction()!)).GetDestination()!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination pd2
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination)(((global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo)(link2.GetAction()!)).GetDestination()!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination pd3
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination)(((global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo)(link3.GetAction()!)).GetDestination()!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination pd4
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination)(((global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo)(link4.GetAction()!)).GetDestination()!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination pd5
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination)(((global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo)(link5.GetAction()!)).GetDestination()!);
        global::DripSharp.PdfCarton.Pdmodel.PDPageTree pageTree = dstDoc.GetPages();
        global::DripSharp.Testing.JavaAssertions.Equal(0, pageTree.IndexOf(pd1.GetPage()), null);
        global::DripSharp.Testing.JavaAssertions.Equal(1, pageTree.IndexOf(pd2.GetPage()), null);
        global::DripSharp.Testing.JavaAssertions.Null(pd3.GetPage(), null);
        global::DripSharp.Testing.JavaAssertions.Null(pd4.GetPage(), null);
        global::DripSharp.Testing.JavaAssertions.Null(pd5.GetPage(), null);
      }
    }
  }

  internal virtual void testSplitWithStructureTreeAndDestinationsAndRemovedAnnotations() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-5762-722238.pdf")))) {
      global::DripSharp.PdfCarton.Multipdf.Splitter splitter
        = new global::DripSharp.PdfCarton.Multipdf.Splitter();
      foreach (global::DripSharp.PdfCarton.Pdmodel.PDPage page in doc.GetPages()) {
        page.SetAnnotations(global::System.Array.Empty<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>());
      }
      splitter.SetStartPage(1);
      splitter.SetEndPage(2);
      splitter.SetSplitAtPage(2);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.PDDocument> splitResult
        = splitter.Split(doc);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(splitResult), null);
      using (global::DripSharp.PdfCarton.Pdmodel.PDDocument dstDoc
        = global::DripSharp.Runtime.JavaCompat.ListGet(splitResult, 0)) {
        global::DripSharp.Testing.JavaAssertions.Equal(2, dstDoc.GetNumberOfPages(), null);
        this.checkForPageOrphans(dstDoc);
      }
    }
  }

  internal virtual void testSinglePageSplit() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-5792-240045.pdf")))) {
      global::DripSharp.PdfCarton.Multipdf.Splitter splitter
        = new global::DripSharp.PdfCarton.Multipdf.Splitter();
      splitter.SetSplitAtPage(1);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.PDDocument> splitResult
        = splitter.Split(doc);
      global::DripSharp.Testing.JavaAssertions.Equal(6,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(splitResult), null);
      foreach (global::DripSharp.PdfCarton.Pdmodel.PDDocument dstDoc__1316_29 in splitResult) {
        global::DripSharp.Testing.JavaAssertions.Equal(1, dstDoc__1316_29.GetNumberOfPages(), null);
        this.checkForPageOrphans(dstDoc__1316_29);
        foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation ann in dstDoc__1316_29.GetPage(0).GetAnnotations()) {
          global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink link
            = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)(ann!);
          global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo action
            = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo)(link.GetAction()!);
          global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination destination
            = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination)(action.GetDestination()!);
          global::DripSharp.Testing.JavaAssertions.Null(destination.GetPage(), null);
        }
      }
      global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot1
        = global::DripSharp.Runtime.JavaCompat.ListGet(splitResult,
        0).GetDocumentCatalog().GetStructureTreeRoot();
      global::DripSharp.Testing.JavaAssertions.Equal(6,
        global::DripSharp.Runtime.JavaCompat.MapCount(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(structureTreeRoot1.GetParentTree())),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(3,
        global::DripSharp.Runtime.JavaCompat.MapCount(structureTreeRoot1.GetRoleMap()), null);
      global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot2
        = global::DripSharp.Runtime.JavaCompat.ListGet(splitResult,
        1).GetDocumentCatalog().GetStructureTreeRoot();
      global::DripSharp.Testing.JavaAssertions.Equal(6,
        global::DripSharp.Runtime.JavaCompat.MapCount(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(structureTreeRoot2.GetParentTree())),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(3,
        global::DripSharp.Runtime.JavaCompat.MapCount(structureTreeRoot2.GetRoleMap()), null);
      global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot3
        = global::DripSharp.Runtime.JavaCompat.ListGet(splitResult,
        2).GetDocumentCatalog().GetStructureTreeRoot();
      global::DripSharp.Testing.JavaAssertions.Equal(6,
        global::DripSharp.Runtime.JavaCompat.MapCount(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(structureTreeRoot3.GetParentTree())),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(4,
        global::DripSharp.Runtime.JavaCompat.MapCount(structureTreeRoot3.GetRoleMap()), null);
      global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot4
        = global::DripSharp.Runtime.JavaCompat.ListGet(splitResult,
        3).GetDocumentCatalog().GetStructureTreeRoot();
      global::DripSharp.Testing.JavaAssertions.Equal(5,
        global::DripSharp.Runtime.JavaCompat.MapCount(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(structureTreeRoot4.GetParentTree())),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(4,
        global::DripSharp.Runtime.JavaCompat.MapCount(structureTreeRoot4.GetRoleMap()), null);
      global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot5
        = global::DripSharp.Runtime.JavaCompat.ListGet(splitResult,
        4).GetDocumentCatalog().GetStructureTreeRoot();
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.MapCount(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(structureTreeRoot5.GetParentTree())),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(6,
        global::DripSharp.Runtime.JavaCompat.MapCount(structureTreeRoot5.GetRoleMap()), null);
      global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot6
        = global::DripSharp.Runtime.JavaCompat.ListGet(splitResult,
        5).GetDocumentCatalog().GetStructureTreeRoot();
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.MapCount(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.getNumberTreeAsMap(structureTreeRoot6.GetParentTree())),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(7,
        global::DripSharp.Runtime.JavaCompat.MapCount(structureTreeRoot6.GetRoleMap()), null);
      foreach (global::DripSharp.PdfCarton.Pdmodel.PDDocument dstDoc__1346_29 in splitResult) {
        dstDoc__1346_29.Dispose();
      }
    }
  }

  internal virtual void testSplitWithPopupAnnotations() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-5809-509329.pdf")))) {
      global::DripSharp.PdfCarton.Multipdf.Splitter splitter
        = new global::DripSharp.PdfCarton.Multipdf.Splitter();
      splitter.SetStartPage(3);
      splitter.SetEndPage(3);
      splitter.SetSplitAtPage(1);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.PDDocument> splitResult
        = splitter.Split(doc);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(splitResult), null);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotations;
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationText annotationText3;
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationPopup annotationPopup4;
      using (global::DripSharp.PdfCarton.Pdmodel.PDDocument dstDoc
        = global::DripSharp.Runtime.JavaCompat.ListGet(splitResult, 0)) {
        this.checkForPageOrphans(dstDoc);
        global::DripSharp.Testing.JavaAssertions.Equal(1, dstDoc.GetNumberOfPages(), null);
        annotations = dstDoc.GetPage(0).GetAnnotations();
        global::DripSharp.Testing.JavaAssertions.Equal(5,
          global::DripSharp.Runtime.JavaCompat.CollectionCount(annotations), null);
        annotationText3
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationText)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          3)!);
        annotationPopup4
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationPopup)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          4)!);
        global::DripSharp.Testing.JavaAssertions.Equal(annotationText3.GetPopup(), annotationPopup4,
          null);
        global::DripSharp.Testing.JavaAssertions.Equal(annotationPopup4.GetParent(),
          annotationText3, null);
        global::DripSharp.Testing.JavaAssertions.Equal(annotationText3.GetPage(), dstDoc.GetPage(0),
          null);
      }
      annotations = doc.GetPage(2).GetAnnotations();
      global::DripSharp.Testing.JavaAssertions.Equal(5,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(annotations), null);
      annotationText3
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationText)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
        3)!);
      annotationPopup4
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationPopup)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
        4)!);
      global::DripSharp.Testing.JavaAssertions.Equal(annotationText3.GetPopup(), annotationPopup4,
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(annotationPopup4.GetParent(), annotationText3,
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(annotationText3.GetPage(), doc.GetPage(2),
        null);
    }
  }

  internal virtual void testSplitWithBrokenDestination() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-5811-362972.pdf")))) {
      global::DripSharp.PdfCarton.Multipdf.Splitter splitter
        = new global::DripSharp.PdfCarton.Multipdf.Splitter();
      splitter.SetStartPage(2);
      splitter.SetEndPage(2);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.PDDocument> splitResult
        = splitter.Split(doc);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(splitResult), null);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotations;
      using (global::DripSharp.PdfCarton.Pdmodel.PDDocument dstDoc
        = global::DripSharp.Runtime.JavaCompat.ListGet(splitResult, 0)) {
        this.checkForPageOrphans(dstDoc);
        global::DripSharp.Testing.JavaAssertions.Equal(1, dstDoc.GetNumberOfPages(), null);
        annotations = dstDoc.GetPage(0).GetAnnotations();
        global::DripSharp.Testing.JavaAssertions.Equal(1,
          global::DripSharp.Runtime.JavaCompat.CollectionCount(annotations), null);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink link__1407_34
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          0)!);
        global::DripSharp.Testing.JavaAssertions.Null(link__1407_34.GetDestination(), null);
      }
      annotations = doc.GetPage(1).GetAnnotations();
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(annotations), null);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink link__1413_30
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
        0)!);
      global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
        => { link__1413_30.GetDestination(); }, null);
    }
  }

  internal virtual void testSplitWithNamedDestinations() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-5840-410609.pdf")))) {
      global::DripSharp.PdfCarton.Multipdf.Splitter splitter
        = new global::DripSharp.PdfCarton.Multipdf.Splitter();
      splitter.SetSplitAtPage(6);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.PDDocument> splitResult
        = splitter.Split(doc);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(splitResult), null);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotations;
      using (global::DripSharp.PdfCarton.Pdmodel.PDDocument dstDoc
        = global::DripSharp.Runtime.JavaCompat.ListGet(splitResult, 0)) {
        this.checkForPageOrphans(dstDoc);
        global::DripSharp.Testing.JavaAssertions.Equal(6, dstDoc.GetNumberOfPages(), null);
        annotations = dstDoc.GetPage(0).GetAnnotations();
        global::DripSharp.Testing.JavaAssertions.Equal(5,
          global::DripSharp.Runtime.JavaCompat.CollectionCount(annotations), null);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink link1
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          0)!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink link2
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          1)!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink link3
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          2)!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink link4
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          3)!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink link5
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          4)!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination pd1
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination)(((global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo)(link1.GetAction()!)).GetDestination()!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination pd2
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination)(((global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo)(link2.GetAction()!)).GetDestination()!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination pd3
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination)(((global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo)(link3.GetAction()!)).GetDestination()!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination pd4
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination)(((global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo)(link4.GetAction()!)).GetDestination()!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination pd5
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDPageDestination)(((global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo)(link5.GetAction()!)).GetDestination()!);
        global::DripSharp.PdfCarton.Pdmodel.PDPageTree pageTree = dstDoc.GetPages();
        global::DripSharp.Testing.JavaAssertions.Equal(0, pageTree.IndexOf(pd1.GetPage()), null);
        global::DripSharp.Testing.JavaAssertions.Equal(1, pageTree.IndexOf(pd2.GetPage()), null);
        global::DripSharp.Testing.JavaAssertions.Equal(3, pageTree.IndexOf(pd3.GetPage()), null);
        global::DripSharp.Testing.JavaAssertions.Equal(3, pageTree.IndexOf(pd4.GetPage()), null);
        global::DripSharp.Testing.JavaAssertions.Equal(5, pageTree.IndexOf(pd5.GetPage()), null);
        global::DripSharp.Testing.JavaAssertions.NotNull(dstDoc.GetDocumentCatalog().GetMetadata(),
          null);
        global::DripSharp.Runtime.JavaByteArrayOutputStream baos
          = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
        dstDoc.Save(baos);
        global::DripSharp.PdfCarton.Pdmodel.PDDocument reloadedDoc
          = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
        global::DripSharp.Testing.JavaAssertions.NotNull(reloadedDoc.GetDocumentCatalog().GetMetadata(),
          null);
        reloadedDoc.Dispose();
      }
      annotations = doc.GetPage(0).GetAnnotations();
      global::DripSharp.Testing.JavaAssertions.Equal(5,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(annotations), null);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink link
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
        0)!);
      global::DripSharp.Testing.JavaAssertions.True((((global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo)(link.GetAction()!)).GetDestination() is global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDNamedDestination),
        null);
    }
  }

  internal virtual void testSplitWithPgEntryAtTheTop() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-6009.pdf"))))) {
      global::DripSharp.PdfCarton.Multipdf.Splitter splitter
        = new global::DripSharp.PdfCarton.Multipdf.Splitter();
      splitter.SetSplitAtPage(1);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.PDDocument> splitResult
        = splitter.Split(doc);
      global::DripSharp.Testing.JavaAssertions.Equal(3,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(splitResult), null);
      foreach (global::DripSharp.PdfCarton.Pdmodel.PDDocument dstDoc in splitResult) {
        global::DripSharp.Testing.JavaAssertions.Equal(1, dstDoc.GetNumberOfPages(), null);
        this.checkWithNumberTree(dstDoc);
        this.checkForPageOrphans(dstDoc);
      }
      global::DripSharp.Runtime.JavaCompat.ForEach(splitResult,
        global::DripSharp.PdfCarton.IO.IOUtils.CloseQuietly);
    }
  }

  internal virtual void testSplitWithOrphanPopupAnnotation() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.SRCDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-6018-099267-p9-OrphanPopups.pdf")))) {
      global::DripSharp.PdfCarton.Multipdf.Splitter splitter
        = new global::DripSharp.PdfCarton.Multipdf.Splitter();
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.PDDocument> splitResult
        = splitter.Split(doc);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(splitResult), null);
      using (global::DripSharp.PdfCarton.Pdmodel.PDDocument dstDoc
        = global::DripSharp.Runtime.JavaCompat.ListGet(splitResult, 0)) {
        global::DripSharp.Testing.JavaAssertions.Equal(1, dstDoc.GetNumberOfPages(), null);
        global::DripSharp.PdfCarton.Pdmodel.PDPage page = dstDoc.GetPage(0);
        global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotations
          = page.GetAnnotations();
        global::DripSharp.Testing.JavaAssertions.Equal(2,
          global::DripSharp.Runtime.JavaCompat.CollectionCount(annotations), null);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationText ann0
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationText)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          0)!);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationText ann1
          = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationText)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
          1)!);
        global::DripSharp.Testing.JavaAssertions.Equal(page, ann0.GetPage(), null);
        global::DripSharp.Testing.JavaAssertions.Equal(page, ann1.GetPage(), null);
        global::DripSharp.Testing.JavaAssertions.Equal(ann0, ann0.GetPopup().GetParent(), null);
        global::DripSharp.Testing.JavaAssertions.Equal(ann1, ann1.GetPopup().GetParent(), null);
      }
    }
  }

  internal virtual void testOutlinesSelfParent() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    pdfMergerUtility.AddSource(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-5939-google-docs-1.pdf"))));
    pdfMergerUtility.AddSource(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-5939-google-docs-1.pdf"))));
    pdfMergerUtility.SetDestinationFileName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR,
      "PDFBOX-5939-google-docs-result.pdf")));
    pdfMergerUtility.MergeDocuments(global::DripSharp.PdfCarton.IO.IOUtils.CreateMemoryOnlyStreamCache());
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument mergedDoc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBOX-5939-google-docs-result.pdf")))) {
      global::DripSharp.Testing.JavaAssertions.Equal(2, mergedDoc.GetNumberOfPages(), null);
    }
  }

  internal virtual void testPDFBox515() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility pdfMergerUtility
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    pdfMergerUtility.AddSource(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ComSquare1.pdf"))));
    pdfMergerUtility.AddSource(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Ghostscript1.pdf"))));
    pdfMergerUtility.SetDestinationFileName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR,
      "PDFBOX-515-result.pdf")));
    pdfMergerUtility.MergeDocuments(global::DripSharp.PdfCarton.IO.IOUtils.CreateMemoryOnlyStreamCache());
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument mergedDoc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Multipdf.PDFMergerUtilityTest.TARGETTESTDIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-515-result.pdf")))) {
      global::DripSharp.Testing.JavaAssertions.Equal(2, mergedDoc.GetNumberOfPages(), null);
      global::DripSharp.PdfCarton.Cos.COSDictionary imageDict
        = (global::DripSharp.PdfCarton.Cos.COSDictionary)(mergedDoc.GetDocumentInformation().GetCOSObject().GetCOSDictionary(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "ImPDF"))).GetCOSDictionary(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Images"))).GetCOSArray(global::DripSharp.PdfCarton.Cos.COSName.Kids).GetObject(0)!);
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject imageXObject
        = (global::DripSharp.PdfCarton.Pdmodel.Graphics.Image.PDImageXObject)(global::DripSharp.PdfCarton.Pdmodel.Graphics.PDXObject.CreateXObject(imageDict,
        new global::DripSharp.PdfCarton.Pdmodel.PDResources())!);
      global::SkiaSharp.SKBitmap bim = imageXObject.GetImage();
      global::DripSharp.Testing.JavaAssertions.Equal(909, bim.Width, null);
      global::DripSharp.Testing.JavaAssertions.Equal(233, bim.Height, null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_2730250012_d1db6b351412d01a() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testFileDeletion();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0289128527_f45d6e34427f1fa1() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testJpegCcitt();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1210741391_fe4bd69f160a86c9() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testMergeBogusStructParents1();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1210741392_24e0d4cc2d822626() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testMergeBogusStructParents2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1968833488_67ee094b85d6554d() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testMissingParentTreeNextKey();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2228919961_1197cb2a3202066a() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testOutlinesSelfParent();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0194179726_505a34b14a2ef30c() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBox515();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3782412825_333ea08bf7e45ebc() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBox5198_2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3782412826_d4dec97663a7d566() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFBox5198_3();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4102406938_7341b477dad79083() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFMergerOpenAction();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0236507570_38719d08e27c4f34() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFMergerUtility();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3036767424_55658774211f152d() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testPDFMergerUtility2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1188797850_5bfb5f2bdbe1fb03() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testParentTree();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3908465521_3e075c0c080b9ebc() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testSinglePageSplit();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3426129931_0b7bf34c90a2b8eb() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testSplitWithBrokenDestination();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0123291408_426afa71901db395() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testSplitWithNamedDestinations();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3303676261_8cd50f06b88f2911() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testSplitWithOrphanPopupAnnotation();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2227100324_fec7c14b098696ff() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testSplitWithPgEntryAtTheTop();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3563927942_97b6980fc9210bfb() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testSplitWithPopupAnnotations();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0548235203_166bf49a5b7b8543() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testSplitWithStructureTree();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0319976281_7ff63e6f9b44cb48() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testSplitWithStructureTreeAndDestinations();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0014007042_47d54c371a419940() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testSplitWithStructureTreeAndDestinationsAndRemovedAnnotations();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2413164345_3f09b443aa369172() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testStructureTreeMerge();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1793650713_6aa1fea6e5f8ef95() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testStructureTreeMerge2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1793650714_1f2b8260c3f06ec7() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testStructureTreeMerge3();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1793650715_bb59ce3c7228603d() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testStructureTreeMerge4();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1793650716_9941846e91d10dfc() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testStructureTreeMerge5();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1793650717_932b72512e223fed() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testStructureTreeMerge6();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1793650718_201b2fd2c9279ca5() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testStructureTreeMerge7();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0117167058_22e01653e6a5acff() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testStructureTreeMergeIDTree();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

  private static bool __RunUpstreamBeforeAll() {
    setUp();
    return true;
  }
}
