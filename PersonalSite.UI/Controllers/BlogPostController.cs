using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.UI.Controllers
{
    public class BlogPostController : Controller
    {

            private readonly IBlogPostService _blogPostService;
            private readonly IBlogCategoryService _blogCategoryService;

            public BlogPostController(IBlogPostService blogPostService, IBlogCategoryService blogCategoryService)
            {
                _blogPostService = blogPostService;
                _blogCategoryService = blogCategoryService;
            }

            public IActionResult Index()
            {
                ViewData["Title"] = "Blog Yazıları";
                var posts = _blogPostService.GetAll();
                return View(posts);
            }

            public IActionResult Create()
            {
                ViewData["Title"] = "Yeni Yazı";
                ViewBag.Categories = _blogCategoryService.GetAll();
                return View();
            }

            [HttpPost]
            public IActionResult Create(BlogPost post)
            {
                post.CreatedDate = DateTime.Now;
                post.IsActive = true;
                post.Slug = post.Title!.ToLower().Replace(" ", "-");
                _blogPostService.Add(post);
                return RedirectToAction("Index");
            }

            public IActionResult Edit(int id)
            {
                ViewData["Title"] = "Yazıyı Düzenle";
                ViewBag.Categories = _blogCategoryService.GetAll();
                var post = _blogPostService.GetById(id);
                return View(post);
            }

            [HttpPost]
            public IActionResult Edit(BlogPost post)
            {
                post.Slug = post.Title!.ToLower().Replace(" ", "-");
                _blogPostService.Update(post);
                return RedirectToAction("Index");
            }

            public IActionResult Delete(int id)
            {
                var post = _blogPostService.GetById(id);
                _blogPostService.Delete(post);
                return RedirectToAction("Index");
            }
        }
    }
