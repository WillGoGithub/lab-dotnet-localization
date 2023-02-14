using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Localization.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IStringLocalizer<SharedResource> sharedResourceLocalizer;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IStringLocalizer<SharedResource> sharedResourceLocalizer)
        {
            _logger = logger;
            this.sharedResourceLocalizer = sharedResourceLocalizer;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Name = sharedResourceLocalizer["REQUIRED_INPUT"],
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        [HttpPost]
        public IActionResult Create(WeatherForecast data)
        {
            return Ok();
        }
    }
}