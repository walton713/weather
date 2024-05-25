using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

/// <summary>
/// A representation of the properties of an alert feature from the National Weather Service (NWS) API.
/// </summary>
public class AlertProperties
{
    /// <summary>
    /// Gets or sets the id of the properties.
    /// </summary>
    /// <value>The id of the properties.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the area description of the alert.
    /// </summary>
    /// <value>The area description of the alert.</value>
    [JsonPropertyName("areaDesc")]
    public string AreaDescription { get; set; }

    /// <summary>
    /// Gets or sets the Geographical Code of the alert.
    /// </summary>
    /// <value>The Geographical Code of the alert.</value>
    [JsonPropertyName("geoCode")]
    public GeoCode Geocode { get; set; }

    /// <summary>
    /// Gets or sets the affected zones of the alert.
    /// </summary>
    /// <value>the affected zones of the alert.</value>
    [JsonPropertyName("affectedZones")]
    public IEnumerable<string> AffectedZones { get; set; }

    /// <summary>
    /// Gets or sets the references associated with the alert.
    /// </summary>
    /// <value>The references associated with the alert.</value>
    [JsonPropertyName("references")]
    public IEnumerable<AlertReference> References { get; set; }

    /// <summary>
    /// Gets or sets the date and time the alert was sent.
    /// </summary>
    /// <value>The date and time the alert was sent.</value>
    [JsonPropertyName("sent")]
    public DateTime Sent { get; set; }

    /// <summary>
    /// Gets or sets the date and time the alert is in effect.
    /// </summary>
    /// <value>The date and time the alert is in effect.</value>
    [JsonPropertyName("effective")]
    public DateTime Effective { get; set; }

    /// <summary>
    /// Gets or sets the date and time the alert starts.
    /// </summary>
    /// <value>The date and time the alert starts.</value>
    /// <remarks>If null, the date and time the alert was sent is considered the onset.</remarks>
    [JsonPropertyName("onset")]
    public DateTime? Onset { get; set; }

    /// <summary>
    /// Gets or sets the date and time the alert expires.
    /// </summary>
    /// <value>The date and time the alert expires.</value>
    [JsonPropertyName("expires")]
    public DateTime Expires { get; set; }

    /// <summary>
    /// Gets or sets the date and time the alert ends.
    /// </summary>
    /// <value>The date and time the alert ends.</value>
    /// <remarks>If null, the date and time the alert expires is considered the end.</remarks>
    [JsonPropertyName("ends")]
    public DateTime? Ends { get; set; }

    /// <summary>
    /// Gets or sets the status of the alert.
    /// </summary>
    /// <value>The status of the alert.</value>
    /// <remarks>Possible values are Actual, Draft, Exercise, System and Test.</remarks>
    [JsonPropertyName("status")]
    public AlertStatus Status { get; set; }

    /// <summary>
    /// Gets or sets the message type of the alert.
    /// </summary>
    /// <value>the message type of the alert.</value>
    /// <remarks>Possible values are Ack, Alert, Cancel, Error and Update.</remarks>
    [JsonPropertyName("messageType")]
    public AlertMessageType MessageType { get; set; }

    /// <summary>
    /// Gets or sets the category of the alert.
    /// </summary>
    /// <value>The category of the alert.</value>
    /// <remarks>Possible values are CBRNE, Env, Fire, Geo, Health, Infra, Met, Other, Rescue, Safety, Security and Transport.</remarks>
    [JsonPropertyName("category")]
    public AlertCategory Category { get; set; }

    /// <summary>
    /// Gets or sets the severity of the alert.
    /// </summary>
    /// <value>The severity of the alert.</value>
    /// <remarks>Possible values are Extreme, Minor, Moderate, Severe and Unknown.</remarks>
    [JsonPropertyName("severity")]
    public AlertSeverity Severity { get; set; }

    /// <summary>
    /// Gets or sets the certainty of the alert.
    /// </summary>
    /// <value>The certainty of the alert.</value>
    /// <remarks>Possible values are Likely, Observed, Possible, Unknown and Unlikely.</remarks>
    [JsonPropertyName("certainty")]
    public AlertCertainty Certainty { get; set; }

    /// <summary>
    /// Gets or sets the urgency of the alert.
    /// </summary>
    /// <value>The urgency of the alert.</value>
    /// <remarks>Possible values are Expected, Future, Immediate, Past and Unknown.</remarks>
    [JsonPropertyName("urgency")]
    public AlertUrgency Urgency { get; set; }

    /// <summary>
    /// Gets or sets the event of the alert.
    /// </summary>
    /// <value>The event of the alert.</value>
    [JsonPropertyName("event")]
    public string Event { get; set; }

    /// <summary>
    /// Gets or sets the sender of the alert.
    /// </summary>
    /// <value>The sender of the alert.</value>
    [JsonPropertyName("sender")]
    public string Sender { get; set; }

    /// <summary>
    /// Gets or sets the name of the sender of the alert.
    /// </summary>
    /// <value>The name of the sender of the alert.</value>
    [JsonPropertyName("senderName")]
    public string SenderName { get; set; }

    /// <summary>
    /// Gets or sets the headline of the alert.
    /// </summary>
    /// <value>The headline of the alert.</value>
    [JsonPropertyName("headline")]
    public string? Headline { get; set; }

    /// <summary>
    /// Gets or sets the description of the alert.
    /// </summary>
    /// <value>The description of the alert.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or sets the instructions for the alert.
    /// </summary>
    /// <value>The instructions for the alert.</value>
    [JsonPropertyName("instruction")]
    public string? Instruction { get; set; }

    /// <summary>
    /// Gets or sets the response for the alert.
    /// </summary>
    /// <value>The response for the alert.</value>
    [JsonPropertyName("response")]
    public AlertResponse Response { get; set; }
}
