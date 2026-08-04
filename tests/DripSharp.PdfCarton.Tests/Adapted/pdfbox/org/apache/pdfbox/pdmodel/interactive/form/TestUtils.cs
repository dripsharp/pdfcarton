// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Form;

public class TestUtils {
public static global::System.Collections.Generic.IList<string> GetStringsFromStream(global::DripSharp.PdfCarton.Pdmodel.Interactive.Form.PDField field) {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Annotation.PDAnnotationWidget widget = global::DripSharp.Runtime.JavaCompat.ListGet(field.GetWidgets(), 0);
global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser parser = new global::DripSharp.PdfCarton.Pdfparser.PDFStreamParser(widget.GetNormalAppearanceStream());
global::System.Collections.Generic.IList<object> tokens = parser.Parse();
return global::DripSharp.Runtime.JavaCompat.ToListValues(global::DripSharp.Runtime.JavaCompat.Map(global::DripSharp.Runtime.JavaCompat.Map(global::DripSharp.Runtime.JavaCompat.Map(global::DripSharp.Runtime.JavaCompat.StreamFilter(global::DripSharp.Runtime.JavaCompat.Stream(tokens), (value0) => typeof(global::DripSharp.PdfCarton.Cos.COSString).IsInstanceOfType(value0)), (value0) => global::DripSharp.Runtime.JavaCompat.ClassCast<global::DripSharp.PdfCarton.Cos.COSString>(typeof(global::DripSharp.PdfCarton.Cos.COSString), value0)), (value0) => value0.GetString()), (value0) => global::DripSharp.Runtime.JavaCompat.StringTrim(value0)));
}
}
