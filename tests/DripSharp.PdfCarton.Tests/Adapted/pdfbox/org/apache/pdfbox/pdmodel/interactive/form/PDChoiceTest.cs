// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class PDChoiceTest {
  private global::DripSharp.PdfCarton.Pdmodel.PDDocument document = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = null!;

  private global::System.Collections.Generic.IList<string> options = null!;

  internal virtual void setUp() {
    this.document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
    this.acroForm
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(this.document);
    this.options = new global::System.Collections.Generic.List<string>();
    global::DripSharp.Runtime.JavaCompat.Add(this.options, " ");
    global::DripSharp.Runtime.JavaCompat.Add(this.options, "A");
    global::DripSharp.Runtime.JavaCompat.Add(this.options, "B");
  }

  internal virtual void createListBox() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDChoice choiceField
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDListBox(this.acroForm);
    global::DripSharp.Testing.JavaAssertions.Equal(choiceField.GetFieldType(),
      choiceField.GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.Ft), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Ch", choiceField.GetFieldType(), null);
    global::DripSharp.Testing.JavaAssertions.False(choiceField.IsCombo(), null);
  }

  internal virtual void createComboBox() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDChoice choiceField
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDComboBox(this.acroForm);
    global::DripSharp.Testing.JavaAssertions.Equal(choiceField.GetFieldType(),
      choiceField.GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.Ft), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Ch", choiceField.GetFieldType(), null);
    global::DripSharp.Testing.JavaAssertions.True(choiceField.IsCombo(), null);
  }

  internal virtual void getOptionsFromStrings() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDChoice choiceField
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDComboBox(this.acroForm);
    global::DripSharp.PdfCarton.Cos.COSArray choiceFieldOptions
      = new global::DripSharp.PdfCarton.Cos.COSArray();
    choiceFieldOptions.Add(new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      " ")));
    choiceFieldOptions.Add(new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "A")));
    choiceFieldOptions.Add(new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "B")));
    choiceField.GetCOSObject().SetItem(global::DripSharp.PdfCarton.Cos.COSName.Opt,
      choiceFieldOptions);
    global::DripSharp.Testing.JavaAssertions.Equal(this.options, choiceField.GetOptions(), null);
  }

  internal virtual void getOptionsFromCOSArray() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDChoice choiceField
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDComboBox(this.acroForm);
    global::DripSharp.PdfCarton.Cos.COSArray choiceFieldOptions
      = new global::DripSharp.PdfCarton.Cos.COSArray();
    global::DripSharp.PdfCarton.Cos.COSArray entry = new global::DripSharp.PdfCarton.Cos.COSArray();
    entry.Add(new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      " ")));
    choiceFieldOptions.Add(entry);
    entry = new global::DripSharp.PdfCarton.Cos.COSArray();
    entry.Add(new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "A")));
    choiceFieldOptions.Add(entry);
    entry = new global::DripSharp.PdfCarton.Cos.COSArray();
    entry.Add(new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "B")));
    choiceFieldOptions.Add(entry);
    choiceField.GetCOSObject().SetItem(global::DripSharp.PdfCarton.Cos.COSName.Opt,
      choiceFieldOptions);
    global::DripSharp.Testing.JavaAssertions.Equal(this.options, choiceField.GetOptions(), null);
  }

  internal virtual void getOptionsFromMixed() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDChoice choiceField
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDComboBox(this.acroForm);
    global::DripSharp.PdfCarton.Cos.COSArray choiceFieldOptions
      = new global::DripSharp.PdfCarton.Cos.COSArray();
    choiceFieldOptions.Add(new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      " ")));
    global::DripSharp.PdfCarton.Cos.COSArray entry = new global::DripSharp.PdfCarton.Cos.COSArray();
    entry.Add(new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "A")));
    choiceFieldOptions.Add(entry);
    entry = new global::DripSharp.PdfCarton.Cos.COSArray();
    entry.Add(new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "B")));
    choiceFieldOptions.Add(entry);
    choiceField.GetCOSObject().SetItem(global::DripSharp.PdfCarton.Cos.COSName.Opt,
      choiceFieldOptions);
    global::DripSharp.Testing.JavaAssertions.Equal(this.options, choiceField.GetOptions(), null);
  }

  internal virtual void PDFBox6150() {
    global::System.IO.FileInfo pdfFile
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/pdfs/PDFBOX-6150.pdf"));
    if (!global::System.IO.File.Exists(pdfFile.FullName)) {
      return;
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document
      = global::DripSharp.PdfCarton.Loader.LoadPDF(pdfFile)) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
        = document.GetDocumentCatalog().GetAcroForm();
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDChoice field
        = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDChoice)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "shipping_country"))!);
      field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "DE"));
      global::DripSharp.Testing.JavaAssertions.Equal("DE",
        global::DripSharp.Runtime.JavaCompat.ListGet(field.GetValue(), 0),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "The fields value should be set to DE"));
      global::System.Collections.Generic.IList<string> content
        = global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.TestUtils.GetStringsFromStream(field);
      bool hasContent
        = global::DripSharp.Runtime.JavaCompat.Any(global::DripSharp.Runtime.JavaCompat.Stream(content),
        "Deutschland".Equals);
      global::DripSharp.Testing.JavaAssertions.True(hasContent,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "The content should contain the display value for DE which is Deutschland"));
      document.Dispose();
    }
  }

  [Xunit.Fact]
  public void __Upstream_0137141679_769adc65565fa8cc() {
    this.setUp();
    try {
      this.PDFBox6150();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2457733753_80295b308e6b7a9d() {
    this.setUp();
    try {
      this.createComboBox();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0280972209_d8a3694f30b43a41() {
    this.setUp();
    try {
      this.createListBox();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3368570212_b73b8e626dfee0c7() {
    this.setUp();
    try {
      this.getOptionsFromCOSArray();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4208677097_bbd7af2cc44818c0() {
    this.setUp();
    try {
      this.getOptionsFromMixed();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0019063792_a26b61534ce33baa() {
    this.setUp();
    try {
      this.getOptionsFromStrings();
    } finally {
    }
  }
}
