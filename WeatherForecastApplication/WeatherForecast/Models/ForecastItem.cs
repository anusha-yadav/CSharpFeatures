using Newtonsoft.Json;

namespace WeatherForecast.Models
{
    public class ForecastItem
    {
        [JsonProperty("dt_txt")]
        public string dt_txt { get; set; }
        public MainInfo main { get; set; }
        public List<Weather> weather { get; set; }
    }
}
