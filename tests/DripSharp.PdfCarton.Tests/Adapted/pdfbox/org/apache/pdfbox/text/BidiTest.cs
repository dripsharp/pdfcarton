// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Text;

public class BidiTest {
  private static readonly global::Microsoft.Extensions.Logging.ILogger LOG
    = global::Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;

  private static readonly global::System.IO.FileInfo IN_DIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "src/test/resources/org/apache/pdfbox/text/"));

  private static readonly global::System.IO.FileInfo OUT_DIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/test-output"));

  private const string NAME_OF_PDF = "BidiSample.pdf";

  private const string ENCODING = "UTF-8";

  private global::DripSharp.PdfCarton.Pdmodel.PDDocument document = null!;

  private global::DripSharp.PdfCarton.Text.PDFTextStripper stripper = null!;

  internal virtual void setUp() {
    global::DripSharp.Runtime.JavaCompat.CreateDirectories(new global::DripSharp.Runtime.JavaPath(global::DripSharp.PdfCarton.Text.BidiTest.OUT_DIR.FullName));
    this.document
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Text.BidiTest.IN_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Text.BidiTest.NAME_OF_PDF))));
    this.stripper = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
    this.stripper.SetLineSeparator(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "\n"));
  }

  internal virtual void testSorted() {
    global::System.IO.FileInfo testFile
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Text.BidiTest.IN_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Text.BidiTest.NAME_OF_PDF)));
    this.doTestFile(testFile, global::DripSharp.PdfCarton.Text.BidiTest.OUT_DIR, false, true);
  }

  internal virtual void testNotSorted() {
    global::System.IO.FileInfo testFile
      = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Text.BidiTest.IN_DIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Text.BidiTest.NAME_OF_PDF)));
    this.doTestFile(testFile, global::DripSharp.PdfCarton.Text.BidiTest.OUT_DIR, false, false);
  }

  internal virtual void tearDown() {
    this.document.Dispose();
  }

  private void doTestFile(global::System.IO.FileInfo inFile, global::System.IO.FileInfo outDir,
    bool bLogResult, bool bSort) {
    if (bSort) {
      global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Text.BidiTest.LOG,
        global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Preparing to parse ",
        inFile.Name), " for sorted test")));
    } else {
      global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Text.BidiTest.LOG,
        global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Preparing to parse ",
        inFile.Name), " for standard test")));
    }
    global::System.IO.FileInfo outFile;
    global::System.IO.FileInfo expectedFile;
    if (bSort) {
      outFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine(outDir.FullName,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(inFile.Name, "-sorted.txt"))));
      expectedFile
        = new global::System.IO.FileInfo(global::System.IO.Path.Combine(global::DripSharp.PdfCarton.Tests.Support.ParentFile(inFile).FullName,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(inFile.Name, "-sorted.txt"))));
    } else {
      outFile = new global::System.IO.FileInfo(global::System.IO.Path.Combine(outDir.FullName,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(inFile.Name, ".txt"))));
      expectedFile
        = new global::System.IO.FileInfo(global::System.IO.Path.Combine(global::DripSharp.PdfCarton.Tests.Support.ParentFile(inFile).FullName,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        global::DripSharp.Runtime.JavaCompat.Concat(inFile.Name, ".txt"))));
    }
    using (global::System.IO.Stream os
      = global::DripSharp.Runtime.JavaCompat.OpenFileOutput(outFile)) using (global::System.IO.TextWriter writer
      = new global::System.IO.StreamWriter(os,
      global::DripSharp.PdfCarton.Tests.Support.EncodingByName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Text.BidiTest.ENCODING)), 1024, false)) {
      this.stripper.SetSortByPosition(bSort);
      this.stripper.WriteText(this.document, writer);
    }
    if (bLogResult) {
      global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Text.BidiTest.LOG,
        global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Text for ",
        inFile.Name), ":")));
      global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Text.BidiTest.LOG,
        global::DripSharp.Runtime.JavaCompat.StringValueOf(this.stripper.GetText(this.document)));
    }
    if (!global::System.IO.File.Exists(expectedFile.FullName)) {
      global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
      return;
    }
    using (global::DripSharp.Runtime.JavaLineNumberReader expectedReader
      = new global::DripSharp.Runtime.JavaLineNumberReader(global::DripSharp.PdfCarton.Tests.Support.NewInputStreamReader(global::DripSharp.Runtime.JavaCompat.OpenFileInput(expectedFile),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Text.BidiTest.ENCODING)))) using (global::DripSharp.Runtime.JavaLineNumberReader actualReader
      = new global::DripSharp.Runtime.JavaLineNumberReader(global::DripSharp.PdfCarton.Tests.Support.NewInputStreamReader(global::DripSharp.Runtime.JavaCompat.OpenFileInput(outFile),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.PdfCarton.Text.BidiTest.ENCODING)))) {
      while (true) {
        string expectedLine = expectedReader.ReadLine();
        while (((expectedLine != default!)
          && (global::DripSharp.Runtime.JavaCompat.StringTrim(expectedLine).Length == 0))) {
          expectedLine = expectedReader.ReadLine();
        }
        string actualLine = actualReader.ReadLine();
        while (((actualLine != default!)
          && (global::DripSharp.Runtime.JavaCompat.StringTrim(actualLine).Length == 0))) {
          actualLine = actualReader.ReadLine();
        }
        if (!(this.stringsEqual(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          expectedLine), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          actualLine)))) {
          global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
        }
        if (((expectedLine == default!) || (actualLine == default!))) {
          break;
        }
      }
    }
  }

  private bool stringsEqual(string expected, string actual) {
    bool equals = true;
    if (((expected == default!) && (actual == default!))) {
      return true;
    } else {
      if (((expected != default!) && (actual != default!))) {
        expected = global::DripSharp.Runtime.JavaCompat.StringTrim(expected);
        actual = global::DripSharp.Runtime.JavaCompat.StringTrim(actual);
        char[] expectedArray = expected.ToCharArray();
        char[] actualArray = actual.ToCharArray();
        int expectedIndex = 0;
        int actualIndex = 0;
        while (((expectedIndex < expectedArray.Length) && (actualIndex < actualArray.Length))) {
          if (((int)(expectedArray[expectedIndex]) != (int)(actualArray[actualIndex]))) {
            equals = false;
            global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Text.BidiTest.LOG,
              global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Lines differ at index",
              " expected:"), expectedIndex), "-"), (int)(expectedArray[expectedIndex])),
              " actual:"), actualIndex), "-"), (int)(actualArray[actualIndex]))));
            break;
          }
          expectedIndex = this.skipWhitespace(expectedArray, expectedIndex);
          actualIndex = this.skipWhitespace(actualArray, actualIndex);
          expectedIndex++;
          actualIndex++;
        }
        if (equals) {
          if ((expectedIndex != expectedArray.Length)) {
            equals = false;
            global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Text.BidiTest.LOG,
              global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("Expected line is longer at:",
              expectedIndex)));
          }
          if ((actualIndex != actualArray.Length)) {
            equals = false;
            global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Text.BidiTest.LOG,
              global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("Actual line is longer at:",
              actualIndex)));
          }
        }
      } else {
        equals = ((((expected == default!) && (actual != default!))
          && (global::DripSharp.Runtime.JavaCompat.StringTrim(actual).Length == 0)) || (((actual
          == default!) && (expected != default!))
          && (global::DripSharp.Runtime.JavaCompat.StringTrim(expected).Length == 0)));
      }
    }
    return equals;
  }

  private int skipWhitespace(char[] array, int index) {
    if ((((int)(array[index]) == (int)' ') || ((int)(array[index]) > 256))) {
      while (((index < array.Length) && (((int)(array[index]) == (int)' ')
        || ((int)(array[index]) > 256)))) {
        index++;
      }
      index--;
    }
    return index;
  }

  [Xunit.Fact]
  public void __Upstream_4097564414_9fd6dec80f016149() {
    this.setUp();
    try {
      this.testNotSorted();
    } finally {
      this.tearDown();
    }
  }

  [Xunit.Fact]
  public void __Upstream_3870625263_2da028b332e062ae() {
    this.setUp();
    try {
      this.testSorted();
    } finally {
      this.tearDown();
    }
  }
}
