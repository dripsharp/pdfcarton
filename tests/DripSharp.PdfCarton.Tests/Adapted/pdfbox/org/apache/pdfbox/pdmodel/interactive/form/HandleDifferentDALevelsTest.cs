// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class HandleDifferentDALevelsTest {
private static readonly global::System.IO.FileInfo OUT_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output"));

private static readonly global::System.IO.FileInfo IN_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "src/test/resources/org/apache/pdfbox/pdmodel/interactive/form"));

private const string NAME_OF_PDF = "DifferentDALevels.pdf";

private global::DripSharp.PdfCarton.Pdmodel.PDDocument document = null!;

private global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = null!;

internal virtual void setUp() {
this.document = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.HandleDifferentDALevelsTest.IN_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.HandleDifferentDALevelsTest.NAME_OF_PDF))));
this.acroForm = this.document.GetDocumentCatalog().GetAcroForm();
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.HandleDifferentDALevelsTest.OUT_DIR);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField field = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "SingleAnnotation"))!);
field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "single annotation"));
field = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "MultipeAnnotations-SameLayout"))!);
field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "same layout"));
field = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "MultipleAnnotations-DifferentLayout"))!);
field.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "different layout"));
global::System.IO.FileInfo file = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.HandleDifferentDALevelsTest.OUT_DIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.HandleDifferentDALevelsTest.NAME_OF_PDF)));
this.document.Save(file);
}

internal virtual void checkSingleAnnotation() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField field = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "SingleAnnotation"))!);
string fieldFontSetting = this.getFontSettingFromDA(field);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget> widgets = field.GetWidgets();
foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget in widgets) {
string contentAsString = global::DripSharp.Runtime.JavaCompat.NewString(widget.GetNormalAppearanceStream().GetContentStream().ToByteArray(), global::System.Text.Encoding.UTF8);
global::DripSharp.Testing.JavaAssertions.True((contentAsString.IndexOf(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", fieldFontSetting), global::System.StringComparison.Ordinal) > 0), null);
}
}

internal virtual void checkSameLayout() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField field = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "MultipeAnnotations-SameLayout"))!);
string fieldFontSetting = this.getFontSettingFromDA(field);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget> widgets = field.GetWidgets();
foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget in widgets) {
string contentAsString = global::DripSharp.Runtime.JavaCompat.NewString(widget.GetNormalAppearanceStream().GetContentStream().ToByteArray(), global::System.Text.Encoding.UTF8);
global::DripSharp.Testing.JavaAssertions.True((contentAsString.IndexOf(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", fieldFontSetting), global::System.StringComparison.Ordinal) > 0), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("font setting in content stream shall be ", fieldFontSetting)));
}
}

internal virtual void checkDifferentLayout() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField field = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField)(this.acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "MultipleAnnotations-DifferentLayout"))!);
string fieldFontSetting = this.getFontSettingFromDA(field);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget> widgets = field.GetWidgets();
foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget in widgets) {
string widgetFontSetting = this.getFontSettingFromDA(widget);
string fontSetting = ((widgetFontSetting == default!) ? fieldFontSetting : widgetFontSetting);
string contentAsString = global::DripSharp.Runtime.JavaCompat.NewString(widget.GetNormalAppearanceStream().GetContentStream().ToByteArray(), global::System.Text.Encoding.UTF8);
global::DripSharp.Testing.JavaAssertions.True((contentAsString.IndexOf(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", fontSetting), global::System.StringComparison.Ordinal) > 0), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("font setting in content stream shall be ", fontSetting)));
}
}

internal virtual void tearDown() {
this.document.Dispose();
}

private string getFontSettingFromDA(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField field) {
string defaultAppearance = field.GetDefaultAppearance();
return global::DripSharp.Runtime.JavaCompat.StringSubstring(defaultAppearance, 0, (defaultAppearance.LastIndexOf(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Tf"), global::System.StringComparison.Ordinal) + 2));
}

private string getFontSettingFromDA(global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget) {
string defaultAppearance = widget.GetCOSObject().GetString(global::DripSharp.PdfCarton.Cos.COSName.Da);
if ((defaultAppearance != default!)) {
return global::DripSharp.Runtime.JavaCompat.StringSubstring(defaultAppearance, 0, (defaultAppearance.LastIndexOf(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Tf"), global::System.StringComparison.Ordinal) + 2));
}
return defaultAppearance;
}

[Xunit.Fact]
public void __Upstream_1803782811_879fd73280d4c2bd()
{
        this.setUp();
        try
        {
            this.checkDifferentLayout();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_1403148888_2e223ba502487316()
{
        this.setUp();
        try
        {
            this.checkSameLayout();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_1898228415_710e807c3f870e0c()
{
        this.setUp();
        try
        {
            this.checkSingleAnnotation();
        }
        finally
        {
            this.tearDown();
        }
}
}
