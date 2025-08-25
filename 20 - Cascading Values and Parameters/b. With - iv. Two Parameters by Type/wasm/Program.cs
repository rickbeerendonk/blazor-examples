/*! European Union Public License version 1.2 !*/
/*! Copyright © 2020 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using CascadingValuesParameters_With_TwoParametersByType;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<Top>("#app");
await builder.Build().RunAsync();
