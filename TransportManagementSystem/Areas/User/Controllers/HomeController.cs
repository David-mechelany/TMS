using Microsoft.AspNetCore.Mvc;

namespace TransportManagementSystem.Areas.User.Controllers
{
    [Area("User")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HeadTitle = "Admin Dashboard";
            return View();
        }
    }
}
