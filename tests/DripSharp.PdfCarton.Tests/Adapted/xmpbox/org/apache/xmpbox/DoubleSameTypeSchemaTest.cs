// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp;

public class DoubleSameTypeSchemaTest {
  private readonly global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata
    = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();

  internal virtual void testDoubleDublinCore() {
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dc1
      = this.metadata.CreateAndAddDublinCoreSchema();
    string ownPrefix = "test";
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dc2
      = new global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema(this.metadata,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", ownPrefix));
    this.metadata.AddSchema(dc2);
    global::System.Collections.Generic.IList<string> creators
      = new global::System.Collections.Generic.List<string>();
    global::DripSharp.Runtime.JavaCompat.Add(creators, "creator1");
    global::DripSharp.Runtime.JavaCompat.Add(creators, "creator2");
    string format = "application/pdf";
    dc1.SetFormat(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", format));
    dc1.AddCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.Runtime.JavaCompat.ListGet(creators, 0)));
    dc1.AddCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.Runtime.JavaCompat.ListGet(creators, 1)));
    string coverage = "Coverage";
    dc2.SetCoverage(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", coverage));
    dc2.AddCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.Runtime.JavaCompat.ListGet(creators, 0)));
    dc2.AddCreator(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.Runtime.JavaCompat.ListGet(creators, 1)));
    global::DripSharp.PdfCarton.Xmp.Type.StructuredType stDub
      = global::DripSharp.Runtime.JavaCompat.ClassGetAnnotation<global::DripSharp.PdfCarton.Xmp.Type.StructuredType>(typeof(global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema),
      typeof(global::DripSharp.PdfCarton.Xmp.Type.StructuredType))!;
    global::DripSharp.Testing.JavaAssertions.Equal(format,
      ((global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema)(this.metadata.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      stDub.PreferedPrefix()), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      stDub.@Namespace()))!)).GetFormat(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(coverage,
      ((global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema)(this.metadata.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      ownPrefix), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      stDub.@Namespace()))!)).GetCoverage(), null);
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema> schems
      = this.metadata.GetAllSchemas();
    global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema dc;
    foreach (global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema xmpSchema in schems) {
      dc = (global::DripSharp.PdfCarton.Xmp.Schema.DublinCoreSchema)(xmpSchema!);
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ContainsAll(dc.GetCreators(),
        global::DripSharp.Runtime.JavaCompat.CastObjects(creators)), null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_1343937058_41b497e61185a983() {
    try {
      this.testDoubleDublinCore();
    } finally {
    }
  }
}
