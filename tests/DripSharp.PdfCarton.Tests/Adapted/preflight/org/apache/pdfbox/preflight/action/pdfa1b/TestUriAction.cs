// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Action.Pdfa1b;

public class TestUriAction : global::DripSharp.PdfCarton.Preflight.Action.Pdfa1b.AbstractTestAction {
protected internal virtual global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI CreateAction() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI action = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI();
action.SetURI(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "http://www.apache.org"));
return action;
}

internal virtual void test() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDAction action = this.CreateAction();
this.Valid(action, true);
}

internal virtual void testMissingURI() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI action = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI();
this.Valid(action, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionMisingKey));
}

internal virtual void testInvalidURI() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI action = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI();
action.GetCOSObject().SetBoolean(global::DripSharp.PdfCarton.Cos.COSName.Uri, true);
this.Valid(action, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionInvalidType));
}

internal virtual void testNextValid() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI action = this.CreateAction();
action.SetNext(global::DripSharp.Runtime.JavaCompat.AsList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDAction>(this.CreateAction()));
this.Valid(action, true);
}

internal virtual void testNextInvalid() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionURI action = this.CreateAction();
action.SetNext(global::DripSharp.Runtime.JavaCompat.AsList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDAction>(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDActionJavaScript()));
this.Valid(action, false, global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", global::DripSharp.PdfCarton.Preflight.PreflightConstants.ErrorActionForbiddenActionsExplicitlyForbidden));
}

[Xunit.Fact]
public void __Upstream_2151040146_0fa358b8cc0deb03()
{
        try
        {
            this.test();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3896578599_fc5dce34e404a518()
{
        try
        {
            this.testInvalidURI();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1338415192_9faac8a10809e39e()
{
        try
        {
            this.testMissingURI();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0504662930_03de32c882ef740a()
{
        try
        {
            this.testNextInvalid();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4025537623_008ae9fe3b1fb6b6()
{
        try
        {
            this.testNextValid();
        }
        finally
        {
        }
}
}
