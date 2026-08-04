// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdfparser;

public class EndstreamFilterStreamTest {
internal virtual void testEndstreamFilterStream() {
global::DripSharp.PdfCarton.Pdfparser.EndstreamFilterStream feos = new global::DripSharp.PdfCarton.Pdfparser.EndstreamFilterStream();
sbyte[] tab1 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)) };
sbyte[] tab2 = new sbyte[] { unchecked((sbyte)(5)), unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)('\r')), unchecked((sbyte)('\n')) };
sbyte[] tab3 = new sbyte[] { unchecked((sbyte)(8)), unchecked((sbyte)(9)), unchecked((sbyte)('\r')), unchecked((sbyte)('\n')) };
feos.Filter(tab1, 0, tab1.Length);
feos.Filter(tab2, 0, tab2.Length);
feos.Filter(tab3, 0, tab3.Length);
sbyte[] expectedResult1 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)), unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)('\r')), unchecked((sbyte)('\n')), unchecked((sbyte)(8)), unchecked((sbyte)(9)) };
global::DripSharp.Testing.JavaAssertions.Equal((long)(expectedResult1.Length), feos.CalculateLength(), null);
feos = new global::DripSharp.PdfCarton.Pdfparser.EndstreamFilterStream();
sbyte[] tab4 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)) };
sbyte[] tab5 = new sbyte[] { unchecked((sbyte)(5)), unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)('\r')) };
sbyte[] tab6 = new sbyte[] { unchecked((sbyte)(8)), unchecked((sbyte)(9)), unchecked((sbyte)('\n')) };
feos.Filter(tab4, 0, tab4.Length);
feos.Filter(tab5, 0, tab5.Length);
feos.Filter(tab6, 0, tab6.Length);
sbyte[] expectedResult2 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)), unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)('\r')), unchecked((sbyte)(8)), unchecked((sbyte)(9)) };
global::DripSharp.Testing.JavaAssertions.Equal((long)(expectedResult2.Length), feos.CalculateLength(), null);
feos = new global::DripSharp.PdfCarton.Pdfparser.EndstreamFilterStream();
sbyte[] tab7 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)('\r')) };
sbyte[] tab8 = new sbyte[] { unchecked((sbyte)('\n')), unchecked((sbyte)(5)), unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)('\n')) };
sbyte[] tab9 = new sbyte[] { unchecked((sbyte)(8)), unchecked((sbyte)(9)), unchecked((sbyte)('\r')) };
feos.Filter(tab7, 0, tab7.Length);
feos.Filter(tab8, 0, tab8.Length);
feos.Filter(tab9, 0, tab9.Length);
sbyte[] expectedResult3 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)('\r')), unchecked((sbyte)('\n')), unchecked((sbyte)(5)), unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)('\n')), unchecked((sbyte)(8)), unchecked((sbyte)(9)), unchecked((sbyte)('\r')) };
global::DripSharp.Testing.JavaAssertions.Equal((long)(expectedResult3.Length), feos.CalculateLength(), null);
feos = new global::DripSharp.PdfCarton.Pdfparser.EndstreamFilterStream();
sbyte[] tab10 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)('\r')) };
sbyte[] tab11 = new sbyte[] { unchecked((sbyte)('\n')), unchecked((sbyte)(5)), unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)('\r')) };
sbyte[] tab12 = new sbyte[] { unchecked((sbyte)(8)), unchecked((sbyte)(9)), unchecked((sbyte)('\r')) };
sbyte[] tab13 = new sbyte[] { unchecked((sbyte)('\n')) };
feos.Filter(tab10, 0, tab10.Length);
feos.Filter(tab11, 0, tab11.Length);
feos.Filter(tab12, 0, tab12.Length);
feos.Filter(tab13, 0, tab13.Length);
sbyte[] expectedResult4 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)('\r')), unchecked((sbyte)('\n')), unchecked((sbyte)(5)), unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)('\r')), unchecked((sbyte)(8)), unchecked((sbyte)(9)) };
global::DripSharp.Testing.JavaAssertions.Equal((long)(expectedResult4.Length), feos.CalculateLength(), null);
feos = new global::DripSharp.PdfCarton.Pdfparser.EndstreamFilterStream();
sbyte[] tab14 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)('\r')) };
sbyte[] tab15 = new sbyte[] { unchecked((sbyte)('\n')), unchecked((sbyte)(5)), unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)('\r')) };
sbyte[] tab16 = new sbyte[] { unchecked((sbyte)(8)), unchecked((sbyte)(9)), unchecked((sbyte)('\n')) };
sbyte[] tab17 = new sbyte[] { unchecked((sbyte)('\r')) };
feos.Filter(tab14, 0, tab14.Length);
feos.Filter(tab15, 0, tab15.Length);
feos.Filter(tab16, 0, tab16.Length);
feos.Filter(tab17, 0, tab17.Length);
sbyte[] expectedResult5 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)('\r')), unchecked((sbyte)('\n')), unchecked((sbyte)(5)), unchecked((sbyte)(6)), unchecked((sbyte)(7)), unchecked((sbyte)('\r')), unchecked((sbyte)(8)), unchecked((sbyte)(9)), unchecked((sbyte)('\n')), unchecked((sbyte)('\r')) };
global::DripSharp.Testing.JavaAssertions.Equal((long)(expectedResult5.Length), feos.CalculateLength(), null);
}

internal virtual void testPDFBox2079EmbeddedFile() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "src/test/resources/org/apache/pdfbox/pdfparser"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "embedded_zip.pdf")))) {
global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog = doc.GetDocumentCatalog();
global::DripSharp.PdfCarton.Pdmodel.PDDocumentNameDictionary names = catalog.GetNames();
global::DripSharp.PdfCarton.Pdmodel.PDEmbeddedFilesNameTreeNode node = names.GetEmbeddedFiles();
global::System.Collections.Generic.IDictionary<string, global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDComplexFileSpecification> map = node.GetNames();
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.MapCount(map), null);
global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDComplexFileSpecification spec = global::DripSharp.Runtime.JavaCompat.MapGet(map, "My first attachment");
global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDEmbeddedFile file = spec.GetEmbeddedFile();
global::System.IO.Stream input = file.CreateInputStream();
global::System.IO.FileInfo d = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output"));
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(d);
global::System.IO.FileInfo f = new global::System.IO.FileInfo(global::System.IO.Path.Combine(d.FullName, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", spec.GetFile())));
using (global::System.IO.Stream os = global::DripSharp.Runtime.JavaCompat.OpenFileOutput(f)) {
global::DripSharp.PdfCarton.IO.IOUtils.Copy(input, os);
}
global::DripSharp.Testing.JavaAssertions.Equal((long)(17660), f.Length, null);
}
}

[Xunit.Fact]
public void __Upstream_3414365025_6f7e1572ca709527()
{
        try
        {
            this.testEndstreamFilterStream();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0249735569_9bbaa4ee5f9e2a89()
{
        try
        {
            this.testPDFBox2079EmbeddedFile();
        }
        finally
        {
        }
}
}
