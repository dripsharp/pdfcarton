// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Cos;

public class COSDictionaryTest {
  internal virtual void testCOSDictionaryNotEqualsCOSStream() {
    global::DripSharp.PdfCarton.Cos.COSDictionary cosDictionary
      = new global::DripSharp.PdfCarton.Cos.COSDictionary();
    global::DripSharp.PdfCarton.Cos.COSStream cosStream
      = new global::DripSharp.PdfCarton.Cos.COSStream();
    cosDictionary.SetItem(global::DripSharp.PdfCarton.Cos.COSName.Be,
      global::DripSharp.PdfCarton.Cos.COSName.Be);
    cosDictionary.SetInt(global::DripSharp.PdfCarton.Cos.COSName.Length, 0);
    cosStream.SetItem(global::DripSharp.PdfCarton.Cos.COSName.Be,
      global::DripSharp.PdfCarton.Cos.COSName.Be);
    global::DripSharp.Testing.JavaAssertions.NotEqual(cosDictionary, cosStream,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "a COSDictionary shall not be equal to a COSStream with the same dictionary entries"));
    global::DripSharp.Testing.JavaAssertions.NotEqual(cosStream, cosDictionary,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "a COSStream shall not be equal to a COSDictionary with the same dictionary entries"));
  }

  [Xunit.Fact]
  public void __Upstream_0648835328_9b31eadbc037a47b() {
    try {
      this.testCOSDictionaryNotEqualsCOSStream();
    } finally {
    }
  }
}
