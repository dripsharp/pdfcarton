// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Type;

public class TestDerivedType {
public const string Prefix = "myprefix";

public const string Name = "myname";

public const string Value = "myvalue";

protected internal global::DripSharp.PdfCarton.Xmp.XMPMetadata Xmp = null!;

protected internal string Type = default!;

protected internal global::System.Type Clz = default!;

protected internal global::System.Reflection.ConstructorInfo Constructor = default!;

internal virtual void before() {
this.Xmp = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
}

private static global::System.Collections.Generic.IEnumerable<object[]> initializeParameters() {
return global::DripSharp.Runtime.JavaCompat.StreamOf(new object[] { typeof(global::DripSharp.PdfCarton.Xmp.Type.AgentNameType), "AgentName" }, new object[] { typeof(global::DripSharp.PdfCarton.Xmp.Type.ChoiceType), "Choice" }, new object[] { typeof(global::DripSharp.PdfCarton.Xmp.Type.GUIDType), "GUID" }, new object[] { typeof(global::DripSharp.PdfCarton.Xmp.Type.LocaleType), "Locale" }, new object[] { typeof(global::DripSharp.PdfCarton.Xmp.Type.MIMEType), "MIME" }, new object[] { typeof(global::DripSharp.PdfCarton.Xmp.Type.PartType), "Part" }, new object[] { typeof(global::DripSharp.PdfCarton.Xmp.Type.ProperNameType), "ProperName" }, new object[] { typeof(global::DripSharp.PdfCarton.Xmp.Type.RenditionClassType), "RenditionClass" }, new object[] { typeof(global::DripSharp.PdfCarton.Xmp.Type.URIType), "URI" }, new object[] { typeof(global::DripSharp.PdfCarton.Xmp.Type.URLType), "URL" }, new object[] { typeof(global::DripSharp.PdfCarton.Xmp.Type.XPathType), "XPath" });
}

protected internal virtual global::DripSharp.PdfCarton.Xmp.Type.TextType Instanciate(global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata, string namespaceURI, string prefix, string propertyName, object value) {
object[] initargs = new object[] { metadata, namespaceURI, prefix, propertyName, value };
return global::DripSharp.Runtime.JavaCompat.ConstructorInvoke<global::DripSharp.PdfCarton.Xmp.Type.TextType>(this.Constructor, initargs);
}

internal virtual void test1(global::System.Type clz, string type) {
this.Constructor = global::DripSharp.Runtime.JavaCompat.ClassGetDeclaredConstructor(clz, typeof(global::DripSharp.PdfCarton.Xmp.XMPMetadata), typeof(string), typeof(string), typeof(string), typeof(object));
global::DripSharp.PdfCarton.Xmp.Type.TextType element = this.Instanciate(this.Xmp, (string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", global::DripSharp.PdfCarton.Xmp.Type.TestDerivedType.Prefix), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", global::DripSharp.PdfCarton.Xmp.Type.TestDerivedType.Name), global::DripSharp.PdfCarton.Xmp.Type.TestDerivedType.Value);
global::DripSharp.Testing.JavaAssertions.Null(element.GetNamespace(), null);
global::DripSharp.Testing.JavaAssertions.True((element.GetValue() is string), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.Type.TestDerivedType.Value, element.GetValue(), null);
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_a6844f8ada0a8b25()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::System.Type>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[1]) };
    }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_a6844f8ada0a8b25))]
public void __Upstream_2257735135_beb035c8195efe61(global::System.Type clz, string type)
{
        this.before();
        try
        {
            this.test1(clz, type);
        }
        finally
        {
        }
}
}
