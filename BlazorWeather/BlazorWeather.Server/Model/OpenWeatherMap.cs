using Newtonsoft.Json;

namespace BlazorWeather.Server.Model
{
    public class OpenWeatherMap
    {
        [JsonProperty("coord")]
        public Coordinates Location { get; set; }
        [JsonProperty("Weather")]
        public Weather[] Weather { get; set; }
        [JsonProperty("_base")]
        public string Base { get; set; }
        [JsonProperty("main")]
        public Main Main { get; set; }
        [JsonProperty("visibility")]
        public int Visibility { get; set; }
        [JsonProperty("wind")]
        public Wind Wind { get; set; }
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }
        [JsonProperty("dt")]
        public int Dt { get; set; }
        [JsonProperty("Sys")]
        public Sys sys { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("cod")]
        public int Code { get; set; }
    }
}
