# Interactive Server Side Rendering

`Program.cs` calls `AddInteractiveServerComponents()` and `AddInteractiveServerRenderMode()`, and `App.razor` applies `@rendermode="InteractiveServer"` to `Routes`. Every page runs interactively on the server: the UI is kept in sync with the browser over a SignalR circuit, so events (e.g. the `Counter` button) work without shipping any WebAssembly to the client.

## How to run

### Command line

```sh
cd "BlazorApp_Server"
dotnet watch run
```

The browser opens automatically.

### VS Code

Open any file inside `60 - WebApp/BlazorApp_Server/BlazorApp_Server` and run the **Start** (or **Start-Without-Debugging**) task.
