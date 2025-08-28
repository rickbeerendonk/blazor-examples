using DynamicForms.Models;

namespace DynamicForms.Services;

public class FormSchemaService
{
    public Task<IReadOnlyList<DynamicField>> GetCustomerFormAsync()
    {
        var fields = new List<DynamicField>
        {
            new() { Label = "Name", Property = "Name", Type = "text", Required = true, Placeholder = "Name" },
            new() { Label = "Age", Property = "Age", Type = "number", Required = true, Placeholder = "Age" }
        };
        return Task.FromResult<IReadOnlyList<DynamicField>>(fields);
    }
}
