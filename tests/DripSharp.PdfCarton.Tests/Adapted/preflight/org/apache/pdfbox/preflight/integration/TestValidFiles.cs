// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Integration;

public class TestValidFiles {
  private const string RESULTS_FILE = "results.file";

  private const string ISARTOR_FILES = "valid.files";

  protected internal static global::System.IO.Stream IsartorResultFile;

  internal global::DripSharp.Runtime.JavaFile path = null!;

  protected internal static readonly global::Microsoft.Extensions.Logging.ILogger Log;

  protected internal global::Microsoft.Extensions.Logging.ILogger Logger = default!;

  [global::DripSharp.Runtime.JavaFileBoundary]
  protected internal static global::System.Collections.Generic.ICollection<global::System.IO.FileInfo> StopIfExpected() {
    return global::DripSharp.Runtime.JavaFileBridge.Export<global::System.Collections.Generic.ICollection<global::System.IO.FileInfo>>(__JavaFile_StopIfExpected());
  }

  internal static global::System.Collections.Generic.ICollection<global::DripSharp.Runtime.JavaFile> __JavaFile_StopIfExpected() {
    global::System.Collections.Generic.IList<global::DripSharp.Runtime.JavaFile> ret
      = new global::System.Collections.Generic.List<global::DripSharp.Runtime.JavaFile>();
    global::DripSharp.Runtime.JavaCompat.Add(ret, default!);
    return ret;
  }

  [global::DripSharp.Runtime.JavaFileBoundary]
  public static global::System.Collections.Generic.ICollection<global::System.IO.FileInfo> InitializeParameters() {
    return global::DripSharp.Runtime.JavaFileBridge.Export<global::System.Collections.Generic.ICollection<global::System.IO.FileInfo>>(__JavaFile_InitializeParameters());
  }

  internal static global::System.Collections.Generic.ICollection<global::DripSharp.Runtime.JavaFile> __JavaFile_InitializeParameters() {
    string isartor
      = global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles.ISARTOR_FILES));
    if (((isartor == default!) || (isartor.Length == 0))) {
      global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles.Log,
        global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles.ISARTOR_FILES,
        " (where are isartor pdf files) is not defined.")));
      return global::DripSharp.Runtime.JavaFileBridge.Call<global::System.Collections.Generic.ICollection<global::DripSharp.Runtime.JavaFile>>(typeof(global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles),
        "StopIfExpected", new global::System.Type[] {  }, new object[] {  });
    }
    global::DripSharp.Runtime.JavaFile root
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      isartor));
    global::System.Collections.Generic.IList<global::DripSharp.Runtime.JavaFile> data
      = new global::System.Collections.Generic.List<global::DripSharp.Runtime.JavaFile>();
    global::System.Collections.Generic.ICollection<object> files
      = global::DripSharp.PdfCarton.Tests.Support.ListFilesObjects(root, new string[] { "pdf" },
      true);
    foreach (object @object in files) {
      global::DripSharp.Runtime.JavaFile file = (global::DripSharp.Runtime.JavaFile)(@object!);
      global::DripSharp.Runtime.JavaCompat.Add(data, file);
    }
    return data;
  }

  internal static void beforeClass() {
    string irp
      = global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles.RESULTS_FILE));
    if ((irp == default!)) {
      global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        "No result file defined, will use standard error"));
      global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles.IsartorResultFile
        = global::DripSharp.PdfCarton.Tests.Support.ErrorStream;
    } else {
      global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles.IsartorResultFile
        = global::DripSharp.Runtime.JavaCompat.OpenFileOutput(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        irp));
    }
  }

  internal static void afterClass() {
    global::DripSharp.PdfCarton.Tests.Support.CloseQuietly(global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles.IsartorResultFile);
  }

  internal virtual void validate(global::DripSharp.Runtime.JavaFile path) {
    this.Logger = global::Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;
    if ((path == default!)) {
      global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(this.Logger,
        global::DripSharp.Runtime.JavaCompat.StringValueOf("This is an empty test"));
      return;
    }
    global::DripSharp.PdfCarton.Preflight.ValidationResult result
      = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Preflight.ValidationResult>(typeof(global::DripSharp.PdfCarton.Preflight.Parser.PreflightParser),
      "Validate", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
      new object[] { (global::DripSharp.Runtime.JavaFile)path });
    global::DripSharp.Testing.JavaAssertions.False(result.IsValid(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(path,
      " : Isartor file should be invalid ("), path), ")")));
    global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.Runtime.JavaCompat.CollectionCount(result.GetErrorsList()) > 0),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(path, " : Should find at least one error")));
    if ((global::DripSharp.Runtime.JavaCompat.CollectionCount(result.GetErrorsList()) > 0)) {
      global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
    }
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_a1b936598aca9989() {
    foreach (var value in __JavaFile_InitializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<object>(row[0]) };
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_a1b936598aca9989))]
  public void __Upstream_0726210838_8958b464d557b2cc(object path) {
    beforeClass();
    try {
      this.validate(global::DripSharp.Runtime.JavaFileBridge.Import<global::DripSharp.Runtime.JavaFile>(path));
    } finally {
      afterClass();
    }
  }

  static TestValidFiles() {
    IsartorResultFile = default!;
    Log = global::Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;
  }
}
