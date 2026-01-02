namespace publications.Models
{
    public class Communication:Publication
    {
        string conference;
        string location;
        public string Conference { get => conference; set => conference = value; }
        public string Location { get => location; set => location = value; }
    }
}
