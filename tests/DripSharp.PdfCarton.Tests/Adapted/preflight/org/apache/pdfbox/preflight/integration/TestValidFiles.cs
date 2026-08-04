// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Integration;

public class TestValidFiles {
private const string RESULTS_FILE = "results.file";

private const string ISARTOR_FILES = "valid.files";

protected internal static global::System.IO.Stream IsartorResultFile = default!;

protected internal global::System.IO.FileInfo Path = null!;

protected internal static readonly global::Microsoft.Extensions.Logging.ILogger Log = global::Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;

protected internal global::Microsoft.Extensions.Logging.ILogger Logger = default!;

protected internal static global::System.Collections.Generic.ICollection<global::System.IO.FileInfo> StopIfExpected() {
global::System.Collections.Generic.IList<global::System.IO.FileInfo> ret = new global::System.Collections.Generic.List<global::System.IO.FileInfo>();
global::DripSharp.Runtime.JavaCompat.Add(ret, default!);
return ret;
}

public static global::System.Collections.Generic.ICollection<global::System.IO.FileInfo> InitializeParameters() {
string isartor = global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles.ISARTOR_FILES));
if (((isartor == default!) || (isartor.Length == 0))) {
global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles.Log, global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles.ISARTOR_FILES, " (where are isartor pdf files) is not defined.")));
return global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles.StopIfExpected();
}
global::System.IO.FileInfo root = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", isartor));
global::System.Collections.Generic.IList<global::System.IO.FileInfo> data = new global::System.Collections.Generic.List<global::System.IO.FileInfo>();
global::System.Collections.Generic.ICollection<object> files = global::DripSharp.PdfCarton.Tests.Support.ListFilesObjects(root, new string[] { "pdf" }, true);
foreach (object @object in files) {
global::System.IO.FileInfo file = (global::System.IO.FileInfo)(@object!);
global::DripSharp.Runtime.JavaCompat.Add(data, file);
}
return data;
}

internal static void beforeClass() {
string irp = global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles.RESULTS_FILE));
if ((irp == default!)) {
global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "No result file defined, will use standard error"));
global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles.IsartorResultFile = global::DripSharp.PdfCarton.Tests.Support.ErrorStream;
} else {
global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles.IsartorResultFile = global::DripSharp.Runtime.JavaCompat.OpenFileOutput(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", irp));
}
}

internal static void afterClass() {
global::DripSharp.PdfCarton.Tests.Support.CloseQuietly(global::DripSharp.PdfCarton.Preflight.Integration.TestValidFiles.IsartorResultFile);
}

internal virtual void validate(global::System.IO.FileInfo path) {
this.Logger = global::Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;
if ((path == default!)) {
global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(this.Logger, global::DripSharp.Runtime.JavaCompat.StringValueOf("This is an empty test"));
return;
}
global::DripSharp.PdfCarton.Preflight.ValidationResult result = global::DripSharp.PdfCarton.Preflight.Parser.PreflightParser.Validate(path);
global::DripSharp.Testing.JavaAssertions.False(result.IsValid(), global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(path, " : Isartor file should be invalid ("), path), ")")));
global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.Runtime.JavaCompat.CollectionCount(result.GetErrorsList()) > 0), global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.Runtime.JavaCompat.Concat(path, " : Should find at least one error")));
if ((global::DripSharp.Runtime.JavaCompat.CollectionCount(result.GetErrorsList()) > 0)) {
global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
}
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_a1b936598aca9989()
{
    foreach (var value in InitializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::System.IO.FileInfo>(row[0]) };
    }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_a1b936598aca9989))]
public void __Upstream_0726210838_8958b464d557b2cc(global::System.IO.FileInfo path)
{
        beforeClass();
        try
        {
            this.validate(path);
        }
        finally
        {
            afterClass();
        }
}
}
