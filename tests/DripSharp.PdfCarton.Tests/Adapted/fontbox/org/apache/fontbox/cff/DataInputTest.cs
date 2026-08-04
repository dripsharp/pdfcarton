// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Cff;

public class DataInputTest {
internal virtual void testReadBytes() {
sbyte[] data = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(-1)), unchecked((sbyte)(2)), unchecked((sbyte)(-3)), unchecked((sbyte)(4)), unchecked((sbyte)(-5)), unchecked((sbyte)(6)), unchecked((sbyte)(-7)), unchecked((sbyte)(8)), unchecked((sbyte)(-9)) };
global::DripSharp.PdfCarton.Fonts.Cff.DataInput dataInput = new global::DripSharp.PdfCarton.Fonts.Cff.DataInputByteArray(data);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => dataInput.ReadBytes(20), null);
global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)(0)) }, dataInput.ReadBytes(1), null);
global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)(-1)), unchecked((sbyte)(2)), unchecked((sbyte)(-3)) }, dataInput.ReadBytes(3), null);
dataInput.SetPosition(6);
global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)(6)), unchecked((sbyte)(-7)), unchecked((sbyte)(8)) }, dataInput.ReadBytes(3), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => dataInput.ReadBytes(-1), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => dataInput.ReadBytes(5), null);
}

internal virtual void testReadByte() {
sbyte[] data = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(-1)), unchecked((sbyte)(2)), unchecked((sbyte)(-3)), unchecked((sbyte)(4)), unchecked((sbyte)(-5)), unchecked((sbyte)(6)), unchecked((sbyte)(-7)), unchecked((sbyte)(8)), unchecked((sbyte)(-9)) };
global::DripSharp.PdfCarton.Fonts.Cff.DataInput dataInput = new global::DripSharp.PdfCarton.Fonts.Cff.DataInputByteArray(data);
global::DripSharp.Testing.JavaAssertions.Equal(0, (int)(dataInput.ReadByte()), null);
global::DripSharp.Testing.JavaAssertions.Equal(-1, (int)(dataInput.ReadByte()), null);
dataInput.SetPosition(6);
global::DripSharp.Testing.JavaAssertions.Equal(6, (int)(dataInput.ReadByte()), null);
global::DripSharp.Testing.JavaAssertions.Equal(-7, (int)(dataInput.ReadByte()), null);
dataInput.SetPosition((dataInput.Length() - 1));
global::DripSharp.Testing.JavaAssertions.Equal(-9, (int)(dataInput.ReadByte()), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => { dataInput.ReadByte(); }, null);
}

internal virtual void testReadUnsignedByte() {
sbyte[] data = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(-1)), unchecked((sbyte)(2)), unchecked((sbyte)(-3)), unchecked((sbyte)(4)), unchecked((sbyte)(-5)), unchecked((sbyte)(6)), unchecked((sbyte)(-7)), unchecked((sbyte)(8)), unchecked((sbyte)(-9)) };
global::DripSharp.PdfCarton.Fonts.Cff.DataInput dataInput = new global::DripSharp.PdfCarton.Fonts.Cff.DataInputByteArray(data);
global::DripSharp.Testing.JavaAssertions.Equal(0, dataInput.ReadUnsignedByte(), null);
global::DripSharp.Testing.JavaAssertions.Equal(255, dataInput.ReadUnsignedByte(), null);
dataInput.SetPosition(6);
global::DripSharp.Testing.JavaAssertions.Equal(6, dataInput.ReadUnsignedByte(), null);
global::DripSharp.Testing.JavaAssertions.Equal(249, dataInput.ReadUnsignedByte(), null);
dataInput.SetPosition((dataInput.Length() - 1));
global::DripSharp.Testing.JavaAssertions.Equal(247, dataInput.ReadUnsignedByte(), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => { dataInput.ReadUnsignedByte(); }, null);
}

internal virtual void testBasics() {
sbyte[] data = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(-1)), unchecked((sbyte)(2)), unchecked((sbyte)(-3)), unchecked((sbyte)(4)), unchecked((sbyte)(-5)), unchecked((sbyte)(6)), unchecked((sbyte)(-7)), unchecked((sbyte)(8)), unchecked((sbyte)(-9)) };
global::DripSharp.PdfCarton.Fonts.Cff.DataInput dataInput = new global::DripSharp.PdfCarton.Fonts.Cff.DataInputByteArray(data);
global::DripSharp.Testing.JavaAssertions.Equal(10, dataInput.Length(), null);
global::DripSharp.Testing.JavaAssertions.True(dataInput.HasRemaining(), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => dataInput.SetPosition(-1), null);
int length = dataInput.Length();
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => dataInput.SetPosition(length), null);
}

internal virtual void testPeek() {
sbyte[] data = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(-1)), unchecked((sbyte)(2)), unchecked((sbyte)(-3)), unchecked((sbyte)(4)), unchecked((sbyte)(-5)), unchecked((sbyte)(6)), unchecked((sbyte)(-7)), unchecked((sbyte)(8)), unchecked((sbyte)(-9)) };
global::DripSharp.PdfCarton.Fonts.Cff.DataInput dataInput = new global::DripSharp.PdfCarton.Fonts.Cff.DataInputByteArray(data);
global::DripSharp.Testing.JavaAssertions.Equal(0, dataInput.PeekUnsignedByte(0), null);
global::DripSharp.Testing.JavaAssertions.Equal(251, dataInput.PeekUnsignedByte(5), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => dataInput.PeekUnsignedByte(-1), null);
int length = dataInput.Length();
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => dataInput.PeekUnsignedByte(length), null);
}

internal virtual void testReadShort() {
sbyte[] data = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(15)), unchecked((sbyte)(170)), unchecked((sbyte)(0)), unchecked((sbyte)(254)), unchecked((sbyte)(255)) };
global::DripSharp.PdfCarton.Fonts.Cff.DataInput dataInput = new global::DripSharp.PdfCarton.Fonts.Cff.DataInputByteArray(data);
global::DripSharp.Testing.JavaAssertions.Equal(unchecked((short)(15)), ((global::DripSharp.PdfCarton.Fonts.Cff.DataInput)(dataInput)).ReadShort(), null);
global::DripSharp.Testing.JavaAssertions.Equal(unchecked((short)(43520)), ((global::DripSharp.PdfCarton.Fonts.Cff.DataInput)(dataInput)).ReadShort(), null);
global::DripSharp.Testing.JavaAssertions.Equal(unchecked((short)(65279)), ((global::DripSharp.PdfCarton.Fonts.Cff.DataInput)(dataInput)).ReadShort(), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => { dataInput.ReadShort(); }, null);
}

internal virtual void testReadUnsignedShort() {
sbyte[] data = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(15)), unchecked((sbyte)(170)), unchecked((sbyte)(0)), unchecked((sbyte)(254)), unchecked((sbyte)(255)) };
global::DripSharp.PdfCarton.Fonts.Cff.DataInput dataInput = new global::DripSharp.PdfCarton.Fonts.Cff.DataInputByteArray(data);
global::DripSharp.Testing.JavaAssertions.Equal(15, ((global::DripSharp.PdfCarton.Fonts.Cff.DataInput)(dataInput)).ReadUnsignedShort(), null);
global::DripSharp.Testing.JavaAssertions.Equal(43520, ((global::DripSharp.PdfCarton.Fonts.Cff.DataInput)(dataInput)).ReadUnsignedShort(), null);
global::DripSharp.Testing.JavaAssertions.Equal(65279, ((global::DripSharp.PdfCarton.Fonts.Cff.DataInput)(dataInput)).ReadUnsignedShort(), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => { dataInput.ReadUnsignedShort(); }, null);
sbyte[] data2 = new sbyte[] { unchecked((sbyte)(0)) };
global::DripSharp.PdfCarton.Fonts.Cff.DataInput dataInput2 = new global::DripSharp.PdfCarton.Fonts.Cff.DataInputByteArray(data2);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => { dataInput2.ReadUnsignedShort(); }, null);
}

internal virtual void testReadInt() {
sbyte[] data = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(15)), unchecked((sbyte)(170)), unchecked((sbyte)(0)), unchecked((sbyte)(254)), unchecked((sbyte)(255)), unchecked((sbyte)(48)), unchecked((sbyte)(80)) };
global::DripSharp.PdfCarton.Fonts.Cff.DataInput dataInput = new global::DripSharp.PdfCarton.Fonts.Cff.DataInputByteArray(data);
global::DripSharp.Testing.JavaAssertions.Equal(1026560, ((global::DripSharp.PdfCarton.Fonts.Cff.DataInput)(dataInput)).ReadInt(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-16830384, ((global::DripSharp.PdfCarton.Fonts.Cff.DataInput)(dataInput)).ReadInt(), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => { dataInput.ReadInt(); }, null);
sbyte[] data2 = new sbyte[] { unchecked((sbyte)(0)), unchecked((sbyte)(15)), unchecked((sbyte)(170)) };
global::DripSharp.PdfCarton.Fonts.Cff.DataInput dataInput2 = new global::DripSharp.PdfCarton.Fonts.Cff.DataInputByteArray(data2);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => { dataInput2.ReadInt(); }, null);
}

[Xunit.Fact]
public void __Upstream_3371019575_4ac489cb4016ae90()
{
        try
        {
            this.testBasics();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1000575245_deafd2cf3f00259d()
{
        try
        {
            this.testPeek();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1993763440_b284a05d57050441()
{
        try
        {
            this.testReadByte();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1677124611_db2a71e3f2adb3e2()
{
        try
        {
            this.testReadBytes();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2835267975_9c7a3841b9c99cba()
{
        try
        {
            this.testReadInt();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1692313620_4513c53f93e07f59()
{
        try
        {
            this.testReadShort();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0912382725_91bf7268fb7053af()
{
        try
        {
            this.testReadUnsignedByte();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2529249823_a4150b68dbb2bcf0()
{
        try
        {
            this.testReadUnsignedShort();
        }
        finally
        {
        }
}
}
