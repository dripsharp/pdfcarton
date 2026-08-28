// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Action.Pdfa1b;

public class TestThreadAction
: global::DripSharp.PdfCarton.Preflight.Action.Pdfa1b.AbstractTestAction {
  protected internal virtual global::DripSharp.PdfCarton.Cos.COSDictionary CreateSubmitAction() {
    global::DripSharp.PdfCarton.Cos.COSDictionary action
      = new global::DripSharp.PdfCarton.Cos.COSDictionary();
    action.SetItem(global::DripSharp.PdfCarton.Cos.COSName.Type,
      global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "Action")));
    action.SetItem(global::DripSharp.PdfCarton.Cos.COSName.S,
      global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "Thread")));
    action.SetInt(global::DripSharp.PdfCarton.Cos.COSName.D, 1);
    return action;
  }

  internal virtual void test() {
    global::DripSharp.PdfCarton.Cos.COSDictionary action = this.CreateSubmitAction();
    this.Valid(action, true);
  }

  internal virtual void testMissingD() {
    global::DripSharp.PdfCarton.Cos.COSDictionary action = this.CreateSubmitAction();
    action.RemoveItem(global::DripSharp.PdfCarton.Cos.COSName.D);
    this.Valid(action, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionMisingKey));
  }

  internal virtual void testInvalidD() {
    global::DripSharp.PdfCarton.Cos.COSDictionary action = this.CreateSubmitAction();
    action.SetBoolean(global::DripSharp.PdfCarton.Cos.COSName.D, false);
    this.Valid(action, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionInvalidType));
  }

  [Xunit.Fact]
  public void __Upstream_2151040146_2552b6493113b56f() {
    try {
      this.test();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3485615071_d5be491943a1c826() {
    try {
      this.testInvalidD();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1655022160_70e3e7047379f645() {
    try {
      this.testMissingD();
    } finally {
    }
  }
}
