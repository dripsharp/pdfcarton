// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Xmp;

public class TestXMPWithDefinedSchemas {
internal static global::System.Collections.Generic.IEnumerable<string> initializeParameters() {
return global::DripSharp.Runtime.JavaCompat.StreamOf("/validxmp/override_ns.rdf", "/validxmp/ghost2.xmp", "/validxmp/history2.rdf", "/validxmp/Notepad++_A1b.xmp", "/validxmp/metadata.rdf", "/validxmp/PDFBOX-6099.xmp");
}

internal virtual void main(string path) {
using (global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(((object)(this)).GetType(), global::DripSharp.PdfCarton.Tests.Support.TestPath("xmpbox", path))) {
global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser builder = new global::DripSharp.PdfCarton.Xmp.Xml.DomXmpParser();
global::DripSharp.PdfCarton.Xmp.XMPMetadata rxmp = builder.Parse(@is);
global::DripSharp.Testing.JavaAssertions.False(global::DripSharp.Runtime.JavaCompat.ListIsEmpty(rxmp.GetAllSchemas()), null);
}
}

public static global::System.Collections.Generic.IEnumerable<object[]> __Data_6c42939554f6a5bd()
{
    foreach (var value in initializeParameters())
    {
        object[] row = ((object?)value is object[] values)
            ? values : new object[] { value! };
        yield return new object[] { global::DripSharp.PdfCarton.Tests.Support.TheoryArgument<string>(row[0]) };
    }
}

[Xunit.Theory]
[Xunit.MemberData(nameof(__Data_6c42939554f6a5bd))]
public void __Upstream_2150827449_f696888c0556024d(string path)
{
        try
        {
            this.main(path);
        }
        finally
        {
        }
}
}
