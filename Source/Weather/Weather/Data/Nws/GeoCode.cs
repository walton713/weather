using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

public class GeoCode
{
    [JsonPropertyName("UGC")]
    public IEnumerable<string> Ugc { get; set; }

    [JsonPropertyName("SAME")]
    public IEnumerable<string> Same { get; set; }
}
