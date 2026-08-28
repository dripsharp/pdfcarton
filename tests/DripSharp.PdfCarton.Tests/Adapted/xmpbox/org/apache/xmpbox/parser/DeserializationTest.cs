// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Parser;

public class DeserializationTest {
  private global::DripSharp.Runtime.JavaByteArrayOutputStream baos = null!;

  private global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer serializer = null!;

  private global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xdb = null!;

  private static global::System.TimeZoneInfo defaultTZ = null!;

  internal static void initAll() {
    global::DripSharp.PdfCarton.Xmp.Parser.DeserializationTest.defaultTZ
      = global::System.TimeZoneInfo.Local;
    global::DripSharp.PdfCarton.Tests.Support.SetDefaultTimeZone(global::DripSharp.Runtime.JavaCompat.GetTimeZone(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "UTC")));
  }

  internal virtual void init() {
    this.baos = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    this.serializer = new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer();
    this.xdb = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
  }

  internal static void finishAll() {
    global::DripSharp.PdfCarton.Tests.Support.SetDefaultTimeZone(global::DripSharp.PdfCarton.Xmp.Parser.DeserializationTest.defaultTZ);
  }

  internal virtual void testStructuredRecursive() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/org/apache/xmpbox/parser/structured_recursive.xml"))) {
      global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = this.xdb.Parse(@is);
      this.checkTransform(metadata, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "62495942572014793625872774972947435765670563107818217447706375288846297812281"),
        global::DripSharp.Runtime.JavaCompat.CollectionCount(metadata.GetAllSchemas()));
    }
  }

  internal virtual void testEmptyLi() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/org/apache/xmpbox/parser/empty_list.xml"))) {
      global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = this.xdb.Parse(@is);
      this.checkTransform(metadata, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "95754993383010030299848397520773287413798669761891751126809013411187892693280"),
        global::DripSharp.Runtime.JavaCompat.CollectionCount(metadata.GetAllSchemas()));
    }
  }

  internal virtual void testEmptyLi2() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "/validxmp/emptyli.xml"))) {
      global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = this.xdb.Parse(@is);
      global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dc = metadata.GetDublinCoreSchema();
      dc.GetCreatorsProperty();
      this.checkTransform(metadata, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "39450703080437563739186076111811684356424147071014681699119272065568305393521"),
        global::DripSharp.Runtime.JavaCompat.CollectionCount(metadata.GetAllSchemas()));
    }
  }

  internal virtual void testGetTitle() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "/validxmp/emptyli.xml"))) {
      global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = this.xdb.Parse(@is);
      global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dc = metadata.GetDublinCoreSchema();
      string s = dc.GetTitle((string)default!);
      global::DripSharp.Testing.JavaAssertions.Equal("title value", s, null);
    }
  }

  internal virtual void testAltBagSeq() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/org/apache/xmpbox/parser/AltBagSeqTest.xml"))) {
      global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = this.xdb.Parse(@is);
      this.checkTransform(metadata, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "89123270336154452745819041017446278583816329940574853160909598044560152910018"),
        global::DripSharp.Runtime.JavaCompat.CollectionCount(metadata.GetAllSchemas()));
    }
  }

  internal virtual void testIsartorStyleWithThumbs() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/org/apache/xmpbox/parser/ThumbisartorStyle.xml"))) {
      global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = this.xdb.Parse(@is);
      global::DripSharp.Testing.JavaAssertions.Equal("uuid:09C78666-2F91-3A9C-92AF-3691A6D594F7",
        metadata.GetXMPMediaManagementSchema().GetDocumentID(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "2008-01-18T16:59:54+01:00")), metadata.GetXMPBasicSchema().GetCreateDate(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "2008-01-18T16:59:54+01:00")), metadata.GetXMPBasicSchema().GetModifyDate(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.DateConverter.ToCalendar(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "2008-01-18T16:59:54+01:00")), metadata.GetXMPBasicSchema().GetMetadataDate(), null);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Xmp.Type.ThumbnailType> thumbs
        = metadata.GetXMPBasicSchema().GetThumbnailsProperty();
      global::DripSharp.Testing.JavaAssertions.NotNull(thumbs, null);
      global::DripSharp.Testing.JavaAssertions.Equal(2,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(thumbs), null);
      global::DripSharp.PdfCarton.Xmp.Type.ThumbnailType thumb
        = global::DripSharp.Runtime.JavaCompat.ListGet(thumbs, 0);
      global::DripSharp.Testing.JavaAssertions.Equal(162, thumb.GetHeight(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(216, thumb.GetWidth(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("JPEG", thumb.GetFormat(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("/9j/4AAQSkZJRgABAgEASABIAAD",
        thumb.GetImage(), null);
      thumb = global::DripSharp.Runtime.JavaCompat.ListGet(thumbs, 1);
      global::DripSharp.Testing.JavaAssertions.Equal(162, thumb.GetHeight(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(216, thumb.GetWidth(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("JPEG", thumb.GetFormat(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("/9j/4AAQSkZJRgABAgEASABIAAD",
        thumb.GetImage(), null);
      global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema acmeMailSchema
        = metadata.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "http://www.acme.com/ns/email/1/"));
      global::DripSharp.PdfCarton.Xmp.Type.DateType deliveryDate
        = (global::DripSharp.PdfCarton.Xmp.Type.DateType)(acmeMailSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "Delivery-Date"))!);
      global::DripSharp.Testing.JavaAssertions.Equal("2007-11-09T09:55:36+01:00",
        deliveryDate.GetStringValue(), null);
      global::DripSharp.PdfCarton.Xmp.Type.DefinedStructuredType dst
        = (global::DripSharp.PdfCarton.Xmp.Type.DefinedStructuredType)(acmeMailSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "From"))!);
      global::DripSharp.Testing.JavaAssertions.Equal("[name=TextType:John Doe]",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(dst.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "name"))), null);
      global::DripSharp.Testing.JavaAssertions.Equal("[mailto=TextType:john@acme.com]",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(dst.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "mailto"))), null);
      this.checkTransform(metadata, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "64755266855514150823517184659364700851455308334441170957883187622624192802093"),
        global::DripSharp.Runtime.JavaCompat.CollectionCount(metadata.GetAllSchemas()));
    }
  }

  internal virtual void testWithNoXPacketStart() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "/invalidxmp/noxpacket.xml"))) {
      global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
        = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
        => this.xdb.Parse(@is), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException.ErrorType.XpacketBadStart,
        ex.GetErrorType(), null);
    }
  }

  internal virtual void testWithNoXPacketEnd() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/invalidxmp/noxpacketend.xml"))) {
      global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
        = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
        => this.xdb.Parse(@is), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException.ErrorType.XpacketBadEnd,
        ex.GetErrorType(), null);
    }
  }

  internal virtual void testWithNoRDFElement() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "/invalidxmp/noroot.xml"))) {
      global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
        = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
        => this.xdb.Parse(@is), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException.ErrorType.Format,
        ex.GetErrorType(), null);
    }
  }

  internal virtual void testWithTwoRDFElement() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "/invalidxmp/tworoot.xml"))) {
      global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
        = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
        => this.xdb.Parse(@is), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException.ErrorType.Format,
        ex.GetErrorType(), null);
    }
  }

  internal virtual void testWithInvalidRDFElementPrefix() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/invalidxmp/invalidroot2.xml"))) {
      global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
        = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
        => this.xdb.Parse(@is), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException.ErrorType.Format,
        ex.GetErrorType(), null);
    }
  }

  internal virtual void testWithRDFRootAsText() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/invalidxmp/invalidroot.xml"))) {
      global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
        = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
        => this.xdb.Parse(@is), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException.ErrorType.Format,
        ex.GetErrorType(), null);
    }
  }

  internal virtual void testUndefinedSchema() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/invalidxmp/undefinedschema.xml"))) {
      global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
        = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
        => this.xdb.Parse(@is), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException.ErrorType.NoSchema,
        ex.GetErrorType(), null);
    }
  }

  internal virtual void testUndefinedPropertyWithDefinedSchema() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/invalidxmp/undefinedpropertyindefinedschema.xml"))) {
      global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
        = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
        => this.xdb.Parse(@is), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException.ErrorType.NoType,
        ex.GetErrorType(), null);
    }
  }

  internal virtual void testUndefinedStructuredWithDefinedSchema() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/invalidxmp/undefinedstructuredindefinedschema.xml"))) {
      global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
        = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
        => this.xdb.Parse(@is), null);
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException.ErrorType.NoValueType,
        ex.GetErrorType(), null);
    }
  }

  internal virtual void testRdfAboutFound() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "/validxmp/emptyli.xml"))) {
      global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = this.xdb.Parse(@is);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema> schemas
        = metadata.GetAllSchemas();
      foreach (global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema xmpSchema in schemas) {
        global::DripSharp.Testing.JavaAssertions.NotNull(xmpSchema.GetAboutAttribute(), null);
      }
    }
  }

  internal virtual void testWithAttributesAsProperties() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/validxmp/attr_as_props.xml"))) {
      global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = this.xdb.Parse(@is);
      global::DripSharp.PdfCarton.Xmp.Schema.AdobePDFSchema pdf = metadata.GetAdobePDFSchema();
      global::DripSharp.Testing.JavaAssertions.Equal("GPL Ghostscript 8.64", pdf.GetProducer(),
        null);
      global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dc = metadata.GetDublinCoreSchema();
      global::DripSharp.Testing.JavaAssertions.Equal("application/pdf", dc.GetFormat(), null);
      global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicSchema basic = metadata.GetXMPBasicSchema();
      global::DripSharp.Testing.JavaAssertions.NotNull(basic.GetCreateDate(), null);
      global::DripSharp.PdfCarton.Xmp.Schema.PDFAIdentificationSchema pdfaIdentificationSchema
        = metadata.GetPDFAIdentificationSchema();
      global::DripSharp.Testing.JavaAssertions.Equal("B", pdfaIdentificationSchema.GetConformance(),
        null);
      global::DripSharp.Testing.JavaAssertions.Equal(1, pdfaIdentificationSchema.GetPart(), null);
      global::DripSharp.PdfCarton.Xmp.Schema.XMPMediaManagementSchema xmpMediaManagementSchema
        = metadata.GetXMPMediaManagementSchema();
      global::DripSharp.Testing.JavaAssertions.Equal("e7127190-445c-11ea-0000-b3bc74086807",
        xmpMediaManagementSchema.GetDocumentID(), null);
      this.checkTransform(metadata, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "27499224985683016678197540524065114038595582230834506941950503218519476041225"),
        global::DripSharp.Runtime.JavaCompat.CollectionCount(metadata.GetAllSchemas()));
    }
  }

  internal virtual void testSpaceTextValues() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/validxmp/only_space_fields.xmp"))) {
      global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = this.xdb.Parse(@is);
      global::DripSharp.Testing.JavaAssertions.Equal(" ",
        metadata.GetAdobePDFSchema().GetProducer(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("Canon ",
        metadata.GetXMPBasicSchema().GetCreatorTool(), null);
      this.checkTransform(metadata, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "9220923061800113567693538810355030344095407871190202111473587642358933618073"),
        global::DripSharp.Runtime.JavaCompat.CollectionCount(metadata.GetAllSchemas()));
    }
  }

  internal virtual void testMetadataParsing() {
    global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata
      = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dc
      = metadata.CreateAndAddDublinCoreSchema();
    dc.SetCoverage(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "coverage"));
    dc.AddContributor(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "contributor1"));
    dc.AddContributor(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "contributor2"));
    dc.AddDescription(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "x-default"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "Description"));
    global::DripSharp.PdfCarton.Xmp.Schema.AdobePDFSchema pdf
      = metadata.CreateAndAddAdobePDFSchema();
    pdf.SetProducer(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "Producer"));
    pdf.SetPDFVersion(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "1.4"));
    this.checkTransform(metadata, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "24727341753942351260821151680330022244742411666459385225917195999704816908515"),
      global::DripSharp.Runtime.JavaCompat.CollectionCount(metadata.GetAllSchemas()));
  }

  internal virtual void testEmptyDate() {
    string xmpmeta
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?>\n",
      "<x:xmpmeta x:xmptk=\"Adobe XMP Core 4.2.1-c041 52.342996, 2008/05/07-20:48:00\" xmlns:x=\"adobe:ns:meta/\">\n"),
      "  <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "   <rdf:Description rdf:about=\"\" xmlns:xmp=\"http://ns.adobe.com/xap/1.0/\">\n"),
      "    <xmp:CreateDate></xmp:CreateDate>\n"), "   </rdf:Description>\n"), "  </rdf:RDF>\n"),
      "</x:xmpmeta>\n"), "<?xpacket end=\"w\"?>");
    global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata
      = this.xdb.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(xmpmeta,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    this.checkTransform(metadata, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "19030153876683461724958694183980892665426846590791273142114566290124997390122"),
      global::DripSharp.Runtime.JavaCompat.CollectionCount(metadata.GetAllSchemas()));
  }

  private void checkTransform(global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata, string expected,
    int expectedSchemaCount) {
    this.serializer.Serialize(metadata, this.baos, true);
    string replaced
      = global::DripSharp.Runtime.JavaCompat.ReplaceOrdinal(global::DripSharp.Runtime.JavaCompat.MemoryStreamToString(this.baos,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      (global::DripSharp.Runtime.JavaStandardCharsets.UTF8).WebName)), "\r\n", "\n");
    sbyte[] ba = global::DripSharp.Runtime.JavaCompat.StringGetBytes(replaced,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8);
    sbyte[] digest
      = global::DripSharp.Runtime.JavaMessageDigest.GetInstance(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "SHA-256")).Digest(ba);
    string result = global::DripSharp.Runtime.JavaCompat.NewBigInteger(1, digest).ToString();
    global::DripSharp.Testing.JavaAssertions.Equal(expected, result,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.Runtime.JavaCompat.Concat("output:\n", replaced)));
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = this.xdb.Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(this.baos));
    global::DripSharp.Testing.JavaAssertions.Equal(expectedSchemaCount,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(xmp.GetAllSchemas()), null);
  }

  [Xunit.Fact]
  public void __Upstream_0391220686_85738244369b0d60() {
    initAll();
    this.init();
    try {
      this.testAltBagSeq();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_1396726313_34775d4296b81f84() {
    initAll();
    this.init();
    try {
      this.testEmptyDate();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_0131062456_2116680b3fc6d339() {
    initAll();
    this.init();
    try {
      this.testEmptyLi();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_4062936186_43889499750f0c9c() {
    initAll();
    this.init();
    try {
      this.testEmptyLi2();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_0533053268_516a05da9c258dbb() {
    initAll();
    this.init();
    try {
      this.testGetTitle();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_1544648010_c4979e67d3a41b34() {
    initAll();
    this.init();
    try {
      this.testIsartorStyleWithThumbs();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_1254804879_b125a867b1c8ee9b() {
    initAll();
    this.init();
    try {
      this.testMetadataParsing();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_1187360791_4dc5ac052056bafc() {
    initAll();
    this.init();
    try {
      this.testRdfAboutFound();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_2771104611_65e40d58b9b93676() {
    initAll();
    this.init();
    try {
      this.testSpaceTextValues();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_0035599343_1f5de7178aa59d76() {
    initAll();
    this.init();
    try {
      this.testStructuredRecursive();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_0176021841_da632544d7d1b984() {
    initAll();
    this.init();
    try {
      this.testUndefinedPropertyWithDefinedSchema();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_1011336223_006d2de3d982bc39() {
    initAll();
    this.init();
    try {
      this.testUndefinedSchema();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_3882679509_c755f88737a5e4d0() {
    initAll();
    this.init();
    try {
      this.testUndefinedStructuredWithDefinedSchema();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_2133419156_f72c9a25b085e4d7() {
    initAll();
    this.init();
    try {
      this.testWithAttributesAsProperties();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_2975879449_87c220d051c626f0() {
    initAll();
    this.init();
    try {
      this.testWithInvalidRDFElementPrefix();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_0637891873_bd47e500a16bea2f() {
    initAll();
    this.init();
    try {
      this.testWithNoRDFElement();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_4177255124_b2d10b5f16f4b4a8() {
    initAll();
    this.init();
    try {
      this.testWithNoXPacketEnd();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_2855828507_d317b9920c08667c() {
    initAll();
    this.init();
    try {
      this.testWithNoXPacketStart();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_2669775357_3822937c7eac82bd() {
    initAll();
    this.init();
    try {
      this.testWithRDFRootAsText();
    } finally {
      finishAll();
    }
  }

  [Xunit.Fact]
  public void __Upstream_3841911228_beee51e2ddf723e8() {
    initAll();
    this.init();
    try {
      this.testWithTwoRDFElement();
    } finally {
      finishAll();
    }
  }
}
