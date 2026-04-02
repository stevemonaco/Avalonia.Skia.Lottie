---
title: "Installation"
---

# Installation

## Prerequisites

- Avalonia application targeting a supported runtime from this repository.
- Skia-backed rendering for `Lottie`, `CompositionAnimatedControl`, and `ShaderAnimatedControl`.
- .NET SDK compatible with the repository toolchain if you plan to run the samples or build from source.

Desktop Avalonia apps using `UsePlatformDetect()` normally run on the Skia backend already.

## Choose the package

| Package | Install command | Use when |
| --- | --- | --- |
| `Lottie` | `dotnet add package Lottie` | You want to play Lottie JSON files directly in XAML or code |
| `AnimationControl` | `dotnet add package AnimationControl` | You need a simple custom animation loop based on Avalonia rendering |
| `CompositionAnimatedControl` | `dotnet add package CompositionAnimatedControl` | You need custom Skia rendering with seek, repeat, redraw, and update callbacks |
| `ShaderAnimatedControl` | `dotnet add package ShaderAnimatedControl` | You want to render SKSL effects inside an Avalonia control |

## Package reference form

```xml
<ItemGroup>
  <PackageReference Include="Lottie" Version="x.y.z" />
</ItemGroup>
```

Swap `Lottie` for the package you need.

## XAML namespace

All four packages map their controls into the default Avalonia XAML namespace:

```xml
xmlns="https://github.com/avaloniaui"
```

That means you can use controls such as `<Lottie />` or `<ShaderAnimatedControl />` without a separate XML namespace alias.

## Running the sample applications

```bash
dotnet run --project samples/LottieDemo.Desktop/LottieDemo.Desktop.csproj
dotnet run --project samples/AnimationControlDemo/AnimationControlDemo.csproj
dotnet run --project samples/CompositionAnimatedControlDemo/CompositionAnimatedControlDemo.csproj
dotnet run --project samples/EffectsDemo/EffectsDemo.csproj
```

The sample apps are the fastest way to confirm backend, asset loading, and rendering assumptions before you integrate the packages into another solution.
