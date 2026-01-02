using System.Linq.Expressions;

namespace publications.Repositories
{
    public interface IBaseRepository<T,K> where T : class
    {
        public T save(T t);
        public T? findById(K k);
        public IEnumerable<T> findAll();
        public void remove(T t);
        public T update(T t);
        public IEnumerable<T> findByCretiria(Expression<Func<T,bool>> expression);

        IQueryable<T> Query {  get; }

    }
}
