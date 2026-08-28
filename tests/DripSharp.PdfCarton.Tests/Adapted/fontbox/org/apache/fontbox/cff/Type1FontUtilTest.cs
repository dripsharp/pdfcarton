// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Cff;

public class Type1FontUtilTest {
  internal const long DEFAULTSEED = 12345;

  internal const long LOOPS = 1000;

  internal virtual void testHexEncoding() {
    long seed = global::DripSharp.PdfCarton.Fonts.Cff.Type1FontUtilTest.DEFAULTSEED;
    this.tryHexEncoding(seed);
    for (int i = 0; (i < global::DripSharp.PdfCarton.Fonts.Cff.Type1FontUtilTest.LOOPS); ++i) {
      this.tryHexEncoding(global::System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
    }
  }

  private void tryHexEncoding(long seed) {
    sbyte[] bytes
      = global::DripSharp.PdfCarton.Fonts.Cff.Type1FontUtilTest.createRandomByteArray(128, seed);
    string encodedBytes = global::DripSharp.PdfCarton.Fonts.Cff.Type1FontUtil.HexEncode(bytes);
    sbyte[] decodedBytes
      = global::DripSharp.PdfCarton.Fonts.Cff.Type1FontUtil.HexDecode(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      encodedBytes));
    global::DripSharp.Testing.JavaAssertions.Equal(bytes, decodedBytes,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      global::DripSharp.Runtime.JavaCompat.Concat("Seed: ", seed)));
  }

  internal virtual void testEexecEncryption() {
    long seed = global::DripSharp.PdfCarton.Fonts.Cff.Type1FontUtilTest.DEFAULTSEED;
    this.tryEexecEncryption(seed);
    for (int i = 0; (i < global::DripSharp.PdfCarton.Fonts.Cff.Type1FontUtilTest.LOOPS); ++i) {
      this.tryEexecEncryption(global::System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
    }
  }

  private void tryEexecEncryption(long seed) {
    sbyte[] bytes
      = global::DripSharp.PdfCarton.Fonts.Cff.Type1FontUtilTest.createRandomByteArray(128, seed);
    sbyte[] encryptedBytes
      = global::DripSharp.PdfCarton.Fonts.Cff.Type1FontUtil.EexecEncrypt(bytes);
    sbyte[] decryptedBytes
      = global::DripSharp.PdfCarton.Fonts.Cff.Type1FontUtil.EexecDecrypt(encryptedBytes);
    global::DripSharp.Testing.JavaAssertions.Equal(bytes, decryptedBytes,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      global::DripSharp.Runtime.JavaCompat.Concat("Seed: ", seed)));
  }

  internal virtual void testCharstringEncryption() {
    long seed = global::DripSharp.PdfCarton.Fonts.Cff.Type1FontUtilTest.DEFAULTSEED;
    this.tryCharstringEncryption(seed);
    for (int i = 0; (i < global::DripSharp.PdfCarton.Fonts.Cff.Type1FontUtilTest.LOOPS); ++i) {
      this.tryCharstringEncryption(global::System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds());
    }
  }

  private void tryCharstringEncryption(long seed) {
    sbyte[] bytes
      = global::DripSharp.PdfCarton.Fonts.Cff.Type1FontUtilTest.createRandomByteArray(128, seed);
    sbyte[] encryptedBytes
      = global::DripSharp.PdfCarton.Fonts.Cff.Type1FontUtil.CharstringEncrypt(bytes, 4);
    sbyte[] decryptedBytes
      = global::DripSharp.PdfCarton.Fonts.Cff.Type1FontUtil.CharstringDecrypt(encryptedBytes, 4);
    global::DripSharp.Testing.JavaAssertions.Equal(bytes, decryptedBytes,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      global::DripSharp.Runtime.JavaCompat.Concat("Seed: ", seed)));
  }

  private static sbyte[] createRandomByteArray(int arrayLength, long seed) {
    sbyte[] bytes = new sbyte[arrayLength];
    global::DripSharp.PdfCarton.Tests.JavaRandom ramdom
      = new global::DripSharp.PdfCarton.Tests.JavaRandom(seed);
    for (int i = 0; (i < arrayLength); i++) {
      bytes[i] = unchecked((sbyte)(unchecked((sbyte)(ramdom.NextInt(256)))));
    }
    return bytes;
  }

  [Xunit.Fact]
  public void __Upstream_1956433276_6d46af53181277be() {
    try {
      this.testCharstringEncryption();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2372488103_cee4c784bbf28df4() {
    try {
      this.testEexecEncryption();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0545328540_60fdeb501038b359() {
    try {
      this.testHexEncoding();
    } finally {
    }
  }
}
