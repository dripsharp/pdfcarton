// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Schema;

public class PhotoshopSchemaTest {
  private global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = null!;

  private global::System.Type schemaClass = null!;

  internal virtual void initMetadata() {
    this.metadata = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
    this.schemaClass = typeof(global::DripSharp.PdfCarton.Xmp.Schema.PhotoshopSchema);
  }

  internal virtual void testInitializedToNull(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester
      = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
    schemaTester.TestInitializedToNull();
  }

  internal virtual void testSettingValue(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester
      = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
    schemaTester.TestSettingValue();
  }

  internal virtual void testRandomSettingValue(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester
      = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
    schemaTester.TestRandomSettingValue();
  }

  internal virtual void testSettingValueInArray(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester
      = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
    schemaTester.TestSettingValueInArray();
  }

  internal virtual void testRandomSettingValueInArray(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester
      = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
    schemaTester.TestRandomSettingValueInArray();
  }

  internal virtual void testPropertySetterSimple(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester
      = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
    schemaTester.TestPropertySetterSimple();
  }

  internal virtual void testRandomPropertySetterSimple(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester
      = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
    schemaTester.TestRandomPropertySetterSimple();
  }

  internal virtual void testRandomSetterSimple(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester
      = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
    schemaTester.TestRandomSetterSimple();
  }

  internal virtual void testPropertySetterInArray(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester
      = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
    schemaTester.TestPropertySetterInArray();
  }

  internal virtual void testRandomPropertySetterInArray(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester schemaTester
      = new global::DripSharp.PdfCarton.Xmp.Schema.SchemaTester(this.metadata, this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fieldName), type, card);
    schemaTester.TestRandomPropertySetterInArray();
  }

  private static global::System.Collections.Generic.IEnumerable<object[]> initializeParameters() {
    return global::DripSharp.Runtime.JavaCompat.StreamOf(new object[] { "AncestorID",
        global::DripSharp.PdfCarton.Xmp.Type.Types.Uri,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "AuthorsPosition",
        global::DripSharp.PdfCarton.Xmp.Type.Types.Text,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "CaptionWriter",
        global::DripSharp.PdfCarton.Xmp.Type.Types.ProperName,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "Category",
        global::DripSharp.PdfCarton.Xmp.Type.Types.Text,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "City",
        global::DripSharp.PdfCarton.Xmp.Type.Types.Text,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "ColorMode",
        global::DripSharp.PdfCarton.Xmp.Type.Types.Integer,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "Country",
        global::DripSharp.PdfCarton.Xmp.Type.Types.Text,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "Credit",
        global::DripSharp.PdfCarton.Xmp.Type.Types.Text,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "DateCreated",
        global::DripSharp.PdfCarton.Xmp.Type.Types.Date,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "Headline",
        global::DripSharp.PdfCarton.Xmp.Type.Types.Text,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "History",
        global::DripSharp.PdfCarton.Xmp.Type.Types.Text,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "ICCProfile",
        global::DripSharp.PdfCarton.Xmp.Type.Types.Text,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "Instructions",
        global::DripSharp.PdfCarton.Xmp.Type.Types.Text,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "Source",
        global::DripSharp.PdfCarton.Xmp.Type.Types.Text,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "State",
        global::DripSharp.PdfCarton.Xmp.Type.Types.Text,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple },
      new object[] { "SupplementalCategories", global::DripSharp.PdfCarton.Xmp.Type.Types.Text,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple },
      new object[] { "TransmissionReference", global::DripSharp.PdfCarton.Xmp.Type.Types.Text,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple }, new object[] { "Urgency",
        global::DripSharp.PdfCarton.Xmp.Type.Types.Integer,
        global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple });
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_d2336221150c0906() {
    foreach (var value in initializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_970c926acb00b2a7() {
    foreach (var value in initializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_77dadfe7d5f64524() {
    foreach (var value in initializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_0a794bb67d085c7b() {
    foreach (var value in initializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_6f60392dfa9d0628() {
    foreach (var value in initializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_e5a518bb7763f26e() {
    foreach (var value in initializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_b8ede3b66ba21565() {
    foreach (var value in initializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_195a963fd8e99a03() {
    foreach (var value in initializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_ea672e79b158a43e() {
    foreach (var value in initializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_57b1bef0772c8097() {
    foreach (var value in initializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Types>(row[1]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<global::DripSharp.PdfCarton.Xmp.Type.Cardinality>(row[2]) };
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_d2336221150c0906))]
  public void __Upstream_3540789284_55ae831725c5dc6f(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    this.initMetadata();
    try {
      this.testInitializedToNull(fieldName, type, card);
    } finally {
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_970c926acb00b2a7))]
  public void __Upstream_0974183790_8462faba26e2cce1(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    this.initMetadata();
    try {
      this.testPropertySetterInArray(fieldName, type, card);
    } finally {
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_77dadfe7d5f64524))]
  public void __Upstream_3916638520_cecceaa0d1ad0a3a(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    this.initMetadata();
    try {
      this.testPropertySetterSimple(fieldName, type, card);
    } finally {
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_0a794bb67d085c7b))]
  public void __Upstream_3372502507_8a76233f7da562fe(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    this.initMetadata();
    try {
      this.testRandomPropertySetterInArray(fieldName, type, card);
    } finally {
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_6f60392dfa9d0628))]
  public void __Upstream_3024172315_4ef80300eea47203(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    this.initMetadata();
    try {
      this.testRandomPropertySetterSimple(fieldName, type, card);
    } finally {
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_e5a518bb7763f26e))]
  public void __Upstream_4049502118_aa665d9d3eed04fa(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    this.initMetadata();
    try {
      this.testRandomSetterSimple(fieldName, type, card);
    } finally {
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_b8ede3b66ba21565))]
  public void __Upstream_3730436502_7fef9b46e247d2f8(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    this.initMetadata();
    try {
      this.testRandomSettingValue(fieldName, type, card);
    } finally {
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_195a963fd8e99a03))]
  public void __Upstream_2849682878_df6a3c557be795fa(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    this.initMetadata();
    try {
      this.testRandomSettingValueInArray(fieldName, type, card);
    } finally {
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_ea672e79b158a43e))]
  public void __Upstream_3686552243_64a7cda1c1666dad(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    this.initMetadata();
    try {
      this.testSettingValue(fieldName, type, card);
    } finally {
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_57b1bef0772c8097))]
  public void __Upstream_1354451457_f43b9989588a61ff(string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    this.initMetadata();
    try {
      this.testSettingValueInArray(fieldName, type, card);
    } finally {
    }
  }
}
