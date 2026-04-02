---
title: "Package: ShaderAnimatedControl"
---

# Package: ShaderAnimatedControl

`ShaderAnimatedControl` builds on `CompositionAnimatedControl` and turns a Skia runtime effect into an Avalonia control.

## Install

```bash
dotnet add package ShaderAnimatedControl
```

## Public surface

- `ShaderUri`
- `ShaderWidth`
- `ShaderHeight`
- `IsShaderFillCanvas`
- `Draw` event with `DrawEventArgs`

## Basic usage

```xml
<ShaderAnimatedControl ShaderUri="avares://EffectsDemo/Assets/shader.txt"
                       ShaderWidth="500"
                       ShaderHeight="500"
                       IsShaderFillCanvas="True"
                       Draw="ShaderAnimatedControl_OnDraw" />
```

## Binding uniforms in the draw callback

```csharp
private SKRuntimeEffectUniforms? _uniforms;

private void ShaderAnimatedControl_OnDraw(object? sender, DrawEventArgs e)
{
    if (e.ErrorText is not null)
    {
        return;
    }

    var targetWidth = (float)(e.IsShaderFillCanvas ? e.DestRect.Width : e.ShaderWidth);
    var targetHeight = (float)(e.IsShaderFillCanvas ? e.DestRect.Height : e.ShaderHeight);

    _uniforms ??= new SKRuntimeEffectUniforms(e.Effect);
    _uniforms["iTime"] = (float)e.EffectiveElapsed.TotalSeconds;
    _uniforms["iResolution"] = new[] { targetWidth, targetHeight, 0f };

    using var paint = new SKPaint();
    using var shader = e.Effect.ToShader(_uniforms);
    paint.Shader = shader;

    var rect = new SKRect((float)e.DestRect.X, (float)e.DestRect.Y, (float)e.DestRect.Right, (float)e.DestRect.Bottom);
    e.Canvas.DrawRect(rect, paint);
}
```

## Notes

- The control automatically starts on `Loaded` and stops on `Unloaded`.
- `DrawEventArgs.ErrorText` lets you detect SKSL compilation errors.
- `IsShaderFillCanvas` switches between a fixed logical shader size and the current control bounds.

For more detail, see [Shader Uniform Binding](../guides/shader-uniform-binding.md).
