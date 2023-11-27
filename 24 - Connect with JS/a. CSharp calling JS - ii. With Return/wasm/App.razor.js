// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

// Function to call from Blazor code.
export function jsfunc(input) {
  console.log("JS received:", input);
  const output = Math.random();
  console.log("JS returns:", output);
  return output;
}
