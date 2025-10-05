using System.ComponentModel.DataAnnotations;
using QUALITE.Models.PrincipalEntity;
using  QUALITE.Models.RegularEntity;
namespace QUALITE.Services.WeakServices;

public class M1Services
{
	[Required(ErrorMessage ="Code M1 obligatoire")]
	public int Code {get;set;}
	[Required(ErrorMessage ="Code Etablissement obligatoire")]
	public int CodeEtab {get;set;}
    public Etablissement? Etablissement {get;set;}
	[Required(ErrorMessage ="Code FPE obligatoire")]
	public int CodeFpe {get;set;}
    public ModelFpe? ModelFpe {get;set;}
    public int SERIE_A_INSCRITS_G { get; set; }
	public int SERIE_A_INSCRITS_F { get; set; }
	public int SERIE_A_ADMIS_G { get; set; }
	public int SERIE_A_ADMIS_F { get; set; }
	public int SERIE_C_INSCRITS_G { get; set; }
	public int SERIE_C_INSCRITS_F { get; set; }
	public int SERIE_C_ADMIS_G { get; set; }
	public int SERIE_C_ADMIS_F { get; set; }
	public int SERIE_D_INSCRITS_G { get; set; }
	public int SERIE_D_INSCRITS_F { get; set; }
	public int SERIE_D_ADMIS_G { get; set; }
	public int SERIE_D_ADMIS_F { get; set; }
	public int SERIE_L_INSCRITS_G { get; set; }
	public int SERIE_L_INSCRITS_F { get; set; }
	public int SERIE_L_ADMIS_G { get; set; }
	public int SERIE_L_ADMIS_F { get; set; }
	public int SERIE_S_INSCRITS_G { get; set; }
	public int SERIE_S_INSCRITS_F { get; set; }
	public int SERIE_S_ADMIS_G { get; set; }
	public int SERIE_S_ADMIS_F { get; set; }
	public int SERIE_OSE_INSCRITS_G { get; set; }
	public int SERIE_OSE_INSCRITS_F { get; set; }
	public int SERIE_OSE_ADMIS_G { get; set; }
	public int SERIE_OSE_ADMIS_F { get; set; }
};