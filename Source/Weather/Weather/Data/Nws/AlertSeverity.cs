using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

/// <summary>
/// A representation of the severity of an alert from the National Weather Service (NWS) API.
/// </summary>
[Flags]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlertSeverity
{
    /// <summary>
    /// The alert is of extreme severity.
    /// </summary>
    Extreme = 1,

    /// <summary>
    /// The alert is of minor severity.
    /// </summary>
    Minor = 2,

    /// <summary>
    /// The alert is of moderate severity.
    /// </summary>
    Moderate = 4,

    /// <summary>
    /// The alert is of severe severity.
    /// </summary>
    Severe = 8,

    /// <summary>
    /// The alert is of unknown severity.
    /// </summary>
    Unknown = 16
}
