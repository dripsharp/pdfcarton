// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight;

public class TestValidDirectory {
  internal virtual void validate(global::System.IO.FileInfo target) {
    if ((target != default!)) {
      (global::DripSharp.Runtime.JavaCompat.@out).WriteLine(target);
      global::DripSharp.PdfCarton.Preflight.ValidationResult result
        = global::DripSharp.PdfCarton.Preflight.Parser.PreflightParser.Validate(target);
      global::DripSharp.Testing.JavaAssertions.True(result.IsValid(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.Runtime.JavaCompat.Concat("Validation of ", target)));
    }
  }

  public static global::System.Collections.Generic.ICollection<global::System.IO.FileInfo> InitializeParameters() {
    global::System.IO.FileInfo directory = default!;
    string pdfPath
      = global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "pdfa.valid"), (string)default!);
    if (global::DripSharp.Runtime.JavaCompat.Equals("${user.pdfa.valid}", pdfPath)) {
      pdfPath = default!;
    }
    if ((pdfPath != default!)) {
      directory
        = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        pdfPath));
      if (!global::System.IO.File.Exists((directory!).FullName)) {
        throw new global::System.IO.IOException(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
          global::DripSharp.Runtime.JavaCompat.Concat("directory does not exists : ",
          directory!.FullName)));
      }
      if (!global::DripSharp.Runtime.JavaCompat.FileIsDirectory(directory!)) {
        throw new global::System.IO.IOException(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
          global::DripSharp.Runtime.JavaCompat.Concat("not a directory : ", directory!.FullName)));
      }
    } else {
      global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        "System property 'pdfa.valid' not defined, will not run TestValidaDirectory"));
    }
    if ((directory! == default!)) {
      global::System.Collections.Generic.IList<global::System.IO.FileInfo> data__81_24
        = new global::System.Collections.Generic.List<global::System.IO.FileInfo>(1);
      global::DripSharp.Runtime.JavaCompat.Add(data__81_24, default!);
      return data__81_24;
    } else {
      global::System.IO.FileInfo[] files
        = global::DripSharp.Runtime.JavaCompat.FileListFiles(directory!);
      global::System.Collections.Generic.IList<global::System.IO.FileInfo> data__88_24
        = new global::System.Collections.Generic.List<global::System.IO.FileInfo>(files.Length);
      foreach (global::System.IO.FileInfo file in files) {
        if (global::DripSharp.Runtime.JavaCompat.FileIsFile(file)) {
          global::DripSharp.Runtime.JavaCompat.Add(data__88_24, file);
        }
      }
      return data__88_24;
    }
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_13c6df9127953619() {
    foreach (var value in InitializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::System.IO.FileInfo>(row[0]) };
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_13c6df9127953619))]
  public void __Upstream_0726210838_504f43fe4d81f900(global::System.IO.FileInfo target) {
    try {
      this.validate(target);
    } finally {
    }
  }
}
