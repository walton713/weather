using OneOf;
using Weather.Data.Nws;

namespace Weather.Services;

/// <summary>
/// Provides a class for getting data from the National Weather Service (NWS) API.
/// </summary>
/// <inheritdoc cref="INwsService"/>
public class NwsService : INwsService
{
    private readonly HttpClient _client;

    /// <summary>
    /// Initializes a new instance of the NwsService with the given HttpClient.
    /// </summary>
    /// <param name="client">The HttpClient to use for calls to the NWS API.</param>
    public NwsService(HttpClient client)
    {
        _client = client;
    }

    /// <remarks>The API returns 500 alerts by default.</remarks>
    /// <inheritdoc cref="INwsService.GetAlertsAsync"/>
    public Task<OneOf<AlertResponse, ErrorResponse>> GetAlertsAsync()
    {
        throw new NotImplementedException();
    }
}
