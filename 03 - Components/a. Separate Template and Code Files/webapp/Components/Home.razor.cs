/*! European Union Public License version 1.2 !*/
/*! Copyright © 2020 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components;

namespace Demo.Components;

public partial class Home : ComponentBase
{
    private int count = 0;

    private void HandleClick() => count++;
}
