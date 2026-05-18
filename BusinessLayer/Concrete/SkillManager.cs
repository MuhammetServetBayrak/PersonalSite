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
    public class SkillManager : ISkillService
    {
        private readonly ISkillDal _skillDal;

        public SkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void Add(Skill entity) => _skillDal.Add(entity);
        public void Update(Skill entity) => _skillDal.Update(entity);
        public void Delete(Skill entity) => _skillDal.Delete(entity);
        public Skill GetById(int id) => _skillDal.GetById(id);
        public List<Skill> GetAll() => _skillDal.GetAll();
    }
}
