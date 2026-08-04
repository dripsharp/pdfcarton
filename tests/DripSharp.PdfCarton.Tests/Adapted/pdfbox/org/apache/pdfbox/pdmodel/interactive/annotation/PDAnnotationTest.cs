// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Annotation;

public class PDAnnotationTest {
internal virtual void createDefaultWidgetAnnotation() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation annotation = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget();
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Annot, annotation.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Type), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget.SubType, annotation.GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.Subtype), null);
}

internal virtual void createWidgetAnnotationFromField() {
global::DripSharp.PdfCarton.Pdmodel.PDDocument document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(document);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField textField = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(acroForm);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation annotation = global::DripSharp.Runtime.JavaCompat.ListGet(textField.GetWidgets(), 0);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Annot, annotation.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Type), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget.SubType, annotation.GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.Subtype), null);
}

[Xunit.Fact]
public void __Upstream_3022614616_0d50b8d6611245e9()
{
        try
        {
            this.createDefaultWidgetAnnotation();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0595189377_0324421b22c203ce()
{
        try
        {
            this.createWidgetAnnotationFromField();
        }
        finally
        {
        }
}
}
