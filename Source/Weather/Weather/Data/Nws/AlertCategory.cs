using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

/// <summary>
/// A representation of the category of an alert from the National Weather Service (NWS) API.
/// </summary>
[Flags]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlertCategory
{

    /// <summary>
    /// A Chemical, Biological, Radiological, Nuclear or High-Yield Explosive alert.
    /// </summary>
    CBRNE = 1,

    /// <summary>
    ///  An Environmental alert.
    /// </summary>
    Env = 2,

    /// <summary>
    /// A Fire alert.
    /// </summary>
    Fire = 4,

    /// <summary>
    /// A Geological alert.
    /// </summary>
    Geo = 8,

    /// <summary>
    /// A Health alert.
    /// </summary>
    Health = 16,

    /// <summary>
    /// An Infrastructure alert.
    /// </summary>
    Infra = 32,

    /// <summary>
    /// A Meteorological alert.
    /// </summary>
    Met = 64,

    /// <summary>
    /// An alert not described by the other values.
    /// </summary>
    Other = 128,

    /// <summary>
    /// A Rescue alert.
    /// </summary>
    Rescue = 256,

    /// <summary>
    /// A Safety alert.
    /// </summary>
    Safety = 512,

    /// <summary>
    /// A Security alert.
    /// </summary>
    Security = 1024,

    /// <summary>
    /// A Transportation alert.
    /// </summary>
    Transport = 2048
}
