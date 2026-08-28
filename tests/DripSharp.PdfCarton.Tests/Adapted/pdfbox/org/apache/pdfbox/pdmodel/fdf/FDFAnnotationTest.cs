// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Fdf;

public class FDFAnnotationTest {
  internal virtual void loadXFDFAnnotations() {
    global::System.IO.FileInfo f
      = global::DripSharp.Runtime.JavaCompat.NewFileInfo(global::DripSharp.PdfCarton.Tests.Support.ResourceUri(typeof(global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFAnnotationTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "xfdf-test-document-annotations.xml")));
    using (global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFDocument fdfDoc
      = global::DripSharp.PdfCarton.Loader.LoadXFDF(f)) {
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFAnnotation> fdfAnnots
        = fdfDoc.GetCatalog().GetFDF().GetAnnotations();
      global::DripSharp.Testing.JavaAssertions.Equal(18,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(fdfAnnots), null);
      bool testedPDFBox4345andPDFBox3646 = false;
      foreach (global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFAnnotation ann in fdfAnnots) {
        if ((ann is global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFAnnotationFreeText)) {
          global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFAnnotationFreeText annotationFreeText
            = (global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFAnnotationFreeText)(ann!);
          if (global::DripSharp.Runtime.JavaCompat.Equals("P&1 P&2 P&3",
            annotationFreeText.GetContents())) {
            testedPDFBox4345andPDFBox3646 = true;
            global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<body style=\"font:12pt Helvetica; ",
              "color:#D66C00;\" xfa:APIVersion=\"Acrobat:7.0.8\" "),
              "xfa:spec=\"2.0.2\" xmlns=\"http://www.w3.org/1999/xhtml\" "),
              "xmlns:xfa=\"http://www.xfa.org/schema/xfa-data/1.0/\">\n"),
              "          <p dir=\"ltr\">P&amp;1 <span style=\"text-"),
              "decoration:word;font-family:Helvetica\">P&amp;2</span> "), "P&amp;3</p>\n"),
              "        </body>"),
              global::DripSharp.Runtime.JavaCompat.StringTrim(annotationFreeText.GetRichContents()),
              null);
          }
        }
      }
      global::DripSharp.Testing.JavaAssertions.True(testedPDFBox4345andPDFBox3646, null);
    }
  }

  internal virtual void testAnnotationWidth() {
    string xfdf
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\"?>",
      "<xfdf xmlns=\"http://ns.adobe.com/xfdf/\" xml:space=\"preserve\">"), "<annots>"),
      "<freetext"), " width=\"0.00\""), " justification=\"left\" page=\"0\""),
      " date=\"D:20251124141013+01'00'\""), " flags=\"print\""),
      " name=\"b525be7e-4735-4598-ab7f-163cd0c7e48b\""),
      " rect=\"372.339325,722.633545,531.075317,736.673523\""), " title=\"Username\""),
      " BBox=\"372.339325,722.633545,531.075317,736.673523\""),
      " Matrix=\"1.000000,0.000000,0.000000,1.000000,0.000000,0.000000\""),
      " creationdate=\"D:20251124141003+01'00'\""), " opacity=\"1\""), " subject=\"Texteingabe\""),
      " intent=\"FreeTextTypewriter\""), " IT=\"FreeTextTypewriter\">"),
      "<defaultappearance>&#x20;/Helv 12 Tf 0.415686 0.756863 0.690196 rg</defaultappearance>"),
      "<defaultstyle>font: &apos;Helvetica&apos; ,sans-serif 12.00pt;color:#3049D1</defaultstyle>"),
      "<contents>Your text is here.</contents>"), "</freetext>"), "</annots>"),
      "<f href=\".xfdf\"/>"), "</xfdf>");
    global::System.IO.MemoryStream inputStream
      = global::DripSharp.Runtime.JavaCompat.NewMemoryStream(global::DripSharp.Runtime.JavaCompat.StringGetBytes(xfdf,
      global::DripSharp.Runtime.JavaStandardCharsets.UTF8));
    using (global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFDocument fdfDoc
      = global::DripSharp.PdfCarton.Loader.LoadXFDF(inputStream)) {
      global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFAnnotation> fdfAnnots
        = fdfDoc.GetCatalog().GetFDF().GetAnnotations();
      global::DripSharp.Testing.JavaAssertions.Equal(1,
        global::DripSharp.Runtime.JavaCompat.CollectionCount(fdfAnnots), null);
      global::DripSharp.PdfCarton.Pdmodel.Fdf.FDFAnnotation annot
        = global::DripSharp.Runtime.JavaCompat.ListGet(fdfAnnots, 0);
      global::DripSharp.Testing.JavaAssertions.NotNull(annot.GetBorderStyle(), null);
      global::DripSharp.Testing.JavaAssertions.Equal(0.0F, annot.GetBorderStyle().GetWidth(), null,
        0.01F);
    }
  }

  [Xunit.Fact]
  public void __Upstream_1912852334_af5c576ef15bfda8() {
    try {
      this.loadXFDFAnnotations();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3822482661_667f072da25ea682() {
    try {
      this.testAnnotationWidth();
    } finally {
    }
  }
}
