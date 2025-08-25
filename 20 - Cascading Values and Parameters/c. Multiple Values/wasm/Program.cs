/*! European Union Public License version 1.2 !*/
/*! Copyright © 2021 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using CascadingValuesParameters_MultipleValues;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<Top>("#app");
await builder.Build().RunAsync();
