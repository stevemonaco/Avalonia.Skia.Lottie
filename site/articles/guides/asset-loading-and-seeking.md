---
title: "Asset Loading and Seeking"
---

# Asset Loading and Seeking

## Loading Lottie assets

`Lottie.Path` accepts the same styles used in the repository samples:

- `/Assets/Example.json` for assets resolved from the XAML base URI,
- `avares://AssemblyName/Assets/Example.json` for explicit asset URIs,
- file-based paths for local content.

Internally, the control resolves relative paths against the XAML base URI captured by its constructor.

## Timeline control

The player exposes three common seek surfaces:

- `Seek(TimeSpan position)`
- `SeekSeconds(double seconds)`
- `SeekProgress(double progress)`

`SeekProgress(...)` clamps to the range `[0, 1]`, which makes it convenient for scrubbers and normalized animation timelines.

## Binding to UI controls

The sample Lottie viewer binds playback state to XAML controls:

- `PositionSeconds` for the current slider value,
- `DurationSeconds` for the slider maximum,
- `PlaybackRate` for user-adjustable speed.

That pattern is a good default when you want a player UI without writing a separate view model for timeline math.

## Swapping assets at runtime

Changing `Path` stops the current animation, disposes the previous Skottie object, loads the new asset, and starts playback again if loading succeeds.

That is how the sample browser swaps between built-in assets and user-dropped files.
