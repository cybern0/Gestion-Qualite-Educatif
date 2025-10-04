using QUALITE.Models.PrincipalEntity;
namespace QUALITE.Models.DerivedEntity;

public class REM : Etablissement, Indicateur
{
    public int GetIndicateur()
    {
        return 1;
    }
}