# INwsService.GetAlertsAsync Method

Reference

Namespace: [Weather.Services](Weather-Services.md)
Assembly: Weather

Get alerts from the National Weather Service (NWS) API as an asynchronous operation.

## Overloads

<table>
<tr>
<td><a href="GetAlertsAsync.md#GetAlertsAsync()">GetAlertsAsync()</a></td>
<td>Get the latest alerts from the NWS API as an asynchronous operation.</td>
</tr>
</table>

## GetAlertsAsync() {id=GetAlertsAsync()}

Source: [INwsService.cs](https://github.com/walton713/weather/blob/master/Source/Weather/Services/INwsService.cs#L8)

Get the latest alerts from the NWS API as an asynchronous operation.

```C#
public System.Threading.Tasks.Task<OneOf.OneOf<Weather.Data.Nws.AlertResponse, Weather.Data.Nws.ErrorResponse>> GetAlertsAsync ();
```

### Remarks {id=GetAlertsAsync()-Remarks}

This operation will return the 500 latest alerts from the NWS. For more information visit the [NWS API documentation](https://www.weather.gov/documentation/services-web-api)

<seealso>
<category ref="external">
<a href="https://www.weather.gov/documentation/services-web-api">NWS API Documentation</a>
</category>
</seealso>
