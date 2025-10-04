using QUALITE.Models.PrincipalEntity;
namespace QUALITE.Models.DerivedEntity;

public class Manuel : Etablissement, Indicateur
{
    public int GetIndicateur{get;set;}
}