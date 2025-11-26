// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.ComponentModel.DataAnnotations;

namespace Demo;

public class DemoModel(Func<DemoModel, IEnumerable<ValidationResult>> validate) : IValidatableObject
{
    [Required]
    [StringLength(10, ErrorMessage = "Name is too long.")]
    public string? Name { get; set; }

    public int Age { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        return validate(this);
    }
}
