using Newtonsoft.Json;

namespace BlazorWeather.Server.Model
{
    public class Main
    {
        [JsonProperty("temp")]
        public float Temperature { get; set; }
        [JsonProperty("pressure")]
        public int Pressure { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
        [JsonProperty("temp_min")]
        public int MinimumTemperature { get; set; }
        [JsonProperty("temp_max")]
        public int MaximumTemperature { get; set; }
    }

}
