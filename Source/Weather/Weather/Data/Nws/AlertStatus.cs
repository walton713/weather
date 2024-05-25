using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

/// <summary>
/// A representation of the status of an alert from the National Weather Service (NWS) API.
/// </summary>
[Flags]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlertStatus
{
    /// <summary>
    /// This is an actual alert.
    /// </summary>
    Actual = 1,

    /// <summary>
    /// This is an exercise.
    /// </summary>
    Exercise = 2,

    /// <summary>
    /// This is a system alert.
    /// </summary>
    System = 4,

    /// <summary>
    /// This is a test.
    /// </summary>
    Test = 8,

    /// <summary>
    /// This is a draft alert.
    /// </summary>
    Draft = 16
}
