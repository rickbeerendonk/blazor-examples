# Per-Component Render Mode - InteractiveWebAssembly

The solution has two projects: `BlazorApp_WASM` (the ASP.NET Core host) and `BlazorApp_WASM.Client` (the Blazor WebAssembly app). `Program.cs` in the host registers `AddInteractiveWebAssemblyComponents()`, but `App.razor` does **not** set a render mode on `Routes`, so pages are static by default. Only `Counter.razor` (in the `.Client` project) opts in with `@rendermode InteractiveWebAssembly` at the top of the file, making just that page interactive in the browser while every other page stays static SSR.

## How to run

Only run the host project (`BlazorApp_WASM`) — it references and serves the `.Client` project, so the client is never started separately.

### Command line

```sh
cd "BlazorApp_WASM/BlazorApp_WASM"
dotnet watch run
```

The browser opens automatically. Compare the `Home` page (static) with the `Counter` page (interactive).

### VS Code

Open any file inside `60 - WebApp/RenderMode per Component/BlazorApp_WASM/BlazorApp_WASM/BlazorApp_WASM` (not `BlazorApp_WASM.Client`) and run the **Start** (or **Start-Without-Debugging**) task.
