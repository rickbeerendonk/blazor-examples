/*! European Union Public License version 1.2 !*/
/*! Copyright © 2020 Rick Beerendonk          !*/

// 1. Namespace for HeadOutlet
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using PageTitle_In_Router;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// 1. HeadOutlet
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.RootComponents.Add<App>("#app");
await builder.Build().RunAsync();
