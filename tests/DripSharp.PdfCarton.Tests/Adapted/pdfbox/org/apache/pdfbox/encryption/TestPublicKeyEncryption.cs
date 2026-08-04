// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Encryption;

public class TestPublicKeyEncryption {
private static readonly global::System.IO.FileInfo TESTRESULTSDIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output/crypto"));

private global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission permission1 = null!;

private global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission permission2 = null!;

private global::DripSharp.PdfCarton.Pdmodel.Encryption.PublicKeyRecipient recipient1 = null!;

private global::DripSharp.PdfCarton.Pdmodel.Encryption.PublicKeyRecipient recipient2 = null!;

private string keyStore1 = null!;

private string keyStore2 = null!;

private string password1 = null!;

private string password2 = null!;

private global::DripSharp.PdfCarton.Pdmodel.PDDocument document = null!;

private string text = null!;

private string producer = null!;

public int KeyLength = default;

public static global::System.Collections.Generic.ICollection<int> KeyLengths() {
return global::DripSharp.Runtime.JavaCompat.AsList<int>(40, 128, 256);
}

internal static void init() {
global::DripSharp.Testing.JavaAssertions.Equal(int.MaxValue, global::DripSharp.Runtime.JavaCipher.GetMaxAllowedKeyLength(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "AES")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "JCE unlimited strength jurisdiction policy files are not installed"));
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Encryption.TestPublicKeyEncryption.TESTRESULTSDIR);
}

internal virtual void setUp() {
this.permission1 = new global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission();
this.permission1.SetCanAssembleDocument(false);
this.permission1.SetCanExtractContent(false);
this.permission1.SetCanExtractForAccessibility(true);
this.permission1.SetCanFillInForm(false);
this.permission1.SetCanModify(false);
this.permission1.SetCanModifyAnnotations(false);
this.permission1.SetCanPrint(false);
this.permission1.SetCanPrintFaithful(false);
this.permission2 = new global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission();
this.permission2.SetCanAssembleDocument(false);
this.permission2.SetCanExtractContent(false);
this.permission2.SetCanExtractForAccessibility(true);
this.permission2.SetCanFillInForm(false);
this.permission2.SetCanModify(false);
this.permission2.SetCanModifyAnnotations(false);
this.permission2.SetCanPrint(true);
this.permission2.SetCanPrintFaithful(false);
this.recipient1 = global::DripSharp.PdfCarton.Encryption.TestPublicKeyEncryption.getRecipient(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "test1.der"), this.permission1);
this.recipient2 = global::DripSharp.PdfCarton.Encryption.TestPublicKeyEncryption.getRecipient(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "test2.der"), this.permission2);
this.password1 = "test1";
this.password2 = "test2";
this.keyStore1 = "test1.pfx";
this.keyStore2 = "test2.pfx";
this.document = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "test.pdf"))));
this.text = new global::DripSharp.PdfCarton.Text.PDFTextStripper().GetText(this.document);
this.producer = this.document.GetDocumentInformation().GetProducer();
this.document.SetVersion(1.7F);
}

internal virtual void tearDown() {
this.document.Dispose();
}

internal virtual void testProtectionError(int keyLength) {
global::DripSharp.PdfCarton.Pdmodel.Encryption.PublicKeyProtectionPolicy policy = new global::DripSharp.PdfCarton.Pdmodel.Encryption.PublicKeyProtectionPolicy();
policy.AddRecipient(this.recipient1);
policy.SetEncryptionKeyLength(keyLength);
this.document.Protect(policy);
global::System.IO.FileInfo file = this.save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "testProtectionError"));
global::System.IO.IOException ex = global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => this.reload(file, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", this.password2), this.getKeyStore(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", this.keyStore2))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "No exception when using an incorrect decryption key"));
string msg = global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(msg, "serial-#: rid 2 vs. cert 3"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("not the expected exception: ", msg)));
}

internal virtual void testProtection(int keyLength) {
global::DripSharp.PdfCarton.Pdmodel.Encryption.PublicKeyProtectionPolicy policy = new global::DripSharp.PdfCarton.Pdmodel.Encryption.PublicKeyProtectionPolicy();
policy.AddRecipient(this.recipient1);
policy.SetEncryptionKeyLength(keyLength);
this.document.Protect(policy);
global::System.IO.FileInfo file = this.save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "testProtection"));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument encryptedDoc = this.reload(file, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", this.password1), this.getKeyStore(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", this.keyStore1)))) {
global::DripSharp.Testing.JavaAssertions.True(encryptedDoc.IsEncrypted(), null);
global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission permission = encryptedDoc.GetCurrentAccessPermission();
global::DripSharp.Testing.JavaAssertions.False(permission.CanAssembleDocument(), null);
global::DripSharp.Testing.JavaAssertions.False(permission.CanExtractContent(), null);
global::DripSharp.Testing.JavaAssertions.True(permission.CanExtractForAccessibility(), null);
global::DripSharp.Testing.JavaAssertions.False(permission.CanFillInForm(), null);
global::DripSharp.Testing.JavaAssertions.False(permission.CanModify(), null);
global::DripSharp.Testing.JavaAssertions.False(permission.CanModifyAnnotations(), null);
global::DripSharp.Testing.JavaAssertions.False(permission.CanPrint(), null);
global::DripSharp.Testing.JavaAssertions.False(permission.CanPrintFaithful(), null);
}
}

internal virtual void testMultipleRecipients(int keyLength) {
global::DripSharp.PdfCarton.Pdmodel.Encryption.PublicKeyProtectionPolicy policy = new global::DripSharp.PdfCarton.Pdmodel.Encryption.PublicKeyProtectionPolicy();
policy.AddRecipient(this.recipient1);
policy.AddRecipient(this.recipient2);
policy.SetEncryptionKeyLength(keyLength);
this.document.Protect(policy);
global::System.IO.FileInfo file = this.save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "testMultipleRecipients"));
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument encryptedDoc1 = this.reload(file, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", this.password1), this.getKeyStore(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", this.keyStore1)))) {
global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission permission__230_30 = encryptedDoc1.GetCurrentAccessPermission();
global::DripSharp.Testing.JavaAssertions.False(permission__230_30.CanAssembleDocument(), null);
global::DripSharp.Testing.JavaAssertions.False(permission__230_30.CanExtractContent(), null);
global::DripSharp.Testing.JavaAssertions.True(permission__230_30.CanExtractForAccessibility(), null);
global::DripSharp.Testing.JavaAssertions.False(permission__230_30.CanFillInForm(), null);
global::DripSharp.Testing.JavaAssertions.False(permission__230_30.CanModify(), null);
global::DripSharp.Testing.JavaAssertions.False(permission__230_30.CanModifyAnnotations(), null);
global::DripSharp.Testing.JavaAssertions.False(permission__230_30.CanPrint(), null);
global::DripSharp.Testing.JavaAssertions.False(permission__230_30.CanPrintFaithful(), null);
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument encryptedDoc2 = this.reload(file, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", this.password2), this.getKeyStore(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", this.keyStore2)))) {
global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission permission__244_30 = encryptedDoc2.GetCurrentAccessPermission();
global::DripSharp.Testing.JavaAssertions.False(permission__244_30.CanAssembleDocument(), null);
global::DripSharp.Testing.JavaAssertions.False(permission__244_30.CanExtractContent(), null);
global::DripSharp.Testing.JavaAssertions.True(permission__244_30.CanExtractForAccessibility(), null);
global::DripSharp.Testing.JavaAssertions.False(permission__244_30.CanFillInForm(), null);
global::DripSharp.Testing.JavaAssertions.False(permission__244_30.CanModify(), null);
global::DripSharp.Testing.JavaAssertions.False(permission__244_30.CanModifyAnnotations(), null);
global::DripSharp.Testing.JavaAssertions.True(permission__244_30.CanPrint(), null);
global::DripSharp.Testing.JavaAssertions.False(permission__244_30.CanPrintFaithful(), null);
}
}

private global::DripSharp.PdfCarton.Pdmodel.PDDocument reload(global::System.IO.FileInfo file, string decryptionPassword, global::System.IO.Stream keyStore) {
global::DripSharp.PdfCarton.Pdmodel.PDDocument doc2 = global::DripSharp.PdfCarton.Loader.LoadPDF(file, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", decryptionPassword), keyStore, (string)default!, global::DripSharp.PdfCarton.IO.IOUtils.CreateMemoryOnlyStreamCache());
global::DripSharp.Testing.JavaAssertions.Equal(this.text, new global::DripSharp.PdfCarton.Text.PDFTextStripper().GetText(doc2), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Extracted text is different"));
global::DripSharp.Testing.JavaAssertions.Equal(this.producer, doc2.GetDocumentInformation().GetProducer(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Producer is different"));
return doc2;
}

private static global::DripSharp.PdfCarton.Pdmodel.Encryption.PublicKeyRecipient getRecipient(string certificate, global::DripSharp.PdfCarton.Pdmodel.Encryption.AccessPermission permission) {
using (global::System.IO.Stream input = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Encryption.TestPublicKeyEncryption), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", certificate))) {
global::DripSharp.Runtime.JavaCertificateFactory factory = global::DripSharp.Runtime.JavaCertificateFactory.GetInstance(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "X.509"));
global::DripSharp.PdfCarton.Pdmodel.Encryption.PublicKeyRecipient recipient = new global::DripSharp.PdfCarton.Pdmodel.Encryption.PublicKeyRecipient();
recipient.SetPermission(permission);
recipient.SetX509((global::System.Security.Cryptography.X509Certificates.X509Certificate2)(factory.GenerateCertificate(input)!));
return recipient;
}
}

private global::System.IO.Stream getKeyStore(string name) {
return global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Encryption.TestPublicKeyEncryption), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", name));
}

private global::System.IO.FileInfo save(string name) {
global::System.IO.FileInfo file = new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Encryption.TestPublicKeyEncryption.TESTRESULTSDIR).FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(name, "-"), this.KeyLength), "bit.pdf"))));
this.document.Save(file);
return file;
}

internal virtual void testReadPubkeyEncryptedAES128() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Encryption.TestPublicKeyEncryption), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "AESkeylength128.pdf"))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "w!z%C*F-JaNdRgUk"), global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Encryption.TestPublicKeyEncryption), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4421-keystore.pfx")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "testnutzer"))) {
global::DripSharp.Testing.JavaAssertions.Equal("PublicKeySecurityHandler", ((object)(doc.GetEncryption().GetSecurityHandler())).GetType().Name, null);
global::DripSharp.Testing.JavaAssertions.Equal(128, doc.GetEncryption().GetSecurityHandler().GetKeyLength(), null);
global::DripSharp.PdfCarton.Text.PDFTextStripper stripper = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
global::DripSharp.Testing.JavaAssertions.Equal("Key length: 128", global::DripSharp.Runtime.JavaCompat.StringTrim(stripper.GetText(doc)), null);
}
}

internal virtual void testReadPubkeyEncryptedAES256() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Encryption.TestPublicKeyEncryption), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "AESkeylength256.pdf"))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "w!z%C*F-JaNdRgUk"), global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Encryption.TestPublicKeyEncryption), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4421-keystore.pfx")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "testnutzer"))) {
global::DripSharp.Testing.JavaAssertions.Equal("PublicKeySecurityHandler", ((object)(doc.GetEncryption().GetSecurityHandler())).GetType().Name, null);
global::DripSharp.Testing.JavaAssertions.Equal(256, doc.GetEncryption().GetSecurityHandler().GetKeyLength(), null);
global::DripSharp.PdfCarton.Text.PDFTextStripper stripper = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
global::DripSharp.Testing.JavaAssertions.Equal("Key length: 256", global::DripSharp.Runtime.JavaCompat.StringTrim(stripper.GetText(doc)), null);
}
}

internal virtual void testReadPubkeyEncryptedAES128withMetadataExposed() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Encryption.TestPublicKeyEncryption), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "AES128ExposedMeta.pdf"))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ""), global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Encryption.TestPublicKeyEncryption), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-5249.p12")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "test"), global::DripSharp.PdfCarton.IO.IOUtils.CreateMemoryOnlyStreamCache())) {
global::DripSharp.Testing.JavaAssertions.Equal("PublicKeySecurityHandler", ((object)(doc.GetEncryption().GetSecurityHandler())).GetType().Name, null);
global::DripSharp.Testing.JavaAssertions.Equal(128, doc.GetEncryption().GetSecurityHandler().GetKeyLength(), null);
global::DripSharp.PdfCarton.Text.PDFTextStripper stripper = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
stripper.SetLineSeparator(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "\n"));
global::DripSharp.Testing.JavaAssertions.Equal("AES key length: 128\nwith exposed Metadata", global::DripSharp.Runtime.JavaCompat.StringTrim(stripper.GetText(doc)), null);
}
}

internal virtual void testReadPubkeyEncryptedAES256withMetadataExposed() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Encryption.TestPublicKeyEncryption), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "AES256ExposedMeta.pdf"))), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ""), global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Encryption.TestPublicKeyEncryption), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-5249.p12")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "test"), global::DripSharp.PdfCarton.IO.IOUtils.CreateMemoryOnlyStreamCache())) {
global::DripSharp.Testing.JavaAssertions.Equal("PublicKeySecurityHandler", ((object)(doc.GetEncryption().GetSecurityHandler())).GetType().Name, null);
global::DripSharp.Testing.JavaAssertions.Equal(256, doc.GetEncryption().GetSecurityHandler().GetKeyLength(), null);
global::DripSharp.PdfCarton.Text.PDFTextStripper stripper = new global::DripSharp.PdfCarton.Text.PDFTextStripper();
stripper.SetLineSeparator(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "\n"));
global::DripSharp.Testing.JavaAssertions.Equal("AES key length: 256 \nwith exposed Metadata", global::DripSharp.Runtime.JavaCompat.StringTrim(stripper.GetText(doc)), null);
}
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_2c082531643b0510()
{
    foreach (var value in KeyLengths())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<int>(row[0]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_b1cfaad308091038()
{
    foreach (var value in KeyLengths())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<int>(row[0]) };
    }
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_6257d1474cd639dc()
{
    foreach (var value in KeyLengths())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<int>(row[0]) };
    }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_2c082531643b0510))]
public void __Upstream_3873947612_1d92c973610ae4f0(int keyLength)
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        this.setUp();
        try
        {
            this.testMultipleRecipients(keyLength);
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_b1cfaad308091038))]
public void __Upstream_4043582731_c225ac39cbf30c9b(int keyLength)
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        this.setUp();
        try
        {
            this.testProtection(keyLength);
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_6257d1474cd639dc))]
public void __Upstream_4065797053_b63e19420a290445(int keyLength)
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        this.setUp();
        try
        {
            this.testProtectionError(keyLength);
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3601995490_f0f6d7d426d86ab3()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        this.setUp();
        try
        {
            this.testReadPubkeyEncryptedAES128();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3262868265_fe3b991382e55840()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        this.setUp();
        try
        {
            this.testReadPubkeyEncryptedAES128withMetadataExposed();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_3601996542_87034bfeb367923c()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        this.setUp();
        try
        {
            this.testReadPubkeyEncryptedAES256();
        }
        finally
        {
            this.tearDown();
        }
}

[Xunit.Fact]
public void __Upstream_2676513165_01223b56d2f2e7dd()
{
        if (!__UpstreamBeforeAll)
            throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
        this.setUp();
        try
        {
            this.testReadPubkeyEncryptedAES256withMetadataExposed();
        }
        finally
        {
            this.tearDown();
        }
}

private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

private static bool __RunUpstreamBeforeAll()
{
    init();
    return true;
}
}
