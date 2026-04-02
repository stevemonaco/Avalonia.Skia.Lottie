---
title: "Lunet Docs Pipeline"
---

# Lunet Docs Pipeline

This repository uses Lunet for the documentation site and generated .NET API reference.

## Key files

- `site/config.scriban`: site metadata, theme bundle, and `api.dotnet` project list
- `site/menu.yml`: top-level navigation
- `site/articles/**`: authored documentation pages and sidebars
- `site/.lunet/includes/_builtins/bundle.sbn-html`: bundle override used by the custom lite bundle
- `site/.lunet/layouts/_default.api-dotnet*.sbn-md`: API layout overrides
- `site/.lunet/css/template-main.css`: precompiled template stylesheet
- `site/.lunet/css/site-overrides.css`: repository-specific visual styling
- `.config/dotnet-tools.json`: pinned local Lunet tool

## Build commands

```bash
./build-docs.sh
./serve-docs.sh
./check-docs.sh
```

All commands run Lunet from `site/` and write generated output to `site/.lunet/build/www`.

## Deployment

`.github/workflows/docs.yml` restores the local tool, builds the site, and publishes `site/.lunet/build/www` to GitHub Pages on pushes to `main` or `master`.
