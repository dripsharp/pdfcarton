// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Common;

public class TestPDNameTreeNode {
  private global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Cos.COSInteger> node1
    = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Cos.COSInteger> node2
    = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Cos.COSInteger> node4
    = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Cos.COSInteger> node5
    = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Cos.COSInteger> node24
    = null!;

  internal virtual void setUp() {
    this.node5 = new global::DripSharp.PdfCarton.Pdmodel.Common.PDIntegerNameTreeNode();
    global::System.Collections.Generic.IDictionary<string,
      global::DripSharp.PdfCarton.Cos.COSInteger> names
      = global::DripSharp.Runtime.JavaCompat.NewSortedDictionary<string,
      global::DripSharp.PdfCarton.Cos.COSInteger>();
    global::DripSharp.Runtime.JavaCompat.MapPut(names, "Actinium",
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(89)));
    global::DripSharp.Runtime.JavaCompat.MapPut(names, "Aluminum",
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(13)));
    global::DripSharp.Runtime.JavaCompat.MapPut(names, "Americium",
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(95)));
    global::DripSharp.Runtime.JavaCompat.MapPut(names, "Antimony",
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(51)));
    global::DripSharp.Runtime.JavaCompat.MapPut(names, "Argon",
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(18)));
    global::DripSharp.Runtime.JavaCompat.MapPut(names, "Arsenic",
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(33)));
    global::DripSharp.Runtime.JavaCompat.MapPut(names, "Astatine",
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(85)));
    this.node5.SetNames(names);
    this.node24 = new global::DripSharp.PdfCarton.Pdmodel.Common.PDIntegerNameTreeNode();
    names = global::DripSharp.Runtime.JavaCompat.NewSortedDictionary<string,
      global::DripSharp.PdfCarton.Cos.COSInteger>();
    global::DripSharp.Runtime.JavaCompat.MapPut(names, "Xenon",
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(54)));
    global::DripSharp.Runtime.JavaCompat.MapPut(names, "Ytterbium",
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(70)));
    global::DripSharp.Runtime.JavaCompat.MapPut(names, "Yttrium",
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(39)));
    global::DripSharp.Runtime.JavaCompat.MapPut(names, "Zinc",
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(30)));
    global::DripSharp.Runtime.JavaCompat.MapPut(names, "Zirconium",
      global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(40)));
    this.node24.SetNames(names);
    this.node2 = new global::DripSharp.PdfCarton.Pdmodel.Common.PDIntegerNameTreeNode();
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Cos.COSInteger>> kids
      = this.node2.GetKids();
    if ((kids == default!)) {
      kids
        = new global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Cos.COSInteger>>();
    }
    global::DripSharp.Runtime.JavaCompat.Add(kids, this.node5);
    this.node2.SetKids(kids);
    this.node4 = new global::DripSharp.PdfCarton.Pdmodel.Common.PDIntegerNameTreeNode();
    kids = this.node4.GetKids();
    if ((kids == default!)) {
      kids
        = new global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Cos.COSInteger>>();
    }
    global::DripSharp.Runtime.JavaCompat.Add(kids, this.node24);
    this.node4.SetKids(kids);
    this.node1 = new global::DripSharp.PdfCarton.Pdmodel.Common.PDIntegerNameTreeNode();
    kids = this.node1.GetKids();
    if ((kids == default!)) {
      kids
        = new global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Common.PDNameTreeNode<global::DripSharp.PdfCarton.Cos.COSInteger>>();
    }
    global::DripSharp.Runtime.JavaCompat.Add(kids, this.node2);
    global::DripSharp.Runtime.JavaCompat.Add(kids, this.node4);
    this.node1.SetKids(kids);
  }

  internal virtual void testUpperLimit() {
    global::DripSharp.Testing.JavaAssertions.Equal("Astatine", this.node5.GetUpperLimit(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Astatine", this.node2.GetUpperLimit(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Zirconium", this.node24.GetUpperLimit(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Zirconium", this.node4.GetUpperLimit(), null);
    global::DripSharp.Testing.JavaAssertions.Equal((object)default!, this.node1.GetUpperLimit(),
      null);
  }

  internal virtual void testLowerLimit() {
    global::DripSharp.Testing.JavaAssertions.Equal("Actinium", this.node5.GetLowerLimit(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Actinium", this.node2.GetLowerLimit(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Xenon", this.node24.GetLowerLimit(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("Xenon", this.node4.GetLowerLimit(), null);
    global::DripSharp.Testing.JavaAssertions.Equal((object)default!, this.node1.GetLowerLimit(),
      null);
  }

  [Xunit.Fact]
  public void __Upstream_2642606956_258420b60ecb9c3d() {
    this.setUp();
    try {
      this.testLowerLimit();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4046727787_1ec2cd4b630712f2() {
    this.setUp();
    try {
      this.testUpperLimit();
    } finally {
    }
  }
}
