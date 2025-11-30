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

// Some dummy data (normally this would be stored in the database, for example)
List<Todo> data =
[
	new(Id: 0, Title: "Learn Danish", Completed: false),
	new(Id: 1, Title: "Learn Dutch", Completed: true),
	new(Id: 2, Title: "Learn Norwegian", Completed: false)
];
var nextid = 3;

// GET: /todos
app.MapGet("/todos", () => data);

// GET /todos/3
app.MapGet("/todos/{id:int}", (int id) =>
	data.Find(t => t.Id == id) is { } todo ? Results.Ok(todo) : Results.NotFound());

// POST /todos
app.MapPost("/todos", (Todo? value) =>
{
	if (value is null)
	{
		return Results.BadRequest();
	}

	value.Id = nextid++;
	data.Add(value);

	return Results.CreatedAtRoute("GetById", new { id = value.Id }, value);
}).WithName("GetById");

// PUT /todos/3
app.MapPut("/todos/{id:int}", (int id, Todo? value) =>
{
	if (value is null)
	{
		return Results.BadRequest();
	}

	var index = data.FindIndex(t => t.Id == id);
	if (index < 0)
	{
		return Results.NotFound();
	}

	data[index] = value;
	return Results.NoContent();
});

// DELETE /todos/3
app.MapDelete("/todos/{id:int}", (int id) =>
{
	var index = data.FindIndex(t => t.Id == id);
	if (index < 0)
	{
		return Results.NotFound();
	}

	data.RemoveAt(index);
	return Results.NoContent();
});

app.Run();

public record Todo(int Id, string? Title, bool Completed)
{
	public int Id { get; set; } = Id;
	public string? Title { get; set; } = Title;
	public bool Completed { get; set; } = Completed;
}