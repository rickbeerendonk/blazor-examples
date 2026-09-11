// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

using System.Runtime.InteropServices.JavaScript;

namespace JSCallingCSharp_JSExport_WithoutReturn;

public partial class App
{
    [JSExport]
    public static void LogMessage(string input)
    {
        Console.WriteLine($"C# received: {input}");
    }
}
