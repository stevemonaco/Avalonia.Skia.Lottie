---
title: "Quickstart: Lottie Player"
---

# Quickstart: Lottie Player

## Install

```bash
dotnet add package Lottie
```

## Add a Lottie asset

Place a `.json` animation in your Avalonia project and mark it as an `AvaloniaResource` or another asset type you already use with `AssetLoader`.

## Basic XAML usage

```xml
<Viewbox>
  <Lottie Path="/Assets/LottieLogo1.json"
          RepeatCount="-1"
          PlaybackRate="1.0" />
</Viewbox>
```

`Path` can point to:

- an asset path relative to the current XAML base URI,
- an `avares://` URI,
- or a local file path/`file://` URI.

## Add playback controls

The `Lottie` control inherits the playback API from `CompositionAnimatedControl` and adds duration/position helpers:

```xml
<StackPanel Spacing="8">
  <Lottie x:Name="Player"
          Path="/Assets/LottieLogo1.json"
          RepeatCount="-1" />

  <StackPanel Orientation="Horizontal" Spacing="8">
    <Button Content="Play" Click="OnPlay" />
    <Button Content="Pause" Click="OnPause" />
    <Button Content="Resume" Click="OnResume" />
    <Button Content="Stop" Click="OnStop" />
  </StackPanel>

  <Slider Minimum="0"
          Maximum="{Binding #Player.DurationSeconds}"
          Value="{Binding #Player.PositionSeconds, Mode=TwoWay}" />
</StackPanel>
```

```csharp
private void OnPlay(object? sender, RoutedEventArgs e) => Player.Play();
private void OnPause(object? sender, RoutedEventArgs e) => Player.Pause();
private void OnResume(object? sender, RoutedEventArgs e) => Player.Resume();
private void OnStop(object? sender, RoutedEventArgs e) => Player.Stop();
```

## Useful members

- `RepeatCount = -1` plays forever.
- `PlaybackRate` speeds up or slows down playback.
- `PositionSeconds` and `DurationSeconds` are convenient for slider binding.
- `SeekSeconds(...)` and `SeekProgress(...)` let you drive playback from code.

## Next steps

- See [Package: Lottie](../packages/lottie.md) for the full player surface.
- See [Asset Loading and Seeking](../guides/asset-loading-and-seeking.md) for URI and timeline details.
