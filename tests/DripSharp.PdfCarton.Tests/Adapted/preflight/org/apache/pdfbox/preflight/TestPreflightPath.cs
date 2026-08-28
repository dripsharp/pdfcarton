// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight;

public class TestPreflightPath {
  internal virtual void test() {
    global::DripSharp.PdfCarton.Preflight.PreflightPath path
      = new global::DripSharp.PdfCarton.Preflight.PreflightPath();
    global::DripSharp.Testing.JavaAssertions.True(path.IsEmpty(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(0, path.Size(), null);
    path.PushObject("a");
    global::DripSharp.Testing.JavaAssertions.Equal(1, path.Size(), null);
    global::DripSharp.Testing.JavaAssertions.False(path.IsEmpty(), null);
    int position = path.GetClosestTypePosition(typeof(string));
    global::DripSharp.Testing.JavaAssertions.Equal(0, position, null);
    path.PushObject(6);
    global::DripSharp.Testing.JavaAssertions.Equal(2, path.Size(), null);
    position = path.GetClosestTypePosition(typeof(string));
    global::DripSharp.Testing.JavaAssertions.Equal(0, position, null);
    position = path.GetClosestTypePosition(typeof(int));
    global::DripSharp.Testing.JavaAssertions.Equal(1, position, null);
    path.PushObject("b");
    global::DripSharp.Testing.JavaAssertions.Equal(3, path.Size(), null);
    position = path.GetClosestTypePosition(typeof(string));
    global::DripSharp.Testing.JavaAssertions.Equal(2, position, null);
    position = path.GetClosestTypePosition(typeof(int));
    global::DripSharp.Testing.JavaAssertions.Equal(1, position, null);
    int? i = path.GetPathElement<int>(position, typeof(int));
    global::DripSharp.Testing.JavaAssertions.Equal(6, i, null);
    object str = path.Peek();
    global::DripSharp.Testing.JavaAssertions.Equal(3, path.Size(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(typeof(string), ((object)(str)).GetType(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("b", str, null);
    str = path.Pop();
    global::DripSharp.Testing.JavaAssertions.Equal(2, path.Size(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(typeof(string), ((object)(str)).GetType(), null);
    global::DripSharp.Testing.JavaAssertions.Equal("b", str, null);
    path.Clear();
    global::DripSharp.Testing.JavaAssertions.True(path.IsEmpty(), null);
    global::DripSharp.Testing.JavaAssertions.Equal(0, path.Size(), null);
  }

  internal virtual void testPush() {
    global::DripSharp.PdfCarton.Preflight.PreflightPath path
      = new global::DripSharp.PdfCarton.Preflight.PreflightPath();
    global::DripSharp.Testing.JavaAssertions.True(path.PushObject("a"), null);
    global::DripSharp.Testing.JavaAssertions.False(path.PushObject((object)default!), null);
  }

  [Xunit.Fact]
  public void __Upstream_2151040146_8a4e305a684fda03() {
    try {
      this.test();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1000591052_b08ee89527b925d8() {
    try {
      this.testPush();
    } finally {
    }
  }
}
