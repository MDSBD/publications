namespace publications.Models
{
    public class Chapitre : Publication
    {
        string bookTitle;
        string editor;
        string isbn;
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public string Editor { get => editor; set => editor = value; }
        public string Isbn { get => isbn; set => isbn = value; }
    }
}
