using System;

namespace BlazorWeather.Shared
{
    public class WeatherDayDTO
    {
        public string WeatherName { get; set; }
        public string WeatherDescription { get; set; }
        public string Day { get; set; }
        public double MinimumTemperature { get; set; }
        public double MaximumTemperature { get; set; }
    }
}
