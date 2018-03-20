using Newtonsoft.Json;

namespace BlazorWeather.Server.Model
{
    public class Clouds
    {
        [JsonProperty("all")]
        public int All { get; set; }
    }

}
