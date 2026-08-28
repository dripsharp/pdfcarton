// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Common;

public class TestEmbeddedFiles {
  internal virtual void testNullEmbeddedFile() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDEmbeddedFile embeddedFile
      = default!;
    bool ok = false;
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Common.TestEmbeddedFiles),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "null_PDComplexFileSpecification.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog = doc.GetDocumentCatalog();
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentNameDictionary names = catalog.GetNames();
      global::DripSharp.Testing.JavaAssertions.Equal(2,
        global::DripSharp.Runtime.JavaCompat.MapCount(names.GetEmbeddedFiles().GetNames()),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "expected two files"));
      global::DripSharp.PdfCarton.Pdmodel.PDEmbeddedFilesNameTreeNode embeddedFiles
        = names.GetEmbeddedFiles();
      global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDComplexFileSpecification spec
        = global::DripSharp.Runtime.JavaCompat.MapGet(embeddedFiles.GetNames(),
        "non-existent-file.docx");
      if ((spec != default!)) {
        embeddedFile = spec.GetEmbeddedFile();
        ok = true;
      }
      spec = global::DripSharp.Runtime.JavaCompat.MapGet(embeddedFiles.GetNames(),
        "My first attachment");
      global::DripSharp.Testing.JavaAssertions.NotNull(spec,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "one attachment actually exists"));
      global::DripSharp.Testing.JavaAssertions.Equal(17660, spec.GetEmbeddedFile().GetLength(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "existing file length"));
      spec = global::DripSharp.Runtime.JavaCompat.MapGet(embeddedFiles.GetNames(),
        "non-existent-file.docx");
      global::DripSharp.Testing.JavaAssertions.NotNull(spec, null);
      global::DripSharp.Testing.JavaAssertions.Null(spec.GetFile(), null);
      global::DripSharp.Testing.JavaAssertions.Null(spec.GetEmbeddedFile(), null);
    }
    global::DripSharp.Testing.JavaAssertions.True(ok,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Was able to get file without exception"));
    global::DripSharp.Testing.JavaAssertions.Null(embeddedFile!,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "EmbeddedFile was correctly null"));
  }

  internal virtual void testOSSpecificAttachments() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDEmbeddedFile nonOSFile
      = default!;
    global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDEmbeddedFile macFile = default!;
    global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDEmbeddedFile dosFile = default!;
    global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDEmbeddedFile unixFile = default!;
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Common.TestEmbeddedFiles),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "testPDF_multiFormatEmbFiles.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog = doc.GetDocumentCatalog();
      global::DripSharp.PdfCarton.Pdmodel.PDDocumentNameDictionary names = catalog.GetNames();
      global::DripSharp.PdfCarton.Pdmodel.PDEmbeddedFilesNameTreeNode treeNode
        = names.GetEmbeddedFiles();
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDComplexFileSpecification>> kids
        = treeNode.GetKids();
      foreach (global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDComplexFileSpecification> kid in kids) {
        global::System.Collections.Generic.IDictionary<string,
          global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDComplexFileSpecification> tmpNames
          = kid.GetNames();
        global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable obj
          = global::DripSharp.Runtime.JavaCompat.MapGet(tmpNames, "My first attachment");
        global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDComplexFileSpecification spec
          = (global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDComplexFileSpecification)(obj!);
        nonOSFile = spec.GetEmbeddedFile();
        macFile = spec.GetEmbeddedFileMac();
        dosFile = spec.GetEmbeddedFileDos();
        unixFile = spec.GetEmbeddedFileUnix();
      }
      global::DripSharp.Testing.JavaAssertions.True(this.byteArrayContainsLC(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "non os specific"), nonOSFile!.ToByteArray(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ISO-8859-1")),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "non os specific"));
      global::DripSharp.Testing.JavaAssertions.True(this.byteArrayContainsLC(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "mac embedded"), macFile!.ToByteArray(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ISO-8859-1")),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "mac"));
      global::DripSharp.Testing.JavaAssertions.True(this.byteArrayContainsLC(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "dos embedded"), dosFile!.ToByteArray(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ISO-8859-1")),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "dos"));
      global::DripSharp.Testing.JavaAssertions.True(this.byteArrayContainsLC(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
        "unix embedded"), unixFile!.ToByteArray(),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ISO-8859-1")),
        global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "unix"));
    }
  }

  private bool byteArrayContainsLC(string target, sbyte[] bytes, string encoding) {
    string s = global::DripSharp.Runtime.JavaCompat.NewString(bytes,
      global::DripSharp.PdfCarton.Tests.Support.EncodingByName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      encoding)));
    return global::DripSharp.Runtime.JavaCompat.StringContains(s.ToLowerInvariant(), target);
  }

  [Xunit.Fact]
  public void __Upstream_2480888575_6bda6ce6ab9c48be() {
    try {
      this.testNullEmbeddedFile();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2998267208_cda1ba278f64e219() {
    try {
      this.testOSSpecificAttachments();
    } finally {
    }
  }
}
