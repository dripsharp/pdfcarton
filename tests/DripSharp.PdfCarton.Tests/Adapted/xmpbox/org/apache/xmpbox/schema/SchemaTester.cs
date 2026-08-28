// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Schema;

internal class SchemaTester : global::DripSharp.PdfCarton.Xmp.Type.AbstractTypeTester {
  private readonly global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = null!;

  private readonly global::System.Type schemaClass = null!;

  private readonly string fieldName = null!;

  private readonly global::DripSharp.PdfCarton.Xmp.Type.Types type = null!;

  private readonly global::DripSharp.PdfCarton.Xmp.Type.Cardinality cardinality = null!;

  private readonly global::DripSharp.PdfCarton.Xmp.Type.TypeMapping typeMapping = null!;

  internal virtual global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema getSchema() {
    switch (this.schemaClass.Name) {
      case var __case_55_18_0 when global::System.Object.Equals(__case_55_18_0, "DublinCoreSchema"):
        return this.metadata.CreateAndAddDublinCoreSchema();
      case var __case_57_18_0 when global::System.Object.Equals(__case_57_18_0, "PhotoshopSchema"):
        return this.metadata.CreateAndAddPhotoshopSchema();
      default:
        return this.metadata.CreateAndAddXMPBasicSchema();
    }
  }

  internal SchemaTester(global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata,
    global::System.Type schemaClass, string fieldName,
    global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    this.metadata = metadata;
    this.schemaClass = schemaClass;
    this.typeMapping = metadata.GetTypeMapping();
    this.fieldName = fieldName;
    this.type = type;
    this.cardinality = card;
  }

  public virtual void TestInitializedToNull() {
    global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema = this.getSchema();
    global::DripSharp.Testing.JavaAssertions.Null(schema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName)), null);
    if ((this.cardinality == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple)) {
      string getter__82_20
        = this.CalculateSimpleGetter(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        this.fieldName));
      global::System.Reflection.MethodInfo get__83_20
        = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getter__82_20));
      object result__84_20 = get__83_20.Invoke(schema, new object?[] {  });
      global::DripSharp.Testing.JavaAssertions.Null(result__84_20, null);
    } else {
      string getter__90_20
        = this.CalculateArrayGetter(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        this.fieldName));
      global::System.Reflection.MethodInfo get__91_20
        = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getter__90_20));
      object result__92_20 = get__91_20.Invoke(schema, new object?[] {  });
      global::DripSharp.Testing.JavaAssertions.Null(result__92_20, null);
    }
  }

  public virtual void TestSettingValue() {
    this.internalTestSettingValue();
  }

  public virtual void TestRandomSettingValue() {
    this.InitializeSeed(new global::DripSharp.PdfCarton.Tests.JavaRandom());
    for (int i = 0; (i < global::DripSharp.PdfCarton.Xmp.Type.AbstractTypeTester.RandLoopCount);
      i++) {
      this.internalTestSettingValue();
    }
  }

  private void internalTestSettingValue() {
    if ((this.cardinality != global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple)) {
      return;
    }
    global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema = this.getSchema();
    object value = this.GetJavaValue(this.type);
    global::DripSharp.PdfCarton.Xmp.Type.AbstractSimpleProperty property
      = schema.InstanciateSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName), value);
    schema.AddProperty(property);
    string qn
      = this.GetPropertyQualifiedName(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName));
    global::DripSharp.Testing.JavaAssertions.NotNull(schema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName)), null);
    global::System.Collections.Generic.IList<global::System.Reflection.FieldInfo> fields
      = this.GetXmpFields(this.schemaClass);
    foreach (global::System.Reflection.FieldInfo field in fields) {
      string fqn
        = this.GetPropertyQualifiedName(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(field.GetValue((object)default!))));
      if (!global::DripSharp.Runtime.JavaCompat.Equals(fqn, qn)) {
        global::DripSharp.Testing.JavaAssertions.Null(schema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
          fqn)), null);
      }
    }
  }

  public virtual void TestSettingValueInArray() {
    this.internalTestSettingValueInArray();
  }

  public virtual void TestRandomSettingValueInArray() {
    this.InitializeSeed(new global::DripSharp.PdfCarton.Tests.JavaRandom());
    for (int i = 0; (i < global::DripSharp.PdfCarton.Xmp.Type.AbstractTypeTester.RandLoopCount);
      i++) {
      this.internalTestSettingValueInArray();
    }
  }

  private void internalTestSettingValueInArray() {
    if ((this.cardinality == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple)) {
      return;
    }
    global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema = this.getSchema();
    object value = this.GetJavaValue(this.type);
    global::DripSharp.PdfCarton.Xmp.Type.AbstractSimpleProperty property
      = schema.InstanciateSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName), value);
    switch (global::DripSharp.Runtime.JavaCompat.EnumOrdinal(this.cardinality)) {
      case 2:
        schema.AddUnqualifiedSequenceValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
          property.GetPropertyName()), property);
        break;
      case 1:
        schema.AddBagValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
          property.GetPropertyName()), property);
        break;
      default:
        throw new global::System.Exception(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
          global::DripSharp.Runtime.JavaCompat.Concat("Unexpected case in test : ",
          global::DripSharp.Runtime.JavaCompat.EnumName(this.cardinality))));
    }
    string qn
      = this.GetPropertyQualifiedName(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName));
    global::DripSharp.Testing.JavaAssertions.NotNull(schema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName)), null);
    global::System.Collections.Generic.IList<global::System.Reflection.FieldInfo> fields
      = this.GetXmpFields(this.schemaClass);
    foreach (global::System.Reflection.FieldInfo field in fields) {
      string fqn
        = this.GetPropertyQualifiedName(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        global::DripSharp.Runtime.JavaCompat.StringValueOf(field.GetValue((object)default!))));
      if (!global::DripSharp.Runtime.JavaCompat.Equals(fqn, qn)) {
        global::DripSharp.Testing.JavaAssertions.Null(schema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
          fqn)), null);
      }
    }
  }

  public virtual void TestPropertySetterSimple() {
    this.internalTestPropertySetterSimple();
  }

  public virtual void TestRandomPropertySetterSimple() {
    this.InitializeSeed(new global::DripSharp.PdfCarton.Tests.JavaRandom());
    for (int i = 0; (i < global::DripSharp.PdfCarton.Xmp.Type.AbstractTypeTester.RandLoopCount);
      i++) {
      this.internalTestPropertySetterSimple();
    }
  }

  public virtual void TestRandomSetterSimple() {
    this.InitializeSeed(new global::DripSharp.PdfCarton.Tests.JavaRandom());
    for (int i = 0; (i < global::DripSharp.PdfCarton.Xmp.Type.AbstractTypeTester.RandLoopCount);
      i++) {
      this.internalTestSetterSimple();
    }
  }

  private void internalTestPropertySetterSimple() {
    if ((this.cardinality != global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple)) {
      return;
    }
    global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema = this.getSchema();
    string setter
      = global::DripSharp.Runtime.JavaCompat.Concat(this.CalculateSimpleSetter(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName)), "Property");
    object value = this.GetJavaValue(this.type);
    global::DripSharp.PdfCarton.Xmp.Type.AbstractSimpleProperty asp
      = this.typeMapping.InstanciateSimpleProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      schema.GetNamespace()), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      schema.GetPrefix()), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName), value, this.type);
    global::System.Reflection.MethodInfo set
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setter),
      this.type.GetImplementingClass());
    set.Invoke(schema, new object?[] { asp });
    global::DripSharp.PdfCarton.Xmp.Type.AbstractSimpleProperty stored
      = (global::DripSharp.PdfCarton.Xmp.Type.AbstractSimpleProperty)(schema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName))!);
    global::DripSharp.Testing.JavaAssertions.Equal(value, stored.GetValue(), null);
    string getter
      = global::DripSharp.Runtime.JavaCompat.Concat(this.CalculateSimpleGetter(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName)), "Property");
    global::System.Reflection.MethodInfo get
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getter));
    object result = get.Invoke(schema, new object?[] {  });
    global::DripSharp.Testing.JavaAssertions.True(this.type.GetImplementingClass().IsAssignableFrom(((object)(result)).GetType()),
      null);
    global::DripSharp.Testing.JavaAssertions.Equal(asp, result, null);
  }

  public virtual void TestPropertySetterInArray() {
    this.internalTestPropertySetterInArray();
  }

  public virtual void TestRandomPropertySetterInArray() {
    this.InitializeSeed(new global::DripSharp.PdfCarton.Tests.JavaRandom());
    for (int i = 0; (i < global::DripSharp.PdfCarton.Xmp.Type.AbstractTypeTester.RandLoopCount);
      i++) {
      this.internalTestPropertySetterInArray();
    }
  }

  private void internalTestPropertySetterInArray() {
    if ((this.cardinality == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple)) {
      return;
    }
    global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema = this.getSchema();
    string setter = global::DripSharp.Runtime.JavaCompat.Concat("add",
      this.CalculateFieldNameForMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName)));
    object value1 = this.GetJavaValue(this.type);
    global::System.Reflection.MethodInfo set
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setter),
      this.GetJavaType(this.type));
    set.Invoke(schema, new object?[] { value1 });
    string getter
      = global::DripSharp.Runtime.JavaCompat.Concat(this.CalculateArrayGetter(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName)), "Property");
    global::System.Reflection.MethodInfo getcp
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getter));
    object ocp = getcp.Invoke(schema, new object?[] {  });
    global::DripSharp.Testing.JavaAssertions.True((ocp is global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty),
      null);
    global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty cp
      = (global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty)(ocp!);
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(cp.GetContainer().GetAllProperties()),
      null);
    object value2 = this.GetJavaValue(this.type);
    set.Invoke(schema, new object?[] { value2 });
    global::DripSharp.Testing.JavaAssertions.Equal(2,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(cp.GetContainer().GetAllProperties()),
      null);
    string remover = global::DripSharp.Runtime.JavaCompat.Concat("remove",
      this.CalculateFieldNameForMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName)));
    global::System.Reflection.MethodInfo remove
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", remover),
      this.GetJavaType(this.type));
    remove.Invoke(schema, new object?[] { value1 });
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(cp.GetContainer().GetAllProperties()),
      null);
  }

  protected internal virtual string GetPropertyQualifiedName(string name) {
    global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema = this.getSchema();
    global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();
    sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      schema.GetPrefix())).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      ":")).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", name));
    return sb.ToString();
  }

  private void internalTestSetterSimple() {
    if ((this.cardinality != global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple)) {
      return;
    }
    if (((this.schemaClass == typeof(global::DripSharp.PdfCarton.Xmp.Schema.PhotoshopSchema))
      && ((global::DripSharp.Runtime.JavaCompat.Equals("Urgency", this.fieldName)
      || global::DripSharp.Runtime.JavaCompat.Equals("ColorMode", this.fieldName))
      || global::DripSharp.Runtime.JavaCompat.Equals("DateCreated", this.fieldName)))) {
      return;
    }
    global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema = this.getSchema();
    string setter
      = this.CalculateSimpleSetter(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName));
    object value = this.GetJavaValue(this.type);
    global::System.Reflection.MethodInfo set
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setter), typeof(string));
    set.Invoke(schema, new object?[] { value });
    global::DripSharp.PdfCarton.Xmp.Type.AbstractSimpleProperty stored
      = (global::DripSharp.PdfCarton.Xmp.Type.AbstractSimpleProperty)(schema.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName))!);
    global::DripSharp.Testing.JavaAssertions.Equal(value, stored.GetValue(), null);
    string getter
      = this.CalculateSimpleGetter(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.fieldName));
    global::System.Reflection.MethodInfo get
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getter));
    object result = get.Invoke(schema, new object?[] {  });
    global::DripSharp.Testing.JavaAssertions.Equal(value, result, null);
  }
}
