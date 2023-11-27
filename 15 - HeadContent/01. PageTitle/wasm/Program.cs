/*! European Union Public License version 1.2 !*/
/*! Copyright © 2023 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using HeadContent_PageTitle;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// 1. HeadOutlet
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.RootComponents.Add<App>("#app");
await builder.Build().RunAsync();
