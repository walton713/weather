using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum AlertResponse
{
    Shelter,
    Evacuate,
    Prepare,
    Execute,
    Avoid,
    Monitor,
    Assess,
    AllClear,
    None
}
