using Newtonsoft.Json;

namespace WeatherForecast.Models
{
    public class MainInfo
    {
        [JsonProperty("temp")]
        public float temp { get; set; }
    }
}
