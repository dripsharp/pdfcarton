// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class PDButtonTest {
private static readonly global::System.IO.FileInfo IN_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "src/test/resources/org/apache/pdfbox/pdmodel/interactive/form"));

private const string NAME_OF_PDF = "AcroFormsBasicFields.pdf";

private static readonly global::System.IO.FileInfo TARGET_PDF_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/pdfs"));

private global::DripSharp.PdfCarton.Pdmodel.PDDocument document = null!;

private global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = null!;

private global::DripSharp.PdfCarton.Pdmodel.PDDocument acrobatDocument = null!;

private global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acrobatAcroForm = null!;

internal virtual void setUp() {
this.document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
this.acroForm = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(this.document);
this.acrobatDocument = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDButtonTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDButtonTest.NAME_OF_PDF))));
this.acrobatAcroForm = this.acrobatDocument.GetDocumentCatalog().GetAcroForm();
}

internal virtual void createCheckBox() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDButton buttonField = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox(this.acroForm);
global::DripSharp.Testing.JavaAssertions.Equal(buttonField.GetFieldType(), buttonField.GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.Ft), null);
global::DripSharp.Testing.JavaAssertions.Equal("Btn", buttonField.GetFieldType(), null);
global::DripSharp.Testing.JavaAssertions.False(buttonField.IsPushButton(), null);
global::DripSharp.Testing.JavaAssertions.False(buttonField.IsRadioButton(), null);
}

internal virtual void createPushButton() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDButton buttonField = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDPushButton(this.acroForm);
global::DripSharp.Testing.JavaAssertions.Equal(buttonField.GetFieldType(), buttonField.GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.Ft), null);
global::DripSharp.Testing.JavaAssertions.Equal("Btn", buttonField.GetFieldType(), null);
global::DripSharp.Testing.JavaAssertions.True(buttonField.IsPushButton(), null);
global::DripSharp.Testing.JavaAssertions.False(buttonField.IsRadioButton(), null);
}

internal virtual void createRadioButton() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDButton buttonField = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton(this.acroForm);
global::DripSharp.Testing.JavaAssertions.Equal(buttonField.GetFieldType(), buttonField.GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.Ft), null);
global::DripSharp.Testing.JavaAssertions.Equal("Btn", buttonField.GetFieldType(), null);
global::DripSharp.Testing.JavaAssertions.True(buttonField.IsRadioButton(), null);
global::DripSharp.Testing.JavaAssertions.False(buttonField.IsPushButton(), null);
}

internal virtual void testRadioButtonWithOptions() {
global::System.IO.FileInfo file = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDButtonTest.TARGET_PDF_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-3656.pdf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument pdfDocument = global::DripSharp.PdfCarton.Loader.LoadPDF(file)) {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton radioButton = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton)(pdfDocument.GetDocumentCatalog().GetAcroForm().GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Checking/Savings"))!);
radioButton.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Off"));
global::DripSharp.Runtime.JavaCompat.ForEach(radioButton.GetWidgets(), (widget) => global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Off, widget.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.As), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The widget should be set to Off")));
}
}

internal virtual void testOptionsAndNamesNotNumbers() {
global::System.IO.FileInfo file = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDButtonTest.TARGET_PDF_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-3682.pdf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument pdfDocument = global::DripSharp.PdfCarton.Loader.LoadPDF(file)) {
pdfDocument.GetDocumentCatalog().GetAcroForm().GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "RadioButton")).SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "c"));
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton radioButton = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton)(pdfDocument.GetDocumentCatalog().GetAcroForm().GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "RadioButton"))!);
radioButton.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "c"));
global::DripSharp.Testing.JavaAssertions.NotEqual("2", radioButton.GetValueAsString(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "This shall no longer be 2"));
global::DripSharp.Testing.JavaAssertions.NotEqual("2", global::DripSharp.Runtime.JavaCompat.ListGet(radioButton.GetWidgets(), 2).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.As), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "This shall no longer be 2"));
global::DripSharp.Testing.JavaAssertions.Equal("c", radioButton.GetValueAsString(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "This shall be c"));
global::DripSharp.Testing.JavaAssertions.Equal("c", global::DripSharp.Runtime.JavaCompat.ListGet(radioButton.GetWidgets(), 2).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.As), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "This shall be c"));
}
}

internal virtual void retrieveAcrobatCheckBoxProperties() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox checkbox = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox)(this.acrobatAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Checkbox"))!);
global::DripSharp.Testing.JavaAssertions.NotNull(checkbox, null);
global::DripSharp.Testing.JavaAssertions.Equal("Yes", checkbox.GetOnValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, checkbox.GetOnValues().Count, null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(checkbox.GetOnValues(), "Yes"), null);
}

internal virtual void testAcrobatCheckBoxProperties() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox checkbox = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox)(this.acrobatAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Checkbox"))!);
global::DripSharp.Testing.JavaAssertions.Equal("Off", checkbox.GetValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(false, checkbox.IsChecked(), null);
checkbox.Check();
global::DripSharp.Testing.JavaAssertions.Equal(checkbox.GetValue(), checkbox.GetOnValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(true, checkbox.IsChecked(), null);
checkbox.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Yes"));
global::DripSharp.Testing.JavaAssertions.Equal(checkbox.GetValue(), checkbox.GetOnValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(true, checkbox.IsChecked(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Yes, checkbox.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.As), null);
checkbox.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Off"));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Off.GetName(), checkbox.GetValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(false, checkbox.IsChecked(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Off, checkbox.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.As), null);
checkbox = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox)(this.acrobatAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Checkbox-DefaultValue"))!);
global::DripSharp.Testing.JavaAssertions.Equal(checkbox.GetDefaultValue(), checkbox.GetOnValue(), null);
checkbox.SetDefaultValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Off"));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Off.GetName(), checkbox.GetDefaultValue(), null);
}

internal virtual void setValueForAbstractedAcrobatCheckBox() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField checkbox = this.acrobatAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Checkbox"));
checkbox.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Yes"));
global::DripSharp.Testing.JavaAssertions.Equal(checkbox.GetValueAsString(), ((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox)(checkbox!)).GetOnValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(true, ((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox)(checkbox!)).IsChecked(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Yes, checkbox.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.As), null);
checkbox.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Off"));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Off.GetName(), checkbox.GetValueAsString(), null);
global::DripSharp.Testing.JavaAssertions.Equal(false, ((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox)(checkbox!)).IsChecked(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Off, checkbox.GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.As), null);
}

internal virtual void testAcrobatCheckBoxGroupProperties() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox checkbox = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox)(this.acrobatAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "CheckboxGroup"))!);
global::DripSharp.Testing.JavaAssertions.Equal("Off", checkbox.GetValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(false, checkbox.IsChecked(), null);
checkbox.Check();
global::DripSharp.Testing.JavaAssertions.Equal(checkbox.GetValue(), checkbox.GetOnValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(true, checkbox.IsChecked(), null);
global::DripSharp.Testing.JavaAssertions.Equal(3, checkbox.GetOnValues().Count, null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(checkbox.GetOnValues(), "Option1"), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(checkbox.GetOnValues(), "Option2"), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(checkbox.GetOnValues(), "Option3"), null);
checkbox.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Option1"));
global::DripSharp.Testing.JavaAssertions.Equal("Option1", checkbox.GetValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Option1", checkbox.GetValueAsString(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Option1", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 0).GetAppearanceState().GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Off", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 1).GetAppearanceState().GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Off", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 2).GetAppearanceState().GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Off", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 3).GetAppearanceState().GetName(), null);
checkbox.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Option3"));
global::DripSharp.Testing.JavaAssertions.Equal("Option3", checkbox.GetValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Option3", checkbox.GetValueAsString(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Off", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 0).GetAppearanceState().GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Off", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 1).GetAppearanceState().GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Option3", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 2).GetAppearanceState().GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Option3", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 3).GetAppearanceState().GetName(), null);
}

internal virtual void setValueForAbstractedCheckBoxGroup() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField checkbox = this.acrobatAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "CheckboxGroup"));
checkbox.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Option1"));
global::DripSharp.Testing.JavaAssertions.Equal("Option1", checkbox.GetValueAsString(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Option1", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 0).GetAppearanceState().GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Off", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 1).GetAppearanceState().GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Off", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 2).GetAppearanceState().GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Off", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 3).GetAppearanceState().GetName(), null);
checkbox.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Option3"));
global::DripSharp.Testing.JavaAssertions.Equal("Option3", checkbox.GetValueAsString(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Off", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 0).GetAppearanceState().GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Off", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 1).GetAppearanceState().GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Option3", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 2).GetAppearanceState().GetName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Option3", global::DripSharp.Runtime.JavaCompat.ListGet(checkbox.GetWidgets(), 3).GetAppearanceState().GetName(), null);
}

internal virtual void setCheckboxInvalidValue() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox checkbox = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox)(this.acrobatAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Checkbox"))!);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => checkbox.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "InvalidValue")), null);
}

internal virtual void setCheckboxGroupInvalidValue() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox checkbox = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox)(this.acrobatAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "CheckboxGroup"))!);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => checkbox.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "InvalidValue")), null);
}

internal virtual void setAbstractedCheckboxInvalidValue() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField checkbox = this.acrobatAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Checkbox"));
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => checkbox.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "InvalidValue")), null);
}

internal virtual void setAbstractedCheckboxGroupInvalidValue() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField checkbox = this.acrobatAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "CheckboxGroup"));
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => checkbox.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "InvalidValue")), null);
}

internal virtual void retrieveAcrobatRadioButtonProperties() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton radioButton = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton)(this.acrobatAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "RadioButtonGroup"))!);
global::DripSharp.Testing.JavaAssertions.NotNull(radioButton, null);
global::DripSharp.Testing.JavaAssertions.Equal(2, radioButton.GetOnValues().Count, null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(radioButton.GetOnValues(), "RadioButton01"), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(radioButton.GetOnValues(), "RadioButton02"), null);
}

internal virtual void testAcrobatRadioButtonProperties() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton radioButton = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton)(this.acrobatAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "RadioButtonGroup"))!);
radioButton.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "RadioButton01"));
global::DripSharp.Testing.JavaAssertions.Equal("RadioButton01", radioButton.GetValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "RadioButton01")), global::DripSharp.Runtime.JavaCompat.ListGet(radioButton.GetWidgets(), 0).GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.As), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Off, global::DripSharp.Runtime.JavaCompat.ListGet(radioButton.GetWidgets(), 1).GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.As), null);
radioButton.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "RadioButton02"));
global::DripSharp.Testing.JavaAssertions.Equal("RadioButton02", radioButton.GetValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Off, global::DripSharp.Runtime.JavaCompat.ListGet(radioButton.GetWidgets(), 0).GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.As), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "RadioButton02")), global::DripSharp.Runtime.JavaCompat.ListGet(radioButton.GetWidgets(), 1).GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.As), null);
}

internal virtual void setValueForAbstractedAcrobatRadioButton() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField radioButton = this.acrobatAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "RadioButtonGroup"));
radioButton.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "RadioButton01"));
global::DripSharp.Testing.JavaAssertions.Equal("RadioButton01", radioButton.GetValueAsString(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "RadioButton01")), global::DripSharp.Runtime.JavaCompat.ListGet(radioButton.GetWidgets(), 0).GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.As), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Off, global::DripSharp.Runtime.JavaCompat.ListGet(radioButton.GetWidgets(), 1).GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.As), null);
radioButton.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "RadioButton02"));
global::DripSharp.Testing.JavaAssertions.Equal("RadioButton02", radioButton.GetValueAsString(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Off, global::DripSharp.Runtime.JavaCompat.ListGet(radioButton.GetWidgets(), 0).GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.As), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "RadioButton02")), global::DripSharp.Runtime.JavaCompat.ListGet(radioButton.GetWidgets(), 1).GetCOSObject().GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.As), null);
}

internal virtual void setRadioButtonInvalidValue() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton radioButton = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDRadioButton)(this.acrobatAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "RadioButtonGroup"))!);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => radioButton.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "InvalidValue")), null);
}

internal virtual void setAbstractedRadioButtonInvalidValue() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField radioButton = this.acrobatAcroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "RadioButtonGroup"));
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => radioButton.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "InvalidValue")), null);
}

internal virtual void tearDown() {
this.document.Dispose();
this.acrobatDocument.Dispose();
}

[Xunit.Fact]
public void __Upstream_0311946431_b79ea66118c40d50()
{
        this.setUp();
        try
        {
            this.createCheckBox();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0791542024_882cb50224ab0b7c()
{
        this.setUp();
        try
        {
            this.createPushButton();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_2012991601_34879c8bb7b91423()
{
        this.setUp();
        try
        {
            this.createRadioButton();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_2361560272_e621f351730f5c48()
{
        this.setUp();
        try
        {
            this.retrieveAcrobatCheckBoxProperties();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0990375494_c296c75986f27baa()
{
        this.setUp();
        try
        {
            this.retrieveAcrobatRadioButtonProperties();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_1892448083_f5b9b22bfa92ee16()
{
        this.setUp();
        try
        {
            this.setAbstractedCheckboxGroupInvalidValue();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3644140544_168085f279d044aa()
{
        this.setUp();
        try
        {
            this.setAbstractedCheckboxInvalidValue();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3894277028_2e325ef7ed988b5e()
{
        this.setUp();
        try
        {
            this.setAbstractedRadioButtonInvalidValue();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0732204564_cd6a336ba4111149()
{
        this.setUp();
        try
        {
            this.setCheckboxGroupInvalidValue();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0459808927_77aeba2c4af6a2e3()
{
        this.setUp();
        try
        {
            this.setCheckboxInvalidValue();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_2413741733_58a4d75051ea645b()
{
        this.setUp();
        try
        {
            this.setRadioButtonInvalidValue();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3819271710_f6ff69790d3f5c13()
{
        this.setUp();
        try
        {
            this.setValueForAbstractedAcrobatCheckBox();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0776001202_16c7011da0bea60d()
{
        this.setUp();
        try
        {
            this.setValueForAbstractedAcrobatRadioButton();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0496373857_1851cb42fa29da2b()
{
        this.setUp();
        try
        {
            this.setValueForAbstractedCheckBoxGroup();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_2201620843_cd1864d6a90aa781()
{
        this.setUp();
        try
        {
            this.testAcrobatCheckBoxGroupProperties();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0931132730_86fb88a3577f878d()
{
        this.setUp();
        try
        {
            this.testAcrobatCheckBoxProperties();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_1788982684_a5d1f6719c6e6ca8()
{
        this.setUp();
        try
        {
            this.testAcrobatRadioButtonProperties();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3715236180_2df667dc966fcdca()
{
        this.setUp();
        try
        {
            this.testOptionsAndNamesNotNumbers();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0846473437_14f6db280a844e00()
{
        this.setUp();
        try
        {
            this.testRadioButtonWithOptions();
        }
        finally
        {
            this.tearDown();
        }
}
}
