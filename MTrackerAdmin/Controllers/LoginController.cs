using Microsoft.AspNetCore.Mvc;

namespace MTrackerAdmin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
