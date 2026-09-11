# Interactive Client Side Rendering (WebAssembly)

The solution has two projects: `BlazorApp_WASM` (the ASP.NET Core host) and `BlazorApp_WASM.Client` (the Blazor WebAssembly app). `Program.cs` in the host calls `AddInteractiveWebAssemblyComponents()` and `AddInteractiveWebAssemblyRenderMode()`, and `App.razor` applies `@rendermode="InteractiveWebAssembly"` to `Routes`. Every page runs interactively in the browser after the WebAssembly runtime and app assemblies are downloaded.

## How to run

Only run the host project (`BlazorApp_WASM`) — it references and serves the `.Client` project, so the client is never started separately.

### Command line

```sh
cd "BlazorApp_WASM/BlazorApp_WASM"
dotnet watch run
```

The browser opens automatically.

### VS Code

Open any file inside `60 - WebApp/BlazorApp_WASM/BlazorApp_WASM/BlazorApp_WASM` (not `BlazorApp_WASM.Client`) and run the **Start** (or **Start-Without-Debugging**) task.
