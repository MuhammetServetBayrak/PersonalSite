using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.UI.Controllers
{
    public class ProjectController : Controller
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Projeler";
            var projects = _projectService.GetAll();
            return View(projects);
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Yeni Proje";
            return View();
        }

        [HttpPost]
        public IActionResult Create(Project project)
        {
            project.CreatedDate = DateTime.UtcNow;
            project.IsActive = true;
            _projectService.Add(project);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            ViewData["Title"] = "Projeyi Düzenle";
            var project = _projectService.GetById(id);
            return View(project);
        }

        [HttpPost]
        public IActionResult Edit(Project project)
        {
            if (project.CreatedDate == default)
                project.CreatedDate = DateTime.UtcNow;
            _projectService.Update(project);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var project = _projectService.GetById(id);
            _projectService.Delete(project);
            return RedirectToAction("Index");
        }
    }
}