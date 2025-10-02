using  QUALITE.Models.RegularEntity;
namespace QUALITE.Models.PrincipalEntity;

using System.ComponentModel.DataAnnotations;

public class Etablissement
{
	[Required(ErrorMessage ="Code Etablissement obligatoire")]
	public int CodeEtab {get;set;}
	public int CodeSecteur {get;set;}
	public Secteur? Secteur {get;set;}
	public int EXISTE_EEC {get;set;}
	public int EXISTE_PRESCO {get;set;}
	public int EXISTE_PRIMAIRE {get;set;}
	public int EXISTE_COLLEGE 	{get;set;}
	public int EXISTE_LYCEE {get;set;}
	public int CODE_DREN {get;set;}
	public Dren? Dren {get;set;}
	public int CODE_CISCO {get;set;}
	public District? Cisco{get;set;}
	public int CODE_COMMUNE {get;set;}
	public Commune? Commune {get;set;}
	public int CODE_ZAP {get;set;}
	public Zap? Zap {get;set;}
	public int CODE_FOKONTANY {get;set;}
	public Fokontany? Fokontany {get;set;}
	public string? VILLAGE {get;set;}
	public string? NOM_ETAB {get;set;}
};