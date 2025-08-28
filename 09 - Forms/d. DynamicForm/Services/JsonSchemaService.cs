using System.Net.Http.Json;
using DynamicForms.Models;

namespace DynamicForms.Services;

public class JsonSchemaService
{
    private readonly HttpClient http;
    public JsonSchemaService(HttpClient http) => this.http = http;

    public async Task<JsonSchema> GetAsync(string path = "schema/customer.json")
        => (await http.GetFromJsonAsync<JsonSchema>(path)) ?? new JsonSchema();
}
