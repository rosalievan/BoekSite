using BoekSite.Models.Database;
using BoekSite.Models.Request;
using BoekSite.Repositories;

namespace BoekSite.Services
{
    public interface IAuthorService
    {
        public IEnumerable<Author> GetAllAuthors();
        public Author CreateAuthor (CreateAuthorRequest request);
    }

    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepo _authors;

        public AuthorService(IAuthorRepo authors)
        {
            _authors = authors;
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            return _authors.GetAllAuthors();
        }
        public Author CreateAuthor(CreateAuthorRequest request)
        {
            var newAuthor = new Author
            {
                FirstName = request.FirstName,
                LastName = request.LastName
            };

           return  _authors.CreateAuthor(newAuthor);
        }
    }
}
