using BoekSite.Models.Database;
using BoekSite.Models.Request;
using BoekSite.Repositories;

namespace BoekSite.Services
{
    public interface IExcerptService
    {
        public IEnumerable<Excerpt> GetAllExcerpts();
        public IEnumerable<Excerpt> GetAllExcerptsByBookId(int id);
        public Excerpt CreateExcerpt (CreateExcerptRequest request);
    }

    public class ExcerptService : IExcerptService
    {
        private readonly IExcerptRepo _excerpts;

        public ExcerptService(IExcerptRepo excerpts)
        {
            _excerpts = excerpts;
        }

        public IEnumerable<Excerpt> GetAllExcerpts()
        {
            return _excerpts.GetAllExcerpts();
        }

        public IEnumerable<Excerpt> GetAllExcerptsByBookId(int id)
        {
            return _excerpts.GetExcerptsByBookId(id);
        }
        public Excerpt CreateExcerpt(CreateExcerptRequest request)
        {
            var newExcerpt = new Excerpt
            {
                Text = request.Text,
                Book = request.Book
            };

           return  _excerpts.CreateExcerpt(newExcerpt);
        }
    }
}
