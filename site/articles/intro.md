---
title: "Introduction"
---

# Introduction

`Lottie` is a small animation-focused repository with four reusable packages:

- `Lottie`: a Skottie-powered control for playing `.json` Lottie assets in Avalonia.
- `AnimationControl`: a lightweight base class for custom animations driven by `RequestAnimationFrame`.
- `CompositionAnimatedControl`: a composition-backed Skia host for animated or static redraw scenarios.
- `ShaderAnimatedControl`: a shader-oriented control that loads SKSL and exposes a draw callback for uniform binding.

## Why this repository exists

Avalonia applications often need animation surfaces at different abstraction levels:

- a ready-to-use player for Lottie assets,
- a simple frame loop for custom `DrawingContext` rendering,
- a Skia canvas hosted in the composition layer,
- or a way to run shader effects inside an Avalonia control.

This repository keeps those layers in one place so the packages can build on each other instead of duplicating scheduling and rendering code.

## Package relationships

| Package | Depends on | Best for |
| --- | --- | --- |
| `AnimationControl` | `Avalonia` | Basic custom controls that animate with Avalonia drawing primitives |
| `CompositionAnimatedControl` | `Avalonia`, `Avalonia.Skia`, `SkiaSharp` | Custom Skia rendering with playback, seek, repeat, and redraw support |
| `Lottie` | `CompositionAnimatedControl`, `SkiaSharp.Skottie` | Playing Lottie/Skottie JSON animations |
| `ShaderAnimatedControl` | `CompositionAnimatedControl`, `SkiaSharp` | Running SKSL shaders with app-controlled uniforms |

## Key concepts

- **Layered design**: `Lottie` and `ShaderAnimatedControl` reuse the scheduling and rendering pipeline in `CompositionAnimatedControl`.
- **Skia-first rendering**: the higher-level packages assume the Avalonia Skia backend because they render into `SKCanvas`.
- **Authoring flexibility**: you can start with the `Lottie` player and move down to base controls only when you need custom drawing behavior.
- **Sample-backed docs**: each package has a matching sample project in `samples/` so the authored docs stay grounded in working code.
