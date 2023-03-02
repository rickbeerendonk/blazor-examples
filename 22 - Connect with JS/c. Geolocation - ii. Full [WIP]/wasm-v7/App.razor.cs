// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;

namespace GeolocationDemo;

public partial class App
{
    [JSImport("getCurrentPosition", "App")]
    [return: JSMarshalAs<JSType.Promise<JSType.Object>>()]
    internal static partial Task<JSObject> GetCurrentPositionJS();

    internal static getCurrentPosition()
    {

    }
}

public class GeolocationPosition
{
  public GeolocationCoordinates Coords { get; set; }
  //   timestamp
 }

public class GeolocationCoordinates
{
    Longitude { get; set; }
    Latitude { get; set; }
    Altitude { get; set; }
    Accuracy { get; set; }
    AltitudeAccuracy { get; set; }
    Heading { get; set; }
    Speed { get; set; }
}
