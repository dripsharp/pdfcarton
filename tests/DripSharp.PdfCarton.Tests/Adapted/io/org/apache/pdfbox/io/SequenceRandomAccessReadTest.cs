// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.IO;

public class SequenceRandomAccessReadTest {
internal virtual void TestCreateAndRead() {
string input1 = "This is a test string number 1";
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessReadBuffer1 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.StringGetBytes(input1, global::System.Text.Encoding.UTF8));
string input2 = "This is a test string number 2";
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessReadBuffer2 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.StringGetBytes(input2, global::System.Text.Encoding.UTF8));
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.IO.RandomAccessRead> inputList = global::DripSharp.Runtime.JavaCompat.AsList<global::DripSharp.PdfCarton.IO.RandomAccessRead>(randomAccessReadBuffer1, randomAccessReadBuffer2);
using (global::DripSharp.PdfCarton.IO.SequenceRandomAccessRead sequenceRandomAccessRead = new global::DripSharp.PdfCarton.IO.SequenceRandomAccessRead(inputList)) {
global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(() => sequenceRandomAccessRead.CreateView((long)(0), (long)(10)), null);
int overallLength = (input1.Length + input2.Length);
global::DripSharp.Testing.JavaAssertions.Equal((long)(overallLength), sequenceRandomAccessRead.Length(), null);
sbyte[] bytesRead = new sbyte[overallLength];
global::DripSharp.Testing.JavaAssertions.Equal(overallLength, ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead))).Read(bytesRead), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat(input1, input2), global::DripSharp.Runtime.JavaCompat.NewString(bytesRead, global::System.Text.Encoding.UTF8), null);
}
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => new global::DripSharp.PdfCarton.IO.SequenceRandomAccessRead((global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.IO.RandomAccessRead>)default!), null);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.IO.RandomAccessRead> emptyList = global::System.Array.Empty<global::DripSharp.PdfCarton.IO.RandomAccessRead>();
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => new global::DripSharp.PdfCarton.IO.SequenceRandomAccessRead(emptyList), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => new global::DripSharp.PdfCarton.IO.SequenceRandomAccessRead(inputList), null);
}

internal virtual void TestSeekPeekAndRewind() {
string input1 = "01234567890123456789";
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessReadBuffer1 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.StringGetBytes(input1, global::System.Text.Encoding.UTF8));
string input2 = "abcdefghijklmnopqrst";
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessReadBuffer2 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.StringGetBytes(input2, global::System.Text.Encoding.UTF8));
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.IO.RandomAccessRead> inputList = global::DripSharp.Runtime.JavaCompat.AsList<global::DripSharp.PdfCarton.IO.RandomAccessRead>(randomAccessReadBuffer1, randomAccessReadBuffer2);
using (global::DripSharp.PdfCarton.IO.SequenceRandomAccessRead sequenceRandomAccessRead = new global::DripSharp.PdfCarton.IO.SequenceRandomAccessRead(inputList)) {
sequenceRandomAccessRead.Seek((long)(4));
global::DripSharp.Testing.JavaAssertions.Equal((long)(4), sequenceRandomAccessRead.GetPosition(), null);
global::DripSharp.Testing.JavaAssertions.Equal((int)('4'), sequenceRandomAccessRead.Read(), null);
global::DripSharp.Testing.JavaAssertions.Equal((long)(5), sequenceRandomAccessRead.GetPosition(), null);
((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead)).Rewind(1);
global::DripSharp.Testing.JavaAssertions.Equal((long)(4), sequenceRandomAccessRead.GetPosition(), null);
global::DripSharp.Testing.JavaAssertions.Equal((int)('4'), sequenceRandomAccessRead.Read(), null);
global::DripSharp.Testing.JavaAssertions.Equal((int)('5'), ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead)).Peek(), null);
global::DripSharp.Testing.JavaAssertions.Equal((long)(5), sequenceRandomAccessRead.GetPosition(), null);
global::DripSharp.Testing.JavaAssertions.Equal((int)('5'), sequenceRandomAccessRead.Read(), null);
global::DripSharp.Testing.JavaAssertions.Equal((long)(6), sequenceRandomAccessRead.GetPosition(), null);
sequenceRandomAccessRead.Seek((long)(24));
global::DripSharp.Testing.JavaAssertions.Equal((long)(24), sequenceRandomAccessRead.GetPosition(), null);
global::DripSharp.Testing.JavaAssertions.Equal((int)('e'), sequenceRandomAccessRead.Read(), null);
((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead)).Rewind(1);
global::DripSharp.Testing.JavaAssertions.Equal((int)('e'), sequenceRandomAccessRead.Read(), null);
global::DripSharp.Testing.JavaAssertions.Equal((int)('f'), ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead)).Peek(), null);
global::DripSharp.Testing.JavaAssertions.Equal((int)('f'), sequenceRandomAccessRead.Read(), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => sequenceRandomAccessRead.Seek((long)(-1)), null);
}
}

internal virtual void TestBorderCases() {
string input1 = "01234567890123456789";
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessReadBuffer1 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.StringGetBytes(input1, global::System.Text.Encoding.UTF8));
string input2 = "abcdefghijklmnopqrst";
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessReadBuffer2 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.StringGetBytes(input2, global::System.Text.Encoding.UTF8));
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.IO.RandomAccessRead> inputList = global::DripSharp.Runtime.JavaCompat.AsList<global::DripSharp.PdfCarton.IO.RandomAccessRead>(randomAccessReadBuffer1, randomAccessReadBuffer2);
using (global::DripSharp.PdfCarton.IO.SequenceRandomAccessRead sequenceRandomAccessRead = new global::DripSharp.PdfCarton.IO.SequenceRandomAccessRead(inputList)) {
sequenceRandomAccessRead.Seek((long)(19));
global::DripSharp.Testing.JavaAssertions.Equal((int)('9'), sequenceRandomAccessRead.Read(), null);
((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead)).Rewind(1);
global::DripSharp.Testing.JavaAssertions.Equal((int)('9'), sequenceRandomAccessRead.Read(), null);
global::DripSharp.Testing.JavaAssertions.Equal((int)('a'), ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead)).Peek(), null);
global::DripSharp.Testing.JavaAssertions.Equal((int)('a'), sequenceRandomAccessRead.Read(), null);
sequenceRandomAccessRead.Seek((long)(17));
sbyte[] bytesRead = new sbyte[6];
global::DripSharp.Testing.JavaAssertions.Equal(6, ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead))).Read(bytesRead), null);
global::DripSharp.Testing.JavaAssertions.Equal("789abc", global::DripSharp.Runtime.JavaCompat.NewString(bytesRead, global::System.Text.Encoding.UTF8), null);
global::DripSharp.Testing.JavaAssertions.Equal((long)(23), sequenceRandomAccessRead.GetPosition(), null);
((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead)).Rewind(6);
global::DripSharp.Testing.JavaAssertions.Equal((long)(17), sequenceRandomAccessRead.GetPosition(), null);
bytesRead = new sbyte[6];
global::DripSharp.Testing.JavaAssertions.Equal(6, ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead))).Read(bytesRead), null);
global::DripSharp.Testing.JavaAssertions.Equal("789abc", global::DripSharp.Runtime.JavaCompat.NewString(bytesRead, global::System.Text.Encoding.UTF8), null);
sequenceRandomAccessRead.Seek((long)(0));
bytesRead = new sbyte[6];
global::DripSharp.Testing.JavaAssertions.Equal(6, ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead))).Read(bytesRead), null);
global::DripSharp.Testing.JavaAssertions.Equal("012345", global::DripSharp.Runtime.JavaCompat.NewString(bytesRead, global::System.Text.Encoding.UTF8), null);
}
}

internal virtual void TestEOF() {
string input1 = "01234567890123456789";
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessReadBuffer1 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.StringGetBytes(input1, global::System.Text.Encoding.UTF8));
string input2 = "abcdefghijklmnopqrst";
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessReadBuffer2 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.StringGetBytes(input2, global::System.Text.Encoding.UTF8));
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.IO.RandomAccessRead> inputList = global::DripSharp.Runtime.JavaCompat.AsList<global::DripSharp.PdfCarton.IO.RandomAccessRead>(randomAccessReadBuffer1, randomAccessReadBuffer2);
global::DripSharp.PdfCarton.IO.SequenceRandomAccessRead sequenceRandomAccessRead = new global::DripSharp.PdfCarton.IO.SequenceRandomAccessRead(inputList);
int overallLength = (input1.Length + input2.Length);
sequenceRandomAccessRead.Seek((long)((overallLength - 1)));
global::DripSharp.Testing.JavaAssertions.False(sequenceRandomAccessRead.IsEOF(), null);
global::DripSharp.Testing.JavaAssertions.Equal((int)('t'), ((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead)).Peek(), null);
global::DripSharp.Testing.JavaAssertions.False(sequenceRandomAccessRead.IsEOF(), null);
global::DripSharp.Testing.JavaAssertions.Equal((int)('t'), sequenceRandomAccessRead.Read(), null);
global::DripSharp.Testing.JavaAssertions.True(sequenceRandomAccessRead.IsEOF(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-1, sequenceRandomAccessRead.Read(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-1, sequenceRandomAccessRead.Read(new sbyte[1], 0, 1), null);
((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead)).Rewind(5);
global::DripSharp.Testing.JavaAssertions.False(sequenceRandomAccessRead.IsEOF(), null);
sbyte[] bytesRead = new sbyte[5];
global::DripSharp.Testing.JavaAssertions.Equal(5, ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead))).Read(bytesRead), null);
global::DripSharp.Testing.JavaAssertions.Equal("pqrst", global::DripSharp.Runtime.JavaCompat.NewString(bytesRead, global::System.Text.Encoding.UTF8), null);
global::DripSharp.Testing.JavaAssertions.True(sequenceRandomAccessRead.IsEOF(), null);
sequenceRandomAccessRead.Seek((long)((overallLength + 10)));
global::DripSharp.Testing.JavaAssertions.True(sequenceRandomAccessRead.IsEOF(), null);
global::DripSharp.Testing.JavaAssertions.Equal((long)(overallLength), sequenceRandomAccessRead.GetPosition(), null);
global::DripSharp.Testing.JavaAssertions.False(sequenceRandomAccessRead.IsClosed(), null);
sequenceRandomAccessRead.Dispose();
global::DripSharp.Testing.JavaAssertions.True(sequenceRandomAccessRead.IsClosed(), null);
sequenceRandomAccessRead.Dispose();
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => { sequenceRandomAccessRead.Read(); }, global::DripSharp.PdfCarton.Tests.Support.TestPath("io", "checkClosed should have thrown an IOException"));
}

internal virtual void TestEmptyStream() {
string input1 = "01234567890123456789";
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessReadBuffer1 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.StringGetBytes(input1, global::System.Text.Encoding.UTF8));
string input2 = "abcdefghijklmnopqrst";
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer randomAccessReadBuffer2 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.StringGetBytes(input2, global::System.Text.Encoding.UTF8));
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer emptyBuffer = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(global::DripSharp.Runtime.JavaCompat.StringGetBytes("", global::System.Text.Encoding.UTF8));
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.IO.RandomAccessRead> inputList = global::DripSharp.Runtime.JavaCompat.AsList<global::DripSharp.PdfCarton.IO.RandomAccessRead>(randomAccessReadBuffer1, emptyBuffer, randomAccessReadBuffer2);
using (global::DripSharp.PdfCarton.IO.SequenceRandomAccessRead sequenceRandomAccessRead = new global::DripSharp.PdfCarton.IO.SequenceRandomAccessRead(inputList)) {
global::DripSharp.Testing.JavaAssertions.Equal(sequenceRandomAccessRead.Length(), (long)((input1.Length + input2.Length)), null);
sbyte[] bytesRead = new sbyte[10];
sequenceRandomAccessRead.Seek((long)(15));
global::DripSharp.Testing.JavaAssertions.Equal(10, ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead))).Read(bytesRead), null);
global::DripSharp.Testing.JavaAssertions.Equal("56789abcde", global::DripSharp.Runtime.JavaCompat.NewString(bytesRead, global::System.Text.Encoding.UTF8), null);
((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead)).Rewind(15);
bytesRead = new sbyte[5];
global::DripSharp.Testing.JavaAssertions.Equal(5, ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead))).Read(bytesRead), null);
global::DripSharp.Testing.JavaAssertions.Equal("01234", global::DripSharp.Runtime.JavaCompat.NewString(bytesRead, global::System.Text.Encoding.UTF8), null);
bytesRead = new sbyte[5];
sequenceRandomAccessRead.Seek((long)(38));
global::DripSharp.Testing.JavaAssertions.Equal(2, ((global::DripSharp.PdfCarton.IO.RandomAccessRead)((global::DripSharp.PdfCarton.IO.RandomAccessRead)(sequenceRandomAccessRead))).Read(bytesRead), null);
global::DripSharp.Testing.JavaAssertions.Equal("st", global::DripSharp.Runtime.JavaCompat.NewString(bytesRead, 0, 2, global::System.Text.Encoding.UTF8), null);
sequenceRandomAccessRead.Seek((long)(40));
global::DripSharp.Testing.JavaAssertions.True(sequenceRandomAccessRead.IsEOF(), null);
}
}

internal virtual void testPDFBox5981() {
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer r1 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(new sbyte[2448]);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer r2 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(new sbyte[2412]);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer r3 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(new sbyte[2417]);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer r4 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(new sbyte[2433]);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer r5 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(new sbyte[2432]);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer r6 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(new sbyte[2416]);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer r7 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(new sbyte[2417]);
global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer r8 = new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(new sbyte[2266]);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.IO.RandomAccessRead> list = new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.IO.RandomAccessRead>();
global::DripSharp.Runtime.JavaCompat.Add(list, r1);
global::DripSharp.Runtime.JavaCompat.Add(list, r2);
global::DripSharp.Runtime.JavaCompat.Add(list, r3);
global::DripSharp.Runtime.JavaCompat.Add(list, r4);
global::DripSharp.Runtime.JavaCompat.Add(list, r5);
global::DripSharp.Runtime.JavaCompat.Add(list, r6);
global::DripSharp.Runtime.JavaCompat.Add(list, r7);
global::DripSharp.Runtime.JavaCompat.Add(list, r8);
using (global::DripSharp.PdfCarton.IO.SequenceRandomAccessRead srar = new global::DripSharp.PdfCarton.IO.SequenceRandomAccessRead(list)) using (global::DripSharp.PdfCarton.IO.RandomAccessInputStream rais = new global::DripSharp.PdfCarton.IO.RandomAccessInputStream(srar)) {
int rc = rais.Read(new sbyte[0], 0, 0);
global::DripSharp.Testing.JavaAssertions.Equal(0, rc, null);
sbyte[] result = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(rais);
global::DripSharp.Testing.JavaAssertions.Equal(19241, result.Length, null);
global::DripSharp.Testing.JavaAssertions.Equal(srar.Length(), (long)(result.Length), null);
}
}

[Xunit.Fact]
public void __Upstream_1213410917_9d7703f2632a7514()
{
        try
        {
            this.TestBorderCases();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0779702239_ceb9ff07b59b9a98()
{
        try
        {
            this.TestCreateAndRead();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2389655274_d5c528f64993e42a()
{
        try
        {
            this.TestEOF();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1674100507_3683de722d46a458()
{
        try
        {
            this.TestEmptyStream();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1783382061_4d8087f66491d537()
{
        try
        {
            this.TestSeekPeekAndRewind();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1724612040_12b239978312ff80()
{
        try
        {
            this.testPDFBox5981();
        }
        finally
        {
        }
}
}
