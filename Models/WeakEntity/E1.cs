using  QUALITE.Models.PrincipalEntity;
using  QUALITE.Models.RegularEntity;
namespace QUALITE.Models.WeakEntity;

public class E1
{
	[Required(ErrorMessage ="Code E1 obligatoire")]
	public int Code {get;set;}
	[Required(ErrorMessage ="Code Etablissement obligatoire")]
	public int CodeEtab {get;set;}
    public Etablissement? Etablissement {get;set;}
	[Required(ErrorMessage ="Code FPE obligatoire")]
	public int CodeFpe {get;set;}
    public ModelFpe? ModelFpe {get;set;}
    public int EEC_G { get; set; }
	public int EEC_F { get; set; }
	public int CRECHE_G { get; set; }
	public int CRECHE_F { get; set; }
	public int PS_G { get; set; }
	public int PS_F { get; set; }
	public int MS_G { get; set; }
	public int MS_F { get; set; }
	public int GS_G { get; set; }
	public int GS_F { get; set; }
	public int T1_G { get; set; }
	public int T1_F { get; set; }
	public int T2_G { get; set; }
	public int T2_F { get; set; }
	public int T3_G { get; set; }
	public int T3_F { get; set; }
	public int T4_G { get; set; }
	public int T4_F { get; set; }
	public int T5_G { get; set; }
	public int T5_F { get; set; }
	public int CI_G { get; set; }
	public int CI_F { get; set; }
};