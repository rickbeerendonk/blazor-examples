/*! European Union Public License version 1.2 !*/
/*! Copyright © 2024 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using Router_State_Persistent;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add Services
builder.Services.AddScoped<AppState>();

builder.RootComponents.Add<App>("#app");
await builder.Build().RunAsync();
