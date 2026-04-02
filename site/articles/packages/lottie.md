---
title: "Package: Lottie"
---

# Package: Lottie

`Lottie` is the highest-level control in the repository. It loads a Skottie animation, renders it through `CompositionAnimatedControl`, and exposes helpers that are convenient for UI playback controls.

## Install

```bash
dotnet add package Lottie
```

## What it gives you

- `Path` for asset or file loading
- `RepeatCount` and `PlaybackRate`
- `Play()`, `Pause()`, `Resume()`, `Stop()`
- `Seek(TimeSpan)`, `SeekSeconds(double)`, `SeekProgress(double)`
- `PositionSeconds` and `DurationSeconds` for slider binding

## Basic usage

```xml
<Lottie Path="/Assets/LottieLogo1.json"
        RepeatCount="-1" />
```

## Interactive usage

```xml
<Lottie x:Name="Player"
        Path="{Binding SelectedAsset.Path}"
        RepeatCount="-1" />

<Slider Minimum="0"
        Maximum="{Binding #Player.DurationSeconds}"
        Value="{Binding #Player.PositionSeconds, Mode=TwoWay}" />
```

This matches the pattern used by the `samples/LottieDemo` application, which also binds `PlaybackRate` and exposes play/pause/resume/stop buttons.

## Asset loading behavior

The control can load:

- relative asset paths such as `/Assets/LottieLogo1.json`,
- `avares://` resource URIs,
- local files when the path resolves to a file URI.

If the path changes before the control is attached to the visual tree, the control stores it and loads it on `Loaded`.

## When to use it

Use `Lottie` when you already have Lottie JSON assets and want a finished player surface. If you need to author custom Skia visuals instead of playing existing assets, use `CompositionAnimatedControl` directly.
