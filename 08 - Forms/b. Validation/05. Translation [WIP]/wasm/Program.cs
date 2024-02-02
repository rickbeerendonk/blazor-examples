/*! European Union Public License version 1.2 !*/
/*! Copyright © 2024 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.AspNetCore.Builder; 

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

var app = builder.Build();

app.UseRequestLocalization(); // This will use the localization options configured above

await app.RunAsync();
