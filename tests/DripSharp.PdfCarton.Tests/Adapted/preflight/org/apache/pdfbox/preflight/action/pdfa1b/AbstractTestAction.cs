// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Action.Pdfa1b;

public abstract class AbstractTestAction {
  protected internal virtual global::DripSharp.PdfCarton.Preflight.PreflightContext CreateContext() {
    global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "src/test/resources/pdfa-with-annotations-square.pdf")));
    global::DripSharp.PdfCarton.Preflight.PreflightDocument preflightDocument
      = new global::DripSharp.PdfCarton.Preflight.PreflightDocument(doc.GetDocument(),
      global::DripSharp.PdfCarton.Preflight.Format.PdfA1b);
    global::DripSharp.PdfCarton.Preflight.PreflightContext ctx
      = new global::DripSharp.PdfCarton.Preflight.PreflightContext();
    ctx.SetDocument(preflightDocument);
    preflightDocument.SetContext(ctx);
    return ctx;
  }

  protected internal virtual void Valid(global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDAction action,
    bool valid) {
    this.Valid(action, valid, (string)default!);
  }

  protected internal virtual void Valid(global::DripSharp.PdfCarton.Cos.COSDictionary action,
    bool valid) {
    this.Valid(action, valid, (string)default!);
  }

  protected internal virtual void Valid(global::DripSharp.PdfCarton.Pdmodel.Interactive.Action.PDAction action,
    bool valid, string expectedCode) {
    this.Valid(action.GetCOSObject(), valid,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", expectedCode));
  }

  protected internal virtual void Valid(global::DripSharp.PdfCarton.Cos.COSDictionary action,
    bool valid, string expectedCode) {
    global::DripSharp.PdfCarton.Preflight.Action.ActionManagerFactory fact
      = new global::DripSharp.PdfCarton.Preflight.Action.ActionManagerFactory();
    global::DripSharp.PdfCarton.Preflight.PreflightContext ctx = this.CreateContext();
    ctx.SetConfig(global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.CreatePdfA1BConfiguration());
    global::DripSharp.PdfCarton.Cos.COSDictionary dict
      = new global::DripSharp.PdfCarton.Cos.COSDictionary();
    dict.SetItem(global::DripSharp.PdfCarton.Cos.COSName.A, action);
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Preflight.Action.AbstractActionManager> actions
      = fact.GetActionManagers(ctx, dict);
    foreach (global::DripSharp.PdfCarton.Preflight.Action.AbstractActionManager abstractActionManager in actions) {
      abstractActionManager.Valid();
    }
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError> errors
      = ctx.GetDocument().GetValidationErrors();
    if (!valid) {
      global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(errors),
        null);
      if (((expectedCode != default!) && !((expectedCode.Length == 0)))) {
        bool found = false;
        foreach (global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError err in errors) {
          if (global::DripSharp.Runtime.JavaCompat.Equals(err.GetErrorCode(), expectedCode)) {
            found = true;
            break;
          }
        }
        global::DripSharp.Testing.JavaAssertions.True(found, null);
      }
    } else {
      global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(errors),
        null);
    }
    ctx.GetDocument().Dispose();
  }

  public AbstractTestAction() {}
}
