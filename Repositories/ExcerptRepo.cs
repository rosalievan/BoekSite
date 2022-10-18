using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BoekSite.Models.Database;

namespace BoekSite.Repositories
{
    public interface IExcerptRepo
    {
        public IEnumerable<Excerpt> GetAllExcerpts();
        public IEnumerable<Excerpt> GetExcerptsByBookId(int id);
        public Excerpt CreateExcerpt (Excerpt createExcerptRequest);
    }

    public class ExcerptRepo : IExcerptRepo
    {
        private readonly BoekSiteDbContext _context;

        public ExcerptRepo(BoekSiteDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Excerpt> GetAllExcerpts()
        {
            return _context.Excerpts;
        }

        public IEnumerable<Excerpt> GetExcerptsByBookId(int id)
        {
           return  _context.Excerpts
           .Include(e => e.Book)
           .Where(e => e.Book.Id == id);
        }
        public Excerpt CreateExcerpt(Excerpt newExcerpt)
        {
            var insertedExcerpt = _context.Excerpts.Add(newExcerpt);
            _context.SaveChanges();
            return insertedExcerpt.Entity;
        }
    }
}
