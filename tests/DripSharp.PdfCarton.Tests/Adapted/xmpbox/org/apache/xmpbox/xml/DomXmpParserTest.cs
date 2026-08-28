// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Xml;

public class DomXmpParserTest {
  internal virtual void testPDFBox5649() {
    using (global::System.IO.Stream fis
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/org/apache/xmpbox/xml/PDFBOX-5649.xml"))) {
      global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser dxp
        = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
      global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp = dxp.Parse(fis);
      global::DripSharp.Testing.JavaAssertions.NotNull(xmp, null);
    }
  }

  internal virtual void testPDFBox5835() {
    using (global::System.IO.Stream fis
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/org/apache/xmpbox/xml/PDFBOX-5835.xml"))) {
      global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser dxp
        = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
      global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp = dxp.Parse(fis);
      global::DripSharp.Testing.JavaAssertions.Equal("A",
        xmp.GetPDFAIdentificationSchema().GetConformance(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(3, xmp.GetPDFAIdentificationSchema().GetPart(),
        null);
    }
  }

  internal virtual void testPDFBox5976() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?>\n"), "<rdf:RDF\n"),
      "\txmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"\n"),
      "\txmlns:pdf=\"http://ns.adobe.com/pdf/1.3/\"\n"),
      "\txmlns:pdfaid=\"http://www.aiim.org/pdfa/ns/id/\">\n"),
      "\t    <rdf:Description pdfaid:conformance=\"B\" pdfaid:part=\"3\" rdf:about=\"\"/>\n"),
      "\t    <rdf:Description pdf:Producer=\"WeasyPrint 64.1\" rdf:about=\"\"/>\n"),
      "</rdf:RDF>\n"), "<?xpacket end=\"r\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.Testing.JavaAssertions.Equal("B",
      xmp.GetPDFAIdentificationSchema().GetConformance(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(3, xmp.GetPDFAIdentificationSchema().GetPart(),
      null);
  }

  internal virtual void testPDFBox6106() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xpacket begin='' id='W5M0MpCehiHzreSzNTczkc9d' bytes='647'?>\n",
      "<rdf:RDF xmlns:rdf='http://www.w3.org/1999/02/22-rdf-syntax-ns#'\n"),
      "         xmlns:iX='http://ns.adobe.com/iX/1.0/'>\n"), "\t<rdf:Description about=''\n"),
      "\t                 xmlns='http://ns.adobe.com/pdf/1.3/'\n"),
      "\t                 xmlns:pdf='http://ns.adobe.com/pdf/1.3/'\n"),
      "\t                 pdf:CreationDate='2004-01-30T17:21:50Z'\n"),
      "\t                 pdf:ModDate='2004-01-30T17:21:50Z'\n"),
      "\t                 pdf:Producer='Acrobat Distiller 5.0.5 (Windows)'/>\n"),
      "\t<rdf:Description about=''\n"),
      "\t                 xmlns='http://ns.adobe.com/xap/1.0/'\n"),
      "\t                 xmlns:xap='http://ns.adobe.com/xap/1.0/'\n"),
      "\t                 xap:CreateDate='2004-01-30T17:21:50Z'\n"),
      "\t                 xap:ModifyDate='2004-01-30T17:21:50Z'\n"),
      "\t                 xap:MetadataDate='2004-01-30T17:21:50Z'/>\n"),
      "</rdf:RDF><?xpacket end='r'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("No type defined for {http://ns.adobe.com/pdf/1.3/}CreationDate",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  internal virtual void testPDFBox5288() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Public XMP Toolkit Core 4.0  \">\n"),
      " \n"), " <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"), "  \n"),
      "  <rdf:Description xmlns:xmpMM=\"http://ns.adobe.com/xap/1.0/mm/\" rdf:about=\"\">\n"),
      "   <xmpMM:DocumentID>uidd:1f0e03977b90b6365a376454ffdf34a7</xmpMM:DocumentID>\n"),
      "   <xmpMM:History>\n"), "    <rdf:Seq>\n"),
      "     <rdf:li xmlns:stEvt=\"http://ns.adobe.com/xap/1.0/sType/ResourceEvent#\">\n"),
      "      <rdf:Description>\n"), "       <stEvt:action>created</stEvt:action>\n"),
      "       <stEvt:parameters>iDRS PDF output engine 7</stEvt:parameters>\n"),
      "       <stEvt:when>2022-09-12T12:00:07+02:00</stEvt:when>\n"), "      </rdf:Description>\n"),
      "     </rdf:li>\n"), "    </rdf:Seq>\n"), "   </xmpMM:History>\n"), "  </rdf:Description>\n"),
      " </rdf:RDF>\n"), "</x:xmpmeta><?xpacket end=\"w\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPMediaManagementSchema xmpMediaManagementSchema
      = xmp.GetXMPMediaManagementSchema();
    global::DripSharp.Testing.JavaAssertions.Equal("uidd:1f0e03977b90b6365a376454ffdf34a7",
      xmpMediaManagementSchema.GetDocumentID(), null);
    global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty historyProperty
      = xmpMediaManagementSchema.GetHistoryProperty();
    global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType firstHistoryEntry
      = (global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType)(global::DripSharp.Runtime.JavaCompat.Iterator(historyProperty.GetAllProperties()).Next()!);
    global::DripSharp.Testing.JavaAssertions.Equal("created", firstHistoryEntry.GetAction(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("iDRS PDF output engine 7",
      firstHistoryEntry.GetParameters(), null);
  }

  internal virtual void testPageTextSchema() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?>\n"),
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\">\n"),
      "\t<rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "           <rdf:Description xmlns:stRef=\"http://ns.adobe.com/xap/1.0/sType/ResourceRef#\"\n"),
      "\t\t                 xmlns:xmpMM=\"http://ns.adobe.com/xap/1.0/mm/\"\n"),
      "\t\t                 rdf:about=\"\">\n"),
      "\t\t\t<xmpMM:InstanceID>uuid:b429d411-e628-45ca-b932-d2c77fbe6cd3</xmpMM:InstanceID>\n"),
      "\t\t\t<xmpMM:DocumentID>adobe:docid:indd:db084a4d-dbb2-11dc-ac34-beb3cc4028ec</xmpMM:DocumentID>\n"),
      "\t\t\t<xmpMM:RenditionClass>proof:pdf</xmpMM:RenditionClass>\n"),
      "\t\t\t<xmpMM:DerivedFrom rdf:parseType=\"Resource\">\n"),
      "\t\t\t\t<stRef:documentID>adobe:docid:indd:fa7c6589-9f4a-11dc-9641-af983df728d7</stRef:documentID>\n"),
      "\t\t\t</xmpMM:DerivedFrom>\n"), "\t\t</rdf:Description>"),
      "\t\t<rdf:Description xmlns:xmpTPg=\"http://ns.adobe.com/xap/1.0/t/pg/\"\n"),
      "\t\t                 rdf:about=\"\">\n"), "\t\t\t<xmpTPg:MaxPageSize>\n"),
      "\t\t\t\t<rdf:Description xmlns:stDim=\"http://ns.adobe.com/xap/1.0/sType/Dimensions#\">\n"),
      "\t\t\t\t\t<stDim:w>4</stDim:w>\n"), "\t\t\t\t\t<stDim:h>3</stDim:h>\n"),
      "\t\t\t\t\t<stDim:unit>inch</stDim:unit>\n"), "\t\t\t\t</rdf:Description>\n"),
      "\t\t\t</xmpTPg:MaxPageSize>\n"), "\t\t\t<xmpTPg:NPages>7</xmpTPg:NPages>\n"),
      "\t\t</rdf:Description>\n"), "\t</rdf:RDF>\n"), "</x:xmpmeta><?xpacket end=\"r\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPageTextSchema pageTextSchema
      = xmp.GetPageTextSchema();
    global::DripSharp.PdfCarton.Xmp.Type.DimensionsType dim
      = (global::DripSharp.PdfCarton.Xmp.Type.DimensionsType)(pageTextSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.XMPageTextSchema.MaxPageSize))!);
    global::DripSharp.Testing.JavaAssertions.Equal("DimensionsType{4.0 x 3.0 inch}", dim.ToString(),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal("[NPages=IntegerType:7]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(pageTextSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.XMPageTextSchema.NPages))), null);
    global::DripSharp.PdfCarton.Xmp.Schema.XMPMediaManagementSchema xmpMediaManagementSchema
      = xmp.GetXMPMediaManagementSchema();
    global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType derivedFromProperty
      = xmpMediaManagementSchema.GetDerivedFromProperty();
    global::DripSharp.Testing.JavaAssertions.Equal("uuid:b429d411-e628-45ca-b932-d2c77fbe6cd3",
      xmpMediaManagementSchema.GetInstanceID(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("proof:pdf",
      xmpMediaManagementSchema.GetRenditionClass(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("adobe:docid:indd:db084a4d-dbb2-11dc-ac34-beb3cc4028ec",
      xmpMediaManagementSchema.GetDocumentID(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("adobe:docid:indd:fa7c6589-9f4a-11dc-9641-af983df728d7",
      derivedFromProperty.GetDocumentID(), null);
  }

  internal virtual void testPageTextSchema2() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?>\n"),
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\">\n"),
      "\t<rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "           <rdf:Description xmlns:xmpTPg=\"http://ns.adobe.com/xap/1.0/t/pg/\""),
      "                            xmlns:stDim=\"http://ns.adobe.com/xap/1.0/sType/Dimensions#\""),
      "\t\t                 rdf:about=\"\">\n"), "\t\t\t<xmpTPg:MaxPageSize>\n"),
      "\t\t\t\t<rdf:Description stDim:w=\"4\" stDim:h=\"3\">\n"),
      "\t\t\t\t\t<stDim:unit>inch</stDim:unit>\n"), "\t\t\t\t</rdf:Description>\n"),
      "\t\t\t</xmpTPg:MaxPageSize>\n"), "\t\t\t<xmpTPg:NPages>7</xmpTPg:NPages>\n"),
      "\t\t</rdf:Description>\n"), "\t</rdf:RDF>\n"), "</x:xmpmeta><?xpacket end=\"r\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPageTextSchema pageTextSchema
      = xmp.GetPageTextSchema();
    global::DripSharp.PdfCarton.Xmp.Type.DimensionsType dim
      = (global::DripSharp.PdfCarton.Xmp.Type.DimensionsType)(pageTextSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.XMPageTextSchema.MaxPageSize))!);
    global::DripSharp.Testing.JavaAssertions.Equal("DimensionsType{4.0 x 3.0 inch}", dim.ToString(),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal("[NPages=IntegerType:7]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(pageTextSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.XMPageTextSchema.NPages))), null);
  }

  internal virtual void testPageTextSchema3() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?>\n"),
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\">\n"),
      "\t<rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "           <rdf:Description xmlns:xmpTPg=\"http://ns.adobe.com/xap/1.0/t/pg/\""),
      "                            xmlns:stDim=\"http://ns.adobe.com/xap/1.0/sType/Dimensions#\""),
      "\t\t                 rdf:about=\"\">\n"), "\t\t\t<xmpTPg:MaxPageSize>\n"),
      "\t\t\t\t<rdf:Description stDim:w=\"4\" stDim:h=\"3\" stDim:unit=\"inch\"/>\n"),
      "\t\t\t</xmpTPg:MaxPageSize>\n"), "\t\t\t<xmpTPg:NPages>7</xmpTPg:NPages>\n"),
      "\t\t</rdf:Description>\n"), "\t</rdf:RDF>\n"), "</x:xmpmeta><?xpacket end=\"r\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPageTextSchema pageTextSchema
      = xmp.GetPageTextSchema();
    global::DripSharp.PdfCarton.Xmp.Type.DimensionsType dim
      = (global::DripSharp.PdfCarton.Xmp.Type.DimensionsType)(pageTextSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.XMPageTextSchema.MaxPageSize))!);
    global::DripSharp.Testing.JavaAssertions.Equal("DimensionsType{4.0 x 3.0 inch}", dim.ToString(),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal("[NPages=IntegerType:7]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(pageTextSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.XMPageTextSchema.NPages))), null);
  }

  internal virtual void testPDFBox3882() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/org/apache/xmpbox/xml/PDFBOX-3882-dematbox.xml"))) {
      global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser dxp
        = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
      global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp = dxp.Parse(@is);
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Xmp.Type.AbstractField> allProperties
        = xmp.GetPDFExtensionSchema().GetSchemasProperty().GetAllProperties();
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(allProperties), null);
      global::DripSharp.PdfCarton.Xmp.Type.PDFASchemaType pdfExtensionSchema
        = (global::DripSharp.PdfCarton.Xmp.Type.PDFASchemaType)(global::DripSharp.Runtime.JavaCompat.ListGet(allProperties,
        0)!);
      global::DripSharp.Testing.JavaAssertions.Equal("http://www.sagemcom.com/documents/xmlns/dematbox",
        pdfExtensionSchema.GetNamespaceURI(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("dematbox",
        pdfExtensionSchema.GetPrefixValue(), null);
      global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema extensionSchema
        = xmp.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        pdfExtensionSchema.GetNamespaceURI()));
      global::DripSharp.Testing.JavaAssertions.Equal(pdfExtensionSchema.GetNamespaceURI(),
        extensionSchema.GetNamespace(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(pdfExtensionSchema.GetPrefixValue(),
        extensionSchema.GetPrefix(), null);
      global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty pageInfoProp
        = (global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty)(extensionSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "PageInfo"))!);
      global::DripSharp.PdfCarton.Xmp.Type.DefinedStructuredType dst
        = (global::DripSharp.PdfCarton.Xmp.Type.DefinedStructuredType)(global::DripSharp.Runtime.JavaCompat.ListGet(pageInfoProp.GetAllProperties(),
        0)!);
      global::DripSharp.Testing.JavaAssertions.Equal("[number=IntegerType:1]",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(dst.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "number"))), null);
      global::DripSharp.Testing.JavaAssertions.Equal("[origNumber=IntegerType:1]",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(dst.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "origNumber"))), null);
    }
  }

  internal virtual void testPDFBox3882_2() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?>\n",
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\"\n"),
      "           x:xmptk=\"Adobe XMP Core 5.0-c060 61.134777, 2010/02/12-17:32:00        \">\n"),
      "\t<rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "\t\t<rdf:Description rdf:about=\"\"\n"),
      "\t\t                 xmlns:xmp=\"http://ns.adobe.com/xap/1.0/\"\n"),
      "\t\t                 xmlns:dc=\"http://purl.org/dc/elements/1.1/\"\n"),
      "\t\t                 xmlns:xmpMM=\"http://ns.adobe.com/xap/1.0/mm/\"\n"),
      "\t\t                 xmlns:stEvt=\"http://ns.adobe.com/xap/1.0/sType/ResourceEvent#\"\n"),
      "\t\t                 xmlns:stRef=\"http://ns.adobe.com/xap/1.0/sType/ResourceRef#\"\n"),
      "\t\t                 xmlns:photoshop=\"http://ns.adobe.com/photoshop/1.0/\"\n"),
      "\t\t                 xmp:CreatorTool=\"Adobe Photoshop CS5 Macintosh\"\n"),
      "\t\t                 xmp:CreateDate=\"2012-04-30T12:52:07-04:00\"\n"),
      "\t\t                 xmp:MetadataDate=\"2012-05-03T13:36:11-04:00\"\n"),
      "\t\t                 xmp:ModifyDate=\"2012-05-03T13:36:11-04:00\"\n"),
      "\t\t                 dc:format=\"image/jpeg\"\n"),
      "\t\t                 xmpMM:InstanceID=\"xmp.iid:49E997338D4911E1AB62EBF9B374B234\"\n"),
      "\t\t                 xmpMM:DocumentID=\"xmp.did:49E997348D4911E1AB62EBF9B374B234\"\n"),
      "\t\t                 xmpMM:OriginalDocumentID=\"xmp.did:01801174072068118A6D9A879C818256\"\n"),
      "\t\t                 photoshop:History=\"2012-05-03T09:34:50-04:00&#x9;File i1222b.jpg opened&#xA;\">\n"),
      "\t\t\t<xmpMM:History>\n"), "\t\t\t\t<rdf:Seq>\n"),
      "\t\t\t\t\t<rdf:li stEvt:action=\"created\"\n"),
      "\t\t\t\t\t        stEvt:instanceID=\"xmp.iid:01801174072068118A6D9A879C818256\"\n"),
      "\t\t\t\t\t        stEvt:when=\"2012-04-30T12:52:07-04:00\"\n"),
      "\t\t\t\t\t        stEvt:softwareAgent=\"Adobe Photoshop CS5 Macintosh\"/>\n"),
      "\t\t\t\t\t<rdf:li stEvt:action=\"saved\"\n"),
      "\t\t\t\t\t        stEvt:instanceID=\"xmp.iid:02801174072068118A6D9A879C818256\"\n"),
      "\t\t\t\t\t        stEvt:when=\"2012-04-30T12:54:04-04:00\"\n"),
      "\t\t\t\t\t        stEvt:softwareAgent=\"Adobe Photoshop CS5 Macintosh\"\n"),
      "\t\t\t\t\t        stEvt:changed=\"/\"/>\n"), "\t\t\t\t\t<rdf:li stEvt:action=\"saved\"\n"),
      "\t\t\t\t\t        stEvt:instanceID=\"xmp.iid:03801174072068118A6D9A879C818256\"\n"),
      "\t\t\t\t\t        stEvt:when=\"2012-04-30T12:54:48-04:00\"\n"),
      "\t\t\t\t\t        stEvt:softwareAgent=\"Adobe Photoshop CS5 Macintosh\"\n"),
      "\t\t\t\t\t        stEvt:changed=\"/\"/>\n"), "\t\t\t\t</rdf:Seq>\n"),
      "\t\t\t</xmpMM:History>\n"),
      "\t\t\t<xmpMM:DerivedFrom stRef:instanceID=\"xmp.iid:21F0677BA22168118A6D9A879C818256\"\n"),
      "\t\t\t                   stRef:documentID=\"xmp.did:01801174072068118A6D9A879C818256\"\n"),
      "\t\t\t                   stRef:originalDocumentID=\"xmp.did:01801174072068118A6D9A879C818256\"/>\n"),
      "\t\t\t<photoshop:DocumentAncestors>\n"), "\t\t\t\t<rdf:Bag>\n"),
      "\t\t\t\t\t<rdf:li>adobe:docid:photoshop:11d3ec5a-c131-11d8-9274-ec65c7d7e0c6</rdf:li>\n"),
      "\t\t\t\t\t<rdf:li>adobe:docid:photoshop:aadc7027-309c-11d8-9596-9cf45d2f630b</rdf:li>\n"),
      "\t\t\t\t\t<rdf:li>adobe:docid:photoshop:c7961c59-6e0f-11d8-87b7-d67539df12d8</rdf:li>\n"),
      "\t\t\t\t</rdf:Bag>\n"), "\t\t\t</photoshop:DocumentAncestors>\n"),
      "\t\t\t<photoshop:DateCreated>2012-04-30T12:54:48Z</photoshop:DateCreated>\n"),
      "\t\t\t<photoshop:TextLayers>\n"), "\t\t\t\t<rdf:Seq>\n"),
      "                               <rdf:li photoshop:LayerName=\"Name1\" photoshop:LayerText=\"Text1\"/>\n"),
      "                               <rdf:li photoshop:LayerName=\"Name2\" photoshop:LayerText=\"Text2\"/>\n"),
      "\t\t\t\t</rdf:Seq>\n"), "\t\t\t</photoshop:TextLayers>\n"), "\t\t</rdf:Description>\n"),
      "\t</rdf:RDF>\n"), "</x:xmpmeta>\n"), "<?xpacket end=\"w\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPMediaManagementSchema xmpMediaManagementSchema
      = xmp.GetXMPMediaManagementSchema();
    global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty historyProperty
      = xmpMediaManagementSchema.GetHistoryProperty();
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Xmp.Type.AbstractField> historyProperties
      = historyProperty.GetAllProperties();
    global::DripSharp.Testing.JavaAssertions.Equal(3,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(historyProperties), null);
    global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType ret0
      = (global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType)(global::DripSharp.Runtime.JavaCompat.ListGet(historyProperties,
      0)!);
    global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType ret1
      = (global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType)(global::DripSharp.Runtime.JavaCompat.ListGet(historyProperties,
      1)!);
    global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType ret2
      = (global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType)(global::DripSharp.Runtime.JavaCompat.ListGet(historyProperties,
      2)!);
    global::DripSharp.Testing.JavaAssertions.Equal("created", ret0.GetAction(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("xmp.iid:01801174072068118A6D9A879C818256",
      ret0.GetInstanceID(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(2012,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(ret0.GetWhen(), 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(52,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(ret0.GetWhen(), 12), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Adobe Photoshop CS5 Macintosh",
      ret0.GetSoftwareAgent(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("xmp.iid:02801174072068118A6D9A879C818256",
      ret1.GetInstanceID(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("xmp.iid:03801174072068118A6D9A879C818256",
      ret2.GetInstanceID(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(2012,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(ret1.GetWhen(), 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(54,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(ret1.GetWhen(), 12), null);
    global::DripSharp.Testing.JavaAssertions.Equal(4,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(ret1.GetWhen(), 13), null);
    global::DripSharp.Testing.JavaAssertions.Equal(2012,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(ret2.GetWhen(), 1), null);
    global::DripSharp.Testing.JavaAssertions.Equal(54,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(ret2.GetWhen(), 12), null);
    global::DripSharp.Testing.JavaAssertions.Equal(48,
      global::DripSharp.Runtime.JavaCompat.CalendarGet(ret2.GetWhen(), 13), null);
    global::DripSharp.Testing.JavaAssertions.Equal("xmp.iid:49E997338D4911E1AB62EBF9B374B234",
      xmpMediaManagementSchema.GetInstanceID(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("xmp.did:49E997348D4911E1AB62EBF9B374B234",
      xmpMediaManagementSchema.GetDocumentID(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("xmp.did:01801174072068118A6D9A879C818256",
      xmpMediaManagementSchema.GetOriginalDocumentID(), null);
    global::DripSharp.PdfCarton.Xmp.Schema.PhotoshopSchema photoshopSchema
      = xmp.GetPhotoshopSchema();
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Xmp.Type.LayerType> textLayers
      = photoshopSchema.GetTextLayers();
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(textLayers), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Name1",
      global::DripSharp.Runtime.JavaCompat.ListGet(textLayers, 0).GetLayerName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Text1",
      global::DripSharp.Runtime.JavaCompat.ListGet(textLayers, 0).GetLayerText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Name2",
      global::DripSharp.Runtime.JavaCompat.ListGet(textLayers, 1).GetLayerName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Text2",
      global::DripSharp.Runtime.JavaCompat.ListGet(textLayers, 1).GetLayerText(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("2012-04-30T12:54:48+00:00",
      photoshopSchema.GetDateCreated(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("2012-05-03T09:34:50-04:00\tFile i1222b.jpg opened\n",
      photoshopSchema.GetHistory(), null);
    global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty ancestorsProperty
      = photoshopSchema.GetDocumentAncestorsProperty();
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Xmp.Type.AbstractField> ancestors
      = ancestorsProperty.GetAllProperties();
    global::DripSharp.Testing.JavaAssertions.Equal(3,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(ancestors), null);
    global::DripSharp.Testing.JavaAssertions.Equal("adobe:docid:photoshop:11d3ec5a-c131-11d8-9274-ec65c7d7e0c6",
      ((global::DripSharp.PdfCarton.Xmp.Type.TextType)(global::DripSharp.Runtime.JavaCompat.ListGet(ancestors,
      0)!)).GetStringValue(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("adobe:docid:photoshop:aadc7027-309c-11d8-9596-9cf45d2f630b",
      ((global::DripSharp.PdfCarton.Xmp.Type.TextType)(global::DripSharp.Runtime.JavaCompat.ListGet(ancestors,
      1)!)).GetStringValue(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("adobe:docid:photoshop:c7961c59-6e0f-11d8-87b7-d67539df12d8",
      ((global::DripSharp.PdfCarton.Xmp.Type.TextType)(global::DripSharp.Runtime.JavaCompat.ListGet(ancestors,
      2)!)).GetStringValue(), null);
  }

  internal virtual void testPDFBox5292() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xpacket begin=\"\u00EF\u00BB\u00BF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?>\n",
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.6-c015 84.159810, 2016/09/10-02:41:30        \">\n"),
      "    <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "        <rdf:Description rdf:about=\"\"\n"),
      "                         xmlns:xmp=\"http://ns.adobe.com/xap/1.0/\"\n"),
      "                         xmlns:dc=\"http://purl.org/dc/elements/1.1/\"\n"),
      "                         xmlns:pdf=\"http://ns.adobe.com/pdf/1.3/\"\n"),
      "                         xmlns:pdfaid=\"http://www.aiim.org/pdfa/ns/id/\"\n"),
      "                         xmlns:pdfaExtension=\"http://www.aiim.org/pdfa/ns/extension/\"\n"),
      "                         xmlns:pdfaSchema=\"http://www.aiim.org/pdfa/ns/schema#\"\n"),
      "                         xmlns:pdfaProperty=\"http://www.aiim.org/pdfa/ns/property#\"\n"),
      "                         xmlns:example=\"http://ns.example.org/default/1.0/\">\n"),
      "            <xmp:CreateDate>2021-05-21T11:42:49+01:00</xmp:CreateDate>\n"),
      "            <xmp:ModifyDate>2021-05-21T11:47:16+02:00</xmp:ModifyDate>\n"),
      "            <xmp:MetadataDate>2021-05-21T11:47:16+02:00</xmp:MetadataDate>\n"),
      "            <dc:format>application/pdf</dc:format>\n"), "            <dc:title>\n"),
      "                <rdf:Alt>\n"),
      "                    <rdf:li xml:lang=\"x-default\">Inline XMP Extension PoC</rdf:li>\n"),
      "                </rdf:Alt>\n"), "            </dc:title>\n"), "            <dc:creator>\n"),
      "                <rdf:Seq>\n"), "                    <rdf:li>DSO</rdf:li>\n"),
      "                </rdf:Seq>\n"), "            </dc:creator>\n"),
      "            <dc:description>\n"), "                <rdf:Alt>\n"),
      "                    <rdf:li xml:lang=\"x-default\">Inline XMP Extension PoC</rdf:li>\n"),
      "                </rdf:Alt>\n"), "            </dc:description>\n"),
      "            <pdf:Keywords/>\n"), "            <pdfaid:part>2</pdfaid:part>\n"),
      "            <pdfaid:conformance>A</pdfaid:conformance>\n"),
      "            <example:Data>Example</example:Data>\n"),
      "            <pdfaExtension:schemas>\n"), "                <rdf:Bag>\n"),
      "                    <rdf:li rdf:parseType=\"Resource\">\n"),
      "                        <pdfaSchema:schema>Simple Schema</pdfaSchema:schema>\n"),
      "                        <pdfaSchema:namespaceURI>http://ns.example.org/default/1.0/</pdfaSchema:namespaceURI>\n"),
      "                        <pdfaSchema:prefix>example</pdfaSchema:prefix>\n"),
      "                        <pdfaSchema:property>\n"),
      "                            <rdf:Seq>\n"),
      "                                <rdf:li rdf:parseType=\"Resource\">\n"),
      "                                    <pdfaProperty:name>Data</pdfaProperty:name>\n"),
      "                                    <pdfaProperty:valueType>Text</pdfaProperty:valueType>\n"),
      "                                    <pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "                                    <pdfaProperty:description>Example Data</pdfaProperty:description>\n"),
      "                                </rdf:li>\n"), "                            </rdf:Seq>\n"),
      "                        </pdfaSchema:property>\n"), "                    </rdf:li>\n"),
      "                    <rdf:li rdf:parseType=\"Resource\">\n"),
      "                        <pdfaSchema:namespaceURI>http://www.aiim.org/pdfa/ns/id/</pdfaSchema:namespaceURI>\n"),
      "                        <pdfaSchema:prefix>pdfaid</pdfaSchema:prefix>\n"),
      "                        <pdfaSchema:schema>PDF/A ID Schema</pdfaSchema:schema>\n"),
      "                        <pdfaSchema:property>\n"),
      "                            <rdf:Seq>\n"),
      "                                <rdf:li rdf:parseType=\"Resource\">\n"),
      "                                    <pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "                                    <pdfaProperty:description>Part of PDF/A standard</pdfaProperty:description>\n"),
      "                                    <pdfaProperty:name>part</pdfaProperty:name>\n"),
      "                                    <pdfaProperty:valueType>Integer</pdfaProperty:valueType>\n"),
      "                                </rdf:li>\n"),
      "                                <rdf:li rdf:parseType=\"Resource\">\n"),
      "                                    <pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "                                    <pdfaProperty:description>Conformance level of PDF/A standard</pdfaProperty:description>\n"),
      "                                    <pdfaProperty:name>conformance</pdfaProperty:name>\n"),
      "                                    <pdfaProperty:valueType>Text</pdfaProperty:valueType>\n"),
      "                                </rdf:li>\n"), "                            </rdf:Seq>\n"),
      "                        </pdfaSchema:property>\n"), "                    </rdf:li>\n"),
      "                </rdf:Bag>\n"), "            </pdfaExtension:schemas>\n"),
      "        </rdf:Description>\n"), "    </rdf:RDF>\n"), "</x:xmpmeta>\n"), "\n"),
      "<?xpacket end=\"w\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.PDFAIdentificationSchema pdfaIdSchema
      = xmp.GetPDFAIdentificationSchema();
    global::DripSharp.Testing.JavaAssertions.Equal(2, pdfaIdSchema.GetPart(), null);
    string dataValue = xmp.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "http://ns.example.org/default/1.0/")).GetUnqualifiedTextPropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "Data"));
    global::DripSharp.Testing.JavaAssertions.Equal("Example", dataValue, null);
  }

  internal virtual void testLenientBagSeqMixup() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xpacket begin='\uFEFF' id='W5M0MpCehiHzreSzNTczkc9d'?>\n",
      "<?adobe-xap-filters esc=\"CRLF\"?>\n"), "<x:xmpmeta xmlns:x='adobe:ns:meta/'>\n"),
      "\t<rdf:RDF xmlns:rdf='http://www.w3.org/1999/02/22-rdf-syntax-ns#'>\n"),
      "\t\t<rdf:Description xmlns:dc='http://purl.org/dc/elements/1.1/'\n"),
      "\t\t                 dc:format='application/pdf'>\n"), "\t\t\t<dc:subject>\n"),
      "\t\t\t\t<rdf:Seq>\n"), "\t\t\t\t\t<rdf:li>Important subject</rdf:li>\n"),
      "\t\t\t\t\t<rdf:li>Unimportant subject</rdf:li>\n"), "\t\t\t\t</rdf:Seq>\n"),
      "\t\t\t</dc:subject>\n"), "\t\t</rdf:Description>\n"), "\t</rdf:RDF>\n"), "</x:xmpmeta>\n"),
      "<?xpacket end='w'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Invalid array type, expecting Bag and found Seq [prefix=dc; name=subject]",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser2.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dublinCoreSchema
      = xmp.GetDublinCoreSchema();
    global::System.Collections.Generic.IList<string> subjects = dublinCoreSchema.GetSubjects();
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(subjects), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Important subject",
      global::DripSharp.Runtime.JavaCompat.ListGet(subjects, 0), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Unimportant subject",
      global::DripSharp.Runtime.JavaCompat.ListGet(subjects, 1), null);
  }

  internal virtual void testBadAttr() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?>\n"),
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\">\n"),
      "\t<rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "           <rdf:Description xmlns:xmpTPg=\"http://ns.adobe.com/xap/1.0/t/pg/\""),
      "                            xmlns:stDim=\"http://ns.adobe.com/xap/1.0/sType/Dimensions#\""),
      "\t\t                 rdf:about=\"\">\n"), "\t\t\t<xmpTPg:MaxPageSize>\n"),
      "\t\t\t\t<rdf:Description stDim:X=\"4\" stDim:Y=\"3\" stDim:Z=\"inch\"/>\n"),
      "\t\t\t</xmpTPg:MaxPageSize>\n"), "\t\t</rdf:Description>\n"), "\t</rdf:RDF>\n"),
      "</x:xmpmeta><?xpacket end=\"r\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("No type defined for {http://ns.adobe.com/xap/1.0/sType/Dimensions#}X",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser2.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPageTextSchema pageTextSchema
      = xmp.GetPageTextSchema();
    global::DripSharp.PdfCarton.Xmp.Type.DimensionsType dim
      = (global::DripSharp.PdfCarton.Xmp.Type.DimensionsType)(pageTextSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.XMPageTextSchema.MaxPageSize))!);
    global::DripSharp.Testing.JavaAssertions.Equal("DimensionsType{null x null null}",
      dim.ToString(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("[X=TextType:4]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(dim.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "X"))), null);
    global::DripSharp.Testing.JavaAssertions.Equal("[Y=TextType:3]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(dim.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "Y"))), null);
    global::DripSharp.Testing.JavaAssertions.Equal("[Z=TextType:inch]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(dim.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "Z"))), null);
  }

  internal virtual void testBadType() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin='' id='W5M0MpCehiHzreSzNTczkc9d'?>\n"),
      "<rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\"\n"),
      "         xmlns:iX=\"http://ns.adobe.com/iX/1.0/\">\n"),
      "\t<rdf:Description xmlns=\"http://ns.adobe.com/pdf/1.3/\"\n"),
      "\t                 xmlns:pdf=\"http://ns.adobe.com/pdf/1.3/\"\n"),
      "\t                 about=\"\"\n"), "\t                 pdf:Author=\"edocslib\"/>\n"),
      "</rdf:RDF>\n"), "<?xpacket end='r'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("No type defined for {http://ns.adobe.com/pdf/1.3/}Author",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser2.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.AdobePDFSchema adobePDFSchema = xmp.GetAdobePDFSchema();
    global::DripSharp.PdfCarton.Xmp.Type.TextType tt
      = (global::DripSharp.PdfCarton.Xmp.Type.TextType)(adobePDFSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "Author"))!);
    global::DripSharp.Testing.JavaAssertions.Equal("[Author=TextType:edocslib]", tt.ToString(),
      null);
  }

  internal virtual void testBadType2() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?>\n"),
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\"\n"), "           x:xmptk=\"3.1.1-111\">\n"),
      "\t<rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "\t\t<rdf:Description xmlns:pdf=\"http://ns.adobe.com/pdf/1.3/\"\n"),
      "\t\t                 rdf:about=\"\">\n"), "\t\t\t<pdf:Bad>Value</pdf:Bad>\n"),
      "\t\t</rdf:Description>\n"), "\t</rdf:RDF>\n"), "</x:xmpmeta><?xpacket end=\"r\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("No type defined for {http://ns.adobe.com/pdf/1.3/}Bad",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser2.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.Testing.JavaAssertions.Equal("Value",
      xmp.GetAdobePDFSchema().GetUnqualifiedTextPropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "Bad")), null);
  }

  internal virtual void testBadLocalName() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin='\uFEFF' id='W5M0MpCehiHzreSzNTczkc9d'?><?adobe-xap-filters esc=\"CR\"?>\n"),
      "<x:xapmeta xmlns:x=\"adobe:ns:meta/\">\n"),
      "\t<rdf:RDF xmlns:iX=\"http://ns.adobe.com/iX/1.0/\" xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "\t</rdf:RDF>\n"), "</x:xapmeta><?xpacket end='w'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Expecting local name 'xmpmeta' and found 'xapmeta'",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser2.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp2
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.Testing.JavaAssertions.Equal(0,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(xmp2.GetAllSchemas()), null);
  }

  internal virtual void testBadXPacketEnd1() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\" ?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\">\n"),
      "    <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "        <rdf:Description xmlns:dc=\"http://purl.org/dc/elements/1.1/\" rdf:about=\"\">\n"),
      "            <dc:format>application/pdf</dc:format>\n"), "        </rdf:Description>\n"),
      "    </rdf:RDF>\n"), "</x:xmpmeta><?xpacket ends=\"w\" ?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Expected xpacket 'end' attribute (must be present and placed in first)",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  internal virtual void testBadXPacketEnd2() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\" ?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\">\n"),
      "    <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "        <rdf:Description xmlns:dc=\"http://purl.org/dc/elements/1.1/\" rdf:about=\"\">\n"),
      "            <dc:format>application/pdf</dc:format>\n"), "        </rdf:Description>\n"),
      "    </rdf:RDF>\n"), "</x:xmpmeta><?xpacket end=\"k\" ?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Expected xpacket 'end' attribute with value 'r' or 'w' ",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  internal virtual void testNoRdfChildren() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\" ?>"),
      "  <x:xmpmeta xmlns:x=\"adobe:ns:meta/\"/>\n"), "<?xpacket end=\"w\" ?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("No rdf description found in xmp",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  internal virtual void testTextInsteadOfArray() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?>\n"),
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\"\n"), "           x:xmptk=\"3.1-701\">\n"),
      "\t<rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "\t\t<rdf:Description xmlns:dc=\"http://purl.org/dc/elements/1.1/\"\n"),
      "\t\t                 rdf:about=\"\">\n"), "\t\t\t<dc:title>Title</dc:title>\n"),
      "\t\t</rdf:Description>\n"), "\t</rdf:RDF>\n"), "</x:xmpmeta><?xpacket end=\"w\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Invalid array definition, expecting Alt and found Text [prefix=dc; name=title]",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  internal virtual void testPropertyNotDefined() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin='\uFEFF' id='W5M0MpCehiHzreSzNTczkc9d'?>\n"),
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\"\n"),
      "           x:xmptk=\"XMP toolkit 3.0-28, framework 1.6\">\n"),
      "\t<rdf:RDF xmlns:iX=\"http://ns.adobe.com/iX/1.0/\"\n"),
      "\t         xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "\t\t<rdf:Description xmlns:exif=\"http://ns.adobe.com/exif/1.0/\"\n"),
      "\t\t                 rdf:about=\"uuid:d9974396-53ee-11d9-9542-81b7ec7f4613\">\n"),
      "\t\t\t<exif:Flash rdf:parseType=\"Resource\">\n"),
      "\t\t\t\t<exif:Fired>False</exif:Fired>\n"), "\t\t\t</exif:Flash>\n"),
      "\t\t</rdf:Description>\n"), "\t</rdf:RDF>\n"), "</x:xmpmeta><?xpacket end='w'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Type.FlashType flash
      = (global::DripSharp.PdfCarton.Xmp.Type.FlashType)(xmp.GetSchema(typeof(global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema)).GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema.Flash))!);
    global::DripSharp.Testing.JavaAssertions.Equal("[Fired=BooleanType:False]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(flash.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Type.FlashType.Fired))), null);
  }

  internal virtual void testBadAttr2() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin='\uFEFF' id='W5M0MpCehiHzreSzNTczkc9d'?>\n"),
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\"\n"),
      "           x:xmptk=\"XMP toolkit 2.9.1-13, framework 1.6\">\n"),
      "\t<rdf:RDF xmlns:iX=\"http://ns.adobe.com/iX/1.0/\"\n"),
      "\t         xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "\t\t<rdf:Description xmlns:exif=\"http://ns.adobe.com/exif/1.0/\"\n"),
      "\t\t                 exif:FNumber=\"36/10\"\n"),
      "\t\t                 exif:FileSource=\"3\"\n"), "\t\t                 exif:Flash=\"1\"\n"),
      "\t\t                 rdf:about=\"\">\n"), "\t\t</rdf:Description>\n"), "\t</rdf:RDF>\n"),
      "</x:xmpmeta><?xpacket end='r'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("The type 'Flash' in 'exif:Flash=1' is a structured or array type, but attributes are simple types",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser2.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema exifSchema
      = (global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema)(xmp.GetSchema(typeof(global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema))!);
    global::DripSharp.Testing.JavaAssertions.Equal("[Flash=TextType:1]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(exifSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema.Flash))), null);
  }

  internal virtual void testBadAttr3() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin='' id='W5M0MpCehiHzreSzNTczkc9d' bytes='1064'?><rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "    <rdf:Description xmlns=\"http://purl.org/dc/elements/1.1/\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" about=\"\" dc:creator=\"Creator\" />\n"),
      "</rdf:RDF><?xpacket end='r'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("The type 'Text' in 'dc:creator=Creator' is a structured or array type, but attributes are simple types",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser2.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp2
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer serializer
      = new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer();
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    serializer.Serialize(xmp2, baos, true);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser3
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser3.Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Invalid array definition, expecting Seq and found Text [prefix=dc; name=creator]",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser4
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser4.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp4
      = xmpParser4.Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dublinCoreSchema
      = xmp4.GetDublinCoreSchema();
    global::DripSharp.Testing.JavaAssertions.Equal("[creator=TextType:Creator]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(dublinCoreSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema.Creator))), null);
  }

  internal virtual void testBadAttr4() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin='' id='W5M0MpCehiHzreSzNTczkc9d' bytes='1206'?><rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" >\n"),
      "    <rdf:Description xmlns=\"http://purl.org/dc/elements/1.1/\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" about=\"\" dc:creator=\"\">\n"),
      "        <dc:coverage>Coverage</dc:coverage>\n"), "    </rdf:Description>\n"),
      "</rdf:RDF><?xpacket end='r'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("The type 'Text' in 'dc:creator=' is a structured or array type, but attributes are simple types",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser2.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp2
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dublinCoreSchema2
      = xmp2.GetDublinCoreSchema();
    global::DripSharp.Testing.JavaAssertions.Equal("Coverage", dublinCoreSchema2.GetCoverage(),
      null);
    global::DripSharp.Testing.JavaAssertions.Null(dublinCoreSchema2.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema.Creator)), null);
    global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer serializer
      = new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer();
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    serializer.Serialize(xmp2, baos, true);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser3
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser3.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp3
      = xmpParser3.Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dublinCoreSchema3
      = xmp3.GetDublinCoreSchema();
    global::DripSharp.Testing.JavaAssertions.Equal("Coverage", dublinCoreSchema3.GetCoverage(),
      null);
    global::DripSharp.Testing.JavaAssertions.Null(dublinCoreSchema2.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema.Creator)), null);
  }

  internal virtual void testBadAttr5() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin='' id='W5M0MpCehiHzreSzNTczkc9d' bytes='987'?><rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" xmlns:iX=\"http://ns.adobe.com/iX/1.0/\">\n"),
      "    <rdf:Description xmlns=\"http://purl.org/dc/elements/1.1/\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" about=\"\" dc:title=\"\" dc:coverage=\"COVER\"/>\n"),
      "</rdf:RDF><?xpacket end='r'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("The type 'LangAlt' in 'dc:title=' is a structured or array type, but attributes are simple types",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser2.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp2
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dublinCoreSchema2
      = xmp2.GetDublinCoreSchema();
    global::DripSharp.Testing.JavaAssertions.Null(dublinCoreSchema2.GetTitle(), null);
    global::DripSharp.Testing.JavaAssertions.Null(dublinCoreSchema2.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema.Title)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("COVER", dublinCoreSchema2.GetCoverage(), null);
    global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer serializer
      = new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer();
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    serializer.Serialize(xmp2, baos, true);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser3
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser3.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp3
      = xmpParser3.Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dublinCoreSchema3
      = xmp3.GetDublinCoreSchema();
    global::DripSharp.Testing.JavaAssertions.Null(dublinCoreSchema3.GetTitle(), null);
    global::DripSharp.Testing.JavaAssertions.Null(dublinCoreSchema3.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema.Title)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("COVER", dublinCoreSchema3.GetCoverage(), null);
  }

  internal virtual void testBadSchema() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin='\uFEFF' id='W5M0MpCehiHzreSzNTczkc9d'?><?adobe-xap-filters esc=\"CRLF\"?>\n"),
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\"\n"), "           x:xmptk=\"XMP toolkit\">\n"),
      "\t<rdf:RDF xmlns:iX=\"http://ns.adobe.com/iX/1.0/\"\n"),
      "\t         xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "\t\t<rdf:Description xmlns:stJob=\"http://ns.adobe.com/xap/1.0/sType/Job#\"\n"),
      "\t\t                 rdf:about=\"uuid\"\n"), "\t\t                 stJob:id=\"jobid\"\n"),
      "\t\t                 stJob:name=\"some name\">\n"),
      "\t\t\t<stJob:URL>https://pdfbox.apache.org</stJob:URL>\n"), "\t\t</rdf:Description>\n"),
      "\t</rdf:RDF>\n"), "</x:xmpmeta><?xpacket end='w'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("This namespace is not from a schema: http://ns.adobe.com/xap/1.0/sType/Job#",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  internal virtual void testPDFBOX6126() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?>\n"),
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\"\n"),
      "           x:xmptk=\"Adobe XMP Core 5.1.0-jc003\">\n"),
      "\t<rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "\t\t<rdf:Description xmlns:dc=\"http://purl.org/dc/elements/1.1/\"\n"),
      "\t\t                 xmlns:pdf=\"http://ns.adobe.com/pdf/1.3/\"\n"),
      "\t\t                 xmlns:pdfaExtension=\"http://www.aiim.org/pdfa/ns/extension/\"\n"),
      "\t\t                 xmlns:pdfaProperty=\"http://www.aiim.org/pdfa/ns/property#\"\n"),
      "\t\t                 xmlns:pdfaSchema=\"http://www.aiim.org/pdfa/ns/schema#\"\n"),
      "\t\t                 xmlns:pdfaid=\"http://www.aiim.org/pdfa/ns/id/\"\n"),
      "\t\t                 xmlns:pdfuaid=\"http://www.aiim.org/pdfua/ns/id/\"\n"),
      "\t\t                 xmlns:xmp=\"http://ns.adobe.com/xap/1.0/\"\n"),
      "\t\t                 dc:format=\"application/pdf\"\n"),
      "\t\t                 pdf:Producer=\"iText\u00AE 5.5.13 \u00A92000-2018 iText Group NV (AGPL-version)\"\n"),
      "\t\t                 pdfaid:conformance=\"B\"\n"),
      "\t\t                 pdfaid:part=\"1\"\n"), "\t\t                 rdf:about=\"\"\n"),
      "\t\t                 xmp:CreateDate=\"2018-09-24T09:00:57+02:00\"\n"),
      "\t\t                 xmp:ModifyDate=\"2018-09-24T09:00:57+02:00\">\n"),
      "\t\t\t<pdfaExtension:schemas>\n"), "\t\t\t\t<rdf:Bag>\n"),
      "\t\t\t\t\t<rdf:li rdf:parseType=\"Resource\">\n"),
      "\t\t\t\t\t\t<rdf:Description pdfaSchema:namespaceURI=\"http://www.aiim.org/pdfua/ns/id/\"\n"),
      "\t\t\t\t\t\t                 pdfaSchema:prefix=\"pdfuaid\"\n"),
      "\t\t\t\t\t\t                 pdfaSchema:schema=\"PDF/UA identification schema\">\n"),
      "\t\t\t\t\t\t\t<pdfaSchema:property>\n"), "\t\t\t\t\t\t\t\t<rdf:Seq>\n"),
      "\t\t\t\t\t\t\t\t\t<rdf:li pdfaProperty:category=\"internal\"\n"),
      "\t\t\t\t\t\t\t\t\t        pdfaProperty:description=\"PDF/UA version identifier\"\n"),
      "\t\t\t\t\t\t\t\t\t        pdfaProperty:name=\"part\"\n"),
      "\t\t\t\t\t\t\t\t\t        pdfaProperty:valueType=\"Integer\"/>\n"),
      "\t\t\t\t\t\t\t\t\t<rdf:li pdfaProperty:category=\"internal\"\n"),
      "\t\t\t\t\t\t\t\t\t        pdfaProperty:description=\"PDF/UA amendment identifier\"\n"),
      "\t\t\t\t\t\t\t\t\t        pdfaProperty:name=\"amd\"\n"),
      "\t\t\t\t\t\t\t\t\t        pdfaProperty:valueType=\"Text\"/>\n"),
      "\t\t\t\t\t\t\t\t\t<rdf:li pdfaProperty:category=\"internal\"\n"),
      "\t\t\t\t\t\t\t\t\t        pdfaProperty:description=\"PDF/UA corrigenda identifier\"\n"),
      "\t\t\t\t\t\t\t\t\t        pdfaProperty:name=\"corr\"\n"),
      "\t\t\t\t\t\t\t\t\t        pdfaProperty:valueType=\"Text\"/>\n"),
      "\t\t\t\t\t\t\t\t</rdf:Seq>\n"), "\t\t\t\t\t\t\t</pdfaSchema:property>\n"),
      "\t\t\t\t\t\t</rdf:Description>\n"), "\t\t\t\t\t</rdf:li>\n"), "\t\t\t\t</rdf:Bag>\n"),
      "\t\t\t</pdfaExtension:schemas>\n"), "\t\t\t<pdfuaid:part>1</pdfuaid:part>\n"),
      "\t\t</rdf:Description>\n"), "\t</rdf:RDF>\n"), "</x:xmpmeta><?xpacket end=\"w\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp1
      = xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema uaSchema1
      = xmp1.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "http://www.aiim.org/pdfua/ns/id/"));
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      uaSchema1.GetIntegerPropertyValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "part")), null);
    global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer serializer
      = new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer();
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    serializer.Serialize(xmp1, baos, true);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp2
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema uaSchema2
      = xmp2.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "http://www.aiim.org/pdfua/ns/id/"));
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      uaSchema2.GetIntegerPropertyValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "part")), null);
  }

  internal virtual void testNonStandardURIinRDF() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 4.2.1-c041 52.342996, 2008/05/07-20:48:00        \">\n"),
      "    <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "        <rdf:Description xmlns:pdfx=\"http://ns.adobe.com/pdfx/1.3/\" rdf:about=\"\">\n"),
      "            <pdfx:XPressPrivate>private</pdfx:XPressPrivate>\n"),
      "        </rdf:Description>\n"), "    </rdf:RDF>\n"), "</x:xmpmeta><?xpacket end=\"w\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Cannot find a definition for the namespace http://ns.adobe.com/pdfx/1.3/, property: pdfx:XPressPrivate",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser2.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp2
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema2
      = xmp2.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "http://ns.adobe.com/pdfx/1.3/"));
    global::DripSharp.Testing.JavaAssertions.Equal("[XPressPrivate=TextType:private]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(schema2.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "XPressPrivate"))), null);
    global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer serializer
      = new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer();
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    serializer.Serialize(xmp2, baos, true);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringContains(global::DripSharp.Runtime.JavaCompat.MemoryStreamToString(baos,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "utf-8")),
      "<rdf:RDF xmlns:pdfx="), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser3
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser3.Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Cannot find a definition for the namespace http://ns.adobe.com/pdfx/1.3/, property: pdfx:XPressPrivate",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser4
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser4.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp4
      = xmpParser4.Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema4
      = xmp4.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "http://ns.adobe.com/pdfx/1.3/"));
    global::DripSharp.Testing.JavaAssertions.Equal("[XPressPrivate=TextType:private]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(schema4.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "XPressPrivate"))), null);
  }

  internal virtual void testBadProp() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin='' id='W5M0MpCehiHzreSzNTczkc9d' bytes='1506'?><rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" xmlns:iX=\"http://ns.adobe.com/iX/1.0/\">\n"),
      "    <rdf:Description xmlns=\"http://purl.org/dc/elements/1.1/\" xmlns:dc=\"http://purl.org/dc/elements/1.1/\" about=\"\">\n"),
      "        <dc:creator/>\n"), "        <dc:coverage>Cover</dc:coverage>\n"),
      "    </rdf:Description>\n"), "</rdf:RDF><?xpacket end='r'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Invalid array definition, expecting Seq and found nothing [prefix=dc; name=creator]",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser2.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp2
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dublinCoreSchema2
      = xmp2.GetDublinCoreSchema();
    global::DripSharp.Testing.JavaAssertions.Null(dublinCoreSchema2.GetCreators(), null);
    global::DripSharp.Testing.JavaAssertions.Null(dublinCoreSchema2.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema.Creator)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Cover", dublinCoreSchema2.GetCoverage(), null);
    global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer serializer
      = new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer();
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    serializer.Serialize(xmp2, baos, true);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser3
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser3.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp3
      = xmpParser3.Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dublinCoreSchema3
      = xmp3.GetDublinCoreSchema();
    global::DripSharp.Testing.JavaAssertions.Null(dublinCoreSchema3.GetCreators(), null);
    global::DripSharp.Testing.JavaAssertions.Null(dublinCoreSchema3.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema.Creator)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Cover", dublinCoreSchema3.GetCoverage(), null);
  }

  internal virtual void testBadProp2() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"3.1-701\">\n"),
      "    <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "        <rdf:Description xmlns:stRef=\"http://ns.adobe.com/xap/1.0/sType/ResourceRef#\" xmlns:xapMM=\"http://ns.adobe.com/xap/1.0/mm/\" rdf:about=\"\">\n"),
      "            <xapMM:DocumentID>uuid:CE03288B61A6DB11A55CA11F14F48514</xapMM:DocumentID>\n"),
      "            <xapMM:InstanceID>uuid:474647e9-680a-47dc-83d5-ba3f3a7e2a67</xapMM:InstanceID>\n"),
      "            <xapMM:DerivedFrom rdf:parseType=\"Resource\">\n"),
      "                <stRef:documentName>uuid:8705447f-b80d-4cc8-82f7-0ec27187edfe</stRef:documentName>\n"),
      "                <stRef:documentID>uuid:b2f88223-2723-430d-b93c-3503ccb0e34b</stRef:documentID>\n"),
      "            </xapMM:DerivedFrom>\n"), "        </rdf:Description>\n"), "    </rdf:RDF>\n"),
      "</x:xmpmeta><?xpacket end=\"w\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Type 'stRef:documentName' not defined in http://ns.adobe.com/xap/1.0/sType/ResourceRef#",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser2.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp2
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPMediaManagementSchema xmpMediaManagementSchema
      = xmp2.GetXMPMediaManagementSchema();
    global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType derived
      = xmpMediaManagementSchema.GetDerivedFromProperty();
    global::DripSharp.Testing.JavaAssertions.Equal("uuid:b2f88223-2723-430d-b93c-3503ccb0e34b",
      derived.GetDocumentID(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("[documentName=TextType:uuid:8705447f-b80d-4cc8-82f7-0ec27187edfe]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(derived.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "documentName"))), null);
  }

  internal virtual void testParseFailure() {
    string s = "<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>";
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.StringStartsWith(global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "Failed to parse: ")), null);
  }

  internal virtual void testNoXPacket() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?packet begin=\"\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"3.1-701\">\n"),
      "</x:xmpmeta><?packet end=\"w\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Bad processing instruction name : packet",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  internal virtual void testDoubleEnd() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xpacket begin='' id='W5M0MpCehiHzreSzNTczkc9d'?> \n",
      "<?xpacket begin='' id='W5M0MpCehiHzreSzNTczkc9d'?> \n"),
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\"\n"),
      "           x:xmptk=\"Adobe XMP Core 4.0-c316 44.253921, Sun Oct 01 2006 17:14:39\">\n"),
      "\t<rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"), "\t</rdf:RDF>\n"),
      "</x:xmpmeta> \n"), "<?xpacket end=\"w\"?> \n"), "<?xpacket end='r'?> ");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("xmp should end after xpacket end processing instruction",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  internal virtual void testBadInner() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.2-c001 63.139439, 2010/09/27-13:37:26        \">\n"),
      "    <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "        <rdf:Description xmlns:dc=\"http://purl.org/dc/elements/1.1/\" xmlns:pdf=\"http://ns.adobe.com/pdf/1.3/\" xmlns:photoshop=\"http://ns.adobe.com/photoshop/1.0/\" xmlns:stEvt=\"http://ns.adobe.com/xap/1.0/sType/ResourceEvent#\" xmlns:stRef=\"http://ns.adobe.com/xap/1.0/sType/ResourceRef#\"  xmlns:xmpMM=\"http://ns.adobe.com/xap/1.0/mm/\" xmlns:xmpRights=\"http://ns.adobe.com/xap/1.0/rights/\">\n"),
      "            <xmpMM:DerivedFrom xmpMM:parseType=\"Resource\">\n"),
      "                <stRef:instanceID>uuid:6b838c4d-07e2-0611-2333-558805f93988</stRef:instanceID>\n"),
      "                <stRef:documentID>uuid:6b838c4d-07e2-0611-2333-558805f93988</stRef:documentID>\n"),
      "            </xmpMM:DerivedFrom>\n"), "        </rdf:Description>\n"), "    </rdf:RDF>\n"),
      "</x:xmpmeta><?xpacket end=\"w\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("inner element should contain child elements : [stRef:instanceID: null]",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    string s2 = global::DripSharp.Runtime.JavaCompat.ReplaceOrdinal(s, "xmpMM:parseType",
      "rdf:parseType");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp2
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s2,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPMediaManagementSchema xmpMediaManagementSchema
      = xmp2.GetXMPMediaManagementSchema();
    global::DripSharp.PdfCarton.Xmp.Type.ResourceRefType derivedFromProperty
      = xmpMediaManagementSchema.GetDerivedFromProperty();
    global::DripSharp.Testing.JavaAssertions.Equal("uuid:6b838c4d-07e2-0611-2333-558805f93988",
      derivedFromProperty.GetInstanceID(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("uuid:6b838c4d-07e2-0611-2333-558805f93988",
      derivedFromProperty.GetDocumentID(), null);
  }

  internal virtual void testBadRdfNameSpace() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"XXX\">\n"),
      "    <rdf:RDF xmlns:rdf=\"https://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "    </rdf:RDF>\n"), "</x:xmpmeta><?xpacket end=\"w\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Expecting namespace 'http://www.w3.org/1999/02/22-rdf-syntax-ns#' and found 'https://www.w3.org/1999/02/22-rdf-syntax-ns#'",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  internal virtual void testTypeInLiResourceElement() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\">\n"),
      "    <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "        <rdf:Description xmlns:xmpMM=\"http://ns.adobe.com/xap/1.0/mm/\" rdf:about=\"\">\n"),
      "            <xmpMM:History>\n"), "                <rdf:Seq>\n"),
      "                    <rdf:li xmlns:stEvt=\"http://ns.adobe.com/xap/1.0/sType/ResourceEvent#\" rdf:parseType=\"Resource\">\n"),
      "                        <stEvt:action>created</stEvt:action>\n"),
      "                        <stEvt:parameters>original PDF file</stEvt:parameters>\n"),
      "                    </rdf:li>\n"), "                </rdf:Seq>\n"),
      "            </xmpMM:History>\n"), "        </rdf:Description>\n"), "    </rdf:RDF>\n"),
      "</x:xmpmeta><?xpacket end=\"w\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp2
      = xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPMediaManagementSchema xmpMediaManagementSchema
      = xmp2.GetXMPMediaManagementSchema();
    global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty historyProperty
      = xmpMediaManagementSchema.GetHistoryProperty();
    global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType firstHistoryEntry
      = (global::DripSharp.PdfCarton.Xmp.Type.ResourceEventType)(global::DripSharp.Runtime.JavaCompat.Iterator(historyProperty.GetAllProperties()).Next()!);
    global::DripSharp.Testing.JavaAssertions.Equal("created", firstHistoryEntry.GetAction(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("original PDF file",
      firstHistoryEntry.GetParameters(), null);
  }

  internal virtual void testLenientPdfaExtension() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?>\n",
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\"\n"),
      "           x:xmptk=\"Adobe XMP Core 4.2.1-c043 52.372728, 2009/01/18-15:08:04\">\n"),
      "\t<rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "\t\t<rdf:Description rdf:about=\"\"\n"),
      "\t\t                 xmlns:xmpMM=\"http://ns.adobe.com/xap/1.0/mm/\">\n"),
      "\t\t\t<xmpMM:DocumentID>uuid:0b306144-6a43-dcbd-6b3e-c6b6b1df873d</xmpMM:DocumentID>\n"),
      "\t\t\t<xmpMM:InstanceID>uuid:0b306144-6a43-dcbd-6b3e-c6b6b1df873d</xmpMM:InstanceID>\n"),
      "\t\t</rdf:Description>\n"), "\t\t<rdf:Description rdf:about=\"\"\n"),
      "\t\t                 xmlns:pdfaExtension=\"http://www.aiim.org/pdfa/ns/extension/\"\n"),
      "\t\t                 xmlns:pdfaSchema=\"http://www.aiim.org/pdfa/ns/schema#\"\n"),
      "\t\t                 xmlns:pdfaProperty=\"http://www.aiim.org/pdfa/ns/property#\">\n"),
      "\t\t\t<pdfaExtension:schemas>\n"), "\t\t\t\t<rdf:Bag>\n"),
      "\t\t\t\t\t<rdf:li rdf:parseType=\"Resource\">\n"),
      "\t\t\t\t\t\t<pdfaSchema:namespaceURI>http://ns.adobe.com/pdf/1.3/</pdfaSchema:namespaceURI>\n"),
      "\t\t\t\t\t\t<pdfaSchema:prefix>pdf</pdfaSchema:prefix>\n"),
      "\t\t\t\t\t\t<pdfaSchema:schema>Adobe PDF Schema</pdfaSchema:schema>\n"),
      "\t\t\t\t\t</rdf:li>\n"), "\t\t\t\t\t<rdf:li rdf:parseType=\"Resource\">\n"),
      "\t\t\t\t\t\t<pdfaSchema:namespaceURI>http://ns.adobe.com/xap/1.0/mm/</pdfaSchema:namespaceURI>\n"),
      "\t\t\t\t\t\t<pdfaSchema:prefix>xmpMM</pdfaSchema:prefix>\n"),
      "\t\t\t\t\t\t<pdfaSchema:schema>XMP Media Management Schema</pdfaSchema:schema>\n"),
      "\t\t\t\t\t\t<pdfaSchema:property>\n"), "\t\t\t\t\t\t\t<rdf:Seq>\n"),
      "\t\t\t\t\t\t\t\t<rdf:li rdf:parseType=\"Resource\">\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:description>UUID based identifier for specific incarnation of a document</pdfaProperty:description>\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:name>InstanceID</pdfaProperty:name>\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:valueType>URI</pdfaProperty:valueType>\n"),
      "\t\t\t\t\t\t\t\t</rdf:li>\n"), "\t\t\t\t\t\t\t</rdf:Seq>\n"),
      "\t\t\t\t\t\t</pdfaSchema:property>\n"), "\t\t\t\t\t</rdf:li>\n"),
      "\t\t\t\t\t<rdf:li rdf:parseType=\"Resource\">\n"),
      "\t\t\t\t\t\t<pdfaSchema:namespaceURI>http://www.aiim.org/pdfa/ns/id/</pdfaSchema:namespaceURI>\n"),
      "\t\t\t\t\t\t<pdfaSchema:prefix>pdfaid</pdfaSchema:prefix>\n"),
      "\t\t\t\t\t\t<pdfaSchema:schema>PDF/A ID Schema</pdfaSchema:schema>\n"),
      "\t\t\t\t\t\t<pdfaSchema:property>\n"), "\t\t\t\t\t\t\t<rdf:Seq>\n"),
      "\t\t\t\t\t\t\t\t<rdf:li rdf:parseType=\"Resource\">\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:description>Part of PDF/A standard</pdfaProperty:description>\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:name>part</pdfaProperty:name>\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:valueType>Integer</pdfaProperty:valueType>\n"),
      "\t\t\t\t\t\t\t\t</rdf:li>\n"), "\t\t\t\t\t\t\t\t<rdf:li rdf:parseType=\"Resource\">\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:description>Amendment of PDF/A standard</pdfaProperty:description>\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:name>amd</pdfaProperty:name>\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:valueType>Text</pdfaProperty:valueType>\n"),
      "\t\t\t\t\t\t\t\t</rdf:li>\n"), "\t\t\t\t\t\t\t\t<rdf:li rdf:parseType=\"Resource\">\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:description>Conformance level of PDF/A standard</pdfaProperty:description>\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:name>conformance</pdfaProperty:name>\n"),
      "\t\t\t\t\t\t\t\t\t<pdfaProperty:valueType>Text</pdfaProperty:valueType>\n"),
      "\t\t\t\t\t\t\t\t</rdf:li>\n"), "\t\t\t\t\t\t\t</rdf:Seq>\n"),
      "\t\t\t\t\t\t</pdfaSchema:property>\n"), "\t\t\t\t\t</rdf:li>\n"), "\t\t\t\t</rdf:Bag>\n"),
      "\t\t\t</pdfaExtension:schemas>\n"), "\t\t</rdf:Description>\n"), "\t</rdf:RDF>\n"),
      "</x:xmpmeta>\n"), "<?xpacket end=\"w\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Missing pdfaSchema:property in type definition",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.Testing.JavaAssertions.True(xmpParser2.IsStrictParsing(), null);
    xmpParser2.SetStrictParsing(false);
    global::DripSharp.Testing.JavaAssertions.False(xmpParser2.IsStrictParsing(), null);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp2
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPMediaManagementSchema xmpMediaManagementSchema
      = xmp2.GetXMPMediaManagementSchema();
    global::DripSharp.Testing.JavaAssertions.Equal("uuid:0b306144-6a43-dcbd-6b3e-c6b6b1df873d",
      xmpMediaManagementSchema.GetInstanceID(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("uuid:0b306144-6a43-dcbd-6b3e-c6b6b1df873d",
      xmpMediaManagementSchema.GetDocumentID(), null);
  }

  internal virtual void testNoProcessingInstruction() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 4.1-c037 46.282696, Mon Apr 02 2007 18:36:42        \">\n",
      " <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "  <rdf:Description rdf:about=\"\"\n"),
      "    xmlns:xapMM=\"http://ns.adobe.com/xap/1.0/mm/\"\n"),
      "    xmlns:stRef=\"http://ns.adobe.com/xap/1.0/sType/ResourceRef#\"\n"),
      "    xmlns:tiff=\"http://ns.adobe.com/tiff/1.0/\"\n"),
      "    xmlns:xap=\"http://ns.adobe.com/xap/1.0/\"\n"),
      "    xmlns:exif=\"http://ns.adobe.com/exif/1.0/\"\n"),
      "    xmlns:dc=\"http://purl.org/dc/elements/1.1/\"\n"),
      "    xmlns:photoshop=\"http://ns.adobe.com/photoshop/1.0/\"\n"),
      "   xapMM:DocumentID=\"uuid:F1FEDA1D7D03DA11B0F6E4B4E63B0143\"\n"),
      "   xapMM:InstanceID=\"uuid:7A28FBF56920DA11B4BBB356C0A5C72B\"\n"),
      "   tiff:Orientation=\"1\"\n"), "   tiff:XResolution=\"3050000/10000\"\n"),
      "   tiff:YResolution=\"3050000/10000\"\n"), "   tiff:ResolutionUnit=\"2\"\n"),
      "   tiff:NativeDigest=\"123456\"\n"), "   xap:ModifyDate=\"2005-09-08T09:13:10-04:00\"\n"),
      "   xap:CreatorTool=\"Adobe Photoshop CS2 Windows\"\n"),
      "   xap:CreateDate=\"2005-08-02T13:47:24-04:00\"\n"),
      "   xap:MetadataDate=\"2005-09-08T09:13:10-04:00\"\n"), "   exif:ColorSpace=\"-1\"\n"),
      "   exif:PixelXDimension=\"1525\"\n"), "   exif:PixelYDimension=\"387\"\n"),
      "   exif:NativeDigest=\"12345678\"\n"), "   dc:format=\"image/tiff\"\n"),
      "   photoshop:ColorMode=\"4\"\n"), "   photoshop:ICCProfile=\"U.S. Web Coated (SWOP) v2\"\n"),
      "   photoshop:History=\"\">\n"), "   <xapMM:DerivedFrom\n"),
      "    stRef:instanceID=\"adobe:docid:photoshop:28ff3dc5-4801-11d8-85d1-bb49d244e2ef\"\n"),
      "    stRef:documentID=\"adobe:docid:photoshop:28ff3dc5-4801-11d8-85d1-bb49d244e2ef\"/>\n"),
      "  </rdf:Description>\n"), " </rdf:RDF>\n"), "</x:xmpmeta>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("xmp should start with a processing instruction",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser2.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp2
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dublinCoreSchema
      = xmp2.GetDublinCoreSchema();
    global::DripSharp.Testing.JavaAssertions.Equal("image/tiff", dublinCoreSchema.GetFormat(),
      null);
    global::DripSharp.PdfCarton.Xmp.Schema.XMPMediaManagementSchema xmpMediaManagementSchema
      = xmp2.GetXMPMediaManagementSchema();
    global::DripSharp.Testing.JavaAssertions.Equal("uuid:F1FEDA1D7D03DA11B0F6E4B4E63B0143",
      xmpMediaManagementSchema.GetDocumentID(), null);
    global::DripSharp.PdfCarton.Xmp.Schema.TiffSchema tiffSchema
      = (global::DripSharp.PdfCarton.Xmp.Schema.TiffSchema)(xmp2.GetSchema(typeof(global::DripSharp.PdfCarton.Xmp.Schema.TiffSchema))!);
    global::DripSharp.Testing.JavaAssertions.Equal("[Orientation=IntegerType:1]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(tiffSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.TiffSchema.Orientation))), null);
    global::DripSharp.PdfCarton.Xmp.Schema.PhotoshopSchema photoshopSchema
      = xmp2.GetPhotoshopSchema();
    global::DripSharp.Testing.JavaAssertions.Equal(4, photoshopSchema.GetColorMode(), null);
    global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema exifSchema
      = (global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema)(xmp2.GetSchema(typeof(global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema))!);
    global::DripSharp.Testing.JavaAssertions.Equal("[PixelXDimension=IntegerType:1525]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(exifSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema.PixelXDimension))), null);
    global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicSchema xmpBasicSchema = xmp2.GetXMPBasicSchema();
    global::DripSharp.Testing.JavaAssertions.Equal("Adobe Photoshop CS2 Windows",
      xmpBasicSchema.GetCreatorTool(), null);
    global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer serializer
      = new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer();
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    serializer.Serialize(xmp2, baos, true);
    string s2 = global::DripSharp.Runtime.JavaCompat.MemoryStreamToString(baos,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "utf-8"));
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.StringContains(s2,
      " ColorMode="), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.StringContains(s2,
      " CreateDate="), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.StringContains(s2,
      " CreatorTool="), null);
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.StringContains(s2,
      " DocumentID="), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser3
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser3.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp3
      = xmpParser3.Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dublinCoreSchema3
      = xmp3.GetDublinCoreSchema();
    global::DripSharp.Testing.JavaAssertions.Equal("image/tiff", dublinCoreSchema3.GetFormat(),
      null);
    global::DripSharp.PdfCarton.Xmp.Schema.XMPMediaManagementSchema xmpMediaManagementSchema3
      = xmp3.GetXMPMediaManagementSchema();
    global::DripSharp.Testing.JavaAssertions.Equal("uuid:F1FEDA1D7D03DA11B0F6E4B4E63B0143",
      xmpMediaManagementSchema3.GetDocumentID(), null);
    global::DripSharp.PdfCarton.Xmp.Schema.TiffSchema tiffSchema3
      = (global::DripSharp.PdfCarton.Xmp.Schema.TiffSchema)(xmp3.GetSchema(typeof(global::DripSharp.PdfCarton.Xmp.Schema.TiffSchema))!);
    global::DripSharp.Testing.JavaAssertions.Equal("[Orientation=IntegerType:1]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(tiffSchema3.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.TiffSchema.Orientation))), null);
    global::DripSharp.PdfCarton.Xmp.Schema.PhotoshopSchema photoshopSchema3
      = xmp3.GetPhotoshopSchema();
    global::DripSharp.Testing.JavaAssertions.Equal(4, photoshopSchema3.GetColorMode(), null);
    global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema exifSchema3
      = (global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema)(xmp3.GetSchema(typeof(global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema))!);
    global::DripSharp.Testing.JavaAssertions.Equal("[PixelXDimension=IntegerType:1525]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(exifSchema3.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema.PixelXDimension))), null);
    global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicSchema xmpBasicSchema3
      = xmp3.GetXMPBasicSchema();
    global::DripSharp.Testing.JavaAssertions.Equal("Adobe Photoshop CS2 Windows",
      xmpBasicSchema3.GetCreatorTool(), null);
  }

  internal virtual void testNoSchema() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 5.6-c016 91.163616, 2018/10/29-16:58:49        \">\n"),
      "    <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "        <rdf:Description xmlns:xmp=\"http://ns.adobe.com/xap/1.0/\" xmlns:pdf=\"http://ns.adobe.com/pdf/1.3/\" rdf:about=\"\">\n"),
      "            <xml:ModifyDate>2019-07-26'T'19:28:53.000'-04:00'</xml:ModifyDate>\n"),
      "            <xmp:ModifyDate>2019-07-29T15:12:07-04:00</xmp:ModifyDate>\n"),
      "            <pdf:Producer>iTextSharp 4.0.3 (based on iText 2.0.2)</pdf:Producer>\n"),
      "        </rdf:Description>\n"), "    </rdf:RDF>\n"), "</x:xmpmeta><?xpacket end=\"w\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Schema is not set in this document : http://www.w3.org/XML/1998/namespace, property: xml:ModifyDate",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  internal virtual void testNoInstantiation() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin='\uFEFF' id='W5M0MpCehiHzreSzNTczkc9d'?><?adobe-xap-filters esc=\"CRLF\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"XMP toolkit 2.9.1-13, framework 1.6\">\n"),
      "    <rdf:RDF xmlns:iX=\"http://ns.adobe.com/iX/1.0/\" xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "        <rdf:Description xmlns:xmp=\"http://ns.adobe.com/xap/1.0/\" rdf:about=\"uuid:f577a812-a531-11f4-0000-2eba1231b686\">\n"),
      "            <xmp:CreateDate>2019-05-02T22:03:5Z</xmp:CreateDate>\n"),
      "        </rdf:Description>\n"), "    </rdf:RDF>\n"), "</x:xmpmeta><?xpacket end='w'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Failed to instantiate DateType property with value '2019-05-02T22:03:5Z' in xmp:CreateDate",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  internal virtual void testNoInstantiation2() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin='\uFEFF' id='W5M0MpCehiHzreSzNTczkc9d'?><?adobe-xap-filters esc=\"CRLF\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"XMP toolkit 2.9.1-13, framework 1.6\">\n"),
      "    <rdf:RDF xmlns:iX=\"http://ns.adobe.com/iX/1.0/\" xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "        <rdf:Description xmlns:xap=\"http://ns.adobe.com/xap/1.0/\" xap:CreateDate=\"2016-03-09T19:47:1Z\">\n"),
      "            <xap:CreatorTool>PrimoPDF http://www.primopdf.com</xap:CreatorTool>\n"),
      "        </rdf:Description>\n"), "    </rdf:RDF>\n"), "</x:xmpmeta><?xpacket end='w'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Failed to instantiate DateType property with value '2016-03-09T19:47:1Z' in xap:CreateDate",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
  }

  internal virtual void testPDFBox6131() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/org/apache/xmpbox/xml/PDFBOX-6131-0015675.xml"))) {
      global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
        = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
      global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp = xmpParser.Parse(@is);
      global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema uaSchema2
        = xmp.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "http://www.aiim.org/pdfua/ns/id/"));
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        uaSchema2.GetIntegerPropertyValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "part")), null);
    }
  }

  internal virtual void testWrongType() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin=\"\uFEFF\" id=\"W5M0MpCehiHzreSzNTczkc9d\"?><x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 4.0-c316 44.253921, Sun Oct 01 2006 17:14:39\">\n"),
      "    <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "        <rdf:Description xmlns:photoshop=\"http://ns.adobe.com/photoshop/1.0/\" rdf:about=\"\">\n"),
      "            <photoshop:headline>\n"), "                <rdf:Seq>\n"),
      "                    <rdf:li/>\n"), "                </rdf:Seq>\n"),
      "            </photoshop:headline>\n"), "        </rdf:Description>\n"), "    </rdf:RDF>\n"),
      "</x:xmpmeta><?xpacket end=\"w\"?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser1
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException ex
      = global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpParsingException>(()
      => xmpParser1.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8)), null);
    global::DripSharp.Testing.JavaAssertions.Equal("No type defined for {http://ns.adobe.com/photoshop/1.0/}headline",
      global::DripSharp.Runtime.JavaCompat.ExceptionMessage(ex), null);
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser2
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser2.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp2
      = xmpParser2.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.PhotoshopSchema photoshopSchema
      = xmp2.GetPhotoshopSchema();
    global::DripSharp.Testing.JavaAssertions.Null(photoshopSchema.GetHeadline(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("[headline=TextType:]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(photoshopSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "headline"))), null);
  }

  internal virtual void testPDFBox6131_2() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/org/apache/xmpbox/xml/PDFBOX-6131-RMR6DEEUWZO6IM3A7WKRPX33SZMBTTQZ.xml"))) {
      global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
        = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
      global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp = xmpParser.Parse(@is);
      global::DripSharp.Testing.JavaAssertions.Equal(1, xmp.GetPDFAIdentificationSchema().GetPart(),
        null);
    }
  }

  internal virtual void testPDFBox6133() {
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "/org/apache/xmpbox/xml/PDFBOX-6133-0064638.xml"))) {
      global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
        = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
      global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp = xmpParser.Parse(@is);
      global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema epaSchema
        = xmp.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "http://www.epo.org/patent-bibliographic-data/1.0/"));
      global::DripSharp.Testing.JavaAssertions.Equal("[TotalNumberOfPages=RealType:47.0]",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(epaSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "TotalNumberOfPages"))), null);
      global::DripSharp.PdfCarton.Xmp.Type.DefinedStructuredType pub
        = (global::DripSharp.PdfCarton.Xmp.Type.DefinedStructuredType)(epaSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "Publication"))!);
      global::DripSharp.Testing.JavaAssertions.Equal("[CountryCode=TextType:EP]",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(pub.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "CountryCode"))), null);
      global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty classification
        = (global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty)(epaSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "Classification"))!);
      global::DripSharp.Testing.JavaAssertions.Equal(4,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(classification.GetAllProperties()),
        null);
      global::DripSharp.PdfCarton.Xmp.Type.TextType class3
        = (global::DripSharp.PdfCarton.Xmp.Type.TextType)(global::DripSharp.Runtime.JavaCompat.ListGet(classification.GetAllProperties(),
        3)!);
      global::DripSharp.Testing.JavaAssertions.Equal("A61K 39/215 20060101ALI20160203BHEP",
        class3.GetStringValue(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("CORONAVIRUS",
        epaSchema.GetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "Title"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "de")), null);
      global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty documentStructure
        = (global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty)(epaSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "DocumentStructure"))!);
      global::DripSharp.Testing.JavaAssertions.Equal(5,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(documentStructure.GetAllProperties()),
        null);
      global::DripSharp.PdfCarton.Xmp.Type.DefinedStructuredType struct4
        = (global::DripSharp.PdfCarton.Xmp.Type.DefinedStructuredType)(global::DripSharp.Runtime.JavaCompat.ListGet(documentStructure.GetAllProperties(),
        4)!);
      global::DripSharp.Testing.JavaAssertions.Equal("[DocumentSection=TextType:cited-references]",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(struct4.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "DocumentSection"))), null);
      global::DripSharp.Testing.JavaAssertions.Equal("[StartPage=RealType:47.0]",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(struct4.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "StartPage"))), null);
      global::DripSharp.Testing.JavaAssertions.Equal("[NumberOfPages=RealType:1.0]",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(struct4.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "NumberOfPages"))), null);
      global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer serializer
        = new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer();
      global::DripSharp.Runtime.JavaByteArrayOutputStream baos
        = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
      serializer.Serialize(xmp, baos, true);
      xmp
        = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser().Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos));
      epaSchema = xmp.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "http://www.epo.org/patent-bibliographic-data/1.0/"));
      global::DripSharp.Testing.JavaAssertions.Equal("[TotalNumberOfPages=RealType:47.0]",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(epaSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "TotalNumberOfPages"))), null);
      pub
        = (global::DripSharp.PdfCarton.Xmp.Type.DefinedStructuredType)(epaSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "Publication"))!);
      global::DripSharp.Testing.JavaAssertions.Equal("[CountryCode=TextType:EP]",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(pub.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "CountryCode"))), null);
      classification
        = (global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty)(epaSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "Classification"))!);
      global::DripSharp.Testing.JavaAssertions.Equal(4,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(classification.GetAllProperties()),
        null);
      class3
        = (global::DripSharp.PdfCarton.Xmp.Type.TextType)(global::DripSharp.Runtime.JavaCompat.ListGet(classification.GetAllProperties(),
        3)!);
      global::DripSharp.Testing.JavaAssertions.Equal("A61K 39/215 20060101ALI20160203BHEP",
        class3.GetStringValue(), null);
      global::DripSharp.Testing.JavaAssertions.Equal("CORONAVIRUS",
        epaSchema.GetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "Title"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "de")), null);
      documentStructure
        = (global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty)(epaSchema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "DocumentStructure"))!);
      global::DripSharp.Testing.JavaAssertions.Equal(5,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(documentStructure.GetAllProperties()),
        null);
      struct4
        = (global::DripSharp.PdfCarton.Xmp.Type.DefinedStructuredType)(global::DripSharp.Runtime.JavaCompat.ListGet(documentStructure.GetAllProperties(),
        4)!);
      global::DripSharp.Testing.JavaAssertions.Equal("[DocumentSection=TextType:cited-references]",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(struct4.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "DocumentSection"))), null);
      global::DripSharp.Testing.JavaAssertions.Equal("[StartPage=RealType:47.0]",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(struct4.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "StartPage"))), null);
      global::DripSharp.Testing.JavaAssertions.Equal("[NumberOfPages=RealType:1.0]",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(struct4.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        "NumberOfPages"))), null);
    }
  }

  internal virtual void testPropertyNotDefined2() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin='\uFEFF' id='W5M0MpCehiHzreSzNTczkc9d'?>\n"),
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\"\n"),
      "           x:xmptk=\"Adobe XMP Core 4.0-c006 1.236519, Wed Jun 14 2006 08:31:24\">\n"),
      "\t<rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"),
      "\t\t<rdf:Description xmlns:dc=\"http://purl.org/dc/elements/1.1/\"\n"),
      "\t\t                 xmlns:exif=\"http://ns.adobe.com/exif/1.0/\">\n"),
      "\t\t\t<exif:CFAPattern>\n"), "\t\t\t\t<rdf:Description>\n"), "\t\t\t\t\t<exif:Values>\n"),
      "\t\t\t\t\t\t<rdf:Seq>\n"), "\t\t\t\t\t\t\t<rdf:li>1</rdf:li>\n"),
      "\t\t\t\t\t\t\t<rdf:li>2</rdf:li>\n"), "\t\t\t\t\t\t\t<rdf:li>0</rdf:li>\n"),
      "\t\t\t\t\t\t\t<rdf:li>1</rdf:li>\n"), "\t\t\t\t\t\t</rdf:Seq>\n"),
      "\t\t\t\t\t</exif:Values>\n"), "\t\t\t\t</rdf:Description>\n"), "\t\t\t</exif:CFAPattern>\n"),
      "\t\t</rdf:Description>\n"), "\t</rdf:RDF>\n"), "</x:xmpmeta><?xpacket end='w'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Type.CFAPatternType cfa
      = (global::DripSharp.PdfCarton.Xmp.Type.CFAPatternType)(xmp.GetSchema(typeof(global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema)).GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema.CfaPattern))!);
    global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty ap
      = (global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty)(cfa.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.PdfCarton.Xmp.Type.CFAPatternType.Values))!);
    global::DripSharp.Testing.JavaAssertions.Equal("[1, 2, 0, 1]",
      global::DripSharp.Runtime.JavaCompat.StringValueOf(ap.GetElementsAsString()), null);
  }

  internal virtual void testPDFBox6136() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"no\"?>\n",
      "<?xpacket begin='' id='W5M0MpCehiHzreSzNTczkc9d' bytes='6865'?><rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" xmlns:iX=\"http://ns.adobe.com/iX/1.0/\">\n"),
      "    <rdf:Description xmlns=\"http://www.aiim.org/pdfa/ns/extension/\" xmlns:pdfaExtension=\"http://www.aiim.org/pdfa/ns/extension/\" xmlns:pdfaProperty=\"http://www.aiim.org/pdfa/ns/property#\" xmlns:pdfaSchema=\"http://www.aiim.org/pdfa/ns/schema#\" about=\"\">\n"),
      "        <pdfaExtension:schemas>\n"), "            <rdf:Bag>\n"),
      "                <rdf:li rdf:parseType=\"Resource\">\n"),
      "                    <pdfaSchema:namespaceURI>http://ns.adobe.com/pdfx/1.3/</pdfaSchema:namespaceURI>\n"),
      "                    <pdfaSchema:prefix>pdfx</pdfaSchema:prefix>\n"),
      "                    <pdfaSchema:schema>Adobe Document Info PDF eXtension Schema</pdfaSchema:schema>\n"),
      "                    <pdfaSchema:property>\n"), "                        <rdf:Seq>\n"),
      "                            <rdf:li rdf:parseType=\"Resource\">\n"),
      "                                <pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "                                <pdfaProperty:description>ID of PDF/X standard</pdfaProperty:description>\n"),
      "                                <pdfaProperty:name>GTS_PDFXVersion</pdfaProperty:name>\n"),
      "                                <pdfaProperty:valueType>Text</pdfaProperty:valueType>\n"),
      "                            </rdf:li>\n"),
      "                            <rdf:li rdf:parseType=\"Resource\">\n"),
      "                                <pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "                                <pdfaProperty:description>Conformance level of PDF/X standard</pdfaProperty:description>\n"),
      "                                <pdfaProperty:name>GTS_PDFXConformance</pdfaProperty:name>\n"),
      "                                <pdfaProperty:valueType>Text</pdfaProperty:valueType>\n"),
      "                            </rdf:li>\n"),
      "                            <rdf:li rdf:parseType=\"Resource\">\n"),
      "                                <pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "                                <pdfaProperty:description>Company creating the PDF</pdfaProperty:description>\n"),
      "                                <pdfaProperty:name>Company</pdfaProperty:name>\n"),
      "                                <pdfaProperty:valueType>Text</pdfaProperty:valueType>\n"),
      "                            </rdf:li>\n"),
      "                            <rdf:li rdf:parseType=\"Resource\">\n"),
      "                                <pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "                                <pdfaProperty:description>Date when document was last modified</pdfaProperty:description>\n"),
      "                                <pdfaProperty:name>SourceModified</pdfaProperty:name>\n"),
      "                                <pdfaProperty:valueType>Text</pdfaProperty:valueType>\n"),
      "                            </rdf:li>\n"), "                        </rdf:Seq>\n"),
      "                    </pdfaSchema:property>\n"), "                </rdf:li>\n"),
      "                <rdf:li rdf:parseType=\"Resource\">\n"),
      "                    <pdfaSchema:namespaceURI>http://ns.adobe.com/xap/1.0/mm/</pdfaSchema:namespaceURI>\n"),
      "                    <pdfaSchema:prefix>xmpMM</pdfaSchema:prefix>\n"),
      "                    <pdfaSchema:schema>XMP Media Management Schema</pdfaSchema:schema>\n"),
      "                    <pdfaSchema:property>\n"), "                        <rdf:Seq>\n"),
      "                            <rdf:li rdf:parseType=\"Resource\">\n"),
      "                                <pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "                                <pdfaProperty:description>UUID based identifier for specific incarnation of a document</pdfaProperty:description>\n"),
      "                                <pdfaProperty:name>InstanceID</pdfaProperty:name>\n"),
      "                                <pdfaProperty:valueType>URI</pdfaProperty:valueType>\n"),
      "                            </rdf:li>\n"),
      "                            <rdf:li rdf:parseType=\"Resource\">\n"),
      "                                <pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "                                <pdfaProperty:description>The common identifier for all versions and renditions of a document.</pdfaProperty:description>\n"),
      "                                <pdfaProperty:name>OriginalDocumentID</pdfaProperty:name>\n"),
      "                                <pdfaProperty:valueType>URI</pdfaProperty:valueType>\n"),
      "                            </rdf:li>\n"), "                        </rdf:Seq>\n"),
      "                    </pdfaSchema:property>\n"), "                </rdf:li>\n"),
      "                <rdf:li rdf:parseType=\"Resource\">\n"),
      "                    <pdfaSchema:namespaceURI>http://www.aiim.org/pdfa/ns/id/</pdfaSchema:namespaceURI>\n"),
      "                    <pdfaSchema:prefix>pdfaid</pdfaSchema:prefix>\n"),
      "                    <pdfaSchema:schema>PDF/A ID Schema</pdfaSchema:schema>\n"),
      "                    <pdfaSchema:property>\n"), "                        <rdf:Seq>\n"),
      "                            <rdf:li rdf:parseType=\"Resource\">\n"),
      "                                <pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "                                <pdfaProperty:description>Part of PDF/A standard</pdfaProperty:description>\n"),
      "                                <pdfaProperty:name>part</pdfaProperty:name>\n"),
      "                                <pdfaProperty:valueType>Integer</pdfaProperty:valueType>\n"),
      "                            </rdf:li>\n"),
      "                            <rdf:li rdf:parseType=\"Resource\">\n"),
      "                                <pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "                                <pdfaProperty:description>Amendment of PDF/A standard</pdfaProperty:description>\n"),
      "                                <pdfaProperty:name>amd</pdfaProperty:name>\n"),
      "                                <pdfaProperty:valueType>Text</pdfaProperty:valueType>\n"),
      "                            </rdf:li>\n"),
      "                            <rdf:li rdf:parseType=\"Resource\">\n"),
      "                                <pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "                                <pdfaProperty:description>Conformance level of PDF/A standard</pdfaProperty:description>\n"),
      "                                <pdfaProperty:name>conformance</pdfaProperty:name>\n"),
      "                                <pdfaProperty:valueType>Text</pdfaProperty:valueType>\n"),
      "                            </rdf:li>\n"), "                        </rdf:Seq>\n"),
      "                    </pdfaSchema:property>\n"), "                </rdf:li>\n"),
      "            </rdf:Bag>\n"), "        </pdfaExtension:schemas>\n"),
      "    </rdf:Description>\n"),
      "    <rdf:Description xmlns=\"http://www.aiim.org/pdfa/ns/id/\" xmlns:pdfaid=\"http://www.aiim.org/pdfa/ns/id/\" about=\"\">\n"),
      "        <pdfaid:part>1</pdfaid:part>\n"),
      "        <pdfaid:conformance>B</pdfaid:conformance>\n"), "    </rdf:Description>\n"),
      "</rdf:RDF><?xpacket end='r'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    xmpParser.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.Testing.JavaAssertions.Equal("B",
      xmp.GetPDFAIdentificationSchema().GetConformance(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(1, xmp.GetPDFAIdentificationSchema().GetPart(),
      null);
  }

  internal virtual void testNamespaceInRoot() {
    string s
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?>\n",
      "<?xpacket begin='' id='W5M0MpCehiHzreSzNTczkc9d'?>"),
      "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\" xmlns:pdfaExtension=\"http://www.aiim.org/pdfa/ns/extension/\" "),
      "xmlns:pdfaProperty=\"http://www.aiim.org/pdfa/ns/property#\" xmlns:pdfaSchema=\"http://www.aiim.org/pdfa/ns/schema#\" "),
      "xmlns:pdfuaid=\"http://www.aiim.org/pdfua/ns/id/\" xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\" "),
      "x:xmptk=\"Adobe XMP Core 5.6-c015 91.163280, 2018/06/22-11:31:03        \">\n"),
      "    <rdf:RDF>\n"), "        <rdf:Description rdf:about=\"\">\n"),
      "            <pdfaExtension:schemas>\n"), "                <rdf:Bag>\n"),
      "                    <rdf:li rdf:parseType=\"Resource\">\n"),
      "                        <pdfaSchema:schema>PDF/UA Universal Accessibility Schema</pdfaSchema:schema>\n"),
      "                        <pdfaSchema:namespaceURI>http://www.aiim.org/pdfua/ns/id/</pdfaSchema:namespaceURI>\n"),
      "                        <pdfaSchema:prefix>pdfuaid</pdfaSchema:prefix>\n"),
      "                        <pdfaSchema:property>\n"),
      "                            <rdf:Seq>\n"),
      "                                <rdf:li rdf:parseType=\"Resource\">\n"),
      "                                    <pdfaProperty:name>part</pdfaProperty:name>\n"),
      "                                    <pdfaProperty:valueType>Integer</pdfaProperty:valueType>\n"),
      "                                    <pdfaProperty:category>internal</pdfaProperty:category>\n"),
      "                                    <pdfaProperty:description>Indicates, which part of ISO 14289 standard is followed</pdfaProperty:description>\n"),
      "                                </rdf:li>\n"), "                            </rdf:Seq>\n"),
      "                        </pdfaSchema:property>\n"), "                    </rdf:li>\n"),
      "                </rdf:Bag>\n"), "            </pdfaExtension:schemas>\n"),
      "            <pdfuaid:part>1</pdfuaid:part>\n"), "        </rdf:Description>\n"),
      "    </rdf:RDF>\n"), "</x:xmpmeta><?xpacket end='w'?>");
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp
      = xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(s,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema uaSchema
      = xmp.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "http://www.aiim.org/pdfua/ns/id/"));
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      uaSchema.GetIntegerPropertyValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "part")), null);
  }

  [Xunit.Fact]
  public void __Upstream_1407363748_effbf2c2daab8e79() {
    try {
      this.testBadAttr();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0678603278_4f191040110fd677() {
    try {
      this.testBadAttr2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0678603279_bde752acf7e3d3ec() {
    try {
      this.testBadAttr3();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0678603280_bc2976dc666ea104() {
    try {
      this.testBadAttr4();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0678603281_02397b2922c64a96() {
    try {
      this.testBadAttr5();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0685806595_82e2288414734ea0() {
    try {
      this.testBadInner();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3060254659_ec92ac3cb1b4c4c7() {
    try {
      this.testBadLocalName();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1407808534_0ac80d0b850c6e82() {
    try {
      this.testBadProp();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0692391644_c7137abc6b187b15() {
    try {
      this.testBadProp2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1371897050_56388ad7759ebacd() {
    try {
      this.testBadRdfNameSpace();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0061121940_85603909432536d8() {
    try {
      this.testBadSchema();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1407934445_fb82c90c52f06caa() {
    try {
      this.testBadType();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0696294885_2850d9e4ea32dced() {
    try {
      this.testBadType2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3153397219_e30fa794cb637960() {
    try {
      this.testBadXPacketEnd1();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3153397220_2fb099a27d20666b() {
    try {
      this.testBadXPacketEnd2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2011010776_f0dc4ae93e54a6c5() {
    try {
      this.testDoubleEnd();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2744168763_19b5eaefd2dc38f7() {
    try {
      this.testLenientBagSeqMixup();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1104426187_610a1497160b7fdc() {
    try {
      this.testLenientPdfaExtension();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3161060848_407f30a898a4c676() {
    try {
      this.testNamespaceInRoot();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1755336218_a685ed76029c2193() {
    try {
      this.testNoInstantiation();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2875815256_b6200a324384412c() {
    try {
      this.testNoInstantiation2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0794750792_8322b702657a2f90() {
    try {
      this.testNoProcessingInstruction();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1535268512_418f18025fc3c8b9() {
    try {
      this.testNoRdfChildren();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3496939892_152dd3b2fa345ce5() {
    try {
      this.testNoSchema();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0623025581_1c5115b2524ea129() {
    try {
      this.testNoXPacket();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1510511611_d2cb2cca300061f3() {
    try {
      this.testNonStandardURIinRDF();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0778948458_191414e415e88350() {
    try {
      this.testPDFBOX6126();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724551498_273ffb4b38c955c5() {
    try {
      this.testPDFBox3882();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3731583613_e58b6dc4eba5797b() {
    try {
      this.testPDFBox3882_2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724605320_b7f06d667200fb28() {
    try {
      this.testPDFBox5288();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724605345_88c8289ea7f70685() {
    try {
      this.testPDFBox5292();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724609041_cfc7ee8fc3d05729() {
    try {
      this.testPDFBox5649();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724610928_9b3851e833657677() {
    try {
      this.testPDFBox5835();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724612014_7f75ba9f48e9df33() {
    try {
      this.testPDFBox5976();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724633900_d1f25d4a0b490b32() {
    try {
      this.testPDFBox6106();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724633988_38e1ffcab9ee6432() {
    try {
      this.testPDFBox6131();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3810856503_e48efb86acea118e() {
    try {
      this.testPDFBox6131_2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724633990_a43fc9c881a739aa() {
    try {
      this.testPDFBox6133();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724633993_3044ab40f272f85a() {
    try {
      this.testPDFBox6136();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0553210447_8efc3a4b7943fda6() {
    try {
      this.testPageTextSchema();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4264622019_ae36be84375ced0b() {
    try {
      this.testPageTextSchema2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4264622020_0fa931d2365beaf8() {
    try {
      this.testPageTextSchema3();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0127081737_e08a2de131321887() {
    try {
      this.testParseFailure();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3693607837_4ee46c22e2293e7b() {
    try {
      this.testPropertyNotDefined();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2832693301_f79ed75524b0832b() {
    try {
      this.testPropertyNotDefined2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1799542751_41c0ea364ad4cad0() {
    try {
      this.testTextInsteadOfArray();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3019293344_2d502d28931a9edf() {
    try {
      this.testTypeInLiResourceElement();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2270999061_4aefc74ebcbddbc6() {
    try {
      this.testWrongType();
    } finally {
    }
  }
}
