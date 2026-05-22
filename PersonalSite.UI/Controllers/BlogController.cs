using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.UI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogPostService _blogPostService;
        private readonly IBlogCategoryService _blogCategoryService;

        public BlogController(IBlogPostService blogPostService, IBlogCategoryService blogCategoryService)
        {
            _blogPostService = blogPostService;
            _blogCategoryService = blogCategoryService;
        }

        public IActionResult Index(int? categoryId)
        {
            ViewData["Title"] = "Blog";
            var categories = _blogCategoryService.GetAll();
            var posts = _blogPostService.GetAll()
                .Where(x => x.IsActive)
                .OrderByDescending(x => x.CreatedDate)
                .ToList();

            if (categoryId.HasValue)
                posts = posts.Where(x => x.BlogCategoryId == categoryId).ToList();

            ViewBag.Categories = categories;
            ViewBag.SelectedCategory = categoryId;
            return View(posts);
        }

        public IActionResult Detail(int id)
        {
            ViewData["Title"] = "Yazı Detayı";
            var post = _blogPostService.GetById(id);
            if (post == null) return NotFound();
            ViewData["Title"] = post.Title;
            return View(post);
        }
    }
}