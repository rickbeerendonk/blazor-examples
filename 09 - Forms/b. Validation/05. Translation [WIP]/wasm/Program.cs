/*! European Union Public License version 1.2 !*/
/*! Copyright © 2024 Rick Beerendonk          !*/

using System.Globalization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Localization;

using Forms_Validation_Summary;
using Forms_Validation_Summary.Resources;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Support translations
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.RootComponents.Add<App>("#app");

var host = builder.Build();

// Set the default culture for the application
var defaultCulture = new CultureInfo("en-US");
var defaultUICulture = new CultureInfo("nl-NL");
CultureInfo.DefaultThreadCurrentCulture = defaultCulture;
CultureInfo.DefaultThreadCurrentUICulture = defaultUICulture;

await host.RunAsync();