using BlazorWeather.Shared;
using System.Threading.Tasks;

namespace BlazorWeather.Server.Services
{
    public interface IWeatherClient
    {
        Task<WeatherDTO> GetWeatherBy(string location);
    }
}