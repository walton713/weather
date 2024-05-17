using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

[Flags]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlertMessageType
{
    Alert = 0,
    Update = 1,
    Cancel = 2,
    Ack = 4,
    Error = 8
}
