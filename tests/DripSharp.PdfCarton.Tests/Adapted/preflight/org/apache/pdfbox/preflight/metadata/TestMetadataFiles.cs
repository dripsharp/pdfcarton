// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Metadata;

public class TestMetadataFiles {
  internal virtual void validate() {
    string testfileDirectory = "src/test/resources/org/apache/pdfbox/preflight/metadata/";
    global::System.IO.FileInfo validFile
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(testfileDirectory,
      "PDFAMetaDataValidationTestTrailingNul.pdf")));
    global::DripSharp.Testing.JavaAssertions.True(this.checkPDF(validFile),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Metadata test file ",
      validFile), " has to be valid ")));
    global::System.IO.FileInfo invalidFile1
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(testfileDirectory,
      "PDFAMetaDataValidationTestTrailingSpaces.pdf")));
    global::DripSharp.Testing.JavaAssertions.False(this.checkPDF(invalidFile1),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Metadata test file ",
      invalidFile1), " has to be invalid ")));
    global::System.IO.FileInfo invalidFile2
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(testfileDirectory,
      "PDFAMetaDataValidationTestTrailingControlChar.pdf")));
    global::DripSharp.Testing.JavaAssertions.False(this.checkPDF(invalidFile2),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Metadata test file ",
      invalidFile2), " has to be invalid ")));
    global::System.IO.FileInfo invalidFile3
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(testfileDirectory,
      "PDFAMetaDataValidationTestMiddleNul.pdf")));
    global::DripSharp.Testing.JavaAssertions.False(this.checkPDF(invalidFile3),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Metadata test file ",
      invalidFile3), " has to be invalid ")));
    global::System.IO.FileInfo invalidFile4
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(testfileDirectory,
      "PDFAMetaDataValidationTestMiddleControlChar.pdf")));
    global::DripSharp.Testing.JavaAssertions.False(this.checkPDF(invalidFile4),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Metadata test file ",
      invalidFile4), " has to be invalid ")));
  }

  private bool checkPDF(global::System.IO.FileInfo pdf) {
    bool testResult = false;
    if (global::System.IO.File.Exists(pdf.FullName)) {
      global::DripSharp.PdfCarton.Preflight.ValidationResult result = default!;
      try {
        result = global::DripSharp.PdfCarton.Preflight.Parser.PreflightParser.Validate(pdf);
      } catch (global::System.IO.IOException e) {
        global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
      }
      if ((result! != default!)) {
        testResult = result!.IsValid();
      }
    } else {
      global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
    }
    return testResult;
  }

  [Xunit.Fact]
  public void __Upstream_0726210838_3966aa54e178caab() {
    try {
      this.validate();
    } finally {
    }
  }
}
