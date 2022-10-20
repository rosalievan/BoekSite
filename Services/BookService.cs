using BoekSite.Models.Database;
using BoekSite.Models.Request;
using BoekSite.Repositories;

namespace BoekSite.Services
{
    public interface IBookService
    {
        public IEnumerable<Book> GetAllBooks();
        public Book CreateBook(CreateBookRequest book);
        public Book GetBookById(int id);
        public void UpdateReadStatus(UpdateReadStatusRequest updateReadStatusRequest);
    }

    public class BookService : IBookService
    {
        private readonly IBookRepo _books;

        public BookService(IBookRepo books)
        {
            _books = books;
        }
        
        public IEnumerable<Book> GetAllBooks()
        {
            return _books.GetAllBooks();
        }
        public Book CreateBook(CreateBookRequest request)
        {
            var newBook = new Book{
                Author = request.Author,
                Title = request.Title,
                Genre = request.Genre,
                PhotoUrl = request.PhotoUrl,
                Rating = request.Rating,
                Read = request.Read,
                ReadTimestamp = request.ReadTimestamp,
                ReadingPriority = request.ReadingPriority,
                ReadingNotes = request.ReadingNotes,
                Available = request.Available,
                AvailableTimestamp = request.AvailableTimestamp,
                PurchasingPriority = request.PurchasingPriority,
                Format = request.Format,
                DownloadUrl = request.DownloadUrl,
                Summarized = request.Summarized,
                SummarizedTimestamp = request.SummarizedTimestamp,
                SummarizingPriority = request.SummarizingPriority,
                SummaryNotes = request.SummaryNotes

            };

            return _books.CreateBook(newBook);
        }

        public Book GetBookById(int id)
        {
            return _books.GetBookById(id);
        }

        public void UpdateReadStatus(UpdateReadStatusRequest updateReadStatusRequest)
        {
            _books.UpdateReadStatus(updateReadStatusRequest);
        }
    }
}
