using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TextToSpeech.Models;

namespace TextToSpeech.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public ActionResult VoiceToText(string transcript)
        {
            try
            {
                LogReceivedText(transcript);
                return Json(new { success = true, message = "Text received and processed successfully" });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = $"Error processing text: {ex.Message}" });
            }
        }

        private void LogReceivedText(string text)
        {
            Console.WriteLine($"Received Text: {text}");
        }
    }
}