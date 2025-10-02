
using  QUALITE.Models.PrincipalEntity;
using  QUALITE.Models.RegularEntity;
namespace QUALITE.Models.WeakEntity;

public class G1
{
	[Required(ErrorMessage ="Code G1 obligatoire")]
	public int Code {get;set;}
	[Required(ErrorMessage ="Code Etablissement obligatoire")]
	public int CodeEtab {get;set;}
    public Etablissement? Etablissement {get;set;}
	[Required(ErrorMessage ="Code FPE obligatoire")]
	public int CodeFpe {get;set;}
    public ModelFpe? ModelFpe {get;set;}
    public int EEC_SECTION { get; set; }
	public int CRECHE_SECTION { get; set; }
	public int PS_SECTION { get; set; }
	public int MS_SECTION { get; set; }
	public int GS_SECTION { get; set; }
	public int T1_SECTION { get; set; }
	public int T2_SECTION { get; set; }
	public int T3_SECTION { get; set; }
	public int T4_SECTION { get; set; }
	public int T5_SECTION { get; set; }
	public int CI_SECTION { get; set; }
	public int T6_SECTION { get; set; }
	public int T7_SECTION { get; set; }
	public int T8_SECTION { get; set; }
	public int T9_SECTION { get; set; }
	public int _2NDE_SECTION { get; set; }
	public int _1A_SECTION { get; set; }
	public int _1C_SECTION { get; set; }
	public int _1D_SECTION { get; set; }
	public int _1L_SECTION { get; set; }
	public int _1S_SECTION { get; set; }
	public int _1OSE_SECTION { get; set; }
	public int TA_SECTION { get; set; }
	public int TC_SECTION { get; set; }
	public int TD_SECTION { get; set; }
	public int TL_SECTION { get; set; }
	public int TS_SECTION { get; set; }
	public int TOSE_SECTION { get; set; }
	public int T1_SECTION_MULTIGRADE_1_EFFECTIF { get; set; }
	public int T2_SECTION_MULTIGRADE_1_EFFECTIF { get; set; }
	public int T3_SECTION_MULTIGRADE_1_EFFECTIF { get; set; }
	public int T4_SECTION_MULTIGRADE_1_EFFECTIF { get; set; }
	public int T5_SECTION_MULTIGRADE_1_EFFECTIF { get; set; }
	public int T1_SECTION_MULTIGRADE_2_EFFECTIF { get; set; }
	public int T2_SECTION_MULTIGRADE_2_EFFECTIF { get; set; }
	public int T3_SECTION_MULTIGRADE_2_EFFECTIF { get; set; }
	public int T4_SECTION_MULTIGRADE_2_EFFECTIF { get; set; }
	public int T5_SECTION_MULTIGRADE_2_EFFECTIF { get; set; }
	public int T1_SECTION_MULTIGRADE_3_EFFECTIF { get; set; }
	public int T2_SECTION_MULTIGRADE_3_EFFECTIF { get; set; }
	public int T3_SECTION_MULTIGRADE_3_EFFECTIF { get; set; }
	public int T4_SECTION_MULTIGRADE_3_EFFECTIF { get; set; }
	public int T5_SECTION_MULTIGRADE_3_EFFECTIF { get; set; }
};