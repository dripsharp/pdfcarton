// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Type;

public class TestStructuredType : global::DripSharp.PdfCarton.Xmp.Type.AbstractTypeTester {
internal virtual void testInitializedToNull(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type) {
global::DripSharp.Testing.JavaAssertions.Null(structured.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName)), null);
global::System.Reflection.MethodInfo get = global::DripSharp.Runtime.JavaCompat.GetMethod(clz, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.CalculateSimpleGetter(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName))));
object result = get.Invoke(structured, new object?[] {  });
global::DripSharp.Testing.JavaAssertions.Null(result, null);
}

internal virtual void testSettingValue(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type) {
this.internalTestSettingValue(structured, clz, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type);
}

internal virtual void testRandomSettingValue(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type) {
this.InitializeSeed(new global::DripSharp.PdfCarton.Tests.JavaRandom());
for (int i = 0; (i < global::DripSharp.PdfCarton.Xmp.Type.AbstractTypeTester.RandLoopCount); i++) {
this.internalTestSettingValue(structured, clz, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type);
}
}

private void internalTestSettingValue(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type) {
object value = this.GetJavaValue(type);
structured.AddSimpleProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), value);
global::DripSharp.Testing.JavaAssertions.NotNull(structured.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName)), null);
global::System.Collections.Generic.IList<global::System.Reflection.FieldInfo> fields = this.GetXmpFields(clz);
foreach (global::System.Reflection.FieldInfo field in fields) {
string name = global::DripSharp.Runtime.JavaCompat.StringValueOf(field.GetValue((object)default!));
if (!(global::DripSharp.Runtime.JavaCompat.Equals(name, fieldName))) {
global::DripSharp.Testing.JavaAssertions.Null(structured.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", name)), null);
}
}
}

internal virtual void testPropertyType(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type) {
this.internalTestPropertyType(structured, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type);
}

internal virtual void testRandomPropertyType(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type) {
this.InitializeSeed(new global::DripSharp.PdfCarton.Tests.JavaRandom());
for (int i = 0; (i < global::DripSharp.PdfCarton.Xmp.Type.AbstractTypeTester.RandLoopCount); i++) {
this.internalTestPropertyType(structured, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type);
}
}

private void internalTestPropertyType(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type) {
object value = this.GetJavaValue(type);
structured.AddSimpleProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), value);
global::DripSharp.Testing.JavaAssertions.NotNull(structured.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName)), null);
global::DripSharp.PdfCarton.Xmp.Type.AbstractSimpleProperty asp = (global::DripSharp.PdfCarton.Xmp.Type.AbstractSimpleProperty)(structured.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName))!);
global::DripSharp.Testing.JavaAssertions.Equal(type.GetImplementingClass(), ((object)(asp)).GetType(), null);
}

internal virtual void testSetter(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type) {
this.internalTestSetter(structured, clz, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type);
}

internal virtual void testRandomSetter(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type) {
this.InitializeSeed(new global::DripSharp.PdfCarton.Tests.JavaRandom());
for (int i = 0; (i < global::DripSharp.PdfCarton.Xmp.Type.AbstractTypeTester.RandLoopCount); i++) {
this.internalTestSetter(structured, clz, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type);
}
}

private void internalTestSetter(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type) {
string setter = this.CalculateSimpleSetter(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName));
object value = this.GetJavaValue(type);
global::System.Reflection.MethodInfo set = global::DripSharp.Runtime.JavaCompat.GetMethod(clz, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setter), this.GetJavaType(type));
set.Invoke(structured, new object?[] { value });
global::DripSharp.Testing.JavaAssertions.Equal(value, ((global::DripSharp.PdfCarton.Xmp.Type.AbstractSimpleProperty)(structured.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName))!)).GetValue(), null);
global::System.Reflection.MethodInfo get = global::DripSharp.Runtime.JavaCompat.GetMethod(clz, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.CalculateSimpleGetter(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName))));
object result = get.Invoke(structured, new object?[] {  });
global::DripSharp.Testing.JavaAssertions.True(this.GetJavaType(type).IsAssignableFrom(((object)(result)).GetType()), null);
global::DripSharp.Testing.JavaAssertions.Equal(value, result, null);
}

private static global::System.Collections.Generic.IEnumerable<object[]> initializeParameters() {
global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
return global::DripSharp.Runtime.JavaCompat.StreamOf(new object[] { new global::DripSharp.PdfCarton.Xmp.Type.JobType(xmp, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "job")), typeof(global::DripSharp.PdfCarton.Xmp.Type.JobType), "id", global::DripSharp.PdfCarton.Xmp.Type.Types.Text }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.JobType(xmp, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "job")), typeof(global::DripSharp.PdfCarton.Xmp.Type.JobType), "name", global::DripSharp.PdfCarton.Xmp.Type.Types.Text }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.JobType(xmp, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "job")), typeof(global::DripSharp.PdfCarton.Xmp.Type.JobType), "url", global::DripSharp.PdfCarton.Xmp.Type.Types.Url }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.LayerType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.LayerType), "LayerName", global::DripSharp.PdfCarton.Xmp.Type.Types.Text }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.LayerType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.LayerType), "LayerText", global::DripSharp.PdfCarton.Xmp.Type.Types.Text }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType), "action", global::DripSharp.PdfCarton.Xmp.Type.Types.Choice }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType), "changed", global::DripSharp.PdfCarton.Xmp.Type.Types.Text }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType), "instanceID", global::DripSharp.PdfCarton.Xmp.Type.Types.Guid }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType), "parameters", global::DripSharp.PdfCarton.Xmp.Type.Types.Text }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType), "softwareAgent", global::DripSharp.PdfCarton.Xmp.Type.Types.AgentName }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType), "when", global::DripSharp.PdfCarton.Xmp.Type.Types.Date }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType), "documentID", global::DripSharp.PdfCarton.Xmp.Type.Types.Uri }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType), "filePath", global::DripSharp.PdfCarton.Xmp.Type.Types.Uri }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType), "fromPart", global::DripSharp.PdfCarton.Xmp.Type.Types.Part }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType), "instanceID", global::DripSharp.PdfCarton.Xmp.Type.Types.Uri }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType), "lastModifyDate", global::DripSharp.PdfCarton.Xmp.Type.Types.Date }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType), "manager", global::DripSharp.PdfCarton.Xmp.Type.Types.AgentName }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType), "managerVariant", global::DripSharp.PdfCarton.Xmp.Type.Types.Text }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType), "manageTo", global::DripSharp.PdfCarton.Xmp.Type.Types.Uri }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType), "manageUI", global::DripSharp.PdfCarton.Xmp.Type.Types.Uri }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType), "maskMarkers", global::DripSharp.PdfCarton.Xmp.Type.Types.Choice }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType), "partMapping", global::DripSharp.PdfCarton.Xmp.Type.Types.Text }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType), "renditionClass", global::DripSharp.PdfCarton.Xmp.Type.Types.RenditionClass }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType), "renditionParams", global::DripSharp.PdfCarton.Xmp.Type.Types.Text }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType), "toPart", global::DripSharp.PdfCarton.Xmp.Type.Types.Part }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType), "versionID", global::DripSharp.PdfCarton.Xmp.Type.Types.Text }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ThumbnailType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ThumbnailType), "format", global::DripSharp.PdfCarton.Xmp.Type.Types.Choice }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ThumbnailType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ThumbnailType), "height", global::DripSharp.PdfCarton.Xmp.Type.Types.Integer }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ThumbnailType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ThumbnailType), "width", global::DripSharp.PdfCarton.Xmp.Type.Types.Integer }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.ThumbnailType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.ThumbnailType), "image", global::DripSharp.PdfCarton.Xmp.Type.Types.Text }, new object[] { new global::DripSharp.PdfCarton.Xmp.Type.VersionType(xmp), typeof(global::DripSharp.PdfCarton.Xmp.Type.VersionType), "modifier", global::DripSharp.PdfCarton.Xmp.Type.Types.ProperName });
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_1d2320ae7fcd3d71()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::System.Type>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[2]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[3]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_71dfff13b59f5e62()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::System.Type>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[2]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[3]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_22e55d0e2cf77c21()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::System.Type>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[2]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[3]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_4f3ba6f314009ff6()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::System.Type>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[2]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[3]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_44d7df9c053689e1()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::System.Type>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[2]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[3]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_2acbceaa4cadee2c()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::System.Type>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[2]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[3]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_573fbae239eb371b()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::System.Type>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[2]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[3]) };
    }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_1d2320ae7fcd3d71))]
public void __Upstream_3540789284_14955959c3eb494b(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type)
{
        try
        {
            this.testInitializedToNull(structured, clz, fieldName, type);
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_71dfff13b59f5e62))]
public void __Upstream_2314091617_239795c7690ff50c(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type)
{
        try
        {
            this.testPropertyType(structured, clz, fieldName, type);
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_22e55d0e2cf77c21))]
public void __Upstream_2357975876_db4c82ff530764af(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type)
{
        try
        {
            this.testRandomPropertyType(structured, clz, fieldName, type);
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_4f3ba6f314009ff6))]
public void __Upstream_2610188500_dbb8c6ca69991d40(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type)
{
        try
        {
            this.testRandomSetter(structured, clz, fieldName, type);
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_44d7df9c053689e1))]
public void __Upstream_3730436502_5a7aee327895a655(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type)
{
        try
        {
            this.testRandomSettingValue(structured, clz, fieldName, type);
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_2acbceaa4cadee2c))]
public void __Upstream_3861449649_3af26391d5dc9794(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type)
{
        try
        {
            this.testSetter(structured, clz, fieldName, type);
        }
        finally
        {
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_573fbae239eb371b))]
public void __Upstream_3686552243_be800700ce8db1fa(global::DripSharp.PdfCarton.Xmp.Type.AbstractStructuredType structured, global::System.Type clz, string fieldName, global::DripSharp.PdfCarton.Xmp.Type.Types type)
{
        try
        {
            this.testSettingValue(structured, clz, fieldName, type);
        }
        finally
        {
        }
}
}
