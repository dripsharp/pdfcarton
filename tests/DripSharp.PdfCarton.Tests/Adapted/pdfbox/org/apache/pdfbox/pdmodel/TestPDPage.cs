// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel;

public class TestPDPage {
  internal virtual void testAddingPageAfterCreatingAnnotation() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_38_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage(global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle.A4);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm acroForm
          = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDAcroForm(document);
        document.GetDocumentCatalog().SetAcroForm(acroForm);
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField textField
          = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDTextField(acroForm);
        textField.SetPartialName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "testField"));
        global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget
          = global::DripSharp.Runtime.JavaCompat.ListGet(textField.GetWidgets(), 0);
        widget.SetRectangle(new global::DripSharp.PdfCarton.Pdmodel.Common.PDRectangle((float)(100),
          (float)(700), (float)(200), (float)(20)));
        widget.SetPage(page);
        global::DripSharp.Runtime.JavaCompat.Add(page.GetAnnotations(), widget);
        global::DripSharp.Runtime.JavaCompat.Add(acroForm.GetFields(), textField);
        global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => document.AddPage(page), null);
        document.Save(new global::DripSharp.Runtime.JavaByteArrayOutputStream());
        document.Dispose();
      } catch (global::System.Exception __dripsharpCaught_38_25_0) {
        __dripsharpPrimary_38_25_0 = __dripsharpCaught_38_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document, __dripsharpPrimary_38_25_0);
      }
    }
  }

  internal virtual void testNullThreadBeads() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument document
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_66_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
        global::DripSharp.Testing.JavaAssertions.Equal(0,
          global::DripSharp.Runtime.JavaCompat.CollectionCount(page.GetThreadBeads()), null);
        page.SetThreadBeads(new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDThreadBead>());
        global::DripSharp.Testing.JavaAssertions.Equal(0,
          global::DripSharp.Runtime.JavaCompat.CollectionCount(page.GetThreadBeads()), null);
        page.SetThreadBeads((global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Pagenavigation.PDThreadBead>)default!);
        global::DripSharp.Testing.JavaAssertions.Equal(0,
          global::DripSharp.Runtime.JavaCompat.CollectionCount(page.GetThreadBeads()), null);
      } catch (global::System.Exception __dripsharpCaught_66_25_0) {
        __dripsharpPrimary_66_25_0 = __dripsharpCaught_66_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(document, __dripsharpPrimary_66_25_0);
      }
    }
  }

  [Xunit.Fact]
  public void __Upstream_2741754722_cce5ba33a3fb4bd3() {
    try {
      this.testAddingPageAfterCreatingAnnotation();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4286385834_fb3042ee298a6d3a() {
    try {
      this.testNullThreadBeads();
    } finally {
    }
  }
}
