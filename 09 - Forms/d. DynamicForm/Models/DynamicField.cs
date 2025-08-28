namespace DynamicForms.Models;

public class DynamicField
{
    public string Label { get; set; } = default!;
    public string Property { get; set; } = default!;
    public string Type { get; set; } = "text"; // supported: text, number
    public bool Required { get; set; }
    public string? Placeholder { get; set; }
}
