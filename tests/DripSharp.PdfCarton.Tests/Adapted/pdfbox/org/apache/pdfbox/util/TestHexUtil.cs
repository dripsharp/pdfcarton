// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Util;

public class TestHexUtil {
  internal virtual void testGetCharsFromShortWithoutPassingInABuffer() {
    global::DripSharp.Testing.JavaAssertions.Equal(new char[] { '0', '0', '0', '0' },
      global::DripSharp.PdfCarton.Util.Hex.GetChars(unchecked((short)(0))), null);
    global::DripSharp.Testing.JavaAssertions.Equal(new char[] { '0', '0', '0', 'F' },
      global::DripSharp.PdfCarton.Util.Hex.GetChars(unchecked((short)(15))), null);
    global::DripSharp.Testing.JavaAssertions.Equal(new char[] { 'A', 'B', 'C', 'D' },
      global::DripSharp.PdfCarton.Util.Hex.GetChars(unchecked((short)(43981))), null);
    global::DripSharp.Testing.JavaAssertions.Equal(new char[] { 'B', 'A', 'B', 'E' },
      global::DripSharp.PdfCarton.Util.Hex.GetChars(unchecked((short)(-889275714))), null);
  }

  internal virtual void testGetCharsUTF16BE() {
    global::DripSharp.Testing.JavaAssertions.Equal(new char[] { '0', '0', '6', '1', '0', '0', '6',
      '2' },
      global::DripSharp.PdfCarton.Util.Hex.GetCharsUTF16BE(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "ab")), null);
    global::DripSharp.Testing.JavaAssertions.Equal(new char[] { '5', 'E', '2', 'E', '5', '2', 'A',
      '9' },
      global::DripSharp.PdfCarton.Util.Hex.GetCharsUTF16BE(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "\u5E2E\u52A9")), null);
  }

  internal virtual void testMisc() {
    sbyte[] byteSrcArray = new sbyte[256];
    for (int i = 0; (i < 256); ++i) {
      byteSrcArray[i] = unchecked((sbyte)(unchecked((sbyte)(i))));
      sbyte[] bytes
        = global::DripSharp.PdfCarton.Util.Hex.GetBytes(unchecked((sbyte)(unchecked((sbyte)(i)))));
      global::DripSharp.Testing.JavaAssertions.Equal(2, bytes.Length, null);
      string s2
        = global::DripSharp.Runtime.JavaCompat.JavaStringFormat(global::System.Globalization.CultureInfo.GetCultureInfo("en-US"),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "%02X"), i);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s2,
        global::DripSharp.Runtime.JavaStandardCharsets.USASCII), bytes, null);
      s2
        = global::DripSharp.PdfCarton.Util.Hex.GetString(unchecked((sbyte)(unchecked((sbyte)(i)))));
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s2,
        global::DripSharp.Runtime.JavaStandardCharsets.USASCII), bytes, null);
      global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)(unchecked((sbyte)(i)))) },
        global::DripSharp.PdfCarton.Util.Hex.DecodeHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        s2)), null);
    }
    sbyte[] byteDstArray = global::DripSharp.PdfCarton.Util.Hex.GetBytes(byteSrcArray);
    global::DripSharp.Testing.JavaAssertions.Equal(byteDstArray.Length, (byteSrcArray.Length * 2),
      null);
    string dstString = global::DripSharp.PdfCarton.Util.Hex.GetString(byteSrcArray);
    global::DripSharp.Testing.JavaAssertions.Equal(dstString.Length, (byteSrcArray.Length * 2),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.StringGetBytes(dstString,
      global::DripSharp.Runtime.JavaStandardCharsets.USASCII), byteDstArray, null);
    global::DripSharp.Testing.JavaAssertions.Equal(byteSrcArray,
      global::DripSharp.PdfCarton.Util.Hex.DecodeHex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      dstString)), null);
  }

  internal virtual void testGetHexValue() {
    global::System.Collections.Generic.ISet<char> validHexCharacters
      = new global::System.Collections.Generic.HashSet<char>();
    for (char c__94_19 = '0'; ((int)c__94_19 <= (int)'9'); ++c__94_19) {
      validHexCharacters.Add(c__94_19);
      string s__97_20 = new global::System.Text.StringBuilder().Append(c__94_19).ToString();
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        s__97_20), 16), global::DripSharp.PdfCarton.Util.Hex.GetHexValue(c__94_19), null);
    }
    for (char c__100_19 = 'a'; ((int)c__100_19 <= (int)'f'); ++c__100_19) {
      validHexCharacters.Add(c__100_19);
      string s__103_20 = new global::System.Text.StringBuilder().Append(c__100_19).ToString();
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        s__103_20), 16), global::DripSharp.PdfCarton.Util.Hex.GetHexValue(c__100_19), null);
    }
    for (char c__106_19 = 'A'; ((int)c__106_19 <= (int)'F'); ++c__106_19) {
      validHexCharacters.Add(c__106_19);
      string s__109_20 = new global::System.Text.StringBuilder().Append(c__106_19).ToString();
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        s__109_20), 16), global::DripSharp.PdfCarton.Util.Hex.GetHexValue(c__106_19), null);
    }
    global::DripSharp.Testing.JavaAssertions.Equal(22, validHexCharacters.Count, null);
    for (char c__113_19 = unchecked((char)(0)); ((int)c__113_19 < 256); ++c__113_19) {
      if (!global::DripSharp.Runtime.JavaCompat.CollectionContains(validHexCharacters, c__113_19)) {
        global::DripSharp.Testing.JavaAssertions.Equal(-256,
          global::DripSharp.PdfCarton.Util.Hex.GetHexValue(c__113_19), null);
      }
    }
  }

  [Xunit.Fact]
  public void __Upstream_3270405754_cecfbd19ddb08ce0() {
    try {
      this.testGetCharsFromShortWithoutPassingInABuffer();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2977520694_1ef00148b81dd1dd() {
    try {
      this.testGetCharsUTF16BE();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3096066202_59b437b04523c409() {
    try {
      this.testGetHexValue();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1000490142_152e37b3a3eaeb54() {
    try {
      this.testMisc();
    } finally {
    }
  }
}
