// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight;

public class TestInvalidDirectory {
  internal virtual void validate(global::DripSharp.Runtime.JavaFile target) {
    if ((target != default!)) {
      (global::DripSharp.Runtime.JavaCompat.@out).WriteLine(target);
      global::DripSharp.PdfCarton.Preflight.ValidationResult result
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Preflight.ValidationResult>(typeof(global::DripSharp.PdfCarton.Preflight.Parser.PreflightParser),
        "Validate", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { target });
      global::DripSharp.Testing.JavaAssertions.False(result.IsValid(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.Runtime.JavaCompat.Concat("Test of ", target)));
    }
  }

  [global::DripSharp.Runtime.JavaFileBoundary]
  public static global::System.Collections.Generic.ICollection<global::System.IO.FileInfo> InitializeParameters() {
    return global::DripSharp.Runtime.JavaFileBridge.Export<global::System.Collections.Generic.ICollection<global::System.IO.FileInfo>>(__JavaFile_InitializeParameters());
  }

  internal static global::System.Collections.Generic.ICollection<global::DripSharp.Runtime.JavaFile> __JavaFile_InitializeParameters() {
    global::DripSharp.Runtime.JavaFile directory = default!;
    string pdfPath
      = global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "pdfa.invalid"), (string)default!);
    if (global::DripSharp.Runtime.JavaCompat.Equals("${user.pdfa.invalid}", pdfPath)) {
      pdfPath = default!;
    }
    if ((pdfPath != default!)) {
      directory
        = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        pdfPath));
      if (!global::System.IO.File.Exists((directory!).FullName)) {
        throw new global::System.IO.IOException(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
          global::DripSharp.Runtime.JavaCompat.Concat("directory does not exists : ",
          global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(directory!))));
      }
      if (!global::DripSharp.Runtime.JavaCompat.FileIsDirectory(directory!)) {
        throw new global::System.IO.IOException(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
          global::DripSharp.Runtime.JavaCompat.Concat("not a directory : ",
          global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(directory!))));
      }
    } else {
      global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        "System property 'pdfa.invalid' not defined, will not run TestValidaDirectory"));
    }
    if ((directory! == default!)) {
      global::System.Collections.Generic.IList<global::DripSharp.Runtime.JavaFile> data__81_24
        = new global::System.Collections.Generic.List<global::DripSharp.Runtime.JavaFile>(1);
      global::DripSharp.Runtime.JavaCompat.Add(data__81_24, default!);
      return data__81_24;
    } else {
      global::DripSharp.Runtime.JavaFile[] files
        = global::DripSharp.Runtime.JavaCompat.FileListFiles(directory!);
      global::System.Collections.Generic.IList<global::DripSharp.Runtime.JavaFile> data__88_24
        = new global::System.Collections.Generic.List<global::DripSharp.Runtime.JavaFile>(files.Length);
      foreach (global::DripSharp.Runtime.JavaFile file in files) {
        if (global::DripSharp.Runtime.JavaCompat.FileIsFile(file)) {
          global::DripSharp.Runtime.JavaCompat.Add(data__88_24, file);
        }
      }
      return data__88_24;
    }
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_96304bcc76199075() {
    foreach (var value in __JavaFile_InitializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<object>(row[0]) };
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_96304bcc76199075))]
  public void __Upstream_0726210838_2eb90c1cace5df2a(object target) {
    try {
      this.validate(global::DripSharp.Runtime.JavaFileBridge.Import<global::DripSharp.Runtime.JavaFile>(target));
    } finally {
    }
  }
}
