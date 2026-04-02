---
title: "Troubleshooting"
---

# Troubleshooting

## The control stays blank

Check the obvious first:

- the `Path` or `ShaderUri` actually resolves,
- the asset is included in the application output/resources,
- the control has non-zero size.

For `Lottie`, a missing or invalid asset path will prevent the animation from loading.

## Playback controls do nothing

`Lottie`, `CompositionAnimatedControl`, and `ShaderAnimatedControl` only create their composition custom visual after the control is loaded. If you call playback methods before `Loaded`, there is no underlying visual to message yet.

## Duration stays at zero

If `DurationSeconds` remains `0`, the Lottie asset likely failed to load or the animation file is invalid for Skottie.

## Shader effect reports an error

Inspect `DrawEventArgs.ErrorText`. The control surfaces shader compilation failures there instead of throwing from the draw callback.

## The wrong package was chosen

Use this rule of thumb:

- `AnimationControl` for pure Avalonia drawing,
- `CompositionAnimatedControl` for custom Skia rendering,
- `Lottie` for Lottie JSON playback,
- `ShaderAnimatedControl` for SKSL effects.
