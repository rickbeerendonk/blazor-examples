/*! European Union Public License version 1.2 !*/
/*! Copyright © 2024 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Demo;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Add Services
builder.Services.AddKeyedSingleton<ILogger, LoggerService1>("one");
builder.Services.AddKeyedSingleton<ILogger, LoggerService2>("two");

await builder.Build().RunAsync();
