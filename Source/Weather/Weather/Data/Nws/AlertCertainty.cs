using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

/// <summary>
/// A representation of the likelihood an event will occur in relation to an alert from the National Weather Service (NWS) API.
/// </summary>
[Flags]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlertCertainty
{
    /// <summary>
    /// An event is likely to happen in association with the alert.
    /// </summary>
    Likely = 1,

    /// <summary>
    /// An event has been observed in association with the alert.
    /// </summary>
    Observed = 2,

    /// <summary>
    /// An event is possible in association with the alert.
    /// </summary>
    Possible = 4,

    /// <summary>
    /// The likelihood of an event is unknown in association with the alert.
    /// </summary>
    Unknown = 8,

    /// <summary>
    /// An event is unlikely to occur in association with the alert.
    /// </summary>
    Unlikely = 16
}
