---
title: "Package: AnimationControl"
---

# Package: AnimationControl

`AnimationControl` is the smallest package in the repository. It provides a control base class that continuously requests the next animation frame while the control is attached to the visual tree.

## Install

```bash
dotnet add package AnimationControl
```

## Core API

Subclass `AnimationControl` and override:

```csharp
protected override void OnAnimationFrame(TimeSpan now, TimeSpan last)
{
    // update your state
}
```

Then render the current state in `Render(DrawingContext context)`.

## Example

The sample project includes an `EllipseAnimationControl` that updates horizontal position each frame and draws the ellipse through normal Avalonia drawing primitives:

```csharp
public class EllipseAnimationControl : AnimationControl
{
    private double _position;
    private double _velocity = 120;

    protected override void OnAnimationFrame(TimeSpan now, TimeSpan last)
    {
        var delta = now - last;
        _position += _velocity * delta.TotalSeconds;
        var limit = Math.Max(0, Bounds.Width - 40);
        if (_position > limit || _position < 0)
        {
            _velocity = -_velocity;
            _position = _position < 0 ? 0 : (_position > limit ? limit : _position);
        }
    }

    public override void Render(DrawingContext context)
    {
        var center = new Point(20 + _position, Bounds.Height / 2);
        context.DrawEllipse(Brushes.DarkRed, null, center, 20, 20);
    }
}
```

## When to use it

Use `AnimationControl` when:

- Avalonia drawing primitives are enough,
- you do not need explicit playback commands,
- you want the fewest dependencies possible.

If you need Skia rendering, repeat counts, seek support, or redraw-only mode, use `CompositionAnimatedControl` instead.
