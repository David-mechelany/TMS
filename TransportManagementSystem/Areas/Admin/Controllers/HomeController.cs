using Microsoft.AspNetCore.Mvc;

namespace TransportManagementSystem.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HeadTitle = "Admin Dashboard";
            return View();
        }
    }
}
