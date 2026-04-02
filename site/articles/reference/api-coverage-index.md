---
title: "API Coverage Index"
---

# API Coverage Index

The generated API reference under `/api` is built from these projects:

- `../src/Lottie/Lottie.csproj`
- `../src/AnimationControl/AnimationControl.csproj`
- `../src/CompositionAnimatedControl/CompositionAnimatedControl.csproj`
- `../src/ShaderAnimatedControl/ShaderAnimatedControl.csproj`

## Build settings

Current API settings:

- configuration: `Release`
- target framework override: `net8.0`
- output path: `/api`

## Coverage notes

- `Lottie` documents the ready-to-use player surface.
- `AnimationControl` covers the smallest custom animation base.
- `CompositionAnimatedControl` includes the reusable playback and redraw API used by higher-level controls.
- `ShaderAnimatedControl` and `DrawEventArgs` document the shader entry points exposed to application code.

## When a new package is added

To keep the authored docs and generated API aligned:

1. Add the project to `site/config.scriban` under `api.dotnet.projects`.
2. Update [Packages and Namespaces](packages-and-namespaces.md).
3. Add or update the package page under `site/articles/packages/`.
4. Rebuild the site with `./build-docs.sh`.
