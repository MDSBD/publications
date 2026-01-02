using publications.Models;

namespace publications.Services.Remote
{
    public interface IChercheur
    {
        public IEnumerable<Chercheur> GetChercheursByIds(List<long> ids);
        public Chercheur GetChercheurById(long id);

    }
}
