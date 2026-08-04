// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Schema;

public class PDFAIdentificationTest {
private global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = null!;

private global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema = null!;

private global::System.Type schemaClass = null!;

internal virtual void initMetadata() {
this.metadata = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
this.schema = this.metadata.CreateAndAddPDFAIdentificationSchema();
this.schemaClass = typeof(global::DripSharp.PdfCarton.Xmp.Schema.PDFAIdentificationSchema);
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
return global::DripSharp.Runtime.JavaCompat.StreamOf(new object[] { "part", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Integer), 1 }, new object[] { "amd", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Text), "2005" }, new object[] { "conformance", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Text), "B" }, new object[] { "rev", global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaTester.CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types.Integer), 2020 });
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_928d1f4ebc11768a()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.PropertyType>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<object>(row[2]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_9d205129c65b3551()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.PropertyType>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<object>(row[2]) };
    }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_928d1f4ebc11768a))]
public void __Upstream_1084695039_c7c7cc4fea5085c9(string property, global::DripSharp.PdfCarton.Xmp.Type.PropertyType type, object value)
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
[Xunit.MemberData(nameof(__Data_9d205129c65b3551))]
public void __Upstream_2596523399_8b5a599a52211643(string property, global::DripSharp.PdfCarton.Xmp.Type.PropertyType type, object value)
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
