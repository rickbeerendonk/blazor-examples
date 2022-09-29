/*! European Union Public License version 1.2 !*/
/*! Copyright © 2021 Rick Beerendonk          !*/

using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Fetch_WebApi_Client
{
    public class Todo
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public bool Completed { get; set; }
    }

    public interface ITodosService
    {
        // Get all
        Task<Todo[]?> TodosAsync();

        // Post
        Task<bool> AddAsync(Todo value);

        // Delete
        Task<bool> DeleteAsync(Todo value);

        // Put
        Task<bool> UpdateAsync(Todo value);
    }

    public class TodosHttpService : ITodosService
    {
        private readonly HttpClient http;
        private readonly Uri baseAddress = new Uri("https://localhost:5003/todos/");

        public TodosHttpService(HttpClient http)
        {
            http.BaseAddress = this.baseAddress;
            this.http = http;
        }

        public Task<Todo[]?> TodosAsync()
        {
            return http.GetFromJsonAsync<Todo[]?>("");
        }

        public Task<bool> AddAsync(Todo value)
        {
            Task<HttpResponseMessage> result = http.PostAsJsonAsync<Todo>("", value);
            return result.ContinueWith<bool>(response => response.Result.IsSuccessStatusCode);
        }

        public Task<bool> DeleteAsync(Todo value)
        {
            Task<HttpResponseMessage> result = http.DeleteAsync(new Uri(baseAddress, value.Id.ToString()));
            return result.ContinueWith<bool>(response => response.Result.IsSuccessStatusCode);
        }

        public Task<bool> UpdateAsync(Todo value)
        {
            Task<HttpResponseMessage> result = http.PutAsJsonAsync(new Uri(baseAddress, value.Id.ToString()), value);
            return result.ContinueWith<bool>(response => response.Result.IsSuccessStatusCode);
        }
    }
}