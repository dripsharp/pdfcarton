// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdfparser;

public class PDFStreamParserTest {
internal virtual void testInlineImages() {
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI Q"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI EMC"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EMC"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI Q "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI EMC "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EMC"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI  Q"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI  EMC"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EMC"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI  Q "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI  EMC "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EMC"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI \u0000Q"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI Q                             "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI EMC                           "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EMC"));
this.testInlineImage1op(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"));
this.testInlineImage1op(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI                               "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI                               Q "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI                               EMC "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EMC"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI                               Q"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12345EI                               EMC"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12345"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EMC"));
this.testInlineImage1op(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"));
this.testInlineImage1op(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"));
this.testInlineImage1op(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EIQEI"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5EIQ"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EIQEI Q"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5EIQ"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI Q"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI Q "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI EMC"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EMC"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI EMC "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EMC"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI                                Q"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI                                Q "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI                                EMC"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EMC"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI                                EMC "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EMC"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI       EMC "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EMC"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI        EMC "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EMC"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI         EMC "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EMC"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI          EMC "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "EMC"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI       Q   "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI        Q   "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI         Q   "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ID\n12EI5EI          Q   "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "12EI5"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Q"));
}

internal virtual void testNestedBI() {
global::System.IO.IOException ex = global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => this.testInlineImage2ops(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "BI/IB/IB BI/ BI"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ""), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "")), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Nested '", global::DripSharp.PdfCarton.Contentstream.@Operator.OperatorName.BeginInlineImage), "' operator not allowed at offset 11, first: 2"), global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
}

private void testInlineImage2ops(string s, string imageDataString, string opName) {
global::System.Collections.Generic.IList<object> tokens = this.parseTokenString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", s));
global::DripSharp.Testing.JavaAssertions.Equal(2, global::DripSharp.Runtime.JavaCompat.CollectionCount(tokens), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Contentstream.@Operator.OperatorName.BeginInlineImageData, ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 0)!)).GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(imageDataString.Length, ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 0)!)).GetImageData().Length, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.StringGetBytes(imageDataString, global::System.Text.Encoding.UTF8), ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 0)!)).GetImageData(), null);
global::DripSharp.Testing.JavaAssertions.Equal(opName, ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 1)!)).GetName(), null);
}

private void testInlineImage1op(string s, string imageDataString) {
global::System.Collections.Generic.IList<object> tokens = this.parseTokenString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", s));
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.CollectionCount(tokens), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Contentstream.@Operator.OperatorName.BeginInlineImageData, ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 0)!)).GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal(imageDataString.Length, ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 0)!)).GetImageData().Length, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.StringGetBytes(imageDataString, global::System.Text.Encoding.UTF8), ((global::DripSharp.PdfCarton.Contentstream.@Operator.Operator)(global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 0)!)).GetImageData(), null);
}

private global::System.Collections.Generic.IList<object> parseTokenString(string s) {
global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser pdfStreamParser = new global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s, global::System.Text.Encoding.UTF8));
return pdfStreamParser.Parse();
}

[Xunit.Fact]
public void __Upstream_3271182371_e76ea85cd58becda()
{
        try
        {
            this.testInlineImages();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4143578672_8f2059ed4a4161e4()
{
        try
        {
            this.testNestedBI();
        }
        finally
        {
        }
}
}
