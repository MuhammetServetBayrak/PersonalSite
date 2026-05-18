using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Project : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? ThumbnailUrl { get; set; }
        public string? GitHubUrl { get; set; }
        public string? LiveUrl { get; set; }
        public string? Technologies { get; set; }
    }
}
