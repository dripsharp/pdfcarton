// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Filter;

public class PredictorTest {
  internal virtual void testGetBitSeq() {
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2), 0, 8), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2), 0, 8), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2), 0, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "0"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2), 0, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "001"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00110001"), 2), 0, 3), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "10101010"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "10101010"), 2), 0, 8), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "10"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "10101010"), 2), 0, 2), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "01"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "10101010"), 2), 1, 2), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "10"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "10101010"), 2), 2, 2), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "101"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "10101010"), 2), 3, 3), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1010101"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "10101010"), 2), 1, 7), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "01"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "10101010"), 2), 3, 2), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00110001"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00110001"), 2), 0, 8), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "10001"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00110001"), 2), 0, 5), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "0011"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00110001"), 2), 4, 4), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "110"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00110001"), 2), 3, 3), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00110001"), 2), 6, 2), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1111"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11110000"), 2), 4, 4), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11110000"), 2), 6, 2), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "0000"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.getBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11110000"), 2), 0, 4), null);
  }

  internal virtual void testCalcSetBitSeq() {
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2), 0, 8, 0), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000001"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2), 0, 8, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2), 0, 1, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111101"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2), 0, 2, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111001"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2), 0, 3, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000001"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2), 0, 2, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11110001"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2), 0, 4, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11100011"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2), 1, 4, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000010"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2), 1, 1, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2), 7, 1, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "01111111"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2), 7, 1, 0), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "10000000"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2), 7, 1, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2), 7, 1, 0), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "01000000"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2), 6, 1, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2), 6, 1, 0), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00110000"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2), 3, 3, 6), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "01100000"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2), 4, 3, 6), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11000000"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2), 5, 3, 6), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2), 0, 8, 255), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "11111111"), 2), 0, 8, 255), null);
    global::DripSharp.Testing.JavaAssertions.Equal(126,
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(165, 0, 8, (217 + 165)), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000010"), 2),
      global::DripSharp.PdfCarton.Filter.Predictor.calcSetBitSeq(global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "00000000"), 2), 1, 1, 3), null);
  }

  [Xunit.Fact]
  public void __Upstream_3725116621_d60340aadea37e4b() {
    try {
      this.testCalcSetBitSeq();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3124400790_dcf444089ce708d3() {
    try {
      this.testGetBitSeq();
    } finally {
    }
  }
}
