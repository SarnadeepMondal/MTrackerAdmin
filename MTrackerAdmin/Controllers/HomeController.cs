using Microsoft.AspNetCore.Mvc;
using MTrackerAdmin.Data;

namespace MTrackerAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicatonDbContext dataContext;
        public HomeController(ILogger<HomeController> logger, ApplicatonDbContext db)
        {
            _logger = logger;
            dataContext = db;

        }
        public IActionResult Index()
        {
            return View(dataContext.Organization);
        }
    }
}
