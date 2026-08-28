// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Annotation;

public class PDCircleAnnotationTest {
  internal virtual void createDefaultCircleAnnotation() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation annotation
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationCircle();
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Annot,
      annotation.GetCOSObject().GetItem(global::DripSharp.PdfCarton.Cos.COSName.Type), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationCircle.SubType,
      annotation.GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.Subtype),
      null);
  }

  [Xunit.Fact]
  public void __Upstream_0827200484_506479fc8b523d9e() {
    try {
      this.createDefaultCircleAnnotation();
    } finally {
    }
  }
}
