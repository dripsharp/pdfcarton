// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline;

public class PDOutlineItemIteratorTest {
internal virtual void singleItem() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem first = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItemIterator iterator = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItemIterator(first);
global::DripSharp.Testing.JavaAssertions.True(iterator.HasNext(), null);
global::DripSharp.Testing.JavaAssertions.Equal(first, iterator.Next(), null);
global::DripSharp.Testing.JavaAssertions.False(iterator.HasNext(), null);
}

internal virtual void multipleItem() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem first = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem second = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
first.setNextSibling(second);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItemIterator iterator = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItemIterator(first);
global::DripSharp.Testing.JavaAssertions.True(iterator.HasNext(), null);
global::DripSharp.Testing.JavaAssertions.Equal(first, iterator.Next(), null);
global::DripSharp.Testing.JavaAssertions.True(iterator.HasNext(), null);
global::DripSharp.Testing.JavaAssertions.Equal(second, iterator.Next(), null);
global::DripSharp.Testing.JavaAssertions.False(iterator.HasNext(), null);
}

internal virtual void removeUnsupported() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItemIterator pdOutlineItemIterator = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItemIterator(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
global::DripSharp.Testing.JavaAssertions.Throws<global::System.NotSupportedException>(pdOutlineItemIterator.Remove, null);
}

internal virtual void noChildren() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItemIterator iterator = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItemIterator((global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem)default!);
global::DripSharp.Testing.JavaAssertions.False(iterator.HasNext(), null);
}

[Xunit.Fact]
public void __Upstream_2402946371_a23b5ecc557ca56a()
{
        try
        {
            this.multipleItem();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0671055584_4ea007950a9cb485()
{
        try
        {
            this.noChildren();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4220720913_7c3f009233b88506()
{
        try
        {
            this.removeUnsupported();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3060797307_f419d86face2c6b4()
{
        try
        {
            this.singleItem();
        }
        finally
        {
        }
}
}
