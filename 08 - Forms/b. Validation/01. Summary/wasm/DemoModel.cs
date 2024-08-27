// European Union Public License version 1.2
// Copyright © 2020 Rick Beerendonk

using System.ComponentModel.DataAnnotations;

namespace Forms_Validation_Summary;

public class DemoModel
{
    [Required]
    [StringLength(10, ErrorMessage = "Name is too long.")]
    public string? Name { get; set; }

    [Range(18, 67, ErrorMessage = "Age is out of range.")]
    public int Age { get; set; }
}
