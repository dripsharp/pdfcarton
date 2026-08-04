// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel;

public class TestFDF {
internal virtual void testLoad2() {
this.checkFields(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "/org/apache/pdfbox/pdfparser/withcatalog.fdf"));
this.checkFields(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "/org/apache/pdfbox/pdfparser/nocatalog.fdf"));
}

internal virtual void testPDFBox5894() {
using (global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFDocument fdf = global::DripSharp.PdfCarton.Loader.LoadFDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/pdfs/PDFBOX-5894.fdf")))) {
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Cos.COSObject> objectsByType = fdf.GetDocument().GetObjectsByType(global::DripSharp.PdfCarton.Cos.COSName.Annot);
global::DripSharp.Testing.JavaAssertions.Equal(4, global::DripSharp.Runtime.JavaCompat.CollectionCount(objectsByType), null);
foreach (global::DripSharp.PdfCarton.Cos.COSObject obj in objectsByType) {
global::DripSharp.PdfCarton.Cos.COSBase @base = obj.GetObject();
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Annot, ((global::DripSharp.PdfCarton.Cos.COSDictionary)(@base!)).GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.Type), null);
}
}
}

private void checkFields(string name) {
using (global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFDocument fdf = global::DripSharp.PdfCarton.Loader.LoadFDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.TestFDF), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", name))))) {
fdf.SaveXFDF(new global::System.IO.StreamWriter(new global::DripSharp.Runtime.JavaByteArrayOutputStream(), global::System.Text.Encoding.UTF8, 1024, false));
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFField> fields = fdf.GetCatalog().GetFDF().GetFields();
global::DripSharp.Testing.JavaAssertions.Equal(2, global::DripSharp.Runtime.JavaCompat.CollectionCount(fields), null);
global::DripSharp.Testing.JavaAssertions.Equal("Field1", global::DripSharp.Runtime.JavaCompat.ListGet(fields, 0).GetPartialFieldName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Field2", global::DripSharp.Runtime.JavaCompat.ListGet(fields, 1).GetPartialFieldName(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Test1", global::DripSharp.Runtime.JavaCompat.ListGet(fields, 0).GetValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Test2", global::DripSharp.Runtime.JavaCompat.ListGet(fields, 1).GetValue(), null);
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument pdf = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.TestFDF), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "/org/apache/pdfbox/pdfparser/SimpleForm2Fields.pdf"))))) {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = pdf.GetDocumentCatalog().GetAcroForm();
acroForm.ImportFDF(fdf);
global::DripSharp.Testing.JavaAssertions.Equal("Test1", acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Field1")).GetValueAsString(), null);
global::DripSharp.Testing.JavaAssertions.Equal("Test2", acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Field2")).GetValueAsString(), null);
}
}
}

[Xunit.Fact]
public void __Upstream_0949661338_c35e7bd329b2edc7()
{
        try
        {
            this.testLoad2();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1724611113_e3ae5e885cc81e41()
{
        try
        {
            this.testPDFBox5894();
        }
        finally
        {
        }
}
}
