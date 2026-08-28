// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Common.Function.Type4;

public class TestParser {
  internal virtual void testParserBasics() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "3 4 add 2 sub")).Pop(5).IsEmpty();
  }

  internal virtual void testNested() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "true { 2 1 add } { 2 1 sub } ifelse")).Pop(3).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "{ true }")).Pop(true).IsEmpty();
  }

  internal virtual void testParseFloat() {
    global::DripSharp.Testing.JavaAssertions.Equal((float)(0),
      global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.InstructionSequenceBuilder.ParseReal(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "0")), null, 1.0E-5F);
    global::DripSharp.Testing.JavaAssertions.Equal((float)(1),
      global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.InstructionSequenceBuilder.ParseReal(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1")), null, 1.0E-5F);
    global::DripSharp.Testing.JavaAssertions.Equal((float)(1),
      global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.InstructionSequenceBuilder.ParseReal(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "+1")), null, 1.0E-5F);
    global::DripSharp.Testing.JavaAssertions.Equal((float)(-1),
      global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.InstructionSequenceBuilder.ParseReal(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-1")), null, 1.0E-5F);
    global::DripSharp.Testing.JavaAssertions.Equal(3.14157D,
      (double)(global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.InstructionSequenceBuilder.ParseReal(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "3.14157"))), null, (double)(1.0E-5F));
    global::DripSharp.Testing.JavaAssertions.Equal(-1.2D,
      (double)(global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.InstructionSequenceBuilder.ParseReal(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-1.2"))), null, (double)(1.0E-5F));
    global::DripSharp.Testing.JavaAssertions.Equal(1.0E-5D,
      (double)(global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.InstructionSequenceBuilder.ParseReal(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1.0E-5"))), null, (double)(1.0E-5F));
  }

  internal virtual void testJira804() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1 {dup dup .72 mul exch 0 exch .38 mul}\n")).Pop(0.38F).Pop(0.0F).Pop(0.72F).Pop(1.0F).IsEmpty();
  }

  [Xunit.Fact]
  public void __Upstream_0160314588_c06002a2505a9ac0() {
    try {
      this.testJira804();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3718274089_b4e73499d8e56060() {
    try {
      this.testNested();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0429515163_db448234b6ae173f() {
    try {
      this.testParseFloat();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3922810038_3b938cf4e8d56ec1() {
    try {
      this.testParserBasics();
    } finally {
    }
  }
}
