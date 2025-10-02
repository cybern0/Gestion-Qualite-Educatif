namespace QUALITE.Models.RegularEntity;

public class Commune
{
	[Required(ErrorMessage ="Code Commune obligatoire")]
	public int CodeCommune { get; set; }
	public string? LibelleCommune {get;set;}
	public string? CategorieCommune {get;set;}
};