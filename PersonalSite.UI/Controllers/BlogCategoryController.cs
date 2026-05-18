using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.UI.Controllers
{
    public class BlogCategoryController : Controller
    {
        private readonly IBlogCategoryService _blogCategoryService;

        public BlogCategoryController(IBlogCategoryService blogCategoryService)
        {
            _blogCategoryService = blogCategoryService;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Kategoriler";
            var categories = _blogCategoryService.GetAll();
            return View(categories);
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Yeni Kategori";
            return View();
        }

        [HttpPost]
        public IActionResult Create(BlogCategory category)
        {
            category.CreatedDate = DateTime.UtcNow;
            category.IsActive = true;
            category.Slug = category.Name!.ToLower().Replace(" ", "-");
            _blogCategoryService.Add(category);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var category = _blogCategoryService.GetById(id);
            _blogCategoryService.Delete(category);
            return RedirectToAction("Index");
        }
    }
}