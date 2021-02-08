// European Union Public License version 1.2
// Copyright © 2021 Rick Beerendonk

using System.ComponentModel.DataAnnotations;

namespace Forms_Validation_Individual
{
  public class DemoModel
  {
    [Required]
    [StringLength(10, ErrorMessage = "Name is too long.")]
    public string Name { get; set; }

    [Required]
    [Range(18, 67, ErrorMessage = "Age is out of range.")]
    public int Age { get; set; }
  }
}