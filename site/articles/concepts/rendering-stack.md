---
title: "Rendering Stack"
---

# Rendering Stack

The repository is organized as a layered animation stack rather than a single monolithic control.

## Layer map

| Layer | Public package | Rendering model | Typical use |
| --- | --- | --- | --- |
| 1 | `AnimationControl` | Avalonia `DrawingContext` + `RequestAnimationFrame` | Simple custom animations without Skia |
| 2 | `CompositionAnimatedControl` | Avalonia composition custom visual + `SKCanvas` | Reusable Skia rendering surfaces |
| 3a | `Lottie` | Skottie animation rendered into the composition-backed canvas | JSON animation playback |
| 3b | `ShaderAnimatedControl` | `SKRuntimeEffect` hosted on the composition-backed canvas | Shader effects and procedural visuals |

## How to choose

- Choose `AnimationControl` when a normal Avalonia control and a frame callback are enough.
- Choose `CompositionAnimatedControl` when you need Skia rendering or explicit playback control.
- Choose `Lottie` when you already have animation assets in Lottie JSON format.
- Choose `ShaderAnimatedControl` when the visual should come from SKSL instead of vector assets.

## Inheritance

- `Lottie : CompositionAnimatedControl`
- `ShaderAnimatedControl : CompositionAnimatedControl`

That shared base is why both controls expose concepts such as `RepeatCount`, `PlaybackRate`, `Seek(...)`, `Start()`, `Stop()`, and `Redraw()`.

## Backend implications

`AnimationControl` only depends on Avalonia rendering. The other three packages depend on `Avalonia.Skia` and render through `SKCanvas`, so they are intended for Skia-backed Avalonia applications.
