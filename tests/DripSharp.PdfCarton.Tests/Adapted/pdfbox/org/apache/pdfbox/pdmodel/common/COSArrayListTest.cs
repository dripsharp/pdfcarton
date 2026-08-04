// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Common;

public class COSArrayListTest {
internal static global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> tbcAnnotationsList = null!;

internal static global::DripSharp.PdfCarton.Cos.COSBase[] tbcAnnotationsArray = null!;

internal static global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotationsList = null!;

internal static global::DripSharp.PdfCarton.Cos.COSArray annotationsArray = null!;

internal static global::DripSharp.PdfCarton.Pdmodel.PDPage pdPage = null!;

private static readonly global::System.IO.FileInfo OUT_DIR = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "target/test-output/pdmodel/common"));

internal virtual void setUp() {
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList = new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>();
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationHighlight txtMark = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationHighlight();
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink txtLink = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink();
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationCircle aCircle = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationCircle();
global::DripSharp.Runtime.JavaCompat.Add(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList, txtMark);
global::DripSharp.Runtime.JavaCompat.Add(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList, txtLink);
global::DripSharp.Runtime.JavaCompat.Add(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList, aCircle);
global::DripSharp.Runtime.JavaCompat.Add(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList, txtLink);
global::DripSharp.Testing.JavaAssertions.Equal(4, global::DripSharp.Runtime.JavaCompat.CollectionCount(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList), null);
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsList = new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>();
global::DripSharp.Runtime.JavaCompat.Add(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsList, txtMark);
global::DripSharp.Runtime.JavaCompat.Add(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsList, txtLink);
global::DripSharp.Runtime.JavaCompat.Add(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsList, aCircle);
global::DripSharp.Runtime.JavaCompat.Add(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsList, txtLink);
global::DripSharp.Testing.JavaAssertions.Equal(4, global::DripSharp.Runtime.JavaCompat.CollectionCount(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsList), null);
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray = new global::DripSharp.PdfCarton.Cos.COSArray();
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.Add(txtMark);
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.Add(txtLink);
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.Add(aCircle);
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.Add(txtLink);
global::DripSharp.Testing.JavaAssertions.Equal(4, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.Size(), null);
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsArray = new global::DripSharp.PdfCarton.Cos.COSBase[4];
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsArray[0] = txtMark.GetCOSObject();
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsArray[1] = txtLink.GetCOSObject();
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsArray[2] = aCircle.GetCOSObject();
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsArray[3] = txtLink.GetCOSObject();
global::DripSharp.Testing.JavaAssertions.Equal(4, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsArray.Length, null);
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.pdPage = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.pdPage.SetAnnotations(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList);
global::DripSharp.PdfCarton.Tests.Support.Mkdirs(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.OUT_DIR);
}

internal virtual void getFromList() {
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> cosArrayList = new global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray);
for (int i = 0; (i < cosArrayList.Size()); i++) {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation annot = cosArrayList.Get(i);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.Get(i), annot.GetCOSObject(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("PDAnnotations cosObject at ", i), " shall be equal to index "), i), " of COSArray")));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.ListGet(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsList, i), annot, global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("PDAnnotations at ", i), " shall be at index "), i), " of List")));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsArray[i], annot.GetCOSObject(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("PDAnnotations cosObject at ", i), " shall be at position "), i), " of Array")));
}
}

public virtual void AddToList() {
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> cosArrayList = new global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationSquare aSquare = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationSquare();
cosArrayList.Add(aSquare);
global::DripSharp.Testing.JavaAssertions.Equal(5, global::DripSharp.Runtime.JavaCompat.CollectionCount(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "List size shall be 5"));
global::DripSharp.Testing.JavaAssertions.Equal(5, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "COSArray size shall be 5"));
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation annot = global::DripSharp.Runtime.JavaCompat.ListGet(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList, 4);
global::DripSharp.Testing.JavaAssertions.Equal(4, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.IndexOf(annot.GetCOSObject()), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Added annotation shall be 4th entry in COSArray"));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray, cosArrayList.ToList(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Provided COSArray and underlying COSArray shall be equal"));
}

internal virtual void removeFromListByIndex() {
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> cosArrayList = new global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray);
int positionToRemove = 2;
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation toBeRemoved = cosArrayList.Get(positionToRemove);
global::DripSharp.Testing.JavaAssertions.Equal(toBeRemoved, cosArrayList.Remove(positionToRemove), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Remove operation shall return the removed object"));
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArrayList.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "List size shall be 3"));
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "COSArray size shall be 3"));
global::DripSharp.Testing.JavaAssertions.Equal(-1, cosArrayList.IndexOf(global::DripSharp.Runtime.JavaCompat.ListGet(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsList, positionToRemove)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDAnnotation shall no longer exist in List"));
global::DripSharp.Testing.JavaAssertions.Equal(-1, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.IndexOf(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsArray[positionToRemove]), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "COSObject shall no longer exist in COSArray"));
}

internal virtual void removeUniqueFromListByObject() {
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> cosArrayList = new global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray);
int positionToRemove = 2;
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation toBeRemoved = global::DripSharp.Runtime.JavaCompat.ListGet(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList, positionToRemove);
global::DripSharp.Testing.JavaAssertions.True(cosArrayList.Remove(toBeRemoved), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Remove operation shall return true"));
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArrayList.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "List size shall be 3"));
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "COSArray size shall be 3"));
global::DripSharp.Testing.JavaAssertions.Equal(cosArrayList.Get(2), global::DripSharp.Runtime.JavaCompat.ListGet(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsList, 3), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "List object at 3 is at position 2 in COSArrayList now"));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.Get(2), global::DripSharp.Runtime.JavaCompat.ListGet(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsList, 3).GetCOSObject(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "COSObject of List object at 3 is at position 2 in COSArray now"));
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.Get(2), global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsArray[3], global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Array object at 3 is at position 2 in underlying COSArray now"));
global::DripSharp.Testing.JavaAssertions.Equal(-1, cosArrayList.IndexOf(global::DripSharp.Runtime.JavaCompat.ListGet(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsList, positionToRemove)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "PDAnnotation shall no longer exist in List"));
global::DripSharp.Testing.JavaAssertions.Equal(-1, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.IndexOf(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsArray[positionToRemove]), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "COSObject shall no longer exist in COSArray"));
global::DripSharp.Testing.JavaAssertions.False(cosArrayList.Remove(toBeRemoved), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Remove shall not remove any object"));
}

internal virtual void removeAllUniqueFromListByObject() {
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> cosArrayList = new global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray);
int positionToRemove = 2;
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation toBeRemoved = global::DripSharp.Runtime.JavaCompat.ListGet(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList, positionToRemove);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> toBeRemovedInstances = global::DripSharp.Runtime.JavaCompat.ListOf<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>(toBeRemoved);
global::DripSharp.Testing.JavaAssertions.True(cosArrayList.RemoveAll(global::DripSharp.Runtime.JavaCompat.CastObjects(toBeRemovedInstances)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Remove operation shall return true"));
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArrayList.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "List size shall be 3"));
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "COSArray size shall be 3"));
global::DripSharp.Testing.JavaAssertions.False(cosArrayList.RemoveAll(global::DripSharp.Runtime.JavaCompat.CastObjects(toBeRemovedInstances)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Remove shall not remove any object"));
}

internal virtual void removeMultipleFromListByObject() {
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> cosArrayList = new global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray);
int positionToRemove = 1;
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation toBeRemoved = global::DripSharp.Runtime.JavaCompat.ListGet(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.tbcAnnotationsList, positionToRemove);
global::DripSharp.Testing.JavaAssertions.True(cosArrayList.Remove(toBeRemoved), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Remove operation shall return true"));
global::DripSharp.Testing.JavaAssertions.Equal(3, cosArrayList.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "List size shall be 3"));
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "COSArray size shall be 3"));
global::DripSharp.Testing.JavaAssertions.True(cosArrayList.Remove(toBeRemoved), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Remove operation shall return true"));
global::DripSharp.Testing.JavaAssertions.Equal(2, cosArrayList.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "List size shall be 2"));
global::DripSharp.Testing.JavaAssertions.Equal(2, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "COSArray size shall be 2"));
}

internal virtual void removeAllMultipleFromListByObject() {
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> cosArrayList = new global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray);
int positionToRemove = 1;
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation toBeRemoved = global::DripSharp.Runtime.JavaCompat.ListGet(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsList, positionToRemove);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> toBeRemovedInstances = global::DripSharp.Runtime.JavaCompat.ListOf<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>(toBeRemoved);
global::DripSharp.Testing.JavaAssertions.True(cosArrayList.RemoveAll(global::DripSharp.Runtime.JavaCompat.CastObjects(toBeRemovedInstances)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Remove operation shall return true"));
global::DripSharp.Testing.JavaAssertions.Equal(2, cosArrayList.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "List size shall be 2"));
global::DripSharp.Testing.JavaAssertions.Equal(2, global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.annotationsArray.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "COSArray size shall be 2"));
global::DripSharp.Testing.JavaAssertions.False(cosArrayList.RemoveAll(global::DripSharp.Runtime.JavaCompat.CastObjects(toBeRemovedInstances)), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "Remove shall not remove any object"));
}

internal virtual void removeFromFilteredListByIndex() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.AnnotationFilter annotsFilter = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.__AnnotationFilterFunctionalAdapter((annotation) => !((annotation is global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)));
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> cosArrayList = (global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>)(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.pdPage.GetAnnotations(annotsFilter)!);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(() => cosArrayList.Remove(1), null);
}

internal virtual void removeFromFilteredListByObject() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.AnnotationFilter annotsFilter = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.__AnnotationFilterFunctionalAdapter((annotation) => !((annotation is global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink)));
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> cosArrayList = (global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>)(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.pdPage.GetAnnotations(annotsFilter)!);
int positionToRemove = 1;
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation toBeRemoved = cosArrayList.Get(positionToRemove);
global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(() => cosArrayList.Remove(toBeRemoved), null);
}

internal virtual void removeSingleDirectObject() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument pdf__312_25 = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page__313_20 = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
pdf__312_25.AddPage(page__313_20);
global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> pageAnnots = new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>();
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationHighlight txtMark = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationHighlight();
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink txtLink = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink();
txtMark.GetCOSObject().GetCOSObject().SetDirect(true);
txtLink.GetCOSObject().GetCOSObject().SetDirect(true);
global::DripSharp.Runtime.JavaCompat.Add(pageAnnots, txtMark);
global::DripSharp.Runtime.JavaCompat.Add(pageAnnots, txtMark);
global::DripSharp.Runtime.JavaCompat.Add(pageAnnots, txtMark);
global::DripSharp.Runtime.JavaCompat.Add(pageAnnots, txtLink);
global::DripSharp.Testing.JavaAssertions.Equal(4, global::DripSharp.Runtime.JavaCompat.CollectionCount(pageAnnots), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 4 annotations generated"));
page__313_20.SetAnnotations(pageAnnots);
pdf__312_25.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.OUT_DIR, "/removeSingleDirectObjectTest.pdf")));
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument pdf__335_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.OUT_DIR, "/removeSingleDirectObjectTest.pdf"))))) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page__336_20 = pdf__335_25.GetPage(0);
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotations = (global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>)(page__336_20.GetAnnotations()!);
global::DripSharp.Testing.JavaAssertions.Equal(4, annotations.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 4 annotations retrieved"));
global::DripSharp.Testing.JavaAssertions.Equal(4, annotations.ToList().Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The size of the internal COSArray shall be 4"));
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation toBeRemoved = annotations.Get(0);
annotations.Remove(toBeRemoved);
global::DripSharp.Testing.JavaAssertions.Equal(3, annotations.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 3 annotations left"));
global::DripSharp.Testing.JavaAssertions.Equal(3, annotations.ToList().Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The size of the internal COSArray shall be 3"));
}
}

internal virtual void removeSingleIndirectObject() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument pdf__358_25 = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page__359_20 = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
pdf__358_25.AddPage(page__359_20);
global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> pageAnnots = new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>();
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationHighlight txtMark = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationHighlight();
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink txtLink = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink();
global::DripSharp.Runtime.JavaCompat.Add(pageAnnots, txtMark);
global::DripSharp.Runtime.JavaCompat.Add(pageAnnots, txtMark);
global::DripSharp.Runtime.JavaCompat.Add(pageAnnots, txtMark);
global::DripSharp.Runtime.JavaCompat.Add(pageAnnots, txtLink);
global::DripSharp.Testing.JavaAssertions.Equal(4, global::DripSharp.Runtime.JavaCompat.CollectionCount(pageAnnots), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 4 annotations generated"));
page__359_20.SetAnnotations(pageAnnots);
pdf__358_25.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.OUT_DIR, "/removeSingleIndirectObjectTest.pdf")));
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument pdf__377_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.OUT_DIR, "/removeSingleIndirectObjectTest.pdf"))))) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page__378_20 = pdf__377_25.GetPage(0);
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotations = (global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>)(page__378_20.GetAnnotations()!);
global::DripSharp.Testing.JavaAssertions.Equal(4, annotations.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 4 annotations retrieved"));
global::DripSharp.Testing.JavaAssertions.Equal(4, annotations.ToList().Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The size of the internal COSArray shall be 4"));
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation toBeRemoved = annotations.Get(0);
annotations.Remove(toBeRemoved);
global::DripSharp.Testing.JavaAssertions.Equal(3, annotations.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 3 annotations left"));
global::DripSharp.Testing.JavaAssertions.Equal(3, annotations.ToList().Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The size of the internal COSArray shall be 2"));
}
}

internal virtual void retainIndirectObject() {
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument pdf__401_25 = new global::DripSharp.PdfCarton.Pdmodel.PDDocument()) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page__402_20 = new global::DripSharp.PdfCarton.Pdmodel.PDPage();
pdf__401_25.AddPage(page__402_20);
global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> pageAnnots = new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>();
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationHighlight txtMark = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationHighlight();
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink txtLink = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationLink();
global::DripSharp.Runtime.JavaCompat.Add(pageAnnots, txtMark);
global::DripSharp.Runtime.JavaCompat.Add(pageAnnots, txtMark);
global::DripSharp.Runtime.JavaCompat.Add(pageAnnots, txtMark);
global::DripSharp.Runtime.JavaCompat.Add(pageAnnots, txtLink);
global::DripSharp.Testing.JavaAssertions.Equal(4, global::DripSharp.Runtime.JavaCompat.CollectionCount(pageAnnots), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 4 annotations generated"));
page__402_20.SetAnnotations(pageAnnots);
pdf__401_25.Save(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.OUT_DIR, "/removeIndirectObjectTest.pdf")));
}
using (global::DripSharp.PdfCarton.Pdmodel.PDDocument pdf__420_25 = global::DripSharp.PdfCarton.Loader.LoadPDF(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayListTest.OUT_DIR, "/removeIndirectObjectTest.pdf"))))) {
global::DripSharp.PdfCarton.Pdmodel.PDPage page__421_20 = pdf__420_25.GetPage(0);
global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> annotations = (global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>)(page__421_20.GetAnnotations()!);
global::DripSharp.Testing.JavaAssertions.Equal(4, annotations.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 4 annotations retrieved"));
global::DripSharp.Testing.JavaAssertions.Equal(4, annotations.ToList().Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The size of the internal COSArray shall be 4"));
global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation> toBeRetained = new global::System.Collections.Generic.List<global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotation>();
global::DripSharp.Runtime.JavaCompat.Add(toBeRetained, annotations.Get(0));
annotations.RetainAll(global::DripSharp.Runtime.JavaCompat.CastObjects(toBeRetained));
global::DripSharp.Testing.JavaAssertions.Equal(3, annotations.Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "There shall be 3 annotations left"));
global::DripSharp.Testing.JavaAssertions.Equal(3, annotations.ToList().Size(), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "The size of the internal COSArray shall be 3"));
}
}

[Xunit.Fact]
public void __Upstream_2980484318_1d329b89f2f5a069()
{
        this.setUp();
        try
        {
            this.getFromList();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1337664459_5bb2cab10225ca7e()
{
        this.setUp();
        try
        {
            this.removeAllMultipleFromListByObject();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3139873484_1084fe17d8a23dc1()
{
        this.setUp();
        try
        {
            this.removeAllUniqueFromListByObject();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2239071352_8e0dc3dd36efd070()
{
        this.setUp();
        try
        {
            this.removeFromFilteredListByIndex();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0852606041_eafdfd7e15bf26db()
{
        this.setUp();
        try
        {
            this.removeFromFilteredListByObject();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3651865871_a9abe432ac6885fd()
{
        this.setUp();
        try
        {
            this.removeFromListByIndex();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0796863698_2511815ca75c1f90()
{
        this.setUp();
        try
        {
            this.removeMultipleFromListByObject();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0033923220_afb617a86a125aa2()
{
        this.setUp();
        try
        {
            this.removeSingleDirectObject();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3635956537_fe7cc465edc7ba69()
{
        this.setUp();
        try
        {
            this.removeSingleIndirectObject();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0882330003_aa745c46e9ce9a08()
{
        this.setUp();
        try
        {
            this.removeUniqueFromListByObject();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2115724946_62ab30688cf33eb6()
{
        this.setUp();
        try
        {
            this.retainIndirectObject();
        }
        finally
        {
        }
}
}
