using Newtonsoft.Json;

namespace BlazorWeather.Server.Model
{
    public class Temp
    {
        [JsonProperty("day")]
        public float Day { get; set; }
        [JsonProperty("min")]
        public float Minimum { get; set; }
        [JsonProperty("max")]
        public float Maximum { get; set; }
        [JsonProperty("night")]
        public float Night { get; set; }
        [JsonProperty("eve")]
        public float Eve { get; set; }
        [JsonProperty("morn")]
        public float Morning { get; set; }
    }
}
