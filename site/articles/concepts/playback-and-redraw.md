---
title: "Playback and Redraw Model"
---

# Playback and Redraw Model

## `AnimationControl`

`AnimationControl` is intentionally minimal:

- it starts requesting animation frames when attached to the visual tree,
- it stops when detached,
- and it calls `OnAnimationFrame(TimeSpan now, TimeSpan last)` before invalidating the control.

There is no explicit `Start()` or `Pause()` API in this package. If you need those semantics, move up to `CompositionAnimatedControl`.

## `CompositionAnimatedControl`

`CompositionAnimatedControl` adds a higher-level playback model on top of a composition custom visual:

- `Start()`, `Stop()`, `Pause()`, `Resume()`
- `Seek(TimeSpan position)`
- `RepeatCount`
- `PlaybackRate`
- `Position`
- `Redraw()`

It also raises:

- `Update(TimeSpan delta)`
- `Started`
- `Stopped`
- `Disposed`

## Time normalization

Custom subclasses can override `OnNormalizeElapsed(TimeSpan elapsed)` to map absolute elapsed time into:

- an effective elapsed value to render,
- plus a `HasLooped` flag.

That is how `Lottie` turns an ever-increasing clock into loop-aware playback for the current animation duration.

## Static redraw scenarios

Not every Skia-backed control in this repository is continuously animated. `CompositionAnimatedControl` supports static redraw mode:

- do not call `Start()`,
- update your state from normal application events,
- call `Redraw()` when the visual needs another render pass.

The `StaticRedrawControl` sample in `samples/CompositionAnimatedControlDemo` demonstrates this pattern.
