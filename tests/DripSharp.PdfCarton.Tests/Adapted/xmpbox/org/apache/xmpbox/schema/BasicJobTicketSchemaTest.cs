// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Schema;

public class BasicJobTicketSchemaTest {
  internal virtual void testAddTwoJobs() {
    global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata
      = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer serializer
      = new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer();
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser builder
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicJobTicketSchema basic
      = metadata.CreateAndAddBasicJobTicketSchema();
    basic.AddJob(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "zeid1"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "zename1"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "zeurl1"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "aaa"));
    basic.AddJob(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "zeid2"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "zename2"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "zeurl2"));
    global::DripSharp.Runtime.JavaByteArrayOutputStream bos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    serializer.Serialize(metadata, bos, true);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata rxmp
      = builder.Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(bos));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicJobTicketSchema jt
      = rxmp.GetBasicJobTicketSchema();
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Xmp.Type.JobType> jobs
      = jt.GetJobs();
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(jobs), null);
    global::DripSharp.PdfCarton.Xmp.Type.JobType jt0
      = global::DripSharp.Runtime.JavaCompat.ListGet(jobs, 0);
    global::DripSharp.Testing.JavaAssertions.Equal("zeid1", jt0.GetId(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("zename1", jt0.GetName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("zeurl1", jt0.GetUrl(), null);
    global::DripSharp.PdfCarton.Xmp.Type.JobType jt1
      = global::DripSharp.Runtime.JavaCompat.ListGet(jobs, 1);
    global::DripSharp.Testing.JavaAssertions.Equal("zeid2", jt1.GetId(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("zename2", jt1.GetName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("zeurl2", jt1.GetUrl(), null);
  }

  internal virtual void testAddWithDefaultPrefix() {
    global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata
      = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer serializer
      = new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer();
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser builder
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicJobTicketSchema basic
      = metadata.CreateAndAddBasicJobTicketSchema();
    basic.AddJob(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "zeid2"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "zename2"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "zeurl2"));
    global::DripSharp.Runtime.JavaByteArrayOutputStream bos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    serializer.Serialize(metadata, bos, true);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata rxmp
      = builder.Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(bos));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicJobTicketSchema jt
      = rxmp.GetBasicJobTicketSchema();
    global::DripSharp.Testing.JavaAssertions.NotNull(jt, null);
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(jt.GetJobs()), null);
    global::DripSharp.PdfCarton.Xmp.Type.JobType job
      = global::DripSharp.Runtime.JavaCompat.ListGet(jt.GetJobs(), 0);
    global::DripSharp.Testing.JavaAssertions.Equal("zeid2", job.GetId(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("zename2", job.GetName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("zeurl2", job.GetUrl(), null);
  }

  internal virtual void testAddWithDefinedPrefix() {
    global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata
      = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
    global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer serializer
      = new global::DripSharp.PdfCarton.Xmp.Xml.XmpSerializer();
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser builder
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicJobTicketSchema basic
      = metadata.CreateAndAddBasicJobTicketSchema();
    basic.AddJob(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "zeid2"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "zename2"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "zeurl2"),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "aaa"));
    global::DripSharp.Runtime.JavaByteArrayOutputStream bos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    serializer.Serialize(metadata, bos, true);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata rxmp
      = builder.Parse(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(bos));
    global::DripSharp.PdfCarton.Xmp.Schema.XMPBasicJobTicketSchema jt
      = rxmp.GetBasicJobTicketSchema();
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(jt.GetJobs()), null);
    global::DripSharp.PdfCarton.Xmp.Type.JobType job
      = global::DripSharp.Runtime.JavaCompat.ListGet(jt.GetJobs(), 0);
    global::DripSharp.PdfCarton.Xmp.Type.StructuredType stjob
      = global::DripSharp.Runtime.JavaCompat.ClassGetAnnotation<global::DripSharp.PdfCarton.Xmp.Type.StructuredType>(typeof(global::DripSharp.PdfCarton.Xmp.Type.JobType),
      typeof(global::DripSharp.PdfCarton.Xmp.Type.StructuredType))!;
    global::DripSharp.Testing.JavaAssertions.Equal("zeid2", job.GetId(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("zename2", job.GetName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("zeurl2", job.GetUrl(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(stjob.@Namespace(), job.GetNamespace(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("aaa", job.GetPrefix(), null);
  }

  [Xunit.Fact]
  public void __Upstream_2429646611_c0027c3ae454b3d7() {
    try {
      this.testAddTwoJobs();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3586648606_06dbb9106989f62c() {
    try {
      this.testAddWithDefaultPrefix();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1151892454_8b84746f6b82acd7() {
    try {
      this.testAddWithDefinedPrefix();
    } finally {
    }
  }
}
