// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

using System.ComponentModel.DataAnnotations;

using Forms_Validation_Summary.Resources;

namespace Forms_Validation_Summary
{
    public class DemoModel
    {
        [Required(ErrorMessageResourceName = "NameRequired", ErrorMessageResourceType = typeof(ValidationMessages))]
        [StringLength(10, ErrorMessageResourceName = "NameTooLong", ErrorMessageResourceType = typeof(ValidationMessages))]
        public string? Name { get; set; }

        [Range(18, 67, ErrorMessageResourceName = "AgeOutOfRange", ErrorMessageResourceType = typeof(ValidationMessages))]
        public int Age { get; set; }
    }
}