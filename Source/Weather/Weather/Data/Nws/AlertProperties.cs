using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

public class AlertProperties
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("areaDesc")]
    public string AreaDescription { get; set; }

    [JsonPropertyName("geoCode")]
    public GeoCode Geocode { get; set; }

    [JsonPropertyName("affectedZones")]
    public IEnumerable<string> AffectedZones { get; set; }

    [JsonPropertyName("references")]
    public IEnumerable<AlertReference> References { get; set; }

    [JsonPropertyName("sent")]
    public DateTime Sent { get; set; }

    [JsonPropertyName("effective")]
    public DateTime Effective { get; set; }

    [JsonPropertyName("onset")]
    public DateTime? Onset { get; set; }

    [JsonPropertyName("expires")]
    public DateTime Expires { get; set; }

    [JsonPropertyName("ends")]
    public DateTime? Ends { get; set; }

    [JsonPropertyName("status")]
    public AlertStatus Status { get; set; }

    [JsonPropertyName("messageType")]
    public AlertMessageType MessageType { get; set; }

    [JsonPropertyName("category")]
    public AlertCategory Category { get; set; }

    [JsonPropertyName("severity")]
    public AlertSeverity Severity { get; set; }

    [JsonPropertyName("certainty")]
    public AlertCertainty Certainty { get; set; }

    [JsonPropertyName("urgency")]
    public AlertUrgency Urgency { get; set; }

    [JsonPropertyName("event")]
    public string Event { get; set; }

    [JsonPropertyName("sender")]
    public string Sender { get; set; }

    [JsonPropertyName("senderName")]
    public string SenderName { get; set; }

    [JsonPropertyName("headline")]
    public string? Headline { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("instruction")]
    public string? Instruction { get; set; }

    [JsonPropertyName("response")]
    public AlertResponse Response { get; set; }
}
