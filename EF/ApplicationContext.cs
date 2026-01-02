using Microsoft.EntityFrameworkCore;
using publications.Models;

namespace Laboratoires.EF
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options)
        {
        }

        protected ApplicationContext()
        {
        }

        public DbSet<Publication> Publications { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Chapitre> Chapitres { get; set; }


        }
}
