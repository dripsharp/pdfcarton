// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf;

public class TestTTFParser {
internal virtual void testUTCDate() {
global::System.IO.FileInfo testFile = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "src/test/resources/ttf/LiberationSans-Regular.ttf"));
global::System.TimeZoneInfo utc = global::DripSharp.Runtime.JavaCompat.GetTimeZone(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "UTC"));
global::DripSharp.PdfCarton.Tests.Support.SetDefaultTimeZone(global::DripSharp.Runtime.JavaCompat.GetTimeZone(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "America/Los Angeles")));
global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser parser = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser();
global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont ttf = parser.Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBufferedFile(testFile));
global::System.DateTimeOffset? created = ttf.GetHeader().GetCreated();
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.CalendarGetTimeZone(created), utc, null);
global::System.DateTimeOffset? target = global::DripSharp.Runtime.JavaCompat.CalendarInstance(utc);
target = global::DripSharp.Runtime.JavaCompat.CalendarSet(target, 2010, 5, 18, 10, 23, 22);
target = global::DripSharp.Runtime.JavaCompat.CalendarSet(target, 14, 0);
global::DripSharp.Testing.JavaAssertions.Equal(target, created, null);
}

internal virtual void testPostTable() {
global::DripSharp.PdfCarton.Fonts.Ttf.TrueTypeFont font;
using (global::System.IO.Stream @is = global::DripSharp.PdfCarton.Tests.Support.ResourceStream(typeof(global::DripSharp.PdfCarton.Fonts.Ttf.TestTTFParser), global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox", "/ttf/LiberationSans-Regular.ttf"))) {
global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser parser = new global::DripSharp.PdfCarton.Fonts.Ttf.TTFParser();
font = parser.Parse(new global::DripSharp.PdfCarton.IO.RandomAccessReadBuffer(@is));
}
global::DripSharp.PdfCarton.Fonts.Ttf.CmapTable cmapTable = font.GetCmap();
global::DripSharp.Testing.JavaAssertions.NotNull(cmapTable, null);
global::DripSharp.PdfCarton.Fonts.Ttf.CmapSubtable[] cmaps = cmapTable.GetCmaps();
global::DripSharp.Testing.JavaAssertions.NotNull(cmaps, null);
global::DripSharp.PdfCarton.Fonts.Ttf.CmapSubtable cmap = default!;
foreach (global::DripSharp.PdfCarton.Fonts.Ttf.CmapSubtable e in cmaps) {
if (((e.GetPlatformId() == global::DripSharp.PdfCarton.Fonts.Ttf.NameRecord.PlatformWindows) && (e.GetPlatformEncodingId() == global::DripSharp.PdfCarton.Fonts.Ttf.NameRecord.EncodingWindowsUnicodeBmp))) {
cmap = e;
break;
}
}
global::DripSharp.Testing.JavaAssertions.NotNull(cmap!, null);
global::DripSharp.PdfCarton.Fonts.Ttf.PostScriptTable post = font.GetPostScript();
global::DripSharp.Testing.JavaAssertions.NotNull(post, null);
string[] glyphNames = font.GetPostScript().GetGlyphNames();
global::DripSharp.Testing.JavaAssertions.NotNull(glyphNames, null);
int gid = cmap!.GetGlyphId(8482);
global::DripSharp.Testing.JavaAssertions.Equal("trademark", glyphNames[gid], null);
gid = cmap!.GetGlyphId(8364);
global::DripSharp.Testing.JavaAssertions.Equal("Euro", glyphNames[gid], null);
}

[Xunit.Fact]
public void __Upstream_0514455196_65f592dbc79f212b()
{
        try
        {
            this.testPostTable();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0687480448_2f5f29809b9b482e()
{
        try
        {
            this.testUTCDate();
        }
        finally
        {
        }
}
}
