using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

public class AlertReference
{
    [JsonPropertyName("@id")]
    public string Id { get; set; }

    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }

    [JsonPropertyName("sender")]
    public string Sender { get; set; }

    [JsonPropertyName("sent")]
    public DateTime Sent { get; set; }
}
