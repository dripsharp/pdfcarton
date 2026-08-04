// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Filter;

public class TestFilters {
internal virtual void testFilters() {
int COUNT = 10;
global::DripSharp.PdfCarton.Tests.JavaRandom rd = new global::DripSharp.PdfCarton.Tests.JavaRandom((long)(123456));
for (int iter = 0; (iter < (COUNT * 2)); iter++) {
long seed;
if ((iter < COUNT)) {
seed = rd.NextLong();
} else {
seed = new global::DripSharp.PdfCarton.Tests.JavaRandom().NextLong();
}
bool success = false;
try {
global::DripSharp.PdfCarton.Tests.JavaRandom random = new global::DripSharp.PdfCarton.Tests.JavaRandom(seed);
int numBytes = (10000 + random.NextInt(20000));
sbyte[] original = new sbyte[numBytes];
int upto = 0;
while ((upto < numBytes)) {
int left = (numBytes - upto);
if ((random.NextBoolean() || (left < 2))) {
int end__82_35 = (upto + global::System.Math.Min(left, (10 + random.NextInt(100))));
while ((upto < end__82_35)) {
original[upto++] = unchecked((sbyte)(unchecked((sbyte)(random.NextInt()))));
}
} else {
int end__91_35 = (upto + global::System.Math.Min(left, (2 + random.NextInt(10))));
sbyte value = unchecked((sbyte)(unchecked((sbyte)(random.NextInt(4)))));
while ((upto < end__91_35)) {
original[upto++] = unchecked((sbyte)(value));
}
}
}
foreach (global::DripSharp.PdfCarton.Filter.Filter filter in global::DripSharp.PdfCarton.Filter.FilterFactory.Instance.getAllFilters()) {
if (((((filter is global::DripSharp.PdfCarton.Filter.DCTFilter) || (filter is global::DripSharp.PdfCarton.Filter.CCITTFaxFilter)) || (filter is global::DripSharp.PdfCarton.Filter.JPXFilter)) || (filter is global::DripSharp.PdfCarton.Filter.JBIG2Filter))) {
continue;
}
this.checkEncodeDecode(filter, original);
}
success = true;
} finally {
if (!success) {
global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("NOTE: test failed with seed=", seed)));
}
}
}
}

internal virtual void testPDFBOX4517() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/pdfs/PDFBOX-4517-cryptfilter.pdf")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "userpassword1234"))) {
global::DripSharp.Testing.JavaAssertions.Equal(1, doc.GetNumberOfPages(), null);
}
}

internal virtual void testPDFBOX1977() {
using (global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-1977.bin"))) {
global::DripSharp.PdfCarton.Filter.Filter lzwFilter = global::DripSharp.PdfCarton.Filter.FilterFactory.Instance.GetFilter(global::DripSharp.PdfCarton.Cos.COSName.LzwDecode);
sbyte[] byteArray = global::DripSharp.PdfCarton.IO.IOUtils.ToByteArray(@is);
this.checkEncodeDecode(lzwFilter, byteArray);
}
}

internal virtual void testRLE() {
global::DripSharp.PdfCarton.Filter.Filter rleFilter = global::DripSharp.PdfCarton.Filter.FilterFactory.Instance.GetFilter(global::DripSharp.PdfCarton.Cos.COSName.RunLengthDecode);
sbyte[] input0 = new sbyte[0];
this.checkEncodeDecode(rleFilter, input0);
sbyte[] input1 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)), unchecked((sbyte)(3)), unchecked((sbyte)(4)), unchecked((sbyte)(5)), unchecked((sbyte)(128)), unchecked((sbyte)(140)), unchecked((sbyte)(180)), unchecked((sbyte)(255)) };
this.checkEncodeDecode(rleFilter, input1);
sbyte[] input2 = new sbyte[10];
this.checkEncodeDecode(rleFilter, input2);
sbyte[] input3 = new sbyte[128];
this.checkEncodeDecode(rleFilter, input3);
sbyte[] input4 = new sbyte[129];
this.checkEncodeDecode(rleFilter, input4);
sbyte[] input5 = new sbyte[(128 + 128)];
this.checkEncodeDecode(rleFilter, input5);
sbyte[] input6 = new sbyte[1];
this.checkEncodeDecode(rleFilter, input6);
sbyte[] input7 = new sbyte[] { unchecked((sbyte)(1)), unchecked((sbyte)(2)) };
this.checkEncodeDecode(rleFilter, input7);
sbyte[] input8 = new sbyte[2];
this.checkEncodeDecode(rleFilter, input8);
}

internal virtual void testEmptyFilterList() {
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => {
global::DripSharp.PdfCarton.Filter.Filter.Decode((global::System.IO.Stream)default!, new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Filter.Filter>(), new global::DripSharp.PdfCarton.Cos.COSDictionary(), (global::DripSharp.PdfCarton.Filter.DecodeOptions)default!, (global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Filter.DecodeResult>)default!);
}, null);
}

private void checkEncodeDecode(global::DripSharp.PdfCarton.Filter.Filter filter, sbyte[] original) {
global::DripSharp.Runtime.JavaByteArrayOutputStream encoded = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
filter.Encode(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(original), encoded, new global::DripSharp.PdfCarton.Cos.COSDictionary());
global::DripSharp.Runtime.JavaByteArrayOutputStream decoded = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
filter.Decode(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(encoded)), decoded, new global::DripSharp.PdfCarton.Cos.COSDictionary(), 0);
global::DripSharp.Testing.JavaAssertions.Equal(original, global::DripSharp.Runtime.JavaCompat.ToSignedBytes(decoded), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Data that is encoded and then decoded through ", ((object)(filter)).GetType()), " does not match the original data")));
}

[Xunit.Fact]
public void __Upstream_1692587633_2f3c54a8f7853bed()
{
        try
        {
            this.testEmptyFilterList();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0900337417_76ae6214d87d2aa3()
{
        try
        {
            this.testFilters();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0778807347_143680755b477192()
{
        try
        {
            this.testPDFBOX1977();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0778892690_85f31f5eabfe618a()
{
        try
        {
            this.testPDFBOX4517();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0725014393_e83bc42416bf19a8()
{
        try
        {
            this.testRLE();
        }
        finally
        {
        }
}
}
