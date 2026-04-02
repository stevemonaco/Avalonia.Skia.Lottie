---
title: "Lottie for Avalonia"
layout: simple
og_type: website
---

<div class="lottie-hero">
  <div class="lottie-eyebrow"><i class="bi bi-stars" aria-hidden="true"></i> Avalonia Animation Toolkit</div>
  <div class="lottie-hero-split">
    <div>
      <h1>Lottie for Avalonia</h1>
      <p class="lead"><strong>Lottie for Avalonia</strong> bundles a production-ready <code>Lottie</code> player plus reusable animation building blocks for custom timelines, composition-backed Skia rendering, and shader-driven effects.</p>
      <div class="lottie-hero-actions">
        <a class="btn btn-primary btn-lg" href="articles/getting-started/installation"><i class="bi bi-rocket-takeoff" aria-hidden="true"></i> Start Getting Started</a>
        <a class="btn btn-outline-secondary btn-lg" href="articles/packages/readme"><i class="bi bi-box-seam" aria-hidden="true"></i> Explore Packages</a>
        <a class="btn btn-outline-secondary btn-lg" href="api"><i class="bi bi-braces-asterisk" aria-hidden="true"></i> Browse API</a>
      </div>
    </div>
    <div class="lottie-hero-media">
      <img src="images/lottie-hero.svg" alt="Lottie for Avalonia banner" />
    </div>
  </div>
</div>

## Start Here

<div class="lottie-card-grid">
  <a class="lottie-card" href="articles/getting-started/installation">
    <span class="lottie-card-title"><i class="bi bi-download" aria-hidden="true"></i> Installation</span>
    <p>Choose the right NuGet package, confirm Avalonia + Skia prerequisites, and wire the controls into your app.</p>
  </a>
  <a class="lottie-card" href="articles/getting-started/quickstart-lottie">
    <span class="lottie-card-title"><i class="bi bi-play-circle" aria-hidden="true"></i> Quickstart: Lottie</span>
    <p>Load a JSON animation, bind playback controls, and seek through the timeline from XAML.</p>
  </a>
  <a class="lottie-card" href="articles/concepts/rendering-stack">
    <span class="lottie-card-title"><i class="bi bi-layers" aria-hidden="true"></i> Rendering Stack</span>
    <p>See how <code>AnimationControl</code>, <code>CompositionAnimatedControl</code>, <code>Lottie</code>, and <code>ShaderAnimatedControl</code> fit together.</p>
  </a>
  <a class="lottie-card" href="articles/samples">
    <span class="lottie-card-title"><i class="bi bi-window-stack" aria-hidden="true"></i> Samples</span>
    <p>Map each sample project to concrete playback, rendering, and effect scenarios in this repository.</p>
  </a>
</div>

## Packages

<div class="lottie-card-grid lottie-card-grid--wide">
  <a class="lottie-card" href="articles/packages/lottie">
    <span class="lottie-card-title"><i class="bi bi-file-earmark-play" aria-hidden="true"></i> Lottie</span>
    <p>The end-user control for playing Skottie/Lottie JSON assets with seek, repeat-count, playback-rate, and duration tracking.</p>
  </a>
  <a class="lottie-card" href="articles/packages/animation-control">
    <span class="lottie-card-title"><i class="bi bi-activity" aria-hidden="true"></i> AnimationControl</span>
    <p>A minimal <code>RequestAnimationFrame</code>-style base class for custom animations rendered through Avalonia drawing primitives.</p>
  </a>
  <a class="lottie-card" href="articles/packages/composition-animated-control">
    <span class="lottie-card-title"><i class="bi bi-grid-3x3-gap" aria-hidden="true"></i> CompositionAnimatedControl</span>
    <p>A composition-backed Skia control with update, redraw, seek, and repeat semantics for custom animated visuals.</p>
  </a>
  <a class="lottie-card" href="articles/packages/shader-animated-control">
    <span class="lottie-card-title"><i class="bi bi-lightning-charge" aria-hidden="true"></i> ShaderAnimatedControl</span>
    <p>A shader host that loads SKSL, raises a draw callback, and lets you bind time- and size-based uniforms on each frame.</p>
  </a>
</div>

## Documentation Sections

<div class="lottie-card-grid lottie-card-grid--wide">
  <a class="lottie-card" href="articles/getting-started/readme">
    <span class="lottie-card-title"><i class="bi bi-signpost-split" aria-hidden="true"></i> Getting Started</span>
    <p>Package installation, the first Lottie control, and the repository assumptions behind the runtime.</p>
  </a>
  <a class="lottie-card" href="articles/concepts/readme">
    <span class="lottie-card-title"><i class="bi bi-diagram-3" aria-hidden="true"></i> Concepts</span>
    <p>Understand the rendering layers, playback model, redraw flow, and where composition enters the picture.</p>
  </a>
  <a class="lottie-card" href="articles/packages/readme">
    <span class="lottie-card-title"><i class="bi bi-boxes" aria-hidden="true"></i> Packages</span>
    <p>Package-by-package guidance for the four NuGet artifacts shipped from this repository.</p>
  </a>
  <a class="lottie-card" href="articles/guides/readme">
    <span class="lottie-card-title"><i class="bi bi-journal-code" aria-hidden="true"></i> Guides</span>
    <p>Practical recipes for asset loading, playback control, shader uniform binding, and troubleshooting.</p>
  </a>
  <a class="lottie-card" href="articles/reference/readme">
    <span class="lottie-card-title"><i class="bi bi-collection" aria-hidden="true"></i> Reference</span>
    <p>Package maps, API coverage, sample-project inventory, docs pipeline details, and licensing.</p>
  </a>
</div>

## Repository

- Source code and issues: [github.com/wieslawsoltes/Lottie](https://github.com/wieslawsoltes/Lottie)
- Published docs target: [wieslawsoltes.github.io/Lottie](https://wieslawsoltes.github.io/Lottie)
