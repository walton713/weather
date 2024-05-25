using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

/// <summary>
/// A representation of the references for an alert from the National Weather Service (NWS) API.
/// </summary>
public class AlertReference
{
    /// <summary>
    /// Gets or sets the id of the reference
    /// </summary>
    /// <value>The id of the reference.</value>
    [JsonPropertyName("@id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the reference
    /// </summary>
    /// <value>The identifier of the reference.</value>
    [JsonPropertyName("identifier")]
    public string Identifier { get; set; }

    /// <summary>
    /// Gets or sets the sender of the reference.
    /// </summary>
    /// <value>The sender of the reference.</value>
    [JsonPropertyName("sender")]
    public string Sender { get; set; }

    /// <summary>
    /// Gets or sets the date and time the reference was sent.
    /// </summary>
    /// <value>The date and time the reference was sent.</value>
    [JsonPropertyName("sent")]
    public DateTime Sent { get; set; }
}
