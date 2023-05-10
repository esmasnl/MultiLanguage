using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using MultiLanguage.Models;

namespace MultiLanguage.Controllers
{
    public class UserController : Controller
    {
        private readonly IStringLocalizer<UserController> _stringLocalizer;

        public UserController(IStringLocalizer<UserController> stringLocalizer)
            => _stringLocalizer = stringLocalizer;
       
        public IActionResult Index()
        
        {
            var nameValue = _stringLocalizer["Name"];
            return View();
        }

        public IActionResult Create() 
        { 
        return View();
        
        }

        [HttpPost]
        public IActionResult Create(UserCreateRequestModel request)
        {
            return View(request);

        }
    }
}
