using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlertUrgency
{
    Immediate,
    Expected,
    Future,
    Past,
    Unknown
}
