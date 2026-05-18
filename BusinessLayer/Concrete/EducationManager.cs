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
    public class EducationManager : IEducationService
    {
        private readonly IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public void Add(Education entity) => _educationDal.Add(entity);
        public void Update(Education entity) => _educationDal.Update(entity);
        public void Delete(Education entity) => _educationDal.Delete(entity);
        public Education GetById(int id) => _educationDal.GetById(id);
        public List<Education> GetAll() => _educationDal.GetAll();
    }
}
