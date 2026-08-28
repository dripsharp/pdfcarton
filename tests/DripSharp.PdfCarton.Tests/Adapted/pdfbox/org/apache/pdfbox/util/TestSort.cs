// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Util;

public class TestSort {
  internal virtual void doTest<T>(T[] input, T[] expected) where T : global::System.IComparable<T> {
    global::System.Collections.Generic.IList<T> list
      = global::DripSharp.Runtime.JavaCompat.AsList<T>(input);
    global::DripSharp.PdfCarton.Util.IterativeMergeSort.Sort(list,
      global::System.Collections.Generic.Comparer<T>.Create((value0, value1)
      => value0.CompareTo(value1)));
    global::DripSharp.Testing.JavaAssertions.True(global::DripSharp.Testing.JavaAssertions.DeepEqual(global::DripSharp.Runtime.JavaCompat.CollectionToArray(list,
      new object[input.Length]), expected), null);
  }

  internal virtual void testSort() { {
      int[] input__49_23 = new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
      int[] expected__50_23 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      this.doTest<int>(input__49_23, expected__50_23);
    } {
      int[] input__55_23 = new int[] { 4, 3, 2, 1, 9, 8, 7, 6, 5 };
      int[] expected__56_23 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      this.doTest<int>(input__55_23, expected__56_23);
    } {
      int[] input__61_23 = new int[] {  };
      int[] expected__62_23 = new int[] {  };
      this.doTest<int>(input__61_23, expected__62_23);
    } {
      int[] input__67_23 = new int[] { 5 };
      int[] expected__68_23 = new int[] { 5 };
      this.doTest<int>(input__67_23, expected__68_23);
    } {
      int[] input__73_23 = new int[] { 5, 6 };
      int[] expected__74_23 = new int[] { 5, 6 };
      this.doTest<int>(input__73_23, expected__74_23);
    } {
      int[] input__79_23 = new int[] { 6, 5 };
      int[] expected__80_23 = new int[] { 5, 6 };
      this.doTest<int>(input__79_23, expected__80_23);
    }
    global::DripSharp.PdfCarton.Tests.JavaRandom rnd
      = new global::DripSharp.PdfCarton.Tests.JavaRandom((long)(12345));
    for (int cnt = 0; (cnt < 100); ++cnt) {
      int len = (rnd.NextInt(20000) + 2);
      int[] input__88_23 = new int[len];
      int[] expected__89_23 = new int[len];
      for (int i = 0; (i < len); ++i) {
        expected__89_23[i] = (input__88_23[i] = rnd.NextInt((rnd.NextInt(100) + 1)));
      }
      global::System.Array.Sort(expected__89_23);
      this.doTest<int>(input__88_23, expected__89_23);
    }
  }

  [Xunit.Fact]
  public void __Upstream_1000674640_c8811ce803e76a9d() {
    try {
      this.testSort();
    } finally {
    }
  }
}
