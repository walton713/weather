using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

/// <summary>
/// A representation of alert features from the National Weather Service (NWS) API.
/// </summary>
public class Alert
{
    /// <summary>
    /// Gets or sets the id of the alert.
    /// </summary>
    /// <value>The id of the alert.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or sets the type of the alert.
    /// </summary>
    /// <value>The type of the alert.</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the properties of the alert.
    /// </summary>
    /// <value>The properties of the alert.</value>
    [JsonPropertyName("properties")]
    public AlertProperties Properties { get; set; }
}
