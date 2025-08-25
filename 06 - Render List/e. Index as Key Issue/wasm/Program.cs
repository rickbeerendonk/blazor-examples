/*! European Union Public License version 1.2 !*/
/*! Copyright © 2021 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using RenderList_IndexAsKeyIssue;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
await builder.Build().RunAsync();
