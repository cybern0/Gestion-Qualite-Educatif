using System.ComponentModel.DataAnnotations;
using QUALITE.Models.PrincipalEntity;
using  QUALITE.Models.RegularEntity;
namespace QUALITE.Services.WeakServices;

public class K1Services
{
	[Required(ErrorMessage ="Code K1 obligatoire")]
	public int Code {get;set;}
	[Required(ErrorMessage ="Code Etablissement obligatoire")]
	public int CodeEtab {get;set;}
    public Etablissement? Etablissement {get;set;}
	[Required(ErrorMessage ="Code FPE obligatoire")]
	public int CodeFpe {get;set;}
    public ModelFpe? ModelFpe {get;set;}
    public int EEC_PETITES_CHAISES_BON_ETAT { get; set; }
	public int EEC_TABLES_BANCS_1PL_BON_ETAT { get; set; }
	public int EEC_TABLES_BANCS_2PL_BON_ETAT { get; set; }
	public int EEC_TABLES_BANCS_3PL_BON_ETAT { get; set; }
	public int EEC_TABLES_BANCS_4PL_BON_ETAT { get; set; }
	public int EEC_TABLES_BANCS_5PL_PLUS_BON_ETAT { get; set; }
	public int EEC_PETITES_CHAISES_MAUVAIS_ETAT { get; set; }
	public int EEC_TABLES_BANCS_1PL_MAUVAIS_ETAT { get; set; }
	public int EEC_TABLES_BANCS_2PL_MAUVAIS_ETAT { get; set; }
	public int EEC_TABLES_BANCS_3PL_MAUVAIS_ETAT { get; set; }
	public int EEC_TABLES_BANCS_4PL_MAUVAIS_ETAT { get; set; }
	public int EEC_TABLES_BANCS_5PL_PLUS_MAUVAIS_ETAT { get; set; }
	public int PRESCO_PETITES_CHAISES_BON_ETAT { get; set; }
	public int PRESCO_TABLES_BANCS_1PL_BON_ETAT { get; set; }
	public int PRESCO_TABLES_BANCS_2PL_BON_ETAT { get; set; }
	public int PRESCO_TABLES_BANCS_3PL_BON_ETAT { get; set; }
	public int PRESCO_TABLES_BANCS_4PL_BON_ETAT { get; set; }
	public int PRESCO_TABLES_BANCS_5PL_PLUS_BON_ETAT { get; set; }
	public int PRESCO_PETITES_CHAISES_MAUVAIS_ETAT { get; set; }
	public int PRESCO_TABLES_BANCS_1PL_MAUVAIS_ETAT { get; set; }
	public int PRESCO_TABLES_BANCS_2PL_MAUVAIS_ETAT { get; set; }
	public int PRESCO_TABLES_BANCS_3PL_MAUVAIS_ETAT { get; set; }
	public int PRESCO_TABLES_BANCS_4PL_MAUVAIS_ETAT { get; set; }
	public int PRESCO_TABLES_BANCS_5PL_PLUS_MAUVAIS_ETAT { get; set; }
	public int PRIMAIRE_TABLES_BANCS_1PL_BON_ETAT { get; set; }
	public int PRIMAIRE_TABLES_BANCS_2PL_BON_ETAT { get; set; }
	public int PRIMAIRE_TABLES_BANCS_3PL_BON_ETAT { get; set; }
	public int PRIMAIRE_TABLES_BANCS_4PL_BON_ETAT { get; set; }
	public int PRIMAIRE_TABLES_BANCS_5PL_PLUS_BON_ETAT { get; set; }
	public int PRIMAIRE_TABLES_BANCS_1PL_MAUVAIS_ETAT { get; set; }
	public int PRIMAIRE_TABLES_BANCS_2PL_MAUVAIS_ETAT { get; set; }
	public int PRIMAIRE_TABLES_BANCS_3PL_MAUVAIS_ETAT { get; set; }
	public int PRIMAIRE_TABLES_BANCS_4PL_MAUVAIS_ETAT { get; set; }
	public int PRIMAIRE_TABLES_BANCS_5PL_PLUS_MAUVAIS_ETAT { get; set; }
	public int CI_PETITES_CHAISES_BON_ETAT { get; set; }
	public int CI_TABLES_BANCS_1PL_BON_ETAT { get; set; }
	public int CI_TABLES_BANCS_2PL_BON_ETAT { get; set; }
	public int CI_TABLES_BANCS_3PL_BON_ETAT { get; set; }
	public int CI_TABLES_BANCS_4PL_BON_ETAT { get; set; }
	public int CI_TABLES_BANCS_5PL_PLUS_BON_ETAT { get; set; }
	public int CI_PETITES_CHAISES_MAUVAIS_ETAT { get; set; }
	public int CI_TABLES_BANCS_1PL_MAUVAIS_ETAT { get; set; }
	public int CI_TABLES_BANCS_2PL_MAUVAIS_ETAT { get; set; }
	public int CI_TABLES_BANCS_3PL_MAUVAIS_ETAT { get; set; }
	public int CI_TABLES_BANCS_4PL_MAUVAIS_ETAT { get; set; }
	public int CI_TABLES_BANCS_5PL_PLUS_MAUVAIS_ETAT { get; set; }
	public int COLLEGE_TABLES_BANCS_1PL_BON_ETAT { get; set; }
	public int COLLEGE_TABLES_BANCS_2PL_BON_ETAT { get; set; }
	public int COLLEGE_TABLES_BANCS_3PL_BON_ETAT { get; set; }
	public int COLLEGE_TABLES_BANCS_4PL_BON_ETAT { get; set; }
	public int COLLEGE_TABLES_BANCS_5PL_PLUS_BON_ETAT { get; set; }
	public int COLLEGE_TABLES_BANCS_1PL_MAUVAIS_ETAT { get; set; }
	public int COLLEGE_TABLES_BANCS_2PL_MAUVAIS_ETAT { get; set; }
	public int COLLEGE_TABLES_BANCS_3PL_MAUVAIS_ETAT { get; set; }
	public int COLLEGE_TABLES_BANCS_4PL_MAUVAIS_ETAT { get; set; }
	public int COLLEGE_TABLES_BANCS_5PL_PLUS_MAUVAIS_ETAT { get; set; }
	public int LYCEE_TABLES_BANCS_1PL_BON_ETAT { get; set; }
	public int LYCEE_TABLES_BANCS_2PL_BON_ETAT { get; set; }
	public int LYCEE_TABLES_BANCS_3PL_BON_ETAT { get; set; }
	public int LYCEE_TABLES_BANCS_4PL_BON_ETAT { get; set; }
	public int LYCEE_TABLES_BANCS_5PL_PLUS_BON_ETAT { get; set; }
	public int LYCEE_TABLES_BANCS_1PL_MAUVAIS_ETAT { get; set; }
	public int LYCEE_TABLES_BANCS_2PL_MAUVAIS_ETAT { get; set; }
	public int LYCEE_TABLES_BANCS_3PL_MAUVAIS_ETAT { get; set; }
	public int LYCEE_TABLES_BANCS_4PL_MAUVAIS_ETAT { get; set; }
	public int LYCEE_TABLES_BANCS_5PL_PLUS_MAUVAIS_ETAT { get; set; }
};