// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Cmap;

public class CMapStringsTest {
internal virtual void getNonCachedMappings() {
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(0)), unchecked((sbyte)(0)) }), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(0)), unchecked((sbyte)(0)), unchecked((sbyte)(0)) }), null);
}

internal virtual void getMappingOneByte() {
sbyte[] minValueOneByte = new sbyte[] { unchecked((sbyte)(0)) };
string minValueMapping = global::DripSharp.Runtime.JavaCompat.NewString(minValueOneByte, global::DripSharp.Runtime.JavaStandardCharsets.ISO88591);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(minValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(minValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(minValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(minValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.Equal(minValueMapping, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(minValueOneByte), null);
sbyte[] maxValueOneByte = new sbyte[] { unchecked((sbyte)(255)) };
string maxValueMapping = global::DripSharp.Runtime.JavaCompat.NewString(maxValueOneByte, global::DripSharp.Runtime.JavaStandardCharsets.ISO88591);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(maxValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(maxValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(maxValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(maxValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.Equal(maxValueMapping, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(maxValueOneByte), null);
sbyte[] anyValueOneByte = new sbyte[] { unchecked((sbyte)(98)) };
string anyValueMapping = global::DripSharp.Runtime.JavaCompat.NewString(anyValueOneByte, global::DripSharp.Runtime.JavaStandardCharsets.ISO88591);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.Equal(anyValueMapping, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueOneByte), null);
}

internal virtual void getMappingTwoByte() {
sbyte[] minValueTwoByte = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(0)) };
string minValueMapping = global::DripSharp.Runtime.JavaCompat.NewString(minValueTwoByte, global::DripSharp.Runtime.JavaStandardCharsets.UTF16BE);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(minValueTwoByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(minValueTwoByte), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(minValueTwoByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(minValueTwoByte), null);
global::DripSharp.Testing.JavaAssertions.Equal(minValueMapping, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(minValueTwoByte), null);
sbyte[] maxValueTwoByte = new sbyte[] { unchecked((sbyte)(255)), unchecked((sbyte)(255)) };
string maxValueMapping = global::DripSharp.Runtime.JavaCompat.NewString(maxValueTwoByte, global::DripSharp.Runtime.JavaStandardCharsets.UTF16BE);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(maxValueTwoByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(maxValueTwoByte), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(maxValueTwoByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(maxValueTwoByte), null);
global::DripSharp.Testing.JavaAssertions.Equal(maxValueMapping, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(maxValueTwoByte), null);
sbyte[] anyValueTwoByte1 = new sbyte[] { unchecked((sbyte)(98)), unchecked((sbyte)(67)) };
string anyValueMapping1 = global::DripSharp.Runtime.JavaCompat.NewString(anyValueTwoByte1, global::DripSharp.Runtime.JavaStandardCharsets.UTF16BE);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueTwoByte1), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueTwoByte1), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueTwoByte1), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueTwoByte1), null);
global::DripSharp.Testing.JavaAssertions.Equal(anyValueMapping1, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueTwoByte1), null);
sbyte[] anyValueTwoByte2 = new sbyte[] { unchecked((sbyte)(255)), unchecked((sbyte)(67)) };
string anyValueMapping2 = global::DripSharp.Runtime.JavaCompat.NewString(anyValueTwoByte2, global::DripSharp.Runtime.JavaStandardCharsets.UTF16BE);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueTwoByte2), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueTwoByte2), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueTwoByte2), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueTwoByte2), null);
global::DripSharp.Testing.JavaAssertions.Equal(anyValueMapping2, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueTwoByte2), null);
sbyte[] anyValueTwoByte3 = new sbyte[] { unchecked((sbyte)(56)), unchecked((sbyte)(255)) };
string anyValueMapping3 = global::DripSharp.Runtime.JavaCompat.NewString(anyValueTwoByte3, global::DripSharp.Runtime.JavaStandardCharsets.UTF16BE);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueTwoByte3), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueTwoByte3), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueTwoByte3), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueTwoByte3), null);
global::DripSharp.Testing.JavaAssertions.Equal(anyValueMapping3, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetMapping(anyValueTwoByte3), null);
}

internal virtual void getByteValuesOneByte() {
sbyte[] minValueOneByte = new sbyte[] { unchecked((sbyte)(0)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(minValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(minValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(minValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(minValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.NotSame(minValueOneByte, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(minValueOneByte), null);
sbyte[] maxValueOneByte = new sbyte[] { unchecked((sbyte)(255)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(maxValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(maxValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(maxValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(maxValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.NotSame(maxValueOneByte, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(maxValueOneByte), null);
sbyte[] anyValueOneByte = new sbyte[] { unchecked((sbyte)(98)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.NotSame(anyValueOneByte, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueOneByte), null);
}

internal virtual void getByteValuesTwoByte() {
sbyte[] minValueTwoByte = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(0)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(minValueTwoByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(minValueTwoByte), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(minValueTwoByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(minValueTwoByte), null);
global::DripSharp.Testing.JavaAssertions.NotSame(minValueTwoByte, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(minValueTwoByte), null);
sbyte[] maxValueTwoByte = new sbyte[] { unchecked((sbyte)(255)), unchecked((sbyte)(255)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(maxValueTwoByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(maxValueTwoByte), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(maxValueTwoByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(maxValueTwoByte), null);
global::DripSharp.Testing.JavaAssertions.NotSame(maxValueTwoByte, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(maxValueTwoByte), null);
sbyte[] anyValueTwoByte1 = new sbyte[] { unchecked((sbyte)(98)), unchecked((sbyte)(67)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueTwoByte1), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueTwoByte1), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueTwoByte1), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueTwoByte1), null);
global::DripSharp.Testing.JavaAssertions.NotSame(anyValueTwoByte1, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueTwoByte1), null);
sbyte[] anyValueTwoByte2 = new sbyte[] { unchecked((sbyte)(255)), unchecked((sbyte)(67)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueTwoByte2), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueTwoByte2), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueTwoByte2), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueTwoByte2), null);
global::DripSharp.Testing.JavaAssertions.NotSame(anyValueTwoByte2, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueTwoByte2), null);
sbyte[] anyValueTwoByte3 = new sbyte[] { unchecked((sbyte)(56)), unchecked((sbyte)(255)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueTwoByte3), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueTwoByte3), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueTwoByte3), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueTwoByte3), null);
global::DripSharp.Testing.JavaAssertions.NotSame(anyValueTwoByte3, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(anyValueTwoByte3), null);
}

internal virtual void getNonCachedByteValues() {
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(0)), unchecked((sbyte)(0)) }), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetByteValue(new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(0)), unchecked((sbyte)(0)), unchecked((sbyte)(0)) }), null);
}

internal virtual void getIndexValuesOneByte() {
sbyte[] minValueOneByte = new sbyte[] { unchecked((sbyte)(0)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(minValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(minValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(minValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(minValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(minValueOneByte), null);
sbyte[] maxValueOneByte = new sbyte[] { unchecked((sbyte)(255)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(maxValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(maxValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(maxValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(maxValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.Equal(255, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(maxValueOneByte), null);
sbyte[] anyValueOneByte = new sbyte[] { unchecked((sbyte)(98)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueOneByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueOneByte), null);
global::DripSharp.Testing.JavaAssertions.Equal(98, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueOneByte), null);
}

internal virtual void getIndexValuesTwoByte() {
sbyte[] minValueTwoByte = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(0)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(minValueTwoByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(minValueTwoByte), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(minValueTwoByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(minValueTwoByte), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(minValueTwoByte), null);
sbyte[] maxValueTwoByte = new sbyte[] { unchecked((sbyte)(255)), unchecked((sbyte)(255)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(maxValueTwoByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(maxValueTwoByte), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(maxValueTwoByte), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(maxValueTwoByte), null);
global::DripSharp.Testing.JavaAssertions.Equal(65535, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(maxValueTwoByte), null);
sbyte[] anyValueTwoByte1 = new sbyte[] { unchecked((sbyte)(98)), unchecked((sbyte)(67)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueTwoByte1), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueTwoByte1), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueTwoByte1), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueTwoByte1), null);
global::DripSharp.Testing.JavaAssertions.Equal(25155, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueTwoByte1), null);
sbyte[] anyValueTwoByte2 = new sbyte[] { unchecked((sbyte)(255)), unchecked((sbyte)(67)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueTwoByte2), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueTwoByte2), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueTwoByte2), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueTwoByte2), null);
global::DripSharp.Testing.JavaAssertions.Equal(65347, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueTwoByte2), null);
sbyte[] anyValueTwoByte3 = new sbyte[] { unchecked((sbyte)(56)), unchecked((sbyte)(255)) };
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueTwoByte3), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueTwoByte3), null);
global::DripSharp.Testing.JavaAssertions.Same(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueTwoByte3), global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueTwoByte3), null);
global::DripSharp.Testing.JavaAssertions.Equal(14591, global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(anyValueTwoByte3), null);
}

internal virtual void getNonCachedIndexValues() {
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(0)), unchecked((sbyte)(0)) }), null);
global::DripSharp.Testing.JavaAssertions.Null(global::DripSharp.PdfCarton.Fonts.Cmap.CMapStrings.GetIndexValue(new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(0)), unchecked((sbyte)(0)), unchecked((sbyte)(0)) }), null);
}

[Xunit.Fact]
public void __Upstream_3826349102_8896a0dbb3dc47ed()
{
        try
        {
            this.getByteValuesOneByte();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4235797780_50c41bd56bb25c00()
{
        try
        {
            this.getByteValuesTwoByte();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0178847568_378ab98aa4cdbdb8()
{
        try
        {
            this.getIndexValuesOneByte();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0588296246_543d51260301b345()
{
        try
        {
            this.getIndexValuesTwoByte();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1124288726_6bfa56ac8d084558()
{
        try
        {
            this.getMappingOneByte();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1533737404_b15186f402d1ad99()
{
        try
        {
            this.getMappingTwoByte();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0969945283_8ffee9c85ed14f52()
{
        try
        {
            this.getNonCachedByteValues();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1110945595_a0bf1e07ca141703()
{
        try
        {
            this.getNonCachedIndexValues();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0892074014_41c785078a1aef56()
{
        try
        {
            this.getNonCachedMappings();
        }
        finally
        {
        }
}
}
