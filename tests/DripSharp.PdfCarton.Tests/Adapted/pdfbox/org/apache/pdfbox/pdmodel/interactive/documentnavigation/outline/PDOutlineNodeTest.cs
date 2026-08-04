// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline;

public class PDOutlineNodeTest {
private global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem root = null!;

internal virtual void setUp() {
this.root = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
}

internal virtual void getParent() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
this.root.AddLast(child);
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDDocumentOutline outline = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDDocumentOutline();
outline.AddLast(this.root);
global::DripSharp.Testing.JavaAssertions.Null(outline.getParent(), null);
global::DripSharp.Testing.JavaAssertions.Equal(outline, this.root.getParent(), null);
global::DripSharp.Testing.JavaAssertions.Equal(this.root, child.getParent(), null);
}

internal virtual void nullLastChild() {
global::DripSharp.Testing.JavaAssertions.Null(this.root.GetLastChild(), null);
}

internal virtual void nullFirstChild() {
global::DripSharp.Testing.JavaAssertions.Null(this.root.GetFirstChild(), null);
}

internal virtual void openAlreadyOpenedRootNode() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
global::DripSharp.Testing.JavaAssertions.Equal(0, this.root.GetOpenCount(), null);
this.root.AddLast(child);
this.root.OpenNode();
global::DripSharp.Testing.JavaAssertions.True(this.root.IsNodeOpen(), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, this.root.GetOpenCount(), null);
this.root.OpenNode();
global::DripSharp.Testing.JavaAssertions.True(this.root.IsNodeOpen(), null);
global::DripSharp.Testing.JavaAssertions.Equal(1, this.root.GetOpenCount(), null);
}

internal virtual void closeAlreadyClosedRootNode() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
global::DripSharp.Testing.JavaAssertions.Equal(0, this.root.GetOpenCount(), null);
this.root.AddLast(child);
this.root.OpenNode();
this.root.CloseNode();
global::DripSharp.Testing.JavaAssertions.False(this.root.IsNodeOpen(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-1, this.root.GetOpenCount(), null);
this.root.CloseNode();
global::DripSharp.Testing.JavaAssertions.False(this.root.IsNodeOpen(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-1, this.root.GetOpenCount(), null);
}

internal virtual void openLeaf() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
this.root.AddLast(child);
child.OpenNode();
global::DripSharp.Testing.JavaAssertions.False(child.IsNodeOpen(), null);
}

internal virtual void nodeClosedByDefault() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
this.root.AddLast(child);
global::DripSharp.Testing.JavaAssertions.False(this.root.IsNodeOpen(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-1, this.root.GetOpenCount(), null);
}

internal virtual void closeNodeWithOpendParent() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.OpenNode();
this.root.AddLast(child);
this.root.OpenNode();
global::DripSharp.Testing.JavaAssertions.Equal(3, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, child.GetOpenCount(), null);
child.CloseNode();
global::DripSharp.Testing.JavaAssertions.Equal(1, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-2, child.GetOpenCount(), null);
}

internal virtual void closeNodeWithClosedParent() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.OpenNode();
this.root.AddLast(child);
global::DripSharp.Testing.JavaAssertions.Equal(-3, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, child.GetOpenCount(), null);
child.CloseNode();
global::DripSharp.Testing.JavaAssertions.Equal(-1, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-2, child.GetOpenCount(), null);
}

internal virtual void openNodeWithOpendParent() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
this.root.AddLast(child);
this.root.OpenNode();
global::DripSharp.Testing.JavaAssertions.Equal(1, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-2, child.GetOpenCount(), null);
child.OpenNode();
global::DripSharp.Testing.JavaAssertions.Equal(3, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, child.GetOpenCount(), null);
}

internal virtual void openNodeWithClosedParent() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
this.root.AddLast(child);
global::DripSharp.Testing.JavaAssertions.Equal(-1, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-2, child.GetOpenCount(), null);
child.OpenNode();
global::DripSharp.Testing.JavaAssertions.Equal(-3, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, child.GetOpenCount(), null);
}

internal virtual void addLastSingleChild() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
this.root.AddLast(child);
global::DripSharp.Testing.JavaAssertions.Equal(child, this.root.GetFirstChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(child, this.root.GetLastChild(), null);
}

internal virtual void addFirstSingleChild() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
this.root.AddFirst(child);
global::DripSharp.Testing.JavaAssertions.Equal(child, this.root.GetFirstChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(child, this.root.GetLastChild(), null);
}

internal virtual void addLastOpenChildToOpenParent() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.OpenNode();
this.root.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
this.root.OpenNode();
global::DripSharp.Testing.JavaAssertions.Equal(1, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, child.GetOpenCount(), null);
this.root.AddLast(child);
global::DripSharp.Testing.JavaAssertions.NotEqual(child, this.root.GetFirstChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(child, this.root.GetLastChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(4, this.root.GetOpenCount(), null);
}

internal virtual void addFirstOpenChildToOpenParent() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.AddFirst(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.AddFirst(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.OpenNode();
this.root.AddFirst(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
this.root.OpenNode();
global::DripSharp.Testing.JavaAssertions.Equal(1, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, child.GetOpenCount(), null);
this.root.AddFirst(child);
global::DripSharp.Testing.JavaAssertions.NotEqual(child, this.root.GetLastChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(child, this.root.GetFirstChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(4, this.root.GetOpenCount(), null);
}

internal virtual void addLastOpenChildToClosedParent() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.OpenNode();
this.root.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
global::DripSharp.Testing.JavaAssertions.Equal(-1, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, child.GetOpenCount(), null);
this.root.AddLast(child);
global::DripSharp.Testing.JavaAssertions.NotEqual(child, this.root.GetFirstChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(child, this.root.GetLastChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-4, this.root.GetOpenCount(), null);
}

internal virtual void addFirstOpenChildToClosedParent() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.AddFirst(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.AddFirst(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.OpenNode();
this.root.AddFirst(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
global::DripSharp.Testing.JavaAssertions.Equal(-1, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, child.GetOpenCount(), null);
this.root.AddFirst(child);
global::DripSharp.Testing.JavaAssertions.NotEqual(child, this.root.GetLastChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(child, this.root.GetFirstChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-4, this.root.GetOpenCount(), null);
}

internal virtual void addLastClosedChildToOpenParent() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
this.root.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
this.root.OpenNode();
global::DripSharp.Testing.JavaAssertions.Equal(1, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-2, child.GetOpenCount(), null);
this.root.AddLast(child);
global::DripSharp.Testing.JavaAssertions.NotEqual(child, this.root.GetFirstChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(child, this.root.GetLastChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, this.root.GetOpenCount(), null);
}

internal virtual void addFirstClosedChildToOpenParent() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.AddFirst(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.AddFirst(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
this.root.AddFirst(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
this.root.OpenNode();
global::DripSharp.Testing.JavaAssertions.Equal(1, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-2, child.GetOpenCount(), null);
this.root.AddFirst(child);
global::DripSharp.Testing.JavaAssertions.NotEqual(child, this.root.GetLastChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(child, this.root.GetFirstChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(2, this.root.GetOpenCount(), null);
}

internal virtual void addLastClosedChildToClosedParent() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
this.root.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
global::DripSharp.Testing.JavaAssertions.Equal(-1, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-2, child.GetOpenCount(), null);
this.root.AddLast(child);
global::DripSharp.Testing.JavaAssertions.NotEqual(child, this.root.GetFirstChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(child, this.root.GetLastChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-2, this.root.GetOpenCount(), null);
}

internal virtual void addFirstClosedChildToClosedParent() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.AddFirst(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.AddFirst(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
this.root.AddFirst(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
global::DripSharp.Testing.JavaAssertions.Equal(-1, this.root.GetOpenCount(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-2, child.GetOpenCount(), null);
this.root.AddFirst(child);
global::DripSharp.Testing.JavaAssertions.NotEqual(child, this.root.GetLastChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(child, this.root.GetFirstChild(), null);
global::DripSharp.Testing.JavaAssertions.Equal(-2, this.root.GetOpenCount(), null);
}

internal virtual void cannotAddLastAList() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.InsertSiblingAfter(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.InsertSiblingAfter(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => this.root.AddLast(child), null);
}

internal virtual void cannotAddFirstAList() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem child = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
child.InsertSiblingAfter(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
child.InsertSiblingAfter(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(() => this.root.AddFirst(child), null);
}

internal virtual void equalsNode() {
this.root.AddFirst(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
global::DripSharp.Testing.JavaAssertions.Equal(this.root.GetFirstChild(), this.root.GetLastChild(), null);
}

internal virtual void iterator() {
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem first = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
this.root.AddFirst(first);
this.root.AddLast(new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem());
global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem second = new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem();
first.InsertSiblingAfter(second);
int counter = 0;
foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem current in this.root.Children()) {
counter++;
}
global::DripSharp.Testing.JavaAssertions.Equal(3, counter, null);
}

internal virtual void iteratorNoChildre() {
int counter = 0;
foreach (global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem current in new global::DripSharp.PdfCarton.Pdmodel.Interactive.Documentnavigation.Outline.PDOutlineItem().Children()) {
counter++;
}
global::DripSharp.Testing.JavaAssertions.Equal(0, counter, null);
}

internal virtual void openNodeAndAppend() {}

[Xunit.Fact]
public void __Upstream_2494420658_49f19bbb73ebee83()
{
        this.setUp();
        try
        {
            this.addFirstClosedChildToClosedParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3664423952_424cc493e705e09c()
{
        this.setUp();
        try
        {
            this.addFirstClosedChildToOpenParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4041691476_749918808a8c5c71()
{
        this.setUp();
        try
        {
            this.addFirstOpenChildToClosedParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1453745970_5f475492e01548b6()
{
        this.setUp();
        try
        {
            this.addFirstOpenChildToOpenParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1921486757_73fcc40c00fc3131()
{
        this.setUp();
        try
        {
            this.addFirstSingleChild();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3047987050_6e85c435d7507aa6()
{
        this.setUp();
        try
        {
            this.addLastClosedChildToClosedParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2266118856_298e248cd84b2db9()
{
        this.setUp();
        try
        {
            this.addLastClosedChildToOpenParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2643386380_b03f6ddaaca34c63()
{
        this.setUp();
        try
        {
            this.addLastOpenChildToClosedParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1590838250_1cf5e07c018c3a67()
{
        this.setUp();
        try
        {
            this.addLastOpenChildToOpenParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2026205789_70cce21e91774933()
{
        this.setUp();
        try
        {
            this.addLastSingleChild();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2381974285_47b35fd7837abaf4()
{
        this.setUp();
        try
        {
            this.cannotAddFirstAList();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0404800683_bc0b753eb1ad2301()
{
        this.setUp();
        try
        {
            this.cannotAddLastAList();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0376101616_3653a982a542a277()
{
        this.setUp();
        try
        {
            this.closeAlreadyClosedRootNode();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0757347670_8c7f0d67d5c261ea()
{
        this.setUp();
        try
        {
            this.closeNodeWithClosedParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2494335108_c6a7982d94ee2134()
{
        this.setUp();
        try
        {
            this.closeNodeWithOpendParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2535041633_f64d31cc60cd35f7()
{
        this.setUp();
        try
        {
            this.equalsNode();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2848074656_9edc4ea7c19f0018()
{
        this.setUp();
        try
        {
            this.getParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3330017390_dc2f36275d3ad55d()
{
        this.setUp();
        try
        {
            this.iterator();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_3477839488_d460eebbc0850917()
{
        this.setUp();
        try
        {
            this.iteratorNoChildre();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2252554108_d031416640866b14()
{
        this.setUp();
        try
        {
            this.nodeClosedByDefault();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_0172492083_e70105609f0df5cf()
{
        this.setUp();
        try
        {
            this.nullFirstChild();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1305952863_4979354361adfbfa()
{
        this.setUp();
        try
        {
            this.nullLastChild();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2935550939_baffeb2ec5cb09d7()
{
        this.setUp();
        try
        {
            this.openAlreadyOpenedRootNode();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1642595528_160fa72d429b2884()
{
        this.setUp();
        try
        {
            this.openLeaf();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_2649906629_9c451a10fe011422()
{
        this.setUp();
        try
        {
            this.openNodeAndAppend();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_1656561832_d6f4e2b75e1d7ee9()
{
        this.setUp();
        try
        {
            this.openNodeWithClosedParent();
        }
        finally
        {
        }
}

[Xunit.Fact]
public void __Upstream_4185910002_d6752a3762429b96()
{
        this.setUp();
        try
        {
            this.openNodeWithOpendParent();
        }
        finally
        {
        }
}
}
