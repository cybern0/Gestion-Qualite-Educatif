using QUALITE.Models.PrincipalEntity;
namespace QUALITE.Models.DerivedEntity;

public class ExamenServices : Etablissement, Indicateur
{
    public int GetIndicateur 
    { 
        get;
        set 
        {
            return 0;
        } 
    }
}