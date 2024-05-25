using System.Text.Json.Serialization;

namespace Weather.Data.Nws;

/// <summary>
/// A representation of the Geographical Code included in responses from the National Weather Service (NWS) API.
/// </summary>
public class GeoCode
{
    /// <summary>
    /// Gets or sets the Universal Geographic Code.
    /// </summary>
    /// <value>The Universal Geographic Code.</value>
    [JsonPropertyName("UGC")]
    public IEnumerable<string> Ugc { get; set; }

    /// <summary>
    /// Gets or sets the Specific Area Messaging Encoding location code.
    /// </summary>
    /// <value>The Specific Area Messaging Encoding location code.</value>
    [JsonPropertyName("SAME")]
    public IEnumerable<string> Same { get; set; }
}
