using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlogCategoryManager : IBlogCategoryService
    {
        private readonly IBlogCategoryDal _blogCategoryDal;

        public BlogCategoryManager(IBlogCategoryDal blogCategoryDal)
        {
            _blogCategoryDal = blogCategoryDal;
        }

        public void Add(BlogCategory entity) => _blogCategoryDal.Add(entity);
        public void Update(BlogCategory entity) => _blogCategoryDal.Update(entity);
        public void Delete(BlogCategory entity) => _blogCategoryDal.Delete(entity);
        public BlogCategory GetById(int id) => _blogCategoryDal.GetById(id);
        public List<BlogCategory> GetAll() => _blogCategoryDal.GetAll();
    }
}
