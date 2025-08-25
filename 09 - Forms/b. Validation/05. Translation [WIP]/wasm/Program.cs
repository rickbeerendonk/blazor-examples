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
builder.Services.AddDataAnnotationsLocalization(options =>
{
    options.DataAnnotationLocalizerProvider = (type, factory) =>
        factory.Create(typeof(ValidationMessages));
});

builder.RootComponents.Add<App>("#app");

var host = builder.Build();

// Set the default culture for the application
var defaultCulture = new CultureInfo("en-US");
CultureInfo.DefaultThreadCurrentCulture = defaultCulture;
CultureInfo.DefaultThreadCurrentUICulture = defaultCulture;

await host.RunAsync();