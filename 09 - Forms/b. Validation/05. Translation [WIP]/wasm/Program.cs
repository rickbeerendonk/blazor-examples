// European Union Public License version 1.2
// Copyright © 2020 Rick Beerendonk

using System.Globalization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Localization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Support translations
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.RootComponents.Add<App>("#app");

var host = builder.Build();

// Set the culture for the application
// Change "nl-NL" to "en-US" for English
var culture = new CultureInfo("nl-NL"); // Dutch by default
CultureInfo.DefaultThreadCurrentCulture = culture;
CultureInfo.DefaultThreadCurrentUICulture = culture;

await host.RunAsync();