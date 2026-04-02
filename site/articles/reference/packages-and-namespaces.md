---
title: "Packages and Namespaces"
---

# Packages and Namespaces

| Package | Main namespace | Purpose |
| --- | --- | --- |
| `Lottie` | `Avalonia.Skia.Lottie` | Ready-to-use Lottie/Skottie player control |
| `AnimationControl` | `Avalonia.Controls` | Minimal frame-loop base class for custom Avalonia controls |
| `CompositionAnimatedControl` | `Avalonia.Skia.Composition` | Composition-backed Skia control and playback surface |
| `ShaderAnimatedControl` | `Avalonia.Skia.Composition` | Shader host built on top of `CompositionAnimatedControl` |

## Sample projects

| Sample | Project path | Focus |
| --- | --- | --- |
| `LottieDemo` | `samples/LottieDemo` + `samples/LottieDemo.Desktop` | Asset browser, playback controls, drag-and-drop |
| `AnimationControlDemo` | `samples/AnimationControlDemo` | Simple custom animation using Avalonia drawing |
| `CompositionAnimatedControlDemo` | `samples/CompositionAnimatedControlDemo` | Timeline animation, bouncing ball, static redraw, physics sample |
| `EffectsDemo` | `samples/EffectsDemo` | SKSL shader rendering and runtime uniform binding |
| `LottieToSvg` | `samples/LottieToSvg` | Repository utility sample for conversion workflows |
