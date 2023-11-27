// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

export async function getCurrentPosition() {
  // MDN Docs: https://developer.mozilla.org/en-US/docs/Web/API/Geolocation/getCurrentPosition

  // pos = {
  //   coords: { longitude, latitude, altitude, accuracy, altitudeAccuracy, heading, speed,  },
  //   timestamp
  // }
  const pos = await new Promise((resolve, reject) => {
    function errorCallback(err) {
      // err = { code, message }
      // code: 1 = PERMISSION_DENIED, 2 = POSITION_UNAVAILABLE, 3 = TIMEOUT
      reject(err.message);
    }

    navigator.geolocation.getCurrentPosition(reject, errorCallback, {
      maximumAge: 0 /* default = 0 */,
      timeout: 10000 /* default = infinity */,
      enableHighAccuracy: true /* default = false, true consumes more energy */,
    });
    reject();
  });

  return pos;
}
