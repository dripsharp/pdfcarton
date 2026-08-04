// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Schema;

public class XmpRightsSchemaTest {
private global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = null!;

private global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema = null!;

private global::System.Type schemaClass = null!;

internal virtual void initMetadata() {
this.metadata = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
this.schema = this.metadata.CreateAndAddXMPRightsManagementSchema();
this.schemaClass = typeof(global::DripSharp.PdfCarton.Xmp.Schema.XMPRightsManagementSchema);
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
global::System.Collections.Generic.IDictionary<string, string> desc = global::DripSharp.Runtime.JavaCompat.NewJavaDictionary<string, string>(2);
global::DripSharp.Runtime.JavaCompat.MapPut(desc, "fr", "Termes d'utilisation");
global::DripSharp.Runtime.JavaCompat.MapPut(desc, "en", "Usage Terms");
return global::DripSharp.Runtime.JavaCompat.StreamOf(new object[] { "Certificate", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Url), "http://une.url.vers.un.certificat/moncert.cer" }, new object[] { "Marked", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Boolean), true }, new object[] { "Owner", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.ProperName, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Bag), new string[] { "OwnerName" } }, new object[] { "UsageTerms", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.LangAlt), desc }, new object[] { "WebStatement", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Url), "http://une.url.vers.une.page.fr/" });
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_efe91ac87041e7de()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.PropertyType>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<object>(row[2]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_bba5eb3d2243a28f()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.PropertyType>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<object>(row[2]) };
    }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_efe91ac87041e7de))]
public void __Upstream_1084695039_77550cf2d1113370(string property, global::DripSharp.PdfCarton.Xmp.Type.PropertyType type, object value)
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
[Xunit.MemberData(nameof(__Data_bba5eb3d2243a28f))]
public void __Upstream_2596523399_b3337c5388fb2449(string property, global::DripSharp.PdfCarton.Xmp.Type.PropertyType type, object value)
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
