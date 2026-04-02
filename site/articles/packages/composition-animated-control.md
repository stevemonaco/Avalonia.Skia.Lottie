---
title: "Package: CompositionAnimatedControl"
---

# Package: CompositionAnimatedControl

`CompositionAnimatedControl` is the reusable core for the repository's Skia-backed controls. It hosts a composition custom visual, renders into an `SKCanvas`, and exposes a playback model that higher-level controls can reuse.

## Install

```bash
dotnet add package CompositionAnimatedControl
```

## What it adds

- Skia-based rendering through `OnRender(SKCanvas canvas, Rect destRect, TimeSpan effectiveElapsed, bool isRunning)`
- `Start()`, `Stop()`, `Pause()`, `Resume()`, and `Seek(...)`
- `RepeatCount`, `PlaybackRate`, `Position`
- `Redraw()` for on-demand refresh
- `Update`, `Started`, `Stopped`, and `Disposed` events
- `Stretch` and `StretchDirection` support

## Animated mode

The `SimpleTimelineControl` sample shows a looped time-based animation:

```csharp
public sealed class SimpleTimelineControl : CompositionAnimatedControl
{
    protected override Size OnGetSourceSize() => new(300, 200);

    protected override NormalizeResult OnNormalizeElapsed(TimeSpan elapsed)
    {
        var loop = TimeSpan.FromSeconds(2);
        var remainder = TimeSpan.FromTicks(elapsed.Ticks % loop.Ticks);
        return new NormalizeResult(remainder, elapsed >= loop);
    }

    protected override void OnRender(SKCanvas canvas, Rect rect, TimeSpan t, bool running)
    {
        canvas.Clear(SKColors.White);
        var progress = (float)(t.TotalSeconds / 2.0);
        var x = (float)(rect.X + rect.Width * progress);
        using var paint = new SKPaint { Color = SKColors.CornflowerBlue, IsAntialias = true };
        canvas.DrawCircle(x, (float)rect.Center.Y, 20, paint);
    }
}
```

## Static redraw mode

The same base class also supports redraw-on-demand content:

- keep the control stopped,
- update internal state from app events,
- call `Redraw()` when the visual should refresh.

The `StaticRedrawControl` sample demonstrates this pattern.

## When to use it

Choose this package when you need custom Skia rendering but do not want to build the scheduling and composition integration yourself.
