/*! European Union Public License version 1.2 !*/
/*! Copyright © 2022 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components;

namespace DependencyInjection_Singleton_CodeBehind;

public partial class App : ComponentBase
{
    // In Blazor components:
    // - Constructor injection is not possible
    // - Inject only through properties
    [Inject]
    private LoggerService? Logger { get; set; }

    protected override void OnInitialized()
    {
        Logger?.Info("App component created.");
    }
}
