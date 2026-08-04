// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Schema;

public class XMPBasicTest {
private global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = null!;

private global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema = null!;

private global::System.Type schemaClass = null!;

internal virtual void initMetadata() {
this.metadata = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
this.schema = this.metadata.CreateAndAddXMPBasicSchema();
this.schemaClass = typeof(global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicSchema);
}

internal virtual void testElementValue(string property, global::DripSharp.PdfCarton.Xmp.Type.PropertyType type, object value) {
global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester xmpSchemaTester = new global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester(this.metadata, this.schema, this.schemaClass, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", property), type, value);
xmpSchemaTester.TestGetSetValue();
}

internal virtual void testElementProperty(string property, global::DripSharp.PdfCarton.Xmp.Type.PropertyType type, object value) {
global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester xmpSchemaTester = new global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester(this.metadata, this.schema, this.schemaClass, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", property), type, value);
xmpSchemaTester.TestGetSetProperty();
}

internal static global::System.Collections.Generic.IEnumerable<object[]> initializeParameters() {
return global::DripSharp.Runtime.JavaCompat.StreamOf(new object[] { "Advisory", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.XPath, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Bag), new string[] { "xpath1", "xpath2" } }, new object[] { "BaseURL", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Url), "URL" }, new object[] { "CreateDate", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Date), global::System.DateTimeOffset.Now }, new object[] { "CreatorTool", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.AgentName), "CreatorTool" }, new object[] { "Identifier", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Text, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Bag), new string[] { "id1", "id2" } }, new object[] { "Label", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Text), "label" }, new object[] { "MetadataDate", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Date), global::System.DateTimeOffset.Now }, new object[] { "ModifyDate", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Date), global::System.DateTimeOffset.Now }, new object[] { "Nickname", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Text), "nick name" }, new object[] { "Rating", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Integer), 7 }, new object[] { "Thumbnails", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Thumbnail, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Alt), (object[])default! });
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_23cfb0a8d7c9b5b0()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.PropertyType>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<object>(row[2]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_98ac8efe9808605a()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.PropertyType>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<object>(row[2]) };
    }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_23cfb0a8d7c9b5b0))]
public void __Upstream_1084695039_5952eda082c3e218(string property, global::DripSharp.PdfCarton.Xmp.Type.PropertyType type, object value)
{
        this.initMetadata();
        try
        {
            this.testElementProperty(property, type, value);
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_98ac8efe9808605a))]
public void __Upstream_2596523399_43f56218c3b8893e(string property, global::DripSharp.PdfCarton.Xmp.Type.PropertyType type, object value)
{
        this.initMetadata();
        try
        {
            this.testElementValue(property, type, value);
        }
        finally
        {
        }
}
}
