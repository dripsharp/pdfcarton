// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Action.Pdfa1b;

public class TestGotoRemoteAction
: global::DripSharp.PdfCarton.Preflight.Action.Pdfa1b.AbstractTestAction {
  internal virtual void testGoto_OK() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionRemoteGoTo gotoAction
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionRemoteGoTo();
    gotoAction.SetD(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "ADest")));
    gotoAction.SetFile(new Anonymous_39_28());
    this.Valid(gotoAction, true);
  }

  private sealed class Anonymous_39_28
  : global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDFileSpecification {
    public Anonymous_39_28() {}

    public override global::DripSharp.PdfCarton.Cos.COSName GetCOSObject() {
      return global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        "ADest"));
    }

    public override void SetFile(string file) {}

    public override string GetFile() {
      return "pouey";
    }
  }

  internal virtual void testGoto_KO_InvalidContent() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionRemoteGoTo gotoAction
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionRemoteGoTo();
    gotoAction.SetD(new global::DripSharp.PdfCarton.Cos.COSDictionary());
    gotoAction.SetFile(new Anonymous_66_28());
    this.Valid(gotoAction, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionInvalidType));
  }

  private sealed class Anonymous_66_28
  : global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDFileSpecification {
    public Anonymous_66_28() {}

    public override global::DripSharp.PdfCarton.Cos.COSName GetCOSObject() {
      return global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        "ADest"));
    }

    public override void SetFile(string file) {}

    public override string GetFile() {
      return "pouey";
    }
  }

  internal virtual void testGoto_KO_MissingD() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionRemoteGoTo gotoAction
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionRemoteGoTo();
    gotoAction.SetFile(new Anonymous_92_28());
    this.Valid(gotoAction, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionMisingKey));
  }

  private sealed class Anonymous_92_28
  : global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDFileSpecification {
    public Anonymous_92_28() {}

    public override global::DripSharp.PdfCarton.Cos.COSName GetCOSObject() {
      return global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        "ADest"));
    }

    public override void SetFile(string file) {}

    public override string GetFile() {
      return "pouey";
    }
  }

  internal virtual void testGoto_KO_MissingF() {
    global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionRemoteGoTo gotoAction
      = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionRemoteGoTo();
    gotoAction.SetD(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "ADest")));
    this.Valid(gotoAction, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionMisingKey));
  }

  [Xunit.Fact]
  public void __Upstream_2863796787_e2878687f4ac771c() {
    try {
      this.testGoto_KO_InvalidContent();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1524469775_046c6988635bd65b() {
    try {
      this.testGoto_KO_MissingD();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1524469777_7edeaf33a8fdea24() {
    try {
      this.testGoto_KO_MissingF();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1966848326_03ddf084fd03aeee() {
    try {
      this.testGoto_OK();
    } finally {
    }
  }
}
