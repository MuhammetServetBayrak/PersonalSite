using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.UI.Controllers
{
    public class ExperienceController : Controller
    {
        private readonly IExperienceService _experienceService;

        public ExperienceController(IExperienceService experienceService)
        {
            _experienceService = experienceService;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Deneyim";
            var experiences = _experienceService.GetAll();
            return View(experiences);
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Yeni Deneyim";
            return View();
        }

        [HttpPost]
        public IActionResult Create(Experience experience)
        {
            experience.CreatedDate = DateTime.UtcNow;
            experience.IsActive = true;
            _experienceService.Add(experience);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewData["Title"] = "Deneyimi Düzenle";
            var experience = _experienceService.GetById(id);
            return View(experience);
        }

        [HttpPost]
        public IActionResult Edit(Experience experience)
        {
            _experienceService.Update(experience);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var experience = _experienceService.GetById(id);
            _experienceService.Delete(experience);
            return RedirectToAction("Index");
        }
    }
}