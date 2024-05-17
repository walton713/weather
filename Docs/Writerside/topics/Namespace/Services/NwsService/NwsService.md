# NwsService Class

Reference

## Definition

Namespace: [Weather.Services](Weather-Services.md)
Assembly: Weather
Source: [NwsService](https://github.com/walton713/weather/blob/master/Source/Weather/Services/NwsService.cs)

Provides a class for retrieving weather data from the National Weather Service (NWS) API.

```C#
public class NwsService : INwsService
```

Inheritance [Object](https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-8.0) &rarr; NwsService

## Examples

```C#
static readonly HttpClient client = new HttpClient();

var service = new NwsService(client);
var alerts = await service.GetAlertsAsync();
```

## Remarks

For more information on the NWS API visit [their documentation](https://www.weather.gov/documentation/services-web-api).

## Constructors

<table>
<tr>
<td>NwsService(HttpClient)</td>
<td>Initializes a new instance of the NwsService class using the specified client.</td>
</tr>
</table>

## Methods

<table>
<tr>
<td>GetAlertsAsync()</td>
<td>Get the latest NWS alerts as an asynchronous operation.</td>
</tr>
</table>

<seealso>
<category ref="wrs">
<a href="INwsService.md"/>
</category>
<category ref="external">
<a href="https://www.weather.gov/documentation/services-web-api">NWS API Documentation</a>
</category>
</seealso>
