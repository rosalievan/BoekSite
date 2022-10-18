using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using BoekSite.Models.Database;

namespace BoekSite.Repositories
{
    public interface IBookRepo
    {
        public IEnumerable<Book> GetAllBooks();
        public Book CreateBook(Book createBookRequest);
        public Book GetBookById(int id);

    }

    public class BookRepo : IBookRepo
    {
        private readonly BoekSiteDbContext _context;

        public BookRepo(BoekSiteDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books;
        }

        public Book CreateBook(Book newBook)
        {
            var insertedBook = _context.Books.Add(newBook);
            _context.SaveChanges();
            return insertedBook.Entity;
        }

        public Book GetBookById(int id)
        {
            return _context.Books.Where(b => b.Id == id).Single();
        }
    }
}
