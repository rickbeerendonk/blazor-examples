/*! European Union Public License version 1.2 !*/
/*! Copyright © 2020 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CompoundComponents_Basic;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<GreetingEditor>("#app");
await builder.Build().RunAsync();
