using OneOf;
using Weather.Data.Nws;

namespace Weather.Services;

/// <summary>
/// Provides an abstraction for getting data from the National Weather Service (NWS) API.
/// </summary>
/// <remarks>
/// <para>For more information about the NWS API visit <see href="https://www.weather.gov/documentation/services-web-api">their documentation.</see></para>
/// <para>The OneOf package used can be found <see href="https://github.com/mcintyre321/OneOf">here.</see></para>
/// </remarks>
public interface INwsService
{
    /// <summary>
    /// Gets the latest alerts from the NWS API as an asynchronous operation.
    /// </summary>
    /// <returns>The task object containing the response from the API.</returns>
    Task<OneOf<AlertResponse, ErrorResponse>> GetAlertsAsync();
}
