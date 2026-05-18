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
    public class BlogPostManager : IBlogPostService
    {
        private readonly IBlogPostDal _blogPostDal;

        public BlogPostManager(IBlogPostDal blogPostDal)
        {
            _blogPostDal = blogPostDal;
        }

        public void Add(BlogPost entity) => _blogPostDal.Add(entity);
        public void Update(BlogPost entity) => _blogPostDal.Update(entity);
        public void Delete(BlogPost entity) => _blogPostDal.Delete(entity);
        public BlogPost GetById(int id) => _blogPostDal.GetById(id);
        public List<BlogPost> GetAll() => _blogPostDal.GetAll();
    }
}
