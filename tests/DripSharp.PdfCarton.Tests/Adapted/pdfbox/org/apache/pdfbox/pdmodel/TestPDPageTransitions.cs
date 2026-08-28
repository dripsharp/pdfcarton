// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel;

public class TestPDPageTransitions {
  internal virtual void readTransitions() {
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "/org/apache/pdfbox/pdmodel/interactive/pagenavigation/transitions_test.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition firstTransition
        = doc.GetPages().Get(0).GetTransition();
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.EnumName(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionStyle.Glitter),
        firstTransition.GetStyle(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((float)(2), firstTransition.GetDuration(),
        null, (float)(0));
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionDirection.TopLeftToBottomRight.GetCOSBase(),
        firstTransition.GetDirection(), null);
    }
  }

  internal virtual void saveAndReadTransitions() {
    global::DripSharp.Runtime.JavaByteArrayOutputStream baos
      = new global::DripSharp.Runtime.JavaByteArrayOutputStream();
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument document
      = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
      global::DripSharp.PdfCarton.Pdmodel.PDPage page__62_20
        = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
      document.AddPage(page__62_20);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition transition
        = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionStyle.Fly);
      transition.SetDirection(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionDirection.None);
      transition.SetFlyScale(0.5F);
      page__62_20.SetTransition(transition, (float)(2));
      document.Save(baos);
    }
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.Runtime.JavaCompat.ToSignedBytes(baos))) {
      global::DripSharp.PdfCarton.Pdmodel.PDPage page__74_20 = doc.GetPages().Get(0);
      global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition loadedTransition
        = page__74_20.GetTransition();
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.EnumName(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionStyle.Fly),
        loadedTransition.GetStyle(), null);
      global::DripSharp.Testing.JavaAssertions.Equal((float)(2),
        page__74_20.GetCOSObject().GetFloat(global::DripSharp.PdfCarton.Cos.COSName.Dur), null,
        (float)(0));
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionDirection.None.GetCOSBase(),
        loadedTransition.GetDirection(), null);
    }
  }

  [Xunit.Fact]
  public void __Upstream_4074492488_a6edddd81a220e22() {
    try {
      this.readTransitions();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2202681294_bb094c1b29fe5af9() {
    try {
      this.saveAndReadTransitions();
    } finally {
    }
  }
}
