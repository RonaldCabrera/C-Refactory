using FirstPage.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstPage.Web.Controllers
{
    public class HomeController(ILogger<HomeController> logger) : Controller
    {
        private readonly ILogger<HomeController> _logger = logger;

        public IActionResult Index() => View();

        public IActionResult First() => View();

        public IActionResult Second() => View();

        public IActionResult Third() => View();

        public IActionResult Fourth() => View();

        public IActionResult Fifth() => View();

        public IActionResult Sixth() => View();

        public IActionResult Seventh() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
