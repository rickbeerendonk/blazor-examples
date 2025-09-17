/* European Union Public License version 1.2 */
/* Copyright © 2025 Rick Beerendonk */

window.jsCallDotNetInstance = {
  register: function (dotNetObject) {
    setInterval(async () => {
      const result = await dotNetObject.invokeMethodAsync('GetTime');
      console.log(result);
    }, 1000);
  }
};
