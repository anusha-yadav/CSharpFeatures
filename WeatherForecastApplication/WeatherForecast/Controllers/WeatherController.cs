using Microsoft.AspNetCore.Mvc;
using WeatherForecast.SignalR;
using WeatherForecast.Services;
using Microsoft.AspNetCore.SignalR;
using System.ComponentModel;
using WeatherForecast.Models;

namespace WeatherForecast.Controllers
{
    public class WeatherController : Controller
    {
        private readonly IHubContext<WeatherHub> weatherHub;
        private readonly WeatherService WeatherService;

        public WeatherController(IHubContext<WeatherHub> hubContext)
        {
            weatherHub = hubContext;
            WeatherService = new WeatherService();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetCities()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "cities.json");
            var json = System.IO.File.ReadAllText(path);
            return Content(json, "application/json");
        }

        [HttpPost]
        public async Task<IActionResult> GetWeather(string city)
        {
            var weatherData = await WeatherService.GetWeatherAsync(city);
            await weatherHub.Clients.All.SendAsync("RecieveWeatherUpdate", city, weatherData);
            return Json(weatherData);
        }

        [HttpPost]
        public async Task<IActionResult> GetWeatherForecast(string city)
        {
            var weatherData = await WeatherService.GetWeatherForecast(city);
            await weatherHub.Clients.All.SendAsync("RecieveWeatherUpdate", city, weatherData);
            return Json(weatherData);
        }

    }
}
