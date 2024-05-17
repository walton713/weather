using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlertCertainty
{
    Observed,
    Likely,
    Possible,
    Unlikely,
    Unknown
}
