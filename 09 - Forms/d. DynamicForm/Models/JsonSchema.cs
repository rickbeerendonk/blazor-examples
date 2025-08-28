namespace DynamicForms.Models;

public class JsonSchema
{
    public string Title { get; set; } = "Form";
    public List<DynamicField> Fields { get; set; } = new();
}
