using QUALITE.Models.PrincipalEntity;
namespace QUALITE.Models.DerivedEntity;

public class Examen : Etablissement, Indicateur
{
    public int GetIndicateur{get;set;}
}