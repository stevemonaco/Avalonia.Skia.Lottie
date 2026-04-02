---
title: "Shader Uniform Binding"
---

# Shader Uniform Binding

`ShaderAnimatedControl` separates shader compilation from parameter binding:

- the control loads the SKSL source from `ShaderUri`,
- compiles it to an `SKRuntimeEffect`,
- then raises `Draw` for each render pass.

## Recommended pattern

1. Exit early when `ErrorText` is set.
2. Lazily allocate `SKRuntimeEffectUniforms`.
3. Feed time, resolution, and any app-specific values into the uniform buffer.
4. Create a shader from `e.Effect.ToShader(...)`.
5. Draw to `e.Canvas` using `e.DestRect`.

## Size handling

When `IsShaderFillCanvas` is `true`, derive your `iResolution` or equivalent uniform values from `e.DestRect.Width` and `e.DestRect.Height`.

When `IsShaderFillCanvas` is `false`, use `ShaderWidth` and `ShaderHeight` as the logical shader size.

## Resource cleanup

If your view stores `SKRuntimeEffectUniforms` or other disposable Skia objects, dispose them when the owning control or window detaches from the visual tree. The `EffectsDemo` sample does this in `OnDetachedFromVisualTree(...)`.
