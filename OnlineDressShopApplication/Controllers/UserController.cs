using Microsoft.AspNetCore.Mvc;

namespace OnlineDressShopApplication.Controllers
{
    public class UserController : Controller
    {

        public UserController()
        {
            
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}
