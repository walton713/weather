using OneOf;
using Weather.Data.Nws;

namespace Weather.Services;

public interface INwsService
{
    Task<OneOf<AlertResponse, ErrorResponse>> GetAlertsAsync();
}
