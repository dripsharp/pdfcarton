// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Encoding;

public class EncodingTest {
  internal virtual void testStandardEncoding() {
    global::DripSharp.PdfCarton.Fonts.Encoding.StandardEncoding standardEncoding
      = global::DripSharp.PdfCarton.Fonts.Encoding.StandardEncoding.Instance;
    global::DripSharp.Testing.JavaAssertions.Equal(".notdef", standardEncoding.GetName(0), null);
    global::DripSharp.Testing.JavaAssertions.Equal("space", standardEncoding.GetName(32), null);
    global::DripSharp.Testing.JavaAssertions.Equal("p", standardEncoding.GetName(112), null);
    global::DripSharp.Testing.JavaAssertions.Equal("guilsinglleft", standardEncoding.GetName(172),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(32,
      standardEncoding.GetCode(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "space")), null);
    global::DripSharp.Testing.JavaAssertions.Equal(112,
      standardEncoding.GetCode(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "p")),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(172,
      standardEncoding.GetCode(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "guilsinglleft")), null);
  }

  internal virtual void testMacRomanEncoding() {
    global::DripSharp.PdfCarton.Fonts.Encoding.MacRomanEncoding macRomanEncoding
      = global::DripSharp.PdfCarton.Fonts.Encoding.MacRomanEncoding.Instance;
    global::DripSharp.Testing.JavaAssertions.Equal(".notdef", macRomanEncoding.GetName(0), null);
    global::DripSharp.Testing.JavaAssertions.Equal("space", macRomanEncoding.GetName(32), null);
    global::DripSharp.Testing.JavaAssertions.Equal("p", macRomanEncoding.GetName(112), null);
    global::DripSharp.Testing.JavaAssertions.Equal("germandbls", macRomanEncoding.GetName(167),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(32,
      macRomanEncoding.GetCode(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "space")), null);
    global::DripSharp.Testing.JavaAssertions.Equal(112,
      macRomanEncoding.GetCode(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "p")),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(167,
      macRomanEncoding.GetCode(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "germandbls")), null);
  }

  [Xunit.Fact]
  public void __Upstream_2185944595_15f4d53b894a627a() {
    try {
      this.testMacRomanEncoding();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3899770850_e393255b91d51825() {
    try {
      this.testStandardEncoding();
    } finally {
    }
  }
}
