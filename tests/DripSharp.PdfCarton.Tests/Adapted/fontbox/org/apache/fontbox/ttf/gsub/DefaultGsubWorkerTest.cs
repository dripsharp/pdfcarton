// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf.Gsub;

public class DefaultGsubWorkerTest {
  internal virtual void applyTransforms() {
    global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.DefaultGsubWorker sut
      = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.DefaultGsubWorker();
    global::System.Collections.Generic.IList<int> originalGlyphIds
      = global::DripSharp.Runtime.JavaCompat.AsList<int>(1, 2, 3, 4, 5);
    global::System.Collections.Generic.IList<int> pseudoTransformedIds
      = sut.ApplyTransforms(originalGlyphIds);
    global::System.Action modification = pseudoTransformedIds.Clear;
    global::DripSharp.Testing.JavaAssertions.Equal(originalGlyphIds, pseudoTransformedIds, null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(modification,
      null);
  }

  [Xunit.Fact(DisplayName
    = "Transformation result is actually a read-only version of the argument")]
  public void __Upstream_1701408917_cc14e459678c3426() {
    try {
      this.applyTransforms();
    } finally {
    }
  }
}
