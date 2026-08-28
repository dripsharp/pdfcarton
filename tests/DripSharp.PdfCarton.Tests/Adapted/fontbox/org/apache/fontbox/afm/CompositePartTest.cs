// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Afm;

public class CompositePartTest {
  internal virtual void testCompositePart() {
    global::DripSharp.PdfCarton.Fonts.Afm.CompositePart compositePart
      = new global::DripSharp.PdfCarton.Fonts.Afm.CompositePart(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "name"), 10, 20);
    global::DripSharp.Testing.JavaAssertions.Equal("name", compositePart.GetName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(10, compositePart.GetXDisplacement(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(20, compositePart.GetYDisplacement(), null);
  }

  [Xunit.Fact]
  public void __Upstream_0995170216_8b1019115d570d4f() {
    try {
      this.testCompositePart();
    } finally {
    }
  }
}
