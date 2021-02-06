/*! European Union Public License version 1.2 !*/
/*! Copyright © 2021 Rick Beerendonk          !*/

using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Fetch_Service
{
    public class Todo
    {
        public int UserID { get; set; }

        public int ID { get; set; }

        public string Title { get; set; }

        public bool Completed { get; set; }
    }

    #nullable enable

    public interface ITodosService {
        Task<Todo[]?> Todos();
    }

    public class TodosHttpService : ITodosService
    {
        private HttpClient http;

        public TodosHttpService(HttpClient http) => this.http = http;

        public Task<Todo[]?> Todos()
        {
            return http.GetFromJsonAsync<Todo[]>("https://jsonplaceholder.typicode.com/todos");
        }
    }
}