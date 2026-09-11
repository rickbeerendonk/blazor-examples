await Blazor.start();

const { getAssemblyExports } = await globalThis.getDotnetRuntime(0);
const exports = await getAssemblyExports(
  "JSCallingCSharp_JSExport_WithoutReturn.dll",
);
const exportedApp = exports.JSCallingCSharp_JSExport_WithoutReturn.App;

setInterval(() => {
  const input = new Date().toISOString();
  exportedApp.LogMessage(input);
}, 1000);
