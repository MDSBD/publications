namespace publications.Models
{
    public class Article : Publication
    {
        string journal;
        string doi;
        string volume;
        public string Journal { get => journal; set => journal = value; }
        public string Doi { get => doi; set => doi = value; }
      
        public string Volume { get => volume; set => volume = value; }
    }
}
