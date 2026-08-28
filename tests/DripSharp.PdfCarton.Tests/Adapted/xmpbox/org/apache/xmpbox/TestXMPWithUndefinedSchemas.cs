// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp;

public class TestXMPWithUndefinedSchemas {
  internal static global::System.Collections.Generic.IEnumerable<object[]> initializeParameters() {
    return global::DripSharp.Runtime.JavaCompat.Stream<object[]>(global::DripSharp.Runtime.JavaCompat.StreamOf<object[]>(new object[] { "/undefinedxmp/prism.xmp",
        "http://prismstandard.org/namespaces/basic/2.0/", "aggregationType", "journal" }));
  }

  internal virtual void main(string path, string @namespace, string propertyName,
    string propertyValue) {
    global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser builder
      = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
    builder.SetStrictParsing(false);
    global::DripSharp.PdfCarton.Xmp.XMPMetadata rxmp;
    using (global::System.IO.Stream @is
      = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(((object)(this)).GetType(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", path))) {
      rxmp = builder.Parse(@is);
    }
    global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(rxmp.GetAllSchemas()),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      "There should be a least one schema"));
    global::DripSharp.Testing.JavaAssertions.NotNull(rxmp.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      @namespace)), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("The schema for {",
      @namespace), "} should be available")));
    global::DripSharp.Testing.JavaAssertions.NotNull(rxmp.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      @namespace)).GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      propertyName)), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("The schema for {",
      @namespace), "} should have a property {"), propertyName), "} ")));
    global::DripSharp.Testing.JavaAssertions.Equal(rxmp.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      @namespace)).GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      propertyName)).GetPropertyName(), propertyName,
      global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("The schema for {",
      @namespace), "} should have a property {"), propertyName), "} ")));
    global::DripSharp.Testing.JavaAssertions.Equal(rxmp.GetSchema(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      @namespace)).GetUnqualifiedTextPropertyValue(global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      propertyName)), propertyValue, global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("The property {",
      propertyName), "} should have a value of {"), propertyValue), "}")));
  }

  public static global::System.Collections.Generic.IEnumerable<object[]> __Data_0027e67377d2e607() {
    foreach (var value in initializeParameters()) {
      object[] row = ((object?)value is object[] values)
        ? values : new object[] { value! };
      yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[1]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[2]),
        global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[3]) };
    }
  }

  [Xunit.Theory]
  [Xunit.MemberData(nameof(__Data_0027e67377d2e607))]
  public void __Upstream_2150827449_b12f06de62e0acfb(string path, string @namespace,
    string propertyName, string propertyValue) {
    try {
      this.main(path, @namespace, propertyName, propertyValue);
    } finally {
    }
  }
}
