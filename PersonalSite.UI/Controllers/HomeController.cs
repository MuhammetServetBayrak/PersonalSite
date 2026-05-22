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
        private readonly IExperienceService _experienceService;
        private readonly IEducationService _educationService;
        private readonly ISkillService _skillService;

        public HomeController(
            ILogger<HomeController> logger,
            IProjectService projectService,
            IExperienceService experienceService,
            IEducationService educationService,
            ISkillService skillService)
        {
            _logger = logger;
            _projectService = projectService;
            _experienceService = experienceService;
            _educationService = educationService;
            _skillService = skillService;
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

        public IActionResult About()
        {
            ViewData["Title"] = "Hakkýmda";
            ViewBag.Experiences = _experienceService.GetAll().Where(x => x.IsActive).OrderByDescending(x => x.StartDate).ToList();
            ViewBag.Educations = _educationService.GetAll().Where(x => x.IsActive).OrderByDescending(x => x.StartDate).ToList();
            ViewBag.Skills = _skillService.GetAll().Where(x => x.IsActive).ToList();
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