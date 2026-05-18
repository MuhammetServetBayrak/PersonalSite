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
    public class ProjectManager : IProjectService
    {
        private readonly IProjectDal _projectDal;

        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void Add(Project entity) => _projectDal.Add(entity);
        public void Update(Project entity) => _projectDal.Update(entity);
        public void Delete(Project entity) => _projectDal.Delete(entity);
        public Project GetById(int id) => _projectDal.GetById(id);
        public List<Project> GetAll() => _projectDal.GetAll();
    }
}
