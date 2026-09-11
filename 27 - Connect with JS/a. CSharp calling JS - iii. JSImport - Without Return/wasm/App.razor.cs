// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

using System.Runtime.InteropServices.JavaScript;

namespace CSharpCallingJS_JSImport_WithoutReturn;

public partial class App
{
    [JSImport("jsfunc", "App")]
    internal static partial void JSFunc(string input);
}