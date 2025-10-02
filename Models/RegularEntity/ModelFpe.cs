namespace QUALITE.Models.RegularEntity;

public class ModelFpe
{
	[Required(ErrorMessage ="Code FPE obligatoire")]
	public int Code {get;set;}
	public string? Libelle {get;set;}
};