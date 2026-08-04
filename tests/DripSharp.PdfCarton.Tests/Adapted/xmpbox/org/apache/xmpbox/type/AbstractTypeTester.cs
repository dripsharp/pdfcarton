// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp.Type;

public abstract class AbstractTypeTester {
private const long COUNTER_SEED = 0;

private static readonly long MAX_COUNTER = long.MaxValue;

public const int RandLoopCount = 50;

private global::DripSharp.PdfCarton.Tests.JavaRandom counterRandom = new global::DripSharp.PdfCarton.Tests.JavaRandom(global::DripSharp.PdfCarton.Xmp.Type.AbstractTypeTester.COUNTER_SEED);

protected internal virtual void InitializeSeed(global::DripSharp.PdfCarton.Tests.JavaRandom rand) {
this.counterRandom = rand;
}

public virtual string CalculateSimpleGetter(string name) {
global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder((3 + name.Length));
sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "get")).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.CalculateFieldNameForMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", name))));
return sb.ToString();
}

public virtual string CalculateArrayGetter(string name) {
global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder((4 + name.Length));
string fn = this.CalculateFieldNameForMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", name));
sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "get")).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", fn));
if (!(global::DripSharp.Runtime.JavaCompat.StringEndsWith(fn, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "s")))) {
sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "s"));
}
return sb.ToString();
}

public virtual string CalculateSimpleSetter(string name) {
global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder((3 + name.Length));
sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "set")).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", this.CalculateFieldNameForMethod(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", name))));
return sb.ToString();
}

public virtual string CalculateFieldNameForMethod(string name) {
global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder(name.Length);
sb.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", global::DripSharp.Runtime.JavaCompat.StringSubstring(name, 0, 1).ToUpper())).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", name.Substring(1)));
return sb.ToString();
}

public virtual global::System.Type GetJavaType(global::DripSharp.PdfCarton.Xmp.Type.Types type) {
if ((type.GetImplementingClass() == typeof(global::DripSharp.PdfCarton.Xmp.Type.TextType))) {
return typeof(string);
} else {
if ((type.GetImplementingClass() == typeof(global::DripSharp.PdfCarton.Xmp.Type.DateType))) {
return typeof(global::System.DateTimeOffset?);
} else {
if ((type.GetImplementingClass() == typeof(global::DripSharp.PdfCarton.Xmp.Type.IntegerType))) {
return typeof(int);
} else {
if (typeof(global::DripSharp.PdfCarton.Xmp.Type.TextType).IsAssignableFrom(type.GetImplementingClass())) {
return typeof(string);
} else {
throw new global::System.ArgumentException(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", global::DripSharp.Runtime.JavaCompat.Concat("Type not expected in test : ", type.GetImplementingClass())));
}
}
}
}
}

public virtual object GetJavaValue(global::DripSharp.PdfCarton.Xmp.Type.Types type) {
if (typeof(global::DripSharp.PdfCarton.Xmp.Type.TextType).IsAssignableFrom(type.GetImplementingClass())) {
return global::DripSharp.Runtime.JavaCompat.Concat("Text_String_", (this.counterRandom.NextLong() % global::DripSharp.PdfCarton.Xmp.Type.AbstractTypeTester.MAX_COUNTER));
} else {
if ((type.GetImplementingClass() == typeof(global::DripSharp.PdfCarton.Xmp.Type.DateType))) {
global::System.DateTimeOffset? calendar = global::System.DateTimeOffset.Now;
calendar = global::DripSharp.PdfCarton.Tests.Support.CalendarFromUnixTimeMilliseconds((this.counterRandom.NextLong() % global::DripSharp.PdfCarton.Xmp.Type.AbstractTypeTester.MAX_COUNTER));
return calendar;
} else {
if ((type.GetImplementingClass() == typeof(global::DripSharp.PdfCarton.Xmp.Type.IntegerType))) {
return this.counterRandom.NextInt();
} else {
throw new global::System.ArgumentException(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", global::DripSharp.Runtime.JavaCompat.Concat("Type not expected in test : ", type.GetImplementingClass())));
}
}
}
}

public virtual global::System.Collections.Generic.IList<global::System.Reflection.FieldInfo> GetXmpFields(global::System.Type clz) {
global::System.Reflection.FieldInfo[] fields = clz.GetFields();
global::System.Collections.Generic.IList<global::System.Reflection.FieldInfo> result = new global::System.Collections.Generic.List<global::System.Reflection.FieldInfo>(fields.Length);
foreach (global::System.Reflection.FieldInfo field in fields) {
if ((global::DripSharp.Runtime.JavaCompat.FieldGetAnnotation<global::DripSharp.PdfCarton.Xmp.Type.PropertyType>(field, typeof(global::DripSharp.PdfCarton.Xmp.Type.PropertyType))! != default!)) {
global::DripSharp.Runtime.JavaCompat.Add(result, field);
}
}
return result;
}

public AbstractTypeTester() {}
}
