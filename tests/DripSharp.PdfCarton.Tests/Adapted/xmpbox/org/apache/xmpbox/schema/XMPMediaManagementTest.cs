// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Schema;

public class XMPMediaManagementTest {
private global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = null!;

private global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema = null!;

private global::System.Type schemaClass = null!;

internal virtual void initMetadata() {
this.metadata = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
this.schema = this.metadata.CreateAndAddXMPMediaManagementSchema();
this.schemaClass = typeof(global::DripSharp.PdfCarton.Xmp.Schema.XMPMediaManagementSchema);
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
return global::DripSharp.Runtime.JavaCompat.StreamOf(new object[] { "DocumentID", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Uri), "uuid:FB031973-5E75-11B2-8F06-E7F5C101C07A" }, new object[] { "Manager", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.AgentName), "Raoul" }, new object[] { "ManageTo", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Uri), "uuid:36" }, new object[] { "ManageUI", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Uri), "uuid:3635" }, new object[] { "InstanceID", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Uri), "uuid:42" }, new object[] { "OriginalDocumentID", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Text), "uuid:142" }, new object[] { "RenditionParams", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Text), "my params" }, new object[] { "VersionID", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Text), "14" }, new object[] { "Versions", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Version, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Seq), new string[] { "1", "2", "3" } }, new object[] { "History", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Text, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Seq), new string[] { "action 1", "action 2", "action 3" } }, new object[] { "Ingredients", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Text, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Bag), new string[] { "resource1", "resource2" } });
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_b37f4cb60d75cb10()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.PropertyType>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<object>(row[2]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_419d59d9cac79a98()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.PropertyType>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<object>(row[2]) };
    }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_b37f4cb60d75cb10))]
public void __Upstream_1084695039_225f973950c0db28(string property, global::DripSharp.PdfCarton.Xmp.Type.PropertyType type, object value)
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
[Xunit.MemberData(nameof(__Data_419d59d9cac79a98))]
public void __Upstream_2596523399_7d62dc706603f88a(string property, global::DripSharp.PdfCarton.Xmp.Type.PropertyType type, object value)
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
