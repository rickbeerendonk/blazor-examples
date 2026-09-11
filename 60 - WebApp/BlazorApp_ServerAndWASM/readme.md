# Auto Rendering

The solution has two projects: `BlazorApp_ServerAndWASM` (the ASP.NET Core host) and `BlazorApp_ServerAndWASM.Client` (the Blazor WebAssembly app). `Program.cs` in the host registers both `AddInteractiveServerComponents()` and `AddInteractiveWebAssemblyComponents()`, and `App.razor` applies `@rendermode="InteractiveAuto"` to `Routes`. On first visit, pages run interactively over a server circuit; once the WebAssembly runtime has been downloaded and cached, subsequent visits run interactively in the browser instead.

## How to run

Only run the host project (`BlazorApp_ServerAndWASM`) — it references and serves the `.Client` project, so the client is never started separately.

### Command line

```sh
cd "BlazorApp_ServerAndWASM/BlazorApp_ServerAndWASM"
dotnet watch run
```

The browser opens automatically. To see the switch from server to WebAssembly, reload the page a few times (or revisit after the first load) and check the `Counter` page's rendering location.

### VS Code

Open any file inside `60 - WebApp/BlazorApp_ServerAndWASM/BlazorApp_ServerAndWASM/BlazorApp_ServerAndWASM` (not `BlazorApp_ServerAndWASM.Client`) and run the **Start** (or **Start-Without-Debugging**) task.
