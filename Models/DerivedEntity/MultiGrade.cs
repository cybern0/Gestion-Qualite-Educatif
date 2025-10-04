using QUALITE.Models.PrincipalEntity;
namespace QUALITE.Models.DerivedEntity;

public class MultiGrade : Etablissement, Indicateur
{
    public int GetIndicateur{get;set;}
}