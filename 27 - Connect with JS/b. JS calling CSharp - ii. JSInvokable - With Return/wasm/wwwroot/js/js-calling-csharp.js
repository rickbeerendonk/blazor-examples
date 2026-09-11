// Call Blazor code every interval and use the returned value.
setInterval(async () => {
  const value = await DotNet.invokeMethodAsync(
    "JSCallingCSharp_JSInvokable_WithReturn",
    "GetRandomNumber",
  );
  console.log("JS received:", value);
}, 1000);
