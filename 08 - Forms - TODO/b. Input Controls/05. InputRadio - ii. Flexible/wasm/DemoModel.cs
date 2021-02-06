// European Union Public License version 1.2
// Copyright © 2021 Rick Beerendonk

using System.ComponentModel.DataAnnotations;

namespace Forms_InputControls_InputRadio_Flexible
{
    public enum Options { A, B, C };

    public class DemoModel
  {
    public Options Value { get; set; }
  }
}