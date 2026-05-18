using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class BlogPostRepository : GenericRepository<BlogPost>, IBlogPostDal
    {
        public BlogPostRepository(PersonalSiteContext context) : base(context) { }
    }
}
