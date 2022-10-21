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

    [HttpPatch]
    public void UpdateReadStatus([FromBody] UpdateReadStatusRequest updateReadStatusRequest)
    {
        _books.UpdateReadStatus(updateReadStatusRequest);
    }

    [HttpPatch("updateAvailabilityStatus")]
    public void UpdateAvailabilityStatus([FromBody] UpdateAvailabilityStatusRequest updateAvailabilityStatusRequest)
    {
    _books.UpdateAvailabilityStatus(updateAvailabilityStatusRequest);
    }

    [HttpPatch("updateRating")]
    public void UpdateRating([FromBody] UpdateRatingRequest updateRatingRequest)
    {
        _books.UpdateRating(updateRatingRequest);
    }

}
