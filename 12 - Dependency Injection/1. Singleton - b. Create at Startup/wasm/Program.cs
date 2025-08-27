/*! European Union Public License version 1.2 !*/
/*! Copyright © 2025 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

using DependencyInjection_Singleton_CreateAtStartup;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Add Services
//builder.Services.AddTransient<ILogger, LoggerService>();
builder.Services.AddSingleton<ILogger, LoggerService>();

var app = builder.Build();

// Force service creation (use AddTransient to demonstrate)
app.Services.GetRequiredService<ILogger>();

await app.RunAsync();
