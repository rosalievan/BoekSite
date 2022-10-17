using Microsoft.AspNetCore.Mvc;

namespace BoekSite.Controllers;

[ApiController]
[Route("[controller]")]
public class BookController : ControllerBase
{
    


    // [HttpGet]
    // public IEnumerable<Books> Get()
    // {
    //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //     {
    //         Date = DateTime.Now.AddDays(index),
    //         TemperatureC = Random.Shared.Next(-20, 55),
    //         Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //     })
    //     .ToArray();
    // }
}
