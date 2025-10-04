using QUALITE.Models.PrincipalEntity;
namespace QUALITE.Models.DerivedEntity;

public class RES : Etablissement, Indicateur
{
    public int GetIndicateur{get;set;}
}