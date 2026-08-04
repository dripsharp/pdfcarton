// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Action.Pdfa1b;

public class TestNamedAction : global::DripSharp.PdfCarton.Preflight.Action.Pdfa1b.AbstractTestAction {
protected internal virtual global::DripSharp.PdfCarton.Cos.COSDictionary CreateNamedAction() {
global::DripSharp.PdfCarton.Cos.COSDictionary namedAction = new global::DripSharp.PdfCarton.Cos.COSDictionary();
namedAction.SetItem(global::DripSharp.PdfCarton.Cos.COSName.Type, global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "Action")));
namedAction.SetItem(global::DripSharp.PdfCarton.Cos.COSName.S, global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "Named")));
return namedAction;
}

internal virtual void testFirstPage() {
global::DripSharp.PdfCarton.Cos.COSDictionary namedAction = this.CreateNamedAction();
namedAction.SetItem(global::DripSharp.PdfCarton.Cos.COSName.N, global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.PreflightConstants.ActionDictionaryValueAtypeNamedFirst)));
this.Valid(namedAction, true);
}

internal virtual void testLastPage() {
global::DripSharp.PdfCarton.Cos.COSDictionary namedAction = this.CreateNamedAction();
namedAction.SetItem(global::DripSharp.PdfCarton.Cos.COSName.N, global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.PreflightConstants.ActionDictionaryValueAtypeNamedLast)));
this.Valid(namedAction, true);
}

internal virtual void testNextPage() {
global::DripSharp.PdfCarton.Cos.COSDictionary namedAction = this.CreateNamedAction();
namedAction.SetItem(global::DripSharp.PdfCarton.Cos.COSName.N, global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.PreflightConstants.ActionDictionaryValueAtypeNamedNext)));
this.Valid(namedAction, true);
}

internal virtual void testPrevPage() {
global::DripSharp.PdfCarton.Cos.COSDictionary namedAction = this.CreateNamedAction();
namedAction.SetItem(global::DripSharp.PdfCarton.Cos.COSName.N, global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.PreflightConstants.ActionDictionaryValueAtypeNamedPrev)));
this.Valid(namedAction, true);
}

internal virtual void testMissingN() {
global::DripSharp.PdfCarton.Cos.COSDictionary namedAction = this.CreateNamedAction();
this.Valid(namedAction, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionMisingKey));
}

internal virtual void testForbiddenN() {
global::DripSharp.PdfCarton.Cos.COSDictionary namedAction = this.CreateNamedAction();
namedAction.SetItem(global::DripSharp.PdfCarton.Cos.COSName.N, global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "unknown")));
this.Valid(namedAction, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionForbiddenActionsNamed));
}

[Xunit.Fact]
public void __Upstream_2950082797_ee791cf609f2c149()
{
        try
        {
            this.testFirstPage();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0799405479_1159dbe27409bb3b()
{
        try
        {
            this.testForbiddenN();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1402283255_ba8c199db5be8c42()
{
        try
        {
            this.testLastPage();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1655022170_1092f4ae962aee7e()
{
        try
        {
            this.testMissingN();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4286097108_b81128b2f9b1453a()
{
        try
        {
            this.testNextPage();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1587289620_4e6446d654ec33b5()
{
        try
        {
            this.testPrevPage();
        }
        finally
        {
        }
}
}
