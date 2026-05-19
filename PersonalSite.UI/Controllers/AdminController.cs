using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.UI.Controllers
{
    public class AdminController : Controller
    {
        private readonly IBlogPostService _blogPostService;
        private readonly IBlogCategoryService _blogCategoryService;
        private readonly IProjectService _projectService;
        private readonly ISkillService _skillService;

        public AdminController(IBlogPostService blogPostService, IBlogCategoryService blogCategoryService, IProjectService projectService, ISkillService skillService)
        {
            _blogPostService = blogPostService;
            _blogCategoryService = blogCategoryService;
            _projectService = projectService;
            _skillService = skillService;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Dashboard";
            ViewBag.PostCount = _blogPostService.GetAll().Count;
            ViewBag.CategoryCount = _blogCategoryService.GetAll().Count;
            ViewBag.ProjectCount = _projectService.GetAll().Count;
            ViewBag.SkillCount = _skillService.GetAll().Count;
            ViewBag.RecentPosts = _blogPostService.GetAll().OrderByDescending(x => x.CreatedDate).Take(5).ToList();
            return View();
        }
    }
}

