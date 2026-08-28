// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Common.Function;

public class TestPDFunctionType4 {
  private global::DripSharp.PdfCarton.Pdmodel.Common.Function.PDFunctionType4 createFunction(string function,
    float[] domain, float[] range) {
    global::DripSharp.PdfCarton.Cos.COSStream stream
      = new global::DripSharp.PdfCarton.Cos.COSStream();
    stream.SetInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "FunctionType"), 4);
    global::DripSharp.PdfCarton.Cos.COSArray domainArray
      = new global::DripSharp.PdfCarton.Cos.COSArray();
    domainArray.SetFloatArray(domain);
    stream.SetItem(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Domain"),
      domainArray);
    global::DripSharp.PdfCarton.Cos.COSArray rangeArray
      = new global::DripSharp.PdfCarton.Cos.COSArray();
    rangeArray.SetFloatArray(range);
    stream.SetItem(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Range"),
      rangeArray);
    using (global::System.IO.Stream @out = stream.CreateOutputStream()) {
      sbyte[] data = global::DripSharp.Runtime.JavaCompat.StringGetBytes(function,
        global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
      global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(@out, data, 0, data.Length);
    }
    return new global::DripSharp.PdfCarton.Pdmodel.Common.Function.PDFunctionType4(stream);
  }

  internal virtual void testFunctionSimple() {
    string functionText = "{ add }";
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.PDFunctionType4 function
      = this.createFunction(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      functionText), new float[] { -1.0F, 1.0F, -1.0F, 1.0F }, new float[] { -1.0F, 1.0F });
    float[] input = new float[] { 0.8F, 0.1F };
    float[] output = function.Eval(input);
    global::DripSharp.Testing.JavaAssertions.Equal(1, output.Length, null);
    global::DripSharp.Testing.JavaAssertions.Equal(0.9F, output[0], null, 1.0E-4F);
    input = new float[] { 0.8F, 0.3F };
    output = function.Eval(input);
    global::DripSharp.Testing.JavaAssertions.Equal(1, output.Length, null);
    global::DripSharp.Testing.JavaAssertions.Equal(1.0F, output[0], null);
    input = new float[] { 0.8F, 1.2F };
    output = function.Eval(input);
    global::DripSharp.Testing.JavaAssertions.Equal(1, output.Length, null);
    global::DripSharp.Testing.JavaAssertions.Equal(1.0F, output[0], null);
  }

  internal virtual void testFunctionArgumentOrder() {
    string functionText = "{ pop }";
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.PDFunctionType4 function
      = this.createFunction(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      functionText), new float[] { -1.0F, 1.0F, -1.0F, 1.0F }, new float[] { -1.0F, 1.0F });
    float[] input = new float[] { -0.7F, 0.0F };
    float[] output = function.Eval(input);
    global::DripSharp.Testing.JavaAssertions.Equal(1, output.Length, null);
    global::DripSharp.Testing.JavaAssertions.Equal(-0.7F, output[0], null, 1.0E-4F);
  }

  [Xunit.Fact]
  public void __Upstream_0258251815_60aee73481269a1b() {
    try {
      this.testFunctionArgumentOrder();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4075092188_62e1fbd794cb75fd() {
    try {
      this.testFunctionSimple();
    } finally {
    }
  }
}
