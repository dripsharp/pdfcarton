// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel;

public class TestPDPageAnnotationsFiltering {
private global::DripSharp.PdfCarton.Pdmodel.PDPage page = null!;

internal virtual void initMock() {
global::DripSharp.PdfCarton.Cos.COSDictionary mockedPageWithAnnotations = new global::DripSharp.PdfCarton.Cos.COSDictionary();
global::DripSharp.PdfCarton.Cos.COSArray annotsDictionary = new global::DripSharp.PdfCarton.Cos.COSArray();
annotsDictionary.Add(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationRubberStamp().GetCOSObject());
annotsDictionary.Add(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationSquare().GetCOSObject());
annotsDictionary.Add(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink().GetCOSObject());
mockedPageWithAnnotations.SetItem(global::DripSharp.PdfCarton.Cos.COSName.Annots, annotsDictionary);
this.page = new global::DripSharp.PdfCarton.Pdmodel.PDPage(mockedPageWithAnnotations);
}

internal virtual void validateNoFiltering() {
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotations = this.page.GetAnnotations();
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.Runtime.JavaCompat.CollectionCount(annotations), null);
global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 0) is global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationRubberStamp), null);
global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 1) is global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationSquare), null);
global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 2) is global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink), null);
}

internal virtual void validateAllFiltered() {
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotations = this.page.GetAnnotations(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.__AnnotationFilterFunctionalAdapter((annotation) => false));
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.Runtime.JavaCompat.CollectionCount(annotations), null);
}

internal virtual void validateSelectedFew() {
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotations = this.page.GetAnnotations(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.__AnnotationFilterFunctionalAdapter((annotation) => ((annotation is global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink) || (annotation is global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationSquare))));
global::DripSharp.Testing.JavaAssertions.Equal(2, global::DripSharp.Runtime.JavaCompat.CollectionCount(annotations), null);
global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 0) is global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationSquare), null);
global::DripSharp.Testing.JavaAssertions.True((global::DripSharp.Runtime.JavaCompat.ListGet(annotations, 1) is global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink), null);
}

[Xunit.Fact]
public void __Upstream_1649126370_33237c144795dc10()
{
        this.initMock();
        try
        {
            this.validateAllFiltered();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2884737459_c5968a98247348b3()
{
        this.initMock();
        try
        {
            this.validateNoFiltering();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2416933895_dedfece20e9a6320()
{
        this.initMock();
        try
        {
            this.validateSelectedFew();
        }
        finally
        {
        }
}
}
