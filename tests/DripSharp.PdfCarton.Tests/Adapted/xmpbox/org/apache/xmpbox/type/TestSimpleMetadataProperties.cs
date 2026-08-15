// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Type;

public class TestSimpleMetadataProperties {
private readonly global::DripSharp.PdfCarton.Xmp.XMPMetadata parent = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();

internal virtual void testBooleanBadTypeDetection() {
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => {
new global::DripSharp.PdfCarton.Xmp.Type.BooleanType(this.parent, (string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "boolean"), "Not a Boolean");
}, null);
}

internal virtual void testDateBadTypeDetection() {
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => {
new global::DripSharp.PdfCarton.Xmp.Type.DateType(this.parent, (string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "date"), "Bad Date");
}, null);
global::DripSharp.PdfCarton.Xmp.Type.DateType date = new global::DripSharp.PdfCarton.Xmp.Type.DateType(this.parent, (string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "date"), "");
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => date.SetValue((object)default!), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => date.SetValue(3), null);
}

internal virtual void testIntegerBadTypeDetection() {
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => {
new global::DripSharp.PdfCarton.Xmp.Type.IntegerType(this.parent, (string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "integer"), "Not an int");
}, null);
}

internal virtual void testRealBadTypeDetection() {
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => {
new global::DripSharp.PdfCarton.Xmp.Type.RealType(this.parent, (string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "real"), "Not a real");
}, null);
}

internal virtual void testTextBadTypeDetection() {
global::System.DateTimeOffset? calendar = global::System.DateTimeOffset.Now;
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => {
new global::DripSharp.PdfCarton.Xmp.Type.TextType(this.parent, (string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "text"), calendar);
}, null);
}

internal virtual void testElementAndObjectSynchronization() {
bool boolv = true;
global::System.DateTimeOffset? datev = global::System.DateTimeOffset.Now;
int integerv = 1;
float realv = global::DripSharp.Runtime.JavaCompat.ParseFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "1.69"));
string textv = "TEXTCONTENT";
global::DripSharp.PdfCarton.Xmp.Type.BooleanType @bool = this.parent.GetTypeMapping().CreateBoolean((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "boolean"), boolv);
global::DripSharp.PdfCarton.Xmp.Type.DateType date = this.parent.GetTypeMapping().CreateDate((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "date"), datev);
global::DripSharp.PdfCarton.Xmp.Type.IntegerType integer = this.parent.GetTypeMapping().CreateInteger((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "integer"), integerv);
global::DripSharp.PdfCarton.Xmp.Type.RealType real = this.parent.GetTypeMapping().CreateReal((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "real"), realv);
global::DripSharp.PdfCarton.Xmp.Type.TextType text = this.parent.GetTypeMapping().CreateText((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "text"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", textv));
global::DripSharp.Testing.JavaAssertions.Equal(boolv, ((bool)(@bool.GetValue())), null);
global::DripSharp.Testing.JavaAssertions.Equal(datev, ((global::System.DateTimeOffset?)(date.GetValue())), null);
global::DripSharp.Testing.JavaAssertions.Equal(integerv, ((int)(integer.GetValue())), null);
global::DripSharp.Testing.JavaAssertions.Equal(realv, (float)((float)(((float)(real.GetValue())))), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal(textv, text.GetStringValue(), null);
}

internal virtual void testCreationFromString() {
string boolv = "False";
string datev = "2010-03-22T14:33:11+01:00";
string integerv = "10";
string realv = "1.92";
string textv = "text";
global::DripSharp.PdfCarton.Xmp.Type.BooleanType @bool = new global::DripSharp.PdfCarton.Xmp.Type.BooleanType(this.parent, (string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "boolean"), boolv);
global::DripSharp.PdfCarton.Xmp.Type.DateType date = new global::DripSharp.PdfCarton.Xmp.Type.DateType(this.parent, (string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "date"), datev);
global::DripSharp.PdfCarton.Xmp.Type.IntegerType integer = new global::DripSharp.PdfCarton.Xmp.Type.IntegerType(this.parent, (string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "integer"), integerv);
global::DripSharp.PdfCarton.Xmp.Type.RealType real = new global::DripSharp.PdfCarton.Xmp.Type.RealType(this.parent, (string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "real"), realv);
global::DripSharp.PdfCarton.Xmp.Type.TextType text = new global::DripSharp.PdfCarton.Xmp.Type.TextType(this.parent, (string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "text"), textv);
global::DripSharp.Testing.JavaAssertions.Equal(boolv, @bool.GetStringValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(datev, date.GetStringValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(integerv, integer.GetStringValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(realv, real.GetStringValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(textv, text.GetStringValue(), null);
}

internal virtual void testObjectCreationWithNamespace() {
string ns = "http://www.test.org/pdfa/";
global::DripSharp.PdfCarton.Xmp.Type.BooleanType @bool = this.parent.GetTypeMapping().CreateBoolean(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", ns), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "boolean"), true);
global::DripSharp.PdfCarton.Xmp.Type.DateType date = this.parent.GetTypeMapping().CreateDate(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", ns), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "date"), global::System.DateTimeOffset.Now);
global::DripSharp.PdfCarton.Xmp.Type.IntegerType integer = this.parent.GetTypeMapping().CreateInteger(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", ns), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "integer"), 1);
global::DripSharp.PdfCarton.Xmp.Type.RealType real = this.parent.GetTypeMapping().CreateReal(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", ns), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "real"), (float)(1.6D));
global::DripSharp.PdfCarton.Xmp.Type.TextType text = this.parent.GetTypeMapping().CreateText(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", ns), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "text"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "TEST"));
global::DripSharp.Testing.JavaAssertions.Equal(ns, @bool.GetNamespace(), null);
global::DripSharp.Testing.JavaAssertions.Equal(ns, date.GetNamespace(), null);
global::DripSharp.Testing.JavaAssertions.Equal(ns, integer.GetNamespace(), null);
global::DripSharp.Testing.JavaAssertions.Equal(ns, real.GetNamespace(), null);
global::DripSharp.Testing.JavaAssertions.Equal(ns, text.GetNamespace(), null);
}

internal virtual void testAttribute() {
global::DripSharp.PdfCarton.Xmp.Type.IntegerType integer = new global::DripSharp.PdfCarton.Xmp.Type.IntegerType(this.parent, (string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "integer"), 1);
global::DripSharp.PdfCarton.Xmp.Type.Attribute value = new global::DripSharp.PdfCarton.Xmp.Type.Attribute(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "http://www.test.org/test/"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "value1"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "StringValue1"));
global::DripSharp.PdfCarton.Xmp.Type.Attribute value2 = new global::DripSharp.PdfCarton.Xmp.Type.Attribute(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "http://www.test.org/test/"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "value2"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "StringValue2"));
integer.SetAttribute(value);
global::DripSharp.Testing.JavaAssertions.Equal(value, integer.GetAttribute(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", value.GetName())), null);
global::DripSharp.Testing.JavaAssertions.True(integer.ContainsAttribute(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", value.GetName())), null);
integer.SetAttribute(value2);
global::DripSharp.Testing.JavaAssertions.Equal(value2, integer.GetAttribute(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", value2.GetName())), null);
integer.RemoveAttribute(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", value2.GetName()));
global::DripSharp.Testing.JavaAssertions.False(integer.ContainsAttribute(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", value2.GetName())), null);
global::DripSharp.PdfCarton.Xmp.Type.Attribute valueNS = new global::DripSharp.PdfCarton.Xmp.Type.Attribute(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "http://www.tefst2.org/test/"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "value2"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "StringValue.2"));
integer.SetAttribute(valueNS);
global::DripSharp.PdfCarton.Xmp.Type.Attribute valueNS2 = new global::DripSharp.PdfCarton.Xmp.Type.Attribute(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "http://www.test2.org/test/"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "value2"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "StringValueTwo"));
integer.SetAttribute(valueNS2);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Xmp.Type.Attribute> atts = integer.GetAllAttributes();
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.CollectionContains(atts, valueNS), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(atts, valueNS2), null);
}

[Xunit.Fact]
public void __Upstream_2830273066_12819c66466f8198()
{
        try
        {
            this.testAttribute();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2473848764_46ea059e694ac716()
{
        try
        {
            this.testBooleanBadTypeDetection();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2287385804_e13f019269ffc9fd()
{
        try
        {
            this.testCreationFromString();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1426822118_e813094443fe972a()
{
        try
        {
            this.testDateBadTypeDetection();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2953585588_057cc31677cd25e4()
{
        try
        {
            this.testElementAndObjectSynchronization();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3994884306_5b7ed04e659d085c()
{
        try
        {
            this.testIntegerBadTypeDetection();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4086642853_0558798514de55a1()
{
        try
        {
            this.testObjectCreationWithNamespace();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3563068886_a716d090bf62d345()
{
        try
        {
            this.testRealBadTypeDetection();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3524135781_93fed16d043d9ef7()
{
        try
        {
            this.testTextBadTypeDetection();
        }
        finally
        {
        }
}
}
