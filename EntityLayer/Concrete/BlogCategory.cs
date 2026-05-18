using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class BlogCategory : BaseEntity
    {
        public string? Name { get; set; }
        public string? Slug { get; set; }
        public string? Description { get; set; }
    }
}
