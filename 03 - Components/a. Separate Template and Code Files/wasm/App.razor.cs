/*! European Union Public License version 1.2 !*/
/*! Copyright © 2020 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components;

namespace Components_SeparateTempateAndCodeFiles;

public partial class App : ComponentBase
{
    private int count = 0;

    private void HandleClick() => count++;
}
