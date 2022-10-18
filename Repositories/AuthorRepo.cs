using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BoekSite.Models.Database;

namespace BoekSite.Repositories
{
    public interface IAuthorRepo
    {
        public IEnumerable<Author> GetAllAuthors();
        public Author CreateAuthor (Author createAuthorRequest);
    }

    public class AuthorRepo : IAuthorRepo
    {
        private readonly BoekSiteDbContext _context;

        public AuthorRepo(BoekSiteDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return _context.Authors;
        }
        public Author CreateAuthor(Author newAuthor)
        {
            var insertedAuthor = _context.Authors.Add(newAuthor);
            _context.SaveChanges();
            return insertedAuthor.Entity;
        }
    }
}
