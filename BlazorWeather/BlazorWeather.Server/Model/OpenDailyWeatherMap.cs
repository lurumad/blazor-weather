using Newtonsoft.Json;

namespace BlazorWeather.Server.Model
{
    public class OpenDailyWeatherMap
    {
        [JsonProperty("city")]
        public City City { get; set; }
        [JsonProperty("cod")]
        public string Code { get; set; }
        [JsonProperty("message")]
        public float Message { get; set; }
        [JsonProperty("cnt")]
        public int Cnt { get; set; }
        [JsonProperty("list")]
        public List[] List { get; set; }
    }
}
