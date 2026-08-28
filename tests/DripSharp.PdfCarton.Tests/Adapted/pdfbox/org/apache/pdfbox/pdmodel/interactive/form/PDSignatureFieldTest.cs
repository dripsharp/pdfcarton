// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class PDSignatureFieldTest {
  private global::DripSharp.PdfCarton.Pdmodel.PDDocument document = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = null!;

  internal virtual void setUp() {
    this.document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
    this.acroForm
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(this.document);
  }

  internal virtual void createDefaultSignatureField() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDSignatureField sigField
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDSignatureField(this.acroForm);
    sigField.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "SignatureField"));
    global::DripSharp.Testing.JavaAssertions.Equal(sigField.GetFieldType(),
      sigField.GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.Ft), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Sig", sigField.GetFieldType(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Annot,
      sigField.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Type), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget.SubType,
      sigField.GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.Subtype),
      null);
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField> fields
      = new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField>();
    global::DripSharp.Runtime.JavaCompat.Add(fields, sigField);
    this.acroForm.SetFields(fields);
    global::DripSharp.Testing.JavaAssertions.NotNull(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "SignatureField")), null);
  }

  internal virtual void setValueForAbstractedSignatureField() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDSignatureField sigField
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDSignatureField(this.acroForm);
    sigField.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "SignatureField"));
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(() => {
        sigField.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "Can't set value using String"));
      }, null);
  }

  internal virtual void testGetContents() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Digitalsignature.PDSignature signature
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Digitalsignature.PDSignature();
    signature.SetByteRange(new int[] { 0, 10, 30, 10 });
    sbyte[] by
      = global::DripSharp.Runtime.JavaCompat.StringGetBytes("AAAAAAAAAA<313233343536373839>BBBBBBBBBB",
      global::DripSharp.Runtime.JavaStandardCharsets.ISO88591);
    global::DripSharp.Testing.JavaAssertions.Equal("123456789",
      global::DripSharp.Runtime.JavaCompat.NewString(signature.GetContents(by),
      global::System.Text.Encoding.UTF8), null);
    global::DripSharp.Testing.JavaAssertions.Equal("123456789",
      global::DripSharp.Runtime.JavaCompat.NewString(signature.GetContents(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(by)),
      global::System.Text.Encoding.UTF8), null);
  }

  [Xunit.Fact]
  public void __Upstream_1380863015_3aa10957eec38a19() {
    this.setUp();
    try {
      this.createDefaultSignatureField();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3823494141_d152ac57efbdbe62() {
    this.setUp();
    try {
      this.setValueForAbstractedSignatureField();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2998586526_aa13422f0b91c9c0() {
    this.setUp();
    try {
      this.testGetContents();
    } finally {
    }
  }
}
