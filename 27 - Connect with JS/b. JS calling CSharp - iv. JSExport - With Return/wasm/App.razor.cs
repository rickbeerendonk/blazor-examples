// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

using System.Runtime.InteropServices.JavaScript;

namespace JSCallingCSharp_JSExport;

public partial class App
{
    [JSExport]
    public static string GetMessage(string input)
    {
        return $"C# received: {input}";
    }
}
