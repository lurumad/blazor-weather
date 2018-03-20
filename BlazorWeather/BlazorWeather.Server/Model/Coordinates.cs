using Newtonsoft.Json;

namespace BlazorWeather.Server.Model
{
    public class Coordinates
    {
        [JsonProperty("lon")]
        public float Longitude { get; set; }
        [JsonProperty("lat")]
        public float Latitude { get; set; }
    }

}
