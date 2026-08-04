// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Cos;

public class TestCOSArray {
internal virtual void testCreate() {
global::DripSharp.PdfCarton.Cos.COSArray cosArray = new global::DripSharp.PdfCarton.Cos.COSArray();
global::DripSharp.Testing.JavaAssertions.Equal(0, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => new global::DripSharp.PdfCarton.Cos.COSArray((global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable>)default!), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Constructor should have thrown an exception"));
cosArray = new global::DripSharp.PdfCarton.Cos.COSArray(global::DripSharp.Runtime.JavaCompat.AsList<global::DripSharp.PdfCarton.Cos.COSName>(global::DripSharp.PdfCarton.Cos.COSName.A, global::DripSharp.PdfCarton.Cos.COSName.B, global::DripSharp.PdfCarton.Cos.COSName.C));
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.A, cosArray.Get(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.B, cosArray.Get(1), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.C, cosArray.Get(2), null);
}

internal virtual void testConvertString2COSNameAndBack() {
global::DripSharp.PdfCarton.Cos.COSArray cosArray = global::DripSharp.PdfCarton.Cos.COSArray.OfCOSNames(global::DripSharp.Runtime.JavaCompat.AsList<string>(global::DripSharp.PdfCarton.Cos.COSName.A.GetName(), global::DripSharp.PdfCarton.Cos.COSName.B.GetName(), global::DripSharp.PdfCarton.Cos.COSName.C.GetName()));
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.A, cosArray.Get(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.B, cosArray.Get(1), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.C, cosArray.Get(2), null);
global::System.Collections.Generic.IList<string> cosNameStringList = cosArray.ToCOSNameStringList();
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.Runtime.JavaCompat.CollectionCount(cosNameStringList), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.A.GetName(), global::DripSharp.Runtime.JavaCompat.ListGet(cosNameStringList, 0), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.B.GetName(), global::DripSharp.Runtime.JavaCompat.ListGet(cosNameStringList, 1), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.C.GetName(), global::DripSharp.Runtime.JavaCompat.ListGet(cosNameStringList, 2), null);
}

internal virtual void testConvertString2COSStringAndBack() {
global::DripSharp.PdfCarton.Cos.COSArray cosArray = global::DripSharp.PdfCarton.Cos.COSArray.OfCOSStrings(global::DripSharp.Runtime.JavaCompat.AsList<string>("A", "B", "C"));
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal("A", cosArray.GetString(0), null);
global::DripSharp.Testing.JavaAssertions.Equal("B", cosArray.GetString(1), null);
global::DripSharp.Testing.JavaAssertions.Equal("C", cosArray.GetString(2), null);
global::System.Collections.Generic.IList<string> cosStringStringList = cosArray.ToCOSStringStringList();
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.Runtime.JavaCompat.CollectionCount(cosStringStringList), null);
global::DripSharp.Testing.JavaAssertions.Equal("A", global::DripSharp.Runtime.JavaCompat.ListGet(cosStringStringList, 0), null);
global::DripSharp.Testing.JavaAssertions.Equal("B", global::DripSharp.Runtime.JavaCompat.ListGet(cosStringStringList, 1), null);
global::DripSharp.Testing.JavaAssertions.Equal("C", global::DripSharp.Runtime.JavaCompat.ListGet(cosStringStringList, 2), null);
}

internal virtual void testConvertInteger2COSStringAndBack() {
global::DripSharp.PdfCarton.Cos.COSArray cosArray = global::DripSharp.PdfCarton.Cos.COSArray.OfCOSIntegers(global::DripSharp.Runtime.JavaCompat.AsList<int>(1, 2, 3));
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, cosArray.GetInt(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, cosArray.GetInt(1), null);
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.GetInt(2), null);
global::System.Collections.Generic.IList<int?> cosNumberIntegerList = global::DripSharp.Runtime.JavaCompat.CastList<int?>(cosArray.ToCOSNumberIntegerList());
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.Runtime.JavaCompat.CollectionCount(cosNumberIntegerList), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberIntegerList, 0)))), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberIntegerList, 1)))), null);
global::DripSharp.Testing.JavaAssertions.Equal(3, (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberIntegerList, 2)))), null);
cosArray = new global::DripSharp.PdfCarton.Cos.COSArray(global::DripSharp.Runtime.JavaCompat.AsList<global::DripSharp.PdfCarton.Cos.COSInteger?>(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(1)), (global::DripSharp.PdfCarton.Cos.COSInteger?)default!, global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(3))));
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, cosArray.GetInt(0), null);
global::DripSharp.Testing.JavaAssertions.Null(cosArray.Get(1), null);
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.GetInt(2), null);
cosNumberIntegerList = global::DripSharp.Runtime.JavaCompat.CastList<int?>(cosArray.ToCOSNumberIntegerList());
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.Runtime.JavaCompat.CollectionCount(cosNumberIntegerList), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberIntegerList, 0)))), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberIntegerList, 1), null);
global::DripSharp.Testing.JavaAssertions.Equal(3, (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberIntegerList, 2)))), null);
}

internal virtual void testConvertFloat2COSStringAndBack() {
float[] floatArrayStart = new float[] { 1.0F, 0.1F, 0.02F };
global::DripSharp.PdfCarton.Cos.COSArray cosArray = new global::DripSharp.PdfCarton.Cos.COSArray();
cosArray.SetFloatArray(floatArrayStart);
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSFloat.One, cosArray.Get(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat(0.1F), cosArray.Get(1), null);
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat(0.02F), cosArray.Get(2), null);
global::System.Collections.Generic.IList<float?> cosNumberFloatList = global::DripSharp.Runtime.JavaCompat.CastList<float?>(cosArray.ToCOSNumberFloatList());
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.Runtime.JavaCompat.CollectionCount(cosNumberFloatList), null);
global::DripSharp.Testing.JavaAssertions.Equal(1.0F, (float)(global::DripSharp.Runtime.JavaCompat.Unbox(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberFloatList, 0))), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal(0.1F, (float)(global::DripSharp.Runtime.JavaCompat.Unbox(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberFloatList, 1))), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal(0.02F, (float)(global::DripSharp.Runtime.JavaCompat.Unbox(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberFloatList, 2))), null, (float)(0));
float[] floatArrayEnd = cosArray.ToFloatArray();
global::DripSharp.Testing.JavaAssertions.Equal(1.0F, (float)(global::DripSharp.Runtime.JavaCompat.Unbox(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberFloatList, 0))), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal(0.1F, (float)(global::DripSharp.Runtime.JavaCompat.Unbox(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberFloatList, 1))), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal(0.02F, (float)(global::DripSharp.Runtime.JavaCompat.Unbox(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberFloatList, 2))), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal(floatArrayStart, floatArrayEnd, null, (float)(0));
cosArray = new global::DripSharp.PdfCarton.Cos.COSArray(global::DripSharp.Runtime.JavaCompat.AsList<global::DripSharp.PdfCarton.Cos.COSFloat?>(global::DripSharp.PdfCarton.Cos.COSFloat.One, (global::DripSharp.PdfCarton.Cos.COSFloat?)default!, new global::DripSharp.PdfCarton.Cos.COSFloat(0.02F)));
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSFloat.One, cosArray.Get(0), null);
global::DripSharp.Testing.JavaAssertions.Null(cosArray.Get(1), null);
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat(0.02F), cosArray.Get(2), null);
cosNumberFloatList = global::DripSharp.Runtime.JavaCompat.CastList<float?>(cosArray.ToCOSNumberFloatList());
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.Runtime.JavaCompat.CollectionCount(cosNumberFloatList), null);
global::DripSharp.Testing.JavaAssertions.Equal(1.0F, (float)(global::DripSharp.Runtime.JavaCompat.Unbox(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberFloatList, 0))), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberFloatList, 1), null);
global::DripSharp.Testing.JavaAssertions.Equal(0.02F, (float)(global::DripSharp.Runtime.JavaCompat.Unbox(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberFloatList, 2))), null, (float)(0));
floatArrayEnd = cosArray.ToFloatArray();
global::DripSharp.Testing.JavaAssertions.Equal(new float[] { 1.0F, 0, 0.02F }, floatArrayEnd, null, (float)(0));
}

internal virtual void testGetSetName() {
global::DripSharp.PdfCarton.Cos.COSArray cosArray = new global::DripSharp.PdfCarton.Cos.COSArray();
cosArray.GrowToSize(3);
cosArray.SetName(0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "A"));
cosArray.SetName(1, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "B"));
cosArray.SetName(2, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "C"));
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal("A", cosArray.GetName(0), null);
global::DripSharp.Testing.JavaAssertions.Equal("B", cosArray.GetName(1), null);
global::DripSharp.Testing.JavaAssertions.Equal("C", cosArray.GetName(2), null);
global::DripSharp.Testing.JavaAssertions.Equal("NULL", cosArray.GetName(3, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "NULL")), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, cosArray.IndexOf(global::DripSharp.PdfCarton.Cos.COSName.A), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, cosArray.IndexOf(global::DripSharp.PdfCarton.Cos.COSName.B), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, cosArray.IndexOf(global::DripSharp.PdfCarton.Cos.COSName.C), null);
global::DripSharp.Testing.JavaAssertions.Equal(-1, cosArray.IndexOf(global::DripSharp.PdfCarton.Cos.COSName.D), null);
cosArray.SetName(1, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "D"));
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal("D", cosArray.GetName(1), null);
}

internal virtual void testGetSetInt() {
global::DripSharp.PdfCarton.Cos.COSArray cosArray = new global::DripSharp.PdfCarton.Cos.COSArray();
cosArray.GrowToSize(3);
cosArray.SetInt(0, 0);
cosArray.SetInt(1, 1);
cosArray.SetInt(2, 2);
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, cosArray.GetInt(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, cosArray.GetInt(1), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, cosArray.GetInt(2), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, cosArray.GetInt(3, 0), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, cosArray.IndexOf(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(0))), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, cosArray.IndexOf(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(1))), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, cosArray.IndexOf(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(2))), null);
global::DripSharp.Testing.JavaAssertions.Equal(-1, cosArray.IndexOf(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(3))), null);
cosArray.SetInt(1, 3);
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.GetInt(1), null);
}

internal virtual void testGetSetString() {
global::DripSharp.PdfCarton.Cos.COSArray cosArray = new global::DripSharp.PdfCarton.Cos.COSArray();
cosArray.GrowToSize(3);
cosArray.SetString(0, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test1"));
cosArray.SetString(1, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test2"));
cosArray.SetString(2, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test3"));
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Test1", cosArray.GetString(0), null);
global::DripSharp.Testing.JavaAssertions.Equal("Test2", cosArray.GetString(1), null);
global::DripSharp.Testing.JavaAssertions.Equal("Test3", cosArray.GetString(2), null);
global::DripSharp.Testing.JavaAssertions.Equal("NULL", cosArray.GetString(3, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "NULL")), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, cosArray.IndexOf(new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test1"))), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, cosArray.IndexOf(new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test2"))), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, cosArray.IndexOf(new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test3"))), null);
global::DripSharp.Testing.JavaAssertions.Equal(-1, cosArray.IndexOf(new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test4"))), null);
cosArray.SetString(1, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test4"));
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Test4", cosArray.GetString(1), null);
}

internal virtual void testRemove() {
global::DripSharp.PdfCarton.Cos.COSArray cosArray = global::DripSharp.PdfCarton.Cos.COSArray.OfCOSIntegers(global::DripSharp.Runtime.JavaCompat.AsList<int>(1, 2, 3, 4, 5, 6));
cosArray.Clear();
global::DripSharp.Testing.JavaAssertions.Equal(0, cosArray.Size(), null);
cosArray = global::DripSharp.PdfCarton.Cos.COSArray.OfCOSIntegers(global::DripSharp.Runtime.JavaCompat.AsList<int>(1, 2, 3, 4, 5, 6));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(3)), cosArray.Remove(2), null);
global::DripSharp.Testing.JavaAssertions.Equal(5, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, cosArray.GetInt(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(4, cosArray.GetInt(2), null);
global::DripSharp.Testing.JavaAssertions.True(cosArray.RemoveObject(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(5))), null);
global::DripSharp.Testing.JavaAssertions.Equal(4, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, cosArray.GetInt(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(4, cosArray.GetInt(2), null);
global::DripSharp.Testing.JavaAssertions.Equal(6, cosArray.GetInt(3), null);
cosArray = global::DripSharp.PdfCarton.Cos.COSArray.OfCOSIntegers(global::DripSharp.Runtime.JavaCompat.AsList<int>(1, 2, 3, 4, 5, 6));
cosArray.RemoveAll(global::DripSharp.Runtime.JavaCompat.AsList<global::DripSharp.PdfCarton.Cos.COSBase>(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(3)), global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(4))));
global::DripSharp.Testing.JavaAssertions.Equal(4, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, cosArray.GetInt(1), null);
global::DripSharp.Testing.JavaAssertions.Equal(5, cosArray.GetInt(2), null);
cosArray = global::DripSharp.PdfCarton.Cos.COSArray.OfCOSIntegers(global::DripSharp.Runtime.JavaCompat.AsList<int>(1, 2, 3, 4, 5, 6));
cosArray.RetainAll(global::DripSharp.Runtime.JavaCompat.AsList<global::DripSharp.PdfCarton.Cos.COSBase>(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(3)), global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(4))));
global::DripSharp.Testing.JavaAssertions.Equal(2, cosArray.Size(), null);
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArray.GetInt(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(4, cosArray.GetInt(1), null);
}

internal virtual void testGrowToSize() {
global::DripSharp.PdfCarton.Cos.COSArray cosArray = new global::DripSharp.PdfCarton.Cos.COSArray();
global::DripSharp.Testing.JavaAssertions.Equal(0, cosArray.Size(), null);
cosArray.GrowToSize(2);
global::DripSharp.Testing.JavaAssertions.Equal(2, cosArray.Size(), null);
cosArray.GrowToSize(2, global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(0)));
global::DripSharp.Testing.JavaAssertions.Equal(2, cosArray.Size(), null);
cosArray.GrowToSize(4, global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(1)));
global::DripSharp.Testing.JavaAssertions.Equal(4, cosArray.Size(), null);
global::System.Collections.Generic.IList<int?> cosNumberIntegerList = global::DripSharp.Runtime.JavaCompat.CastList<int?>(cosArray.ToCOSNumberIntegerList());
global::DripSharp.Testing.JavaAssertions.Equal(4, global::DripSharp.Runtime.JavaCompat.CollectionCount(cosNumberIntegerList), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberIntegerList, 0), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberIntegerList, 2)))), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(global::DripSharp.Runtime.JavaCompat.ListGet(cosNumberIntegerList, 3)))), null);
}

internal virtual void testToList() {
global::DripSharp.PdfCarton.Cos.COSArray cosArray = global::DripSharp.PdfCarton.Cos.COSArray.OfCOSIntegers(global::DripSharp.Runtime.JavaCompat.AsList<int>(0, 1, 2, 3, 4, 5));
global::System.Collections.Generic.IReadOnlyList<global::DripSharp.PdfCarton.Cos.COSBase> list = cosArray.ToList();
global::DripSharp.Testing.JavaAssertions.Equal(6, global::DripSharp.Runtime.JavaCompat.CollectionCount(list), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(0)), global::DripSharp.Runtime.JavaCompat.ListGet(list, 0), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(5)), global::DripSharp.Runtime.JavaCompat.ListGet(list, 5), null);
}

[Xunit.Fact]
public void __Upstream_4043523933_0365d9d4f8a6b064()
{
        try
        {
            this.testConvertFloat2COSStringAndBack();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2606253179_b3f3b0c150846331()
{
        try
        {
            this.testConvertInteger2COSStringAndBack();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0701107372_ff564678852ee014()
{
        try
        {
            this.testConvertString2COSNameAndBack();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0476762662_a94f76204aab27f5()
{
        try
        {
            this.testConvertString2COSStringAndBack();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3414924334_97b64b3c95cd8d3b()
{
        try
        {
            this.testCreate();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3607392945_e52927d4734e4487()
{
        try
        {
            this.testGetSetInt();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0160167945_de3bbfe2669de057()
{
        try
        {
            this.testGetSetName();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3758388751_90d3c7c65d062a71()
{
        try
        {
            this.testGetSetString();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3703151937_2a80b89b1a52b8f5()
{
        try
        {
            this.testGrowToSize();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3832607670_d8efabc17b247e01()
{
        try
        {
            this.testRemove();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3898112235_077c57495e0c53db()
{
        try
        {
            this.testToList();
        }
        finally
        {
        }
}
}
