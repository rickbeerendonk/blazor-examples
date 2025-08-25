' European Union Public License version 1.2
' Copyright © 2020 Rick Beerendonk

Imports System
Imports Microsoft.AspNetCore.Components
Imports Microsoft.AspNetCore.Components.Rendering

Namespace DataBinding_DataToView_Content
    Partial Public Class App : Inherits ComponentBase
        Private name As String = "Blazor"

        Protected Overrides Sub BuildRenderTree(builder As RenderTreeBuilder)
            builder.OpenElement(0, "h1")
            builder.AddContent(1, "Hello ")
            builder.AddContent(2, name)
            builder.AddContent(3, "!")
            builder.CloseElement()
        End Sub
    End Class
End Namespace
