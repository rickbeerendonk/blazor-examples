// European Union Public License version 1.2
// Copyright © 2021 Rick Beerendonk

namespace Forms_InputControls_InputRadio_ForceSelection;

public enum Options { A, B, C };

public class DemoModel
{
  // To force the user to choose,
  // have a nullable enum and start with null
  public Options? Value { get; set; } = null;
}
