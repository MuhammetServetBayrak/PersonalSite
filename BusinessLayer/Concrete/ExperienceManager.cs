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
    public class ExperienceManager : IExperienceService
    {
        private readonly IExperienceDal _experienceDal;

        public ExperienceManager(IExperienceDal experienceDal)
        {
            _experienceDal = experienceDal;
        }

        public void Add(Experience entity) => _experienceDal.Add(entity);
        public void Update(Experience entity) => _experienceDal.Update(entity);
        public void Delete(Experience entity) => _experienceDal.Delete(entity);
        public Experience GetById(int id) => _experienceDal.GetById(id);
        public List<Experience> GetAll() => _experienceDal.GetAll();
    }
}
