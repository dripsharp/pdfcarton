// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Action.Pdfa1b;

public class TestSubmitAction
: global::DripSharp.PdfCarton.Preflight.Action.Pdfa1b.AbstractTestAction {
  protected internal virtual global::DripSharp.PdfCarton.Cos.COSDictionary CreateSubmitAction() {
    global::DripSharp.PdfCarton.Cos.COSDictionary action
      = new global::DripSharp.PdfCarton.Cos.COSDictionary();
    action.SetItem(global::DripSharp.PdfCarton.Cos.COSName.Type,
      global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "Action")));
    action.SetItem(global::DripSharp.PdfCarton.Cos.COSName.S,
      global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "SubmitForm")));
    action.SetItem(global::DripSharp.PdfCarton.Cos.COSName.F, new Anonymous_38_35());
    return action;
  }

  private sealed class Anonymous_38_35
  : global::DripSharp.PdfCarton.Pdmodel.Common.Filespecification.PDFileSpecification {
    public Anonymous_38_35() {}

    public override global::DripSharp.PdfCarton.Cos.COSName GetCOSObject() {
      return global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        "value"));
    }

    public override void SetFile(string file) {}

    public override string GetFile() {
      return default!;
    }
  }

  internal virtual void test() {
    global::DripSharp.PdfCarton.Cos.COSDictionary action = this.CreateSubmitAction();
    this.Valid(action, true);
  }

  internal virtual void testMissngF() {
    global::DripSharp.PdfCarton.Cos.COSDictionary action = this.CreateSubmitAction();
    action.RemoveItem(global::DripSharp.PdfCarton.Cos.COSName.F);
    this.Valid(action, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionMisingKey));
  }

  [Xunit.Fact]
  public void __Upstream_2151040146_2799e2fca0138c5e() {
    try {
      this.test();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2824339007_01d7fdc7d780c300() {
    try {
      this.testMissngF();
    } finally {
    }
  }
}
