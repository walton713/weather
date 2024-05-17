using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlertSeverity
{
    Extreme,
    Severe,
    Moderate,
    Minor,
    Unknown
}
