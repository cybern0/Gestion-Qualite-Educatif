namespace QUALITE.Models.RegularEntity;

public class Sexe
{
	[Required(ErrorMessage ="Code type Sexe obligatoire")]
	public int CodeTypeSexe {get;set;}
	public char TypeSexe {get;set;}
};