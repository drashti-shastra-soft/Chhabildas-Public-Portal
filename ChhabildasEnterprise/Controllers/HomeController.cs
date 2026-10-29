using ChhabildasEnterprise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ChhabildasEnterprise.Controllers
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
        public IActionResult about()
        {
            return View();
        }
         public IActionResult homelinen()
        {
            return View();
        }
         public IActionResult hotellinen()
        {
            return View();
        }
         public IActionResult hospitallinen()
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
