await Blazor.start();

const { getAssemblyExports } = await globalThis.getDotnetRuntime(0);
const exports = await getAssemblyExports("JSCallingCSharp_JSExport.dll");
const exportedApp = exports.JSCallingCSharp_JSExport.App;

setInterval(() => {
  const input = new Date().toISOString();
  const output = exportedApp.GetMessage(input);
  console.log(output);
}, 1000);
