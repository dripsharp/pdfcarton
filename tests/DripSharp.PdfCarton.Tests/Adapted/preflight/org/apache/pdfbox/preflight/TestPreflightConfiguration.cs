// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight;

public class TestPreflightConfiguration {
  internal virtual void testGetValidationProcess_MissingProcess() {
    global::DripSharp.PdfCarton.Preflight.PreflightConfiguration configuration
      = global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.CreatePdfA1BConfiguration();
    global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Preflight.Exception.MissingValidationProcessException>(()
      => {
        configuration.GetInstanceOfProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        "unknownProcess"));
      }, null);
  }

  internal virtual void testGetValidationProcess_MissingProcess_NoError() {
    global::DripSharp.PdfCarton.Preflight.PreflightConfiguration configuration
      = global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.CreatePdfA1BConfiguration();
    configuration.SetErrorOnMissingProcess(false);
    global::DripSharp.Testing.JavaAssertions.DoesNotThrow(() => {
        configuration.GetInstanceOfProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        "unknownProcess"));
      }, null);
  }

  internal virtual void testReplaceValidationProcess() {
    global::DripSharp.PdfCarton.Preflight.PreflightConfiguration configuration
      = global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.CreatePdfA1BConfiguration();
    string processName = "mock-process";
    configuration.ReplaceProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      processName),
      typeof(global::DripSharp.PdfCarton.Preflight.TestPreflightConfiguration.MockProcess));
    global::DripSharp.Testing.JavaAssertions.Equal(typeof(global::DripSharp.PdfCarton.Preflight.TestPreflightConfiguration.MockProcess),
      ((object)(configuration.GetInstanceOfProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      processName)))).GetType(), null);
    configuration.ReplaceProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      processName),
      typeof(global::DripSharp.PdfCarton.Preflight.TestPreflightConfiguration.MockProcess2));
    global::DripSharp.Testing.JavaAssertions.Equal(typeof(global::DripSharp.PdfCarton.Preflight.TestPreflightConfiguration.MockProcess2),
      ((object)(configuration.GetInstanceOfProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      processName)))).GetType(), null);
  }

  internal virtual void testGetValidationProcess() {
    global::DripSharp.PdfCarton.Preflight.PreflightConfiguration confg
      = global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.CreatePdfA1BConfiguration();
    global::DripSharp.PdfCarton.Preflight.Process.ValidationProcess vp
      = confg.GetInstanceOfProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.BookmarkProcess));
    global::DripSharp.Testing.JavaAssertions.NotNull(vp, null);
    global::DripSharp.Testing.JavaAssertions.True((vp is global::DripSharp.PdfCarton.Preflight.Process.BookmarkValidationProcess),
      null);
  }

  internal virtual void testGetValidationPageProcess() {
    global::DripSharp.PdfCarton.Preflight.PreflightConfiguration confg
      = global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.CreatePdfA1BConfiguration();
    global::DripSharp.PdfCarton.Preflight.Process.ValidationProcess vp
      = confg.GetInstanceOfProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.ResourcesProcess));
    global::DripSharp.Testing.JavaAssertions.NotNull(vp, null);
    global::DripSharp.Testing.JavaAssertions.True((vp is global::DripSharp.PdfCarton.Preflight.Process.Reflect.ResourcesValidationProcess),
      null);
  }

  internal virtual void testGetValidationProcess_noError() {
    global::DripSharp.PdfCarton.Preflight.PreflightConfiguration confg
      = global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.CreatePdfA1BConfiguration();
    confg.SetErrorOnMissingProcess(false);
    confg.RemoveProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.BookmarkProcess));
    global::DripSharp.PdfCarton.Preflight.Process.ValidationProcess vp
      = confg.GetInstanceOfProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.BookmarkProcess));
    global::DripSharp.Testing.JavaAssertions.NotNull(vp, null);
    global::DripSharp.Testing.JavaAssertions.True((vp is global::DripSharp.PdfCarton.Preflight.Process.EmptyValidationProcess),
      null);
  }

  internal virtual void testGetValidationPageProcess_noError() {
    global::DripSharp.PdfCarton.Preflight.PreflightConfiguration confg
      = global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.CreatePdfA1BConfiguration();
    confg.SetErrorOnMissingProcess(false);
    confg.RemovePageProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.ResourcesProcess));
    global::DripSharp.PdfCarton.Preflight.Process.ValidationProcess vp
      = confg.GetInstanceOfProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.ResourcesProcess));
    global::DripSharp.Testing.JavaAssertions.NotNull(vp, null);
    global::DripSharp.Testing.JavaAssertions.True((vp is global::DripSharp.PdfCarton.Preflight.Process.EmptyValidationProcess),
      null);
  }

  internal virtual void testGetMissingValidationProcess() {
    global::DripSharp.PdfCarton.Preflight.PreflightConfiguration confg
      = global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.CreatePdfA1BConfiguration();
    confg.RemoveProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.BookmarkProcess));
    global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Preflight.Exception.ValidationException>(()
      => {
        confg.GetInstanceOfProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.BookmarkProcess));
      }, null);
  }

  internal virtual void testGetMissingValidationPageProcess() {
    global::DripSharp.PdfCarton.Preflight.PreflightConfiguration confg
      = global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.CreatePdfA1BConfiguration();
    confg.RemovePageProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.ResourcesProcess));
    global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Preflight.Exception.ValidationException>(()
      => {
        confg.GetInstanceOfProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.ResourcesProcess));
      }, null);
  }

  internal virtual void testGetMissingValidationProcess2() {
    global::DripSharp.PdfCarton.Preflight.PreflightConfiguration confg
      = global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.CreatePdfA1BConfiguration();
    confg.ReplaceProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.BookmarkProcess),
      (global::System.Type)default!);
    global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Preflight.Exception.ValidationException>(()
      => {
        confg.GetInstanceOfProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.BookmarkProcess));
      }, null);
  }

  internal virtual void testGetMissingValidationPageProcess2() {
    global::DripSharp.PdfCarton.Preflight.PreflightConfiguration confg
      = global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.CreatePdfA1BConfiguration();
    confg.ReplacePageProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.ResourcesProcess),
      (global::System.Type)default!);
    global::DripSharp.Testing.JavaAssertions.Throws<global::DripSharp.PdfCarton.Preflight.Exception.ValidationException>(()
      => {
        confg.GetInstanceOfProcess(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.PdfCarton.Preflight.PreflightConfiguration.ResourcesProcess));
      }, null);
  }

  internal class MockProcess : global::DripSharp.PdfCarton.Preflight.Process.ValidationProcess {
    public virtual void Validate(global::DripSharp.PdfCarton.Preflight.PreflightContext ctx) {}
  }

  internal class MockProcess2
  : global::DripSharp.PdfCarton.Preflight.TestPreflightConfiguration.MockProcess {
    public override void Validate(global::DripSharp.PdfCarton.Preflight.PreflightContext ctx) {}
  }

  [Xunit.Fact]
  public void __Upstream_1101070437_7a3e822ee20bc303() {
    try {
      this.testGetMissingValidationPageProcess();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_4068412525_e2953a84275f774e() {
    try {
      this.testGetMissingValidationPageProcess2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1417905268_a72d9052ca76e864() {
    try {
      this.testGetMissingValidationProcess();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1005390398_b0196440235f28ea() {
    try {
      this.testGetMissingValidationProcess2();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2463355811_3da431647c1c9bdc() {
    try {
      this.testGetValidationPageProcess();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3888933931_83092b4010808552() {
    try {
      this.testGetValidationPageProcess_noError();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2821564082_b2c4505736914ad3() {
    try {
      this.testGetValidationProcess();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_1020071798_1d557acb1776beda() {
    try {
      this.testGetValidationProcess_MissingProcess();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_3858414814_1acb4e9b433a0d18() {
    try {
      this.testGetValidationProcess_MissingProcess_NoError();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_2879766586_45eca57255400ac6() {
    try {
      this.testGetValidationProcess_noError();
    } finally {
    }
  }

  [Xunit.Fact]
  public void __Upstream_0342147604_5060a631bb4ca631() {
    try {
      this.testReplaceValidationProcess();
    } finally {
    }
  }
}
