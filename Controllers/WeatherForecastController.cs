using Microsoft.AspNetCore.Mvc;//classe COntrollerBase

namespace skinet.Controllers;

[ApiController]
[Route("[controller]")]// é o mesmo que http:servidor/weatherforecast
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;//interface??pq??

    public WeatherForecastController(ILogger<WeatherForecastController> logger)//injeção
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]//endpoint

     //RESPOSTA AO GET
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
