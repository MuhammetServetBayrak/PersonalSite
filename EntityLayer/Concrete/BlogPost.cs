using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogPost: BaseEntity
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Slug { get; set; }
        public string? ThumbnailUrl { get; set; }
        public int BlogCategoryId { get; set; }
        public BlogCategory? BlogCategory { get; set; }
    }
}
