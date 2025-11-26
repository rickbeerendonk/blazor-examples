// European Union Public License version 1.2
// Copyright © 2025 Rick Beerendonk

using System.ComponentModel.DataAnnotations;

namespace Demo;

public class DemoModel(int MinAge, int MaxAge) : IValidatableObject
{
    // Validation parameters
    private readonly int minAge = MinAge;
    private readonly int maxAge = MaxAge;

    // Properties to set in a form
    [Required]
    [StringLength(10, ErrorMessage = "Name is too long.")]
    public string? Name { get; set; }

    public int Age { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        if (Age < minAge || Age > maxAge)
        {
            yield return new ValidationResult(
                $"Age is out of range ({minAge}-{maxAge}).",
                [ nameof(Age) ]);
        }
    }
}
