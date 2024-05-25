using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

/// <summary>
/// A representation of the latest message type of an alert from the National Weather Service (NWS) API.
/// </summary>
[Flags]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlertMessageType
{
    /// <summary>
    /// The message is an acknowledgement.
    /// </summary>
    Ack = 1,

    /// <summary>
    /// The message is a new alert.
    /// </summary>
    Alert = 2,

    /// <summary>
    /// The message is a cancellation of an alert.
    /// </summary>
    Cancel = 4,

    /// <summary>
    /// The message was issued in error.
    /// </summary>
    Error = 8,

    /// <summary>
    /// the message is an update to an alert.
    /// </summary>
    Update = 16
}
