using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Umwandlung_DAHRS.Models;

namespace Umwandlung_DAHRS.Controllers
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

        [HttpGet]
        public ViewResult Berechnung()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Berechnung(Betrag b)
        {
            return View("Umwandlung", b);
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
    }
}