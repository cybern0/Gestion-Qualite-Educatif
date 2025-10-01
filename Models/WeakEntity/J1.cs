using  QUALITE.Models.PrincipalEntity;
using  QUALITE.Models.RegularEntity;
namespace QUALITE.Models.WeakEntity;

public class J1
{
	public int Code {get;set;}
	public int CodeEtab {get;set;}
    public Etablissement? Etablissement {get;set;}
	public int CodeFpe {get;set;}
    public ModelFpe? ModelFpe {get;set;}
	public int SDC_EEC_BON_ETAT { get; set; }
	public int SDC_EEC_MAUVAIS_ETAT { get; set; }
	public int SDC_PRESCO_BON_ETAT { get; set; }
	public int SDC_PRESCO_MAUVAIS_ETAT { get; set; }
	public int SDC_PRIMAIRE_BON_ETAT { get; set; }
	public int SDC_PRIMAIRE_MAUVAIS_ETAT { get; set; }
	public int SDC_PRIMAIRE_2VAC_BON_ETAT { get; set; }
	public int SDC_PRIMAIRE_2VAC_MAUVAIS_ETAT { get; set; }
	public int SDC_PRIMAIRE_2FLUX_BON_ETAT { get; set; }
	public int SDC_PRIMAIRE_2FLUX_MAUVAIS_ETAT { get; set; }
	public int SDC_COLLEGE_BON_ETAT { get; set; }
	public int SDC_COLLEGE_MAUVAIS_ETAT { get; set; }
	public int SDC_LYCEE_BON_ETAT { get; set; }
	public int SDC_LYCEE_MAUVAIS_ETAT { get; set; }
};