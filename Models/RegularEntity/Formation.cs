namespace QUALITE.Models.RegularEntity;

public class Formation
{
	[Required(ErrorMessage ="Code Formation obligatoire")]
	public int CodeFormation {get;set;}
	public string? TypeFormation {get;set;}
};