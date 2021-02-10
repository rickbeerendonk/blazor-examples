using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace server.Controllers
{
    [Route("[controller]")]
    public class TodosController : Controller
    {
        // Some dummy data (normally this would be stored in the database, for example.
        private static Dictionary<int, Todo> data = new Dictionary<int, Todo>()
        {
            [0] = new Todo { Title = "Learn Danish", Completed = false },
            [1] = new Todo { Title = "Learn Dutch", Completed = true },
            [2] = new Todo { Title = "Learn Norwegian", Completed = false },
        };
        private static int nextid = 3;

        // GET: /todos
        [HttpGet]
        public IEnumerable<Todo> Get()
        {
            return data.Values;
        }

        // GET /todos/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            if (!data.ContainsKey(id))
            {
                // Set the HTTP status code to 404 (Not Found).
                return NotFound();
            }
            else
            {
                // Set the HTTP status code to 200 (OK), and return the requested item in the HTTP response payload.
                return new ObjectResult(data[id]);
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
            else
            {
                // Insert the item.
                var id = nextid++;
                data[id] = value;

                // Set the HTTP status code to 201 (Created), also set the HTTP Location header, and return the enriched item in the HTTP response payload.
                return CreatedAtAction("GetById",         // Name of GET action method (for URL).
                                        new { id = id },  // Parameters for GET method (for URL).
                                        value);           // Enriched object to return to client.
            }
        }

        // PUT /todos/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Todo value)
        {
            if (value == null)
            {
                // Set the HTTP status code to 400 (Bad Request).
                return BadRequest();
            }
            else if (!data.ContainsKey(id))
            {
                // Set the HTTP status code to 404 (Not Found).
                return NotFound();
            }
            else
            {
                // Update the item.
                data[id] = value;

                // Set the HTTP status code to 204 (No Content, i.e. effectively void).
                return new NoContentResult();
            }
        }

        // DELETE /todos/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (!data.ContainsKey(id))
            {
                // Set the HTTP status code to 404 (Not Found).
                return NotFound();
            }
            else
            {
                // Delete the item.
                data.Remove(id);

                // Set the HTTP status code to 204 (No Content, i.e. effectively void).
                return new NoContentResult();
            }
        }
    }

    public class Todo
    {
        public string Title { get; set; }

        public bool Completed { get; set; }
    }
}
