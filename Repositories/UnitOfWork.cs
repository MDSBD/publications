using Laboratoires.EF;
using publications.Models;

namespace publications.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _context;
        public UnitOfWork(ApplicationContext context) {
        
            _context = context;
            buprepo = new BaseRepository<Publication, long>(context);
            articlerepo = new BaseRepository<Article, long>(context);
            communicationrepo = new BaseRepository<Communication, long>(context);
            chapitrerepo = new BaseRepository<Chapitre, long>(context);

        }
        public IBaseRepository<Publication, long> buprepo { get; private set; }
        public IBaseRepository<Article, long> articlerepo { get; private set; }

        public IBaseRepository<Communication, long> communicationrepo { get; private set; }
        public IBaseRepository<Chapitre, long> chapitrerepo { get; private set; }

        public int Commit()
        {
           return  _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
