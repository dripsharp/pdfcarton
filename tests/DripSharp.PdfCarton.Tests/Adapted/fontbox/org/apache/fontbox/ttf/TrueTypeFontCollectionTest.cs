// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf;

public class TrueTypeFontCollectionTest {
internal virtual void testNumberOfFonts() {
sbyte[] payload = new sbyte[] { unchecked((sbyte)(116)), unchecked((sbyte)(116)), unchecked((sbyte)(99)), unchecked((sbyte)(102)), unchecked((sbyte)(0)), unchecked((sbyte)(0)), unchecked((sbyte)(0)), unchecked((sbyte)(0)), unchecked((sbyte)(127)), unchecked((sbyte)(255)), unchecked((sbyte)(255)), unchecked((sbyte)(255)) };
global::DripSharp.Testing.JavaAssertions.Throws<global::System.IO.IOException>(() => new global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeCollection(global::DripSharp.Runtime.JavaCompat.NewMemoryStream(payload)), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "Invalid number of fonts not detected!"));
}

[Xunit.Fact]
public void __Upstream_2711494514_cda9d86807882708()
{
        try
        {
            this.testNumberOfFonts();
        }
        finally
        {
        }
}
}
