// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Common;

public class PDStreamTest {
internal virtual void testCreateInputStreamNullFilters() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(new sbyte[] { unchecked((sbyte)(12)), unchecked((sbyte)(34)), unchecked((sbyte)(56)), unchecked((sbyte)(78)) });
global::DripSharp.PdfCarton.Pdmodel.Common.PDStream pdStream = new global::DripSharp.PdfCarton.Pdmodel.Common.PDStream(doc, @is, (global::DripSharp.PdfCarton.Cos.COSArray)default!);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(pdStream.GetFilters()), null);
global::System.Collections.Generic.IList<string> stopFilters = new global::System.Collections.Generic.List<string>();
global::DripSharp.Runtime.JavaCompat.Add(stopFilters, global::DripSharp.PdfCarton.Cos.COSName.DctDecode.ToString());
global::DripSharp.Runtime.JavaCompat.Add(stopFilters, global::DripSharp.PdfCarton.Cos.COSName.DctDecodeAbbreviation.ToString());
@is = pdStream.CreateInputStream(stopFilters);
global::DripSharp.Testing.JavaAssertions.Equal(12, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is), null);
global::DripSharp.Testing.JavaAssertions.Equal(34, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is), null);
global::DripSharp.Testing.JavaAssertions.Equal(56, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is), null);
global::DripSharp.Testing.JavaAssertions.Equal(78, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is), null);
global::DripSharp.Testing.JavaAssertions.Equal(-1, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is), null);
}
}

internal virtual void testCreateInputStreamEmptyFilters() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(new sbyte[] { unchecked((sbyte)(12)), unchecked((sbyte)(34)), unchecked((sbyte)(56)), unchecked((sbyte)(78)) });
global::DripSharp.PdfCarton.Pdmodel.Common.PDStream pdStream = new global::DripSharp.PdfCarton.Pdmodel.Common.PDStream(doc, @is, new global::DripSharp.PdfCarton.Cos.COSArray());
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.Runtime.JavaCompat.CollectionCount(pdStream.GetFilters()), null);
global::System.Collections.Generic.IList<string> stopFilters = new global::System.Collections.Generic.List<string>();
global::DripSharp.Runtime.JavaCompat.Add(stopFilters, global::DripSharp.PdfCarton.Cos.COSName.DctDecode.ToString());
global::DripSharp.Runtime.JavaCompat.Add(stopFilters, global::DripSharp.PdfCarton.Cos.COSName.DctDecodeAbbreviation.ToString());
@is = pdStream.CreateInputStream(stopFilters);
global::DripSharp.Testing.JavaAssertions.Equal(12, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is), null);
global::DripSharp.Testing.JavaAssertions.Equal(34, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is), null);
global::DripSharp.Testing.JavaAssertions.Equal(56, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is), null);
global::DripSharp.Testing.JavaAssertions.Equal(78, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is), null);
global::DripSharp.Testing.JavaAssertions.Equal(-1, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is), null);
}
}

internal virtual void testCreateInputStreamNullStopFilters() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::System.IO.Stream @is = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(new sbyte[] { unchecked((sbyte)(12)), unchecked((sbyte)(34)), unchecked((sbyte)(56)), unchecked((sbyte)(78)) });
global::DripSharp.PdfCarton.Pdmodel.Common.PDStream pdStream = new global::DripSharp.PdfCarton.Pdmodel.Common.PDStream(doc, @is, new global::DripSharp.PdfCarton.Cos.COSArray());
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.Runtime.JavaCompat.CollectionCount(pdStream.GetFilters()), null);
@is = pdStream.CreateInputStream((global::System.Collections.Generic.IList<string>)default!);
global::DripSharp.Testing.JavaAssertions.Equal(12, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is), null);
global::DripSharp.Testing.JavaAssertions.Equal(34, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is), null);
global::DripSharp.Testing.JavaAssertions.Equal(56, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is), null);
global::DripSharp.Testing.JavaAssertions.Equal(78, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is), null);
global::DripSharp.Testing.JavaAssertions.Equal(-1, global::DripSharp.Runtime.JavaCompat.InputStreamRead(@is), null);
}
}

[Xunit.Fact]
public void __Upstream_1289279210_1b46c23f1c073fc1()
{
        try
        {
            this.testCreateInputStreamEmptyFilters();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0877342712_c7479e3a009221c7()
{
        try
        {
            this.testCreateInputStreamNullFilters();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1869009686_fc3ff4c5c4a0add7()
{
        try
        {
            this.testCreateInputStreamNullStopFilters();
        }
        finally
        {
        }
}
}
