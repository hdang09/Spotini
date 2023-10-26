using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class RepositoryBase<T> where T : class
    {
        SpotiniDBContext _context;
        DbSet<T> _dbSet;

        public RepositoryBase()
        {
            _context = new SpotiniDBContext();
            _dbSet = _context.Set<T>();
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet;
        }

        public void Create(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
    }
}
