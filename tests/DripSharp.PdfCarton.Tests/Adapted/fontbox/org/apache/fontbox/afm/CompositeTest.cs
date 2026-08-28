// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Afm;

public class CompositeTest {
  internal virtual void testComposite() {
    global::DripSharp.PdfCarton.Fonts.Afm.Composite composite
      = new global::DripSharp.PdfCarton.Fonts.Afm.Composite(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "name"));
    global::DripSharp.Testing.JavaAssertions.Equal("name", composite.GetName(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(0,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(composite.GetParts()), null);
    global::DripSharp.PdfCarton.Fonts.Afm.CompositePart compositePart
      = new global::DripSharp.PdfCarton.Fonts.Afm.CompositePart(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
      "name"), 10, 20);
    composite.AddPart(compositePart);
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Fonts.Afm.CompositePart> parts
      = composite.GetParts();
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(parts), null);
    global::DripSharp.Testing.JavaAssertions.Equal("name",
      global::DripSharp.Runtime.JavaCompat.ListGet(parts, 0).GetName(), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => global::DripSharp.Runtime.JavaCompat.Add(parts, compositePart), null);
  }

  [Xunit.Fact]
  public void __Upstream_1417433621_192ad7027e0e8ffc() {
    try {
      this.testComposite();
    } finally {
    }
  }
}
