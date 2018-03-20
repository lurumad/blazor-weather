using Newtonsoft.Json;

namespace BlazorWeather.Server.Model
{
    public class List
    {
        [JsonProperty("dt")]
        public int Dt { get; set; }
        [JsonProperty("temp")]
        public Temp Temp { get; set; }
        [JsonProperty("pressure")]
        public float Pressure { get; set; }
        [JsonProperty("humidity")]
        public int Humidity { get; set; }
        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }
        [JsonProperty("speed")]
        public float Speed { get; set; }
        [JsonProperty("deg")]
        public int Deg { get; set; }
        [JsonProperty("clouds")]
        public int Clouds { get; set; }
        [JsonProperty("rain")]
        public float Rain { get; set; }
        [JsonProperty("snow")]
        public float Snow { get; set; }
    }
}
