// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Common.Function.Type4;

public class TestOperators {
  internal virtual void testAdd() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "5 6 add")).Pop(11).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "5 0.23 add")).Pop(5.23F).IsEmpty();
    int bigValue = (int.MaxValue - 2);
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.ExecutionContext context
      = global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(bigValue,
      " "), bigValue), " add"))).ToExecutionContext();
    float floatResult
      = global::DripSharp.Runtime.JavaCompat.Unbox((float?)(context.GetStack().Pop()));
    global::DripSharp.Testing.JavaAssertions.Equal((float)(((2 * (long)(int.MaxValue)) - 4)),
      floatResult, null, (float)(1));
    global::DripSharp.Testing.JavaAssertions.True(context.GetStack().IsEmpty, null);
  }

  internal virtual void testAbs() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-3 abs 2.1 abs -2.1 abs -7.5 abs")).Pop(7.5F).Pop(2.1F).Pop(2.1F).Pop(3).IsEmpty();
  }

  internal virtual void testAnd() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "true true and true false and")).Pop(false).Pop(true).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "99 1 and 52 7 and")).Pop(4).Pop(1).IsEmpty();
  }

  internal virtual void testAtan() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "0 1 atan")).Pop(0.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1 0 atan")).Pop(90.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-100 0 atan")).Pop(270.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "4 4 atan")).Pop(45.0F).IsEmpty();
  }

  internal virtual void testCeiling() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "3.2 ceiling -4.8 ceiling 99 ceiling")).Pop(99).Pop(-4.0F).Pop(4.0F).IsEmpty();
  }

  internal virtual void testCos() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "0 cos")).PopReal(1.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "90 cos")).PopReal(0.0F).IsEmpty();
  }

  internal virtual void testCvi() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-47.8 cvi")).Pop(-47).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "520.9 cvi")).Pop(520).IsEmpty();
  }

  internal virtual void testCvr() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-47.8 cvr")).PopReal(-47.8F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "520.9 cvr")).PopReal(520.9F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "77 cvr")).PopReal(77.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.ExecutionContext context
      = global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "77 77 cvr")).ToExecutionContext();
    global::DripSharp.Testing.JavaAssertions.True((context.GetStack().Pop() is float),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Expected a real as the result of 'cvr'"));
    global::DripSharp.Testing.JavaAssertions.True((context.GetStack().Pop() is int),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Expected an int from an integer literal"));
  }

  internal virtual void testDiv() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "3 2 div")).PopReal(1.5F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "4 2 div")).PopReal(2.0F).IsEmpty();
  }

  internal virtual void testExp() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "9 0.5 exp")).PopReal(3.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-9 -1 exp")).PopReal(-0.111111F, 1.0E-6D).IsEmpty();
  }

  internal virtual void testFloor() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "3.2 floor -4.8 floor 99 floor")).Pop(99).Pop(-5.0F).Pop(3.0F).IsEmpty();
  }

  internal virtual void testIDiv() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "3 2 idiv")).Pop(1).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "4 2 idiv")).Pop(2).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-5 2 idiv")).Pop(-2).IsEmpty();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidCastException>(()
      => global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "4.4 2 idiv")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Expected typecheck"));
  }

  internal virtual void testLn() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "10 ln")).PopReal(2.30259F, (double)(1.0E-5F)).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "100 ln")).PopReal(4.60517F, (double)(1.0E-5F)).IsEmpty();
  }

  internal virtual void testLog() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "10 log")).PopReal(1.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "100 log")).PopReal(2.0F).IsEmpty();
  }

  internal virtual void testMod() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "5 3 mod")).Pop(2).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "5 2 mod")).Pop(1).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-5 3 mod")).Pop(-2).IsEmpty();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidCastException>(()
      => global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "4.4 2 mod")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Expected typecheck"));
  }

  internal virtual void testMul() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1 2 mul")).Pop(2).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1.5 2 mul")).PopReal(3.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1.5 2.1 mul")).PopReal(3.15F, 0.001D).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat((int.MaxValue - 3),
      " 2 mul"))).PopReal((float)((2L * (int.MaxValue - 3))), 0.001D).IsEmpty();
  }

  internal virtual void testNeg() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "4.5 neg")).PopReal(-4.5F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-3 neg")).Pop(3).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat((int.MinValue + 1),
      " neg"))).Pop(int.MaxValue).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      global::DripSharp.Runtime.JavaCompat.Concat(int.MinValue,
      " neg"))).PopReal(-(float)(int.MinValue)).IsEmpty();
  }

  internal virtual void testRound() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "3.2 round")).PopReal(3.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "6.5 round")).PopReal(7.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-4.8 round")).PopReal(-5.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-6.5 round")).PopReal(-6.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "99 round")).Pop(99).IsEmpty();
  }

  internal virtual void testSin() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "0 sin")).PopReal(0.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "90 sin")).PopReal(1.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-90.0 sin")).PopReal(-1.0F).IsEmpty();
  }

  internal virtual void testSqrt() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "0 sqrt")).PopReal(0.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1 sqrt")).PopReal(1.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "4 sqrt")).PopReal(2.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "4.4 sqrt")).PopReal(2.097617F, 1.0E-6D).IsEmpty();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.ArgumentException>(()
      => global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-4.1 sqrt")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Expected rangecheck"));
  }

  internal virtual void testSub() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "5 2 sub -7.5 1 sub")).Pop(-8.5F).Pop(3).IsEmpty();
  }

  internal virtual void testTruncate() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "3.2 truncate")).PopReal(3.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "-4.8 truncate")).PopReal(-4.0F).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "99 truncate")).Pop(99).IsEmpty();
  }

  internal virtual void testBitshift() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "7 3 bitshift 142 -3 bitshift")).Pop(17).Pop(56).IsEmpty();
  }

  internal virtual void testEq() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "7 7 eq 7 6 eq 7 -7 eq true true eq false true eq 7.7 7.7 eq")).Pop(true).Pop(false).Pop(true).Pop(false).Pop(false).Pop(true).IsEmpty();
  }

  internal virtual void testGe() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "5 7 ge 7 5 ge 7 7 ge -1 2 ge")).Pop(false).Pop(true).Pop(true).Pop(false).IsEmpty();
  }

  internal virtual void testGt() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "5 7 gt 7 5 gt 7 7 gt -1 2 gt")).Pop(false).Pop(false).Pop(true).Pop(false).IsEmpty();
  }

  internal virtual void testLe() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "5 7 le 7 5 le 7 7 le -1 2 le")).Pop(true).Pop(true).Pop(false).Pop(true).IsEmpty();
  }

  internal virtual void testLt() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "5 7 lt 7 5 lt 7 7 lt -1 2 lt")).Pop(true).Pop(false).Pop(false).Pop(true).IsEmpty();
  }

  internal virtual void testNe() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "7 7 ne 7 6 ne 7 -7 ne true true ne false true ne 7.7 7.7 ne")).Pop(false).Pop(true).Pop(false).Pop(true).Pop(true).Pop(false).IsEmpty();
  }

  internal virtual void testNot() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "true not false not")).Pop(true).Pop(false).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "52 not -37 not")).Pop(37).Pop(-52).IsEmpty();
  }

  internal virtual void testOr() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "true true or true false or false false or")).Pop(false).Pop(true).Pop(true).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "17 5 or 1 1 or")).Pop(1).Pop(21).IsEmpty();
  }

  internal virtual void testXor() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "true true xor true false xor false false xor")).Pop(false).Pop(true).Pop(false).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "7 3 xor 12 3 or")).Pop(15).Pop(4);
  }

  internal virtual void testIf() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "true { 2 1 add } if")).Pop(3).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "false { 2 1 add } if")).IsEmpty();
    global::DripSharp.Testing.JavaAssertions.Throws<global::System.InvalidCastException>(()
      => global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "0 { 2 1 add } if")), global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "Need typecheck error for the '0'"));
  }

  internal virtual void testIfElse() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "true { 2 1 add } { 2 1 sub } ifelse")).Pop(3).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "false { 2 1 add } { 2 1 sub } ifelse")).Pop(1).IsEmpty();
  }

  internal virtual void testCopy() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "true 1 2 3 3 copy")).Pop(3).Pop(2).Pop(1).Pop(3).Pop(2).Pop(1).Pop(true).IsEmpty();
  }

  internal virtual void testDup() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "true 1 2 dup")).Pop(2).Pop(2).Pop(1).Pop(true).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "true dup")).Pop(true).Pop(true).IsEmpty();
  }

  internal virtual void testExch() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "true 1 exch")).Pop(true).Pop(1).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1 2.5 exch")).Pop(1).Pop(2.5F).IsEmpty();
  }

  internal virtual void testIndex() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1 2 3 4 0 index")).Pop(4).Pop(4).Pop(3).Pop(2).Pop(1).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1 2 3 4 3 index")).Pop(1).Pop(4).Pop(3).Pop(2).Pop(1).IsEmpty();
  }

  internal virtual void testPop() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1 pop 7 2 pop")).Pop(7).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1 2 3 pop pop")).Pop(1).IsEmpty();
  }

  internal virtual void testRoll() {
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1 2 3 4 5 5 -2 roll")).Pop(2).Pop(1).Pop(5).Pop(4).Pop(3).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1 2 3 4 5 5 2 roll")).Pop(3).Pop(2).Pop(1).Pop(5).Pop(4).IsEmpty();
    global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester.Create(global::DripSharp.PdfCarton.Tests.Support.TestPath("pdfbox",
      "1 2 3 3 0 roll")).Pop(3).Pop(2).Pop(1).IsEmpty();
  }

  [Xunit.Fact]
  public void __Upstream_0724998784_6fbf258b187d684e() {
    try {
      this.testAbs();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0724998831_b96e027d255c2a6b() {
    try {
      this.testAdd();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0724999141_3811fac75aaea3ad() {
    try {
      this.testAnd();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1000142674_2c1bdbf6992e8ea4() {
    try {
      this.testAtan();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3987539527_be57743d0aea665f() {
    try {
      this.testBitshift();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2415271883_312bb066aa29141c() {
    try {
      this.testCeiling();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1000197927_d94093dfeb71f3b9() {
    try {
      this.testCopy();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725001109_665fc16cd0549e3b() {
    try {
      this.testCos();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725001316_cdaa9e22e4f8b6e9() {
    try {
      this.testCvi();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725001325_d45b280d24d76cfd() {
    try {
      this.testCvr();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725001887_fed2c4bda93eedd9() {
    try {
      this.testDiv();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725002253_c4b488d2690960cc() {
    try {
      this.testDup();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1270313182_883762f5f34cf5eb() {
    try {
      this.testEq();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1000265738_45fbd4dc4aaef205() {
    try {
      this.testExch();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725003307_6de42a3ad1f40f97() {
    try {
      this.testExp();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0944044698_e90bbd2be94b917f() {
    try {
      this.testFloor();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1270313232_55a51382ccbf67c9() {
    try {
      this.testGe();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1270313247_a447a2d9fa40c1d7() {
    try {
      this.testGt();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1000335130_0817ba386136da8e() {
    try {
      this.testIDiv();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1270313295_129f8f9776dcbf57() {
    try {
      this.testIf();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3574674216_40e22c374ed5a8ac() {
    try {
      this.testIfElse();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0946863968_5d3bbe57d1fece43() {
    try {
      this.testIndex();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1270313387_e7644b9414f1d380() {
    try {
      this.testLe();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1270313396_1cc71339082575fe() {
    try {
      this.testLn();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725009746_ce09767d253a3651() {
    try {
      this.testLog();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1270313402_5c34b2f40b779706() {
    try {
      this.testLt();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725010704_35e7d3dce7e69e0b() {
    try {
      this.testMod();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725010898_1b8ba7af6b971904() {
    try {
      this.testMul();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1270313449_a31e955da03b3ae8() {
    try {
      this.testNe();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725011358_2016a278f721961b() {
    try {
      this.testNeg();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725011681_e49b5792c33bface() {
    try {
      this.testNot();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1270313493_0009e0104d3e7c45() {
    try {
      this.testOr();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725013599_f8e33360be054218() {
    try {
      this.testPop();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1000644655_0e195b3520cda754() {
    try {
      this.testRoll();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0955222044_ec06e4a5ab018eba() {
    try {
      this.testRound();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725016294_c10dd1c22f24a39b() {
    try {
      this.testSin();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1000676562_8f8863423a3a13d9() {
    try {
      this.testSqrt();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725016654_827093078e471761() {
    try {
      this.testSub();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0419841048_fbe279c3ea55ee52() {
    try {
      this.testTruncate();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0725021289_d0a4ae7a005d2ad5() {
    try {
      this.testXor();
    } finally {
    }
  }
}
