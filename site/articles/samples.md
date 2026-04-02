---
title: "Samples"
---

# Samples

The repository includes sample applications for each layer of the stack.

## Run the samples

```bash
dotnet run --project samples/LottieDemo.Desktop/LottieDemo.Desktop.csproj
dotnet run --project samples/AnimationControlDemo/AnimationControlDemo.csproj
dotnet run --project samples/CompositionAnimatedControlDemo/CompositionAnimatedControlDemo.csproj
dotnet run --project samples/EffectsDemo/EffectsDemo.csproj
```

## What they show

- `LottieDemo`: packaged assets, drag-and-drop, playback rate, repeat count, and slider-based seeking.
- `AnimationControlDemo`: the simplest custom animation loop in the repository.
- `CompositionAnimatedControlDemo`: multiple composition-backed rendering strategies using the same base class.
- `EffectsDemo`: shader compilation and runtime uniform updates.

See [Reference: Sample Apps](reference/sample-apps.md) for the per-project mapping.
