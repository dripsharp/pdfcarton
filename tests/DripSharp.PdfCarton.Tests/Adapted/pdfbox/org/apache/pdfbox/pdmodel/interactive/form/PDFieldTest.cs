// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class PDFieldTest {
private global::DripSharp.PdfCarton.Pdmodel.PDDocument document = null!;

private global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = null!;

private global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField textField = null!;

internal virtual void setUp() {
this.document = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
this.acroForm = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(this.document);
this.textField = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(this.acroForm);
}

internal virtual void tearDown() {
this.document.Dispose();
}

internal virtual void testPartialName() {
global::DripSharp.Testing.JavaAssertions.Null(this.textField.GetPartialName(), null);
string testName = "testField";
this.textField.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", testName));
global::DripSharp.Testing.JavaAssertions.Equal(testName, this.textField.GetPartialName(), null);
string newName = "anotherField";
this.textField.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", newName));
global::DripSharp.Testing.JavaAssertions.Equal(newName, this.textField.GetPartialName(), null);
}

internal virtual void testSetPartialNameNull() {
global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => this.textField.SetPartialName((string)default!), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Setting partial name to null should not throw an exception"));
}

internal virtual void testPartialNameWithPeriodThrows() {
string nameWithPeriod = "test.field";
global::System.ArgumentException exception = global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => this.textField.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", nameWithPeriod)), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(global::DripSharp.Runtime.JavaCompat.ExceptionMessage(exception), "period character"), null);
}

internal virtual void testFullyQualifiedName() {
this.textField.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "childField"));
string fullyQualifiedName = this.textField.GetFullyQualifiedName();
global::DripSharp.Testing.JavaAssertions.Equal("childField", fullyQualifiedName, null);
}

internal virtual void testFullyQualifiedNameNullPartialName() {
string fullyQualifiedName = this.textField.GetFullyQualifiedName();
global::DripSharp.Testing.JavaAssertions.Null(fullyQualifiedName, null);
}

internal virtual void testFullyQualifiedNameWithParent() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDNonTerminalField parentField = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDNonTerminalField(this.acroForm);
parentField.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "parentField"));
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField childField = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(this.acroForm, new global::DripSharp.PdfCarton.Cos.COSDictionary(), parentField);
childField.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "childField"));
string fullyQualifiedName = childField.GetFullyQualifiedName();
global::DripSharp.Testing.JavaAssertions.Equal("parentField.childField", fullyQualifiedName, null);
}

internal virtual void testAlternateFieldName() {
global::DripSharp.Testing.JavaAssertions.Null(this.textField.GetAlternateFieldName(), null);
string alternateName = "Alternate Name For Field";
this.textField.SetAlternateFieldName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", alternateName));
global::DripSharp.Testing.JavaAssertions.Equal(alternateName, this.textField.GetAlternateFieldName(), null);
string newAlternateName = "New Alternate Name";
this.textField.SetAlternateFieldName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", newAlternateName));
global::DripSharp.Testing.JavaAssertions.Equal(newAlternateName, this.textField.GetAlternateFieldName(), null);
}

internal virtual void testMappingName() {
global::DripSharp.Testing.JavaAssertions.Null(this.textField.GetMappingName(), null);
string mappingName = "mappingName";
this.textField.SetMappingName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", mappingName));
global::DripSharp.Testing.JavaAssertions.Equal(mappingName, this.textField.GetMappingName(), null);
string newMappingName = "newMappingName";
this.textField.SetMappingName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", newMappingName));
global::DripSharp.Testing.JavaAssertions.Equal(newMappingName, this.textField.GetMappingName(), null);
}

internal virtual void testReadOnlyFlag() {
global::DripSharp.Testing.JavaAssertions.False(this.textField.IsReadOnly(), null);
this.textField.SetReadOnly(true);
global::DripSharp.Testing.JavaAssertions.True(this.textField.IsReadOnly(), null);
this.textField.SetReadOnly(false);
global::DripSharp.Testing.JavaAssertions.False(this.textField.IsReadOnly(), null);
}

internal virtual void testRequiredFlag() {
global::DripSharp.Testing.JavaAssertions.False(this.textField.IsRequired(), null);
this.textField.SetRequired(true);
global::DripSharp.Testing.JavaAssertions.True(this.textField.IsRequired(), null);
this.textField.SetRequired(false);
global::DripSharp.Testing.JavaAssertions.False(this.textField.IsRequired(), null);
}

internal virtual void testNoExportFlag() {
global::DripSharp.Testing.JavaAssertions.False(this.textField.IsNoExport(), null);
this.textField.SetNoExport(true);
global::DripSharp.Testing.JavaAssertions.True(this.textField.IsNoExport(), null);
this.textField.SetNoExport(false);
global::DripSharp.Testing.JavaAssertions.False(this.textField.IsNoExport(), null);
}

internal virtual void testMultipleFlagsIndependently() {
this.textField.SetReadOnly(true);
this.textField.SetRequired(true);
this.textField.SetNoExport(false);
global::DripSharp.Testing.JavaAssertions.True(this.textField.IsReadOnly(), null);
global::DripSharp.Testing.JavaAssertions.True(this.textField.IsRequired(), null);
global::DripSharp.Testing.JavaAssertions.False(this.textField.IsNoExport(), null);
this.textField.SetReadOnly(false);
global::DripSharp.Testing.JavaAssertions.False(this.textField.IsReadOnly(), null);
global::DripSharp.Testing.JavaAssertions.True(this.textField.IsRequired(), null);
global::DripSharp.Testing.JavaAssertions.False(this.textField.IsNoExport(), null);
}

internal virtual void testSetFieldFlagsZeroAndClearing() {
this.textField.SetReadOnly(true);
this.textField.SetRequired(true);
this.textField.SetNoExport(true);
global::DripSharp.Testing.JavaAssertions.True(this.textField.IsReadOnly(), null);
global::DripSharp.Testing.JavaAssertions.True(this.textField.IsRequired(), null);
global::DripSharp.Testing.JavaAssertions.True(this.textField.IsNoExport(), null);
this.textField.SetFieldFlags(0);
global::DripSharp.Testing.JavaAssertions.False(this.textField.IsReadOnly(), null);
global::DripSharp.Testing.JavaAssertions.False(this.textField.IsRequired(), null);
global::DripSharp.Testing.JavaAssertions.False(this.textField.IsNoExport(), null);
global::DripSharp.Testing.JavaAssertions.Equal(0, this.textField.GetFieldFlags(), null);
}

internal virtual void testGetFieldType() {
string fieldType = this.textField.GetFieldType();
global::DripSharp.Testing.JavaAssertions.NotNull(fieldType, null);
global::DripSharp.Testing.JavaAssertions.Equal("Tx", fieldType, null);
}

internal virtual void testSetValueAndGetValueAsString() {
global::DripSharp.Testing.JavaAssertions.Equal("", this.textField.GetValueAsString(), null);
}

internal virtual void testGetWidgets() {
global::DripSharp.Testing.JavaAssertions.NotNull(this.textField.GetWidgets(), null);
global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.Runtime.JavaCompat.CollectionCount(this.textField.GetWidgets()) >= 0), null);
}

internal virtual void testGetActionsNonNull() {
global::DripSharp.Testing.JavaAssertions.Null(this.textField.GetActions(), null);
global::DripSharp.PdfCarton.Cos.COSDictionary aaDict = new global::DripSharp.PdfCarton.Cos.COSDictionary();
this.textField.GetCOSObject().SetItem(global::DripSharp.PdfCarton.Cos.COSName.Aa, aaDict);
global::DripSharp.Testing.JavaAssertions.NotNull(this.textField.GetActions(), null);
}

internal virtual void testToStringWithValue() {
this.textField.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "fieldWithValue"));
string stringRepresentation = this.textField.ToString();
global::DripSharp.Testing.JavaAssertions.NotNull(stringRepresentation, null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(stringRepresentation, "PDTextField"), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(stringRepresentation, "fieldWithValue"), null);
}

internal virtual void testGetAcroForm() {
global::DripSharp.Testing.JavaAssertions.NotNull(this.textField.GetAcroForm(), null);
global::DripSharp.Testing.JavaAssertions.Equal(this.acroForm, this.textField.GetAcroForm(), null);
}

internal virtual void testGetParent() {
global::DripSharp.Testing.JavaAssertions.Null(this.textField.GetParent(), null);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDNonTerminalField parent = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDNonTerminalField(this.acroForm);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField childField = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(this.acroForm, new global::DripSharp.PdfCarton.Cos.COSDictionary(), parent);
global::DripSharp.Testing.JavaAssertions.Equal(parent, childField.GetParent(), null);
}

internal virtual void testGetCOSObject() {
global::DripSharp.Testing.JavaAssertions.NotNull(this.textField.GetCOSObject(), null);
global::DripSharp.Testing.JavaAssertions.True((this.textField.GetCOSObject() is global::DripSharp.PdfCarton.Cos.COSDictionary), null);
}

internal virtual void testEquals() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField field1 = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(this.acroForm);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField field2 = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(this.acroForm);
field1.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "testField"));
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField field3 = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(this.acroForm, field1.GetCOSObject(), (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDNonTerminalField)default!);
global::DripSharp.Testing.JavaAssertions.Equal(field1, field3, null);
field2.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "differentField"));
global::DripSharp.Testing.JavaAssertions.NotEqual(field1, field2, null);
global::DripSharp.Testing.JavaAssertions.Equal(field1, field1, null);
global::DripSharp.Testing.JavaAssertions.NotNull(field1, null);
global::DripSharp.Testing.JavaAssertions.NotEqual(field1, "not a field", null);
}

internal virtual void testHashCode() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField field1 = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(this.acroForm);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField field2 = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(this.acroForm, field1.GetCOSObject(), (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDNonTerminalField)default!);
global::DripSharp.Testing.JavaAssertions.Equal(field1.GetHashCode(), field2.GetHashCode(), null);
int hashCode1 = field1.GetHashCode();
int hashCode2 = field1.GetHashCode();
global::DripSharp.Testing.JavaAssertions.Equal(hashCode1, hashCode2, null);
}

internal virtual void testToString() {
this.textField.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "myField"));
string stringRepresentation = this.textField.ToString();
global::DripSharp.Testing.JavaAssertions.NotNull(stringRepresentation, null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(stringRepresentation, "myField"), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(stringRepresentation, "PDTextField"), null);
}

internal virtual void testGetActions() {
global::DripSharp.Testing.JavaAssertions.Null(this.textField.GetActions(), null);
}

internal virtual void testMultiplePropertiesTogether() {
this.textField.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "complexField"));
this.textField.SetAlternateFieldName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Complex Field"));
this.textField.SetMappingName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "complex_field"));
this.textField.SetReadOnly(true);
this.textField.SetRequired(true);
global::DripSharp.Testing.JavaAssertions.Equal("complexField", this.textField.GetPartialName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Complex Field", this.textField.GetAlternateFieldName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("complex_field", this.textField.GetMappingName(), null);
global::DripSharp.Testing.JavaAssertions.True(this.textField.IsReadOnly(), null);
global::DripSharp.Testing.JavaAssertions.True(this.textField.IsRequired(), null);
}

[Xunit.Fact]
public void __Upstream_3708423037_ccaf19cca3e48cf9()
{
        this.setUp();
        try
        {
            this.testAlternateFieldName();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3471735537_cf38b39770e93d56()
{
        this.setUp();
        try
        {
            this.testEquals();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0718170575_739dd6bd4ab960b7()
{
        this.setUp();
        try
        {
            this.testFullyQualifiedName();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_1605213654_4f1a5980aca17463()
{
        this.setUp();
        try
        {
            this.testFullyQualifiedNameNullPartialName();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_2788362303_b275d94c12db26b2()
{
        this.setUp();
        try
        {
            this.testFullyQualifiedNameWithParent();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_1856799943_c7abed9f8670d0e1()
{
        this.setUp();
        try
        {
            this.testGetAcroForm();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_1308530425_99a04f865b15335c()
{
        this.setUp();
        try
        {
            this.testGetActions();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_1951702203_6552e5b04a859862()
{
        this.setUp();
        try
        {
            this.testGetActionsNonNull();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3571534498_8609c6296a4feefc()
{
        this.setUp();
        try
        {
            this.testGetCOSObject();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0139220560_e756644e8e216fc7()
{
        this.setUp();
        try
        {
            this.testGetFieldType();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3517778734_5dc5b7d722c58b32()
{
        this.setUp();
        try
        {
            this.testGetParent();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3810671787_fc025227df573a2c()
{
        this.setUp();
        try
        {
            this.testGetWidgets();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3009520333_9d8f935e91efe6c9()
{
        this.setUp();
        try
        {
            this.testHashCode();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0307045511_e5138a0b2e515592()
{
        this.setUp();
        try
        {
            this.testMappingName();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3021295522_9c179a6798327ab4()
{
        this.setUp();
        try
        {
            this.testMultipleFlagsIndependently();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3302046959_f55447a4a0511a8b()
{
        this.setUp();
        try
        {
            this.testMultiplePropertiesTogether();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0506939283_b2b555a1767530b9()
{
        this.setUp();
        try
        {
            this.testNoExportFlag();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_2199929786_ee3225d8a705f558()
{
        this.setUp();
        try
        {
            this.testPartialName();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0491545390_86be84a337b68ac4()
{
        this.setUp();
        try
        {
            this.testPartialNameWithPeriodThrows();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3956994720_a6c311d67f5b8b78()
{
        this.setUp();
        try
        {
            this.testReadOnlyFlag();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_1549469021_0eb375e3111ce515()
{
        this.setUp();
        try
        {
            this.testRequiredFlag();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_4158908327_25b11a5e935f4677()
{
        this.setUp();
        try
        {
            this.testSetFieldFlagsZeroAndClearing();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0262190356_522ea2819f2d440c()
{
        this.setUp();
        try
        {
            this.testSetValueAndGetValueAsString();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_1084901662_0c51109f9de73ad4()
{
        this.setUp();
        try
        {
            this.testToString();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_0499430605_4d7eef1292b35e5c()
{
        this.setUp();
        try
        {
            this.testToStringWithValue();
        }
        finally
        {
            this.tearDown();
        }
}
}
