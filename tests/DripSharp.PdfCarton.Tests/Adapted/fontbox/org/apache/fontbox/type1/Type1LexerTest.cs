// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Type1;

public class Type1LexerTest {
  internal virtual void testRealNumbers() {
    string s = "/FontMatrix [1e-3 0e-3 0e-3 -1E-03 0 0 1.23 -1.23 ] readonly def";
    global::DripSharp.PdfCarton.Fonts.Type1.Type1Lexer t1l
      = new global::DripSharp.PdfCarton.Fonts.Type1.Type1Lexer(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.USASCII));
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Type1.Token> tokens
      = this.readTokens(t1l);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.LITERAL,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 0).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("FontMatrix",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 0).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.START_ARRAY,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 1).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.REAL,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 2).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.REAL,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 3).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.REAL,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 4).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.REAL,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 5).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.INTEGER,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 6).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.INTEGER,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 7).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.REAL,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 8).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.REAL,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 9).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("1e-3",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 2).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("0e-3",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 3).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("0e-3",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 4).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("-1E-03",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 5).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-0.001F,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 5).FloatValue(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("0",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 6).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("0",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 7).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("1.23",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 8).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("-1.23",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 9).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.END_ARRAY,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 10).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.NAME,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 11).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.NAME,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 12).GetKind(), null);
  }

  internal virtual void testEmptyName() {
    string s = "dup 127 / put";
    global::DripSharp.PdfCarton.Fonts.Type1.Type1Lexer t1l
      = new global::DripSharp.PdfCarton.Fonts.Type1.Type1Lexer(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.USASCII));
    global::DripSharp.PdfCarton.Fonts.Type1.DamagedFontException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Fonts.Type1.DamagedFontException>(()
      => {
        global::DripSharp.PdfCarton.Fonts.Type1.Token nextToken;
        do {
          nextToken = t1l.NextToken();
        } while ((nextToken != default!));
      }, null);
    global::DripSharp.Testing.JavaAssertions.Equal("Could not read token at position 9",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  internal virtual void testProcAndNameAndDictAndString() {
    string s
      = "/ND {noaccess def} executeonly def \n 8#173 +2#110 \n%comment \n<< (string \\n \\r \\t \\b \\f \\\\ \\( \\) \\123) >>";
    global::DripSharp.PdfCarton.Fonts.Type1.Type1Lexer t1l
      = new global::DripSharp.PdfCarton.Fonts.Type1.Type1Lexer(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.USASCII));
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Type1.Token> tokens
      = this.readTokens(t1l);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.LITERAL,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 0).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("ND",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 0).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.START_PROC,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 1).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.NAME,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 2).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("noaccess",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 2).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.NAME,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 3).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("def",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 3).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.END_PROC,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 4).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.NAME,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 5).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("executeonly",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 5).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.NAME,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 6).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("def",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 6).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.INTEGER,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 7).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("123",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 7).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.INTEGER,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 8).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("6",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 8).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.START_DICT,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 9).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.STRING,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 10).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("string \n \n \t \b \f \\ ( ) S",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 10).GetText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.END_DICT,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 11).GetKind(), null);
  }

  internal virtual void TestData() {
    string s = "3 RD 123 ND";
    global::DripSharp.PdfCarton.Fonts.Type1.Type1Lexer t1l
      = new global::DripSharp.PdfCarton.Fonts.Type1.Type1Lexer(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.USASCII));
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Type1.Token> tokens
      = this.readTokens(t1l);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.INTEGER,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 0).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(3,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 0).IntValue(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.CHARSTRING,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 1).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)('1')),
        unchecked((sbyte)('2')), unchecked((sbyte)('3')) },
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 1).GetData(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Type1.Token.NAME,
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 2).GetKind(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("ND",
      global::DripSharp.Runtime.JavaCompat.ListGet(tokens, 2).GetText(), null);
  }

  internal virtual void TestPDFBOX6043() {
    string s = "999 RD";
    global::DripSharp.PdfCarton.Fonts.Type1.Type1Lexer t1l
      = new global::DripSharp.PdfCarton.Fonts.Type1.Type1Lexer(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.USASCII));
    global::System.IO.IOException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(()
      => this.readTokens(t1l), null);
    global::DripSharp.Testing.JavaAssertions.Equal("String length 999 is larger than input",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  private global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Type1.Token> readTokens(global::DripSharp.PdfCarton.Fonts.Type1.Type1Lexer t1l) {
    global::DripSharp.PdfCarton.Fonts.Type1.Token nextToken;
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Type1.Token> tokens
      = new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Fonts.Type1.Token>();
    do {
      nextToken = t1l.NextToken();
      if ((nextToken != default!)) {
        global::DripSharp.Runtime.JavaCompat.Add(tokens, nextToken);
      }
    } while ((nextToken != default!));
    return tokens;
  }

  [Xunit.Fact]
  public void __Upstream_1064858492_965061c2da76f0f8() {
    try {
      this.TestData();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4071921668_69fa00110a4d1362() {
    try {
      this.TestPDFBOX6043();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1397024006_e3994efdfc554dfa() {
    try {
      this.testEmptyName();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1850549781_d8ef9578ec176ff6() {
    try {
      this.testProcAndNameAndDictAndString();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4100625114_fa8ae8afc64fd293() {
    try {
      this.testRealNumbers();
    } finally {
    }
  }
}
