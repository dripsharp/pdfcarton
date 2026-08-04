// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel;

public class PageLayoutTest {
internal virtual void testValues() {
global::System.Collections.Generic.ISet<global::DripSharp.PdfCarton.Pdmodel.PageLayout> pageLayoutSet = global::DripSharp.Runtime.JavaCompat.EnumSetNoneOf<global::DripSharp.PdfCarton.Pdmodel.PageLayout>(typeof(global::DripSharp.PdfCarton.Pdmodel.PageLayout));
global::System.Collections.Generic.ISet<string> stringSet = new global::System.Collections.Generic.HashSet<string>();
foreach (global::DripSharp.PdfCarton.Pdmodel.PageLayout pl in global::DripSharp.PdfCarton.Pdmodel.PageLayout.values()) {
string s = pl.StringValue();
stringSet.Add(s);
pageLayoutSet.Add(global::DripSharp.PdfCarton.Pdmodel.PageLayout.FromString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", s)));
}
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.PageLayout.values().Length, pageLayoutSet.Count, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.PageLayout.values().Length, stringSet.Count, null);
}

internal virtual void fromStringInputNotNullOutputIllegalArgumentException() {
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => global::DripSharp.PdfCarton.Pdmodel.PageLayout.FromString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "SinglePag")), null);
}

[Xunit.Fact]
public void __Upstream_3325848072_c122ab2b2aee7668()
{
        try
        {
            this.fromStringInputNotNullOutputIllegalArgumentException();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3943405652_2ee212001a38e9c3()
{
        try
        {
            this.testValues();
        }
        finally
        {
        }
}
}
