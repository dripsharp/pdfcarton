// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class ControlCharacterTest {
private static readonly global::System.IO.FileInfo IN_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "src/test/resources/org/apache/pdfbox/pdmodel/interactive/form"));

private const string NAME_OF_PDF = "ControlCharacters.pdf";

private global::DripSharp.PdfCarton.Pdmodel.PDDocument document = null!;

private global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = null!;

internal virtual void setUp() {
this.document = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.ControlCharacterTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.ControlCharacterTest.NAME_OF_PDF))));
this.acroForm = this.document.GetDocumentCatalog().GetAcroForm();
}

internal virtual void characterNUL() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "pdfbox-nul"));
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "NUL\u0000NUL")), null);
}

internal virtual void characterTAB() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "pdfbox-tab"));
field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "TAB\tTAB"));
global::System.Collections.Generic.IList<string> pdfboxValues = global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.TestUtils.GetStringsFromStream(field);
global::DripSharp.Runtime.JavaCompat.ForEach(pdfboxValues, (token) => global::DripSharp.Testing.JavaAssertions.Equal("TAB", token, null));
}

private static global::System.Collections.Generic.IEnumerable<object[]> provideParameters() {
return global::DripSharp.Runtime.JavaCompat.StreamOf(new object[] { "space", "SPACE SPACE" }, new object[] { "cr", "CR\rCR" }, new object[] { "lf", "LF\nLF" }, new object[] { "crlf", "CRLF\r\nCRLF" }, new object[] { "lfcr", "LFCR\n\rLFCR" }, new object[] { "linebreak", "linebreak\u2028linebreak" }, new object[] { "paragraphbreak", "paragraphbreak\u2029paragraphbreak" });
}

internal virtual void testCharacter(string nameSuffix, string value) {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field = this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("pdfbox-", nameSuffix)));
field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", value));
global::System.Collections.Generic.IList<string> pdfboxValues = global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.TestUtils.GetStringsFromStream(field);
global::System.Collections.Generic.IList<string> acrobatValues = global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.TestUtils.GetStringsFromStream(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("acrobat-", nameSuffix))));
global::DripSharp.Testing.JavaAssertions.Equal(pdfboxValues, acrobatValues, null);
}

internal virtual void tearDown() {
this.document.Dispose();
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_8f5dc964ef4a6e4b()
{
    foreach (var value in provideParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[1]) };
    }
}

[Xunit.Fact]
public void __Upstream_0704264092_884f30feca53a082()
{
        this.setUp();
        try
        {
            this.characterNUL();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0704269228_e1fe5b9d0751e775()
{
        this.setUp();
        try
        {
            this.characterTAB();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_8f5dc964ef4a6e4b))]
public void __Upstream_0086416055_4f58d71ca02252d6(string nameSuffix, string value)
{
        this.setUp();
        try
        {
            this.testCharacter(nameSuffix, value);
        }
        finally
        {
            this.tearDown();
        }
}
}
