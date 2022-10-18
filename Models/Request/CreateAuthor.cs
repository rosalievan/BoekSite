using BoekSite.Models.Database;
using System.ComponentModel.DataAnnotations;

namespace BoekSite.Models.Request
{
    public class CreateAuthorRequest
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}