using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.UI.Controllers
{
    public class EducationController : Controller
    {
        private readonly IEducationService _educationService;

        public EducationController(IEducationService educationService)
        {
            _educationService = educationService;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Eğitim";
            var educations = _educationService.GetAll();
            return View(educations);
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Yeni Eğitim";
            return View();
        }

        [HttpPost]
        public IActionResult Create(Education education)
        {
            education.CreatedDate = DateTime.UtcNow;
            education.IsActive = true;
            _educationService.Add(education);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewData["Title"] = "Eğitimi Düzenle";
            var education = _educationService.GetById(id);
            return View(education);
        }

        [HttpPost]
        public IActionResult Edit(Education education)
        {
            _educationService.Update(education);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var education = _educationService.GetById(id);
            _educationService.Delete(education);
            return RedirectToAction("Index");
        }
    }
}