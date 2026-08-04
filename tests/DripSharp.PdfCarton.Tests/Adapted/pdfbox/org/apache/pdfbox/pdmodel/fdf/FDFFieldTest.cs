// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Fdf;

public class FDFFieldTest {
internal virtual void testCOSStringValue() {
string testString = "Test value";
global::DripSharp.PdfCarton.Cos.COSString testCOSString = new global::DripSharp.PdfCarton.Cos.COSString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", testString));
global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFField field = new global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFField();
field.SetValue(testCOSString);
global::DripSharp.Testing.JavaAssertions.Equal(testCOSString, field.GetCOSValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(testString, field.GetValue(), null);
}

internal virtual void testTextAsCOSStreamValue() {
string testString = "Test value";
sbyte[] testBytes = global::DripSharp.Runtime.JavaCompat.StringGetBytes(testString, global::DripSharp.Runtime.JavaStandardCharsets.USASCII);
global::DripSharp.PdfCarton.Cos.COSStream stream = this.createStream(testBytes, (global::DripSharp.PdfCarton.Cos.COSBase)default!);
global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFField field = new global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFField();
field.SetValue(stream);
global::DripSharp.Testing.JavaAssertions.Equal(testString, field.GetValue(), null);
}

internal virtual void testCOSNameValue() {
string testString = "Yes";
global::DripSharp.PdfCarton.Cos.COSName testCOSSName = global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", testString));
global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFField field = new global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFField();
field.SetValue(testCOSSName);
global::DripSharp.Testing.JavaAssertions.Equal(testCOSSName, field.GetCOSValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(testString, field.GetValue(), null);
}

internal virtual void testCOSArrayValue() {
global::System.Collections.Generic.IList<string> testList = new global::System.Collections.Generic.List<string>();
global::DripSharp.Runtime.JavaCompat.Add(testList, "A");
global::DripSharp.Runtime.JavaCompat.Add(testList, "B");
global::DripSharp.PdfCarton.Cos.COSArray testCOSArray = global::DripSharp.PdfCarton.Cos.COSArray.OfCOSStrings(testList);
global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFField field = new global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFField();
field.SetValue(testCOSArray);
global::DripSharp.Testing.JavaAssertions.Equal(testCOSArray, field.GetCOSValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(testList, field.GetValue(), null);
}

private global::DripSharp.PdfCarton.Cos.COSStream createStream(sbyte[] testString, global::DripSharp.PdfCarton.Cos.COSBase filters) {
global::DripSharp.PdfCarton.Cos.COSStream stream = new global::DripSharp.PdfCarton.Cos.COSStream();
using (global::System.IO.Stream output = stream.CreateOutputStream(filters)) {
global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(output, testString);
}
return stream;
}

[Xunit.Fact]
public void __Upstream_0031294477_0feb3bb8980db47c()
{
        try
        {
            this.testCOSArrayValue();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2650881425_1ec668f790dcffb5()
{
        try
        {
            this.testCOSNameValue();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2952891659_ca7e0751ac8b33c8()
{
        try
        {
            this.testCOSStringValue();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2380719515_937f4c2d73e9a2d0()
{
        try
        {
            this.testTextAsCOSStreamValue();
        }
        finally
        {
        }
}
}
