using BlazorWeather.Shared;
using System.Collections.Generic;

namespace BlazorWeather.Client.State
{
    public class AppState
    {
        private List<WeatherDTO> weatherDtos { get; set; } = new List<WeatherDTO>();
        public WeatherDTO[] Weather => weatherDtos.ToArray();
        public void AddWeather(WeatherDTO weather)
        {
            weatherDtos.Add(weather);
        }
    }
}
