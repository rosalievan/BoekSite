using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BoekSite.Models.Database;

namespace BoekSite.Repositories
{
    public interface IGenreRepo
    {
        public IEnumerable<Genre> GetAllGenres();
        public Genre CreateGenre (Genre createGenreRequest);
    }

    public class GenreRepo : IGenreRepo
    {
        private readonly BoekSiteDbContext _context;

        public GenreRepo(BoekSiteDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            return _context.Genres;
        }
        public Genre CreateGenre(Genre newGenre)
        {
            var insertedGenre = _context.Genres.Add(newGenre);
            _context.SaveChanges();
            return insertedGenre.Entity;
        }
    }
}
