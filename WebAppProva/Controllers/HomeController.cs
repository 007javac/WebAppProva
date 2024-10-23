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

        [HttpGet]
        public IActionResult Index()
        {
            var orderViewModel = new OrderViewModel();
            return View(orderViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult OrderCalculate(OrderViewModel order)
        {
            if (order.FirstCourse != null && order.SecondCourse != null && order.Drink != null)
            {
                order.TotalPrice = _menu[order.FirstCourse] + _menu[order.SecondCourse] + _menu[order.Drink];

            }
            return View("Index", order);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
