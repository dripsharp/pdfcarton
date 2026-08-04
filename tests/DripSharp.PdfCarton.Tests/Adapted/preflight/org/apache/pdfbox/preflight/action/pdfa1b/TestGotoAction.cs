// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Action.Pdfa1b;

public class TestGotoAction : global::DripSharp.PdfCarton.Preflight.Action.Pdfa1b.AbstractTestAction {
internal virtual void testGoto_OK() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo gotoAction = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo();
gotoAction.SetDestination(new Anonymous_38_35());
this.Valid(gotoAction, true);
}

private sealed class Anonymous_38_35 : global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDDestination {
public Anonymous_38_35() {}

public override global::DripSharp.PdfCarton.Cos.COSName GetCOSObject() {
return global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "ADest"));
}
}

internal virtual void testGoto_KO_invalidContent() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo gotoAction = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo();
gotoAction.SetDestination(new Anonymous_54_35());
this.Valid(gotoAction, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorSyntaxDictInvalid));
}

private sealed class Anonymous_54_35 : global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Destination.PDDestination {
public Anonymous_54_35() {}

public override global::DripSharp.PdfCarton.Cos.COSDictionary GetCOSObject() {
return new global::DripSharp.PdfCarton.Cos.COSDictionary();
}
}

internal virtual void testGoto_KO_missingD() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo gotoAction = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionGoTo();
this.Valid(gotoAction, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionMisingKey));
}

[Xunit.Fact]
public void __Upstream_3865789971_a1ac4a9aeaca6d3b()
{
        try
        {
            this.testGoto_KO_invalidContent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1459825647_322921a798af3d53()
{
        try
        {
            this.testGoto_KO_missingD();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1966848326_21b833d372276278()
{
        try
        {
            this.testGoto_OK();
        }
        finally
        {
        }
}
}
