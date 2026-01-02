using Laboratoires.EF;
using Microsoft.EntityFrameworkCore;
using System.Collections.Immutable;
using System.Linq.Expressions;

namespace publications.Repositories
{
    public class BaseRepository<T, K> : IBaseRepository<T, K> where T : class
    {
        public readonly ApplicationContext _context;
        public readonly DbSet<T> _entities;

        public BaseRepository(ApplicationContext context)
        {
            _context = context;
            _entities =_context.Set<T>();
        }

        public IQueryable<T> Query => _entities;

        public IEnumerable<T> findAll()
        {
           return  _entities.ToList();
        }

        public IEnumerable<T> findByCretiria(Expression<Func<T, bool>> expression)
        {
           return  _entities.Where(expression).ToImmutableList();
        }

        public T? findById(K k)
        {
           return  _entities.Find(k);
        }

        public void remove(T t)
        {
            _entities.Remove(t);
        }

        public T save(T t)
        {
             _entities.Add(t);
            return t;
        }

        public T update(T t)
        {
            throw new NotImplementedException();
        }
    }
}
