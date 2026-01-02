using System.ComponentModel.DataAnnotations.Schema;

namespace publications.Models
{
    public class Publication
    {
        long id;
        DateTime publishedAt;
        string title;

        List<long> idchercheurs;

        [NotMapped]
        List<Chercheur> chercheurs=new List<Chercheur>();

        public long Id { get => id; set => id = value; }
        public DateTime PublishedAt { get => publishedAt; set => publishedAt = value; }
        public string Title { get => title; set => title = value; }
        [NotMapped]
        public List<Chercheur> Chercheurs { get => chercheurs; set => chercheurs = value; }
        public List<long> Idchercheurs { get => idchercheurs; set => idchercheurs = value; }
    }
}
