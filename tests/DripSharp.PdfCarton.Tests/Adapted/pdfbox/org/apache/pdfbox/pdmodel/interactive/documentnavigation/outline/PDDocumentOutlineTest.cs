// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline;

public class PDDocumentOutlineTest {
  internal virtual void outlinesCountShouldNotBeNegative() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDDocumentOutline outline
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDDocumentOutline();
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem firstLevelChild
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
    outline.AddLast(firstLevelChild);
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem secondLevelChild
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
    firstLevelChild.AddLast(secondLevelChild);
    global::DripSharp.Testing.JavaAssertions.Equal(0, secondLevelChild.GetOpenCount(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(-1, firstLevelChild.GetOpenCount(), null);
    global::DripSharp.Testing.JavaAssertions.False((outline.GetOpenCount() < 0),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat("Outlines count cannot be ",
      outline.GetOpenCount())));
  }

  internal virtual void outlinesCount() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDDocumentOutline outline
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDDocumentOutline();
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem root
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
    outline.AddLast(root);
    global::DripSharp.Testing.JavaAssertions.Equal(1, outline.GetOpenCount(), null);
    root.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
    global::DripSharp.Testing.JavaAssertions.Equal(-1, root.GetOpenCount(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(1, outline.GetOpenCount(), null);
    root.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
    global::DripSharp.Testing.JavaAssertions.Equal(-2, root.GetOpenCount(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(1, outline.GetOpenCount(), null);
    root.OpenNode();
    global::DripSharp.Testing.JavaAssertions.Equal(2, root.GetOpenCount(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(3, outline.GetOpenCount(), null);
  }

  [Xunit.Fact]
  public void __Upstream_0258408222_d079344bdb0e9aea() {
    try {
      this.outlinesCount();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1084531162_52d2f24cc3f98843() {
    try {
      this.outlinesCountShouldNotBeNegative();
    } finally {
    }
  }
}
