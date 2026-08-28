// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation;

public class PDTransitionTest {
  internal virtual void defaultStyle() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition transition
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition();
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Trans,
      transition.GetCOSObject().GetCOSName(global::DripSharp.PdfCarton.Cos.COSName.Type), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.EnumName(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionStyle.R),
      transition.GetStyle(), null);
  }

  internal virtual void getStyle() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition transition
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionStyle.Fade);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.Trans,
      transition.GetCOSObject().GetCOSName(global::DripSharp.PdfCarton.Cos.COSName.Type), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.EnumName(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionStyle.Fade),
      transition.GetStyle(), null);
  }

  internal virtual void defaultValues() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition transition
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition(new global::DripSharp.PdfCarton.Cos.COSDictionary());
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.EnumName(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionStyle.R),
      transition.GetStyle(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.EnumName(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionDimension.H),
      transition.GetDimension(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.EnumName(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionMotion.I),
      transition.GetMotion(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.Zero,
      transition.GetDirection(), null);
    global::DripSharp.Testing.JavaAssertions.Equal((float)(1), transition.GetDuration(), null,
      (float)(0));
    global::DripSharp.Testing.JavaAssertions.Equal((float)(1), transition.GetFlyScale(), null,
      (float)(0));
    global::DripSharp.Testing.JavaAssertions.False(transition.IsFlyAreaOpaque(), null);
  }

  internal virtual void dimension() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition transition
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition();
    transition.SetDimension(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionDimension.H);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.EnumName(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionDimension.H),
      transition.GetDimension(), null);
  }

  internal virtual void directionNone() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition transition
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition();
    transition.SetDirection(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionDirection.None);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ClassName(typeof(global::DripSharp.PdfCarton.Cos.COSName),
      "DripSharp.PdfCarton", "org.apache.pdfbox"),
      global::DripSharp.Runtime.JavaCompat.ClassName(((object)(transition.GetDirection())).GetType(),
      "DripSharp.PdfCarton", "org.apache.pdfbox"), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSName.None,
      transition.GetDirection(), null);
  }

  internal virtual void directionNumber() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition transition
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition();
    transition.SetDirection(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionDirection.LeftToRight);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ClassName(typeof(global::DripSharp.PdfCarton.Cos.COSInteger),
      "DripSharp.PdfCarton", "org.apache.pdfbox"),
      global::DripSharp.Runtime.JavaCompat.ClassName(((object)(transition.GetDirection())).GetType(),
      "DripSharp.PdfCarton", "org.apache.pdfbox"), null);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Cos.COSInteger.Zero,
      transition.GetDirection(), null);
  }

  internal virtual void motion() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition transition
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition();
    transition.SetMotion(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionMotion.O);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.EnumName(global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransitionMotion.O),
      transition.GetMotion(), null);
  }

  internal virtual void duration() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition transition
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition();
    transition.SetDuration((float)(4));
    global::DripSharp.Testing.JavaAssertions.Equal((float)(4), transition.GetDuration(), null,
      (float)(0));
  }

  internal virtual void flyScale() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition transition
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition();
    transition.SetFlyScale((float)(4));
    global::DripSharp.Testing.JavaAssertions.Equal((float)(4), transition.GetFlyScale(), null,
      (float)(0));
  }

  internal virtual void flyArea() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition transition
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDTransition();
    transition.SetFlyAreaOpaque(true);
    global::DripSharp.Testing.JavaAssertions.True(transition.IsFlyAreaOpaque(), null);
  }

  [Xunit.Fact]
  public void __Upstream_1486166000_51b5d176fc03bf96() {
    try {
      this.defaultStyle();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3189435075_3d62201e5949b37a() {
    try {
      this.defaultValues();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1052470630_3e2c1b648eb3c40d() {
    try {
      this.dimension();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1617384279_94ff877800aa1e3f() {
    try {
      this.directionNone();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3828609960_ac22c8479b6ee517() {
    try {
      this.directionNumber();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0155471252_ed495eb8cb85f844() {
    try {
      this.duration();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1389322144_d5bdcbf7db926b11() {
    try {
      this.flyArea();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0135486615_42d06c1237f1bf36() {
    try {
      this.flyScale();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4113089531_0d010d0d54a6fb53() {
    try {
      this.getStyle();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1079164854_336cdf0d66bc0941() {
    try {
      this.motion();
    } finally {
    }
  }
}
