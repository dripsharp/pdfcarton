// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Cos;

public abstract class TestCOSNumber : global::DripSharp.PdfCarton.Cos.TestCOSBase {
internal abstract void testFloatValue();

internal abstract void testIntValue();

internal abstract void testLongValue();

internal virtual void testGet() {
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.Zero, global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "0")), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.Zero, global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-")), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.Zero, global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", ".")), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.One, global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "1")), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.Two, global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "2")), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.Three, global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "3")), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(100)), global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "100")), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(256)), global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "256")), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(-1000)), global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-1000")), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(2000)), global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "+2000")), null);
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat(1.1F), global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "1.1")), null);
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat(100.0F), global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "100.0")), null);
global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Cos.COSFloat(-100.001F), global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-100.001")), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-2e-006")), null);
global::DripSharp.Testing.JavaAssertions.NotNull(global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-8e+05")), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.NullReferenceException>(() => global::DripSharp.PdfCarton.Cos.COSNumber.Get((string)default!), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "a")), null);
}

internal virtual void testLargeNumber() {
global::DripSharp.PdfCarton.Cos.COSNumber cosNumber = global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.StringValueOf(long.MaxValue)));
global::DripSharp.Testing.JavaAssertions.True((cosNumber is global::DripSharp.PdfCarton.Cos.COSInteger), null);
global::DripSharp.PdfCarton.Cos.COSInteger cosInteger = (global::DripSharp.PdfCarton.Cos.COSInteger)(cosNumber!);
global::DripSharp.Testing.JavaAssertions.True(cosInteger.IsValid(), null);
cosNumber = global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.StringValueOf(long.MinValue)));
global::DripSharp.Testing.JavaAssertions.True((cosNumber is global::DripSharp.PdfCarton.Cos.COSInteger), null);
cosInteger = (global::DripSharp.PdfCarton.Cos.COSInteger)(cosNumber!);
global::DripSharp.Testing.JavaAssertions.True(cosInteger.IsValid(), null);
cosNumber = global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "18446744073307448448"));
global::DripSharp.Testing.JavaAssertions.True((cosNumber is global::DripSharp.PdfCarton.Cos.COSInteger), null);
cosInteger = (global::DripSharp.PdfCarton.Cos.COSInteger)(cosNumber!);
global::DripSharp.Testing.JavaAssertions.False(cosInteger.IsValid(), null);
cosNumber = global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "-18446744073307448448"));
global::DripSharp.Testing.JavaAssertions.True((cosNumber is global::DripSharp.PdfCarton.Cos.COSInteger), null);
cosInteger = (global::DripSharp.PdfCarton.Cos.COSInteger)(cosNumber!);
global::DripSharp.Testing.JavaAssertions.False(cosInteger.IsValid(), null);
}

internal virtual void testInvalidNumber() {
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => global::DripSharp.PdfCarton.Cos.COSNumber.Get(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "18446744073307F448448")), null);
}

internal TestCOSNumber() {}
}
