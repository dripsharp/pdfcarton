// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Cos;

public abstract class TestCOSBase {
protected internal static global::DripSharp.PdfCarton.Cos.COSBase __field_TestCOSBase = null!;

internal virtual void testGetCOSObject() {
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.TestCOSBase.__field_TestCOSBase, global::DripSharp.PdfCarton.Cos.TestCOSBase.__field_TestCOSBase.GetCOSObject(), null);
}

internal abstract void testAccept();

internal virtual void testIsSetDirect() {
global::DripSharp.PdfCarton.Cos.TestCOSBase.__field_TestCOSBase.SetDirect(true);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.PdfCarton.Cos.TestCOSBase.__field_TestCOSBase.IsDirect(), null);
global::DripSharp.PdfCarton.Cos.TestCOSBase.__field_TestCOSBase.SetDirect(false);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.PdfCarton.Cos.TestCOSBase.__field_TestCOSBase.IsDirect(), null);
}

protected internal virtual void TestByteArrays(sbyte[] byteArr1, sbyte[] byteArr2) {
global::DripSharp.Testing.JavaAssertions.Equal(byteArr1.Length, byteArr1.Length, null);
for (int i = 0; (i < byteArr1.Length); i++) {
global::DripSharp.Testing.JavaAssertions.Equal(byteArr1[i], byteArr2[i], null);
}
}

internal TestCOSBase() {}
}
