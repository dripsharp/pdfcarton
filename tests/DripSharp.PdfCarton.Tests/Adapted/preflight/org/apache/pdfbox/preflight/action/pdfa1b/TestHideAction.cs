// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Action.Pdfa1b;

public class TestHideAction : global::DripSharp.PdfCarton.Preflight.Action.Pdfa1b.AbstractTestAction {
protected internal virtual global::DripSharp.PdfCarton.Cos.COSDictionary CreateHideAction() {
global::DripSharp.PdfCarton.Cos.COSDictionary hideAction = new global::DripSharp.PdfCarton.Cos.COSDictionary();
hideAction.SetItem(global::DripSharp.PdfCarton.Cos.COSName.Type, global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "Action")));
hideAction.SetItem(global::DripSharp.PdfCarton.Cos.COSName.S, global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "Hide")));
hideAction.SetBoolean(global::DripSharp.PdfCarton.Cos.COSName.H, false);
hideAction.SetString(global::DripSharp.PdfCarton.Cos.COSName.T, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "avalue"));
return hideAction;
}

internal virtual void testHideAction() {
global::DripSharp.PdfCarton.Cos.COSDictionary action = this.CreateHideAction();
this.Valid(action, true);
}

internal virtual void testHideAction_InvalideH() {
global::DripSharp.PdfCarton.Cos.COSDictionary action = this.CreateHideAction();
action.SetBoolean(global::DripSharp.PdfCarton.Cos.COSName.H, true);
this.Valid(action, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionHideHInvalid));
}

internal virtual void testHideAction_InvalideT() {
global::DripSharp.PdfCarton.Cos.COSDictionary action = this.CreateHideAction();
action.SetBoolean(global::DripSharp.PdfCarton.Cos.COSName.T, true);
this.Valid(action, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionInvalidType));
}

internal virtual void testHideAction_MissingT() {
global::DripSharp.PdfCarton.Cos.COSDictionary action = this.CreateHideAction();
action.RemoveItem(global::DripSharp.PdfCarton.Cos.COSName.T);
this.Valid(action, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionMisingKey));
}

[Xunit.Fact]
public void __Upstream_1253564490_6d1df790eeb6fb58()
{
        try
        {
            this.testHideAction();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1472856805_022e027890348730()
{
        try
        {
            this.testHideAction_InvalideH();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1472856817_b81490810ab7db57()
{
        try
        {
            this.testHideAction_InvalideT();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1957696547_45b8e265fb30c24a()
{
        try
        {
            this.testHideAction_MissingT();
        }
        finally
        {
        }
}
}
