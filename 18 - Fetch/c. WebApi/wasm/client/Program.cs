/*! European Union Public License version 1.2 !*/
/*! Copyright © 2021 Rick Beerendonk          !*/

using System.Net.Http;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

using Demo;
using Demo.Todos;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

builder.Services.AddHttpClient<ITodosService, TodosHttpService>(client =>
	client.BaseAddress = new Uri("http://localhost:5011/todos/"));

await builder.Build().RunAsync();
