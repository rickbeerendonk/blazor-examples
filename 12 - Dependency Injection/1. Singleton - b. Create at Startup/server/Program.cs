using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using DependencyInjection_Singleton_CreateAtStartup;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Add local services
//builder.Services.AddTransient<ILogger, LoggerService>();
builder.Services.AddSingleton<ILogger, LoggerService>();

var app = builder.Build();

// Force service creation (use AddTransient to demonstrate)
app.Services.GetRequiredService<ILogger>();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
