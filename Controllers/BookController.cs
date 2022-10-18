using Microsoft.AspNetCore.Mvc;
using BoekSite.Models.Database;
using BoekSite.Models.Response;
using BoekSite.Models.Request;
using BoekSite.Services;

namespace BoekSite.Controllers;

[ApiController]
[Route("/books")]
public class BookController : ControllerBase
{
    private readonly IBookService _books;

    public BookController(IBookService books)
    {
        _books = books;
    }

    [HttpGet]
    public IEnumerable<Book> GetAllBooks()
    {
        return _books.GetAllBooks();
    }

    [HttpGet("{id}")]
    public Book GetBookById([FromRoute]int id)
    {
        return _books.GetBookById(id);
    }

    [HttpPost]
    public CreateBookRequest CreateBook([FromBody] CreateBookRequest createBookRequest)
    {
        _books.CreateBook(createBookRequest);
        return createBookRequest;
    }
}
