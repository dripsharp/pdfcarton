// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Rendering;

public class TestRendering {
  private const string INPUT_DIR = "src/test/resources/input/rendering";

  private const string OUTPUT_DIR = "target/test-output/rendering";

  private const int MAX_NUM_FILES = 20;

  private static global::System.Collections.Generic.ICollection<object[]> data() {
    global::DripSharp.Runtime.JavaFile[] testFiles
      = global::DripSharp.PdfCarton.Tests.Support.ListFiles(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Rendering.TestRendering.INPUT_DIR)), (dir, name)
      => (global::DripSharp.Runtime.JavaCompat.StringEndsWith(name,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ".pdf"))
      || global::DripSharp.Runtime.JavaCompat.StringEndsWith(name,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ".ai"))));
    return global::DripSharp.Runtime.JavaCompat.ToListValues(global::DripSharp.Runtime.JavaCompat.Map(global::DripSharp.Runtime.JavaCompat.StreamOf(testFiles),
      (file) => new object[] { file.Name }));
  }

  private static global::System.Collections.Generic.ICollection<object[]> dataSubset() {
    global::DripSharp.Runtime.JavaFile[] testFiles
      = global::DripSharp.PdfCarton.Tests.Support.ListFiles(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Rendering.TestRendering.INPUT_DIR)), (dir, name)
      => (global::DripSharp.Runtime.JavaCompat.StringEndsWith(name,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ".pdf"))
      || global::DripSharp.Runtime.JavaCompat.StringEndsWith(name,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ".ai"))));
    return global::DripSharp.Runtime.JavaCompat.ToListValues(global::DripSharp.PdfCarton.Tests.Support.Limit(global::DripSharp.Runtime.JavaCompat.Map(global::DripSharp.Runtime.JavaCompat.StreamOf(testFiles),
      (file) => new object[] { file.Name }),
      (long)(global::DripSharp.PdfCarton.Rendering.TestRendering.MAX_NUM_FILES)));
  }

  internal virtual void render(string fileName) {
    global::DripSharp.Runtime.JavaFile file
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Rendering.TestRendering.INPUT_DIR),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", fileName));
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document
      = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
      "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
      new object[] { file })) {
      global::DripSharp.PdfCarton.Rendering.PDFRenderer renderer
        = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(document);
      global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => renderer.RenderImage(0), null);
    }
  }

  internal virtual void renderAndCompare(string fileName) {
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Rendering.TestRendering.OUTPUT_DIR)));
    if (!(global::DripSharp.Runtime.JavaFileBridge.Call<bool>(typeof(global::DripSharp.PdfCarton.Rendering.TestPDFToImage),
      "DoTestFile", new global::System.Type[] { typeof(global::System.IO.FileInfo), typeof(string),
        typeof(string) },
      new object[] { global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.PdfCarton.Rendering.TestRendering.INPUT_DIR),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", fileName)),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.PdfCarton.Rendering.TestRendering.INPUT_DIR),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.PdfCarton.Rendering.TestRendering.OUTPUT_DIR) }))) {
      global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
    }
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_7d79ca178630efaa() {
    foreach (var value in dataSubset()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]) };
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_7d79ca178630efaa))]
  public void __Upstream_1212891542_5147fad8ad619184(string fileName) {
    try {
      this.render(fileName);
    } finally {
    }
  }
}
