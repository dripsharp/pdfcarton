// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Metadata;

public class TestSynchronizedMetadataValidation {
  protected internal global::DripSharp.PdfCarton.Pdmodel.PDDocument Doc = null!;

  protected internal global::DripSharp.PdfCarton.Pdmodel.PDDocumentInformation Dico = null!;

  protected internal global::DripSharp.PdfCarton.Xmp.XMPMetadata Metadata = null!;

  protected internal string Title = null!;

  protected internal string Author = null!;

  protected internal string Subject = null!;

  protected internal string Keywords = null!;

  protected internal string Creator = null!;

  protected internal string Producer = null!;

  protected internal global::System.DateTimeOffset? CreationDate = default;

  protected internal global::System.DateTimeOffset? ModifyDate = default;

  protected internal static global::DripSharp.PdfCarton.Preflight.Metadata.SynchronizedMetaDataValidation Sync
    = null!;

  protected internal global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError> Ve
    = null!;

  internal static void initSynchronizedMetadataValidation() {
    global::DripSharp.PdfCarton.Preflight.Metadata.TestSynchronizedMetadataValidation.Sync
      = new global::DripSharp.PdfCarton.Preflight.Metadata.SynchronizedMetaDataValidation();
  }

  internal virtual void initNewDocumentInformation() {
    this.Doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
    this.Dico = this.Doc.GetDocumentInformation();
    this.Metadata = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
  }

  internal virtual void TestNullDocument() {
    global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Preflight.Exception.ValidationException>(()
      => {
        global::DripSharp.PdfCarton.Preflight.Metadata.TestSynchronizedMetadataValidation.Sync.ValidateMetadataSynchronization((global::DripSharp.PdfCarton.Pdmodel.PDDocument)default!,
        this.Metadata);
      }, null);
  }

  internal virtual void TestNullMetaData() {
    global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Preflight.Exception.ValidationException>(()
      => {
        global::DripSharp.PdfCarton.Preflight.Metadata.TestSynchronizedMetadataValidation.Sync.ValidateMetadataSynchronization(this.Doc,
        (global::DripSharp.PdfCarton.Xmp.XMPMetadata)default!);
      }, null);
  }

  internal virtual void TestDocumentWithoutInformation() {
    try {
      this.Ve
        = global::DripSharp.PdfCarton.Preflight.Metadata.TestSynchronizedMetadataValidation.Sync.ValidateMetadataSynchronization(this.Doc,
        this.Metadata);
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(this.Ve), null);
    } catch (global::DripSharp.PdfCarton.Preflight.Exception.ValidationException e) {
      throw new global::System.Exception(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.Runtime.JavaCompat.ExceptionMessage(e)));
    }
  }

  internal virtual void testEmptyXMP() {
    this.initValues();
    this.Dico.SetTitle(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Title));
    this.Dico.SetAuthor(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Author));
    this.Dico.SetSubject(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Subject));
    this.Dico.SetKeywords(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Keywords));
    this.Dico.SetCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Creator));
    this.Dico.SetProducer(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Producer));
    this.Dico.SetCreationDate(this.CreationDate);
    this.Dico.SetModificationDate(this.ModifyDate);
    try {
      this.Ve
        = global::DripSharp.PdfCarton.Preflight.Metadata.TestSynchronizedMetadataValidation.Sync.ValidateMetadataSynchronization(this.Doc,
        this.Metadata);
      foreach (global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError valid in this.Ve) {
        global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorMetadataMismatch,
          valid.GetErrorCode(), null);
      }
    } catch (global::DripSharp.PdfCarton.Preflight.Exception.ValidationException e) {
      throw new global::System.Exception(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.Runtime.JavaCompat.ExceptionMessage(e)));
    }
  }

  internal virtual void testEmptyXMPSchemas() {
    this.initValues();
    this.Metadata.CreateAndAddDublinCoreSchema();
    this.Metadata.CreateAndAddAdobePDFSchema();
    this.Metadata.CreateAndAddXMPBasicSchema();
    this.Dico.SetTitle(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Title));
    this.Dico.SetAuthor(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Author));
    this.Dico.SetSubject(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Subject));
    this.Dico.SetKeywords(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Keywords));
    this.Dico.SetCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Creator));
    this.Dico.SetProducer(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Producer));
    this.Dico.SetCreationDate(this.CreationDate);
    this.Dico.SetModificationDate(this.ModifyDate);
    try {
      this.Ve
        = global::DripSharp.PdfCarton.Preflight.Metadata.TestSynchronizedMetadataValidation.Sync.ValidateMetadataSynchronization(this.Doc,
        this.Metadata);
      global::DripSharp.Testing.JavaAssertions.Equal(8,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(this.Ve), null);
    } catch (global::DripSharp.PdfCarton.Preflight.Exception.ValidationException e) {
      throw new global::System.Exception(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.Runtime.JavaCompat.ExceptionMessage(e)));
    }
  }

  internal virtual void testNullArrayValue() {
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dc
      = this.Metadata.CreateAndAddDublinCoreSchema();
    this.Dico.SetAuthor(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "dicoAuthor"));
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => {
        dc.AddCreator((string)default!);
      }, null);
    this.Dico.SetSubject(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "dicoSubj"));
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => {
        dc.AddSubject((string)default!);
      }, null);
    try {
      this.Ve
        = global::DripSharp.PdfCarton.Preflight.Metadata.TestSynchronizedMetadataValidation.Sync.ValidateMetadataSynchronization(this.Doc,
        this.Metadata);
      global::DripSharp.Testing.JavaAssertions.Equal(2,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(this.Ve), null);
    } catch (global::DripSharp.PdfCarton.Preflight.Exception.ValidationException e) {
      throw new global::System.Exception(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.Runtime.JavaCompat.ExceptionMessage(e)));
    }
  }

  internal virtual void testBadSizeOfArrays() {
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dc
      = this.Metadata.CreateAndAddDublinCoreSchema();
    global::DripSharp.PdfCarton.Xmp.Schema.AdobePDFSchema pdf
      = this.Metadata.CreateAndAddAdobePDFSchema();
    global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicSchema xmp
      = this.Metadata.CreateAndAddXMPBasicSchema();
    this.Dico.SetTitle(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "dicoTitle"));
    dc.SetTitle(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "x-default"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "XMPTitle"));
    this.Dico.SetAuthor(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "dicoAuthor"));
    dc.AddCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "XMPAuthor"));
    dc.AddCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "2ndCreator"));
    this.Dico.SetSubject(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "dicoSubj"));
    dc.AddSubject(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "XMPSubj"));
    dc.AddSubject(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "2ndSubj"));
    this.Dico.SetKeywords(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "DicoKeywords"));
    pdf.SetKeywords(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "XMPkeywords"));
    this.Dico.SetCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "DicoCreator"));
    xmp.SetCreatorTool(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "XMPCreator"));
    this.Dico.SetProducer(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "DicoProducer"));
    pdf.SetProducer(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "XMPProducer"));
    this.Dico.SetCreationDate(global::System.DateTimeOffset.Now);
    global::System.DateTimeOffset? XMPCreate
      = global::DripSharp.PdfCarton.Tests.Support.GregorianCalendar(2008, 11, 5);
    xmp.SetCreateDate(XMPCreate);
    this.Dico.SetModificationDate(global::System.DateTimeOffset.Now);
    global::System.DateTimeOffset? XMPModify
      = global::DripSharp.PdfCarton.Tests.Support.GregorianCalendar(2009, 10, 15);
    xmp.SetModifyDate(XMPModify);
    try {
      this.Ve
        = global::DripSharp.PdfCarton.Preflight.Metadata.TestSynchronizedMetadataValidation.Sync.ValidateMetadataSynchronization(this.Doc,
        this.Metadata);
      global::DripSharp.Testing.JavaAssertions.Equal(8,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(this.Ve), null);
    } catch (global::DripSharp.PdfCarton.Preflight.Exception.ValidationException e) {
      throw new global::System.Exception(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.Runtime.JavaCompat.ExceptionMessage(e)));
    }
  }

  internal virtual void testAllInfoUnsynchronized() {
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dc
      = this.Metadata.CreateAndAddDublinCoreSchema();
    global::DripSharp.PdfCarton.Xmp.Schema.AdobePDFSchema pdf
      = this.Metadata.CreateAndAddAdobePDFSchema();
    global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicSchema xmp
      = this.Metadata.CreateAndAddXMPBasicSchema();
    this.Dico.SetTitle(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "dicoTitle"));
    dc.SetTitle(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "x-default"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "XMPTitle"));
    this.Dico.SetAuthor(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "dicoAuthor"));
    dc.AddCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "XMPAuthor"));
    this.Dico.SetSubject(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "dicoSubj"));
    dc.AddSubject(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "XMPSubj"));
    this.Dico.SetKeywords(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "DicoKeywords"));
    pdf.SetKeywords(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "XMPkeywords"));
    this.Dico.SetCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "DicoCreator"));
    xmp.SetCreatorTool(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "XMPCreator"));
    this.Dico.SetProducer(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "DicoProducer"));
    pdf.SetProducer(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "XMPProducer"));
    this.Dico.SetCreationDate(global::System.DateTimeOffset.Now);
    global::System.DateTimeOffset? XMPCreate
      = global::DripSharp.PdfCarton.Tests.Support.GregorianCalendar(2008, 11, 5);
    xmp.SetCreateDate(XMPCreate);
    this.Dico.SetModificationDate(global::System.DateTimeOffset.Now);
    global::System.DateTimeOffset? XMPModify
      = global::DripSharp.PdfCarton.Tests.Support.GregorianCalendar(2009, 10, 15);
    xmp.SetModifyDate(XMPModify);
    try {
      this.Ve
        = global::DripSharp.PdfCarton.Preflight.Metadata.TestSynchronizedMetadataValidation.Sync.ValidateMetadataSynchronization(this.Doc,
        this.Metadata);
      global::DripSharp.Testing.JavaAssertions.Equal(8,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(this.Ve), null);
    } catch (global::DripSharp.PdfCarton.Preflight.Exception.ValidationException e) {
      throw new global::System.Exception(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.Runtime.JavaCompat.ExceptionMessage(e)));
    }
  }

  internal virtual void testAllInfoSynchronized() {
    this.initValues();
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dc
      = this.Metadata.CreateAndAddDublinCoreSchema();
    global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicSchema xmp
      = this.Metadata.CreateAndAddXMPBasicSchema();
    global::DripSharp.PdfCarton.Xmp.Schema.AdobePDFSchema pdf
      = this.Metadata.CreateAndAddAdobePDFSchema();
    this.Dico.SetTitle(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Title));
    dc.SetTitle(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "x-default"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Title));
    this.Dico.SetAuthor(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Author));
    dc.AddCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Author));
    this.Dico.SetSubject(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Subject));
    dc.AddDescription(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "x-default"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Subject));
    this.Dico.SetKeywords(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Keywords));
    pdf.SetKeywords(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Keywords));
    this.Dico.SetCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Creator));
    xmp.SetCreatorTool(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Creator));
    this.Dico.SetProducer(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Producer));
    pdf.SetProducer(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Producer));
    this.Dico.SetCreationDate(this.CreationDate);
    xmp.SetCreateDate(this.CreationDate);
    this.Dico.SetModificationDate(this.ModifyDate);
    xmp.SetModifyDate(this.ModifyDate);
    try {
      this.Ve
        = global::DripSharp.PdfCarton.Preflight.Metadata.TestSynchronizedMetadataValidation.Sync.ValidateMetadataSynchronization(this.Doc,
        this.Metadata);
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(this.Ve), null);
    } catch (global::DripSharp.PdfCarton.Preflight.Exception.ValidationException e) {
      throw new global::System.Exception(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.Runtime.JavaCompat.ExceptionMessage(e)));
    }
  }

  internal virtual void checkSchemaAccessException() {
    global::System.Exception cause = global::DripSharp.Runtime.JavaCompat.NewThrowable();
    global::DripSharp.Testing.JavaAssertions.Same(cause,
      global::DripSharp.Runtime.JavaCompat.GetCause(global::DripSharp.PdfCarton.Preflight.Metadata.TestSynchronizedMetadataValidation.Sync.SchemaAccessException(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "test"), cause))!, null);
  }

  internal virtual void testBadPrefixSchemas() {
    this.initValues();
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dc
      = new global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema(this.Metadata,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "dctest"));
    this.Metadata.AddSchema(dc);
    global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicSchema xmp
      = new global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicSchema(this.Metadata,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "xmptest"));
    this.Metadata.AddSchema(xmp);
    global::DripSharp.PdfCarton.Xmp.Schema.AdobePDFSchema pdf
      = new global::DripSharp.PdfCarton.Xmp.Schema.AdobePDFSchema(this.Metadata,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "pdftest"));
    this.Metadata.AddSchema(pdf);
    this.Dico.SetTitle(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Title));
    dc.SetTitle(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "x-default"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Title));
    this.Dico.SetAuthor(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Author));
    dc.AddCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Author));
    this.Dico.SetSubject(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Subject));
    dc.AddDescription(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "x-default"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Subject));
    this.Dico.SetKeywords(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Keywords));
    pdf.SetKeywords(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Keywords));
    this.Dico.SetCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Creator));
    xmp.SetCreatorTool(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Creator));
    this.Dico.SetProducer(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Producer));
    pdf.SetProducer(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Producer));
    this.Dico.SetCreationDate(this.CreationDate);
    xmp.SetCreateDate(this.CreationDate);
    this.Dico.SetModificationDate(this.ModifyDate);
    xmp.SetModifyDate(this.ModifyDate);
    try {
      this.Ve
        = global::DripSharp.PdfCarton.Preflight.Metadata.TestSynchronizedMetadataValidation.Sync.ValidateMetadataSynchronization(this.Doc,
        this.Metadata);
      foreach (global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError valid in this.Ve) {
        global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorMetadataWrongNsPrefix,
          valid.GetErrorCode(), null);
      }
    } catch (global::DripSharp.PdfCarton.Preflight.Exception.ValidationException e) {
      throw new global::System.Exception(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.Runtime.JavaCompat.ExceptionMessage(e)));
    }
  }

  internal virtual void testdoublePrefixSchemas() {
    this.initValues();
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dc
      = this.Metadata.CreateAndAddDublinCoreSchema();
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dc2
      = new global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema(this.Metadata,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "dctest"));
    this.Metadata.AddSchema(dc2);
    global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicSchema xmp
      = this.Metadata.CreateAndAddXMPBasicSchema();
    global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicSchema xmp2
      = new global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicSchema(this.Metadata,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "xmptest"));
    this.Metadata.AddSchema(xmp2);
    global::DripSharp.PdfCarton.Xmp.Schema.AdobePDFSchema pdf
      = this.Metadata.CreateAndAddAdobePDFSchema();
    global::DripSharp.PdfCarton.Xmp.Schema.AdobePDFSchema pdf2
      = new global::DripSharp.PdfCarton.Xmp.Schema.AdobePDFSchema(this.Metadata,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "pdftest"));
    this.Metadata.AddSchema(pdf2);
    dc2.SetCoverage(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "tmpcover"));
    xmp2.SetCreatorTool(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "tmpcreator"));
    pdf2.SetKeywords(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "tmpkeys"));
    this.Dico.SetTitle(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Title));
    dc.SetTitle(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "x-default"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Title));
    this.Dico.SetAuthor(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Author));
    dc.AddCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Author));
    this.Dico.SetSubject(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Subject));
    dc.AddDescription(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "x-default"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Subject));
    this.Dico.SetKeywords(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Keywords));
    pdf.SetKeywords(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Keywords));
    this.Dico.SetCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Creator));
    xmp.SetCreatorTool(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Creator));
    this.Dico.SetProducer(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      this.Producer));
    pdf.SetProducer(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", this.Producer));
    this.Dico.SetCreationDate(this.CreationDate);
    xmp.SetCreateDate(this.CreationDate);
    this.Dico.SetModificationDate(this.ModifyDate);
    xmp.SetModifyDate(this.ModifyDate);
    try {
      this.Ve
        = global::DripSharp.PdfCarton.Preflight.Metadata.TestSynchronizedMetadataValidation.Sync.ValidateMetadataSynchronization(this.Doc,
        this.Metadata);
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(this.Ve),
        null);
    } catch (global::DripSharp.PdfCarton.Preflight.Exception.ValidationException e) {
      throw new global::System.Exception(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.Runtime.JavaCompat.ExceptionMessage(e)));
    }
  }

  internal virtual void testPDFBox4292() {
    this.initValues();
    global::System.DateTimeOffset? cal1
      = global::DripSharp.PdfCarton.Util.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "20180817115837+02'00'"));
    global::System.DateTimeOffset? cal2
      = global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "2018-08-17T09:58:37Z"));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicSchema xmp
      = this.Metadata.CreateAndAddXMPBasicSchema();
    this.Dico.SetCreationDate(cal1);
    xmp.SetCreateDate(cal2);
    this.Dico.SetModificationDate(cal1);
    xmp.SetModifyDate(cal2);
    try {
      this.Ve
        = global::DripSharp.PdfCarton.Preflight.Metadata.TestSynchronizedMetadataValidation.Sync.ValidateMetadataSynchronization(this.Doc,
        this.Metadata);
      global::DripSharp.Testing.JavaAssertions.Equal(0,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(this.Ve), null);
    } catch (global::DripSharp.PdfCarton.Preflight.Exception.ValidationException e) {
      throw new global::System.Exception(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.Runtime.JavaCompat.ExceptionMessage(e)));
    }
  }

  public virtual void CheckErrors() {
    try {
      this.Doc.Dispose();
    } catch (global::System.IO.IOException) {
      throw new global::System.Exception(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        "Error while closing PDF Document"));
    }
  }

  private void initValues() {
    this.Title = "TITLE";
    this.Author = "AUTHOR(S)";
    this.Subject = "SUBJECTS";
    this.Keywords = "KEYWORD(S)";
    this.Creator = "CREATOR";
    this.Producer = "PRODUCER";
    this.CreationDate = global::System.DateTimeOffset.Now;
    this.ModifyDate = global::System.DateTimeOffset.Now;
    this.CreationDate = global::DripSharp.Runtime.JavaCompat.CalendarSet(this.CreationDate, 14, 0);
    this.ModifyDate = global::DripSharp.Runtime.JavaCompat.CalendarSet(this.ModifyDate, 14, 0);
  }

  [Xunit.Fact]
  public void __Upstream_0814671377_0abecf11f7d17148() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    this.initNewDocumentInformation();
    try {
      this.TestDocumentWithoutInformation();
    } finally {
      this.CheckErrors();
    }
  }

  [Xunit.Fact]
  public void __Upstream_3106280852_d67cb7b3db767297() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    this.initNewDocumentInformation();
    try {
      this.TestNullDocument();
    } finally {
      this.CheckErrors();
    }
  }

  [Xunit.Fact]
  public void __Upstream_1793602504_073472bbe0218745() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    this.initNewDocumentInformation();
    try {
      this.TestNullMetaData();
    } finally {
      this.CheckErrors();
    }
  }

  [Xunit.Fact]
  public void __Upstream_3047151426_77b534046a295a3c() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    this.initNewDocumentInformation();
    try {
      this.checkSchemaAccessException();
    } finally {
      this.CheckErrors();
    }
  }

  [Xunit.Fact]
  public void __Upstream_0120474289_822ccd43d6f58d7e() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    this.initNewDocumentInformation();
    try {
      this.testAllInfoSynchronized();
    } finally {
      this.CheckErrors();
    }
  }

  [Xunit.Fact]
  public void __Upstream_2059225226_eab772885d89ac2d() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    this.initNewDocumentInformation();
    try {
      this.testAllInfoUnsynchronized();
    } finally {
      this.CheckErrors();
    }
  }

  [Xunit.Fact]
  public void __Upstream_1125647533_a1eae0447cf1459d() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    this.initNewDocumentInformation();
    try {
      this.testBadPrefixSchemas();
    } finally {
      this.CheckErrors();
    }
  }

  [Xunit.Fact]
  public void __Upstream_2918708933_fcc7604c2e072fa3() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    this.initNewDocumentInformation();
    try {
      this.testBadSizeOfArrays();
    } finally {
      this.CheckErrors();
    }
  }

  [Xunit.Fact]
  public void __Upstream_4062946880_b6e9d03765bec6e7() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    this.initNewDocumentInformation();
    try {
      this.testEmptyXMP();
    } finally {
      this.CheckErrors();
    }
  }

  [Xunit.Fact]
  public void __Upstream_0676784274_b7e4321a162425b4() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    this.initNewDocumentInformation();
    try {
      this.testEmptyXMPSchemas();
    } finally {
      this.CheckErrors();
    }
  }

  [Xunit.Fact]
  public void __Upstream_2180648113_a3e6ddc18d0a3a4f() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    this.initNewDocumentInformation();
    try {
      this.testNullArrayValue();
    } finally {
      this.CheckErrors();
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724575554_732bd5748146ad33() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    this.initNewDocumentInformation();
    try {
      this.testPDFBox4292();
    } finally {
      this.CheckErrors();
    }
  }

  [Xunit.Fact]
  public void __Upstream_4266224093_3b64228c0eb1a80d() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    this.initNewDocumentInformation();
    try {
      this.testdoublePrefixSchemas();
    } finally {
      this.CheckErrors();
    }
  }

  private static readonly bool __UpstreamBeforeAll = __RunUpstreamBeforeAll();

  private static bool __RunUpstreamBeforeAll() {
    initSynchronizedMetadataValidation();
    return true;
  }
}
