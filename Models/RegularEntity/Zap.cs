namespace QUALITE.Models.RegularEntity;

public class Zap
{
	[Required(ErrorMessage ="Code ZAP obligatoire")]
	public int CodeZap {get;set;}
	public string? ZAP {get;set;}
};