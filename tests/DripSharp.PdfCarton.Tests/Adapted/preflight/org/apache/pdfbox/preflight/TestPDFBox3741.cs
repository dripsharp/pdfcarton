// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight;

public class TestPDFBox3741 {
internal virtual void testPDFBox3741() {
global::DripSharp.PdfCarton.Preflight.ValidationResult result = global::DripSharp.PdfCarton.Preflight.Parser.PreflightParser.Validate(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "src/test/resources/PDFBOX-3741.pdf")));
global::DripSharp.Testing.JavaAssertions.False(result.IsValid(), global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "File PDFBOX-3741.pdf should be detected as not PDF/A-1b"));
global::DripSharp.Testing.JavaAssertions.Equal(1, global::DripSharp.Runtime.JavaCompat.CollectionCount(result.GetErrorsList()), global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", "List should contain one result"));
global::DripSharp.Testing.JavaAssertions.Equal("2.4.3", global::DripSharp.Runtime.JavaCompat.ListGet(result.GetErrorsList(), 0).GetErrorCode(), null);
}

[Xunit.Fact]
public void __Upstream_1724550412_43d651e90d8e33fc()
{
        try
        {
            this.testPDFBox3741();
        }
        finally
        {
        }
}
}
