// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Annotation;

public class PDSquareAnnotationTest {
  private const double DELTA = 1.0E-4D;

  internal static global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle rectangle = null!;

  private static readonly global::System.IO.FileInfo IN_DIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "src/test/resources/org/apache/pdfbox/pdmodel/interactive/annotation"));

  private const string NAME_OF_PDF = "PDSquareAnnotationTest.pdf";

  internal static void setUp() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle
      = new global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle();
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle.SetLowerLeftX(91.5958F);
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle.SetLowerLeftY(741.91F);
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle.SetUpperRightX(113.849F);
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle.SetUpperRightY(757.078F);
  }

  internal virtual void createDefaultSquareAnnotation() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation annotation
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationSquare();
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Annot,
      annotation.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Type), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationSquare.SubType,
      annotation.GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.Subtype),
      null);
  }

  internal virtual void createWithAppearance() {
    int borderWidth = 1;
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.PDPage page
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
      document.AddPage(page);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotations
        = page.GetAnnotations();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationSquareCircle annotation
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationSquare();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDBorderStyleDictionary borderThin
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDBorderStyleDictionary();
      borderThin.SetWidth((float)(borderWidth));
      global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDColor red
        = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDColor(new float[] { 1, 0, 0 },
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Color.PDDeviceRGB.Instance);
      annotation.SetContents(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Square Annotation"));
      annotation.SetColor(red);
      annotation.SetBorderStyle(borderThin);
      annotation.SetRectangle(global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle);
      annotation.ConstructAppearances();
      global::DripSharp.Runtime.JavaCompat.Add(annotations, annotation);
    }
  }

  internal virtual void validateAppearance() {
    int borderWidth = 1;
    global::System.IO.FileInfo file
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.IN_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.NAME_OF_PDF)));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document
      = global::DripSharp.PdfCarton.Loader.LoadPDF(file)) {
      global::DripSharp.PdfCarton.Pdmodel.PDPage page = document.GetPage(0);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotations
        = page.GetAnnotations();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationSquareCircle annotation
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationSquareCircle)(global::DripSharp.Runtime.JavaCompat.ListGet(annotations,
        0)!);
      global::DripSharp.Testing.JavaAssertions.NotNull(annotation.GetAppearance(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Appearance dictionary shall not be null"));
      global::DripSharp.Testing.JavaAssertions.NotNull(annotation.GetAppearance().GetNormalAppearance(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Normal appearance shall not be null"));
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAppearanceStream appearanceStream
        = annotation.GetAppearance().GetNormalAppearance().GetAppearanceStream();
      global::DripSharp.Testing.JavaAssertions.NotNull(appearanceStream,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Appearance stream shall not be null"));
      global::DripSharp.Testing.JavaAssertions.Equal((double)(global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle.GetLowerLeftX()),
        (double)(appearanceStream.GetBBox().GetLowerLeftX()), null,
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.DELTA);
      global::DripSharp.Testing.JavaAssertions.Equal((double)(global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle.GetLowerLeftY()),
        (double)(appearanceStream.GetBBox().GetLowerLeftY()), null,
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.DELTA);
      global::DripSharp.Testing.JavaAssertions.Equal((double)(global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle.GetWidth()),
        (double)(appearanceStream.GetBBox().GetWidth()), null,
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.DELTA);
      global::DripSharp.Testing.JavaAssertions.Equal((double)(global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle.GetHeight()),
        (double)(appearanceStream.GetBBox().GetHeight()), null,
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.DELTA);
      global::DripSharp.PdfCarton.Util.Matrix matrix = appearanceStream.GetMatrix();
      global::DripSharp.Testing.JavaAssertions.NotNull(matrix,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Matrix shall not be null"));
      global::DripSharp.Testing.JavaAssertions.Equal((double)(-(global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle.GetLowerLeftX())),
        (double)(matrix.GetTranslateX()), null,
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.DELTA);
      global::DripSharp.Testing.JavaAssertions.Equal((double)(-(global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle.GetLowerLeftY())),
        (double)(matrix.GetTranslateY()), null,
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.DELTA);
      global::DripSharp.PdfCarton.Pdmodel.Common.PDStream contentStream
        = appearanceStream.GetContentStream();
      global::DripSharp.Testing.JavaAssertions.NotNull(contentStream,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Content stream shall not be null"));
      global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser parser
        = new global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser(appearanceStream);
      global::System.Collections.Generic.IList<object> tokens = parser.Parse();
      global::DripSharp.Testing.JavaAssertions.Equal(10,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(tokens), null);
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        ((global::DripSharp.PdfCarton.Cos.COSInteger)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens,
        0)!)).IntValue(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        ((global::DripSharp.PdfCarton.Cos.COSInteger)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens,
        1)!)).IntValue(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        ((global::DripSharp.PdfCarton.Cos.COSInteger)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens,
        2)!)).IntValue(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("RG",
        ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens,
        3)!)).GetName(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((double)((global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle.GetLowerLeftX()
        + borderWidth)),
        (double)(((global::DripSharp.PdfCarton.Cos.COSFloat)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens,
        4)!)).FloatValue()), null,
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.DELTA);
      global::DripSharp.Testing.JavaAssertions.Equal((double)((global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle.GetLowerLeftY()
        + borderWidth)),
        (double)(((global::DripSharp.PdfCarton.Cos.COSFloat)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens,
        5)!)).FloatValue()), null,
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.DELTA);
      global::DripSharp.Testing.JavaAssertions.Equal((double)((global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle.GetWidth()
        - (2 * borderWidth))),
        (double)(((global::DripSharp.PdfCarton.Cos.COSFloat)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens,
        6)!)).FloatValue()), null,
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.DELTA);
      global::DripSharp.Testing.JavaAssertions.Equal((double)((global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.rectangle.GetHeight()
        - (2 * borderWidth))),
        (double)(((global::DripSharp.PdfCarton.Cos.COSFloat)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens,
        7)!)).FloatValue()), null,
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDSquareAnnotationTest.DELTA);
      global::DripSharp.Testing.JavaAssertions.Equal("re",
        ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens,
        8)!)).GetName(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("S",
        ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens,
        9)!)).GetName(), null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_0268727281_2cb08fba66d90746() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.createDefaultSquareAnnotation();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3799551462_b36d4f901a1a057a() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.createWithAppearance();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1729023514_fbce2361ab583093() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.validateAppearance();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

  private static bool __RunUpstreamBeforeAll() {
    setUp();
    return true;
  }
}
