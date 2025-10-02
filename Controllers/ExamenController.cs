using Microsoft.AspNetCore.Mvc;

namespace QUALITE.Controllers;

[ApiController]
[Route("etab")]
public class ExamenController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<ExamenController> _logger;

    public ExamenController(ILogger<ExamenController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Examen> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Examen
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
    [HttpGet("examen")]
    public IEnumerable<Examen> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Examen
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
