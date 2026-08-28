// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdfparser;

public class PDFObjectStreamParserTest {
  internal virtual void testOffsetParsing() {
    global::DripSharp.PdfCarton.Cos.COSStream stream
      = new global::DripSharp.PdfCarton.Cos.COSStream();
    stream.SetItem(global::DripSharp.PdfCarton.Cos.COSName.N,
      global::DripSharp.PdfCarton.Cos.COSInteger.Two);
    stream.SetItem(global::DripSharp.PdfCarton.Cos.COSName.First,
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(8)));
    global::System.IO.Stream outputStream = stream.CreateOutputStream();
    global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(outputStream,
      global::DripSharp.Runtime.JavaCompat.StringGetBytes("4 0 6 5 true false",
      global::System.Text.Encoding.UTF8));
    outputStream.Dispose();
    global::DripSharp.PdfCarton.Pdfparser.PDFObjectStreamParser objectStreamParser
      = new global::DripSharp.PdfCarton.Pdfparser.PDFObjectStreamParser(stream,
      (global::DripSharp.PdfCarton.Cos.COSDocument)default!);
    global::System.Collections.Generic.IDictionary<long, int> objectNumbers
      = objectStreamParser.ReadObjectNumbers();
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.MapCount(objectNumbers), null);
    global::DripSharp.Testing.JavaAssertions.Equal(0,
      global::DripSharp.Runtime.JavaCompat.MapGetNullable(objectNumbers, 4L), null);
    global::DripSharp.Testing.JavaAssertions.Equal(5,
      global::DripSharp.Runtime.JavaCompat.MapGetNullable(objectNumbers, 6L), null);
    objectStreamParser = new global::DripSharp.PdfCarton.Pdfparser.PDFObjectStreamParser(stream,
      (global::DripSharp.PdfCarton.Cos.COSDocument)default!);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSBoolean.True,
      objectStreamParser.ParseObject((long)(4)), null);
    objectStreamParser = new global::DripSharp.PdfCarton.Pdfparser.PDFObjectStreamParser(stream,
      (global::DripSharp.PdfCarton.Cos.COSDocument)default!);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSBoolean.False,
      objectStreamParser.ParseObject((long)(6)), null);
  }

  internal virtual void testParseAllObjects() {
    global::DripSharp.PdfCarton.Cos.COSStream stream
      = new global::DripSharp.PdfCarton.Cos.COSStream();
    stream.SetItem(global::DripSharp.PdfCarton.Cos.COSName.N,
      global::DripSharp.PdfCarton.Cos.COSInteger.Two);
    stream.SetItem(global::DripSharp.PdfCarton.Cos.COSName.First,
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(8)));
    global::System.IO.Stream outputStream = stream.CreateOutputStream();
    global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(outputStream,
      global::DripSharp.Runtime.JavaCompat.StringGetBytes("6 0 4 5 true false",
      global::System.Text.Encoding.UTF8));
    outputStream.Dispose();
    global::DripSharp.PdfCarton.Pdfparser.PDFObjectStreamParser objectStreamParser
      = new global::DripSharp.PdfCarton.Pdfparser.PDFObjectStreamParser(stream,
      (global::DripSharp.PdfCarton.Cos.COSDocument)default!);
    global::System.Collections.Generic.IDictionary<global::DripSharp.PdfCarton.Cos.COSObjectKey,
      global::DripSharp.PdfCarton.Cos.COSBase> objectNumbers = objectStreamParser.ParseAllObjects();
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.MapCount(objectNumbers), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSBoolean.True,
      global::DripSharp.Runtime.JavaCompat.MapGet(objectNumbers,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(6), 0)), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSBoolean.False,
      global::DripSharp.Runtime.JavaCompat.MapGet(objectNumbers,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(4), 0)), null);
  }

  internal virtual void testParseAllObjectsIndexed() {
    global::DripSharp.PdfCarton.Cos.COSStream stream
      = new global::DripSharp.PdfCarton.Cos.COSStream();
    stream.SetItem(global::DripSharp.PdfCarton.Cos.COSName.N,
      global::DripSharp.PdfCarton.Cos.COSInteger.Three);
    stream.SetItem(global::DripSharp.PdfCarton.Cos.COSName.First,
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(13)));
    global::System.IO.Stream outputStream = stream.CreateOutputStream();
    global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(outputStream,
      global::DripSharp.Runtime.JavaCompat.StringGetBytes("6 0 4 5 4 11 true false true",
      global::System.Text.Encoding.UTF8));
    outputStream.Dispose();
    global::DripSharp.PdfCarton.Cos.COSDocument cosDoc
      = new global::DripSharp.PdfCarton.Cos.COSDocument();
    global::System.Collections.Generic.IDictionary<global::DripSharp.PdfCarton.Cos.COSObjectKey,
      long> xrefTable = cosDoc.GetXrefTable();
    global::DripSharp.Runtime.JavaCompat.MapPut(xrefTable,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(6), 0, 0), -1L);
    global::DripSharp.Runtime.JavaCompat.MapPut(xrefTable,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(4), 0, 2), -1L);
    global::DripSharp.PdfCarton.Pdfparser.PDFObjectStreamParser objectStreamParser
      = new global::DripSharp.PdfCarton.Pdfparser.PDFObjectStreamParser(stream, cosDoc);
    global::System.Collections.Generic.IDictionary<global::DripSharp.PdfCarton.Cos.COSObjectKey,
      global::DripSharp.PdfCarton.Cos.COSBase> objectNumbers = objectStreamParser.ParseAllObjects();
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.MapCount(objectNumbers), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSBoolean.True,
      global::DripSharp.Runtime.JavaCompat.MapGet(objectNumbers,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(6), 0)), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSBoolean.True,
      global::DripSharp.Runtime.JavaCompat.MapGet(objectNumbers,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(4), 0)), null);
    global::DripSharp.Runtime.JavaCompat.MapRemove(xrefTable,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(4), 0));
    global::DripSharp.Runtime.JavaCompat.MapPut(xrefTable,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(4), 0, 1), -1L);
    objectStreamParser = new global::DripSharp.PdfCarton.Pdfparser.PDFObjectStreamParser(stream,
      cosDoc);
    objectNumbers = objectStreamParser.ParseAllObjects();
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.MapCount(objectNumbers), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSBoolean.True,
      global::DripSharp.Runtime.JavaCompat.MapGet(objectNumbers,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(6), 0)), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSBoolean.False,
      global::DripSharp.Runtime.JavaCompat.MapGet(objectNumbers,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(4), 0)), null);
  }

  internal virtual void testParseAllObjectsSkipMalformedIndex() {
    global::DripSharp.PdfCarton.Cos.COSStream stream
      = new global::DripSharp.PdfCarton.Cos.COSStream();
    stream.SetItem(global::DripSharp.PdfCarton.Cos.COSName.N,
      global::DripSharp.PdfCarton.Cos.COSInteger.Three);
    stream.SetItem(global::DripSharp.PdfCarton.Cos.COSName.First,
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(13)));
    global::System.IO.Stream outputStream = stream.CreateOutputStream();
    global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(outputStream,
      global::DripSharp.Runtime.JavaCompat.StringGetBytes("6 0 4 5 5 11 true false true",
      global::System.Text.Encoding.UTF8));
    outputStream.Dispose();
    global::DripSharp.PdfCarton.Cos.COSDocument cosDoc
      = new global::DripSharp.PdfCarton.Cos.COSDocument();
    global::System.Collections.Generic.IDictionary<global::DripSharp.PdfCarton.Cos.COSObjectKey,
      long> xrefTable = cosDoc.GetXrefTable();
    global::DripSharp.Runtime.JavaCompat.MapPut(xrefTable,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(6), 0, 10), -1L);
    global::DripSharp.Runtime.JavaCompat.MapPut(xrefTable,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(4), 0, 11), -1L);
    global::DripSharp.Runtime.JavaCompat.MapPut(xrefTable,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(5), 0, 12), -1L);
    global::DripSharp.PdfCarton.Pdfparser.PDFObjectStreamParser objectStreamParser
      = new global::DripSharp.PdfCarton.Pdfparser.PDFObjectStreamParser(stream, cosDoc);
    global::System.Collections.Generic.IDictionary<global::DripSharp.PdfCarton.Cos.COSObjectKey,
      global::DripSharp.PdfCarton.Cos.COSBase> objectNumbers = objectStreamParser.ParseAllObjects();
    global::DripSharp.Testing.JavaAssertions.Equal(3,
      global::DripSharp.Runtime.JavaCompat.MapCount(objectNumbers), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSBoolean.True,
      global::DripSharp.Runtime.JavaCompat.MapGet(objectNumbers,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(6), 0)), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSBoolean.False,
      global::DripSharp.Runtime.JavaCompat.MapGet(objectNumbers,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(4), 0)), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSBoolean.True,
      global::DripSharp.Runtime.JavaCompat.MapGet(objectNumbers,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(5), 0)), null);
  }

  internal virtual void testParseAllObjectsUseMalformedIndex() {
    global::DripSharp.PdfCarton.Cos.COSStream stream
      = new global::DripSharp.PdfCarton.Cos.COSStream();
    stream.SetItem(global::DripSharp.PdfCarton.Cos.COSName.N,
      global::DripSharp.PdfCarton.Cos.COSInteger.Three);
    stream.SetItem(global::DripSharp.PdfCarton.Cos.COSName.First,
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(13)));
    global::System.IO.Stream outputStream = stream.CreateOutputStream();
    global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(outputStream,
      global::DripSharp.Runtime.JavaCompat.StringGetBytes("6 0 4 5 4 11 true false true",
      global::System.Text.Encoding.UTF8));
    outputStream.Dispose();
    global::DripSharp.PdfCarton.Cos.COSDocument cosDoc
      = new global::DripSharp.PdfCarton.Cos.COSDocument();
    global::System.Collections.Generic.IDictionary<global::DripSharp.PdfCarton.Cos.COSObjectKey,
      long> xrefTable = cosDoc.GetXrefTable();
    global::DripSharp.Runtime.JavaCompat.MapPut(xrefTable,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(6), 0, 10), -1L);
    global::DripSharp.Runtime.JavaCompat.MapPut(xrefTable,
      new global::DripSharp.PdfCarton.Cos.COSObjectKey((long)(4), 0, 11), -1L);
    global::DripSharp.PdfCarton.Pdfparser.PDFObjectStreamParser objectStreamParser
      = new global::DripSharp.PdfCarton.Pdfparser.PDFObjectStreamParser(stream, cosDoc);
    global::System.Collections.Generic.IDictionary<global::DripSharp.PdfCarton.Cos.COSObjectKey,
      global::DripSharp.PdfCarton.Cos.COSBase> objectNumbers = objectStreamParser.ParseAllObjects();
    global::DripSharp.Testing.JavaAssertions.Equal(0,
      global::DripSharp.Runtime.JavaCompat.MapCount(objectNumbers), null);
  }

  [Xunit.Fact]
  public void __Upstream_1105606443_e1718c912fc40614() {
    try {
      this.testOffsetParsing();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0720694356_e8d39f784cd37cc8() {
    try {
      this.testParseAllObjects();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3705220605_48ee082b4dc1552f() {
    try {
      this.testParseAllObjectsIndexed();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1198029994_1d142fb99c9594b6() {
    try {
      this.testParseAllObjectsSkipMalformedIndex();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3299670346_2210f9d7d371e2fa() {
    try {
      this.testParseAllObjectsUseMalformedIndex();
    } finally {
    }
  }
}
