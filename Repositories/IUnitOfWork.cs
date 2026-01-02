using publications.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;

namespace publications.Repositories
{
    public interface IUnitOfWork:IDisposable
    {
        int Commit();
        IBaseRepository<Publication,long> buprepo {  get; }
        IBaseRepository<Article, long> articlerepo { get; }

        IBaseRepository<Communication, long> communicationrepo { get; }
        IBaseRepository<Chapitre, long> chapitrerepo { get; }



    }
}


