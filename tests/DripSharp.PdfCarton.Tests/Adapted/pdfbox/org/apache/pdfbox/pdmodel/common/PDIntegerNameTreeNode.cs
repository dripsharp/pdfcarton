// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Common;

public class PDIntegerNameTreeNode : global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Cos.COSInteger> {
public PDIntegerNameTreeNode() {}

public PDIntegerNameTreeNode(global::DripSharp.PdfCarton.Cos.COSDictionary dic) : base(dic) {

}

protected internal override global::DripSharp.PdfCarton.Cos.COSInteger ConvertCOSToPD(global::DripSharp.PdfCarton.Cos.COSBase @base) {
if (((@base != default!) && !((@base is global::DripSharp.PdfCarton.Cos.COSInteger)))) {
throw new global::System.IO.IOException(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", global::DripSharp.Runtime.JavaCompat.Concat("integer expected here, but got ", @base)));
}
return (global::DripSharp.PdfCarton.Cos.COSInteger)(@base!);
}

protected internal override global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Cos.COSInteger> CreateChildNode(global::DripSharp.PdfCarton.Cos.COSDictionary dic) {
return new global::DripSharp.PdfCarton.Pdmodel.Common.PDIntegerNameTreeNode(dic);
}
}
