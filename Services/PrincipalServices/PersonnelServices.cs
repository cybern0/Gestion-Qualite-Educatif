using System.ComponentModel.DataAnnotations;
using QUALITE.Models.RegularEntity;

namespace QUALITE.Services.PrincipalServices;

public class PersonnelSevices
{
	[Required(ErrorMessage ="CIN obligatoire")]
	public int CIN {get;set;}
	public int CODE_ETAB {get;set;}
	public Etablissement? Etablissement {get;set;}
	public string? PASSEPORT {get;set;}
	public string? NOM_PRENOMS {get;set;}
	public DateTime? DATE_NAISS {get;set;}
	public int CODE_DISTRICT_NAISSANCE {get;set;}
	public District? DISTRICT_NAISSANCE {get;set;}
	public int SEXE {get;set;}
	public Sexe? Sexe {get;set;}
	public int CODE_FONCTION {get;set;}
	public Fonction? Fonction {get;set;}
	public int CODE_STATUT {get;set;}
	public Statut? Statut {get;set;}
	public DateTime? AGENT_ETAT_ENTREE_ADMINISTRATION {get;set;}
	public int DIPLOME_ACADEMIQUE {get;set;}
	public Diplome? Diplome {get;set;}
	public int SERIE_BACC {get;set;}
	public SerieBacc? SerieBacc {get;set;}
	public string? DIPLOME_PEDAGOGIQUE {get;set;}
	public int NIVEAU_TENU_EEC {get;set;}
	public int NIVEAU_TENU_PRESCO {get;set;}
	public int NIVEAU_TENU_PRIMAIRE {get;set;}
	public int NIVEAU_TENU_COLLEGE {get;set;}
	public int NIVEAU_TENU_LYCEE {get;set;}
	public int FORMATION_PRESCO {get;set;}
	public int CODE_FORMATION_1_DOMAINE {get;set;}
	public Formation? Formation_1 {get;set;}
	public int CODE_FORMATION_2_DOMAINE {get;set;}
	public Formation? Formation_2 {get;set;}
	public int CODE_FORMATION_3_DOMAINE {get;set;}
	public Formation? Formation_3 {get;set;}
	public int CODE_FORMATION_4_DOMAINE {get;set;}
	public Formation? Formation_4 {get;set;}
};