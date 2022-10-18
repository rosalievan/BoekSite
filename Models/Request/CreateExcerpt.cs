using System.ComponentModel.DataAnnotations;
using BoekSite.Models.Database;

namespace BoekSite.Models.Request
{
    public class CreateExcerptRequest
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Book Book { get; set; }
    }
}
