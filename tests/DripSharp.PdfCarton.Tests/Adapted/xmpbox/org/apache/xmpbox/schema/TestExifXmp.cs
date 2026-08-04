// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Schema;

public class TestExifXmp {
internal virtual void testNonStrict() {
using (global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "/validxmp/exif.xmp"))) {
global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser builder = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
builder.SetStrictParsing(false);
global::DripSharp.PdfCarton.Xmp.XMPMetadata rxmp = builder.Parse(@is);
global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema schema = (global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema)(rxmp.GetSchema(typeof(global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema))!);
global::DripSharp.PdfCarton.Xmp.Type.TextType ss = (global::DripSharp.PdfCarton.Xmp.Type.TextType)(schema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema.SpectralSensitivity))!);
global::DripSharp.Testing.JavaAssertions.NotNull(ss, null);
global::DripSharp.Testing.JavaAssertions.Equal("spectral sens value", ss.GetValue(), null);
}
}

internal virtual void testGenerate() {
global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
global::DripSharp.PdfCarton.Xmp.Type.TypeMapping tmapping = metadata.GetTypeMapping();
global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema exif = new global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema(metadata);
metadata.AddSchema(exif);
global::DripSharp.PdfCarton.Xmp.Type.OECFType oecf = new global::DripSharp.PdfCarton.Xmp.Type.OECFType(metadata);
oecf.AddProperty(tmapping.CreateInteger(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", oecf.GetNamespace()), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", oecf.GetPrefix()), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", global::DripSharp.PdfCarton.Xmp.Type.OECFType.Columns), 14));
oecf.SetPropertyName(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", global::DripSharp.PdfCarton.Xmp.Schema.ExifSchema.Oecf));
exif.AddProperty(oecf);
global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer serializer = new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer();
serializer.Serialize(metadata, new global::DripSharp.Runtime.JavaByteArrayOutputStream(), false);
}

[Xunit.Fact]
public void __Upstream_0377228327_b911c7410e1853e7()
{
        try
        {
            this.testGenerate();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3072116612_a34f3c8ef4a4fcac()
{
        try
        {
            this.testNonStrict();
        }
        finally
        {
        }
}
}
