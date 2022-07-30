using Microsoft.AspNetCore.Mvc;
using MTrackerAdminWeb.Data;
using MTrackerAdminWeb.Models;
using System.Diagnostics;

namespace MTrackerAdminWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext dataContext;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            dataContext = db;

        }

        public IActionResult Index()
        {
            return View(dataContext.Organization);
        }
        public IActionResult ContactUs()
        {
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