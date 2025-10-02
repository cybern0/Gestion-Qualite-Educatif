namespace QUALITE.Models.RegularEntity;

public class Dren
{
	[Required(ErrorMessage ="Code DREN obligatoire")]
	public int CodeDren {get;set;}
	public string? DREN {get;set;}
};