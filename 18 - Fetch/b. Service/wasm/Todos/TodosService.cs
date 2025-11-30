/*! European Union Public License version 1.2 !*/
/*! Copyright © 2021 Rick Beerendonk          !*/

using System.Net.Http.Json;

namespace Demo.Todos;

public record Todo(
    int UserId,
    int Id,
    string Title,
    bool Completed
);

#nullable enable

public interface ITodosService
{
    Task<IEnumerable<Todo>> TodosAsync();
}

public class TodosHttpService(HttpClient http) : ITodosService
{
    public async Task<IEnumerable<Todo>> TodosAsync()
    {
        return await http.GetFromJsonAsync<IEnumerable<Todo>>("https://jsonplaceholder.typicode.com/todos") ?? [];
    }
}
