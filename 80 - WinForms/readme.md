# WinForms App with Blazor

Create a .NET 8+ WinForms application

Steps:

1.  Add NuGet package `Microsoft.AspNetCore.Components.WebView.WindowsForms`
2.  In the project file, change Project Sdk to `Microsoft.NET.Sdk.Razor`
3.  Add \_Imports.razor to the root folder containing: `@using Microsoft.AspNetCore.Components.Web`
4.  Add HTML file (make sure link to `<AppName>.style.css` is correct)
5.  Add `css/app.css` file.
6.  Add a Razor component (in the root folder).
7.  Add BlazorWebView control (WebView2) to the form. Set Layout Dock property to Fill.
8.  Add code to Form:
    `
    using Microsoft.AspNetCore.Components.WebView.WindowsForms;
    using Microsoft.Extensions.DependencyInjection;

        namespace BlazorWinFormsApp;

        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();

        		var services = new ServiceCollection();
        		services.AddWindowsFormsBlazorWebView();
        		blazorWebView1.HostPage = "wwwroot\\index.html";
        		blazorWebView1.Services = services.BuildServiceProvider();
        		blazorWebView1.RootComponents.Add<Count>("#app");
        	}
        }

    `
