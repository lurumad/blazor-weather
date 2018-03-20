using Newtonsoft.Json;

namespace BlazorWeather.Server.Model
{
    public class Sys
    {
        [JsonProperty("type")]
        public int Type { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("Message")]
        public float message { get; set; }
        [JsonProperty("Contry")]
        public string country { get; set; }
        [JsonProperty("Sunrise")]
        public int sunrise { get; set; }
        [JsonProperty("sunset")]
        public int Sunset { get; set; }
    }

}
