---
title: "Build and Package"
---

# Build and Package

## Build the repository

```bash
dotnet restore
dotnet build -c Release
dotnet test -c Release
```

## Build the docs

```bash
./build-docs.sh
```

Use `./serve-docs.sh` for a local preview server with Lunet watch mode.

## Pack the NuGet packages

```bash
dotnet pack Avalonia.Skia.Lottie.sln -c Release -o artifacts/packages
```

## What gets packed

- `src/Lottie`
- `src/AnimationControl`
- `src/CompositionAnimatedControl`
- `src/ShaderAnimatedControl`

The sample projects are not packable; they exist to validate usage and support the docs.
