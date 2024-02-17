using Newtonsoft.Json;

namespace WeatherForecast.Services
{
    public class WeatherService
    {
        private readonly string apiKey = "ff1ab2430c517cfcdf61dd5daf95a16a";
        private readonly string apiUrl = "https://api.openweathermap.org/data/2.5/weather";

        public async Task<string> GetWeatherAsync(string city)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{apiUrl}?q={city}&appid={apiKey}");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadAsStringAsync();
            }
        }

        public async Task<List<WeatherInfo>> GetWeatherForecastAsync(string city)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{apiUrl}?q={city}&appid={apiKey}");
                response.EnsureSuccessStatusCode();
                var json = await response.Content.ReadAsStringAsync();

                // Parse the JSON response and extract the relevant information
                var forecast = JsonConvert.DeserializeObject<OpenWeatherMapForecast>(json);

                // Process the forecast data to get the information for the next 4 days
                var nextFourDaysForecast = forecast.list.Take(4).Select(item => new WeatherInfo
                {
                    Date = item.dt_txt,
                    Temperature = item.main.temp,
                    Icon = item.weather.FirstOrDefault()?.icon
                }).ToList();

                return nextFourDaysForecast;
            }
        }
    }
}
}