// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline;

public class PDOutlineItemTest {
private global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem root = null!;

private global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem first = null!;

private global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem second = null!;

private global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem newSibling = null!;

internal virtual void setUp() {
this.root = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
this.first = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
this.second = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
this.root.AddLast(this.first);
this.root.AddLast(this.second);
this.newSibling = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
this.newSibling.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
this.newSibling.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
}

internal virtual void insertSiblingAfter_OpenChildToOpenParent() {
this.newSibling.OpenNode();
this.root.OpenNode();
global::DripSharp.Testing.JavaAssertions.Equal(2, this.root.GetOpenCount(), null);
this.first.InsertSiblingAfter(this.newSibling);
global::DripSharp.Testing.JavaAssertions.Equal(this.first.GetNextSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(this.second.GetPreviousSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(5, this.root.GetOpenCount(), null);
}

internal virtual void insertSiblingBefore_OpenChildToOpenParent() {
this.newSibling.OpenNode();
this.root.OpenNode();
global::DripSharp.Testing.JavaAssertions.Equal(2, this.root.GetOpenCount(), null);
this.second.InsertSiblingBefore(this.newSibling);
global::DripSharp.Testing.JavaAssertions.Equal(this.first.GetNextSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(this.second.GetPreviousSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(5, this.root.GetOpenCount(), null);
}

internal virtual void insertSiblingAfter_OpenChildToClosedParent() {
this.newSibling.OpenNode();
global::DripSharp.Testing.JavaAssertions.Equal(-2, this.root.GetOpenCount(), null);
this.first.InsertSiblingAfter(this.newSibling);
global::DripSharp.Testing.JavaAssertions.Equal(this.first.GetNextSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(this.second.GetPreviousSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(-5, this.root.GetOpenCount(), null);
}

internal virtual void insertSiblingBefore_OpenChildToClosedParent() {
this.newSibling.OpenNode();
global::DripSharp.Testing.JavaAssertions.Equal(-2, this.root.GetOpenCount(), null);
this.second.InsertSiblingBefore(this.newSibling);
global::DripSharp.Testing.JavaAssertions.Equal(this.first.GetNextSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(this.second.GetPreviousSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(-5, this.root.GetOpenCount(), null);
}

internal virtual void insertSiblingAfter_ClosedChildToOpenParent() {
this.root.OpenNode();
global::DripSharp.Testing.JavaAssertions.Equal(2, this.root.GetOpenCount(), null);
this.first.InsertSiblingAfter(this.newSibling);
global::DripSharp.Testing.JavaAssertions.Equal(this.first.GetNextSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(this.second.GetPreviousSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(3, this.root.GetOpenCount(), null);
}

internal virtual void insertSiblingBefore_ClosedChildToOpenParent() {
this.root.OpenNode();
global::DripSharp.Testing.JavaAssertions.Equal(2, this.root.GetOpenCount(), null);
this.second.InsertSiblingBefore(this.newSibling);
global::DripSharp.Testing.JavaAssertions.Equal(this.first.GetNextSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(this.second.GetPreviousSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(3, this.root.GetOpenCount(), null);
}

internal virtual void insertSiblingAfter_ClosedChildToClosedParent() {
global::DripSharp.Testing.JavaAssertions.Equal(-2, this.root.GetOpenCount(), null);
this.first.InsertSiblingAfter(this.newSibling);
global::DripSharp.Testing.JavaAssertions.Equal(this.first.GetNextSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(this.second.GetPreviousSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(-3, this.root.GetOpenCount(), null);
}

internal virtual void insertSiblingBefore_ClosedChildToClosedParent() {
global::DripSharp.Testing.JavaAssertions.Equal(-2, this.root.GetOpenCount(), null);
this.second.InsertSiblingBefore(this.newSibling);
global::DripSharp.Testing.JavaAssertions.Equal(this.first.GetNextSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(this.second.GetPreviousSibling(), this.newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(-3, this.root.GetOpenCount(), null);
}

internal virtual void insertSiblingTop() {
global::DripSharp.Testing.JavaAssertions.Equal(this.root.GetFirstChild(), this.first, null);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem newSibling = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
this.first.InsertSiblingBefore(newSibling);
global::DripSharp.Testing.JavaAssertions.Equal(this.first.GetPreviousSibling(), newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(this.root.GetFirstChild(), newSibling, null);
}

internal virtual void insertSiblingTopNoParent() {
global::DripSharp.Testing.JavaAssertions.Equal(this.root.GetFirstChild(), this.first, null);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem newSibling = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
this.root.InsertSiblingBefore(newSibling);
global::DripSharp.Testing.JavaAssertions.Equal(this.root.GetPreviousSibling(), newSibling, null);
}

internal virtual void insertSiblingBottom() {
global::DripSharp.Testing.JavaAssertions.Equal(this.root.GetLastChild(), this.second, null);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem newSibling = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
this.second.InsertSiblingAfter(newSibling);
global::DripSharp.Testing.JavaAssertions.Equal(this.second.GetNextSibling(), newSibling, null);
global::DripSharp.Testing.JavaAssertions.Equal(this.root.GetLastChild(), newSibling, null);
}

internal virtual void insertSiblingBottomNoParent() {
global::DripSharp.Testing.JavaAssertions.Equal(this.root.GetLastChild(), this.second, null);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem newSibling = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
this.root.InsertSiblingAfter(newSibling);
global::DripSharp.Testing.JavaAssertions.Equal(this.root.GetNextSibling(), newSibling, null);
}

internal virtual void cannotInsertSiblingBeforeAList() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.InsertSiblingAfter(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.InsertSiblingAfter(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => this.root.InsertSiblingBefore(child), null);
}

internal virtual void cannotInsertSiblingAfterAList() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.InsertSiblingAfter(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.InsertSiblingAfter(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => this.root.InsertSiblingAfter(child), null);
}

[Xunit.Fact]
public void __Upstream_2259716681_a348b7c1a6c12663()
{
        this.setUp();
        try
        {
            this.cannotInsertSiblingAfterAList();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0533712634_9003401d8d3b37ca()
{
        this.setUp();
        try
        {
            this.cannotInsertSiblingBeforeAList();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2892900021_4623ecb9c6608d6d()
{
        this.setUp();
        try
        {
            this.insertSiblingAfter_ClosedChildToClosedParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3941933267_10febf76233b6048()
{
        this.setUp();
        try
        {
            this.insertSiblingAfter_ClosedChildToOpenParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0024233495_5aacb0528b05f101()
{
        this.setUp();
        try
        {
            this.insertSiblingAfter_OpenChildToClosedParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3518836917_92b2f68fb733494e()
{
        this.setUp();
        try
        {
            this.insertSiblingAfter_OpenChildToOpenParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2446638986_8e4b340a91539cfc()
{
        this.setUp();
        try
        {
            this.insertSiblingBefore_ClosedChildToClosedParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2842028776_a8234c4f9c660182()
{
        this.setUp();
        try
        {
            this.insertSiblingBefore_ClosedChildToOpenParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3219296300_3feb51de1edf43c5()
{
        this.setUp();
        try
        {
            this.insertSiblingBefore_OpenChildToClosedParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3969088522_5fea060c1b3795eb()
{
        this.setUp();
        try
        {
            this.insertSiblingBefore_OpenChildToOpenParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2783475028_be560c283b96f79b()
{
        this.setUp();
        try
        {
            this.insertSiblingBottom();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1335309119_a992f4ceda7ad85f()
{
        this.setUp();
        try
        {
            this.insertSiblingBottomNoParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3905674956_b6717cd8c4a463a2()
{
        this.setUp();
        try
        {
            this.insertSiblingTop();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2434114743_eab58af05d7c80e1()
{
        this.setUp();
        try
        {
            this.insertSiblingTopNoParent();
        }
        finally
        {
        }
}
}
