using Microsoft.AspNetCore.Mvc;
using QUALITE.Models.;
using QUALITE.Services;

namespace QUALITE.Controllers;

[ApiController]
[Route("qualite")]
public class ExamenController : ControllerBase
{
    private static readonly List<Sexe> Sexes = ExamenServices.GetSexes();

    private readonly ILogger<ExamenController> _logger;

    public ExamenController(ILogger<ExamenController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Sexe> Get()
    {
        return Sexes;
    }
}