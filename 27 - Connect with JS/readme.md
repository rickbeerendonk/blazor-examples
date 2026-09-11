# Connect with JavaScript

These examples show the main directions for JavaScript interop in Blazor.

## Which API should I use?

| API             | Direction        | Works in                                                           | Use it for                                                             |
| --------------- | ---------------- | ------------------------------------------------------------------ | ---------------------------------------------------------------------- |
| `IJSRuntime`    | C# -> JavaScript | Blazor WebAssembly, Blazor Server, and interactive Blazor Web Apps | General-purpose interop, including DOM access and JavaScript modules   |
| `[JSImport]`    | C# -> JavaScript | **Blazor WebAssembly only**                                        | A strongly typed direct call to an exported JavaScript module function |
| `[JSExport]`    | JavaScript -> C# | **Blazor WebAssembly only**                                        | A strongly typed direct export from a C# method                        |
| `[JSInvokable]` | JavaScript -> C# | An interactive Blazor runtime; this sample uses WebAssembly        | Calling a .NET method through the Blazor interop runtime               |

`[JSImport]` and `[JSExport]` are **WebAssembly-only** bindings. They are not alternatives that make server-rendered C# run in the browser. A Blazor Web App must use an interactive WebAssembly component for these APIs; static SSR and interactive Server components cannot use them. Use `IJSRuntime` for those hosting models. `IJSRuntime` also needs an interactive browser runtime: JavaScript interop does not run during static SSR or during prerendering.

## Examples

Each direction is shown without and with a return value, once per applicable API.

### a. C# calling JS

| #   | Folder                                                                                                        | API                                 | Return value                                                                                                                                                                                                                                       |
| --- | ------------------------------------------------------------------------------------------------------------- | ----------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| i   | [IJSRuntime - Without Return](a.%20CSharp%20calling%20JS%20-%20i.%20IJSRuntime%20-%20Without%20Return)        | `IJSRuntime`                        | No (`InvokeVoidAsync`); shown with a [JS module](a.%20CSharp%20calling%20JS%20-%20i.%20IJSRuntime%20-%20Without%20Return/wasm-module) and a [plain script](a.%20CSharp%20calling%20JS%20-%20i.%20IJSRuntime%20-%20Without%20Return/wasm-no-module) |
| ii  | [IJSRuntime - With Return](a.%20CSharp%20calling%20JS%20-%20ii.%20IJSRuntime%20-%20With%20Return/wasm)        | `IJSRuntime`                        | Yes (`InvokeAsync<T>`)                                                                                                                                                                                                                             |
| iii | [\[JSImport\] - Without Return](a.%20CSharp%20calling%20JS%20-%20iii.%20JSImport%20-%20Without%20Return/wasm) | `[JSImport]` (**WebAssembly only**) | No (`void`)                                                                                                                                                                                                                                        |
| iv  | [\[JSImport\] - With Return](a.%20CSharp%20calling%20JS%20-%20iv.%20JSImport%20-%20With%20Return/wasm)        | `[JSImport]` (**WebAssembly only**) | Yes                                                                                                                                                                                                                                                |

### b. JS calling C#

| #   | Folder                                                                                                            | API                                          | Return value |
| --- | ----------------------------------------------------------------------------------------------------------------- | -------------------------------------------- | ------------ |
| i   | [\[JSInvokable\] - Without Return](b.%20JS%20calling%20CSharp%20-%20i.%20JSInvokable%20-%20Without%20Return/wasm) | `[JSInvokable]` + `DotNet.invokeMethodAsync` | No (`void`)  |
| ii  | [\[JSInvokable\] - With Return](b.%20JS%20calling%20CSharp%20-%20ii.%20JSInvokable%20-%20With%20Return/wasm)      | `[JSInvokable]` + `DotNet.invokeMethodAsync` | Yes          |
| iii | [\[JSExport\] - Without Return](b.%20JS%20calling%20CSharp%20-%20iii.%20JSExport%20-%20Without%20Return/wasm)     | `[JSExport]` (**WebAssembly only**)          | No (`void`)  |
| iv  | [\[JSExport\] - With Return](b.%20JS%20calling%20CSharp%20-%20iv.%20JSExport%20-%20With%20Return/wasm)            | `[JSExport]` (**WebAssembly only**)          | Yes          |

The geolocation examples apply the same WebAssembly interop approach to a browser API. The [basic geolocation notes](geolocation.md) link to the library and browser API documentation.

## Running an example

Run `dotnet run` from the example directory that contains the `.csproj`, then open the URL shown by the .NET host. The `IJSRuntime` and `[JSImport]` "With Return" examples display their result in the page; the `[JSInvokable]` and `[JSExport]` examples write their results to the browser console (open developer tools to see them).
