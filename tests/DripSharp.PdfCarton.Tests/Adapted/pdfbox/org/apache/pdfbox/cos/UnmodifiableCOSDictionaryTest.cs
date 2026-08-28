// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Cos;

public class UnmodifiableCOSDictionaryTest {
  internal virtual void testUnmodifiableCOSDictionary() {
    global::DripSharp.PdfCarton.Cos.COSDictionary unmodifiableCOSDictionary
      = new global::DripSharp.PdfCarton.Cos.COSDictionary().AsUnmodifiableDictionary();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(unmodifiableCOSDictionary.Clear,
      null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.RemoveItem(global::DripSharp.PdfCarton.Cos.COSName.A), null);
    global::DripSharp.PdfCarton.Cos.COSDictionary cosDictionary
      = new global::DripSharp.PdfCarton.Cos.COSDictionary();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.AddAll(cosDictionary), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetFlag(global::DripSharp.PdfCarton.Cos.COSName.A, 0, true),
      null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => ((global::DripSharp.PdfCarton.Cos.COSUpdateInfo)(unmodifiableCOSDictionary)).SetNeedToBeUpdated(true),
      null);
  }

  internal virtual void testSetItem() {
    global::DripSharp.PdfCarton.Cos.COSDictionary unmodifiableCOSDictionary
      = new global::DripSharp.PdfCarton.Cos.COSDictionary().AsUnmodifiableDictionary();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetItem(global::DripSharp.PdfCarton.Cos.COSName.A,
      global::DripSharp.PdfCarton.Cos.COSName.A), null);
    global::DripSharp.PdfCarton.Pdmodel.Font.Encoding.Encoding standardEncoding
      = global::DripSharp.PdfCarton.Pdmodel.Font.Encoding.Encoding.GetInstance(global::DripSharp.PdfCarton.Cos.COSName.StandardEncoding);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetItem(global::DripSharp.PdfCarton.Cos.COSName.A,
      standardEncoding), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetItem(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "A"), global::DripSharp.PdfCarton.Cos.COSName.A), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetItem(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "A"), standardEncoding), null);
  }

  internal virtual void testSetBoolean() {
    global::DripSharp.PdfCarton.Cos.COSDictionary unmodifiableCOSDictionary
      = new global::DripSharp.PdfCarton.Cos.COSDictionary().AsUnmodifiableDictionary();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetBoolean(global::DripSharp.PdfCarton.Cos.COSName.A, true),
      null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetBoolean(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "A"), true), null);
  }

  internal virtual void testSetName() {
    global::DripSharp.PdfCarton.Cos.COSDictionary unmodifiableCOSDictionary
      = new global::DripSharp.PdfCarton.Cos.COSDictionary().AsUnmodifiableDictionary();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetName(global::DripSharp.PdfCarton.Cos.COSName.A,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "A")), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetName(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "A"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "A")), null);
  }

  internal virtual void testSetDate() {
    global::DripSharp.PdfCarton.Cos.COSDictionary unmodifiableCOSDictionary
      = new global::DripSharp.PdfCarton.Cos.COSDictionary().AsUnmodifiableDictionary();
    global::System.DateTimeOffset? calendar = global::System.DateTimeOffset.Now;
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetDate(global::DripSharp.PdfCarton.Cos.COSName.A, calendar),
      null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetDate(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "A"), calendar), null);
  }

  internal virtual void testSetEmbeddedDate() {
    global::DripSharp.PdfCarton.Cos.COSDictionary unmodifiableCOSDictionary
      = new global::DripSharp.PdfCarton.Cos.COSDictionary().AsUnmodifiableDictionary();
    global::System.DateTimeOffset? calendar = global::System.DateTimeOffset.Now;
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetEmbeddedDate(global::DripSharp.PdfCarton.Cos.COSName.Params,
      global::DripSharp.PdfCarton.Cos.COSName.A, calendar), null);
  }

  internal virtual void testSetString() {
    global::DripSharp.PdfCarton.Cos.COSDictionary unmodifiableCOSDictionary
      = new global::DripSharp.PdfCarton.Cos.COSDictionary().AsUnmodifiableDictionary();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetString(global::DripSharp.PdfCarton.Cos.COSName.A,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "A")), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetString(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "A"), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "A")), null);
  }

  internal virtual void testSetEmbeddedString() {
    global::DripSharp.PdfCarton.Cos.COSDictionary unmodifiableCOSDictionary
      = new global::DripSharp.PdfCarton.Cos.COSDictionary().AsUnmodifiableDictionary();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetEmbeddedString(global::DripSharp.PdfCarton.Cos.COSName.Params,
      global::DripSharp.PdfCarton.Cos.COSName.A,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox", "A")), null);
  }

  internal virtual void testSetInt() {
    global::DripSharp.PdfCarton.Cos.COSDictionary unmodifiableCOSDictionary
      = new global::DripSharp.PdfCarton.Cos.COSDictionary().AsUnmodifiableDictionary();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetInt(global::DripSharp.PdfCarton.Cos.COSName.A, 0), null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "A"), 0), null);
  }

  internal virtual void testSetEmbeddedInt() {
    global::DripSharp.PdfCarton.Cos.COSDictionary unmodifiableCOSDictionary
      = new global::DripSharp.PdfCarton.Cos.COSDictionary().AsUnmodifiableDictionary();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetEmbeddedInt(global::DripSharp.PdfCarton.Cos.COSName.Params,
      global::DripSharp.PdfCarton.Cos.COSName.A, 0), null);
  }

  internal virtual void testSetLong() {
    global::DripSharp.PdfCarton.Cos.COSDictionary unmodifiableCOSDictionary
      = new global::DripSharp.PdfCarton.Cos.COSDictionary().AsUnmodifiableDictionary();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetLong(global::DripSharp.PdfCarton.Cos.COSName.A, (long)(0)),
      null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetLong(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "A"), (long)(0)), null);
  }

  internal virtual void testSetFloat() {
    global::DripSharp.PdfCarton.Cos.COSDictionary unmodifiableCOSDictionary
      = new global::DripSharp.PdfCarton.Cos.COSDictionary().AsUnmodifiableDictionary();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetFloat(global::DripSharp.PdfCarton.Cos.COSName.A, (float)(0)),
      null);
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(()
      => unmodifiableCOSDictionary.SetFloat(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "A"), (float)(0)), null);
  }

  [Xunit.Fact]
  public void __Upstream_0176883608_e862db543f636ca0() {
    try {
      this.testSetBoolean();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3739388478_b688b3b08b8eddc2() {
    try {
      this.testSetDate();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1852519400_dab27b91e3fa617a() {
    try {
      this.testSetEmbeddedDate();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2137973877_cac8b26f93fa8876() {
    try {
      this.testSetEmbeddedInt();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2601614795_7216e7e68552457d() {
    try {
      this.testSetEmbeddedString();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4254063052_ee39f608d799b979() {
    try {
      this.testSetFloat();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3861408607_65fc66c5ada0a3c4() {
    try {
      this.testSetInt();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3739555235_cda42010b550955b() {
    try {
      this.testSetItem();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3739640076_7365be0117aeb8cc() {
    try {
      this.testSetLong();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3739686171_f784745f02296860() {
    try {
      this.testSetName();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3406599841_1f2a02dcb1231ace() {
    try {
      this.testSetString();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4197954478_95aac2f4fe04f641() {
    try {
      this.testUnmodifiableCOSDictionary();
    } finally {
    }
  }
}
