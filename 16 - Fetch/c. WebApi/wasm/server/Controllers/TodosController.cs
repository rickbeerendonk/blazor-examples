using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    [Route("[controller]")]
    public class TodosController : Controller
    {
        // Some dummy data (normally this would be stored in the database, for example.
        private static List<Todo> data = new List<Todo>()
        {
            new Todo { Id = 0, Title = "Learn Danish", Completed = false },
            new Todo { Id = 1, Title = "Learn Dutch", Completed = true },
            new Todo { Id = 2, Title = "Learn Norwegian", Completed = false },
        };
        private static int nextid = 3;

        // GET: /todos
        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            return data;
        }

        // GET /todos/3
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                Todo todo = data.First(todo => todo.Id == id);
                return new ObjectResult(todo);
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }

        // POST /todos
        [HttpPost]
        public IActionResult Post([FromBody] Todo value)
        {
            if (value == null)
            {
                // Set the HTTP status code to 400 (Bad Request).
                return BadRequest();
            }

            // Insert the item.
            value.Id = nextid++;
            data.Add(value);

            // Set the HTTP status code to 201 (Created), also set the HTTP Location header, and return the enriched item in the HTTP response payload.
            return CreatedAtAction("GetById",               // Name of GET action method (for URL).
                                    new { id = value.Id },  // Parameters for GET method (for URL).
                                    value);                 // Enriched object to return to client.
        }

        // PUT /todos/3
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Todo value)
        {
            if (value == null)
            {
                // Set the HTTP status code to 400 (Bad Request).
                return BadRequest();
            }

            int index = data.FindIndex(0, todo => todo.Id == id);
            if (index < 0)
            {
                // Set the HTTP status code to 404 (Not Found).
                return NotFound();
            }

            // Update the item.
            data[index] = value;

            // Set the HTTP status code to 204 (No Content, i.e. effectively void).
            return new NoContentResult();
        }

        // DELETE /todos/3
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            int index = data.FindIndex(0, todo => todo.Id == id);
            if (index < 0)
            {
                // Set the HTTP status code to 404 (Not Found).
                return NotFound();
            }

            // Delete the item.
            data.RemoveAt(index);

            // Set the HTTP status code to 204 (No Content, i.e. effectively void).
            return new NoContentResult();
        }
    }

    public class Todo
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public bool Completed { get; set; }
    }
}
