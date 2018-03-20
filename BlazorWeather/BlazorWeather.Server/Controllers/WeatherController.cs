using BlazorWeather.Server.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlazorHackaton.Server.Controllers
{
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherClient weatherClient;

        public WeatherController(IWeatherClient weatherClient)
        {
            this.weatherClient = weatherClient;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Search([FromQuery] string location)
        {
            var weatherResult = await weatherClient.GetWeatherBy(location);

            return Ok(weatherResult);
        }
    }
}
