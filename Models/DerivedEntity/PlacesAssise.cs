using QUALITE.Models.PrincipalEntity;
namespace QUALITE.Models.DerivedEntity;

public class PlacesAssise : Etablissement, Indicateur
{
    public int GetIndicateur()
    {
        return 1;
    }
}