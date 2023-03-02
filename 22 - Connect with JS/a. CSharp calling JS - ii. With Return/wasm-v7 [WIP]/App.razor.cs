using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace CSharpCallingJS_WithReturn;

public partial class App
{
    [JSImport("jsfunc", "App")]
    internal static partial double JSFunc(string input);
}