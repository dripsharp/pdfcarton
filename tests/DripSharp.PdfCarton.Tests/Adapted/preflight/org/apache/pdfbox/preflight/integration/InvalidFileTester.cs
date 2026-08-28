// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight.Integration;

public class InvalidFileTester {
  private static readonly global::Microsoft.Extensions.Logging.ILogger LOG
    = global::Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;

  protected internal global::System.IO.Stream OutputResult = default!;

  protected internal global::System.IO.FileInfo Path = null!;

  public InvalidFileTester(string resultKeyFile) {
    this.Before(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight", resultKeyFile));
  }

  public void Validate(global::System.IO.FileInfo path, string expectedError) {
    if ((path == default!)) {
      global::Microsoft.Extensions.Logging.LoggerExtensions.LogWarning(global::DripSharp.PdfCarton.Preflight.Integration.InvalidFileTester.LOG,
        global::DripSharp.Runtime.JavaCompat.StringValueOf("This is an empty test"));
      return;
    }
    global::DripSharp.PdfCarton.Preflight.ValidationResult result
      = global::DripSharp.PdfCarton.Preflight.Parser.PreflightParser.Validate(path);
    global::DripSharp.Testing.JavaAssertions.False(result.IsValid(),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(path,
      " : Isartor file should be invalid ("), path), ")")));
    global::DripSharp.Testing.JavaAssertions.True(!global::DripSharp.Runtime.JavaCompat.ListIsEmpty(result.GetErrorsList()),
      global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(path, " : Should find at least one error")));
    bool found = false;
    if ((expectedError != default!)) {
      foreach (global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError error__81_34 in result.GetErrorsList()) {
        if (global::DripSharp.Runtime.JavaCompat.Equals(error__81_34.GetErrorCode(),
          expectedError)) {
          found = true;
          if ((this.OutputResult == default!)) {
            break;
          }
        }
        if ((this.OutputResult != default!)) {
          string log
            = global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.ReplaceOrdinal(path.Name,
            ".pdf", ""), "#"), error__81_34.GetErrorCode()), "#"), error__81_34.GetDetails()),
            "\n");
          global::DripSharp.Runtime.JavaCompat.OutputStreamWrite(this.OutputResult,
            global::DripSharp.Runtime.JavaCompat.StringGetBytes(log,
            global::System.Text.Encoding.UTF8));
        }
      }
    }
    if (!global::DripSharp.Runtime.JavaCompat.ListIsEmpty(result.GetErrorsList())) {
      if ((expectedError == default!)) {
        global::Microsoft.Extensions.Logging.LoggerExtensions.LogInformation(global::DripSharp.PdfCarton.Preflight.Integration.InvalidFileTester.LOG,
          global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("File invalid as expected (no expected code) :",
          this.Path.FullName)));
      } else {
        if (!found) {
          global::System.Text.StringBuilder message = new global::System.Text.StringBuilder(100);
          message.Append(global::DripSharp.Runtime.JavaCompat.StringValueOf(path)).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
            " : Invalid error code returned. Expected "));
          message.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
            expectedError)).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
            ", found "));
          foreach (global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError error__112_38 in result.GetErrorsList()) {
            message.Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
              error__112_38.GetErrorCode())).Append(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
              " "));
          }
          global::DripSharp.Testing.JavaAssertions.Fail("Assertion failed.");
        }
      }
    } else {
      global::DripSharp.Testing.JavaAssertions.Equal(global::DripSharp.Runtime.JavaCompat.Concat(path,
        " : Invalid error code returned."), expectedError,
        global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.Runtime.JavaCompat.ListGet(result.GetErrorsList(), 0).GetErrorCode()));
    }
  }

  public virtual void Before(string resultKeyFile) {
    string irp
      = global::DripSharp.Runtime.JavaCompat.GetProperty(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      resultKeyFile));
    if ((irp == default!)) {
      this.OutputResult = global::DripSharp.PdfCarton.Tests.Support.ErrorStream;
    } else {
      this.OutputResult
        = global::DripSharp.Runtime.JavaCompat.OpenFileOutput(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        irp));
    }
  }

  public virtual void After() {
    global::DripSharp.PdfCarton.Tests.Support.CloseQuietly(this.OutputResult);
  }
}
