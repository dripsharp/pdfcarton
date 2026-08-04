// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp;

public class TestValidatePermitedMetadata {
internal static global::System.Collections.Generic.ICollection<object[]> initializeParameters() {
global::System.Collections.Generic.IList<object[]> @params = new global::System.Collections.Generic.List<object[]>();
global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Xmp.TestValidatePermitedMetadata), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "/permited_metadata.txt"));
global::System.IO.TextReader reader = global::DripSharp.PdfCarton.Tests.Support.NewInputStreamReader(@is, global::DripSharp.Runtime.JavaStandardCharsets.ISO88591);
string line = reader.ReadLine();
while ((line != default!)) {
if (global::DripSharp.Runtime.JavaCompat.StringStartsWith(line, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "http://"))) {
int pos = global::DripSharp.Runtime.JavaCompat.StringLastIndexOf(line, (int)(':'));
int spos = global::DripSharp.Runtime.JavaCompat.StringLastIndexOf(line, (int)('/'), pos);
string @namespace = global::DripSharp.Runtime.JavaCompat.StringSubstring(line, 0, (spos + 1));
string preferred = global::DripSharp.Runtime.JavaCompat.StringSubstring(line, (spos + 1), pos);
string fieldname = line.Substring((pos + 1));
global::DripSharp.Runtime.JavaCompat.Add(@params, new string[] { @namespace, preferred, fieldname });
}
line = reader.ReadLine();
}
return @params;
}

internal virtual void checkExistence(string @namespace, string preferred, string fieldname) {
global::DripSharp.PdfCarton.Xmp.XMPMetadata xmpmd = new global::DripSharp.PdfCarton.Xmp.XMPMetadata();
global::DripSharp.PdfCarton.Xmp.Type.TypeMapping mapping = new global::DripSharp.PdfCarton.Xmp.Type.TypeMapping(xmpmd);
global::DripSharp.PdfCarton.Xmp.Schema.XMPSchemaFactory factory = mapping.GetSchemaFactory(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", @namespace));
global::DripSharp.Testing.JavaAssertions.NotNull(factory, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", global::DripSharp.Runtime.JavaCompat.Concat("Schema not existing: ", @namespace)));
global::DripSharp.PdfCarton.Xmp.Schema.XMPSchema schema = factory.CreateXMPSchema(xmpmd, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "aa"));
global::DripSharp.Testing.JavaAssertions.Equal(preferred, schema.GetPreferedPrefix(), null);
bool found = false;
global::System.Type clz = ((object)(schema)).GetType();
foreach (global::System.Reflection.FieldInfo dfield in clz.GetFields(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.DeclaredOnly)) {
global::DripSharp.PdfCarton.Xmp.Type.PropertyType ptype = global::DripSharp.Runtime.JavaCompat.FieldGetAnnotation<global::DripSharp.PdfCarton.Xmp.Type.PropertyType>(dfield, typeof(global::DripSharp.PdfCarton.Xmp.Type.PropertyType))!;
if ((ptype != default!)) {
if (global::DripSharp.Runtime.JavaCompat.Equals(typeof(string), dfield.FieldType)) {
string value = (string)(dfield.GetValue(clz)!);
if (global::DripSharp.Runtime.JavaCompat.Equals(fieldname, value)) {
found = true;
break;
}
} else {
throw new global::System.ArgumentException(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", global::DripSharp.Runtime.JavaCompat.Concat("Should be a string : ", dfield.Name)));
}
}
}
string msg = global::DripSharp.Runtime.JavaCompat.JavaStringFormat(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", "Did not find field definition for '%s' in %s (%s)"), fieldname, clz.Name, @namespace);
global::DripSharp.Testing.JavaAssertions.True(found, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", msg));
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_071c0541a8bc3d8a()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[1]), global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[2]) };
    }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_071c0541a8bc3d8a))]
public void __Upstream_2608205338_b66d1360c0f4a5ea(string @namespace, string preferred, string fieldname)
{
        try
        {
            this.checkExistence(@namespace, preferred, fieldname);
        }
        finally
        {
        }
}
}
