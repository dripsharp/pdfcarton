# PdfCarton release verification

Run `eng/verify-release.sh` from any directory to verify PdfCarton for a
release. The verifier always restores and compiles all five production projects
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
work. It cannot omit a production-project build, the mandatory release smoke
suite, or the focused consumer classes. Unset the variable or set it to `0`
for complete verification. Every other value is rejected before invoking
.NET.

Run `eng/test-verify-release.sh` for the fast command-contract regression. It
uses a fake `dotnet` executable to prove the exact reduced boundary, all five
production-project builds, the mandatory smoke invocation, rejection of invalid
mode values, and that a release-smoke failure remains fatal in reduced mode.

After release verification has restored and built the production projects in
Release, run `eng/pack-release.sh <empty-artifact-directory>`. It invokes
`dotnet pack` exactly once for each of IO, Fonts, Xmp, PdfCarton, and Preflight
as internal bundle components. It then deterministically emits exactly one
public `DripSharp.PdfCarton` nupkg and one snupkg containing all five production
DLL/PDB pairs. The bounded validator checks the exact two-file public inventory,
package ID, version, `netstandard2.0` dependency metadata, five production
assemblies, and five portable-PDB names. It does not inspect public surface,
SourceLink contents, or byte reproducibility.

The validator stages the single public nupkg and its already-restored NuGet
dependencies in a temporary local feed. It creates a `net10.0` console consumer
outside the checkout with exactly one `DripSharp.PdfCarton` package reference,
restores into an empty package cache using only that feed, builds, and runs
representative IO, Fonts, Xmp, PdfCarton, and Preflight behavior. Restore,
compilation, assembly load, and behavior failures are fatal.
`eng/validate-release-packages.sh` may also be run directly against an existing
one-package-pair artifact directory.

Run `eng/test-release-packages.sh` after restore for the fast command-boundary
regression. It proves all five internal pack commands, exact one-pair public
inventory, the single-package-reference consumer and isolated source
configuration, fail-closed symbol and metadata inventories, and fatal
restore/build/run failures.
