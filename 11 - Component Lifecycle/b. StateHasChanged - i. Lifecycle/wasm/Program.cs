/*! European Union Public License version 1.2 !*/
/*! Copyright © 2020 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using ComponentLifecycle_StateHasChanged_Lifecycle;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
await builder.Build().RunAsync();
