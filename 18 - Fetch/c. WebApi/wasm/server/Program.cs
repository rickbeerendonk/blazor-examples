// European Union Public License version 1.2
// Copyright © 2020 Rick Beerendonk

using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

// Allow CORS
builder.Services.AddCors(options =>
{
	options.AddDefaultPolicy(policy =>
		policy.AllowAnyOrigin()
			.AllowAnyHeader()
			.AllowAnyMethod()
	);
});

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseDeveloperExceptionPage();
	app.MapOpenApi();
	app.MapScalarApiReference();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();