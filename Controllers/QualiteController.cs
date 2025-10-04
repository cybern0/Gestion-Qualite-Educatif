using Microsoft.AspNetCore.Mvc;
using QUALITE.Services;

namespace QUALITE.Controllers;

[ApiController]
[Route("qualite")]
public class ExamenController : ControllerBase
{
    private static readonly List<ExamenServices> Examens = new List<ExamenServices>
    {
        new ExamenServices{ CodeEtab=1 },
        new ExamenServices{ CodeEtab=2 }
    };

    private readonly ILogger<ExamenController> _logger;

    public ExamenController(ILogger<ExamenController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<ExamenServices> Get()
    {
        return Examens;
    }
}