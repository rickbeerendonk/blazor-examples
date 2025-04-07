// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

using Server.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSignalR();

// Add CORS policy to allow requests from the Blazor client application
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("https://localhost:5001", "https://localhost:44383")
              .AllowAnyHeader()
              .AllowAnyMethod()
              .AllowCredentials(); // needed for SignalR
    });
});

var app = builder.Build();

// Map the SignalR hub to the "/Chat" endpoint
app.MapHub<PingHub>("/ping");

// Use the CORS policy
app.UseCors();

// Serve the index.html file if running the server without the Blazor client.
app.UseStaticFiles();
app.MapFallbackToFile("index.html");

app.Run();
