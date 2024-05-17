using OneOf;
using Weather.Data.Nws;

namespace Weather.Services;

public class NwsService(HttpClient client) : INwsService
{
    public Task<OneOf<AlertResponse, ErrorResponse>> GetAlertsAsync()
    {
        throw new NotImplementedException();
    }
}
