using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

/// <summary>
/// A representation of the pagination info returned in a response from the National Weather Service (NWS) API.
/// </summary>
public class PaginationInfo
{
    /// <summary>
    /// Gets or sets the next URL.
    /// </summary>
    /// <value>The next URL.</value>
    [JsonPropertyName("next")]
    public string Next { get; set; }
}
