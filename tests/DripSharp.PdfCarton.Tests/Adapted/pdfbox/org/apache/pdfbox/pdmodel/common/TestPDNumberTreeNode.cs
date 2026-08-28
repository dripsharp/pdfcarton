// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Common;

public class TestPDNumberTreeNode {
  private global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode node1 = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode node2 = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode node4 = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode node5 = null!;

  private global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode node24 = null!;

  public class PDTest : global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable {
    internal readonly int value = default;

    public PDTest(int value) {
      this.value = value;
    }

    public PDTest(global::DripSharp.PdfCarton.Cos.COSInteger cosInt) {
      this.value = cosInt.IntValue();
    }

    public virtual global::DripSharp.PdfCarton.Cos.COSInteger GetCOSObject() {
      return global::DripSharp.PdfCarton.Cos.COSInteger.Get((long)(this.value));
    }

    public override int GetHashCode() {
      int prime = 31;
      int result = 1;
      result = ((prime * result) + this.value);
      return result;
    }

    public override bool Equals(object obj) {
      if ((this == obj)) {
        return true;
      }
      if ((obj == default!)) {
        return false;
      }
      if ((((object)(this)).GetType() != ((object)(obj)).GetType())) {
        return false;
      }
      global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest other
        = (global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest)(obj!);
      return (this.value == other.value);
    }

    global::DripSharp.PdfCarton.Cos.COSBase global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable.GetCOSObject()
      => (global::DripSharp.PdfCarton.Cos.COSBase)(this.GetCOSObject());
  }

  internal virtual void setUp() {
    this.node5
      = new global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode(typeof(global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest));
    global::System.Collections.Generic.IDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest> Numbers
      = global::DripSharp.Runtime.JavaCompat.NewSortedDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest>();
    global::DripSharp.Runtime.JavaCompat.MapPut(Numbers, 1,
      new global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest(89));
    global::DripSharp.Runtime.JavaCompat.MapPut(Numbers, 2,
      new global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest(13));
    global::DripSharp.Runtime.JavaCompat.MapPut(Numbers, 3,
      new global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest(95));
    global::DripSharp.Runtime.JavaCompat.MapPut(Numbers, 4,
      new global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest(51));
    global::DripSharp.Runtime.JavaCompat.MapPut(Numbers, 5,
      new global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest(18));
    global::DripSharp.Runtime.JavaCompat.MapPut(Numbers, 6,
      new global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest(33));
    global::DripSharp.Runtime.JavaCompat.MapPut(Numbers, 7,
      new global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest(85));
    this.node5.SetNumbers(global::DripSharp.Runtime.JavaCompat.CastDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable>(Numbers));
    this.node24
      = new global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode(typeof(global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest));
    Numbers = global::DripSharp.Runtime.JavaCompat.NewSortedDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest>();
    global::DripSharp.Runtime.JavaCompat.MapPut(Numbers, 8,
      new global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest(54));
    global::DripSharp.Runtime.JavaCompat.MapPut(Numbers, 9,
      new global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest(70));
    global::DripSharp.Runtime.JavaCompat.MapPut(Numbers, 10,
      new global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest(39));
    global::DripSharp.Runtime.JavaCompat.MapPut(Numbers, 11,
      new global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest(30));
    global::DripSharp.Runtime.JavaCompat.MapPut(Numbers, 12,
      new global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest(40));
    this.node24.SetNumbers(global::DripSharp.Runtime.JavaCompat.CastDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable>(Numbers));
    this.node2
      = new global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode(typeof(global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest));
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode> kids
      = this.node2.GetKids();
    if ((kids == default!)) {
      kids
        = new global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode>();
    }
    global::DripSharp.Runtime.JavaCompat.Add(kids, this.node5);
    this.node2.SetKids(kids);
    this.node4
      = new global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode(typeof(global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest));
    kids = this.node4.GetKids();
    if ((kids == default!)) {
      kids
        = new global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode>();
    }
    global::DripSharp.Runtime.JavaCompat.Add(kids, this.node24);
    this.node4.SetKids(kids);
    this.node1
      = new global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode(typeof(global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest));
    kids = this.node1.GetKids();
    if ((kids == default!)) {
      kids
        = new global::DripSharp.PdfCarton.Pdmodel.Common.COSArrayList<global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode>();
    }
    global::DripSharp.Runtime.JavaCompat.Add(kids, this.node2);
    global::DripSharp.Runtime.JavaCompat.Add(kids, this.node4);
    this.node1.SetKids(kids);
  }

  internal virtual void testGetValue() {
    global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest(51),
      this.node5.GetValue(4), null);
    global::DripSharp.Testing.JavaAssertions.Equal(new global::DripSharp.PdfCarton.Pdmodel.Common.TestPDNumberTreeNode.PDTest(70),
      this.node1.GetValue(9), null);
    this.node1.SetKids((global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode>)default!);
    this.node1.SetNumbers(global::DripSharp.Runtime.JavaCompat.CastDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable>(default!));
    global::DripSharp.Testing.JavaAssertions.Null(this.node1.GetValue(0), null);
  }

  internal virtual void testUpperLimit() {
    global::DripSharp.Testing.JavaAssertions.Equal(7,
      (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(this.node5.GetUpperLimit()))), null);
    global::DripSharp.Testing.JavaAssertions.Equal(7,
      (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(this.node2.GetUpperLimit()))), null);
    global::DripSharp.Testing.JavaAssertions.Equal(12,
      (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(this.node24.GetUpperLimit()))), null);
    global::DripSharp.Testing.JavaAssertions.Equal(12,
      (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(this.node4.GetUpperLimit()))), null);
    global::DripSharp.Testing.JavaAssertions.Equal(12,
      (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(this.node1.GetUpperLimit()))), null);
    this.node24.SetNumbers(global::DripSharp.Runtime.JavaCompat.CastDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable>(global::DripSharp.Runtime.JavaCompat.NewJavaDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable>()));
    global::DripSharp.Testing.JavaAssertions.Null(this.node24.GetUpperLimit(), null);
    this.node5.SetNumbers(global::DripSharp.Runtime.JavaCompat.CastDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable>(default!));
    global::DripSharp.Testing.JavaAssertions.Null(this.node5.GetUpperLimit(), null);
    this.node1.SetKids((global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode>)default!);
    global::DripSharp.Testing.JavaAssertions.Null(this.node1.GetUpperLimit(), null);
  }

  internal virtual void testLowerLimit() {
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(this.node5.GetLowerLimit()))), null);
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(this.node2.GetLowerLimit()))), null);
    global::DripSharp.Testing.JavaAssertions.Equal(8,
      (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(this.node24.GetLowerLimit()))), null);
    global::DripSharp.Testing.JavaAssertions.Equal(8,
      (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(this.node4.GetLowerLimit()))), null);
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      (int)(global::DripSharp.Runtime.JavaCompat.Unbox((int)(this.node1.GetLowerLimit()))), null);
    this.node24.SetNumbers(global::DripSharp.Runtime.JavaCompat.CastDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable>(global::DripSharp.Runtime.JavaCompat.NewJavaDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable>()));
    global::DripSharp.Testing.JavaAssertions.Null(this.node24.GetLowerLimit(), null);
    this.node5.SetNumbers(global::DripSharp.Runtime.JavaCompat.CastDictionary<int,
      global::DripSharp.PdfCarton.Pdmodel.Common.COSObjectable>(default!));
    global::DripSharp.Testing.JavaAssertions.Null(this.node5.GetLowerLimit(), null);
    this.node1.SetKids((global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Pdmodel.Common.PDNumberTreeNode>)default!);
    global::DripSharp.Testing.JavaAssertions.Null(this.node1.GetLowerLimit(), null);
  }

  [Xunit.Fact]
  public void __Upstream_0534654573_cd50d5c4dc5d4bf7() {
    this.setUp();
    try {
      this.testGetValue();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2642606956_a58d9e5bdc4272cf() {
    this.setUp();
    try {
      this.testLowerLimit();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4046727787_727a88e050544ed2() {
    this.setUp();
    try {
      this.testUpperLimit();
    } finally {
    }
  }
}
