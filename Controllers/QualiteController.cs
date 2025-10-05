using Microsoft.AspNetCore.Mvc;
using QUALITE.Services.WeakServices;
using QUALITE.Services.DerivedServices;
using QUALITE.Models.DerivedEntity;
using QUALITE.Services.PrincipalServices;
using QUALITE.Models;
namespace QUALITE.Controllers;

[ApiController]
[Route("qualite")]
public class QualiteController : ControllerBase
{
    private readonly ILogger<QualiteController> _logger;

    public QualiteController(ILogger<QualiteController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IEnumerable<Examen>> GetQuality()
    {
        return await ExamenServices.GetAll();
    }
    [HttpPost]
    public async Task<IActionResult> CreateQuality([FromBody] Payloads p)
    {
        if (p == null)
        {
            return BadRequest();
        }

        // Call the service to create the p
        var result = await EtablissementServices.Create(p.Etablissement) &&
                     await PersonnelServices.Create(p.Personnel) &&
                     await M1Services.Create(p.M1) &&
                     await E1Services.Create(p.E1) &&
                     await E4Services.Create(p.E4) &&
                     await K1Services.Create(p.K1) &&
                     await G1Services.Create(p.G1) &&
                     await J1Services.Create(p.J1) &&
                     await L1Services.Create(p.L1) &&
                     await ModelFpeServices.Create(p.ModelFpe);
        if (result)
        {
            return CreatedAtAction(nameof(GetQuality), new { id = p.Etablissement?.CodeEtab }, p);
        }

        return StatusCode(500);
    }
}