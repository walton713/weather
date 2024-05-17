using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlertCategory
{
    Met,
    Geo,
    Safety,
    Security,
    Rescue,
    Fire,
    Health,
    Env,
    Transport,
    Infra,
    CBRNE,
    Other
}
