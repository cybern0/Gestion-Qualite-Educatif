namespace QUALITE.Models.RegularEntity;

public class Partenaire
{
	[Required(ErrorMessage ="Code Partenaire obligatoire")]
	public int Code {get;set;}
	public string? TypePartenaire {get;set;}
};