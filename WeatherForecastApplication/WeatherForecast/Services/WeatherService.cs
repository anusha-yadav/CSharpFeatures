using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using WeatherForecast.Models;

namespace WeatherForecast.Services
{
    public class WeatherService
    {
        private readonly string apiKey = "ff1ab2430c517cfcdf61dd5daf95a16a";
        private readonly string apiUrl = "https://api.openweathermap.org/data/2.5/forecast";

        public async Task<string> GetWeatherAsync(string city)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{apiUrl}?q={city}&appid={apiKey}");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

        public async Task<List<WeatherInfo>> GetWeatherForecast(string city)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{apiUrl}?q={city}&appid={apiKey}");
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();

                // Parse the JSON response and extract the relevant information
                var jsonObject = JObject.Parse(json);


                // Extract information directly without full deserialization
                var nextFourDaysForecast = jsonObject["list"]
                        ?.Select(item => new WeatherInfo
                        {
                            Date = DateTime.Parse(item["dt_txt"]?.Value<string>()).ToString("MMMM dd"),
                            Temperature = (item["main"]?["temp"]?.Value<float>()) ?? 0.0f,
                            Icon = item["weather"]?.FirstOrDefault()?["icon"]?.Value<string>() ?? "",
                            Day = DateTime.Parse(item["dt_txt"]?.Value<string>()).ToString("dddd")
                        })
                        .GroupBy(x=>x.Date)
                        .Select(group => group.First())
                        .Take(5)
                        .ToList();
                return nextFourDaysForecast;
            }
        }
    }
}
