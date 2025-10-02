namespace QUALITE.Models.RegularEntity;

public class Fokontany
{
	[Required(ErrorMessage ="Code FOKONTANY obligatoire")]
	public int CodeFokontany {get;set;}
	public string? FOKONTANY {get;set;}
};