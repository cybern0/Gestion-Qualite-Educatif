namespace QUALITE.Models.RegularEntity;

public class Statut
{
	[Required(ErrorMessage ="Code statut obligatoire")]
	public int CodeStatut {get;set;}
	public string? TypeStatut {get;set;}
};