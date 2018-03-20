using BlazorWeather.Server.Model;
using BlazorWeather.Shared;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorWeather.Server.Services
{
    public class WeatherClient : IWeatherClient
    {
        private const string WeatherUrl = "http://api.openweathermap.org/data/2.5/weather?q=#city#&appid=8da11856c3c42a548fe7f0cd10f826d2&units=metric";
        private const string ForecastDailyUrl = "https://openweathermap.org/data/2.5/forecast/daily/?appid=b6907d289e10d714a6e88b30761fae22&id=#id#&units=metric";

        public async Task<WeatherDTO> GetWeatherBy(string city)
        {
            using (var client = new HttpClient())
            {
                var json = await client.GetStringAsync(WeatherUrl.Replace("#city#", city));
                var weather = JsonConvert.DeserializeObject<OpenWeatherMap>(json);
                json = await client.GetStringAsync(ForecastDailyUrl.Replace("#id#", weather.Id.ToString()));
                var dailyWeather = JsonConvert.DeserializeObject<OpenDailyWeatherMap>(json);
                return MapFrom(weather, dailyWeather);
            }
        }

        private WeatherDTO MapFrom(OpenWeatherMap weather, OpenDailyWeatherMap dailyWeather)
        {
            var date = FromUnixTime(weather.Dt);
            var weatherDto = new WeatherDTO
            {
                DayNumber = date.ToString("dd"),
                DayName = date.ToString("dddd"),
                MonthName = date.ToString("MMMM"),
                Location = weather.Name,
                Degree = Math.Round(weather.Main.Temperature),
                Humidity = weather.Main.Humidity,
                Pressure = weather.Main.Pressure,
                WeatherName = weather.Weather[0].Main,
                WeatherDescription = weather.Weather[0].Description,
                WindSpeed = weather.Wind.Speed,
                Compass = DegreesToCardinal(weather.Wind.Degrees)
            };

            for (int i = 0; i < Constants.MAXIMUN_NUMBER_OF_DAYS; i++)
            {
                var day = i + 1; 
                date = FromUnixTime(dailyWeather.List[day].Dt);
                var weatherDayDto = new WeatherDayDTO
                {
                    Day = date.ToString("dddd"),
                    MaximumTemperature = Math.Round(dailyWeather.List[day].Temp.Maximum),
                    MinimumTemperature = Math.Round(dailyWeather.List[day].Temp.Minimum),
                    WeatherName = dailyWeather.List[day].Weather[0].Main,
                    WeatherDescription = dailyWeather.List[day].Weather[0].Description,
                };
                weatherDto.DailyWeather[i] = weatherDayDto;
            }

            return weatherDto;
        }

        private DateTime FromUnixTime(long unixTime)
        {
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return epoch.AddSeconds(unixTime);
        }

        private string DegreesToCardinal(int degrees)
        {
            string[] caridnals = { "N", "NE", "E", "SE", "S", "SW", "W", "NW", "N" };
            return caridnals[(int)Math.Round(((double)degrees % 360) / 45)];
        }
    }
}