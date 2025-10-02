using Microsoft.AspNetCore.Mvc;
using QUALITE.Models.PrincipalEntity;

namespace QUALITE.Controllers;

[ApiController]
[Route("etab")]
public class ExamenController : ControllerBase
{
    private static readonly List<Etablissement> Etablissements = new List<Etablissement>
    {
        new Etablissement { CodeEtab = 1, CodeSecteur = 101, EXISTE_EEC = 1, EXISTE_PRESCO = 0, EXISTE_PRIMAIRE = 1, EXISTE_COLLEGE = 0, EXISTE_LYCEE = 0, CODE_DREN = 10, CODE_CISCO = 20, CODE_COMMUNE = 30, CODE_ZAP = 40, CODE_FOKONTANY = 50, VILLAGE = "Village A", NOM_ETAB = "Etablissement A" },
        new Etablissement { CodeEtab = 2, CodeSecteur = 102, EXISTE_EEC = 0, EXISTE_PRESCO = 1, EXISTE_PRIMAIRE = 0, EXISTE_COLLEGE = 1, EXISTE_LYCEE = 0, CODE_DREN = 11, CODE_CISCO = 21, CODE_COMMUNE = 31, CODE_ZAP = 41, CODE_FOKONTANY = 51, VILLAGE = "Village B", NOM_ETAB = "Etablissement B" },
        // Ajoutez plus d'éléments si nécessaire
    };

    private readonly ILogger<ExamenController> _logger;

    public ExamenController(ILogger<ExamenController> logger)
    {
        _logger = logger;
    }

    [HttpGet("examen")]
    public IEnumerable<Etablissement> Get()
    {
        return Etablissements.Select(e => new Etablissement
        {
            CodeEtab = e.CodeEtab,
            NOM_ETAB = e.NOM_ETAB
        });
    }
}