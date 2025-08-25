using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

using DependencyInjection_Singleton;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Add local services
builder.Services.AddSingleton<LoggerService>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
