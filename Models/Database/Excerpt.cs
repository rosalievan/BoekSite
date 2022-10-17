namespace BoekSite.Models.Database
{
    public class Excerpt
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Book Book { get; set; }
    }
}