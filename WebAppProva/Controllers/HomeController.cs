using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppProva.Models;

namespace WebAppProva.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private Dictionary<string, double> _menu = new Dictionary<string, double>
        {
            { "Суп", 5.00d },
            { "Борщ", 4.00d },
            { "Стейк", 10.00d },
            { "Пицца", 8.00d },
            { "Кофе", 3.00d },
            { "Чай", 2.00d }
        };

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

        public IActionResult OrderCalculate() => null;

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
