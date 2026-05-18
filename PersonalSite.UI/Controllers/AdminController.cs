using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Dashboard";
            return View();
        }
    }
}
