using Microsoft.AspNetCore.Mvc;
using MTrackerAdminWeb.Models;

namespace MTrackerAdminWeb.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(UsersAdmin Users)
        {
            if (Users.email == "Test@admin" && Users.password == "1234")
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                return RedirectToAction("Error");
            }

        }

    }
}
