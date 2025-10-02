namespace QUALITE.Models.RegularEntity;

public class Affiliation
{
	[Required(ErrorMessage ="Code Affiliation obligatoire")]
	public int CodeTypeAffiliation {get; set;}
	public string? TypeAffiliation {get;set;}
};