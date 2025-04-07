// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

export async function getCurrentPosition() {
  const pos = await new Promise((resolve, reject) => {
    navigator.geolocation.getCurrentPosition(resolve, reject);
  });

  return {
    longitude: pos.coords.longitude,
    latitude: pos.coords.latitude,
  };
}
