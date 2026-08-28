// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Action.Pdfa1b;

public class TestForbiddenAction
: global::DripSharp.PdfCarton.Preflight.Action.Pdfa1b.AbstractTestAction {
  protected internal virtual global::DripSharp.PdfCarton.Cos.COSDictionary CreateAction(string type) {
    global::DripSharp.PdfCarton.Cos.COSDictionary action
      = new global::DripSharp.PdfCarton.Cos.COSDictionary();
    action.SetItem(global::DripSharp.PdfCarton.Cos.COSName.Type,
      global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "Action")));
    action.SetItem(global::DripSharp.PdfCarton.Cos.COSName.S,
      global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      type)));
    return action;
  }

  internal virtual void testLaunch() {
    global::DripSharp.PdfCarton.Cos.COSDictionary action
      = this.CreateAction(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "Launch"));
    this.Valid(action, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionForbiddenActionsExplicitlyForbidden));
  }

  internal virtual void testSound() {
    global::DripSharp.PdfCarton.Cos.COSDictionary action
      = this.CreateAction(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "Sound"));
    this.Valid(action, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionForbiddenActionsExplicitlyForbidden));
  }

  internal virtual void testMovie() {
    global::DripSharp.PdfCarton.Cos.COSDictionary action
      = this.CreateAction(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "Movie"));
    this.Valid(action, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionForbiddenActionsExplicitlyForbidden));
  }

  internal virtual void testImportData() {
    global::DripSharp.PdfCarton.Cos.COSDictionary action
      = this.CreateAction(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "ImportData"));
    this.Valid(action, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionForbiddenActionsExplicitlyForbidden));
  }

  internal virtual void testResetForm() {
    global::DripSharp.PdfCarton.Cos.COSDictionary action
      = this.CreateAction(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "ResetForm"));
    this.Valid(action, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionForbiddenActionsExplicitlyForbidden));
  }

  internal virtual void testJS() {
    global::DripSharp.PdfCarton.Cos.COSDictionary action
      = this.CreateAction(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "JavaScript"));
    this.Valid(action, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionForbiddenActionsExplicitlyForbidden));
  }

  [Xunit.Fact]
  public void __Upstream_3558248225_d431895c42e6053f() {
    try {
      this.testImportData();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1270313307_61f6102ebf9e5380() {
    try {
      this.testJS();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3657375461_c3d81dee341f3164() {
    try {
      this.testLaunch();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0950605246_d8cc0c77e4fdd84f() {
    try {
      this.testMovie();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0545603137_be33e0dd18d64d68() {
    try {
      this.testResetForm();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0956145565_f6e71bb8f3ad3b91() {
    try {
      this.testSound();
    } finally {
    }
  }
}
