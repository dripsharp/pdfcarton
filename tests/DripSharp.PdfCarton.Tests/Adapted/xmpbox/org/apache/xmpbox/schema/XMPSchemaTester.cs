// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Schema;

internal class XMPSchemaTester {
  private readonly global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata = null!;

  private readonly global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema = null!;

  private readonly global::System.Type schemaClass = null!;

  private readonly string property = null!;

  private readonly global::DripSharp.PdfCarton.Xmp.Type.PropertyType type = null!;

  private readonly object value = null!;

  internal XMPSchemaTester(global::DripSharp.PdfCarton.Xmp.XMPMetadata metadata,
    global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema, global::System.Type schemaClass,
    string property, global::DripSharp.PdfCarton.Xmp.Type.PropertyType type, object value) {
    this.metadata = metadata;
    this.schema = schema;
    this.schemaClass = schemaClass;
    this.property = property;
    this.type = type;
    this.value = value;
  }

  public static global::DripSharp.PdfCarton.Xmp.Type.PropertyType CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types type) {
    return global::DripSharp.PdfCarton.Xmp.Type.TypeMapping.CreatePropertyType(type,
      global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple);
  }

  public static global::DripSharp.PdfCarton.Xmp.Type.PropertyType CreatePropertyType(global::DripSharp.PdfCarton.Xmp.Type.Types type,
    global::DripSharp.PdfCarton.Xmp.Type.Cardinality card) {
    return global::DripSharp.PdfCarton.Xmp.Type.TypeMapping.CreatePropertyType(type, card);
  }

  public virtual void TestGetSetValue() {
    if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Text) && (this.type.Card()
      == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {
      this.TestGetSetTextValue();
    } else {
      if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Boolean)
        && (this.type.Card() == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {
        this.TestGetSetBooleanValue();
      } else {
        if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Integer)
          && (this.type.Card() == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {
          this.TestGetSetIntegerValue();
        } else {
          if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Date)
            && (this.type.Card() == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {
            this.TestGetSetDateValue();
          } else {
            if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Uri)
              && (this.type.Card() == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {
              this.TestGetSetTextValue();
            } else {
              if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Url)
                && (this.type.Card() == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {
                this.TestGetSetTextValue();
              } else {
                if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.AgentName)
                  && (this.type.Card()
                  == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {
                  this.TestGetSetTextValue();
                } else {
                  if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.LangAlt)
                    && (this.type.Card()
                    == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {} else {
                    if (((this.type.Type()
                      == global::DripSharp.PdfCarton.Xmp.Type.Types.ResourceRef)
                      && (this.type.Card()
                      == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {} else {
                      if ((this.type.Card()
                        != global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple)) {} else {
                        throw new global::System.ArgumentException(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
                          global::DripSharp.Runtime.JavaCompat.Concat("Unknown type : ",
                          this.type)));
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
  }

  public virtual void TestGetSetProperty() {
    if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Text) && (this.type.Card()
      == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {
      this.TestGetSetTextProperty();
    } else {
      if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Uri) && (this.type.Card()
        == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {
        this.TestGetSetURIProperty();
      } else {
        if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Url)
          && (this.type.Card() == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {
          this.TestGetSetURLProperty();
        } else {
          if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.AgentName)
            && (this.type.Card() == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {
            this.TestGetSetAgentNameProperty();
          } else {
            if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Boolean)
              && (this.type.Card() == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {
              this.TestGetSetBooleanProperty();
            } else {
              if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Integer)
                && (this.type.Card() == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {
                this.TestGetSetIntegerProperty();
              } else {
                if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Date)
                  && (this.type.Card()
                  == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {
                  this.TestGetSetDateProperty();
                } else {
                  if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Text)
                    && (this.type.Card()
                    == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Seq))) {
                    this.TestGetSetTextListValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
                      "seq"));
                  } else {
                    if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Version)
                      && (this.type.Card()
                      == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Seq))) {
                      this.TestGetSetTextListValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
                        "seq"));
                    } else {
                      if (((this.type.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Text)
                        && (this.type.Card()
                        == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Bag))) {
                        this.TestGetSetTextListValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
                          "bag"));
                      } else {
                        if (((this.type.Type()
                          == global::DripSharp.PdfCarton.Xmp.Type.Types.ProperName)
                          && (this.type.Card()
                          == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Bag))) {
                          this.TestGetSetTextListValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
                            "bag"));
                        } else {
                          if (((this.type.Type()
                            == global::DripSharp.PdfCarton.Xmp.Type.Types.XPath)
                            && (this.type.Card()
                            == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Bag))) {
                            this.TestGetSetTextListValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
                              "bag"));
                          } else {
                            if (((this.type.Type()
                              == global::DripSharp.PdfCarton.Xmp.Type.Types.Date)
                              && (this.type.Card()
                              == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Seq))) {
                              this.TestGetSetDateListValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
                                "seq"));
                            } else {
                              if (((this.type.Type()
                                == global::DripSharp.PdfCarton.Xmp.Type.Types.LangAlt)
                                && (this.type.Card()
                                == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple))) {
                                this.TestGetSetLangAltValue();
                              } else {
                                if (((this.type.Type()
                                  == global::DripSharp.PdfCarton.Xmp.Type.Types.Thumbnail)
                                  && (this.type.Card()
                                  == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Alt))) {
                                  this.TestGetSetThumbnail();
                                } else {
                                  throw new global::System.ArgumentException(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
                                    global::DripSharp.Runtime.JavaCompat.Concat("Unknown type : ",
                                    this.type)));
                                }
                              }
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
    global::System.Reflection.FieldInfo[] fields = this.schemaClass.GetFields();
    foreach (global::System.Reflection.FieldInfo field in fields) {
      if ((global::DripSharp.Runtime.JavaCompat.MemberIsAnnotationPresent(field,
        typeof(global::DripSharp.PdfCarton.Xmp.Type.PropertyType))
        && !global::DripSharp.Runtime.JavaCompat.Equals(field.GetValue(this.schema),
        this.property))) {
        global::DripSharp.PdfCarton.Xmp.Type.PropertyType pt
          = global::DripSharp.Runtime.JavaCompat.FieldGetAnnotation<global::DripSharp.PdfCarton.Xmp.Type.PropertyType>(field,
          typeof(global::DripSharp.PdfCarton.Xmp.Type.PropertyType))!;
        if ((pt.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.LangAlt)) {} else {
          if (((pt.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Thumbnail) && (pt.Card()
            == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Alt))) {} else {
            if ((pt.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.ResourceRef)) {} else {
              if (((pt.Type() == global::DripSharp.PdfCarton.Xmp.Type.Types.Version) && (pt.Card()
                == global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Seq))) {} else {
                global::DripSharp.PdfCarton.Xmp.Type.PropertyType spt
                  = this.RetrievePropertyType(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
                  global::DripSharp.Runtime.JavaCompat.StringValueOf(field.GetValue(this.schema))));
                string getNameProperty
                  = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("get",
                  this.PrepareName(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
                  global::DripSharp.Runtime.JavaCompat.StringValueOf(field.GetValue(this.schema))),
                  spt)), "Property");
                global::System.Reflection.MethodInfo getMethod
                  = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
                  global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getNameProperty));
                global::DripSharp.Testing.JavaAssertions.Null(getMethod.Invoke(this.schema,
                  new object?[] {  }), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
                  global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(getNameProperty,
                  " should return null when testing "), this.property)));
                string getNameValue = global::DripSharp.Runtime.JavaCompat.Concat("get",
                  this.PrepareName(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
                  global::DripSharp.Runtime.JavaCompat.StringValueOf(field.GetValue(this.schema))),
                  spt));
                getMethod = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
                  global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getNameValue));
                global::DripSharp.Testing.JavaAssertions.NotNull(getMethod,
                  global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
                  global::DripSharp.Runtime.JavaCompat.Concat(getNameValue,
                  " method should exist")));
                global::DripSharp.Testing.JavaAssertions.Null(getMethod.Invoke(this.schema,
                  new object?[] {  }), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
                  global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(getNameValue,
                  " should return null when testing "), this.property)));
              }
            }
          }
        }
      }
    }
  }

  protected internal virtual global::DripSharp.PdfCarton.Xmp.Type.PropertyType RetrievePropertyType(string prop) {
    global::System.Reflection.FieldInfo[] fields = this.schemaClass.GetFields();
    foreach (global::System.Reflection.FieldInfo field in fields) {
      if (global::DripSharp.Runtime.JavaCompat.MemberIsAnnotationPresent(field,
        typeof(global::DripSharp.PdfCarton.Xmp.Type.PropertyType))) {
        global::DripSharp.PdfCarton.Xmp.Type.PropertyType pt
          = global::DripSharp.Runtime.JavaCompat.FieldGetAnnotation<global::DripSharp.PdfCarton.Xmp.Type.PropertyType>(field,
          typeof(global::DripSharp.PdfCarton.Xmp.Type.PropertyType))!;
        if (global::DripSharp.Runtime.JavaCompat.Equals(field.GetValue(this.schema), prop)) {
          return pt;
        }
      }
    }
    return this.type;
  }

  protected internal virtual string FirstUpper(string name) {
    global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder(name.Length);
    sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.Runtime.JavaCompat.StringSubstring(name, 0, 1).ToUpper()));
    sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", name.Substring(1)));
    return sb.ToString();
  }

  protected internal virtual string PrepareName(string prop,
    global::DripSharp.PdfCarton.Xmp.Type.PropertyType type) {
    string fu = this.FirstUpper(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop));
    global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder((fu.Length + 1));
    sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fu));
    if (global::DripSharp.Runtime.JavaCompat.StringEndsWith(fu,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "s"))) {} else {
      if (global::DripSharp.Runtime.JavaCompat.StringEndsWith(fu,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "y"))) {} else {
        if ((type.Card() != global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Simple)) {
          sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "s"));
        }
      }
    }
    return sb.ToString();
  }

  protected internal virtual string SetMethod(string prop) {
    global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder((3 + prop.Length));
    sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "set")).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.PrepareName(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop),
      this.type))).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "Property"));
    return sb.ToString();
  }

  protected internal virtual string AddMethod(string prop) {
    string fu = this.FirstUpper(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop));
    global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder((3 + prop.Length));
    sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "add")).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fu));
    return sb.ToString();
  }

  protected internal virtual string GetMethod(string prop) {
    string fu = this.FirstUpper(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop));
    global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder((3 + prop.Length));
    sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "get")).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      fu)).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "Property"));
    return sb.ToString();
  }

  protected internal virtual string SetValueMethod(string prop) {
    string fu = this.FirstUpper(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop));
    global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder((8 + prop.Length));
    sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "set")).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fu));
    return sb.ToString();
  }

  protected internal virtual string GetValueMethod(string prop) {
    global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder((8 + prop.Length));
    sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "get")).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.PrepareName(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop),
      this.type)));
    return sb.ToString();
  }

  protected internal virtual string AddToValueMethod(string prop) {
    string fu = this.FirstUpper(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop));
    global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder((10
      + prop.Length));
    sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "add")).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fu));
    return sb.ToString();
  }

  protected internal virtual void TestGetSetBooleanProperty() {
    string setName = this.SetMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName = this.GetMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    global::DripSharp.PdfCarton.Xmp.Type.BooleanType bt
      = new global::DripSharp.PdfCarton.Xmp.Type.BooleanType(this.metadata, (string)default!,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.schema.GetPrefix()),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.property), this.value);
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setName),
      typeof(global::DripSharp.PdfCarton.Xmp.Type.BooleanType));
    global::System.Reflection.MethodInfo getMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName));
    setMethod.Invoke(this.schema, new object?[] { bt });
    bool? found = ((global::DripSharp.PdfCarton.Xmp.Type.BooleanType)(getMethod.Invoke(this.schema,
      new object?[] {  })!)).GetValue();
    global::DripSharp.Testing.JavaAssertions.Equal(this.value, found, null);
  }

  protected internal virtual void TestGetSetDateProperty() {
    string setName = this.SetMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName = this.GetMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    global::DripSharp.PdfCarton.Xmp.Type.DateType dt
      = new global::DripSharp.PdfCarton.Xmp.Type.DateType(this.metadata, (string)default!,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.schema.GetPrefix()),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.property), this.value);
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setName),
      typeof(global::DripSharp.PdfCarton.Xmp.Type.DateType));
    global::System.Reflection.MethodInfo getMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName));
    setMethod.Invoke(this.schema, new object?[] { dt });
    global::System.DateTimeOffset? found
      = ((global::DripSharp.PdfCarton.Xmp.Type.DateType)(getMethod.Invoke(this.schema,
      new object?[] {  })!)).GetValue();
    global::DripSharp.Testing.JavaAssertions.Equal(this.value, found, null);
  }

  protected internal virtual void TestGetSetIntegerProperty() {
    string setName = this.SetMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName = this.GetMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    global::DripSharp.PdfCarton.Xmp.Type.IntegerType it
      = new global::DripSharp.PdfCarton.Xmp.Type.IntegerType(this.metadata, (string)default!,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.schema.GetPrefix()),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.property), this.value);
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setName),
      typeof(global::DripSharp.PdfCarton.Xmp.Type.IntegerType));
    global::System.Reflection.MethodInfo getMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName));
    setMethod.Invoke(this.schema, new object?[] { it });
    int? found = ((global::DripSharp.PdfCarton.Xmp.Type.IntegerType)(getMethod.Invoke(this.schema,
      new object?[] {  })!)).GetValue();
    global::DripSharp.Testing.JavaAssertions.Equal(this.value, found, null);
  }

  protected internal virtual void TestGetSetTextProperty() {
    string setName = this.SetMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName = this.GetMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    global::DripSharp.PdfCarton.Xmp.Type.TextType tt
      = this.metadata.GetTypeMapping().CreateText((string)default!,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.schema.GetPrefix()),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.property),
      (string)(this.value!));
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setName),
      typeof(global::DripSharp.PdfCarton.Xmp.Type.TextType));
    global::System.Reflection.MethodInfo getMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName));
    setMethod.Invoke(this.schema, new object?[] { tt });
    string found = ((global::DripSharp.PdfCarton.Xmp.Type.TextType)(getMethod.Invoke(this.schema,
      new object?[] {  })!)).GetStringValue();
    global::DripSharp.Testing.JavaAssertions.Equal(this.value, found, null);
  }

  protected internal virtual void TestGetSetURIProperty() {
    string setName = this.SetMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName = this.GetMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    global::DripSharp.PdfCarton.Xmp.Type.URIType tt
      = this.metadata.GetTypeMapping().CreateURI((string)default!,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.schema.GetPrefix()),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.property),
      (string)(this.value!));
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setName),
      typeof(global::DripSharp.PdfCarton.Xmp.Type.URIType));
    global::System.Reflection.MethodInfo getMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName));
    setMethod.Invoke(this.schema, new object?[] { tt });
    string found = ((global::DripSharp.PdfCarton.Xmp.Type.TextType)(getMethod.Invoke(this.schema,
      new object?[] {  })!)).GetStringValue();
    global::DripSharp.Testing.JavaAssertions.Equal(this.value, found, null);
  }

  protected internal virtual void TestGetSetURLProperty() {
    string setName = this.SetMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName = this.GetMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    global::DripSharp.PdfCarton.Xmp.Type.URLType tt
      = this.metadata.GetTypeMapping().CreateURL((string)default!,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.schema.GetPrefix()),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.property),
      (string)(this.value!));
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setName),
      typeof(global::DripSharp.PdfCarton.Xmp.Type.URLType));
    global::System.Reflection.MethodInfo getMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName));
    setMethod.Invoke(this.schema, new object?[] { tt });
    string found = ((global::DripSharp.PdfCarton.Xmp.Type.TextType)(getMethod.Invoke(this.schema,
      new object?[] {  })!)).GetStringValue();
    global::DripSharp.Testing.JavaAssertions.Equal(this.value, found, null);
  }

  protected internal virtual void TestGetSetAgentNameProperty() {
    string setName = this.SetMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName = this.GetMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    global::DripSharp.PdfCarton.Xmp.Type.AgentNameType tt
      = this.metadata.GetTypeMapping().CreateAgentName((string)default!,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.schema.GetPrefix()),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.property),
      (string)(this.value!));
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setName),
      typeof(global::DripSharp.PdfCarton.Xmp.Type.AgentNameType));
    global::System.Reflection.MethodInfo getMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName));
    setMethod.Invoke(this.schema, new object?[] { tt });
    string found
      = ((global::DripSharp.PdfCarton.Xmp.Type.AgentNameType)(getMethod.Invoke(this.schema,
      new object?[] {  })!)).GetStringValue();
    global::DripSharp.Testing.JavaAssertions.Equal(this.value, found, null);
  }

  protected internal virtual void TestGetSetTextListValue(string tp) {
    string setName
      = this.AddToValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName
      = this.GetValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string[] svalue = (string[])(this.value!);
    global::System.Array.Sort(svalue);
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setName), typeof(string));
    foreach (string @string in svalue) {
      setMethod.Invoke(this.schema, new object?[] { @string });
    }
    global::System.Reflection.MethodInfo getMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName));
    global::System.Collections.Generic.IList<string> fields
      = global::DripSharp.Runtime.JavaCompat.CastList<string>(getMethod.Invoke(this.schema,
      new object?[] {  }));
    foreach (string field in fields) {
      global::DripSharp.Testing.JavaAssertions.True((global::System.Array.BinarySearch(svalue,
        field) >= 0), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        global::DripSharp.Runtime.JavaCompat.Concat(field, " should be found in list")));
    }
  }

  protected internal virtual void TestGetSetDateListValue(string tp) {
    string setName
      = this.AddToValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName
      = this.GetValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    global::System.DateTimeOffset?[] svalue = (global::System.DateTimeOffset?[])(this.value!);
    global::System.Array.Sort(svalue);
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setName),
      typeof(global::System.DateTimeOffset?));
    foreach (global::System.DateTimeOffset? inst in svalue) {
      setMethod.Invoke(this.schema, new object?[] { inst });
    }
    global::System.Reflection.MethodInfo getMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName));
    global::System.Collections.Generic.IList<global::System.DateTimeOffset?> fields
      = global::DripSharp.Runtime.JavaCompat.CastList<global::System.DateTimeOffset?>(getMethod.Invoke(this.schema,
      new object?[] {  }));
    foreach (global::System.DateTimeOffset? field in fields) {
      global::DripSharp.Testing.JavaAssertions.True((global::System.Array.BinarySearch(svalue,
        field) >= 0), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
        global::DripSharp.Runtime.JavaCompat.Concat(field, " should be found in list")));
    }
  }

  protected internal virtual void TestGetSetThumbnail() {
    string addName = this.AddMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName = this.GetMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", addName), typeof(int),
      typeof(int), typeof(string), typeof(string));
    global::System.Reflection.MethodInfo getMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName));
    int height = 162;
    int width = 400;
    string format = "JPEG";
    string img = "/9j/4AAQSkZJRgABAgEASABIAAD";
    setMethod.Invoke(this.schema, new object?[] { height, width, format, img });
    global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Xmp.Type.ThumbnailType> found
      = global::DripSharp.Runtime.JavaCompat.CastList<global::DripSharp.PdfCarton.Xmp.Type.ThumbnailType>(getMethod.Invoke(this.schema,
      new object?[] {  }));
    global::DripSharp.Testing.JavaAssertions.Equal(1,
      global::DripSharp.Runtime.JavaCompat.CollectionCount(found), null);
    global::DripSharp.PdfCarton.Xmp.Type.ThumbnailType t1
      = global::DripSharp.Runtime.JavaCompat.ListGet(found, 0);
    global::DripSharp.Testing.JavaAssertions.Equal(height, t1.GetHeight(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(width, t1.GetWidth(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(format, t1.GetFormat(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(img, t1.GetImage(), null);
  }

  protected internal virtual void TestGetSetLangAltValue() {
    string setName
      = this.AddToValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName
      = this.GetValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    global::System.Collections.Generic.IDictionary<string, string> svalue
      = global::DripSharp.Runtime.JavaCompat.CastDictionary<string, string>(this.value);
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setName), typeof(string),
      typeof(string));
    foreach (global::DripSharp.Runtime.JavaMapEntry<string,
      string> inst in global::DripSharp.Runtime.JavaCompat.MapEntrySet(svalue)) {
      setMethod.Invoke(this.schema, new object?[] { inst.Key, inst.Value });
    }
    string getLanguagesName
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("get",
      this.FirstUpper(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.property))),
      "Languages");
    global::System.Reflection.MethodInfo getLanguages
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getLanguagesName));
    global::System.Collections.Generic.IList<string> lgs
      = global::DripSharp.Runtime.JavaCompat.CastList<string>(getLanguages.Invoke(this.schema,
      new object?[] {  }));
    foreach (string @string in lgs) {
      global::System.Reflection.MethodInfo getMethod
        = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName), typeof(string));
      string res = (string)(getMethod.Invoke(this.schema, new object?[] { @string })!);
      global::DripSharp.Testing.JavaAssertions.Equal(res,
        global::DripSharp.Runtime.JavaCompat.MapGet(svalue, @string), null);
    }
  }

  protected internal virtual void TestGetSetURLValue() {
    string setName
      = this.AddToValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName
      = this.GetValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string svalue = (string)(this.value!);
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setName), typeof(string),
      typeof(string));
    setMethod.Invoke(this.schema, new object?[] { this.property, svalue });
    string getLanguagesName
      = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("get",
      this.FirstUpper(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.property))),
      "Languages");
    global::System.Reflection.MethodInfo getLanguages
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getLanguagesName));
    global::System.Collections.Generic.IList<string> lgs
      = global::DripSharp.Runtime.JavaCompat.CastList<string>(getLanguages.Invoke(this.schema,
      new object?[] {  }));
    foreach (string @string in lgs) {
      global::System.Reflection.MethodInfo getMethod
        = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName), typeof(string));
      string res = (string)(getMethod.Invoke(this.schema, new object?[] { @string })!);
      global::DripSharp.Testing.JavaAssertions.Equal(res, svalue, null);
    }
  }

  protected internal virtual void TestGetSetTextValue() {
    string setName
      = this.SetValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName
      = this.GetValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setName), typeof(string));
    global::System.Reflection.MethodInfo getMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName));
    setMethod.Invoke(this.schema, new object?[] { this.value });
    string found = (string)(getMethod.Invoke(this.schema, new object?[] {  })!);
    global::DripSharp.Testing.JavaAssertions.Equal(this.value, found, null);
  }

  protected internal virtual void TestGetSetBooleanValue() {
    string setName
      = this.SetValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName
      = this.GetValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setName), typeof(bool));
    global::System.Reflection.MethodInfo getMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName));
    setMethod.Invoke(this.schema, new object?[] { this.value });
    bool found = global::DripSharp.Runtime.JavaCompat.Unbox((bool?)(getMethod.Invoke(this.schema,
      new object?[] {  })));
    global::DripSharp.Testing.JavaAssertions.Equal(this.value, found, null);
  }

  protected internal virtual void TestGetSetDateValue() {
    string setName
      = this.SetValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName
      = this.GetValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setName),
      typeof(global::System.DateTimeOffset?));
    global::System.Reflection.MethodInfo getMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName));
    setMethod.Invoke(this.schema, new object?[] { this.value });
    global::System.DateTimeOffset? found
      = (global::System.DateTimeOffset?)(getMethod.Invoke(this.schema, new object?[] {  })!);
    global::DripSharp.Testing.JavaAssertions.Equal(this.value, found, null);
  }

  protected internal virtual void TestGetSetIntegerValue() {
    string setName
      = this.SetValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    string getName
      = this.GetValueMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      this.property));
    global::System.Reflection.MethodInfo setMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", setName), typeof(int));
    global::System.Reflection.MethodInfo getMethod
      = global::DripSharp.Runtime.JavaCompat.GetMethod(this.schemaClass,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", getName));
    setMethod.Invoke(this.schema, new object?[] { this.value });
    int found = global::DripSharp.Runtime.JavaCompat.Unbox((int?)(getMethod.Invoke(this.schema,
      new object?[] {  })));
    global::DripSharp.Testing.JavaAssertions.Equal(this.value, found, null);
  }
}
