// Step 8b: Add usings:
using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

			// Step 7a: Add BlazorWebView control to the form (WebView2)
			// Step 7b: Set Layout Dock property to Fill

			// Step 8b: Add Blazor startup (similar as Program.cs in Blazor WASM Apps)
			var services = new ServiceCollection();
			services.AddWindowsFormsBlazorWebView();
			blazorWebView1.HostPage = "wwwroot\\index.html";
			blazorWebView1.Services = services.BuildServiceProvider();
			blazorWebView1.RootComponents.Add<Count>("#app");
		}
	}
}
