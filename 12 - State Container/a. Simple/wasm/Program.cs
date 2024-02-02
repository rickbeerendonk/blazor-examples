/*! European Union Public License version 1.2 !*/
/*! Copyright © 2020 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

using StateContainer_Simple;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<Top>("#app");

// Add Services
builder.Services.AddScoped<AppState>();

await builder.Build().RunAsync();
