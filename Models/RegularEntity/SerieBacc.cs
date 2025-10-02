using System.ComponentModel.DataAnnotations;
namespace QUALITE.Models.RegularEntity;

public class SerieBacc
{
	[Required(ErrorMessage = "Code Serie BACC obligatoire")]
	public int Code { get; set; }
	public string? TypeSerieBacc { get; set; }
};