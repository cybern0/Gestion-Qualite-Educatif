using Microsoft.AspNetCore.Mvc;
using QUALITE.Models.RegularEntity;
using QUALITE.Services;

namespace QUALITE.Controllers;

[ApiController]
[Route("etab")]
public class ExamenController : ControllerBase
{
    private static readonly List<Sexe> Sexes = ExamenServices.GetSexes();

    private readonly ILogger<ExamenController> _logger;

    public ExamenController(ILogger<ExamenController> logger)
    {
        _logger = logger;
    }

    [HttpGet("examen")]
    public IEnumerable<Sexe> Get()
    {
        return Sexes;
    }
}