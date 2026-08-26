# PdfCarton release verification

Run `eng/verify-release.sh` from any directory to verify PdfCarton for a
release. The verifier always restores and compiles all five published projects
in Release, then builds and runs the mandatory
`DripSharp.PdfCarton.ReleaseSmoke` suite. Any restore, compilation, or smoke
failure terminates release verification with a nonzero exit.

The default mode also builds and runs every test in
`DripSharp.PdfCarton.Tests`. Set exactly
`PDFCARTON_RELEASE_REDUCED_TESTS=1` for the bounded release-runner mode.
Reduced mode still builds `DripSharp.PdfCarton.Tests` and runs its five focused
consumer classes. It omits only the complete adapted-upstream suite and the
exhaustive fixture-integrity checks in that project, plus DripSharp's declared
high-memory PdfCarton family proof containing the differential and corpus
work. It cannot omit a published-project build, the mandatory release smoke
suite, or the focused consumer classes. Unset the variable or set it to `0`
for complete verification. Every other value is rejected before invoking
.NET.

Run `eng/test-verify-release.sh` for the fast command-contract regression. It
uses a fake `dotnet` executable to prove the exact reduced boundary, all five
published-project builds, the mandatory smoke invocation, rejection of invalid
mode values, and that a release-smoke failure remains fatal in reduced mode.

After release verification has restored and built the production projects in
Release, run `eng/pack-release.sh <empty-artifact-directory>`. It invokes
`dotnet pack` exactly once for each of IO, Fonts, Xmp, PdfCarton, and Preflight,
then runs the bounded package validator. The validator checks only package ID,
version, `netstandard2.0` dependency metadata, and the expected production DLL.
It does not inspect public surface, PDBs, symbol packages, SourceLink, or byte
reproducibility.

The validator stages the five newly packed nupkgs and their already-restored
NuGet dependencies in a temporary local feed. It creates a `net10.0` console
consumer outside the checkout with package references to all five PdfCarton
packages, restores into an empty package cache using only that feed, builds,
and runs representative IO, Fonts, Xmp, PdfCarton, and Preflight behavior.
Restore, compilation, assembly load, and behavior failures are fatal.
`eng/validate-release-packages.sh` may also be run directly against an existing
five-package artifact directory.

Run `eng/test-release-packages.sh <validated-artifact-directory>` for the fast
command-boundary regression. It proves the one-pack command count, the
package-reference-only consumer and isolated source configuration, deliberate
non-inspection of symbol packages, fatal restore/build/run failures, and fatal
essential-metadata failures.
