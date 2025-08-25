// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

using System.ComponentModel.DataAnnotations;

namespace Forms_Validation_Custom;

[DemoValidation]
public class DemoModel
{
    public string? First { get; set; }

    public string? Second { get; set; }
}

internal class DemoValidationAttribute : ValidationAttribute
{
    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        //if (validationContext.ObjectInstance is not DemoModel model)
        if (value is not DemoModel model)
            return new ValidationResult("Cannot validate input");

        // Custom validation logic
        if ((string.IsNullOrEmpty(model?.First) && string.IsNullOrEmpty(model?.Second))
        || (!string.IsNullOrEmpty(model?.First) && !string.IsNullOrEmpty(model?.Second)))
        {
            return new ValidationResult("One of First or Second should have a value (not both).");
        }

        return ValidationResult.Success;
    }
}
