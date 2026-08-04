// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdfwriter;

public class COSDocumentCompressionTest {
private static readonly global::System.IO.FileInfo INDIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "src/test/resources/input/compression/"));

private static readonly global::System.IO.FileInfo OUTDIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output/compression/"));

internal static void init() {
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.OUTDIR);
}

internal virtual void testCompressAcroformDoc() {
global::System.IO.FileInfo source = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.INDIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "acroform.pdf")));
global::System.IO.FileInfo target = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.OUTDIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "acroform.pdf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__75_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(source)) {
document__75_25.Save(target);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__80_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(target)) {
global::DripSharp.Testing.JavaAssertions.Equal(1, document__80_25.GetNumberOfPages(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The number of pages should not have changed, during compression."));
global::DripSharp.PdfCarton.Pdmodel.PDPage page = document__80_25.GetPage(0);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotations = page.GetAnnotations();
global::DripSharp.Testing.JavaAssertions.Equal(13, global::DripSharp.Runtime.JavaCompat.CollectionCount(annotations), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The number of annotations should not have changed"));
global::DripSharp.Testing.JavaAssertions.Equal("TextField", global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 0).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The 1. annotation should have been a text field."));
global::DripSharp.Testing.JavaAssertions.Equal("Button", global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 1).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The 2. annotation should have been a button."));
global::DripSharp.Testing.JavaAssertions.Equal("CheckBox1", global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 2).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The 3. annotation should have been a checkbox."));
global::DripSharp.Testing.JavaAssertions.Equal("CheckBox2", global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 3).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The 4. annotation should have been a checkbox."));
global::DripSharp.Testing.JavaAssertions.Equal("TextFieldMultiLine", global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 4).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The 5. annotation should have been a multiline textfield."));
global::DripSharp.Testing.JavaAssertions.Equal("TextFieldMultiLineRT", global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 5).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The 6. annotation should have been a multiline textfield."));
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 6).GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Parent), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The 7. annotation should have had a parent entry."));
global::DripSharp.Testing.JavaAssertions.Equal("GroupOption", global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 6).GetCOSObject().GetCOSDictionary(global::DripSharp.PdfCarton.Cos.COSName.Parent).GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The 7. annotation's parent should have been a GroupOption."));
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 7).GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Parent), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The 8. annotation should have had a parent entry."));
global::DripSharp.Testing.JavaAssertions.Equal("GroupOption", global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 7).GetCOSObject().GetCOSDictionary(global::DripSharp.PdfCarton.Cos.COSName.Parent).GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The 8. annotation's parent should have been a GroupOption."));
global::DripSharp.Testing.JavaAssertions.Equal("ListBox", global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 8).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The 9. annotation should have been a ListBox."));
global::DripSharp.Testing.JavaAssertions.Equal("ListBoxMultiSelect", global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 9).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The 10. annotation should have been a ListBox Multiselect."));
global::DripSharp.Testing.JavaAssertions.Equal("ComboBox", global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 10).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The 11. annotation should have been a ComboBox."));
global::DripSharp.Testing.JavaAssertions.Equal("ComboBoxEditable", global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 11).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The 12. annotation should have been a EditableComboBox."));
global::DripSharp.Testing.JavaAssertions.Equal("Signature", global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 12).GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.T), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The 13. annotation should have been a Signature."));
}
}

internal virtual void testCompressAttachmentsDoc() {
global::System.IO.FileInfo source = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.INDIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "attachment.pdf")));
global::System.IO.FileInfo target = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.OUTDIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "attachment.pdf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__140_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(source)) {
document__140_25.Save(target);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__145_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(target)) {
global::DripSharp.Testing.JavaAssertions.Equal(2, document__145_25.GetNumberOfPages(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The number of pages should not have changed, during compression."));
global::System.Collections.Generic.IDictionary<string, global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDComplexFileSpecification> embeddedFiles = document__145_25.GetDocumentCatalog().GetNames().GetEmbeddedFiles().GetNames();
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.MapCount(embeddedFiles), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The document should have contained an attachment"));
global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDComplexFileSpecification attachment;
global::DripSharp.Testing.JavaAssertions.NotNull((attachment = global::DripSharp.Runtime.JavaCompat.MapGet(embeddedFiles, "A4Unicode.pdf")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The document should have contained 'A4Unicode.pdf'."));
global::DripSharp.Testing.JavaAssertions.Equal(14997, attachment.GetEmbeddedFile().GetLength(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The attachments length is not as expected."));
}
}

internal virtual void testCompressEncryptedDoc() {
global::System.IO.FileInfo source = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.INDIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "unencrypted.pdf")));
global::System.IO.FileInfo target = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.OUTDIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "encrypted.pdf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__172_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(source, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "user"))) {
document__172_25.Protect(new global::DripSharp.PdfCarton.Pdmodel.Encryption.StandardProtectionPolicy(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "owner"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "user"), new global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission(0)));
document__172_25.Save(target);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__179_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(target, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "user"))) {
global::DripSharp.Testing.JavaAssertions.Equal(2, document__179_25.GetNumberOfPages(), null);
}
}

internal virtual void testAlteredDoc() {
global::System.IO.FileInfo source = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.INDIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "unencrypted.pdf")));
global::System.IO.FileInfo target = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdfwriter.COSDocumentCompressionTest.OUTDIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "altered.pdf")));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__197_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(source)) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page__199_20 = new global::DripSharp.PdfCarton.Pdmodel.PDPage(new global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle((float)(100), (float)(100)));
document__197_25.AddPage(page__199_20);
using (global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(document__197_25, page__199_20)) {
contentStream.BeginText();
contentStream.NewLineAtOffset((float)(20), (float)(80));
contentStream.SetFont(new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica), (float)(12));
contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Test"));
contentStream.EndText();
}
document__197_25.Save(target);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document__214_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(target)) {
global::DripSharp.Testing.JavaAssertions.Equal(3, document__214_25.GetNumberOfPages(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The number of pages should not have changed, during compression."));
global::DripSharp.PdfCarton.Pdmodel.PDPage page__218_20 = document__214_25.GetPage(2);
global::DripSharp.Testing.JavaAssertions.Equal(43, (page__218_20.GetContentStreams()).Next()!.GetLength(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The stream length of the new page is not as expected."));
}
}

internal virtual void testPDFBox5927() {
global::DripSharp.Runtime.JavaByteArrayOutputStream baos = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__234_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/pdfs"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-5927.pdf")))) {
doc__234_25.Save(baos);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__238_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos))) {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm = doc__238_25.GetDocumentCatalog().GetAcroForm();
global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox cb = (global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDCheckBox)(acroForm.GetField(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "chkPrivacy1"))!);
global::DripSharp.Testing.JavaAssertions.True(cb.IsChecked(), null);
}
}

[Xunit.Fact]
public void __Upstream_0726120437_ed8b8771c1b74948()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testAlteredDoc();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3478546529_c51987dfa3675c89()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCompressAcroformDoc();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2291719836_18e4187e1b8afa4a()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCompressAttachmentsDoc();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4197713160_ff63bba101d9b94d()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testCompressEncryptedDoc();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1724611860_d67e073d100289a6()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        try
        {
            this.testPDFBox5927();
        }
        finally
        {
        }
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    init();
    return true;
}
}
