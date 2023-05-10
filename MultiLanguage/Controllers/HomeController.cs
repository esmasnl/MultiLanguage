using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using MultiLanguage.Models;
using System.Diagnostics;

namespace MultiLanguage.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IStringLocalizer<HomeController> _stringLocalizer;
       

        public HomeController(IStringLocalizer<HomeController> stringLocalizer)
            => _stringLocalizer = stringLocalizer;

        public IActionResult Index()
        {
            var say_Home_Value = _stringLocalizer["Say_Home"];
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
    }
}