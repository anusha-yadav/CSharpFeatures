using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WeatherForecast.Models;

namespace WeatherForecast.SignalR
{
    public class WeatherHub : Hub
    {
        public async Task SendWeatherUpdates(string cityName, List<WeatherInfo>temperature)
        {
            await Clients.All.SendAsync("RecieveWeatherUpdate", cityName, temperature);
        }
    }
}
