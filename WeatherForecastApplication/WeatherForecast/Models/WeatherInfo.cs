using Newtonsoft.Json;

namespace WeatherForecast.Models
{
    public class WeatherInfo
    {
        [JsonProperty("dt_txt")]
        public string Date { get; set; }
        [JsonProperty("temp")]
        public float Temperature { get; set; }
        public string Icon { get; set; }
        public string Day { get; set; }
    }
}
