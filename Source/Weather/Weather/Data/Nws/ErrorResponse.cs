namespace Weather.Data.Nws;

/// <summary>
/// A representation of the error response from the National Weather Service (NWS) API.
/// </summary>
public class ErrorResponse
{
    /// <summary>
    /// Gets or sets the correlation id of the response.
    /// </summary>
    /// <value>The correlation id of the response.</value>
    public string CorrelationId { get; set; }

    /// <summary>
    /// Gets or sets the title of the response.
    /// </summary>
    /// <value>The title of the response.</value>
    public string Title { get; set; }

    /// <summary>
    /// Gets or sets the type of the response.
    /// </summary>
    /// <value>The type of the response.</value>
    public string Type { get; set; }

    /// <summary>
    /// Gets or sets the status of the response. This is the same as HTTP Status Code.
    /// </summary>
    /// <value>The status of the response.</value>
    public int Status { get; set; }

    /// <summary>
    /// Gets or sets the details of the response.
    /// </summary>
    /// <value>The details of the response.</value>
    public string Detail { get; set; }

    /// <summary>
    /// Gets or sets the instance of the response.
    /// </summary>
    /// <value>The instance of the response.</value>
    public string Instance { get; set; }
}
