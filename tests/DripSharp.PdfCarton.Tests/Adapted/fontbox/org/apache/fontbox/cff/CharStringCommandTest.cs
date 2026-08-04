// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Cff;

public class CharStringCommandTest {
internal virtual void testKey() {
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.Key.ValueOfKey(1), global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.Key.Hstem, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.Key.ValueOfKey(12), global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.Key.Escape, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.Key.ValueOfKey(12, 0), global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.Key.Dotsection, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.Key.ValueOfKey(12, 3), global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.Key.And, null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.Key.ValueOfKey(13), global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.Key.Hsbw, null);
}

internal virtual void testCharStringCommand() {
global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand charStringCommand1 = global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.GetInstance(1);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.Type1KeyWord.Hstem, charStringCommand1.GetType1KeyWord(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.Type2KeyWord.Hstem, charStringCommand1.GetType2KeyWord(), null);
global::DripSharp.Testing.JavaAssertions.Equal("HSTEM|", charStringCommand1.ToString(), null);
global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand charStringCommand12_0 = global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.GetInstance(12, 0);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.Type1KeyWord.Dotsection, charStringCommand12_0.GetType1KeyWord(), null);
global::DripSharp.Testing.JavaAssertions.Null(charStringCommand12_0.GetType2KeyWord(), null);
global::DripSharp.Testing.JavaAssertions.Equal("DOTSECTION|", charStringCommand12_0.ToString(), null);
int[] values12_3 = new int[] { 12, 3 };
global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand charStringCommand12_3 = global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.GetInstance(values12_3);
global::DripSharp.Testing.JavaAssertions.Null(charStringCommand12_3.GetType1KeyWord(), null);
global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.Type2KeyWord.And, charStringCommand12_3.GetType2KeyWord(), null);
global::DripSharp.Testing.JavaAssertions.Equal("AND|", charStringCommand12_3.ToString(), null);
}

internal virtual void testUnknownCharStringCommand() {
global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand charStringCommandUnknown = global::DripSharp.PdfCarton.Fonts.Cff.CharStringCommand.GetInstance(99);
global::DripSharp.Testing.JavaAssertions.Equal("unknown command|", charStringCommandUnknown.ToString(), null);
}

[Xunit.Fact]
public void __Upstream_3694902226_c978f53db34a75af()
{
        try
        {
            this.testCharStringCommand();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0725008493_c5dff1c37c4f0119()
{
        try
        {
            this.testKey();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1982205388_6b55f81aa3fd295d()
{
        try
        {
            this.testUnknownCharStringCommand();
        }
        finally
        {
        }
}
}
