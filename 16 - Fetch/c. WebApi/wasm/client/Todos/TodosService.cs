/*! European Union Public License version 1.2 !*/
/*! Copyright © 2021 Rick Beerendonk          !*/

using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Fetch_WebApi_Client
{
    public class Todo
    {
        public string Title { get; set; }

        public bool Completed { get; set; }
    }

#nullable enable

    public interface ITodosService
    {
        Task<Todo[]?> TodosAsync();
    }

    public class TodosHttpService : ITodosService
    {
        private HttpClient http;

        public TodosHttpService(HttpClient http) => this.http = http;

        public Task<Todo[]?> TodosAsync()
        {
            return http.GetFromJsonAsync<Todo[]?>("https://localhost:5003/todos");
        }

        /*
                public async bool AddAsync(Todo value)
                {
                    Task<HttpResponseMessage> result = await http.PostAsJsonAsync<Todo>("https://localhost:5003/todos", value);
                    result.GetAwaiter()
                }
        */
    }
}