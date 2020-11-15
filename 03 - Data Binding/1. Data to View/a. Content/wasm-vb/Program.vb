' European Union Public License version 1.2
' Copyright © 2020 Rick Beerendonk

Imports System.Threading.Tasks
Imports Microsoft.AspNetCore.Components.WebAssembly.Hosting

Module Program
    Public Sub Main(args As String())
        Dim builder = WebAssemblyHostBuilder.CreateDefault(args)
        builder.RootComponents.Add(of DataBinding_DataToView_Content.App)("#app")

        builder.Build().RunAsync()
    End Sub
End Module
