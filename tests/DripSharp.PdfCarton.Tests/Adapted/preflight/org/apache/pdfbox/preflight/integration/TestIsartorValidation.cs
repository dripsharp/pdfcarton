// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Integration;

public class TestIsartorValidation {
  private const string RESULTS_FILE = "results.file";

  private const string EXPECTED_ERRORS = "isartor.errors";

  private const string ISARTOR_FILES = "isartor.files";

  protected internal static readonly global::Microsoft.Extensions.Logging.ILogger Log
    = global::Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;

  private static global::DripSharp.PdfCarton.Preflight.Integration.InvalidFileTester tester = null!;

  internal static void setup() {
    global::DripSharp.PdfCarton.Preflight.Integration.TestIsartorValidation.tester
      = new global::DripSharp.PdfCarton.Preflight.Integration.InvalidFileTester(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.Integration.TestIsartorValidation.RESULTS_FILE));
  }

  internal static void closeDown() {
    global::DripSharp.PdfCarton.Preflight.Integration.TestIsartorValidation.tester.After();
  }

  internal virtual void validate(global::System.IO.FileInfo path, string expectedError) {
    global::DripSharp.PdfCarton.Preflight.Integration.TestIsartorValidation.tester.Validate(path,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", expectedError));
  }

  protected internal static global::System.Collections.Generic.ICollection<object[]> StopIfExpected() {
    global::System.Collections.Generic.IList<object[]> ret
      = new global::System.Collections.Generic.List<object[]>();
    global::DripSharp.Runtime.JavaCompat.Add(ret, new object[] { (object[])default!,
        (object[])default! });
    return ret;
  }

  public static global::System.Collections.Generic.ICollection<object[]> InitializeParameters() {
    string isartor
      = global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.Integration.TestIsartorValidation.ISARTOR_FILES));
    if ((isartor == default!)) {
      global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Preflight.Integration.TestIsartorValidation.Log,
        global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Preflight.Integration.TestIsartorValidation.ISARTOR_FILES,
        " (where are isartor pdf files) is not defined.")));
      return global::DripSharp.PdfCarton.Preflight.Integration.TestIsartorValidation.StopIfExpected();
    }
    global::System.IO.FileInfo root
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      isartor));
    string expectedPath
      = global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.Integration.TestIsartorValidation.EXPECTED_ERRORS));
    if ((expectedPath == default!)) {
      global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Preflight.Integration.TestIsartorValidation.Log,
        global::DripSharp.Runtime.JavaCompat.StringValueOf("'expected.errors' not defined, so cannot execute tests"));
      return global::DripSharp.PdfCarton.Preflight.Integration.TestIsartorValidation.StopIfExpected();
    }
    global::System.IO.FileInfo expectedFile
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      expectedPath));
    if ((!global::System.IO.File.Exists(expectedFile.FullName)
      || !global::DripSharp.Runtime.JavaCompat.FileIsFile(expectedFile))) {
      global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Preflight.Integration.TestIsartorValidation.Log,
        global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("'expected.errors' does not reference valid file, so cannot execute tests : ",
        expectedFile.FullName)));
      return global::DripSharp.PdfCarton.Preflight.Integration.TestIsartorValidation.StopIfExpected();
    }
    global::System.IO.Stream expected
      = global::DripSharp.Runtime.JavaCompat.OpenFileInput(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      expectedPath));
    global::DripSharp.Runtime.JavaProperties props = new global::DripSharp.Runtime.JavaProperties();
    props.Load(expected);
    global::DripSharp.PdfCarton.Tests.Support.CloseQuietly(expected);
    global::System.Collections.Generic.IList<object[]> data
      = new global::System.Collections.Generic.List<object[]>();
    global::System.Collections.Generic.ICollection<object> files
      = global::DripSharp.PdfCarton.Tests.Support.ListFilesObjects(root, new string[] { "pdf" },
      true);
    foreach (object @object in files) {
      global::System.IO.FileInfo file = (global::System.IO.FileInfo)(@object!);
      string fn = file.Name;
      if ((props.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", fn))
        != default!)) {
        string expectedError
          = global::DripSharp.Runtime.JavaCompat.StringTrim(new global::DripSharp.Runtime.JavaStringTokenizer(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
          props.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", fn))),
          global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "//")).nextToken());
        global::DripSharp.Runtime.JavaCompat.Add(data, new object[] { file, expectedError });
      } else {
        global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
          global::DripSharp.Runtime.JavaCompat.Concat("No expected result for this file, will not try to validate : ",
          file.FullName)));
      }
    }
    return data;
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_83b16b6db40c5f6b() {
    foreach (var value in InitializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::System.IO.FileInfo>(row[0]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[1]) };
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_83b16b6db40c5f6b))]
  public void __Upstream_0726210838_845c0eb0d722c338(global::System.IO.FileInfo path,
    string expectedError) {
    setup();
    try {
      this.validate(path, expectedError);
    } finally {
      closeDown();
    }
  }
}
