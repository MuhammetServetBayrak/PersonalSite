using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using PersonalSite.UI.Models;
using System.Diagnostics;

namespace PersonalSite.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProjectService _projectService;

        public HomeController(ILogger<HomeController> logger, IProjectService projectService)
        {
            _logger = logger;
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Projects()
        {
            ViewData["Title"] = "Projeler";
            var projects = _projectService.GetAll().Where(x => x.IsActive).ToList();
            return View(projects);
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