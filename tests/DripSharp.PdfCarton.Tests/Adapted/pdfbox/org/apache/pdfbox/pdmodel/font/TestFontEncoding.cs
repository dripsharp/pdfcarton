// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Font;

public class TestFontEncoding {
internal virtual void testAdd() {
int codeForSpace = global::DripSharp.Runtime.JavaCompat.UnboxObject<int>(global::DripSharp.Runtime.JavaCompat.MapGetNullable(global::DripSharp.PdfCarton.Pdmodel.Font.Encoding.WinAnsiEncoding.Instance.GetNameToCodeMap(), "space"));
global::DripSharp.Testing.JavaAssertions.Equal(32, codeForSpace, null);
codeForSpace = global::DripSharp.Runtime.JavaCompat.UnboxObject<int>(global::DripSharp.Runtime.JavaCompat.MapGetNullable(global::DripSharp.PdfCarton.Pdmodel.Font.Encoding.MacRomanEncoding.Instance.GetNameToCodeMap(), "space"));
global::DripSharp.Testing.JavaAssertions.Equal(32, codeForSpace, null);
}

internal virtual void testOverwrite() {
global::DripSharp.PdfCarton.Cos.COSDictionary dictEncodingDict = new global::DripSharp.PdfCarton.Cos.COSDictionary();
dictEncodingDict.SetItem(global::DripSharp.PdfCarton.Cos.COSName.Type, global::DripSharp.PdfCarton.Cos.COSName.Encoding);
dictEncodingDict.SetItem(global::DripSharp.PdfCarton.Cos.COSName.BaseEncoding, global::DripSharp.PdfCarton.Cos.COSName.WinAnsiEncoding);
global::DripSharp.PdfCarton.Cos.COSArray differences = new global::DripSharp.PdfCarton.Cos.COSArray();
differences.Add(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(32)));
differences.Add(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "a")));
dictEncodingDict.SetItem(global::DripSharp.PdfCarton.Cos.COSName.Differences, differences);
global::DripSharp.PdfCarton.Pdmodel.Font.Encoding.DictionaryEncoding dictEncoding = new global::DripSharp.PdfCarton.Pdmodel.Font.Encoding.DictionaryEncoding(dictEncodingDict, false, (global::DripSharp.PdfCarton.Pdmodel.Font.Encoding.Encoding)default!);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.Runtime.JavaCompat.MapGetNullable(dictEncoding.GetNameToCodeMap(), "space"), null);
global::DripSharp.Testing.JavaAssertions.Equal(32, global::DripSharp.Runtime.JavaCompat.Unbox(global::DripSharp.Runtime.JavaCompat.MapGetNullable(dictEncoding.GetNameToCodeMap(), "a")), null);
}

internal virtual void testPDFBox3884() {
global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
doc.AddPage(page);
global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream cs = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page);
cs.SetFont(new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica), (float)(20));
cs.BeginText();
cs.NewLineAtOffset((float)(100), (float)(700));
cs.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "~\u02DC"));
cs.EndText();
cs.Dispose();
global::DripSharp.Runtime.JavaByteArrayOutputStream baos = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
doc.Save(baos);
doc.Dispose();
doc = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
global::DripSharp.PdfCarton.Text.PDFTextStripper stripper = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
string text = stripper.GetText(doc);
global::DripSharp.Testing.JavaAssertions.Equal("~\u02DC", global::DripSharp.Runtime.JavaCompat.StringTrim(text), null);
doc.Dispose();
}

[Xunit.Fact]
public void __Upstream_0724998831_11c3cde8df2b8e54()
{
        try
        {
            this.testAdd();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2072108825_abae7362d8a260ae()
{
        try
        {
            this.testOverwrite();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1724551500_50a82be69205bea4()
{
        try
        {
            this.testPDFBox3884();
        }
        finally
        {
        }
}
}
