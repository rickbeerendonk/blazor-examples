# JS calling CSharp - Instance Method

This sample shows how JavaScript can call a .NET instance method in a Blazor WebAssembly app.

1. The component passes a `DotNetObjectReference` created from `this` to JavaScript.
2. JavaScript stores the reference and calls the .NET method `GetTime` every second.
3. The .NET method updates the component state and returns the current time, which is logged in the browser console.

Run the project with `dotnet watch run` and open the browser console to see the updates.

