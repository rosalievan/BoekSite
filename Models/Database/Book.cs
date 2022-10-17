namespace BoekSite.Models.Database
{
    public class Book
    {
        public int Id { get; set; }
        public Author? Author { get; set; }
        public Genre? Genre { get; set; }
        public string? PhotoUrl { get; set; }
        public Rating? Rating { get; set; }
        public List<Excerpt>? Excerpts { get; set; }
        public Boolean Read { get; set; }
        public DateTime? ReadTimestamp { get; set; }
        public ReadingPriority? ReadingPriority { get; set; }
        public string? ReadingNotes { get; set; }
        public Boolean Available { get; set; }
        public DateTime? AvailableTimestamp { get; set; }
        public PurchasingPriority? PurchasingPriority { get; set; }
        public Format? Format { get; set; }
        public string? DownloadUrl { get; set; }
        public Boolean Summarized { get; set; }
        public DateTime? SummarizedTimestamp { get; set; }
        public SummarizingPriority? SummarizingPriority { get; set; }
        public string? SummaryNotes { get; set; }

    }
}