# Per-Component Render Mode - Baseline (Static Only)

This app only calls `AddRazorComponents()` and `MapRazorComponents<App>()` — no interactive render mode is registered, so no page (including `Counter`) can opt into an interactive render mode. It is the baseline to compare against the other `RenderMode per Component` examples, where individual pages opt in to interactivity while the rest of the app stays static.

## How to run

### Command line

```sh
cd "BlazorApp_None"
dotnet watch run
```

The browser opens automatically.

### VS Code

Open any file inside `60 - WebApp/RenderMode per Component/BlazorApp_None/BlazorApp_None` and run the **Start** (or **Start-Without-Debugging**) task.
