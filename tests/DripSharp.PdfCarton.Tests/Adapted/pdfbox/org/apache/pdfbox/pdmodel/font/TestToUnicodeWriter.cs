// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Font;

public class TestToUnicodeWriter {
  internal virtual void testCMapLigatures() {
    global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter toUnicodeWriter
      = new global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter();
    toUnicodeWriter.Add(1024, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "a"));
    toUnicodeWriter.Add(1025, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "b"));
    toUnicodeWriter.Add(1026, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ff"));
    toUnicodeWriter.Add(1027, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "fi"));
    toUnicodeWriter.Add(1028, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ffl"));
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    toUnicodeWriter.WriteTo(baos);
    string output = global::DripSharp.Runtime.JavaCompat.MemoryStreamToString(baos,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ISO-8859-1"));
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(output,
      "4 beginbfrange"), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(output,
      "<0402> <0402> <00660066>"), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(output,
      "<0403> <0403> <00660069>"), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(output,
      "<0404> <0404> <00660066006C>"), null);
  }

  internal virtual void testCMapCIDOverflow() {
    global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter toUnicodeWriter
      = new global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter();
    toUnicodeWriter.Add(1023, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "6"));
    toUnicodeWriter.Add(1024, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "7"));
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    toUnicodeWriter.WriteTo(baos);
    string output = global::DripSharp.Runtime.JavaCompat.MemoryStreamToString(baos,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ISO-8859-1"));
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(output,
      "2 beginbfrange"), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(output,
      "<03FF> <03FF> <0036>"), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(output,
      "<0400> <0400> <0037>"), null);
  }

  internal virtual void testCMapStringOverflow() {
    global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter toUnicodeWriter
      = new global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter();
    global::System.Text.StringBuilder string1 = new global::System.Text.StringBuilder();
    global::DripSharp.Runtime.JavaCompat.AppendCodePoint(string1, 1279);
    global::System.Text.StringBuilder string2 = new global::System.Text.StringBuilder();
    global::DripSharp.Runtime.JavaCompat.AppendCodePoint(string2, 1280);
    toUnicodeWriter.Add(1023, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      string1.ToString()));
    toUnicodeWriter.Add(1024, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      string2.ToString()));
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    toUnicodeWriter.WriteTo(baos);
    string output = global::DripSharp.Runtime.JavaCompat.MemoryStreamToString(baos,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ISO-8859-1"));
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(output,
      "2 beginbfrange"), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(output,
      "<03FF> <03FF> <04FF>"), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(output,
      "<0400> <0400> <0500>"), null);
  }

  internal virtual void testCMapSurrogates() {
    global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter toUnicodeWriter
      = new global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter();
    toUnicodeWriter.Add(768, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.NewString(new int[] { 194676 }, 0, 1)));
    toUnicodeWriter.Add(769, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.NewString(new int[] { 194678 }, 0, 1)));
    toUnicodeWriter.Add(772, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.NewString(new int[] { 194692 }, 0, 1)));
    toUnicodeWriter.Add(773, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.NewString(new int[] { 194693 }, 0, 1)));
    toUnicodeWriter.Add(774, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.NewString(new int[] { 194694 }, 0, 1)));
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    toUnicodeWriter.WriteTo(baos);
    string output = global::DripSharp.Runtime.JavaCompat.MemoryStreamToString(baos,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ISO-8859-1"));
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(output,
      "3 beginbfrange"), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(output,
      "<0300> <0300> <D87EDC74>"), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(output,
      "<0301> <0301> <D87EDC76>"), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(output,
      "<0304> <0306> <D87EDC84>"), null);
  }

  internal virtual void testAllowCIDToUnicodeRange() {
    global::DripSharp.Runtime.JavaMapEntry<int, string> six
      = new global::DripSharp.Runtime.JavaSimpleEntry<int, string>(1023, "6");
    global::DripSharp.Runtime.JavaMapEntry<int, string> seven
      = new global::DripSharp.Runtime.JavaSimpleEntry<int, string>(1024, "7");
    global::DripSharp.Runtime.JavaMapEntry<int, string> eight
      = new global::DripSharp.Runtime.JavaSimpleEntry<int, string>(1025, "8");
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCIDToUnicodeRange((global::DripSharp.Runtime.JavaMapEntry<int,
      string>)default!, seven), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCIDToUnicodeRange(six,
      (global::DripSharp.Runtime.JavaMapEntry<int, string>)default!), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCIDToUnicodeRange(six,
      seven), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCIDToUnicodeRange(seven,
      eight), null);
  }

  internal virtual void testAllowCodeRange() {
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(15,
      7), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(255,
      0), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(1023,
      768), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(1025,
      1024), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(65535,
      0), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(0,
      0), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(0,
      15), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(0,
      127), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(0,
      255), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(7,
      15), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(127,
      255), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(255,
      255), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(255,
      256), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(511,
      512), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(1023,
      1024), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(2047,
      2048), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(4095,
      4096), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(8191,
      8192), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(16383,
      16384), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(32767,
      32768), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(0,
      1), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(1,
      2), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(3,
      4), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(7,
      8), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(14,
      15), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(31,
      32), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(63,
      64), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(127,
      128), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(254,
      255), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(1022,
      1023), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(1024,
      1025), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowCodeRange(65534,
      65535), null);
  }

  internal virtual void testAllowDestinationRange() {
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      ""), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "")), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "0"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "")), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      ""), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "0")), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "0"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "A")), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "A"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "a")), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "\u00FF"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "\u0100")), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      " "), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "!")), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "("), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ")")), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "0"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "1")), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "a"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "b")), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "A"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "B")), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "\u00C0"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "\u00C1")), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "\u00FE"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "\u00FF")), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "ff"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "fi")), null);
  }

  internal virtual void testAllowDestinationRangeSurrogates() {
    global::System.Text.StringBuilder endOfBMP = new global::System.Text.StringBuilder();
    global::DripSharp.Runtime.JavaCompat.AppendCodePoint(endOfBMP, 65535);
    global::System.Text.StringBuilder beyondBMP = new global::System.Text.StringBuilder();
    global::DripSharp.Runtime.JavaCompat.AppendCodePoint(beyondBMP, 65536);
    global::System.Text.StringBuilder cjk1 = new global::System.Text.StringBuilder();
    global::DripSharp.Runtime.JavaCompat.AppendCodePoint(cjk1, 194692);
    global::System.Text.StringBuilder cjk2 = new global::System.Text.StringBuilder();
    global::DripSharp.Runtime.JavaCompat.AppendCodePoint(cjk2, 194693);
    global::System.Text.StringBuilder cjk3 = new global::System.Text.StringBuilder();
    global::DripSharp.Runtime.JavaCompat.AppendCodePoint(cjk3, 194694);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      endOfBMP.ToString()), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      beyondBMP.ToString())), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      cjk1.ToString()), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      cjk2.ToString())), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      cjk2.ToString()), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      cjk3.ToString())), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Pdmodel.Font.ToUnicodeWriter.allowDestinationRange(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      cjk1.ToString()), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      cjk3.ToString())), null);
  }

  [Xunit.Fact]
  public void __Upstream_1501988290_43e5ecd2b2218c2d() {
    try {
      this.testAllowCIDToUnicodeRange();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4184674105_715f01461a728fd0() {
    try {
      this.testAllowCodeRange();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2574486982_290a917f0a0d7162() {
    try {
      this.testAllowDestinationRange();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1345294081_3832774d42cc47ff() {
    try {
      this.testAllowDestinationRangeSurrogates();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0152021045_a735d958c0e1a1e8() {
    try {
      this.testCMapCIDOverflow();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1569044573_0797b76fcfa04507() {
    try {
      this.testCMapLigatures();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3105237438_15624095a5c72ae1() {
    try {
      this.testCMapStringOverflow();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3842667686_d7f0c6032a689470() {
    try {
      this.testCMapSurrogates();
    } finally {
    }
  }
}
