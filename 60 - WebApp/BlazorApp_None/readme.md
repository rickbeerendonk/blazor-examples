# Static Server Side Rendering

This app only calls `AddRazorComponents()` and `MapRazorComponents<App>()` — no interactive render mode is registered. Every page is rendered once on the server and sent to the browser as static HTML; there is no SignalR circuit and no WebAssembly runtime, so components cannot handle client-side events (e.g. the `Counter` button won't work).

## How to run

### Command line

```sh
cd "BlazorApp_None"
dotnet watch run
```

The browser opens automatically.

### VS Code

Open any file inside `60 - WebApp/BlazorApp_None/BlazorApp_None` and run the **Start** (or **Start-Without-Debugging**) task.
