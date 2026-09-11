// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

export async function onRuntimeReady({ getAssemblyExports }) {
  const exports = await getAssemblyExports("JSCallingCSharp_JSExport.dll");
  const exportedApp = exports.JSCallingCSharp_JSExport.App;

  setInterval(() => {
    const input = new Date().toISOString();
    const output = exportedApp.GetMessage(input);
    console.log(output);
  }, 1000);
}
