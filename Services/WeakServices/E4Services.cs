using System.ComponentModel.DataAnnotations;
using QUALITE.Models.PrincipalEntity;
using  QUALITE.Models.RegularEntity;
namespace QUALITE.Services.WeakServices;

public class E4Services
{
	[Required(ErrorMessage ="Code E4 obligatoire")]
	public int Code {get;set;}
	[Required(ErrorMessage ="Code Etablissement obligatoire")]
	public int CodeEtab {get;set;}
    public Etablissement? Etablissement {get;set;}
	[Required(ErrorMessage ="Code FPE obligatoire")]
	public int CodeFpe {get;set;}
    public ModelFpe? ModelFpe {get;set;}
    public int T6_G { get; set; }
	public int T6_F { get; set; }
	public int T7_G { get; set; }
	public int T7_F { get; set; }
	public int T8_G { get; set; }
	public int T8_F { get; set; }
	public int T9_G { get; set; }
	public int T9_F { get; set; }
	public int _2NDE_G { get; set; }
	public int _2NDE_F { get; set; }
	public int _1A_G { get; set; }
	public int _1A_F { get; set; }
	public int _1C_G { get; set; }
	public int _1C_F { get; set; }
	public int _1D_G { get; set; }
	public int _1D_F { get; set; }
	public int _1L_G { get; set; }
	public int _1L_F { get; set; }
	public int _1S_G { get; set; }
	public int _1S_F { get; set; }
	public int _1OSE_G { get; set; }
	public int _1OSE_F { get; set; }
	public int TA_G { get; set; }
	public int TA_F { get; set; }
	public int TC_G { get; set; }
	public int TC_F { get; set; }
	public int TD_G { get; set; }
	public int TD_F { get; set; }
	public int TL_G { get; set; }
	public int TL_F { get; set; }
	public int TS_G { get; set; }
	public int TS_F { get; set; }
	public int TOSE_G { get; set; }
	public int TOSE_F { get; set; }
};