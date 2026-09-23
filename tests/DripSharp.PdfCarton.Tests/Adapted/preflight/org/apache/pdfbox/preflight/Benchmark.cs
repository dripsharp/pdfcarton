// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Preflight;

public class Benchmark {
  public static void Main(string[] args) {
    if ((args.Length < 3)) {
      global::DripSharp.PdfCarton.Tests.Support.ErrorStream.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        "Usage : Benchmark loop resultFile <file1 ... filen|dir>"));
      global::System.Environment.Exit(255);
    }
    int loop
      = global::DripSharp.Runtime.JavaCompat.ParseInt(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      args[0]), 10);
    global::System.IO.StreamWriter resFile
      = global::DripSharp.PdfCarton.Tests.Support.NewFileWriter(global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      args[1])));
    global::System.Collections.Generic.IList<global::DripSharp.Runtime.JavaFile> lfd
      = new global::System.Collections.Generic.List<global::DripSharp.Runtime.JavaFile>();
    for (int i__55_18 = 2; (i__55_18 < args.Length); ++i__55_18) {
      global::DripSharp.Runtime.JavaFile fi
        = global::DripSharp.PdfCarton.Tests.Support.TestFile(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        args[i__55_18]));
      if (global::DripSharp.Runtime.JavaCompat.FileIsDirectory(fi)) {
        global::System.Collections.Generic.ICollection<global::DripSharp.Runtime.JavaFile> cf
          = global::DripSharp.PdfCarton.Tests.Support.ListFiles(fi, (string[])default!, true);
        global::DripSharp.Runtime.JavaCompat.AddAll(lfd, cf);
      } else {
        global::DripSharp.Runtime.JavaCompat.Add(lfd, fi);
      }
    }
    global::DripSharp.Runtime.JavaSimpleDateFormat sdf
      = new global::DripSharp.Runtime.JavaSimpleDateFormat(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      "dd/MM/yyyy hh:mm:ss.Z"), global::System.Globalization.CultureInfo.InvariantCulture);
    long startGTime = global::System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    int size = global::DripSharp.Runtime.JavaCompat.CollectionCount(lfd);
    for (int i__74_18 = 0; (i__74_18 < loop); i__74_18++) {
      global::DripSharp.Runtime.JavaFile file = global::DripSharp.Runtime.JavaCompat.ListGet(lfd,
        (i__74_18 % size));
      long startLTime = global::System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
      global::DripSharp.PdfCarton.Preflight.ValidationResult result
        = global::DripSharp.Runtime.JavaFileBridge.Call<global::DripSharp.PdfCarton.Preflight.ValidationResult>(typeof(global::DripSharp.PdfCarton.Preflight.Parser.PreflightParser),
        "Validate", new global::System.Type[] { typeof(global::System.IO.FileInfo) },
        new object[] { file });
      if (!(result.IsValid())) {
        resFile.Write(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
          global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.FileGetAbsolutePath(file),
          " isn't PDF/A\n")));
        foreach (global::DripSharp.PdfCarton.Preflight.ValidationResult.ValidationError error in result.GetErrorsList()) {
          resFile.Write(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
            global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(error.GetErrorCode(),
            " : "), error.GetDetails()), "\n")));
        }
      }
      long endLTime = global::System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
      resFile.Write(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
        global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(file.Name,
        " (ms) : "), (endLTime - startLTime)), "\n")));
      resFile.Flush();
    }
    long endGTime = global::System.DateTimeOffset.UtcNow.ToUnixTimeMilliseconds();
    resFile.Write(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Start : ",
      sdf.Format(global::System.DateTimeOffset.FromUnixTimeMilliseconds(startGTime))), "\n")));
    resFile.Write(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("End : ",
      sdf.Format(global::System.DateTimeOffset.FromUnixTimeMilliseconds(endGTime))), "\n")));
    resFile.Write(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Duration (ms) : ",
      (endGTime - startGTime)), "\n")));
    resFile.Write(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("Average (ms) : ",
      (int)(((endGTime - startGTime) / loop))), "\n")));
    global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat("Start : ",
      sdf.Format(global::System.DateTimeOffset.FromUnixTimeMilliseconds(startGTime)))));
    global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat("End : ",
      sdf.Format(global::System.DateTimeOffset.FromUnixTimeMilliseconds(endGTime)))));
    global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat("Duration (ms) : ", (endGTime - startGTime))));
    global::DripSharp.Runtime.JavaCompat.@out.WriteLine(global::DripSharp.PdfCarton.Tests.Support.TestPath("preflight",
      global::DripSharp.Runtime.JavaCompat.Concat("Average (ms) : ", (int)(((endGTime - startGTime)
      / loop)))));
    resFile.Flush();
    global::DripSharp.PdfCarton.Tests.Support.CloseQuietly(resFile);
  }
}
