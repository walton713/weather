using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

[Flags]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlertStatus
{
    Actual = 0,
    Exercise = 1,
    System = 2,
    Test = 4,
    Draft = 8
}
