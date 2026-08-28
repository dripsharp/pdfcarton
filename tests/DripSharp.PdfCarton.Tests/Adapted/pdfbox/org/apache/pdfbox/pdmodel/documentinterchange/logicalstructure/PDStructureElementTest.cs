// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure;

public class PDStructureElementTest {
  private static readonly global::System.IO.FileInfo TARGETPDFDIR
    = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
    "target/pdfs"));

  internal virtual void testPDFBox4197() {
    global::System.Collections.Generic.ISet<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.Revisions<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDAttributeObject>> attributeSet
      = new global::System.Collections.Generic.HashSet<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.Revisions<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDAttributeObject>>();
    global::System.Collections.Generic.ISet<string> classSet
      = new global::System.Collections.Generic.HashSet<string>();
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(new global::System.IO.FileInfo(global::System.IO.Path.Combine((global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElementTest.TARGETPDFDIR).FullName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-4197.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot
        = doc.GetDocumentCatalog().GetStructureTreeRoot();
      this.checkElement(structureTreeRoot.GetK(), attributeSet, structureTreeRoot.GetClassMap(),
        classSet);
    }
    global::DripSharp.Testing.JavaAssertions.Equal(117, attributeSet.Count, null);
    int cnt
      = global::DripSharp.Runtime.JavaCompat.UnboxObject<int>(global::System.Linq.Enumerable.Aggregate(global::DripSharp.Runtime.JavaCompat.Map(global::DripSharp.Runtime.JavaCompat.Stream(attributeSet),
      (value0) => value0.Size()), 0, global::DripSharp.Runtime.JavaCompat.SumInt));
    global::DripSharp.Testing.JavaAssertions.Equal(111, cnt, null);
    global::DripSharp.Testing.JavaAssertions.Equal(0, classSet.Count, null);
  }

  internal virtual void testClassMap() {
    global::System.Collections.Generic.ISet<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.Revisions<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDAttributeObject>> attributeSet
      = new global::System.Collections.Generic.HashSet<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.Revisions<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDAttributeObject>>();
    global::System.Collections.Generic.ISet<string> classSet
      = new global::System.Collections.Generic.HashSet<string>();
    using (global::DripSharp.PdfCarton.Pdmodel.PDDocument doc
      = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer.CreateBufferFromStream(global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElementTest),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDFBOX-2725-878725.pdf"))))) {
      global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureTreeRoot structureTreeRoot
        = doc.GetDocumentCatalog().GetStructureTreeRoot();
      this.checkElement(structureTreeRoot.GetK(), attributeSet, structureTreeRoot.GetClassMap(),
        classSet);
    }
    foreach (global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.Revisions<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDAttributeObject> r in attributeSet) {
      if ((r.Size() >= 2)) {
        global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Taggedpdf.PDTableAttributeObject obj0
          = (global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Taggedpdf.PDTableAttributeObject)(r.GetObject(0)!);
        global::DripSharp.Testing.JavaAssertions.Equal("Table", obj0.GetOwner(), null);
        global::DripSharp.Testing.JavaAssertions.Equal(2, obj0.GetColSpan(), null);
        global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Taggedpdf.PDLayoutAttributeObject obj1
          = (global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Taggedpdf.PDLayoutAttributeObject)(r.GetObject(1)!);
        global::DripSharp.Testing.JavaAssertions.Equal("Layout", obj1.GetOwner(), null);
        global::DripSharp.Testing.JavaAssertions.True(((global::DripSharp.Runtime.JavaCompat.UnboxObject<float>((float?)(obj1.GetWidth()))
          == 166.375F)
          || (global::DripSharp.Runtime.JavaCompat.UnboxObject<float>((float?)(obj1.GetWidth()))
          == 246.75F)), null);
        global::DripSharp.Testing.JavaAssertions.True(((global::DripSharp.Runtime.JavaCompat.UnboxObject<float>((float?)(obj1.GetHeight()))
          == 14.0F)
          || (global::DripSharp.Runtime.JavaCompat.UnboxObject<float>((float?)(obj1.GetHeight()))
          == 17.0F)), null);
        global::DripSharp.Testing.JavaAssertions.Equal("Start", obj1.GetInlineAlign(), null);
        global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.Runtime.JavaCompat.Equals("After",
          obj1.GetBlockAlign()) || global::DripSharp.Runtime.JavaCompat.Equals("Before",
          obj1.GetBlockAlign())), null);
        global::DripSharp.Testing.JavaAssertions.Equal(0, r.GetRevisionNumber(0), null);
        global::DripSharp.Testing.JavaAssertions.Equal(0, r.GetRevisionNumber(1), null);
      }
    }
    global::DripSharp.Testing.JavaAssertions.Equal(72, attributeSet.Count, null);
    int cnt
      = global::DripSharp.Runtime.JavaCompat.UnboxObject<int>(global::System.Linq.Enumerable.Aggregate(global::DripSharp.Runtime.JavaCompat.Map(global::DripSharp.Runtime.JavaCompat.Stream(attributeSet),
      (value0) => value0.Size()), 0, global::DripSharp.Runtime.JavaCompat.SumInt));
    global::DripSharp.Testing.JavaAssertions.Equal(45, cnt, null);
    global::DripSharp.Testing.JavaAssertions.Equal(10, classSet.Count, null);
  }

  private void checkElement(global::DripSharp.PdfCarton.Cos.COSBase @base,
    global::System.Collections.Generic.ISet<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.Revisions<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDAttributeObject>> attributeSet,
    global::System.Collections.Generic.IDictionary<string, object> classMap,
    global::System.Collections.Generic.ISet<string> classSet) {
    if ((@base is global::DripSharp.PdfCarton.Cos.COSArray)) {
      foreach (global::DripSharp.PdfCarton.Cos.COSBase __foreachValue_base2 in (global::DripSharp.PdfCarton.Cos.COSArray)(@base!)) {
        global::DripSharp.PdfCarton.Cos.COSBase base2 = __foreachValue_base2; {
          if ((base2 is global::DripSharp.PdfCarton.Cos.COSObject)) {
            base2 = ((global::DripSharp.PdfCarton.Cos.COSObject)(base2!)).GetObject();
          }
          this.checkElement(base2, attributeSet, classMap, classSet);
        }
      }
    } else {
      if ((@base is global::DripSharp.PdfCarton.Cos.COSDictionary)) {
        global::DripSharp.PdfCarton.Cos.COSDictionary kdict
          = (global::DripSharp.PdfCarton.Cos.COSDictionary)(@base!);
        if (kdict.ContainsKey(global::DripSharp.PdfCarton.Cos.COSName.Pg)) {
          global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement structureElement
            = new global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement(kdict);
          global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.Revisions<global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDAttributeObject> attributes
            = structureElement.GetAttributes();
          attributeSet.Add(attributes);
          global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.Revisions<string> classNames
            = structureElement.GetClassNames();
          if ((kdict.ContainsKey(global::DripSharp.PdfCarton.Cos.COSName.C)
            && !(kdict.ContainsKey(global::DripSharp.PdfCarton.Cos.COSName.A)))) {
            for (int i = 0; (i < classNames.Size()); ++i) {
              string className = classNames.GetObject(i);
              classSet.Add(className);
              global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.MapContainsKey(classMap,
                className), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
                global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("'",
                className), "' not in ClassMap "), classMap)));
            }
          }
        }
        if (kdict.ContainsKey(global::DripSharp.PdfCarton.Cos.COSName.K)) {
          this.checkElement(kdict.GetDictionaryObject(global::DripSharp.PdfCarton.Cos.COSName.K),
            attributeSet, classMap, classSet);
        }
      }
    }
  }

  internal virtual void testSimple() {
    global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement structureElement
      = new global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "S"),
      (global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureNode)default!);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDStructureElement.Type,
      structureElement.GetType(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("S", structureElement.GetStructureType(), null);
    global::DripSharp.Testing.JavaAssertions.Null(structureElement.GetParent(), null);
    structureElement.SetStructureType(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "T"));
    global::DripSharp.Testing.JavaAssertions.Equal("T", structureElement.GetStructureType(), null);
    structureElement.SetElementIdentifier(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Ident"));
    global::DripSharp.Testing.JavaAssertions.Equal("Ident", structureElement.GetElementIdentifier(),
      null);
    structureElement.SetRevisionNumber(33);
    global::DripSharp.Testing.JavaAssertions.Equal(33, structureElement.GetRevisionNumber(), null);
    structureElement.IncrementRevisionNumber();
    global::DripSharp.Testing.JavaAssertions.Equal(34, structureElement.GetRevisionNumber(), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(()
      => structureElement.SetRevisionNumber(-1), null);
    structureElement.SetTitle(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Title"));
    global::DripSharp.Testing.JavaAssertions.Equal("Title", structureElement.GetTitle(), null);
    structureElement.SetLanguage(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Klingon"));
    global::DripSharp.Testing.JavaAssertions.Equal("Klingon", structureElement.GetLanguage(), null);
    structureElement.SetAlternateDescription(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Alto"));
    global::DripSharp.Testing.JavaAssertions.Equal("Alto",
      structureElement.GetAlternateDescription(), null);
    structureElement.SetActualText(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Actual"));
    global::DripSharp.Testing.JavaAssertions.Equal("Actual", structureElement.GetActualText(),
      null);
    structureElement.SetExpandedForm(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "ExpF"));
    global::DripSharp.Testing.JavaAssertions.Equal("ExpF", structureElement.GetExpandedForm(),
      null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(()
      => structureElement.AppendKid(-1), null);
    structureElement.AppendKid(0);
    global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDMarkedContentReference mcr1
      = new global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDMarkedContentReference();
    mcr1.SetMCID(1);
    structureElement.AppendKid(mcr1);
    global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDMarkedContentReference mcr2
      = new global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDMarkedContentReference();
    mcr2.SetMCID(2);
    global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Markedcontent.PDMarkedContent mc2
      = global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Markedcontent.PDMarkedContent.Create(global::DripSharp.PdfCarton.Cos.COSName.S,
      mcr2.GetCOSObject());
    structureElement.AppendKid(mc2);
    global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDMarkedContentReference mcrSubZero
      = new global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDMarkedContentReference();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(()
      => mcrSubZero.SetMCID(-1), null);
    mcrSubZero.GetCOSObject().SetInt(global::DripSharp.PdfCarton.Cos.COSName.Mcid, -1);
    global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Markedcontent.PDMarkedContent mcSubZero
      = global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Markedcontent.PDMarkedContent.Create(global::DripSharp.PdfCarton.Cos.COSName.S,
      mcrSubZero.GetCOSObject());
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(()
      => structureElement.AppendKid(mcSubZero), null);
    global::System.Collections.Generic.IList<object> kids = structureElement.GetKids();
    global::DripSharp.Testing.JavaAssertions.Equal(3,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(kids), null);
    global::DripSharp.Testing.JavaAssertions.Equal(0,
      global::DripSharp.Runtime.JavaCompat.ListGet(kids, 0), null);
    mcr1
      = (global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDMarkedContentReference)(global::DripSharp.Runtime.JavaCompat.ListGet(kids,
      1)!);
    global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Documentinterchange.Logicalstructure.PDMarkedContentReference.Type,
      mcr1.GetCOSObject().GetNameAsString(global::DripSharp.PdfCarton.Cos.COSName.Type), null);
    global::DripSharp.Testing.JavaAssertions.Equal(1, mcr1.GetMCID(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.ListGet(kids, 2), null);
  }

  [Xunit.Fact]
  public void __Upstream_3554240374_22f98ff64d8f6664() {
    try {
      this.testClassMap();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1724574598_d58589e1cb65d3dd() {
    try {
      this.testPDFBox4197();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3864931556_0f9f217cdc6a970f() {
    try {
      this.testSimple();
    } finally {
    }
  }
}
