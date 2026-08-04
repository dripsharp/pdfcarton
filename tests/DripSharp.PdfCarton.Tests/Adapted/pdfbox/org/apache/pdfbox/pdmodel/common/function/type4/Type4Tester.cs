// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Pdmodel.Common.Function.Type4;

public class Type4Tester {
private readonly global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.ExecutionContext context = null!;

private Type4Tester(global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.ExecutionContext ctxt) {
this.context = ctxt;
}

public static global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester Create(string text) {
global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.InstructionSequence instructions = global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.InstructionSequenceBuilder.Parse(text);
global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.ExecutionContext context = new global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.ExecutionContext(new global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Operators());
instructions.Execute(context);
return new global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester(context);
}

public virtual global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester Pop(bool expected) {
bool value = global::DripSharp.Runtime.JavaCompat.Unbox((bool?)(this.context.GetStack().Pop()));
global::DripSharp.Testing.JavaAssertions.Equal(expected, value, null);
return this;
}

public virtual global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester PopReal(float expected) {
return this.PopReal(expected, 1.0E-7D);
}

public virtual global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester PopReal(float expected, double delta) {
float value = global::DripSharp.Runtime.JavaCompat.Unbox((float?)(this.context.GetStack().Pop()));
global::DripSharp.Testing.JavaAssertions.Equal((double)(expected), (double)(value), null, delta);
return this;
}

public virtual global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester Pop(int expected) {
int value = this.context.PopInt();
global::DripSharp.Testing.JavaAssertions.Equal(expected, value, null);
return this;
}

public virtual global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester Pop(float expected) {
return this.Pop(expected, 1.0E-7D);
}

public virtual global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester Pop(float expected, double delta) {
global::System.IConvertible value = this.context.PopNumber();
global::DripSharp.Testing.JavaAssertions.Equal((double)(expected), global::System.Convert.ToDouble(value, global::System.Globalization.CultureInfo.InvariantCulture), null, delta);
return this;
}

public virtual global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.Type4Tester IsEmpty() {
global::DripSharp.Testing.JavaAssertions.True(this.context.GetStack().IsEmpty, null);
return this;
}

public virtual global::DripSharp.PdfCarton.Pdmodel.Common.Function.Type4.ExecutionContext ToExecutionContext() {
return this.context;
}
}
