/*! European Union Public License version 1.2 !*/
/*! Copyright © 2020 Rick Beerendonk          !*/

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace DataBinding_DataToView_Content
{
    public partial class App : ComponentBase
    {
        private string name = "Blazor";

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "h1");
            builder.AddContent(1, "Hello ");
            builder.AddContent(2, name);
            builder.AddContent(3, "!");
            builder.CloseElement();
        }
    }
}
