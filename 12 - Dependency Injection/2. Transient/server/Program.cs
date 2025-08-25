using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

using DependencyInjection_Transient;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Add local services
builder.Services.AddTransient<LoggerService>();

var app = builder.Build();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
