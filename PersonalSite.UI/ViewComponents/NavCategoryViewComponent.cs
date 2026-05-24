using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.UI.ViewComponents
{
    public class NavCategoryViewComponent : ViewComponent
    {
        private readonly IBlogCategoryService _blogCategoryService;

        public NavCategoryViewComponent(IBlogCategoryService blogCategoryService)
        {
            _blogCategoryService = blogCategoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _blogCategoryService.GetAll().Where(x => x.IsActive).ToList();
            return View(categories);
        }
    }
}