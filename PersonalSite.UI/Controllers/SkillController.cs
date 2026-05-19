using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.UI.Controllers
{
    public class SkillController : Controller
    {
        private readonly ISkillService _skillService;

        public SkillController(ISkillService skillService)
        {
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Beceriler";
            var skills = _skillService.GetAll();
            return View(skills);
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Yeni Beceri";
            return View();
        }

        [HttpPost]
        public IActionResult Create(Skill skill)
        {
            skill.CreatedDate = DateTime.UtcNow;
            skill.IsActive = true;
            _skillService.Add(skill);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewData["Title"] = "Beceriyi Düzenle";
            var skill = _skillService.GetById(id);
            return View(skill);
        }

        [HttpPost]
        public IActionResult Edit(Skill skill)
        {
            _skillService.Update(skill);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var skill = _skillService.GetById(id);
            _skillService.Delete(skill);
            return RedirectToAction("Index");
        }
    }
}