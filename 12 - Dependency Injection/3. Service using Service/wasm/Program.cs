/*! European Union Public License version 1.2 !*/
/*! Copyright © 2022 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

using DependencyInjection_ServiceUsingService;
using ILogger = DependencyInjection_ServiceUsingService.ILogger;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Add Services
builder.Services.AddSingleton<ILogger, LoggerService>();
builder.Services.AddSingleton<IOther, OtherService>();
await builder.Build().RunAsync();
