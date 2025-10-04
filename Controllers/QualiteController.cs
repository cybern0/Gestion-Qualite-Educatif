using Microsoft.AspNetCore.Mvc;
using QUALITE.Models.DerivedEntity;
using QUALITE.Services;

namespace QUALITE.Controllers;

[ApiController]
[Route("qualite")]
public class ExamenController : ControllerBase
{
    private static readonly List<Examen> Examens = new List<Examen>
    {
        new Examen{ CodeEtab=1, },
        new Examen{ CodeEtab=2, }
    };//ExamenServices.GetSexes();

    private readonly ILogger<ExamenController> _logger;

    public ExamenController(ILogger<ExamenController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Examen> Get()
    {
        return Examens;
    }
}