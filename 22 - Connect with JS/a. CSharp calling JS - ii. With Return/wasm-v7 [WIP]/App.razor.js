// Function to call from Blazor code.
function jsfunc(input) {
  console.log("JS received:", input);
  const output = Math.random();
  console.log("JS returns:", output);
  return output;
}
