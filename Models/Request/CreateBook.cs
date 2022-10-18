using System;
using BoekSite.Models.Database;
using System.ComponentModel.DataAnnotations;

namespace BoekSite.Models.Request
{
    public class CreateBookRequest
    {
        public Author? Author { get; set; }

        public string Title { get; set; }
        public Genre? Genre { get; set; }
        public string? PhotoUrl { get; set; }
        public Rating? Rating { get; set; }
        
        [Required]
        public Boolean Read { get; set; }

        public ReadingPriority? ReadingPriority { get; set; }
        public string? ReadingNotes { get; set; }
        [Required]
        public Boolean Available { get; set; }
        public PurchasingPriority? PurchasingPriority { get; set; }
        public Format? Format { get; set; }
        public string? DownloadUrl { get; set; }
        [Required]
        public Boolean Summarized { get; set; }
        public SummarizingPriority? SummarizingPriority { get; set; }
        public string? SummaryNotes { get; set; }
        public DateTime? ReadTimestamp { get; set; }
        public DateTime? AvailableTimestamp { get; set; }

        public DateTime? SummarizedTimestamp { get; set; }
    }
}