// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp;

public class XMPMetaDataTest {
internal virtual void testAddingSchem() {
global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
string tmpNsURI = "http://www.test.org/schem/";
global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema tmp = new global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema(metadata, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", tmpNsURI), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"));
tmp.AddQualifiedBagValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "BagContainer"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "Value1"));
tmp.AddQualifiedBagValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "BagContainer"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "Value2"));
tmp.AddQualifiedBagValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "BagContainer"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "Value3"));
tmp.AddUnqualifiedSequenceValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "SeqContainer"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "Value1"));
tmp.AddUnqualifiedSequenceValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "SeqContainer"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "Value2"));
tmp.AddUnqualifiedSequenceValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "SeqContainer"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "Value3"));
tmp.AddProperty(metadata.GetTypeMapping().CreateText((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "simpleProperty"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "YEP")));
global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema tmp2 = new global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema(metadata, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "http://www.space.org/schem/"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "space"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "space"));
tmp2.AddUnqualifiedSequenceValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "SeqSpContainer"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "ValueSpace1"));
tmp2.AddUnqualifiedSequenceValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "SeqSpContainer"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "ValueSpace2"));
tmp2.AddUnqualifiedSequenceValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "SeqSpContainer"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "ValueSpace3"));
metadata.AddSchema(tmp);
metadata.AddSchema(tmp2);
global::DripSharp.Testing.JavaAssertions.Equal(tmp, metadata.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", tmpNsURI)), null);
global::DripSharp.Testing.JavaAssertions.Null(metadata.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "THIS URI NOT EXISTS !")), null);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema> vals = metadata.GetAllSchemas();
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(vals, tmp), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(vals, tmp2), null);
}

internal virtual void testTransformerExceptionMessage() {
global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializationException>(() => {
throw new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializationException(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "TEST"));
}, null);
}

internal virtual void testTransformerExceptionWithCause() {
global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializationException>(() => {
throw new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializationException(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "TEST"), global::DripSharp.Runtime.JavaCompat.NewThrowable());
}, null);
}

internal virtual void testInitMetaDataWithInfo() {
string xpacketBegin = "TESTBEG";
string xpacketId = "TESTID";
string xpacketBytes = "TESTBYTES";
string xpacketEncoding = "TESTENCOD";
global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", xpacketBegin), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", xpacketId), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", xpacketBytes), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", xpacketEncoding));
global::DripSharp.Testing.JavaAssertions.Equal(xpacketBegin, metadata.GetXpacketBegin(), null);
global::DripSharp.Testing.JavaAssertions.Equal(xpacketId, metadata.GetXpacketId(), null);
global::DripSharp.Testing.JavaAssertions.Equal(xpacketBytes, metadata.GetXpacketBytes(), null);
global::DripSharp.Testing.JavaAssertions.Equal(xpacketEncoding, metadata.GetXpacketEncoding(), null);
}

internal virtual void testPDFBOX3257() {
string xmpmeta = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xpacket id=\"W5M0MpCehiHzreSzNTczkc9d\"?>\n", "<x:xmpmeta xmlns:x=\"adobe:ns:meta/\" x:xmptk=\"Adobe XMP Core 4.0-c316 44.253921, Sun Oct 01 2006 17:14:39\">\n"), "   <rdf:RDF xmlns:rdf=\"http://www.w3.org/1999/02/22-rdf-syntax-ns#\">\n"), "      <rdf:Description rdf:about=\"\"\n"), "            xmlns:xap=\"http://ns.adobe.com/xap/1.0/\">\n"), "         <xap:CreatorTool>Acrobat PDFMaker 8.1 for Word</xap:CreatorTool>\n"), "         <xap:ModifyDate>2008-11-12T15:29:43+01:00</xap:ModifyDate>\n"), "         <xap:CreateDate>2008-11-12T15:29:40+01:00</xap:CreateDate>\n"), "         <xap:MetadataDate>2008-11-12T15:29:43+01:00</xap:MetadataDate>\n"), "      </rdf:Description>\n"), "      <rdf:Description rdf:about=\"\"\n"), "            xmlns:pdf=\"http://ns.adobe.com/pdf/1.3/\">\n"), "         <pdf:Producer>Acrobat Distiller 8.1.0 (Windows)</pdf:Producer>\n"), "      </rdf:Description>\n"), "      <rdf:Description rdf:about=\"\"\n"), "            xmlns:dc=\"http://purl.org/dc/elements/1.1/\">\n"), "         <dc:format>application/pdf</dc:format>\n"), "         <dc:creator>\n"), "            <rdf:Seq>\n"), "               <rdf:li>R002325</rdf:li>\n"), "            </rdf:Seq>\n"), "         </dc:creator>\n"), "         <dc:subject>\n"), "            <rdf:Bag>\n"), "               <rdf:li>one</rdf:li>\n"), "               <rdf:li>two</rdf:li>\n"), "               <rdf:li>three</rdf:li>\n"), "               <rdf:li>four</rdf:li>\n"), "            </rdf:Bag>\n"), "         </dc:subject>\n"), "         <dc:title>\n"), "            <rdf:Alt>\n"), "               <rdf:li xml:lang=\"x-default\"> </rdf:li>\n"), "            </rdf:Alt>\n"), "         </dc:title>\n"), "      </rdf:Description>\n"), "      <rdf:Description rdf:about=\"\"\n"), "            xmlns:xapMM=\"http://ns.adobe.com/xap/1.0/mm/\">\n"), "         <xapMM:DocumentID>uuid:31ae92cf-9a27-45e0-9371-0d2741e25919</xapMM:DocumentID>\n"), "         <xapMM:InstanceID>uuid:2c7eb5da-9210-4666-8cef-e02ef6631c5e</xapMM:InstanceID>\n"), "      </rdf:Description>\n"), "   </rdf:RDF>\n"), "</x:xmpmeta>\n"), "<?xpacket end=\"w\"?>");
global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser xmpParser = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
xmpParser.SetStrictParsing(false);
global::DripSharp.PdfCarton.Xmp.XMPMetadata xmp = xmpParser.Parse(global::DripSharp.Runtime.JavaCompat.StringGetBytes(xmpmeta, global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicSchema basicSchema = xmp.GetXMPBasicSchema();
global::System.DateTimeOffset? createDate1 = basicSchema.GetCreateDate();
basicSchema.SetCreateDate(global::System.DateTimeOffset.Now);
global::System.DateTimeOffset? createDate2 = basicSchema.GetCreateDate();
global::DripSharp.Testing.JavaAssertions.NotEqual(createDate1, createDate2, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "CreateDate has not been set"));
global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dublinCoreSchema = xmp.GetDublinCoreSchema();
global::System.Collections.Generic.IList<string> subjects = dublinCoreSchema.GetSubjects();
global::DripSharp.Testing.JavaAssertions.Equal(4, global::DripSharp.Runtime.JavaCompat.CollectionCount(subjects), null);
}

[Xunit.Fact]
public void __Upstream_0630240173_5d3a5ed78c33ddb3()
{
        try
        {
            this.testAddingSchem();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3627569125_4849bc4c101d2b4a()
{
        try
        {
            this.testInitMetaDataWithInfo();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0778860140_2da0670e3c4ea84c()
{
        try
        {
            this.testPDFBOX3257();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1844197375_bf03bf8d956162a8()
{
        try
        {
            this.testTransformerExceptionMessage();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0778500411_789d6ce7e11ccf7f()
{
        try
        {
            this.testTransformerExceptionWithCause();
        }
        finally
        {
        }
}
}
