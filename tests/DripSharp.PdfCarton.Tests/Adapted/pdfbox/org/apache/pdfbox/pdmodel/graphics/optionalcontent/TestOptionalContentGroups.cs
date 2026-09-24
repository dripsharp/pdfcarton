// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent;

public class TestOptionalContentGroups {
  private static readonly global::DripSharp.Runtime.JavaFile testResultsDir;

  internal static void setUp() {
    global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.TestOptionalContentGroups.testResultsDir);
  }

  internal virtual void testOCGGeneration() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_81_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
        doc.AddPage(page);
        global::DripSharp.PdfCarton.Pdmodel.PDResources resources = page.GetResources();
        if ((resources == default!)) {
          resources = new global::DripSharp.PdfCarton.Pdmodel.PDResources();
          page.SetResources(resources);
        }
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentProperties ocprops
          = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentProperties();
        doc.GetDocumentCatalog().SetOCProperties(ocprops);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup background
          = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "background"));
        ocprops.AddGroup(background);
        global::DripSharp.Testing.JavaAssertions.True(ocprops.IsGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "background")), null);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup enabled
          = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "enabled"));
        ocprops.AddGroup(enabled);
        global::DripSharp.Testing.JavaAssertions.False(ocprops.SetGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "enabled"), true), null);
        global::DripSharp.Testing.JavaAssertions.True(ocprops.IsGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "enabled")), null);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup disabled
          = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "disabled"));
        ocprops.AddGroup(disabled);
        global::DripSharp.Testing.JavaAssertions.False(ocprops.SetGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "disabled"), true), null);
        global::DripSharp.Testing.JavaAssertions.True(ocprops.IsGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "disabled")), null);
        global::DripSharp.Testing.JavaAssertions.True(ocprops.SetGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "disabled"), false), null);
        global::DripSharp.Testing.JavaAssertions.False(ocprops.IsGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "disabled")), null); {
          global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page,
            global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Overwrite, false);
          global::System.Exception __dripsharpPrimary_118_38_0 = null!;
          try {
            global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font
              = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.HelveticaBold);
            contentStream.BeginMarkedContent(global::DripSharp.PdfCarton.Cos.COSName.Oc,
              background);
            contentStream.BeginText();
            contentStream.SetFont(font, (float)(14));
            contentStream.NewLineAtOffset((float)(80), (float)(700));
            contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "PDF 1.5: Optional Content Groups"));
            contentStream.EndText();
            font
              = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica);
            contentStream.BeginText();
            contentStream.SetFont(font, (float)(12));
            contentStream.NewLineAtOffset((float)(80), (float)(680));
            contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "You should see a green textline, but no red text line."));
            contentStream.EndText();
            contentStream.EndMarkedContent();
            contentStream.BeginMarkedContent(global::DripSharp.PdfCarton.Cos.COSName.Oc, enabled);
            contentStream.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Green);
            contentStream.BeginText();
            contentStream.SetFont(font, (float)(12));
            contentStream.NewLineAtOffset((float)(80), (float)(600));
            contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "This is from an enabled layer. If you see this, that's good."));
            contentStream.EndText();
            contentStream.EndMarkedContent();
            contentStream.BeginMarkedContent(global::DripSharp.PdfCarton.Cos.COSName.Oc, disabled);
            contentStream.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Red);
            contentStream.BeginText();
            contentStream.SetFont(font, (float)(12));
            contentStream.NewLineAtOffset((float)(80), (float)(500));
            contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "This is from a disabled layer. If you see this, that's NOT good!"));
            contentStream.EndText();
            contentStream.EndMarkedContent();
          } catch (global::System.Exception __dripsharpCaught_118_38_0) {
            __dripsharpPrimary_118_38_0 = __dripsharpCaught_118_38_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(contentStream,
              __dripsharpPrimary_118_38_0);
          }
        }
        global::DripSharp.Runtime.JavaFile targetFile
          = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.TestOptionalContentGroups.testResultsDir,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ocg-generation.pdf"));
        doc.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(targetFile)));
      } catch (global::System.Exception __dripsharpCaught_81_25_0) {
        __dripsharpPrimary_81_25_0 = __dripsharpCaught_81_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_81_25_0);
      }
    }
  }

  internal virtual void testOCGConsumption() {
    global::DripSharp.Runtime.JavaFile pdfFile
      = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.TestOptionalContentGroups.testResultsDir,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "ocg-generation.pdf"));
    if (!global::System.IO.File.Exists(pdfFile.FullName)) {
      this.testOCGGeneration();
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)pdfFile });
      global::System.Exception __dripsharpPrimary_176_25_0 = null!;
      try {
        global::DripSharp.Testing.JavaAssertions.Equal(1.6F, doc.GetVersion(), null);
        global::DripSharp.PdfCarton.Pdmodel.PDDocumentCatalog catalog = doc.GetDocumentCatalog();
        global::DripSharp.PdfCarton.Pdmodel.PDPage page = doc.GetPage(0);
        global::DripSharp.PdfCarton.Pdmodel.PDResources resources = page.GetResources();
        global::DripSharp.PdfCarton.Cos.COSName mc0
          = global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "oc1"));
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup ocg
          = (global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup)(resources.GetProperties(mc0)!);
        global::DripSharp.Testing.JavaAssertions.NotNull(ocg, null);
        global::DripSharp.Testing.JavaAssertions.Equal("background", ocg.GetName(), null);
        global::DripSharp.Testing.JavaAssertions.Null(resources.GetProperties(global::DripSharp.PdfCarton.Cos.COSName.GetPDFName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "inexistent"))), null);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentProperties ocgs
          = catalog.GetOCProperties();
        global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentProperties.BaseState.On,
          ocgs.GetBaseState(), null);
        global::System.Collections.Generic.ISet<string> names
          = new global::System.Collections.Generic.HashSet<string>(global::DripSharp.Runtime.JavaCompat.AsList<string>(ocgs.GetGroupNames()));
        global::DripSharp.Testing.JavaAssertions.Equal(3, names.Count, null);
        global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(names,
          "background"), null);
        global::DripSharp.Testing.JavaAssertions.True(ocgs.IsGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "background")), null);
        global::DripSharp.Testing.JavaAssertions.True(ocgs.IsGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "enabled")), null);
        global::DripSharp.Testing.JavaAssertions.False(ocgs.IsGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "disabled")), null);
        ocgs.SetGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "background"), false);
        global::DripSharp.Testing.JavaAssertions.False(ocgs.IsGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "background")), null);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup background
          = ocgs.GetGroup(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "background"));
        global::DripSharp.Testing.JavaAssertions.Equal(ocg.GetName(), background.GetName(), null);
        global::DripSharp.Testing.JavaAssertions.Null(ocgs.GetGroup(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "inexistent")), null);
        global::System.Collections.Generic.ICollection<global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup> coll
          = ocgs.GetOptionalContentGroups();
        global::DripSharp.Testing.JavaAssertions.Equal(3,
          global::DripSharp.Runtime.JavaCompat.CollectionCount(coll), null);
        global::System.Collections.Generic.HashSet<string> nameSet
          = global::DripSharp.Runtime.JavaCompat.SetOfValues<string>(global::DripSharp.Runtime.JavaCompat.Map(global::DripSharp.Runtime.JavaCompat.Stream(coll),
          (value0) => value0.GetName()));
        global::DripSharp.Testing.JavaAssertions.True(nameSet.Contains("background"), null);
        global::DripSharp.Testing.JavaAssertions.True(nameSet.Contains("enabled"), null);
        global::DripSharp.Testing.JavaAssertions.True(nameSet.Contains("disabled"), null);
        global::DripSharp.PdfCarton.Text.PDFMarkedContentExtractor extractor
          = new global::DripSharp.PdfCarton.Text.PDFMarkedContentExtractor();
        extractor.ProcessPage(page);
        global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Markedcontent.PDMarkedContent> markedContents
          = extractor.GetMarkedContents();
        global::DripSharp.Testing.JavaAssertions.Equal("OC",
          global::DripSharp.Runtime.JavaCompat.ListGet(markedContents, 0).GetTag(), null);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup ocg1
          = (global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup)(global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Markedcontent.PDPropertyList.Create(global::DripSharp.Runtime.JavaCompat.ListGet(markedContents,
          0).GetProperties())!);
        global::DripSharp.Testing.JavaAssertions.Equal("background", ocg1.GetName(), null);
        global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat("PDF 1.5: Optional Content Groups",
          "You should see a green textline, but no red text line."),
          this.textPositionListToString(global::DripSharp.Runtime.JavaCompat.ListGet(markedContents,
          0).GetContents()), null);
        global::DripSharp.Testing.JavaAssertions.Equal("OC",
          global::DripSharp.Runtime.JavaCompat.ListGet(markedContents, 1).GetTag(), null);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup ocg2
          = (global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup)(global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Markedcontent.PDPropertyList.Create(global::DripSharp.Runtime.JavaCompat.ListGet(markedContents,
          1).GetProperties())!);
        global::DripSharp.Testing.JavaAssertions.Equal("enabled", ocg2.GetName(), null);
        global::DripSharp.Testing.JavaAssertions.Equal("This is from an enabled layer. If you see this, that's good.",
          this.textPositionListToString(global::DripSharp.Runtime.JavaCompat.ListGet(markedContents,
          1).GetContents()), null);
        global::DripSharp.Testing.JavaAssertions.Equal("OC",
          global::DripSharp.Runtime.JavaCompat.ListGet(markedContents, 2).GetTag(), null);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup ocg3
          = (global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup)(global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Markedcontent.PDPropertyList.Create(global::DripSharp.Runtime.JavaCompat.ListGet(markedContents,
          2).GetProperties())!);
        global::DripSharp.Testing.JavaAssertions.Equal("disabled", ocg3.GetName(), null);
        global::DripSharp.Testing.JavaAssertions.Equal("This is from a disabled layer. If you see this, that's NOT good!",
          this.textPositionListToString(global::DripSharp.Runtime.JavaCompat.ListGet(markedContents,
          2).GetContents()), null);
      } catch (global::System.Exception __dripsharpCaught_176_25_0) {
        __dripsharpPrimary_176_25_0 = __dripsharpCaught_176_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_176_25_0);
      }
    }
  }

  private string textPositionListToString(global::System.Collections.Generic.IList<object> contents) {
    global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();
    foreach (object o in contents) {
      global::DripSharp.PdfCarton.Text.TextPosition tp
        = (global::DripSharp.PdfCarton.Text.TextPosition)(o!);
      sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", tp.GetUnicode()));
    }
    return sb.ToString();
  }

  internal virtual void testOCGsWithSameNameCanHaveDifferentVisibility() { {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_261_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
        doc.AddPage(page);
        global::DripSharp.PdfCarton.Pdmodel.PDResources resources = page.GetResources();
        if ((resources == default!)) {
          resources = new global::DripSharp.PdfCarton.Pdmodel.PDResources();
          page.SetResources(resources);
        }
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentProperties ocprops
          = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentProperties();
        doc.GetDocumentCatalog().SetOCProperties(ocprops);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup visible
          = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "layer"));
        ocprops.AddGroup(visible);
        global::DripSharp.Testing.JavaAssertions.True(ocprops.IsGroupEnabled(visible), null);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup invisible
          = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "layer"));
        ocprops.AddGroup(invisible);
        global::DripSharp.Testing.JavaAssertions.False(ocprops.SetGroupEnabled(invisible, false),
          null);
        global::DripSharp.Testing.JavaAssertions.False(ocprops.IsGroupEnabled(invisible), null);
        global::DripSharp.Testing.JavaAssertions.True(ocprops.IsGroupEnabled(visible), null); {
          global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc, page,
            global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Overwrite, false);
          global::System.Exception __dripsharpPrimary_293_38_0 = null!;
          try {
            global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font
              = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.HelveticaBold);
            contentStream.BeginMarkedContent(global::DripSharp.PdfCarton.Cos.COSName.Oc, visible);
            contentStream.BeginText();
            contentStream.SetFont(font, (float)(14));
            contentStream.NewLineAtOffset((float)(80), (float)(700));
            contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "PDF 1.5: Optional Content Groups"));
            contentStream.EndText();
            font
              = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica);
            contentStream.BeginText();
            contentStream.SetFont(font, (float)(12));
            contentStream.NewLineAtOffset((float)(80), (float)(680));
            contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "You should see this text, but no red text line."));
            contentStream.EndText();
            contentStream.EndMarkedContent();
            contentStream.BeginMarkedContent(global::DripSharp.PdfCarton.Cos.COSName.Oc, invisible);
            contentStream.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Red);
            contentStream.BeginText();
            contentStream.SetFont(font, (float)(12));
            contentStream.NewLineAtOffset((float)(80), (float)(500));
            contentStream.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "This is from a disabled layer. If you see this, that's NOT good!"));
            contentStream.EndText();
            contentStream.EndMarkedContent();
          } catch (global::System.Exception __dripsharpCaught_293_38_0) {
            __dripsharpPrimary_293_38_0 = __dripsharpCaught_293_38_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(contentStream,
              __dripsharpPrimary_293_38_0);
          }
        }
        global::DripSharp.Runtime.JavaFile targetFile
          = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.TestOptionalContentGroups.testResultsDir,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "ocg-generation-same-name.pdf"));
        doc.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(targetFile)));
      } catch (global::System.Exception __dripsharpCaught_261_25_0) {
        __dripsharpPrimary_261_25_0 = __dripsharpCaught_261_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc, __dripsharpPrimary_261_25_0);
      }
    }
  }

  internal virtual void testOCGGenerationSameNameCanHaveSameVisibilityOff() {
    global::SkiaSharp.SKBitmap expectedImage;
    global::SkiaSharp.SKBitmap actualImage; {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__339_25
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_339_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page__342_20
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
        doc__339_25.AddPage(page__342_20);
        global::DripSharp.PdfCarton.Pdmodel.PDResources resources__344_25
          = page__342_20.GetResources();
        if ((resources__344_25 == default!)) {
          resources__344_25 = new global::DripSharp.PdfCarton.Pdmodel.PDResources();
          page__342_20.SetResources(resources__344_25);
        }
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentProperties ocprops
          = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentProperties();
        doc__339_25.GetDocumentCatalog().SetOCProperties(ocprops);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup background
          = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "background"));
        ocprops.AddGroup(background);
        global::DripSharp.Testing.JavaAssertions.True(ocprops.IsGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "background")), null);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup enabled
          = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "science"));
        ocprops.AddGroup(enabled);
        global::DripSharp.Testing.JavaAssertions.False(ocprops.SetGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "science"), true), null);
        global::DripSharp.Testing.JavaAssertions.True(ocprops.IsGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "science")), null);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup disabled1
          = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "alternative"));
        ocprops.AddGroup(disabled1);
        global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup disabled2
          = new global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.PDOptionalContentGroup(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "alternative"));
        ocprops.AddGroup(disabled2);
        global::DripSharp.Testing.JavaAssertions.False(ocprops.SetGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "alternative"), false), null);
        global::DripSharp.Testing.JavaAssertions.False(ocprops.IsGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "alternative")), null); {
          global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream__379_38
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc__339_25, page__342_20,
            global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Overwrite, false);
          global::System.Exception __dripsharpPrimary_379_38_0 = null!;
          try {
            global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font__381_24
              = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.HelveticaBold);
            contentStream__379_38.BeginMarkedContent(global::DripSharp.PdfCarton.Cos.COSName.Oc,
              background);
            contentStream__379_38.BeginText();
            contentStream__379_38.SetFont(font__381_24, (float)(14));
            contentStream__379_38.NewLineAtOffset((float)(80), (float)(700));
            contentStream__379_38.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "PDF 1.5: Optional Content Groups"));
            contentStream__379_38.EndText();
            contentStream__379_38.EndMarkedContent();
            font__381_24
              = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica);
            contentStream__379_38.BeginMarkedContent(global::DripSharp.PdfCarton.Cos.COSName.Oc,
              enabled);
            contentStream__379_38.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Green);
            contentStream__379_38.BeginText();
            contentStream__379_38.SetFont(font__381_24, (float)(12));
            contentStream__379_38.NewLineAtOffset((float)(80), (float)(600));
            contentStream__379_38.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "The earth is a sphere"));
            contentStream__379_38.EndText();
            contentStream__379_38.EndMarkedContent();
            contentStream__379_38.BeginMarkedContent(global::DripSharp.PdfCarton.Cos.COSName.Oc,
              disabled1);
            contentStream__379_38.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Red);
            contentStream__379_38.BeginText();
            contentStream__379_38.SetFont(font__381_24, (float)(12));
            contentStream__379_38.NewLineAtOffset((float)(80), (float)(500));
            contentStream__379_38.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "Alternative 1: The earth is a flat circle"));
            contentStream__379_38.EndText();
            contentStream__379_38.EndMarkedContent();
            contentStream__379_38.BeginMarkedContent(global::DripSharp.PdfCarton.Cos.COSName.Oc,
              disabled2);
            contentStream__379_38.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Blue);
            contentStream__379_38.BeginText();
            contentStream__379_38.SetFont(font__381_24, (float)(12));
            contentStream__379_38.NewLineAtOffset((float)(80), (float)(450));
            contentStream__379_38.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "Alternative 2: The earth is a flat parallelogram"));
            contentStream__379_38.EndText();
            contentStream__379_38.EndMarkedContent();
          } catch (global::System.Exception __dripsharpCaught_379_38_0) {
            __dripsharpPrimary_379_38_0 = __dripsharpCaught_379_38_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(contentStream__379_38,
              __dripsharpPrimary_379_38_0);
          }
        }
        doc__339_25.GetDocumentCatalog().SetPageMode(global::DripSharp.PdfCarton.Pdmodel.PageMode.UseOptionalContent);
        global::DripSharp.Runtime.JavaFile targetFile
          = global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.TestOptionalContentGroups.testResultsDir,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "ocg-generation-same-name-off.pdf"));
        doc__339_25.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(targetFile)));
      } catch (global::System.Exception __dripsharpCaught_339_25_0) {
        __dripsharpPrimary_339_25_0 = __dripsharpCaught_339_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__339_25,
          __dripsharpPrimary_339_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__430_25
        = new global::DripSharp.PdfCarton.Pdmodel.PDDocument();
      global::System.Exception __dripsharpPrimary_430_25_0 = null!;
      try {
        global::DripSharp.PdfCarton.Pdmodel.PDPage page__432_20
          = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
        doc__430_25.AddPage(page__432_20);
        global::DripSharp.PdfCarton.Pdmodel.PDResources resources__434_25
          = page__432_20.GetResources();
        if ((resources__434_25 == default!)) {
          resources__434_25 = new global::DripSharp.PdfCarton.Pdmodel.PDResources();
          page__432_20.SetResources(resources__434_25);
        } {
          global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream contentStream__441_38
            = new global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream(doc__430_25, page__432_20,
            global::DripSharp.PdfCarton.Pdmodel.PDPageContentStream.AppendMode.Overwrite, false);
          global::System.Exception __dripsharpPrimary_441_38_0 = null!;
          try {
            global::DripSharp.PdfCarton.Pdmodel.Font.PDFont font__443_24
              = new global::DripSharp.PdfCarton.Pdmodel.Font.PDType1Font(global::DripSharp.PdfCarton.Pdmodel.Font.Standard14Fonts.FontName.Helvetica);
            contentStream__441_38.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Red);
            contentStream__441_38.BeginText();
            contentStream__441_38.SetFont(font__443_24, (float)(12));
            contentStream__441_38.NewLineAtOffset((float)(80), (float)(500));
            contentStream__441_38.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "Alternative 1: The earth is a flat circle"));
            contentStream__441_38.EndText();
            contentStream__441_38.SetNonStrokingColor((global::DripSharp.Runtime.JavaColor)global::SkiaSharp.SKColors.Blue);
            contentStream__441_38.BeginText();
            contentStream__441_38.SetFont(font__443_24, (float)(12));
            contentStream__441_38.NewLineAtOffset((float)(80), (float)(450));
            contentStream__441_38.ShowText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
              "Alternative 2: The earth is a flat parallelogram"));
            contentStream__441_38.EndText();
          } catch (global::System.Exception __dripsharpCaught_441_38_0) {
            __dripsharpPrimary_441_38_0 = __dripsharpCaught_441_38_0;
            throw;
          } finally {
            global::DripSharp.Runtime.JavaCompat.CloseResource(contentStream__441_38,
              __dripsharpPrimary_441_38_0);
          }
        }
        expectedImage
          = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(doc__430_25).RenderImage(0,
          (float)(2));
        global::DripSharp.PdfCarton.Tests.Support.WriteImage(expectedImage,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"),
          global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.TestOptionalContentGroups.testResultsDir,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "ocg-generation-same-name-off-expected.png")));
      } catch (global::System.Exception __dripsharpCaught_430_25_0) {
        __dripsharpPrimary_430_25_0 = __dripsharpCaught_430_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__430_25,
          __dripsharpPrimary_430_25_0);
      }
    } {
      global::DripSharp.PdfCarton.Pdmodel.PDDocument doc__465_25
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Pdmodel.PDDocument>(typeof(global::DripSharp.PdfCarton.Loader),
        "LoadPDF", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { (global::DripSharp.Runtime.JavaFile)global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.TestOptionalContentGroups.testResultsDir,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "ocg-generation-same-name-off.pdf")) });
      global::System.Exception __dripsharpPrimary_465_25_0 = null!;
      try {
        doc__465_25.GetDocumentCatalog().GetOCProperties().SetGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "background"), false);
        doc__465_25.GetDocumentCatalog().GetOCProperties().SetGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "science"), false);
        doc__465_25.GetDocumentCatalog().GetOCProperties().SetGroupEnabled(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "alternative"), true);
        actualImage
          = new global::DripSharp.PdfCarton.Rendering.PDFRenderer(doc__465_25).RenderImage(0,
          (float)(2));
        global::DripSharp.PdfCarton.Tests.Support.WriteImage(actualImage,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "png"),
          global::DripSharp.Runtime.JavaCompat.NewJavaFile(global::DripSharp.PdfCarton.Pdmodel.Graphics.Optionalcontent.TestOptionalContentGroups.testResultsDir,
          global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
          "ocg-generation-same-name-off-actual.png")));
      } catch (global::System.Exception __dripsharpCaught_465_25_0) {
        __dripsharpPrimary_465_25_0 = __dripsharpCaught_465_25_0;
        throw;
      } finally {
        global::DripSharp.Runtime.JavaCompat.CloseResource(doc__465_25,
          __dripsharpPrimary_465_25_0);
      }
    }
    global::DripSharp.Runtime.JavaDataBufferInt expectedData
      = (global::DripSharp.Runtime.JavaDataBufferInt)(global::DripSharp.Runtime.PdfCartonFontCompat.GetRaster(expectedImage).GetDataBuffer()!);
    global::DripSharp.Runtime.JavaDataBufferInt actualData
      = (global::DripSharp.Runtime.JavaDataBufferInt)(global::DripSharp.Runtime.PdfCartonFontCompat.GetRaster(actualImage).GetDataBuffer()!);
    global::DripSharp.Testing.JavaAssertions.Equal(expectedData.GetData(), actualData.GetData(),
      null);
  }

  [Xunit.Fact]
  public void __Upstream_3824042426_05ceb840624b8f57() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testOCGConsumption();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0872061721_1e0a7799788ee367() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testOCGGeneration();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2991684649_e8b7323ade9fb096() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testOCGGenerationSameNameCanHaveSameVisibilityOff();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3631810588_6ad26276726376ff() {
    if (!__UpstreamBeforeAll)
    throw new global::System.InvalidOperationException("Upstream @BeforeAll initialization failed.");
    try {
      this.testOCGsWithSameNameCanHaveDifferentVisibility();
    } finally {
    }
  }

  private static readonly bool __UpstreamBeforeAll;

  private static bool __RunUpstreamBeforeAll() {
    setUp();
    return true;
  }

  static TestOptionalContentGroups() {
    testResultsDir
      = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "target/test-output"));
    __UpstreamBeforeAll = __RunUpstreamBeforeAll();
  }
}
