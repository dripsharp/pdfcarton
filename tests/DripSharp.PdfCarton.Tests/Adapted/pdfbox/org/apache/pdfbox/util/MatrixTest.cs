// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Util;

public class MatrixTest {
internal virtual void testConstructionAndCopy() {
global::DripSharp.PdfCarton.Util.Matrix m1 = new global::DripSharp.PdfCarton.Util.Matrix();
this.assertMatrixIsPristine(m1);
global::DripSharp.PdfCarton.Util.Matrix m2 = m1.Clone();
global::DripSharp.Testing.JavaAssertions.NotSame(m1, m2, null);
this.assertMatrixIsPristine(m2);
}

internal virtual void testGetScalingFactor() {
global::DripSharp.PdfCarton.Util.Matrix m1 = new global::DripSharp.PdfCarton.Util.Matrix();
global::DripSharp.Testing.JavaAssertions.Equal((float)(1), m1.GetScalingFactorX(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(1), m1.GetScalingFactorY(), null, (float)(0));
global::DripSharp.PdfCarton.Util.Matrix m2 = new global::DripSharp.PdfCarton.Util.Matrix((float)(2), (float)(4), (float)(4), (float)(2), (float)(0), (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)((float)(global::System.Math.Sqrt((double)(20)))), m2.GetScalingFactorX(), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)((float)(global::System.Math.Sqrt((double)(20)))), m2.GetScalingFactorY(), null, (float)(0));
}

internal virtual void testCreateMatrixUsingInvalidInput() {
global::DripSharp.PdfCarton.Util.Matrix createMatrix = global::DripSharp.PdfCarton.Util.Matrix.CreateMatrix(global::DripSharp.PdfCarton.Cos.COSName.A);
this.assertMatrixIsPristine(createMatrix);
global::DripSharp.PdfCarton.Cos.COSArray cosArray = new global::DripSharp.PdfCarton.Cos.COSArray();
cosArray.Add(global::DripSharp.PdfCarton.Cos.COSName.A);
createMatrix = global::DripSharp.PdfCarton.Util.Matrix.CreateMatrix(cosArray);
this.assertMatrixIsPristine(createMatrix);
cosArray = new global::DripSharp.PdfCarton.Cos.COSArray();
for (int i = 0; (i < 6); i++) {
cosArray.Add(global::DripSharp.PdfCarton.Cos.COSName.A);
}
createMatrix = global::DripSharp.PdfCarton.Util.Matrix.CreateMatrix(cosArray);
this.assertMatrixIsPristine(createMatrix);
}

internal virtual void testMultiplication() {
global::DripSharp.PdfCarton.Util.Matrix const1 = new global::DripSharp.PdfCarton.Util.Matrix();
global::DripSharp.PdfCarton.Util.Matrix const2 = new global::DripSharp.PdfCarton.Util.Matrix();
for (int x = 0; (x < 3); x++) {
for (int y = 0; (y < 3); y++) {
const1.SetValue(x, y, (float)((x + y)));
const2.SetValue(x, y, (float)(((8 + x) + y)));
}
}
float[] m1MultipliedByM1 = new float[] { 5, 8, 11, 8, 14, 20, 11, 20, 29 };
float[] m1MultipliedByM2 = new float[] { 29, 32, 35, 56, 62, 68, 83, 92, 101 };
float[] m2MultipliedByM1 = new float[] { 29, 56, 83, 32, 62, 92, 35, 68, 101 };
global::DripSharp.PdfCarton.Util.Matrix var1 = const1.Clone();
global::DripSharp.PdfCarton.Util.Matrix var2 = const2.Clone();
global::DripSharp.PdfCarton.Util.Matrix result = var1.Multiply(var2);
global::DripSharp.Testing.JavaAssertions.Equal(const1, var1, null);
global::DripSharp.Testing.JavaAssertions.Equal(const2, var2, null);
this.assertMatrixValuesEqualTo(m1MultipliedByM2, result);
result = var1.Multiply(var2);
global::DripSharp.Testing.JavaAssertions.Equal(const1, var1, null);
global::DripSharp.Testing.JavaAssertions.Equal(const2, var2, null);
this.assertMatrixValuesEqualTo(m1MultipliedByM2, result);
var1 = const1.Clone();
var2 = const2.Clone();
var1.Concatenate(var2);
global::DripSharp.Testing.JavaAssertions.Equal(const2, var2, null);
this.assertMatrixValuesEqualTo(m2MultipliedByM1, var1);
var1 = const1.Clone();
var2 = const2.Clone();
result = global::DripSharp.PdfCarton.Util.Matrix.Concatenate(var1, var2);
global::DripSharp.Testing.JavaAssertions.Equal(const1, var1, null);
global::DripSharp.Testing.JavaAssertions.Equal(const2, var2, null);
this.assertMatrixValuesEqualTo(m2MultipliedByM1, result);
var1 = const1.Clone();
result = var1.Multiply(var1);
global::DripSharp.Testing.JavaAssertions.Equal(const1, var1, null);
this.assertMatrixValuesEqualTo(m1MultipliedByM1, result);
}

internal virtual void testOldMultiplication() {
global::DripSharp.PdfCarton.Util.Matrix testMatrix = new global::DripSharp.PdfCarton.Util.Matrix();
for (int x = 0; (x < 3); x++) {
for (int y = 0; (y < 3); y++) {
testMatrix.SetValue(x, y, (float)((x + y)));
}
}
global::DripSharp.PdfCarton.Util.Matrix m1 = testMatrix.Clone();
global::DripSharp.PdfCarton.Util.Matrix m2 = testMatrix.Clone();
global::DripSharp.PdfCarton.Util.Matrix product = m1.Multiply(m2);
global::DripSharp.Testing.JavaAssertions.NotSame(m1, product, null);
global::DripSharp.Testing.JavaAssertions.NotSame(m2, product, null);
this.assertMatrixValuesEqualTo(new float[] { 0, 1, 2, 1, 2, 3, 2, 3, 4 }, m1);
this.assertMatrixValuesEqualTo(new float[] { 0, 1, 2, 1, 2, 3, 2, 3, 4 }, m2);
this.assertMatrixValuesEqualTo(new float[] { 5, 8, 11, 8, 14, 20, 11, 20, 29 }, product);
global::DripSharp.PdfCarton.Util.Matrix retVal = m1.Multiply(m2);
this.assertMatrixValuesEqualTo(new float[] { 0, 1, 2, 1, 2, 3, 2, 3, 4 }, m1);
this.assertMatrixValuesEqualTo(new float[] { 0, 1, 2, 1, 2, 3, 2, 3, 4 }, m2);
this.assertMatrixValuesEqualTo(new float[] { 5, 8, 11, 8, 14, 20, 11, 20, 29 }, retVal);
m1 = testMatrix.Clone();
retVal = m1.Multiply(m1);
this.assertMatrixValuesEqualTo(new float[] { 0, 1, 2, 1, 2, 3, 2, 3, 4 }, m1);
this.assertMatrixValuesEqualTo(new float[] { 5, 8, 11, 8, 14, 20, 11, 20, 29 }, retVal);
}

internal virtual void testIllegalValueNaN1() {
global::DripSharp.PdfCarton.Util.Matrix m = new global::DripSharp.PdfCarton.Util.Matrix();
m.SetValue(0, 0, float.MaxValue);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => m.Multiply(m), null);
}

internal virtual void testIllegalValueNaN2() {
global::DripSharp.PdfCarton.Util.Matrix m = new global::DripSharp.PdfCarton.Util.Matrix();
m.SetValue(0, 0, float.NaN);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => m.Multiply(m), null);
}

internal virtual void testIllegalValuePositiveInfinity() {
global::DripSharp.PdfCarton.Util.Matrix m = new global::DripSharp.PdfCarton.Util.Matrix();
m.SetValue(0, 0, float.PositiveInfinity);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => m.Multiply(m), null);
}

internal virtual void testIllegalValueNegativeInfinity() {
global::DripSharp.PdfCarton.Util.Matrix m = new global::DripSharp.PdfCarton.Util.Matrix();
m.SetValue(0, 0, float.NegativeInfinity);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => m.Multiply(m), null);
}

internal virtual void testPdfbox2872() {
global::DripSharp.PdfCarton.Util.Matrix m = new global::DripSharp.PdfCarton.Util.Matrix((float)(2), (float)(4), (float)(5), (float)(8), (float)(2), (float)(0));
global::DripSharp.PdfCarton.Cos.COSArray toCOSArray = m.ToCOSArray();
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat((float)(2)), toCOSArray.Get(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat((float)(4)), toCOSArray.Get(1), null);
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat((float)(5)), toCOSArray.Get(2), null);
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat((float)(8)), toCOSArray.Get(3), null);
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat((float)(2)), toCOSArray.Get(4), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSFloat.Zero, toCOSArray.Get(5), null);
}

internal virtual void testGetValues() {
global::DripSharp.PdfCarton.Util.Matrix m = new global::DripSharp.PdfCarton.Util.Matrix((float)(2), (float)(4), (float)(4), (float)(2), (float)(15), (float)(30));
float[][] values = m.GetValues();
global::DripSharp.Testing.JavaAssertions.Equal((float)(2), values[0][0], null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(4), values[0][1], null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(0), values[0][2], null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(4), values[1][0], null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(2), values[1][1], null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(0), values[1][2], null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(15), values[2][0], null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(30), values[2][1], null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(1), values[2][2], null, (float)(0));
}

internal virtual void testScaling() {
global::DripSharp.PdfCarton.Util.Matrix m = new global::DripSharp.PdfCarton.Util.Matrix((float)(2), (float)(4), (float)(4), (float)(2), (float)(15), (float)(30));
m.Scale((float)(2), (float)(3));
global::DripSharp.Testing.JavaAssertions.Equal((float)(4), m.GetValue(0, 0), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(8), m.GetValue(0, 1), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(0), m.GetValue(0, 2), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(12), m.GetValue(1, 0), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(6), m.GetValue(1, 1), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(0), m.GetValue(1, 2), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(15), m.GetValue(2, 0), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(30), m.GetValue(2, 1), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(1), m.GetValue(2, 2), null, (float)(0));
}

internal virtual void testTranslation() {
global::DripSharp.PdfCarton.Util.Matrix m = new global::DripSharp.PdfCarton.Util.Matrix((float)(2), (float)(4), (float)(4), (float)(2), (float)(15), (float)(30));
m.Translate((float)(2), (float)(3));
global::DripSharp.Testing.JavaAssertions.Equal((float)(2), m.GetValue(0, 0), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(4), m.GetValue(0, 1), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(0), m.GetValue(0, 2), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(4), m.GetValue(1, 0), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(2), m.GetValue(1, 1), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(0), m.GetValue(1, 2), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(31), m.GetValue(2, 0), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(44), m.GetValue(2, 1), null, (float)(0));
global::DripSharp.Testing.JavaAssertions.Equal((float)(1), m.GetValue(2, 2), null, (float)(0));
}

private void assertMatrixIsPristine(global::DripSharp.PdfCarton.Util.Matrix m) {
this.assertMatrixValuesEqualTo(new float[] { 1, 0, 0, 0, 1, 0, 0, 0, 1 }, m);
}

private void assertMatrixValuesEqualTo(float[] values, global::DripSharp.PdfCarton.Util.Matrix m) {
float delta = 1.0E-5F;
for (int i = 0; (i < values.Length); i++) {
int row = (i / 3);
int column = (i % 3);
global::System.Text.StringBuilder failureMsg = new global::System.Text.StringBuilder();
failureMsg.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Incorrect value for matrix[")).Append(row).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ",")).Append(column).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "]"));
global::DripSharp.Testing.JavaAssertions.Equal(values[i], m.GetValue(row, column), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", failureMsg.ToString()), delta);
}
}

internal virtual void testMultiplicationPerformance() {
long start = global::System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
global::DripSharp.PdfCarton.Util.Matrix c;
global::DripSharp.PdfCarton.Util.Matrix d;
for (int i = 0; (i < 100000000); i++) {
c = new global::DripSharp.PdfCarton.Util.Matrix((float)(15), (float)(3), (float)(235), (float)(55), (float)(422), (float)(1));
d = new global::DripSharp.PdfCarton.Util.Matrix((float)(45), (float)(345), (float)(23), (float)(551), (float)(66), (float)(832));
c.Multiply(d);
c.Concatenate(d);
}
long stop = global::System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Matrix multiplication took ", (stop - start)), "ms.")));
}

[Xunit.Fact]
public void __Upstream_3915532777_b1d8c119ced35a85()
{
        try
        {
            this.testConstructionAndCopy();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1805110504_2c34644839910972()
{
        try
        {
            this.testCreateMatrixUsingInvalidInput();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3486695602_b11693fe84a78cf6()
{
        try
        {
            this.testGetScalingFactor();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3689389990_efdc12bf7a9c457f()
{
        try
        {
            this.testGetValues();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3999469955_e7533fcfe75f0479()
{
        try
        {
            this.testIllegalValueNaN1();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3999469956_ec534024ec9c8f46()
{
        try
        {
            this.testIllegalValueNaN2();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0374895850_e4eeef7141ae8d46()
{
        try
        {
            this.testIllegalValueNegativeInfinity();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1720450734_fbdca7c7df20725d()
{
        try
        {
            this.testIllegalValuePositiveInfinity();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1563848888_fb00ad8e9542c452()
{
        try
        {
            this.testMultiplication();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0563897115_09dca67b54182ff9()
{
        try
        {
            this.testOldMultiplication();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2286223596_3ef06332adea044a()
{
        try
        {
            this.testPdfbox2872();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3665782421_30d1c24e4204aca4()
{
        try
        {
            this.testScaling();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3942327999_1926a1c9765d87be()
{
        try
        {
            this.testTranslation();
        }
        finally
        {
        }
}
}
