using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class ProjectRepository : GenericRepository<Project>, IProjectDal
    {
        public ProjectRepository(PersonalSiteContext context) : base(context) { }
    }
}
