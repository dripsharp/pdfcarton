// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class PDTextFieldTest {
private global::DripSharp.PdfCarton.Pdmodel.PDDocument document = null!;

private global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = null!;

internal virtual void setUp() {
this.document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
this.acroForm = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(this.document);
}

internal virtual void createDefaultTextField() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField textField = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(this.acroForm);
global::DripSharp.Testing.JavaAssertions.Equal(textField.GetFieldType(), textField.GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.Ft), null);
global::DripSharp.Testing.JavaAssertions.Equal("Tx", textField.GetFieldType(), null);
}

internal virtual void createWidgetForGet() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField textField = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(this.acroForm);
global::DripSharp.Testing.JavaAssertions.Null(textField.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Type), null);
global::DripSharp.Testing.JavaAssertions.Null(textField.GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.Subtype), null);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget = global::DripSharp.Runtime.JavaCompat.ListGet(textField.GetWidgets(), 0);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Annot, textField.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Type), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget.SubType, textField.GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.Subtype), null);
global::DripSharp.Testing.JavaAssertions.Equal(widget.GetCOSObject(), textField.GetCOSObject(), null);
}

[Xunit.Fact]
public void __Upstream_1373097896_096aa6c73fe042b7()
{
        this.setUp();
        try
        {
            this.createDefaultTextField();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0574834765_1dea948058135b7c()
{
        this.setUp();
        try
        {
            this.createWidgetForGet();
        }
        finally
        {
        }
}
}
