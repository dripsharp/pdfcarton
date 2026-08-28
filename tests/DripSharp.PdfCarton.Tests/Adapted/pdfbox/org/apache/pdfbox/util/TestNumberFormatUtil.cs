// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Util;

public class TestNumberFormatUtil {
  private readonly sbyte[] buffer = new sbyte[64];

  internal virtual void testFormatOfIntegerValues() {
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast((float)(51), 5,
      this.buffer), null);
    global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)('5')),
        unchecked((sbyte)('1')) },
      global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(this.buffer, 0, 2), null);
    global::DripSharp.Testing.JavaAssertions.Equal(3,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast((float)(-51), 5,
      this.buffer), null);
    global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)('-')),
        unchecked((sbyte)('5')), unchecked((sbyte)('1')) },
      global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(this.buffer, 0, 3), null);
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast((float)(0), 5, this.buffer),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)('0')) },
      global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(this.buffer, 0, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(19,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast((float)(long.MaxValue), 5,
      this.buffer), null);
    global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)('9')),
        unchecked((sbyte)('2')), unchecked((sbyte)('2')), unchecked((sbyte)('3')),
        unchecked((sbyte)('3')), unchecked((sbyte)('7')), unchecked((sbyte)('2')),
        unchecked((sbyte)('0')), unchecked((sbyte)('3')), unchecked((sbyte)('6')),
        unchecked((sbyte)('8')), unchecked((sbyte)('5')), unchecked((sbyte)('4')),
        unchecked((sbyte)('7')), unchecked((sbyte)('7')), unchecked((sbyte)('5')),
        unchecked((sbyte)('8')), unchecked((sbyte)('0')), unchecked((sbyte)('7')) },
      global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(this.buffer, 0, 19), null);
    global::DripSharp.Testing.JavaAssertions.Equal(10,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast((float)(int.MaxValue), 5,
      this.buffer), null);
    global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)('2')),
        unchecked((sbyte)('1')), unchecked((sbyte)('4')), unchecked((sbyte)('7')),
        unchecked((sbyte)('4')), unchecked((sbyte)('8')), unchecked((sbyte)('3')),
        unchecked((sbyte)('6')), unchecked((sbyte)('4')), unchecked((sbyte)('8')) },
      global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(this.buffer, 0, 10), null);
    global::DripSharp.Testing.JavaAssertions.Equal(11,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast((float)(int.MinValue), 5,
      this.buffer), null);
    global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)('-')),
        unchecked((sbyte)('2')), unchecked((sbyte)('1')), unchecked((sbyte)('4')),
        unchecked((sbyte)('7')), unchecked((sbyte)('4')), unchecked((sbyte)('8')),
        unchecked((sbyte)('3')), unchecked((sbyte)('6')), unchecked((sbyte)('4')),
        unchecked((sbyte)('8')) },
      global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(this.buffer, 0, 11), null);
  }

  internal virtual void testFormatOfRealValues() {
    global::DripSharp.Testing.JavaAssertions.Equal(3,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast(0.7F, 5, this.buffer),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)('0')),
        unchecked((sbyte)('.')), unchecked((sbyte)('7')) },
      global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(this.buffer, 0, 3), null);
    global::DripSharp.Testing.JavaAssertions.Equal(4,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast(-0.7F, 5, this.buffer),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)('-')),
        unchecked((sbyte)('0')), unchecked((sbyte)('.')), unchecked((sbyte)('7')) },
      global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(this.buffer, 0, 4), null);
    global::DripSharp.Testing.JavaAssertions.Equal(5,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast(0.003F, 5, this.buffer),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)('0')),
        unchecked((sbyte)('.')), unchecked((sbyte)('0')), unchecked((sbyte)('0')),
        unchecked((sbyte)('3')) },
      global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(this.buffer, 0, 5), null);
    global::DripSharp.Testing.JavaAssertions.Equal(6,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast(-0.003F, 5, this.buffer),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)('-')),
        unchecked((sbyte)('0')), unchecked((sbyte)('.')), unchecked((sbyte)('0')),
        unchecked((sbyte)('0')), unchecked((sbyte)('3')) },
      global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(this.buffer, 0, 6), null);
  }

  internal virtual void testFormatOfRealValuesReturnsMinusOneIfItCannotBeFormatted() {
    global::DripSharp.Testing.JavaAssertions.Equal(-1,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast(float.NaN, 5, this.buffer),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "NaN should not be formattable"));
    global::DripSharp.Testing.JavaAssertions.Equal(-1,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast(float.PositiveInfinity, 5,
      this.buffer), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "+Infinity should not be formattable"));
    global::DripSharp.Testing.JavaAssertions.Equal(-1,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast(float.NegativeInfinity, 5,
      this.buffer), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-Infinity should not be formattable"));
    global::DripSharp.Testing.JavaAssertions.Equal(-1,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast(((float)(long.MaxValue)
      + 1.0E12F), 5, this.buffer), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Too big number should not be formattable"));
    global::DripSharp.Testing.JavaAssertions.Equal(-1,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast((float)(long.MinValue), 5,
      this.buffer), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Too big negative number should not be formattable"));
  }

  internal virtual void testRoundingUp() {
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast(0.999999F, 5, this.buffer),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)('1')) },
      global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(this.buffer, 0, 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(4,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast(0.125F, 2, this.buffer),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)('0')),
        unchecked((sbyte)('.')), unchecked((sbyte)('1')), unchecked((sbyte)('3')) },
      global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(this.buffer, 0, 4), null);
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast(-0.999999F, 5, this.buffer),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)('-')),
        unchecked((sbyte)('1')) },
      global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(this.buffer, 0, 2), null);
  }

  internal virtual void testRoundingDown() {
    global::DripSharp.Testing.JavaAssertions.Equal(4,
      global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast(0.994F, 2, this.buffer),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(new sbyte[] { unchecked((sbyte)('0')),
        unchecked((sbyte)('.')), unchecked((sbyte)('9')), unchecked((sbyte)('9')) },
      global::DripSharp.Runtime.JavaCompat.CopyOfRange<sbyte>(this.buffer, 0, 4), null);
  }

  internal virtual void testFormattingInRange() {
    global::DripSharp.Runtime.JavaCompat.JavaBigDecimal minVal
      = global::DripSharp.Runtime.JavaCompat.JavaBigDecimalParse(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-10"));
    global::DripSharp.Runtime.JavaCompat.JavaBigDecimal maxVal
      = global::DripSharp.Runtime.JavaCompat.JavaBigDecimalParse(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "10"));
    global::DripSharp.Runtime.JavaCompat.JavaBigDecimal maxDelta
      = global::DripSharp.Runtime.JavaCompat.JavaBigDecimalZero();
    global::System.Text.RegularExpressions.Regex pattern
      = global::DripSharp.Runtime.JavaCompat.CompileRegex(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "^\\-?\\d+(\\.\\d+)?$"));
    sbyte[] formatBuffer = new sbyte[32];
    for (int maxFractionDigits = 0; (maxFractionDigits <= 5); maxFractionDigits++) {
      global::DripSharp.Runtime.JavaCompat.JavaBigDecimal increment
        = global::DripSharp.Runtime.JavaCompat.JavaBigDecimalPow(global::DripSharp.Runtime.JavaCompat.JavaBigDecimalValueOf(10),
        -maxFractionDigits);
      for (global::DripSharp.Runtime.JavaCompat.JavaBigDecimal value = minVal;
        (global::DripSharp.Runtime.JavaCompat.JavaBigDecimalCompare(value, maxVal) < 0); value
        = global::DripSharp.Runtime.JavaCompat.JavaBigDecimalAdd(value, increment)) {
        int byteCount
          = global::DripSharp.PdfCarton.Util.NumberFormatUtil.FormatFloatFast(global::DripSharp.Runtime.JavaCompat.JavaBigDecimalFloatValue(value),
          maxFractionDigits, formatBuffer);
        global::DripSharp.Testing.JavaAssertions.NotEqual(-1, byteCount, null);
        string newStringResult = global::DripSharp.Runtime.JavaCompat.NewString(formatBuffer, 0,
          byteCount, global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
        global::DripSharp.Runtime.JavaCompat.JavaBigDecimal formattedDecimal
          = global::DripSharp.Runtime.JavaCompat.JavaBigDecimalParse(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          newStringResult));
        global::DripSharp.Runtime.JavaCompat.JavaBigDecimal expectedDecimal
          = global::DripSharp.Runtime.JavaCompat.JavaBigDecimalFromDouble((double)(global::DripSharp.Runtime.JavaCompat.JavaBigDecimalFloatValue(value)));
        expectedDecimal
          = global::DripSharp.Runtime.JavaCompat.JavaBigDecimalSetScale(expectedDecimal,
          maxFractionDigits, global::DripSharp.Runtime.JavaRoundingMode.HalfUp);
        global::DripSharp.Runtime.JavaCompat.JavaBigDecimal diff
          = global::DripSharp.Runtime.JavaCompat.JavaBigDecimalAbs(global::DripSharp.Runtime.JavaCompat.JavaBigDecimalSubtract(formattedDecimal,
          expectedDecimal));
        global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.RegexMatcher(pattern,
          newStringResult).Matches(), null);
        if ((global::DripSharp.Runtime.JavaCompat.JavaBigDecimalCompare(diff, maxDelta) > 0)) {
          global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
        }
      }
    }
  }

  [Xunit.Fact]
  public void __Upstream_3093506304_120fd52411c0f850() {
    try {
      this.testFormatOfIntegerValues();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2053263200_2938ed684c0496b1() {
    try {
      this.testFormatOfRealValues();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3160067893_14fdd4f848ef3c70() {
    try {
      this.testFormatOfRealValuesReturnsMinusOneIfItCannotBeFormatted();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4137030017_d0239b95ce1d9647() {
    try {
      this.testFormattingInRange();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0479711240_17a36766aaa96515() {
    try {
      this.testRoundingDown();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1296587649_11d8f0cc95022676() {
    try {
      this.testRoundingUp();
    } finally {
    }
  }
}
