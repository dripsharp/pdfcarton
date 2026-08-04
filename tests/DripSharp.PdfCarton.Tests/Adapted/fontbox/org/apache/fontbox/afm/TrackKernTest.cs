// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Afm;

public class TrackKernTest {
internal virtual void testTrackKern() {
global::DripSharp.PdfCarton.Fonts.Afm.TrackKern trackKern = new global::DripSharp.PdfCarton.Fonts.Afm.TrackKern(0, 1.0F, 1.0F, 10.0F, 10.0F);
global::DripSharp.Testing.JavaAssertions.Equal(0, trackKern.GetDegree(), null);
global::DripSharp.Testing.JavaAssertions.Equal(1.0F, trackKern.GetMinPointSize(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(1.0F, trackKern.GetMinKern(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(10.0F, trackKern.GetMaxPointSize(), null, 0.0F);
global::DripSharp.Testing.JavaAssertions.Equal(10.0F, trackKern.GetMaxKern(), null, 0.0F);
}

[Xunit.Fact]
public void __Upstream_3546731663_c5358faecf689ee1()
{
        try
        {
            this.testTrackKern();
        }
        finally
        {
        }
}
}
