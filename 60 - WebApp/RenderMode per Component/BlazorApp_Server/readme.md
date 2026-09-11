# Per-Component Render Mode - InteractiveServer

`Program.cs` registers `AddInteractiveServerComponents()`, but `App.razor` does **not** set a render mode on `Routes`, so pages are static by default. Only `Counter.razor` opts in with `@rendermode InteractiveServer` at the top of the file, making just that page interactive over a SignalR circuit while every other page stays static SSR.

## How to run

### Command line

```sh
cd "BlazorApp_Server"
dotnet watch run
```

The browser opens automatically. Compare the `Home` page (static) with the `Counter` page (interactive).

### VS Code

Open any file inside `60 - WebApp/RenderMode per Component/BlazorApp_Server/BlazorApp_Server` and run the **Start** (or **Start-Without-Debugging**) task.
