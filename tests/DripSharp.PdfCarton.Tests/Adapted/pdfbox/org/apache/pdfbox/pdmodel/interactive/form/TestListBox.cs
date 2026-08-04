// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class TestListBox {
private global::System.Collections.Generic.IList<string> exportValues = null!;

private global::System.Collections.Generic.IList<string> displayValues = null!;

private global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = null!;

internal global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDListBox choice = null!;

internal virtual void setUp() {
this.exportValues = new global::System.Collections.Generic.List<string>();
global::DripSharp.Runtime.JavaCompat.Add(this.exportValues, "export01");
global::DripSharp.Runtime.JavaCompat.Add(this.exportValues, "export02");
global::DripSharp.Runtime.JavaCompat.Add(this.exportValues, "export03");
this.displayValues = new global::System.Collections.Generic.List<string>();
global::DripSharp.Runtime.JavaCompat.Add(this.displayValues, "display02");
global::DripSharp.Runtime.JavaCompat.Add(this.displayValues, "display01");
global::DripSharp.Runtime.JavaCompat.Add(this.displayValues, "display03");
this.doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
global::DripSharp.PdfCarton.Pdmodel.PDPage page = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
this.doc.AddPage(page);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm form = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(this.doc);
global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica);
global::DripSharp.PdfCarton.Pdmodel.PDResources resources = new global::DripSharp.PdfCarton.Pdmodel.PDResources();
resources.Put(global::DripSharp.PdfCarton.Cos.COSName.Helv, font);
form.SetDefaultResources(resources);
string defaultAppearanceString = "/Helv 0 Tf 0 g";
form.SetDefaultAppearance(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", defaultAppearanceString));
this.choice = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDListBox(form);
this.choice.SetDefaultAppearance(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "/Helv 12 Tf 0g"));
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget = global::DripSharp.Runtime.JavaCompat.ListGet(this.choice.GetWidgets(), 0);
global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle rect = new global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle((float)(50), (float)(750), (float)(200), (float)(50));
widget.SetRectangle(rect);
widget.SetPage(page);
global::DripSharp.Runtime.JavaCompat.Add(page.GetAnnotations(), widget);
}

internal virtual void testNoNullsReturned() {
global::DripSharp.Testing.JavaAssertions.NotNull(this.choice.GetOptions(), null);
global::DripSharp.Testing.JavaAssertions.NotNull(this.choice.GetValue(), null);
}

internal virtual void testExportValuesGetterSetter() {
this.choice.SetOptions(this.exportValues);
global::DripSharp.Testing.JavaAssertions.Equal(this.exportValues, this.choice.GetOptionsDisplayValues(), null);
global::DripSharp.Testing.JavaAssertions.Equal(this.exportValues, this.choice.GetOptionsExportValues(), null);
this.choice.SetTopIndex(1);
this.choice.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.ListGet(this.exportValues, 2)));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ListGet(this.exportValues, 2), global::DripSharp.Runtime.JavaCompat.ListGet(this.choice.GetValue(), 0), null);
this.choice.SetTopIndex((int?)default!);
global::DripSharp.PdfCarton.Cos.COSArray optItem = (global::DripSharp.PdfCarton.Cos.COSArray)(this.choice.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Opt)!);
global::DripSharp.Testing.JavaAssertions.NotNull(this.choice.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Opt), null);
global::DripSharp.Testing.JavaAssertions.Equal(optItem.Size(), global::DripSharp.Runtime.JavaCompat.CollectionCount(this.exportValues), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ListGet(this.exportValues, 0), optItem.GetString(0), null);
global::System.Collections.Generic.IList<string> retrievedOptions = this.choice.GetOptions();
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.CollectionCount(retrievedOptions), global::DripSharp.Runtime.JavaCompat.CollectionCount(this.exportValues), null);
global::DripSharp.Testing.JavaAssertions.Equal(retrievedOptions, this.exportValues, null);
}

internal virtual void testFieldValueSetterGetter() {
this.choice.SetOptions(this.exportValues);
this.choice.SetMultiSelect(true);
this.choice.SetValue(this.exportValues);
global::DripSharp.PdfCarton.Cos.COSArray valueItems = (global::DripSharp.PdfCarton.Cos.COSArray)(this.choice.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.V)!);
global::DripSharp.Testing.JavaAssertions.NotNull(valueItems, null);
global::DripSharp.Testing.JavaAssertions.Equal(valueItems.Size(), global::DripSharp.Runtime.JavaCompat.CollectionCount(this.exportValues), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ListGet(this.exportValues, 0), valueItems.GetString(0), null);
global::DripSharp.PdfCarton.Cos.COSArray indexItems = (global::DripSharp.PdfCarton.Cos.COSArray)(this.choice.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.I)!);
global::DripSharp.Testing.JavaAssertions.NotNull(indexItems, null);
global::DripSharp.Testing.JavaAssertions.Equal(indexItems.Size(), global::DripSharp.Runtime.JavaCompat.CollectionCount(this.exportValues), null);
this.choice.SetValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "export01"));
indexItems = (global::DripSharp.PdfCarton.Cos.COSArray)(this.choice.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.I)!);
global::DripSharp.Testing.JavaAssertions.Null(indexItems, null);
}

internal virtual void testMultiselect() {
this.choice.SetOptions(this.exportValues);
this.choice.SetMultiSelect(false);
global::System.Exception exception = global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => {
this.choice.SetValue(this.exportValues);
}, null);
global::DripSharp.Testing.JavaAssertions.Equal("The list box does not allow multiple selections.", global::DripSharp.Runtime.JavaCompat.ExceptionMessage(exception), null);
this.choice.SetMultiSelect(true);
this.choice.SetValue(this.exportValues);
}

internal virtual void testOptIsRemovedForNull() {
this.choice.SetOptions(this.exportValues);
global::DripSharp.Testing.JavaAssertions.NotNull(this.choice.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Opt), null);
this.choice.SetOptions((global::System.Collections.Generic.IList<string>)default!);
global::DripSharp.Testing.JavaAssertions.Null(this.choice.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Opt), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::System.Array.Empty<object>(), this.choice.GetOptions(), null);
}

internal virtual void testSetExportAndDisplay() {
this.choice.SetOptions(this.exportValues, this.displayValues);
global::DripSharp.Testing.JavaAssertions.Equal(this.displayValues, this.choice.GetOptionsDisplayValues(), null);
global::DripSharp.Testing.JavaAssertions.Equal(this.exportValues, this.choice.GetOptionsExportValues(), null);
}

internal virtual void testSortOption() {
this.choice.SetOptions(this.exportValues, this.displayValues);
global::DripSharp.Testing.JavaAssertions.Equal("display02", global::DripSharp.Runtime.JavaCompat.ListGet(this.choice.GetOptionsDisplayValues(), 0), null);
this.choice.SetSort(true);
this.choice.SetOptions(this.exportValues, this.displayValues);
global::DripSharp.Testing.JavaAssertions.Equal("display01", global::DripSharp.Runtime.JavaCompat.ListGet(this.choice.GetOptionsDisplayValues(), 0), null);
global::DripSharp.Testing.JavaAssertions.Equal("display02", global::DripSharp.Runtime.JavaCompat.ListGet(this.choice.GetOptionsDisplayValues(), 1), null);
global::DripSharp.Testing.JavaAssertions.Equal("display03", global::DripSharp.Runtime.JavaCompat.ListGet(this.choice.GetOptionsDisplayValues(), 2), null);
}

internal virtual void testEmptyOptionsNotNull() {
this.choice.SetOptions((global::System.Collections.Generic.IList<string>)default!, this.displayValues);
global::DripSharp.Testing.JavaAssertions.Null(this.choice.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Opt), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::System.Array.Empty<object>(), this.choice.GetOptions(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::System.Array.Empty<object>(), this.choice.GetOptionsDisplayValues(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::System.Array.Empty<object>(), this.choice.GetOptionsExportValues(), null);
}

internal virtual void testExceptionForDifferentNumberOfEntries() {
global::DripSharp.Runtime.JavaCompat.ListRemove(this.exportValues, 1);
global::System.Exception exception = global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => {
this.choice.SetOptions(this.exportValues, this.displayValues);
}, null);
global::DripSharp.Testing.JavaAssertions.Equal("The number of entries for exportValue and displayValue shall be the same.", global::DripSharp.Runtime.JavaCompat.ExceptionMessage(exception), null);
}

internal virtual void tearDown() {
global::DripSharp.PdfCarton.Tests.Support.CloseQuietly(this.doc);
}

[Xunit.Fact]
public void __Upstream_2986283831_9f157f6d871153b8()
{
        this.setUp();
        try
        {
            this.testEmptyOptionsNotNull();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_4167512003_e827b92272664052()
{
        this.setUp();
        try
        {
            this.testExceptionForDifferentNumberOfEntries();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_1175854386_65cec81e2a78f69b()
{
        this.setUp();
        try
        {
            this.testExportValuesGetterSetter();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0672552915_a68cfc4631b87a45()
{
        this.setUp();
        try
        {
            this.testFieldValueSetterGetter();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_2130096003_772f58c54ce36c15()
{
        this.setUp();
        try
        {
            this.testMultiselect();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_2634957448_291aa75967d201d3()
{
        this.setUp();
        try
        {
            this.testNoNullsReturned();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3019016219_20b49bf1ea50cf27()
{
        this.setUp();
        try
        {
            this.testOptIsRemovedForNull();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3131828303_e9ca74b454ceedab()
{
        this.setUp();
        try
        {
            this.testSetExportAndDisplay();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0602099173_1a82dd5483eb9c0f()
{
        this.setUp();
        try
        {
            this.testSortOption();
        }
        finally
        {
            this.tearDown();
        }
}
}
