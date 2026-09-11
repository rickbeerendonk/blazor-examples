// European Union Public License version 1.2
// Copyright © 2026 Rick Beerendonk

export async function onRuntimeReady({ getAssemblyExports }) {
  const exports = await getAssemblyExports(
    "JSCallingCSharp_JSExport_WithoutReturn.dll",
  );
  const exportedApp = exports.JSCallingCSharp_JSExport_WithoutReturn.App;

  setInterval(() => {
    const input = new Date().toISOString();
    exportedApp.LogMessage(input);
  }, 1000);
}
