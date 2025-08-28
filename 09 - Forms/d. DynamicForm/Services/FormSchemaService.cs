using DynamicForms.Models;

namespace DynamicForms.Services;

public class FormSchemaService
{
    public Task<IReadOnlyList<DynamicField>> GetCustomerFormAsync()
    {
        var fields = new List<DynamicField>
        {
            new() { Label = "Name", Property = "Name", Type = "text", Required = true, Placeholder = "Jane Doe" },
            new() { Label = "Age", Property = "Age", Type = "number", Required = true, Placeholder = "28" }
        };
        return Task.FromResult<IReadOnlyList<DynamicField>>(fields);
    }
}
