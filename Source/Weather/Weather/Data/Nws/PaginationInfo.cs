using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

public class PaginationInfo
{
    [JsonPropertyName("next")]
    public string Next { get; set; }
}
