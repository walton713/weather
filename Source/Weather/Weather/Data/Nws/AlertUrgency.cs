using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

/// <summary>
/// A representation of the urgency of an alert from the National Weather Service (NWS) API.
/// </summary>
[Flags]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlertUrgency
{
    /// <summary>
    /// The alert is for an expected event.
    /// </summary>
    Expected = 1,

    /// <summary>
    /// The alert is for a future event.
    /// </summary>
    Future = 2,

    /// <summary>
    /// The alert is for an immediate event.
    /// </summary>
    Immediate = 4,

    /// <summary>
    /// The alert is for an event that has happened.
    /// </summary>
    Past = 8,

    /// <summary>
    /// The alert is for an unknown event.
    /// </summary>
    Unknown = 16
}
