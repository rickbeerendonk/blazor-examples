/*! European Union Public License version 1.2 !*/
/*! Copyright © 2020 Rick Beerendonk          !*/

using System;
using Microsoft.AspNetCore.Components;

namespace SeparateTempateAndCodeFiles_Basics
{
    public partial class App : ComponentBase
    {

        private int count = 0;

        private void handleClick(EventArgs e)
        {
            count++;
        }
    }
}