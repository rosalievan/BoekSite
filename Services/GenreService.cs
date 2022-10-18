using BoekSite.Models.Database;
using BoekSite.Models.Request;
using BoekSite.Repositories;

namespace BoekSite.Services
{
    public interface IGenreService
    {
        public IEnumerable<Genre> GetAllGenres();
        public Genre CreateGenre (CreateGenreRequest request);
    }

    public class GenreService : IGenreService
    {
        private readonly IGenreRepo _Genres;

        public GenreService(IGenreRepo Genres)
        {
            _Genres = Genres;
        }

        public IEnumerable<Genre> GetAllGenres()
        {
            return _Genres.GetAllGenres();
        }
        public Genre CreateGenre(CreateGenreRequest request)
        {
            var newGenre = new Genre
            {
                Name = request.Name
            };

           return  _Genres.CreateGenre(newGenre);
        }
    }
}
