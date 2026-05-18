using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class SkillRepository : GenericRepository<Skill>, ISkillDal
    {
        public SkillRepository(PersonalSiteContext context) : base(context) { }
    }
}
