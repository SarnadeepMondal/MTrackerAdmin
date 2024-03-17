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
            #region Static Login From AppSettings

            var builder = WebApplication.CreateBuilder();

            if (Users.email == builder.Configuration.GetConnectionString("Username") 
                && Users.password == builder.Configuration.GetConnectionString("Password"))
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Error");
            }

            #endregion End static Login From AppSettings
        }

    }
}
