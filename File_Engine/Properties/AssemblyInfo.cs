// Sandbox validation file for CI_Toolkit fix/ci-versioning-gate-and-scan-root.
//
// Named AssemblyInfo.cs at the real-world depth (a project's Properties folder)
// so the versioning changed-file gate can be exercised in a live runner: the
// ':(exclude)*AssemblyInfo.cs' pathspec must drop it, leaving count=0 so every
// step self-skips. Deliberately carries no assembly attributes, because this
// project generates them from the SDK and a duplicate would break the build if
// anything ever did compile this branch.
