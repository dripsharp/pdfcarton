// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Schema;

public class DublinCoreTest {
private global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = null!;

private global::System.Type schemaClass = null!;

internal virtual void initMetadata() {
this.metadata = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
this.schemaClass = typeof(global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema);
}

internal virtual void testInitializedToNull(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
schemaTester.TestInitializedToNull();
}

internal virtual void testSettingValue(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
schemaTester.TestSettingValue();
}

internal virtual void testRandomSettingValue(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
schemaTester.TestRandomSettingValue();
}

internal virtual void testSettingValueInArray(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
schemaTester.TestSettingValueInArray();
}

internal virtual void testRandomSettingValueInArray(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
schemaTester.TestRandomSettingValueInArray();
}

internal virtual void testPropertySetterSimple(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
schemaTester.TestPropertySetterSimple();
}

internal virtual void testRandomPropertySetterSimple(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
schemaTester.TestRandomPropertySetterSimple();
}

internal virtual void testPropertySetterInArray(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
schemaTester.TestPropertySetterInArray();
}

internal virtual void testRandomPropertySetterInArray(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
schemaTester.TestRandomPropertySetterInArray();
}

private static global::System.Collections.Generic.IEnumerable<object[]> initializeParameters() {
return global::DripSharp.Runtime.JavaCompat.StreamOf(new object[] { "contributor", global::DripSharp.PdfCarton.Xmp.Type.Types.ProperName, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Bag }, new object[] { "coverage", global::DripSharp.PdfCarton.Xmp.Type.Types.Text, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "creator", global::DripSharp.PdfCarton.Xmp.Type.Types.ProperName, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Seq }, new object[] { "date", global::DripSharp.PdfCarton.Xmp.Type.Types.Date, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Seq }, new object[] { "format", global::DripSharp.PdfCarton.Xmp.Type.Types.MIMEType, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "identifier", global::DripSharp.PdfCarton.Xmp.Type.Types.Text, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "language", global::DripSharp.PdfCarton.Xmp.Type.Types.Locale, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Bag }, new object[] { "publisher", global::DripSharp.PdfCarton.Xmp.Type.Types.ProperName, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Bag }, new object[] { "relation", global::DripSharp.PdfCarton.Xmp.Type.Types.Text, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Bag }, new object[] { "source", global::DripSharp.PdfCarton.Xmp.Type.Types.Text, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "subject", global::DripSharp.PdfCarton.Xmp.Type.Types.Text, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Bag }, new object[] { "type", global::DripSharp.PdfCarton.Xmp.Type.Types.Text, global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Bag });
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_ce1065a850bee249()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_637b6d8e5cb4dc96()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_49c7d3f332bbe36a()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_2c764b6be486823f()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_78e6764673cac450()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_293f79197f9ec8d8()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_2215ff7584759bde()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_25a468f1982c262d()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_b49e6697abc8de71()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_ce1065a850bee249))]
public void __Upstream_3540789284_daea56c35d5632bd(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card)
{
        this.initMetadata();
        try
        {
            this.testInitializedToNull(fieldName, type, card);
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_637b6d8e5cb4dc96))]
public void __Upstream_0974183790_bdb3937a5bc7c8ba(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card)
{
        this.initMetadata();
        try
        {
            this.testPropertySetterInArray(fieldName, type, card);
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_49c7d3f332bbe36a))]
public void __Upstream_3916638520_c6c36ef31e05b9b5(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card)
{
        this.initMetadata();
        try
        {
            this.testPropertySetterSimple(fieldName, type, card);
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_2c764b6be486823f))]
public void __Upstream_3372502507_80f3519a373e93c2(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card)
{
        this.initMetadata();
        try
        {
            this.testRandomPropertySetterInArray(fieldName, type, card);
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_78e6764673cac450))]
public void __Upstream_3024172315_c5c2d7db7c057bd3(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card)
{
        this.initMetadata();
        try
        {
            this.testRandomPropertySetterSimple(fieldName, type, card);
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_293f79197f9ec8d8))]
public void __Upstream_3730436502_b0c678e5e4229a7b(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card)
{
        this.initMetadata();
        try
        {
            this.testRandomSettingValue(fieldName, type, card);
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_2215ff7584759bde))]
public void __Upstream_2849682878_ce49da0e24eb50e6(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card)
{
        this.initMetadata();
        try
        {
            this.testRandomSettingValueInArray(fieldName, type, card);
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_25a468f1982c262d))]
public void __Upstream_3686552243_3128b46ef0ef5411(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card)
{
        this.initMetadata();
        try
        {
            this.testSettingValue(fieldName, type, card);
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_b49e6697abc8de71))]
public void __Upstream_1354451457_2fe6d3fb732620f5(string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type, global::DripSharp.PdfCarton.Xmp.Type.Cardinality card)
{
        this.initMetadata();
        try
        {
            this.testSettingValueInArray(fieldName, type, card);
        }
        finally
        {
        }
}
}
