using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

public class Alert
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("properties")]
    public AlertProperties Properties { get; set; }
}
