namespace QUALITE.Models.RegularEntity;

public class Fonction
{
	[Required(ErrorMessage ="Code Fonction obligatoire")]
	public int CodeFonction {get;set;}
	public string? TypeFonction {get;set;}
};