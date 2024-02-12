// Call Blazor code every interval
setInterval(() => {
  DotNet.invokeMethodAsync("JSCallingCSharp_StaticMethod", "Ping");
}, 1000);
