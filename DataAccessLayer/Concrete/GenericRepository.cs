using DataAccessLayer.Abstract;
using EntityLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class GenericRepository<T> : IGenericDal<T> where T : class, IEntity
    {
        private readonly PersonalSiteContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(PersonalSiteContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity) { _dbSet.Add(entity); _context.SaveChanges(); }
        public void Update(T entity) { _dbSet.Update(entity); _context.SaveChanges(); }
        public void Delete(T entity) { _dbSet.Remove(entity); _context.SaveChanges(); }
        public T GetById(int id) { return _dbSet.Find(id)!; }
        public List<T> GetAll() { return _dbSet.ToList(); }
    }
}
