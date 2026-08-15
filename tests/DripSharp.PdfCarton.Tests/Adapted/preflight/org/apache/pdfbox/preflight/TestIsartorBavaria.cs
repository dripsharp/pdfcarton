// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight;

public class TestIsartorBavaria {
private const string FILTER_FILE = "isartor.filter";

private const string SKIP_BAVARIA = "skip-bavaria";

private static global::System.IO.Stream isartorResultFile = null!;

public static global::System.Collections.Generic.ICollection<object[]> InitializeParameters() {
string filter = global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.TestIsartorBavaria.FILTER_FILE));
string skipBavaria = global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.TestIsartorBavaria.SKIP_BAVARIA));
global::System.IO.FileInfo f = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "src/test/resources/expected_errors.txt"));
global::System.IO.Stream expected = global::DripSharp.Runtime.JavaCompat.OpenFileInput(f);
global::DripSharp.Runtime.JavaProperties props = new global::DripSharp.Runtime.JavaProperties();
props.Load(expected);
global::DripSharp.PdfCarton.Tests.Support.CloseQuietly(expected);
global::System.Collections.Generic.IList<object[]> data = new global::System.Collections.Generic.List<object[]>();
global::System.IO.FileInfo isartor = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "target/pdfs/Isartor testsuite/PDFA-1b"));
if (global::DripSharp.Runtime.JavaCompat.FileIsDirectory(isartor)) {
global::System.Collections.Generic.ICollection<object> pdfFiles__74_27 = global::DripSharp.PdfCarton.Tests.Support.ListFilesObjects(isartor, new string[] { "pdf", "PDF" }, true);
foreach (object pdfFile__75_25 in pdfFiles__74_27) {
string fn__77_24 = (((global::System.IO.FileInfo)(pdfFile__75_25!))).Name;
if (((filter == default!) || global::DripSharp.Runtime.JavaCompat.StringContains(fn__77_24, filter))) {
string path__80_28 = props.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", fn__77_24));
string error__81_28 = global::DripSharp.Runtime.JavaCompat.StringTrim(new global::DripSharp.Runtime.JavaStringTokenizer(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", path__80_28), global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "//")).nextToken());
string[] errTab = global::DripSharp.Runtime.JavaCompat.StringSplit(error__81_28, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", ","), 0);
global::System.Collections.Generic.ISet<string> errorSet__83_33 = new global::System.Collections.Generic.HashSet<string>(global::DripSharp.Runtime.JavaCompat.AsList<string>(errTab));
global::DripSharp.Runtime.JavaCompat.Add(data, new object[] { pdfFile__75_25, errorSet__83_33 });
}
}
} else {
global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
}
if (global::DripSharp.Runtime.JavaCompat.Equals("false", skipBavaria)) {
global::System.IO.FileInfo bavaria = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "target/pdfs/Bavaria testsuite"));
if (global::DripSharp.Runtime.JavaCompat.FileIsDirectory(bavaria)) {
global::System.Collections.Generic.ICollection<object> pdfFiles__98_31 = global::DripSharp.PdfCarton.Tests.Support.ListFilesObjects(bavaria, new string[] { "pdf", "PDF" }, true);
foreach (object pdfFile__99_29 in pdfFiles__98_31) {
string fn__101_28 = (((global::System.IO.FileInfo)(pdfFile__99_29!))).Name;
if (((filter == default!) || global::DripSharp.Runtime.JavaCompat.StringContains(fn__101_28, filter))) {
string path__104_32 = props.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", fn__101_28));
global::System.Collections.Generic.ISet<string> errorSet__105_37 = new global::System.Collections.Generic.HashSet<string>();
if (!((path__104_32.Length == 0))) {
string error__108_36 = global::DripSharp.Runtime.JavaCompat.StringTrim(new global::DripSharp.Runtime.JavaStringTokenizer(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", path__104_32), global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "//")).nextToken());
global::DripSharp.Runtime.JavaCompat.AddAll(errorSet__105_37, global::DripSharp.Runtime.JavaCompat.AsList<string>(global::DripSharp.Runtime.JavaCompat.StringSplit(error__108_36, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", ","), 0)));
}
global::DripSharp.Runtime.JavaCompat.Add(data, new object[] { pdfFile__99_29, errorSet__105_37 });
}
}
} else {
global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
}
} else {
global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "Bavaria tests are skipped. You can enable them in Maven with -Dskip-bavaria=false"));
global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "About the tests: http://www.pdflib.com/knowledge-base/pdfa/validation-report/"));
}
return data;
}

internal static void beforeClass() {
string irp = global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "isartor.results.path"));
if ((irp != default!)) {
global::System.IO.FileInfo f = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", irp));
if ((global::System.IO.File.Exists(f.FullName) && global::DripSharp.Runtime.JavaCompat.FileIsFile(f))) {
global::DripSharp.Runtime.JavaCompat.FileDelete(f);
global::DripSharp.PdfCarton.Preflight.TestIsartorBavaria.isartorResultFile = global::DripSharp.Runtime.JavaCompat.OpenFileOutput(f);
} else {
if (!global::System.IO.File.Exists(f.FullName)) {
global::DripSharp.PdfCarton.Preflight.TestIsartorBavaria.isartorResultFile = global::DripSharp.Runtime.JavaCompat.OpenFileOutput(f);
} else {
throw new global::System.ArgumentException(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.Runtime.JavaCompat.Concat("Invalid result file : ", irp)));
}
}
}
}

internal static void afterClass() {
if ((global::DripSharp.PdfCarton.Preflight.TestIsartorBavaria.isartorResultFile != default!)) {
global::DripSharp.PdfCarton.Tests.Support.CloseQuietly(global::DripSharp.PdfCarton.Preflight.TestIsartorBavaria.isartorResultFile);
}
}

internal virtual void validate(global::System.IO.FileInfo file, global::System.Collections.Generic.ISet<string> expectedErrorSet) {
global::DripSharp.PdfCarton.Preflight.ValidationResult result = global::DripSharp.PdfCarton.Preflight.Parser.PreflightParser.Validate(file);
if ((result != default!)) {
if (global::DripSharp.Runtime.JavaCompat.CollectionIsEmpty(expectedErrorSet)) {
global::System.Collections.Generic.ISet<string> errorSet__169_29 = new global::System.Collections.Generic.HashSet<string>();
foreach (global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError error__170_38 in result.GetErrorsList()) {
errorSet__169_29.Add(error__170_38.GetErrorCode());
}
global::System.Text.StringBuilder message__174_31 = new global::System.Text.StringBuilder();
message__174_31.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", file.Name));
message__174_31.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", " : PDF/A file should be valid, but has error"));
if ((errorSet__169_29.Count > 1)) {
message__174_31.Append('s');
}
message__174_31.Append(':');
foreach (string errMsg__182_29 in errorSet__169_29) {
message__174_31.Append(' ');
message__174_31.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", errMsg__182_29));
}
global::DripSharp.Testing.JavaAssertions.True(result.IsValid(), global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", message__174_31.ToString()));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(result.GetErrorsList()), global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", message__174_31.ToString()));
} else {
global::DripSharp.Testing.JavaAssertions.False(result.IsValid(), global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(file.Name, " : PDF/A file should be invalid (expected "), expectedErrorSet), ")")));
global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.Runtime.JavaCompat.CollectionCount(result.GetErrorsList()) > 0), global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.Runtime.JavaCompat.Concat(file.Name, " : Should find at least one error")));
bool logged = false;
bool allFound = true;
foreach (string expectedError in expectedErrorSet) {
bool oneFound = false;
foreach (global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError error__203_42 in result.GetErrorsList()) {
if (global::DripSharp.Runtime.JavaCompat.Equals(error__203_42.GetErrorCode(), expectedError)) {
oneFound = true;
}
if (((global::DripSharp.PdfCarton.Preflight.TestIsartorBavaria.isartorResultFile != default!) && !logged)) {
string log = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.ReplaceOrdinal(file.Name, ".pdf", ""), "#"), error__203_42.GetErrorCode()), "#"), error__203_42.GetDetails()), "\n");
global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(global::DripSharp.PdfCarton.Preflight.TestIsartorBavaria.isartorResultFile, global::DripSharp.Runtime.JavaCompat.StringGetBytes(log, global::System.Text.Encoding.UTF8));
}
}
if (!oneFound) {
allFound = false;
break;
}
logged = true;
}
if (!allFound) {
global::System.Collections.Generic.ISet<string> errorSet__227_33 = new global::System.Collections.Generic.HashSet<string>();
foreach (global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError error__228_42 in result.GetErrorsList()) {
errorSet__227_33.Add(error__228_42.GetErrorCode());
}
global::System.Text.StringBuilder message__232_35 = new global::System.Text.StringBuilder();
foreach (string errMsg__233_33 in errorSet__227_33) {
if ((message__232_35.Length > 0)) {
message__232_35.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", ", "));
}
message__232_35.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", errMsg__233_33));
}
global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
}
}
}
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_9c788505e29ff02f()
{
    foreach (var value in InitializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::System.IO.FileInfo>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::System.Collections.Generic.ISet<string>>(row[1]) };
    }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_9c788505e29ff02f))]
public void __Upstream_0726210838_e963237d370e4404(global::System.IO.FileInfo file, global::System.Collections.Generic.ISet<string> expectedErrorSet)
{
        beforeClass();
        try
        {
            this.validate(file, expectedErrorSet);
        }
        finally
        {
            afterClass();
        }
}
}
