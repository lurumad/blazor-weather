using Newtonsoft.Json;

namespace BlazorWeather.Server.Model
{
    public class Wind
    {
        [JsonProperty("speed")]
        public float Speed { get; set; }
        [JsonProperty("deg")]
        public int Degrees { get; set; }
    }

}
