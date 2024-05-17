using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

public class AlertsResponse
{
    [JsonPropertyName("type")]
    public string Type { get; set; }

    [JsonPropertyName("features")]
    public IEnumerable<Alert> Features { get; set; }

    [JsonPropertyName("title")]
    public string Title { get; set; }

    [JsonPropertyName("updated")]
    public DateTime Updated { get; set; }

    [JsonPropertyName("pagination")]
    public PaginationInfo Pagination { get; set; }
}
