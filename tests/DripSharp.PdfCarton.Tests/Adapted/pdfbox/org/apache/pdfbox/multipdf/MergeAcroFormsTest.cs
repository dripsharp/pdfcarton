// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Multipdf;

public class MergeAcroFormsTest {
  private static readonly global::System.IO.FileInfo IN_DIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "src/test/resources/org/apache/pdfbox/multipdf"));

  private static readonly global::System.IO.FileInfo OUT_DIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/test-output/merge/"));

  private static readonly global::System.IO.FileInfo TARGET_PDF_DIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/pdfs"));

  internal static void setUp() {
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Multipdf.MergeAcroFormsTest.OUT_DIR);
  }

  internal virtual void testLegacyModeMerge() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility merger
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    global::System.IO.FileInfo toBeMerged
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.MergeAcroFormsTest.IN_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "AcroFormForMerge.pdf")));
    global::System.IO.FileInfo pdfOutput
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.MergeAcroFormsTest.OUT_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBoxLegacyMerge-SameMerged.pdf")));
    merger.SetDestinationFileName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      pdfOutput.FullName));
    global::DripSharp.Testing.JavaAssertions.Equal(pdfOutput.FullName,
      merger.GetDestinationFileName(), null);
    merger.AddSource(toBeMerged);
    merger.AddSource(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      toBeMerged.FullName));
    merger.MergeDocuments((global::DripSharp.PdfCarton.IO.RandomAccessStreamCache.StreamCacheCreateFunction)default!);
    merger.SetAcroFormMergeMode(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.AcroFormMergeMode.PdfboxLegacyMode);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility.AcroFormMergeMode.PdfboxLegacyMode,
      merger.GetAcroFormMergeMode(), null);
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument compliantDocument
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.MergeAcroFormsTest.IN_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBoxLegacyMerge-SameMerged.pdf"))))) using (global::DripSharp.PdfCarton.Pdmodel.PDDocument toBeCompared
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.MergeAcroFormsTest.OUT_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "PDFBoxLegacyMerge-SameMerged.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm compliantAcroForm
        = compliantDocument.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm toBeComparedAcroForm
        = toBeCompared.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.CollectionCount(compliantAcroForm.GetFields()),
        global::DripSharp.Runtime.JavaCompat.CollectionCount(toBeComparedAcroForm.GetFields()),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "There shall be the same number of root fields"));
      foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField compliantField__87_26 in compliantAcroForm.GetFieldTree()) {
        global::DripSharp.Testing.JavaAssertions.NotNull(toBeComparedAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          compliantField__87_26.GetFullyQualifiedName())),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "There shall be a field with the same FQN"));
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField toBeComparedField__91_25
          = toBeComparedAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          compliantField__87_26.GetFullyQualifiedName()));
        this.compareFieldProperties(compliantField__87_26, toBeComparedField__91_25);
      }
      foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField toBeComparedField__95_26 in toBeComparedAcroForm.GetFieldTree()) {
        global::DripSharp.Testing.JavaAssertions.NotNull(compliantAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          toBeComparedField__95_26.GetFullyQualifiedName())),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "There shall be a field with the same FQN"));
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField compliantField__99_25
          = compliantAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          toBeComparedField__95_26.GetFullyQualifiedName()));
        this.compareFieldProperties(toBeComparedField__95_26, compliantField__99_25);
      }
    }
  }

  private void compareFieldProperties(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField sourceField,
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField toBeComapredField) {
    string[] keys = new string[] { "FT", "T", "TU", "TM", "Ff", "V", "DV", "Opts", "TI", "I",
      "Rect", "DA" };
    global::DripSharp.PdfCarton.Cos.COSDictionary sourceFieldCos = sourceField.GetCOSObject();
    global::DripSharp.PdfCarton.Cos.COSDictionary toBeComparedCos
      = toBeComapredField.GetCOSObject();
    foreach (string key in keys) {
      global::DripSharp.PdfCarton.Cos.COSBase sourceBase
        = sourceFieldCos.GetDictionaryObject(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        key));
      global::DripSharp.PdfCarton.Cos.COSBase toBeComparedBase
        = toBeComparedCos.GetDictionaryObject(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        key));
      if ((sourceBase != default!)) {
        global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.StringValueOf(sourceBase),
          global::DripSharp.Runtime.JavaCompat.StringValueOf(toBeComparedBase),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "The content of the field properties shall be the same"));
      } else {
        global::DripSharp.Testing.JavaAssertions.Null(toBeComparedBase,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "If the source property is null the compared property shall be null too"));
      }
    }
  }

  internal virtual void testAnnotsEntry() {
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility merger
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    global::System.IO.FileInfo f1
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.MergeAcroFormsTest.TARGET_PDF_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-1031-1.pdf")));
    global::System.IO.FileInfo f2
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.MergeAcroFormsTest.TARGET_PDF_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-1031-2.pdf")));
    global::System.IO.FileInfo pdfOutput
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.MergeAcroFormsTest.OUT_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-1031.pdf")));
    merger.SetDestinationFileName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      pdfOutput.FullName));
    merger.AddSource(f1);
    merger.AddSource(f2);
    merger.MergeDocuments((global::DripSharp.PdfCarton.IO.RandomAccessStreamCache.StreamCacheCreateFunction)default!);
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument mergedPDF
      = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfOutput)) {
      global::DripSharp.Testing.JavaAssertions.Equal(2, mergedPDF.GetNumberOfPages(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 2 pages"));
      global::DripSharp.Testing.JavaAssertions.NotNull(mergedPDF.GetPage(0).GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Annots),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "There shall be an /Annots entry for the first page"));
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(mergedPDF.GetPage(0).GetAnnotations()),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "There shall be 1 annotation for the first page"));
      global::DripSharp.Testing.JavaAssertions.NotNull(mergedPDF.GetPage(1).GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Annots),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "There shall be an /Annots entry for the second page"));
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(mergedPDF.GetPage(0).GetAnnotations()),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "There shall be 1 annotation for the second page"));
    }
  }

  internal virtual void testAPEntry() {
    global::System.IO.FileInfo file1
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.MergeAcroFormsTest.TARGET_PDF_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-1100-1.pdf")));
    global::System.IO.FileInfo file2
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.MergeAcroFormsTest.TARGET_PDF_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-1100-2.pdf")));
    global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility merger
      = new global::DripSharp.PdfCarton.Multipdf.PDFMergerUtility();
    global::System.IO.FileInfo pdfOutput
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Multipdf.MergeAcroFormsTest.OUT_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-1100.pdf")));
    merger.SetDestinationFileName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      pdfOutput.FullName));
    merger.AddSource(file1);
    merger.AddSource(file2);
    merger.MergeDocuments((global::DripSharp.PdfCarton.IO.RandomAccessStreamCache.StreamCacheCreateFunction)default!);
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument mergedPDF
      = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfOutput)) {
      global::DripSharp.Testing.JavaAssertions.Equal(2, mergedPDF.GetNumberOfPages(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 2 pages"));
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = mergedPDF.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField formField
        = acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Testfeld"));
      global::DripSharp.Testing.JavaAssertions.NotNull(formField.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Ap),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "There shall be an /AP entry for the field"));
      global::DripSharp.Testing.JavaAssertions.NotNull(formField.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.V),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "There shall be a /V entry for the field"));
      formField = acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Testfeld2"));
      global::DripSharp.Testing.JavaAssertions.NotNull(formField.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Ap),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "There shall be an /AP entry for the field"));
      global::DripSharp.Testing.JavaAssertions.NotNull(formField.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.V),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "There shall be a /V entry for the field"));
    }
  }

  [Xunit.Fact]
  public void __Upstream_0005875889_566906976e946e79() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testAPEntry();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0998372051_d0fdbebce2f160a8() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testAnnotsEntry();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1693049754_1e950b594dd7968c() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testLegacyModeMerge();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

  private static bool __RunUpstreamBeforeAll() {
    setUp();
    return true;
  }
}
