// SPDX-FileCopyrightText: Apache PDFBox contributors
// SPDX-License-Identifier: Apache-2.0

#nullable disable
namespace DripSharp.PdfCarton.Fonts.Ttf.Gsub;

public class GsubWorkerForAalt : global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorker {
  private static readonly global::Microsoft.Extensions.Logging.ILogger LOG
    = global::Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;

  private static readonly global::System.Collections.Generic.IList<string> FEATURES_IN_ORDER
    = global::DripSharp.Runtime.JavaCompat.AsList<string>("aalt");

  private readonly global::DripSharp.PdfCarton.Fonts.Ttf.Model.GsubData gsubData = null!;

  internal GsubWorkerForAalt(global::DripSharp.PdfCarton.Fonts.Ttf.Model.GsubData gsubData) {
    this.gsubData = gsubData;
  }

  public virtual global::System.Collections.Generic.IList<int> ApplyTransforms(global::System.Collections.Generic.IList<int> originalGlyphIds) {
    global::System.Collections.Generic.IList<int> intermediateGlyphsFromGsub = originalGlyphIds;
    foreach (string feature in global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForAalt.FEATURES_IN_ORDER) {
      if (!(this.gsubData.IsFeatureSupported(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        feature)))) {
        global::Microsoft.Extensions.Logging.LoggerExtensions.LogDebug(global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForAalt.LOG,
          global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("the feature ",
          feature), " was not found")));
        continue;
      }
      global::Microsoft.Extensions.Logging.LoggerExtensions.LogDebug(global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForAalt.LOG,
        global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat("applying the feature ",
        feature)));
      global::DripSharp.PdfCarton.Fonts.Ttf.Model.ScriptFeature scriptFeature
        = this.gsubData.GetFeature(global::DripSharp.PdfCarton.Tests.Support.TestPath("fontbox",
        feature));
      intermediateGlyphsFromGsub = this.applyGsubFeature(scriptFeature, intermediateGlyphsFromGsub);
    }
    return global::DripSharp.Runtime.JavaCompat.UnmodifiableList(intermediateGlyphsFromGsub);
  }

  private global::System.Collections.Generic.IList<int> applyGsubFeature(global::DripSharp.PdfCarton.Fonts.Ttf.Model.ScriptFeature scriptFeature,
    global::System.Collections.Generic.IList<int> originalGlyphs) {
    if (global::DripSharp.Runtime.JavaCompat.CollectionIsEmpty(scriptFeature.GetAllGlyphIdsForSubstitution())) {
      global::Microsoft.Extensions.Logging.LoggerExtensions.LogDebug(global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForAalt.LOG,
        global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("getAllGlyphIdsForSubstitution() for ",
        scriptFeature.GetName()), " is empty")));
      return originalGlyphs;
    }
    global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GlyphArraySplitter glyphArraySplitter
      = new global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GlyphArraySplitterRegexImpl(scriptFeature.GetAllGlyphIdsForSubstitution());
    global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>> tokens
      = glyphArraySplitter.Split(originalGlyphs);
    global::System.Collections.Generic.IList<int> gsubProcessedGlyphs
      = new global::System.Collections.Generic.List<int>();
    foreach (global::System.Collections.Generic.IList<int> chunk in tokens) {
      if (scriptFeature.CanReplaceGlyphs(chunk)) {
        int glyphId
          = global::DripSharp.Runtime.JavaCompat.UnboxObject<int>(scriptFeature.GetReplacementForGlyphs(chunk));
        global::DripSharp.Runtime.JavaCompat.Add(gsubProcessedGlyphs, glyphId);
      } else {
        global::DripSharp.Runtime.JavaCompat.AddAll(gsubProcessedGlyphs, chunk);
      }
    }
    global::Microsoft.Extensions.Logging.LoggerExtensions.LogDebug(global::DripSharp.PdfCarton.Fonts.Ttf.Gsub.GsubWorkerForAalt.LOG,
      global::DripSharp.Runtime.JavaCompat.StringValueOf(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat(global::DripSharp.Runtime.JavaCompat.Concat("originalGlyphs: ",
      originalGlyphs), ", gsubProcessedGlyphs: "), gsubProcessedGlyphs)));
    return gsubProcessedGlyphs;
  }
}
