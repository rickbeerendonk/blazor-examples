using System.ComponentModel.DataAnnotations;

namespace DynamicForms.Models;

public class Customer
{
    [Required, StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Range(0, 120)]
    public int Age { get; set; }
}
