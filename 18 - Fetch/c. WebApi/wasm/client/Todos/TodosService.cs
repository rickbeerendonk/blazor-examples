/*! European Union Public License version 1.2 !*/
/*! Copyright © 2021 Rick Beerendonk          !*/

using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Demo.Todos;

public record Todo(int Id, string? Title, bool Completed);

public interface ITodosService
{
	// Get all
	Task<IEnumerable<Todo>> TodosAsync();

	// Post
	Task<bool> AddAsync(Todo value);

	// Delete
	Task<bool> DeleteAsync(Todo value);

	// Put
	Task<bool> UpdateAsync(Todo value);
}

public class TodosHttpService(HttpClient http) : ITodosService
{
	public async Task<IEnumerable<Todo>> TodosAsync()
	{
		// https://localhost:5003/todos
		return await http.GetFromJsonAsync<IEnumerable<Todo>>("") ?? [];
	}

	public async Task<bool> AddAsync(Todo value)
	{
		// https://localhost:5003/todos
		var response = await http.PostAsJsonAsync("", value);
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> DeleteAsync(Todo value)
	{
		// https://localhost:5003/todos/4
		var response = await http.DeleteAsync(value.Id.ToString());
		return response.IsSuccessStatusCode;
	}

	public async Task<bool> UpdateAsync(Todo value)
	{
		// https://localhost:5003/todos/4
		var response = await http.PutAsJsonAsync(value.Id.ToString(), value);
		return response.IsSuccessStatusCode;
	}
}
