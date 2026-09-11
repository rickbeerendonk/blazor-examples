# Per-Component Render Mode - InteractiveAuto

The solution has two projects: `BlazorApp_Auto` (the ASP.NET Core host) and `BlazorApp_Auto.Client` (the Blazor WebAssembly app). `Program.cs` in the host registers both `AddInteractiveServerComponents()` and `AddInteractiveWebAssemblyComponents()`, but `App.razor` does **not** set a render mode on `Routes`, so pages are static by default. Only `Counter.razor` (in the `.Client` project) opts in with `@rendermode InteractiveAuto` at the top of the file, making just that page interactive — first over a server circuit, then in the browser once WebAssembly has been downloaded and cached — while every other page stays static SSR.

## How to run

Only run the host project (`BlazorApp_Auto`) — it references and serves the `.Client` project, so the client is never started separately.

### Command line

```sh
cd "BlazorApp_Auto/BlazorApp_Auto"
dotnet watch run
```

The browser opens automatically. Compare the `Home` page (static) with the `Counter` page (interactive).

### VS Code

Open any file inside `60 - WebApp/RenderMode per Component/BlazorApp_Auto/BlazorApp_Auto/BlazorApp_Auto` (not `BlazorApp_Auto.Client`) and run the **Start** (or **Start-Without-Debugging**) task.
