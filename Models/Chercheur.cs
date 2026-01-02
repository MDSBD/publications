namespace publications.Models
{
    public class Chercheur
    {
        long id;
        string nom;
        string prenom;
        string email;
        List<Publication> publications=new List<Publication>();

        public long Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Email { get => email; set => email = value; }
        public List<Publication> Publications { get => publications; set => publications = value; }
    }
}
