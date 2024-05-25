using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

/// <summary>
/// A representation of the response required by an alert from the National Weather Service (NWS) API.
/// </summary>
[Flags]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlertResponse
{
    /// <summary>
    /// The response is an all clear.
    /// </summary>
    AllClear = 1,

    /// <summary>
    /// The response is to assess.
    /// </summary>
    Assess = 2,

    /// <summary>
    /// The response is to avoid.
    /// </summary>
    Avoid = 4,

    /// <summary>
    /// The response is to evacuate.
    /// </summary>
    Evacuate = 8,

    /// <summary>
    /// The response is to execute.
    /// </summary>
    Execute = 16,

    /// <summary>
    /// The response is to monitor.
    /// </summary>
    Monitor = 32,

    /// <summary>
    /// No response necessary.
    /// </summary>
    None = 64,

    /// <summary>
    /// The response is to prepare.
    /// </summary>
    Prepare = 128,

    /// <summary>
    /// The response is to take shelter.
    /// </summary>
    Shelter = 256
}
