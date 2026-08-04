// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Schema;

public class XMPSchemaTest {
private readonly global::DripSharp.PdfCarton.Xmp.XMPMetadata parent = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();

private readonly global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schem;

internal virtual void testBagManagement() {
string bagName = "BAGTEST";
string value1 = "valueOne";
string value2 = "valueTwo";
this.schem.AddBagValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", bagName), this.schem.GetMetadata().GetTypeMapping().CreateText((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "rdf"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "li"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", value1)));
this.schem.AddQualifiedBagValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", bagName), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", value2));
global::System.Collections.Generic.IList<string> values = this.schem.GetUnqualifiedBagValueList(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", bagName));
global::DripSharp.Testing.JavaAssertions.Equal(value1, global::DripSharp.Runtime.JavaCompat.ListGet(values, 0), null);
global::DripSharp.Testing.JavaAssertions.Equal(value2, global::DripSharp.Runtime.JavaCompat.ListGet(values, 1), null);
this.schem.RemoveUnqualifiedBagValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", bagName), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", value1));
global::System.Collections.Generic.IList<string> values2 = this.schem.GetUnqualifiedBagValueList(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", bagName));
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.CollectionCount(values2), null);
global::DripSharp.Testing.JavaAssertions.Equal(value2, global::DripSharp.Runtime.JavaCompat.ListGet(values2, 0), null);
}

internal virtual void testArrayList() {
global::DripSharp.PdfCarton.Xmp.XMPMetadata meta = global::DripSharp.PdfCarton.Xmp.XMPMetadata.CreateXMPMetadata();
global::DripSharp.PdfCarton.Xmp.Type.ArrayProperty newSeq = meta.GetTypeMapping().CreateArrayProperty((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "nsSchem"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "seqType"), global::DripSharp.PdfCarton.Xmp.Type.Cardinality.Seq);
global::DripSharp.PdfCarton.Xmp.Type.TypeMapping tm = meta.GetTypeMapping();
global::DripSharp.PdfCarton.Xmp.Type.TextType li1 = tm.CreateText((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "rdf"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "li"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "valeur1"));
global::DripSharp.PdfCarton.Xmp.Type.TextType li2 = tm.CreateText((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "rdf"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "li"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "valeur2"));
newSeq.GetContainer().AddProperty(li1);
newSeq.GetContainer().AddProperty(li2);
this.schem.AddProperty(newSeq);
global::System.Collections.Generic.IList<global::DripSharp.PdfCarton.Xmp.Type.AbstractField> list = this.schem.GetUnqualifiedArrayList(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "seqType"));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(list, li1), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(list, li2), null);
}

internal virtual void testSeqManagement() {
global::System.DateTimeOffset? date = global::System.DateTimeOffset.Now;
global::DripSharp.PdfCarton.Xmp.Type.BooleanType @bool = this.parent.GetTypeMapping().CreateBoolean((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "rdf"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "li"), true);
string textVal = "seqValue";
string seqName = "SEQNAME";
this.schem.AddUnqualifiedSequenceDateValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqName), date);
this.schem.AddUnqualifiedSequenceValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqName), @bool);
this.schem.AddUnqualifiedSequenceValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqName), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", textVal));
global::System.Collections.Generic.IList<global::System.DateTimeOffset?> dates = this.schem.GetUnqualifiedSequenceDateValueList(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqName));
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.CollectionCount(dates), null);
global::DripSharp.Testing.JavaAssertions.Equal(date, global::DripSharp.Runtime.JavaCompat.ListGet(dates, 0), null);
global::System.Collections.Generic.IList<string> values = this.schem.GetUnqualifiedSequenceValueList(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqName));
global::DripSharp.Testing.JavaAssertions.Equal(3, global::DripSharp.Runtime.JavaCompat.CollectionCount(values), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Xmp.DateConverter.ToISO8601(date), global::DripSharp.Runtime.JavaCompat.ListGet(values, 0), null);
global::DripSharp.Testing.JavaAssertions.Equal(@bool.GetStringValue(), global::DripSharp.Runtime.JavaCompat.ListGet(values, 1), null);
global::DripSharp.Testing.JavaAssertions.Equal(textVal, global::DripSharp.Runtime.JavaCompat.ListGet(values, 2), null);
this.schem.RemoveUnqualifiedSequenceDateValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqName), date);
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.Runtime.JavaCompat.CollectionCount(this.schem.GetUnqualifiedSequenceDateValueList(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqName))), null);
this.schem.RemoveUnqualifiedSequenceValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqName), @bool);
this.schem.RemoveUnqualifiedSequenceValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqName), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", textVal));
global::DripSharp.Testing.JavaAssertions.Equal(0, global::DripSharp.Runtime.JavaCompat.CollectionCount(this.schem.GetUnqualifiedSequenceValueList(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqName))), null);
}

internal virtual void rdfAboutTest() {
global::DripSharp.Testing.JavaAssertions.Equal("", this.schem.GetAboutValue(), null);
string about = "about";
this.schem.SetAboutAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", about));
global::DripSharp.Testing.JavaAssertions.Equal(about, this.schem.GetAboutValue(), null);
this.schem.SetAboutAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", ""));
global::DripSharp.Testing.JavaAssertions.Equal("", this.schem.GetAboutValue(), null);
this.schem.SetAboutAsSimple((string)default!);
global::DripSharp.Testing.JavaAssertions.Equal("", this.schem.GetAboutValue(), null);
}

internal virtual void testBadRdfAbout() {
global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Type.BadFieldValueException>(() => {
this.schem.SetAbout(new global::DripSharp.PdfCarton.Xmp.Type.Attribute((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "about"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "")));
}, null);
}

internal virtual void testSetSpecifiedSimpleTypeProperty() {
string prop = "testprop";
string val = "value";
string val2 = "value2";
this.schem.SetTextPropertyValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", val));
global::DripSharp.Testing.JavaAssertions.Equal(val, this.schem.GetUnqualifiedTextPropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop)), null);
this.schem.SetTextPropertyValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", val2));
global::DripSharp.Testing.JavaAssertions.Equal(val2, this.schem.GetUnqualifiedTextPropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop)), null);
this.schem.SetTextPropertyValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop), (string)default!);
global::DripSharp.Testing.JavaAssertions.Null(this.schem.GetUnqualifiedTextProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop)), null);
}

internal virtual void testSpecifiedSimplePropertyFormer() {
string prop = "testprop";
string val = "value";
string val2 = "value2";
this.schem.SetTextPropertyValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", val));
global::DripSharp.PdfCarton.Xmp.Type.TextType text = this.schem.GetMetadata().GetTypeMapping().CreateText((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.schem.GetPrefix()), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "value2"));
this.schem.SetTextProperty(text);
global::DripSharp.Testing.JavaAssertions.Equal(val2, this.schem.GetUnqualifiedTextPropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop)), null);
global::DripSharp.Testing.JavaAssertions.Equal(text, this.schem.GetUnqualifiedTextProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", prop)), null);
}

internal virtual void testAsSimpleMethods() {
string @bool = "bool";
bool boolVal = true;
string date = "date";
global::System.DateTimeOffset? dateVal = global::System.DateTimeOffset.Now;
string integ = "integer";
int i = 1;
string langprop = "langprop";
string lang = "x-default";
string langVal = "langVal";
string bagprop = "bagProp";
string bagVal = "bagVal";
string seqprop = "SeqProp";
string seqPropVal = "seqval";
string seqdate = "SeqDate";
string prefSchem = "";
this.schem.SetBooleanPropertyValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", @bool), boolVal);
this.schem.SetDatePropertyValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", date), dateVal);
this.schem.SetIntegerPropertyValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", integ), i);
this.schem.SetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", langprop), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", lang), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", langVal));
this.schem.AddBagValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", bagprop), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", bagVal));
this.schem.AddUnqualifiedSequenceValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqprop), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqPropVal));
this.schem.AddSequenceDateValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqdate), dateVal);
global::DripSharp.Testing.JavaAssertions.Equal(boolVal, (bool)(this.schem.GetBooleanProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", global::DripSharp.Runtime.JavaCompat.Concat(prefSchem, @bool))).GetValue()), null);
global::DripSharp.Testing.JavaAssertions.Equal(dateVal, (global::System.DateTimeOffset?)(this.schem.GetDateProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", global::DripSharp.Runtime.JavaCompat.Concat(prefSchem, date))).GetValue()), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat("", i), this.schem.GetIntegerProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", global::DripSharp.Runtime.JavaCompat.Concat(prefSchem, integ))).GetStringValue(), null);
global::DripSharp.Testing.JavaAssertions.Equal(langVal, this.schem.GetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", langprop), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", lang)), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(this.schem.GetUnqualifiedBagValueList(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", bagprop)), bagVal), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(this.schem.GetUnqualifiedSequenceValueList(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqprop)), seqPropVal), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(this.schem.GetUnqualifiedSequenceDateValueList(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqdate)), dateVal), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(this.schem.GetUnqualifiedLanguagePropertyLanguagesValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", langprop)), lang), null);
global::DripSharp.Testing.JavaAssertions.Equal(boolVal, this.schem.GetBooleanPropertyValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", @bool)), null);
global::DripSharp.Testing.JavaAssertions.Equal(dateVal, this.schem.GetDatePropertyValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", date)), null);
global::DripSharp.Testing.JavaAssertions.Equal(i, this.schem.GetIntegerPropertyValueAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", integ)), null);
global::DripSharp.Testing.JavaAssertions.Equal(langVal, this.schem.GetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", langprop), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", lang)), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(this.schem.GetUnqualifiedBagValueList(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", bagprop)), bagVal), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(this.schem.GetUnqualifiedSequenceValueList(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqprop)), seqPropVal), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(this.schem.GetUnqualifiedSequenceDateValueList(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqdate)), dateVal), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(this.schem.GetUnqualifiedLanguagePropertyLanguagesValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", langprop)), lang), null);
}

internal virtual void testProperties() {
global::DripSharp.Testing.JavaAssertions.Equal("nsURI", this.schem.GetNamespace(), null);
this.schem.AddNamespace(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "http://www.w3.org/1999/02/22-rdf-syntax-ns#"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "rdf"));
string aboutVal = "aboutTest";
this.schem.SetAboutAsSimple(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", aboutVal));
global::DripSharp.Testing.JavaAssertions.Equal(aboutVal, this.schem.GetAboutValue(), null);
global::DripSharp.PdfCarton.Xmp.Type.Attribute about = new global::DripSharp.PdfCarton.Xmp.Type.Attribute(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", global::DripSharp.PdfCarton.Xmp.XmpConstants.RdfNamespace), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "about"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "YEP"));
this.schem.SetAbout(about);
global::DripSharp.Testing.JavaAssertions.Equal(about, this.schem.GetAboutAttribute(), null);
string textProp = "textProp";
string textPropVal = "TextPropTest";
this.schem.SetTextPropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", textProp), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", textPropVal));
global::DripSharp.Testing.JavaAssertions.Equal(textPropVal, this.schem.GetUnqualifiedTextPropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", textProp)), null);
global::DripSharp.PdfCarton.Xmp.Type.TextType text = this.parent.GetTypeMapping().CreateText((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "nsSchem"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "textType"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "GRINGO"));
this.schem.SetTextProperty(text);
global::DripSharp.Testing.JavaAssertions.Equal(text, this.schem.GetUnqualifiedTextProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "textType")), null);
global::System.DateTimeOffset? dateVal = global::System.DateTimeOffset.Now;
string date = "nsSchem:dateProp";
this.schem.SetDatePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", date), dateVal);
global::DripSharp.Testing.JavaAssertions.Equal(dateVal, this.schem.GetDatePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", date)), null);
global::DripSharp.PdfCarton.Xmp.Type.DateType dateType = this.parent.GetTypeMapping().CreateDate((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "nsSchem"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "dateType"), global::System.DateTimeOffset.Now);
this.schem.SetDateProperty(dateType);
global::DripSharp.Testing.JavaAssertions.Equal(dateType, this.schem.GetDateProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "dateType")), null);
string @bool = "nsSchem:booleanTestProp";
bool boolVal = false;
this.schem.SetBooleanPropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", @bool), boolVal);
global::DripSharp.Testing.JavaAssertions.Equal(boolVal, this.schem.GetBooleanPropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", @bool)), null);
global::DripSharp.PdfCarton.Xmp.Type.BooleanType boolType = this.parent.GetTypeMapping().CreateBoolean((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "nsSchem"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "boolType"), false);
this.schem.SetBooleanProperty(boolType);
global::DripSharp.Testing.JavaAssertions.Equal(boolType, this.schem.GetBooleanProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "boolType")), null);
string intProp = "nsSchem:IntegerTestProp";
int intPropVal = 5;
this.schem.SetIntegerPropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", intProp), intPropVal);
global::DripSharp.Testing.JavaAssertions.Equal(intPropVal, this.schem.GetIntegerPropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", intProp)), null);
global::DripSharp.PdfCarton.Xmp.Type.IntegerType intType = this.parent.GetTypeMapping().CreateInteger((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "nsSchem"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "intType"), 5);
this.schem.SetIntegerProperty(intType);
global::DripSharp.Testing.JavaAssertions.Equal(intType, this.schem.GetIntegerProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "intType")), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Type.BadFieldValueException>(() => this.schem.GetIntegerProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "boolType")), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Type.BadFieldValueException>(() => this.schem.GetDateProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "textType")), null);
global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Xmp.Type.BadFieldValueException>(() => this.schem.GetBooleanProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "dateType")), null);
}

internal virtual void testAltProperties() {
string altProp = "AltProp";
string defaultLang = "x-default";
string defaultVal = "Default Language";
string usLang = "en-us";
string usVal = "American Language";
string frLang = "fr-fr";
string frVal = "Lang fran\u00E7aise";
this.schem.SetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altProp), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", usLang), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", usVal));
this.schem.SetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altProp), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", defaultLang), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", defaultVal));
this.schem.SetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altProp), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", frLang), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", frVal));
global::DripSharp.Testing.JavaAssertions.Equal(defaultVal, this.schem.GetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altProp), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", defaultLang)), null);
global::DripSharp.Testing.JavaAssertions.Equal(frVal, this.schem.GetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altProp), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", frLang)), null);
global::DripSharp.Testing.JavaAssertions.Equal(usVal, this.schem.GetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altProp), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", usLang)), null);
global::System.Collections.Generic.IList<string> languages = this.schem.GetUnqualifiedLanguagePropertyLanguagesValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altProp));
global::DripSharp.Testing.JavaAssertions.Equal(defaultLang, global::DripSharp.Runtime.JavaCompat.ListGet(languages, 0), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(languages, usLang), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(languages, frLang), null);
frVal = "Langue fran\u00E7aise";
this.schem.SetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altProp), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", frLang), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", frVal));
global::DripSharp.Testing.JavaAssertions.Equal(frVal, this.schem.GetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altProp), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", frLang)), null);
this.schem.SetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altProp), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", frLang), (string)default!);
languages = this.schem.GetUnqualifiedLanguagePropertyLanguagesValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altProp));
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.CollectionContains(languages, frLang), null);
this.schem.SetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altProp), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", frLang), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", frVal));
}

internal virtual void testMergeSchema() {
string bagName = "bagName";
string seqName = "seqName";
string altName = "AltProp";
string valBagSchem1 = "BagvalSchem1";
string valBagSchem2 = "BagvalSchem2";
string valSeqSchem1 = "seqvalSchem1";
string valSeqSchem2 = "seqvalSchem2";
string valAltSchem1 = "altvalSchem1";
string langAltSchem1 = "x-default";
string valAltSchem2 = "altvalSchem2";
string langAltSchem2 = "fr-fr";
global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schem1 = new global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema(this.parent, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "http://www.test.org/schem/"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"));
schem1.AddQualifiedBagValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", bagName), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", valBagSchem1));
schem1.AddUnqualifiedSequenceValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqName), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", valSeqSchem1));
schem1.SetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altName), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", langAltSchem1), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", valAltSchem1));
global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schem2 = new global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema(this.parent, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "http://www.test.org/schem/"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"));
schem2.AddQualifiedBagValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", bagName), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", valBagSchem2));
schem2.AddUnqualifiedSequenceValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqName), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", valSeqSchem2));
schem2.SetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altName), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", langAltSchem2), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", valAltSchem2));
schem1.Merge(schem2);
global::DripSharp.Testing.JavaAssertions.Equal(valAltSchem2, schem1.GetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altName), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", langAltSchem2)), null);
global::DripSharp.Testing.JavaAssertions.Equal(valAltSchem1, schem1.GetUnqualifiedLanguagePropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", altName), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", langAltSchem1)), null);
global::System.Collections.Generic.IList<string> bag = schem1.GetUnqualifiedBagValueList(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", bagName));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(bag, valBagSchem1), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(bag, valBagSchem2), null);
global::System.Collections.Generic.IList<string> seq = schem1.GetUnqualifiedSequenceValueList(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", seqName));
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(seq, valSeqSchem1), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(seq, valSeqSchem1), null);
}

internal virtual void testListAndContainerAccessor() {
string boolname = "bool";
bool boolVal = true;
global::DripSharp.PdfCarton.Xmp.Type.BooleanType @bool = this.parent.GetTypeMapping().CreateBoolean((string)default!, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.schem.GetPrefix()), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", boolname), boolVal);
global::DripSharp.PdfCarton.Xmp.Type.Attribute att = new global::DripSharp.PdfCarton.Xmp.Type.Attribute(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", global::DripSharp.PdfCarton.Xmp.XmpConstants.RdfNamespace), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "test"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "vgh"));
this.schem.SetAttribute(att);
this.schem.SetBooleanProperty(@bool);
global::DripSharp.Testing.JavaAssertions.Equal(this.schem.GetAllProperties(), this.schem.GetAllProperties(), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(this.schem.GetAllProperties(), @bool), null);
global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Runtime.JavaCompat.CollectionContains(this.schem.GetAllAttributes(), att), null);
global::DripSharp.Testing.JavaAssertions.Equal(@bool, this.schem.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", boolname)), null);
}

[Xunit.Fact]
public void __Upstream_2471294891_ad60b5cfa1ceb696()
{
        try
        {
            this.rdfAboutTest();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1191971914_314a2e90f6f68b6c()
{
        try
        {
            this.testAltProperties();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1392026149_3238cafd9d4765df()
{
        try
        {
            this.testArrayList();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3745335196_908ba203e6e6d32d()
{
        try
        {
            this.testAsSimpleMethods();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1957487276_13f860da5bd09afb()
{
        try
        {
            this.testBadRdfAbout();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0490262265_032115c2212925fa()
{
        try
        {
            this.testBagManagement();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2639275329_1b15b05e50f727ee()
{
        try
        {
            this.testListAndContainerAccessor();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1664675847_23b860318b3852ba()
{
        try
        {
            this.testMergeSchema();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0507420517_60737c6a39f81265()
{
        try
        {
            this.testProperties();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3819032208_99ec984908ee8f1f()
{
        try
        {
            this.testSeqManagement();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2888627009_64bb6df98eb6d332()
{
        try
        {
            this.testSetSpecifiedSimpleTypeProperty();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1626780502_16fa542ef01fdd33()
{
        try
        {
            this.testSpecifiedSimplePropertyFormer();
        }
        finally
        {
        }
}

public XMPSchemaTest() {
this.schem = new global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema(this.parent, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "nsURI"), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "nsSchem"));
}
}
