// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight;

public class TestInvalidDirectory {
internal virtual void validate(global::System.IO.FileInfo target) {
if ((target != default!)) {
(global::DripSharp.Runtime.JavaCompat.@out).WriteLine(target);
global::DripSharp.PdfCarton.Preflight.ValidationResult result = global::DripSharp.PdfCarton.Preflight.Parser.PreflightParser.Validate(target);
global::DripSharp.Testing.JavaAssertions.False(result.IsValid(), global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.Runtime.JavaCompat.Concat("Test of ", target)));
}
}

public static global::System.Collections.Generic.ICollection<global::System.IO.FileInfo> InitializeParameters() {
global::System.IO.FileInfo directory = default!;
string pdfPath = global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "pdfa.invalid"), (string)default!);
if (global::DripSharp.Runtime.JavaCompat.Equals("${user.pdfa.invalid}", pdfPath)) {
pdfPath = default!;
}
if ((pdfPath != default!)) {
directory = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", pdfPath));
if (!global::System.IO.File.Exists((directory!).FullName)) {
throw new global::System.IO.IOException(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.Runtime.JavaCompat.Concat("directory does not exists : ", directory!.FullName)));
}
if (!(global::DripSharp.Runtime.JavaCompat.FileIsDirectory(directory!))) {
throw new global::System.IO.IOException(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.Runtime.JavaCompat.Concat("not a directory : ", directory!.FullName)));
}
} else {
global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "System property 'pdfa.invalid' not defined, will not run TestValidaDirectory"));
}
if ((directory! == default!)) {
global::System.Collections.Generic.IList<global::System.IO.FileInfo> data__81_24 = new global::System.Collections.Generic.List<global::System.IO.FileInfo>(1);
global::DripSharp.Runtime.JavaCompat.Add(data__81_24, default!);
return data__81_24;
} else {
global::System.IO.FileInfo[] files = global::DripSharp.Runtime.JavaCompat.FileListFiles(directory!);
global::System.Collections.Generic.IList<global::System.IO.FileInfo> data__88_24 = new global::System.Collections.Generic.List<global::System.IO.FileInfo>(files.Length);
foreach (global::System.IO.FileInfo file in files) {
if (global::DripSharp.Runtime.JavaCompat.FileIsFile(file)) {
global::DripSharp.Runtime.JavaCompat.Add(data__88_24, file);
}
}
return data__88_24;
}
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_96304bcc76199075()
{
    foreach (var value in InitializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::System.IO.FileInfo>(row[0]) };
    }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_96304bcc76199075))]
public void __Upstream_0726210838_2eb90c1cace5df2a(global::System.IO.FileInfo target)
{
        try
        {
            this.validate(target);
        }
        finally
        {
        }
}
}
