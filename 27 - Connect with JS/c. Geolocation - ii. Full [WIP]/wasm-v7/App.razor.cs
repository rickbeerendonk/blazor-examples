// European Union Public License version 1.2
// Copyright © 2023 Rick Beerendonk

using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using System.Text.Json.Serialization;

namespace GeolocationDemo;

public partial class App
{
    [JSImport("getCurrentPosition", "App")]
    [return: JSMarshalAs<JSType.Promise<JSType.Object>>()]
    internal static partial Task<JSObject> GetCurrentPositionJS();
}

public class GeolocationPosition
{
    public GeolocationCoordinates Coords { get; set; }
    public long Timestamp { get; set; }
    [JsonIgnore]
    public DateTimeOffset DateTimeOffset => DateTimeOffset.FromUnixTimeMilliseconds(Timestamp);
}

public class GeolocationCoordinates
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public double? Altitude { get; set; }
    public double Accuracy { get; set; }
    public double? AltitudeAccuracy { get; set; }
    public double? Heading { get; set; }
    public double? Speed { get; set; }
}
