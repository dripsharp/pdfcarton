// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Parser;

public class TestXmlResultParser {
public const string ErrorCode = "000";

protected internal readonly global::DripSharp.PdfCarton.Preflight.Parser.XmlResultParser Parser = new global::DripSharp.PdfCarton.Preflight.Parser.XmlResultParser();

protected internal global::System.Xml.XmlDocument Document = null!;

protected internal global::System.Xml.XmlElement Preflight = null!;

protected internal global::DripSharp.PdfCarton.Tests.JavaTestXPath Xpath = null!;

public virtual void Before() {
this.Document = new global::System.Xml.XmlDocument();
this.Preflight = this.Parser.GenerateResponseSkeleton(this.Document, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "myname"), (long)(14));
this.Xpath = global::DripSharp.PdfCarton.Tests.JavaTestXPathFactory.Instance.NewXPath();
}

internal virtual void testOneError() {
global::DripSharp.PdfCarton.Preflight.ValidationResult result = new global::DripSharp.PdfCarton.Preflight.ValidationResult(false);
result.AddError(new global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "7")));
this.Parser.CreateResponseWithError(this.Document, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "pdftype"), result, this.Preflight);
global::DripSharp.Testing.JavaAssertions.NotNull(this.Xpath.Evaluate(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "errors[@count='1']"), this.Preflight, global::DripSharp.PdfCarton.Tests.JavaTestXPathConstants.NODE), null);
global::System.Xml.XmlNodeList nl = (global::System.Xml.XmlNodeList)(this.Xpath.Evaluate(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "errors/error[@count='1']"), this.Preflight, global::DripSharp.PdfCarton.Tests.JavaTestXPathConstants.NODESET)!);
global::DripSharp.Testing.JavaAssertions.Equal(1, nl.Count, null);
}

internal virtual void testTwoError() {
global::DripSharp.PdfCarton.Preflight.ValidationResult result = new global::DripSharp.PdfCarton.Preflight.ValidationResult(false);
result.AddError(new global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "7")));
result.AddError(new global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.Parser.TestXmlResultParser.ErrorCode)));
this.Parser.CreateResponseWithError(this.Document, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "pdftype"), result, this.Preflight);
global::DripSharp.Testing.JavaAssertions.NotNull(this.Xpath.Evaluate(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "errors[@count='2']"), this.Preflight, global::DripSharp.PdfCarton.Tests.JavaTestXPathConstants.NODE), null);
global::System.Xml.XmlNodeList nl = (global::System.Xml.XmlNodeList)(this.Xpath.Evaluate(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "errors/error[@count='1']"), this.Preflight, global::DripSharp.PdfCarton.Tests.JavaTestXPathConstants.NODESET)!);
global::DripSharp.Testing.JavaAssertions.Equal(2, nl.Count, null);
}

internal virtual void testSameErrorTwice() {
global::DripSharp.PdfCarton.Preflight.ValidationResult result = new global::DripSharp.PdfCarton.Preflight.ValidationResult(false);
result.AddError(new global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.Parser.TestXmlResultParser.ErrorCode)));
result.AddError(new global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.Parser.TestXmlResultParser.ErrorCode)));
this.Parser.CreateResponseWithError(this.Document, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "pdftype"), result, this.Preflight);
global::DripSharp.Testing.JavaAssertions.NotNull(this.Xpath.Evaluate(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "errors[@count='2']"), this.Preflight, global::DripSharp.PdfCarton.Tests.JavaTestXPathConstants.NODE), null);
global::DripSharp.Testing.JavaAssertions.NotNull(this.Xpath.Evaluate(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "errors/error[@count='2']"), this.Preflight, global::DripSharp.PdfCarton.Tests.JavaTestXPathConstants.NODE), null);
global::System.Xml.XmlElement code = (global::System.Xml.XmlElement)(this.Xpath.Evaluate(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "errors/error[@count='2']/code"), this.Preflight, global::DripSharp.PdfCarton.Tests.JavaTestXPathConstants.NODE)!);
global::DripSharp.Testing.JavaAssertions.NotNull(code, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Preflight.Parser.TestXmlResultParser.ErrorCode, code.InnerText, null);
}

internal virtual void testSameCodeWithDifferentMessages() {
global::DripSharp.PdfCarton.Preflight.ValidationResult result = new global::DripSharp.PdfCarton.Preflight.ValidationResult(false);
result.AddError(new global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.Parser.TestXmlResultParser.ErrorCode), global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "message 1")));
result.AddError(new global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.Parser.TestXmlResultParser.ErrorCode), global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "message 2")));
this.Parser.CreateResponseWithError(this.Document, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "pdftype"), result, this.Preflight);
global::DripSharp.Testing.JavaAssertions.NotNull(this.Xpath.Evaluate(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "errors[@count='2']"), this.Preflight, global::DripSharp.PdfCarton.Tests.JavaTestXPathConstants.NODE), null);
global::System.Xml.XmlNodeList nl = (global::System.Xml.XmlNodeList)(this.Xpath.Evaluate(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "errors/error[@count='1']"), this.Preflight, global::DripSharp.PdfCarton.Tests.JavaTestXPathConstants.NODESET)!);
global::DripSharp.Testing.JavaAssertions.Equal(2, nl.Count, null);
}

[Xunit.Fact]
public void __Upstream_0545208820_85a052d553baad60()
{
        this.Before();
        try
        {
            this.testOneError();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0216314714_6b7d89195abeab06()
{
        this.Before();
        try
        {
            this.testSameCodeWithDifferentMessages();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3896251960_2625dc07c4180c9b()
{
        this.Before();
        try
        {
            this.testSameErrorTwice();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0353215950_b37bdf9806cf14fc()
{
        this.Before();
        try
        {
            this.testTwoError();
        }
        finally
        {
        }
}
}
