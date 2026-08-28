// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Cos;

public class TestCOSUpdateInfo {
  internal virtual void testIsSetNeedToBeUpdate() {
    global::DripSharp.PdfCarton.Cos.COSDocumentState origin
      = new global::DripSharp.PdfCarton.Cos.COSDocumentState();
    origin.SetParsing(false);
    global::DripSharp.PdfCarton.Cos.COSUpdateInfo testCOSDictionary
      = new global::DripSharp.PdfCarton.Cos.COSDictionary();
    ((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(testCOSDictionary)).SetNeedToBeUpdated(true);
    global::DripSharp.Testing.JavaAssertions.False(((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(testCOSDictionary)).IsNeedToBeUpdated(),
      null);
    testCOSDictionary.GetUpdateState().SetOriginDocumentState(origin);
    ((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(testCOSDictionary)).SetNeedToBeUpdated(true);
    global::DripSharp.Testing.JavaAssertions.True(((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(testCOSDictionary)).IsNeedToBeUpdated(),
      null);
    ((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(testCOSDictionary)).SetNeedToBeUpdated(false);
    global::DripSharp.Testing.JavaAssertions.False(((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(testCOSDictionary)).IsNeedToBeUpdated(),
      null);
    global::DripSharp.PdfCarton.Cos.COSUpdateInfo testCOSObject;
    testCOSObject
      = new global::DripSharp.PdfCarton.Cos.COSObject((global::DripSharp.PdfCarton.Cos.COSBase)default!);
    ((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(testCOSObject)).SetNeedToBeUpdated(true);
    global::DripSharp.Testing.JavaAssertions.False(((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(testCOSObject)).IsNeedToBeUpdated(),
      null);
    testCOSObject.GetUpdateState().SetOriginDocumentState(origin);
    ((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(testCOSObject)).SetNeedToBeUpdated(true);
    global::DripSharp.Testing.JavaAssertions.True(((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(testCOSObject)).IsNeedToBeUpdated(),
      null);
    ((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(testCOSObject)).SetNeedToBeUpdated(false);
    global::DripSharp.Testing.JavaAssertions.False(((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(testCOSObject)).IsNeedToBeUpdated(),
      null);
  }

  [Xunit.Fact]
  public void __Upstream_1831862979_adf12c40ece81a9a() {
    try {
      this.testIsSetNeedToBeUpdate();
    } finally {
    }
  }
}
