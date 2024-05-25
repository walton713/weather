using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

/// <summary>
/// A representation of the successful response for alerts from the National Weather Service (NWS) API.
/// </summary>
public class AlertsResponse
{
    /// <summary>
    /// Gets or sets the type of the response. For alerts this should always be FeatureCollection.
    /// </summary>
    /// <value>The type of the response.</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the individual alerts in the response.
    /// </summary>
    /// <value>The individual alerts in the response.</value>
    [JsonPropertyName("features")]
    public IEnumerable<Alert> Features { get; set; }

    /// <summary>
    /// Gets or sets the title of the response.
    /// </summary>
    /// <value>The title of the response.</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }

    /// <summary>
    /// Gets or sets the date and time the response was updated.
    /// </summary>
    /// <value>The date and time the response was updated.</value>
    [JsonPropertyName("updated")]
    public DateTime Updated { get; set; }

    /// <summary>
    /// Gets or sets the pagination information for the response.
    /// </summary>
    /// <value>The pagination information for the response.</value>
    /// <remarks>This value is used to get subsequent pages of alerts.</remarks>
    [JsonPropertyName("pagination")]
    public PaginationInfo Pagination { get; set; }
}
