using System.ComponentModel.DataAnnotations;

namespace BoekSite.Models.Request
{
    public class CreateGenreRequest
    {
        [Required]
        public string? Name { get; set; }
    }
}
