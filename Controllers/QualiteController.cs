using Microsoft.AspNetCore.Mvc;
using QUALITE.Services;
using QUALITE.Models.DerivedEntity;
namespace QUALITE.Controllers;

[ApiController]
[Route("qualite")]
public class ExamenController : ControllerBase
{
    private readonly ILogger<ExamenController> _logger;

    public ExamenController(ILogger<ExamenController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<Examen>> GetQuality()
    {
        return await ExamenServices.GetAll();
    }
    [HttpPost]
    public async Task<IActionResult> CreateQuality([FromBody] Examen examen)
    {
        if (examen == null)
        {
            return BadRequest();
        }

        // Call the service to create the examen
        // var result = await ExamenServices.Create(examen);
        // if (result)
        // {
        //     return CreatedAtAction(nameof(GetQuality), new { id = examen.CodeEtab }, examen);
        // }

        return StatusCode(500);
    }
}