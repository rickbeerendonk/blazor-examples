// European Union Public License version 1.2
// Copyright © 2024 Rick Beerendonk

using Microsoft.AspNetCore.Components;

namespace Demo;

public partial class Greeting : ComponentBase
{
    [Inject(Key = "two")]
    private ILogger Logger { get; set; }

    protected override void OnInitialized()
    {
        Logger.Info("Greeting component created.");
    }
}