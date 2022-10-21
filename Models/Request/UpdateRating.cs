using BoekSite.Models.Database;

namespace BoekSite.Models.Request
{
    public class UpdateRatingRequest
    {
        public int BookId { get; set; }
        public int Rating { get; set; }
    }
}
